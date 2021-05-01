using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geriSayim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; // thread da iken ui erişimi için.
        }
        Thread saatGuncelleme;
        private void Form1_Load(object sender, EventArgs e)
        {            
            for (int i = 0; i <= 24; i++)
            {
                cmbSaat.Items.Add(i);
            }

            for (int i = 0; i <= 60; i++)
            {
                cmbDakika.Items.Add(i);
                cmbSaniye.Items.Add(i);
                cmbGun.Items.Add(i);
            }

            cmbGun.SelectedIndex = 0;
            cmbSaat.SelectedIndex = 0;
            cmbDakika.SelectedIndex = 0;
            cmbSaniye.SelectedIndex = 0;
            cmbsecim.SelectedIndex = 0;

        }
        
        int gun = 0;
        int saat = 0;
        int dakika = 0;
        int saniye = 0;
        bool acikKapali = false;
        private void button1_Click(object sender, EventArgs e)
        {          
            
            if ((int)cmbGun.Items[cmbGun.SelectedIndex] == 0 && (int)cmbSaat.Items[cmbSaat.SelectedIndex] == 0 && (int)cmbDakika.Items[cmbDakika.SelectedIndex] == 0 && (int)cmbSaniye.Items[cmbSaniye.SelectedIndex] == 0)
            {
                MessageBox.Show("Zaman Belirtin.");
            }
            else
            {
                if(!acikKapali)
                {                    
                    gun = (int)cmbGun.Items[cmbGun.SelectedIndex];
                    saat = (int)cmbSaat.Items[cmbSaat.SelectedIndex];
                    dakika = (int)cmbDakika.Items[cmbDakika.SelectedIndex];
                    saniye = (int)cmbSaniye.Items[cmbSaniye.SelectedIndex];
                    saatGuncelleme = new Thread(saatGuncelle);
                    saatGuncelleme.Start();
                    acikKapali = true;
                }
                else
                {
                    if(MessageBox.Show("Zaten Geri Sayım Açık Kapatılsın Mı ?","Geri Sayım", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            saatGuncelleme.Abort();
                            acikKapali = false; // thread kapatıldı.
                        }
                        catch (ThreadAbortException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                   
                }
                
            }
        }
        
        void saatGuncelle()
        {
            while (true)
            {
                //saniye sıfır ise saniyeyi den daha çıkarma yapmamış olup eksilere gitmesini önlemiş oluruz.
                if (saniye != 0)
                {
                    Thread.Sleep(1000);
                    saniye -= 1;
                }

                if (saniye == 0 && dakika == 0 && saat == 0 && gun == 0) // saniye dakika saat, gun sıfırlandığında geri sayım bitmiş demektir.
                {
                    lbldurum.Text = "Kalan Zaman: Saat:" + saat + " Dakika:" + dakika + " Saniye:" + saniye + " Tamamlandı.";
                    Thread.Sleep(2000);// Kullanıcının tamamlandı yazısını görebilmesi için 2 saniye daha bekletiyorum.
                    if(cmbsecim.SelectedIndex == 0)
                        Shutdown("1"); // Bilgisayarı Kapat.                          
                    else
                        Shutdown("2"); // Yeniden Başlat.
                    break; // İş parçacığını(Thread) sonlandırmak için. döngüden break ile çıkış yapıyoruz.
                    
                }
                else
                    lbldurum.Text = "Kalan Zaman: Gün:"+gun+" Saat:" + saat + " Dakika:" + dakika + " Saniye:" + saniye + "";

                if (saniye <= 0) // saniye 0 eşit veya her ihtimale karşı 0 dan küçük ise.
                {

                    if (dakika != 0) // dakika var mı kontrol et varsa saniye 60 ver dakikadan 1 azalt. Bu sayede zamanı sadece 1 saniyeler ile bitirebiliyoruz.
                    {
                        dakika -= 1;
                        saniye = 60;
                    }
                    else // dakika yoksa saati kontrol et.
                    {
                        if (saat != 0) // saat var mı varsa dakikaya 60 ver saatten bir azalt.
                        {
                            saat -= 1;
                            dakika = 60;
                        }
                        else
                        {
                            if (gun != 0)
                            {
                                gun -= 1;
                                saat = 24;
                            }
                            else
                            {
                                //kontrol bitişi. // yıl gibi devam edebilir :)
                            }
                        }
                    }
                }
            }
        }
      

        public void Shutdown(string flag) // Bilgisayarı Kapatma, Yeniden Başlatma Flag 1 kapatır 2 Yeniden Başlatır.
        {
            ManagementBaseObject mboShutdown = null;
            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();

            mcWin32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject mboShutdownParams =
                     mcWin32.GetMethodParameters("Win32Shutdown");

            mboShutdownParams["Flags"] = flag;
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown",
                                               mboShutdownParams, null);
            }
        }
    }
}
