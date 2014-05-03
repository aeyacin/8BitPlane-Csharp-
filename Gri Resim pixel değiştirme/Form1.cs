using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Gri_Resim_pixel_değiştirme
{
    public partial class Form1 : Form
    {

        byte[] bayt;
        String resimyolu;
        Bitmap resim ;
        Color renk ;
        int kirmizi;
        int yesil;
        int mavi;
        string[] binary;

        public Form1()
        {
            InitializeComponent();
        }

       

    
       public void bitplane()
        {
            Char[] karakter = new char[8];
            //   string[] karakter = new string[8];
            OpenFileDialog resimsec = new OpenFileDialog();

            resimsec.Title = "Lütfen Bir Gri Resim Seçiniz";
            resimsec.Filter = " (*.jpg)|*.jpg|(*.png)|*.png";
            if (resimsec.ShowDialog() == DialogResult.OK)
            {

                var orjinalGoruntu = new Bitmap(resimsec.OpenFile());
                this.pictureBox1.Image = orjinalGoruntu;
                var goruntuGenislik = orjinalGoruntu.Width;
                var goruntuYukseklik = orjinalGoruntu.Height;

                var piksellestirilmisGoruntu = new Bitmap(goruntuGenislik, goruntuYukseklik);
                var piksellestirilmisGoruntu1 = new Bitmap(goruntuGenislik, goruntuYukseklik);
                var piksellestirilmisGoruntu2 = new Bitmap(goruntuGenislik, goruntuYukseklik);
                var piksellestirilmisGoruntu3 = new Bitmap(goruntuGenislik, goruntuYukseklik);
                var piksellestirilmisGoruntu4 = new Bitmap(goruntuGenislik, goruntuYukseklik);
                var piksellestirilmisGoruntu5 = new Bitmap(goruntuGenislik, goruntuYukseklik);
                var piksellestirilmisGoruntu6 = new Bitmap(goruntuGenislik, goruntuYukseklik);
                var piksellestirilmisGoruntu7 = new Bitmap(goruntuGenislik, goruntuYukseklik);

                for (var i = 0; i < goruntuGenislik; i++)
                {
                    for (var j = 0; j < goruntuYukseklik; j++)
                    {

                        var piksel = orjinalGoruntu.GetPixel(i, j);

                        if (piksel.R != piksel.G && piksel.G != piksel.B)
                        {
                            MessageBox.Show("Lütfen gri resim seçiniz");
                            return;
                        }

                        var renkliPiksel = Color.FromArgb((int)(piksel.R), (int)(piksel.G), (int)(piksel.B));
                        var renkliPiksel1 = Color.FromArgb((int)(piksel.R), (int)(piksel.G), (int)(piksel.B));
                        var renkliPiksel2 = Color.FromArgb((int)(piksel.R), (int)(piksel.G), (int)(piksel.B));
                        var renkliPiksel3 = Color.FromArgb((int)(piksel.R), (int)(piksel.G), (int)(piksel.B));
                        var renkliPiksel4 = Color.FromArgb((int)(piksel.R), (int)(piksel.G), (int)(piksel.B));
                        var renkliPiksel5 = Color.FromArgb((int)(piksel.R), (int)(piksel.G), (int)(piksel.B));
                        var renkliPiksel6 = Color.FromArgb((int)(piksel.R), (int)(piksel.G), (int)(piksel.B));
                        var renkliPiksel7 = Color.FromArgb((int)(piksel.R), (int)(piksel.G), (int)(piksel.B));
                        var binary = Convert.ToString(piksel.R, 2);
                        binary = binary.PadLeft(8, '0');
                        binary = binary.PadRight(8, '0');

                        karakter = binary.ToCharArray();

                        //   MessageBox.Show(binary.ToString()+"-"+piksel.R+"-"+karakter[7]);


                        if (karakter[7] == '0')
                        {
                            renkliPiksel = Color.FromArgb(0, 0, 0);
                        }
                        else if (karakter[7] == '1')
                        {
                            renkliPiksel = Color.FromArgb(255, 255, 255);
                        }
                        if (karakter[6] == '0')
                        {
                            renkliPiksel1 = Color.FromArgb(0, 0, 0);
                        }
                        else if (karakter[6] == '1')
                        {
                            renkliPiksel1 = Color.FromArgb(255, 255, 255);
                        }
                        if (karakter[5] == '0')
                        {
                            renkliPiksel2 = Color.FromArgb(0, 0, 0);
                        }
                        else if (karakter[5] == '1')
                        {
                            renkliPiksel2 = Color.FromArgb(255, 255, 255);
                        }
                        if (karakter[4] == '0')
                        {
                            renkliPiksel3 = Color.FromArgb(0, 0, 0);
                        }
                        else if (karakter[4] == '1')
                        {
                            renkliPiksel3 = Color.FromArgb(255, 255, 255);
                        }
                        if (karakter[3] == '0')
                        {
                            renkliPiksel4 = Color.FromArgb(0, 0, 0);
                        }
                        else if (karakter[3] == '1')
                        {
                            renkliPiksel4 = Color.FromArgb(255, 255, 255);
                        }
                        if (karakter[2] == '0')
                        {
                            renkliPiksel5 = Color.FromArgb(0, 0, 0);
                        }
                        else if (karakter[2] == '1')
                        {
                            renkliPiksel5 = Color.FromArgb(255, 255, 255);
                        }
                        if (karakter[1] == '0')
                        {
                            renkliPiksel6 = Color.FromArgb(0, 0, 0);
                        }
                        else if (karakter[1] == '1')
                        {
                            renkliPiksel6 = Color.FromArgb(255, 255, 255);
                        }
                        if (karakter[0] == '0')
                        {
                            renkliPiksel7 = Color.FromArgb(0, 0, 0);
                        }
                        else if (karakter[0] == '1')
                        {
                            renkliPiksel7 = Color.FromArgb(255, 255, 255);
                        }
                       

                        piksellestirilmisGoruntu.SetPixel(i, j, renkliPiksel);
                        piksellestirilmisGoruntu1.SetPixel(i, j, renkliPiksel1);
                        piksellestirilmisGoruntu2.SetPixel(i, j, renkliPiksel2);
                        piksellestirilmisGoruntu3.SetPixel(i, j, renkliPiksel3);
                        piksellestirilmisGoruntu4.SetPixel(i, j, renkliPiksel4);
                        piksellestirilmisGoruntu5.SetPixel(i, j, renkliPiksel5);
                        piksellestirilmisGoruntu6.SetPixel(i, j, renkliPiksel6);
                        piksellestirilmisGoruntu7.SetPixel(i, j, renkliPiksel7);

                    }
                }

                pictureBox9.Image = piksellestirilmisGoruntu;
                pictureBox8.Image = piksellestirilmisGoruntu1;
                pictureBox7.Image = piksellestirilmisGoruntu2;
                pictureBox6.Image = piksellestirilmisGoruntu3;
                pictureBox5.Image = piksellestirilmisGoruntu4;
                pictureBox4.Image = piksellestirilmisGoruntu5;
                pictureBox3.Image = piksellestirilmisGoruntu6;
                pictureBox2.Image = piksellestirilmisGoruntu7;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bitplane();
        }

      
        
    }
}
