using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintOdev
{
    public partial class Form1 : Form
    {
        public string SecilenButon;
        int maxSekilSayisi = 1000;
        public Color SeciliRenk = Color.Brown;
        Graphics cizimAraci;
        Sekil[] sekiller;
        int sekilsayisi = 0;
        bool cizimAktifmi = false;
        Sekil AktifSekil = null;
        public Bitmap bmp;


        public Form1()
        {

            InitializeComponent();
            sekiller = new Sekil[maxSekilSayisi];//bakılacak
            Text = "Paint Projesi";
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            DoubleBuffered = true;
        }



        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            cizimAktifmi = false;

            if (sekilsayisi != maxSekilSayisi - 1)
            {
                sekiller[sekilsayisi] = AktifSekil;
                sekilsayisi++;
                // panel2.Invalidate();
            }
        }


        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (cizimAktifmi)
            {
                AktifSekil.BitisAta(e.X, e.Y);
                panel2.Invalidate();

            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            for (int i = 0; i < sekilsayisi; i++)
            {
                if (sekiller[i].Secme(e.X, e.Y))
                {


                }

            }
            if (SecilenButon == "Kare")
            {
                AktifSekil = new Kare(SeciliRenk);
            }
            if (SecilenButon == "Daire")
            {
                AktifSekil = new Daire(SeciliRenk);

            }
            if (SecilenButon == "Altıgen")
            {
                AktifSekil = new Altıgen(SeciliRenk);

            }
            if (SecilenButon == "Ucgen")
            {
                AktifSekil = new Ucgen(SeciliRenk);

            }
            cizimAktifmi = true;
            AktifSekil.X = e.X;
            AktifSekil.Y = e.Y;

            panel2.Invalidate();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            cizimAraci = e.Graphics;

            if (SecilenButon == "Kare")
            {
                if (AktifSekil != null)
                    AktifSekil.Ciz(cizimAraci);

            }
            if (SecilenButon == "Daire")
            {
                if (AktifSekil != null)
                    AktifSekil.Ciz(cizimAraci);

            }
            if (SecilenButon == "Altıgen")
            {
                if (AktifSekil != null)
                    AktifSekil.Ciz(cizimAraci);

            }

            if (SecilenButon == "Ucgen")
            {
                if (AktifSekil != null)
                    AktifSekil.Ciz(cizimAraci);

            }


            for (int i = 0; i < sekilsayisi; i++)
            {
                sekiller[i].Ciz(cizimAraci);

            }
        }

        private void button2_Click(object sender, EventArgs e)//karebutonu
        {

            SecilenButon = "Kare";
        }

        private void button4_Click(object sender, EventArgs e)//daire butonu
        {
            SecilenButon = "Daire";
        }

        private void button3_Click(object sender, EventArgs e)//altıgen butonu
        {
            SecilenButon = "Altıgen";
        }

        private void button1_Click(object sender, EventArgs e)//üçgen butonu
        {
            SecilenButon = "Ucgen";
        }

        private void button16_Click(object sender, EventArgs e)//koordinatlı kaydet
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Metin Belgesi|*.txt";
            try
            {
               if (file.ShowDialog() == DialogResult.OK)
                {
                    string dsyyl = file.FileName;
                    FileStream fs = new FileStream(dsyyl, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    for (int i = 0; i < sekilsayisi; i++)
                    {
                        if (SecilenButon == "Ucgen")
                        {
                            sw.WriteLine("Ucgen" + " " + sekiller[i].X + " " + sekiller[i].Y + " "+SeciliRenk.Name);
                        }
                        if (SecilenButon == "Daire")
                        {
                            sw.WriteLine("Daire" + " " + sekiller[i].X + " " + sekiller[i].Y + " " +SeciliRenk.Name);
                        }
                        if (SecilenButon == "Altıgen")
                        {
                            sw.WriteLine("Altıgen" + " " + sekiller[i].X + " " + sekiller[i].Y + " " + SeciliRenk.Name);
                        }
                        if (SecilenButon == "Kare")
                        {
                            sw.WriteLine("Kare" + " " + sekiller[i].X + " " + sekiller[i].Y + " " + SeciliRenk.Name);
                        }
                     }
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
    }
            catch
            {
                MessageBox.Show("Dosya kaydedilemedi.Lütfen tekrar deneyin");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SeciliRenk = button5.BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SeciliRenk = button6.BackColor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SeciliRenk = button7.BackColor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SeciliRenk = button8.BackColor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SeciliRenk = button9.BackColor;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SeciliRenk = button10.BackColor;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SeciliRenk = button11.BackColor;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SeciliRenk = button12.BackColor;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SeciliRenk = button13.BackColor;
        }
       
        private void button17_Click(object sender, EventArgs e)//dosya ac
        {
         /*   try
            {
                OpenFileDialog dsy_ac = new OpenFileDialog();
                dsy_ac.Filter = "Png files|*.png|jgep files|*.jpg|bitmaps|*.bmp";
                if(dsy_ac.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    Array.Clear(sekiller, 0, sekiller.Length);
                    panel2.Invalidate();
                     Image.FromFile(dsy_ac.FileName).Clone();
                 }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tekrar deneyiniz." + ex.Message);
            }  */
        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        public void button18_Click(object sender, EventArgs e)//PNG KAYDET
        {
            Bitmap bitmap = new Bitmap(panel2.Width, panel2.Height);
            Graphics cizimaraci = Graphics.FromImage(bitmap);
            Rectangle kaydet = panel2.RectangleToScreen(panel2.ClientRectangle);
            cizimaraci.CopyFromScreen(kaydet.Location, Point.Empty, panel2.Size);
            
            SaveFileDialog kaydett= new SaveFileDialog();
            kaydett.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*bmp";
            if (kaydett.ShowDialog() == DialogResult.OK)
            {
                if(File.Exists(kaydett.FileName))
                {
                    File.Delete(kaydett.FileName);
                }
                if(kaydett.FileName.Contains(".jpg"))
                {
                    bitmap.Save(kaydett.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                }
                else if(kaydett.FileName.Contains(".png"))
                {
                    bitmap.Save(kaydett.FileName, System.Drawing.Imaging.ImageFormat.Png);

                }
                else if(kaydett.FileName.Contains(".bmp"))
                {
                    bitmap.Save(kaydett.FileName, System.Drawing.Imaging.ImageFormat.Bmp);

                }
            }
        }
    }

}