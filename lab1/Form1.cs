using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog image1 = new OpenFileDialog();
            image1.Title = "select the image";
            image1.Filter = "All Image|*.*";

            if (image1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(image1.FileName);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //red image
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bitr = new Bitmap(bit.Width, bit.Height);

            Color p;


            for (int y = 0; y < bitr.Height; y++)
            {
                for (int x = 0; x < bitr.Width; x++)
                {
                    p = bit.GetPixel(x, y);

                    p = Color.FromArgb(p.A, p.R, 0, 0);
                    bitr.SetPixel(x, y, p);

                }
            }
            pictureBox3.Image = bitr;


        }
        private void button4_Click(object sender, EventArgs e)
        {
            //grea image
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = 0; y < bit2.Height; y++)
            {
                for (int x = 0; x < bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);

                    p = Color.FromArgb(p.A, ((p.B + p.G + p.R) / 3), ((p.B + p.G + p.R) / 3), ((p.B + p.G + p.R) / 3));
                    bit2.SetPixel(x, y, p);

                }
            }
            pictureBox3.Image = bit2;



        }



        private void button2_Click(object sender, EventArgs e)
        {
            //green image
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bitg = new Bitmap(bit.Width, bit.Height);
            Color p;


            for (int y = 0; y < bitg.Height; y++)
            {
                for (int x = 0; x < bitg.Width; x++)
                {
                    p = bit.GetPixel(x, y);

                    p = Color.FromArgb(p.A, 0, p.G, 0);
                    bitg.SetPixel(x, y, p);

                }
            }
            pictureBox3.Image = bitg;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //blue image
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bitb = new Bitmap(bit.Width, bit.Height);
            Color p;


            for (int y = 0; y < bitb.Height; y++)
            {
                for (int x = 0; x < bitb.Width; x++)
                {
                    p = bit.GetPixel(x, y);

                    p = Color.FromArgb(p.A, 0, 0, p.B);
                    bitb.SetPixel(x, y, p);

                }
            }
            pictureBox3.Image = bitb;

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog image2 = new OpenFileDialog();
            image2.Title = "Select the image from Your PC";
            image2.Filter = "All image|*.*";

            if (image2.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(image2.FileName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Color p;
            int max = 0;
            
            Bitmap bit1;
            if (bit.Width > bit.Height)
            {
                max = bit.Width;
                bit1 = new Bitmap(bit.Height, max);

            }

            else if (bit.Width > bit.Height)
            {
                max = bit.Width;
                bit1 = new Bitmap(  max , bit.Height);

            }
            else
            {
                max = bit.Height;
                bit1 = new Bitmap(max , bit.Width );
            }
            // Bitmap bit1 = new Bitmap(max, max);


            for (int h = 0; h < bit.Height; h++)
            {
                for (int w = 0; w < bit.Width; w++)
                {

                    p = bit.GetPixel(w, h);

                    bit1.SetPixel(bit1.Width - h - 1, w, p);

                }

            }
           

            pictureBox2.Image = bit1;

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = 0; y < bit2.Height / 2; y++)
            {
                for (int x = 0; x < bit2.Width / 2; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x, y, p);

                }
            }
            pictureBox6.Image = bit2;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = 0; y < bit2.Height / 2; y++)
            {
                for (int x = bit2.Width / 2; x < bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x, y, p);

                }
            }
            pictureBox6.Image = bit2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = bit2.Height / 2; y < bit2.Height; y++)
            {
                for (int x = 0; x < bit2.Width / 2; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x, y, p);

                }
            }
            pictureBox6.Image = bit2;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = bit2.Height / 2; y < bit2.Height; y++)
            {
                for (int x = bit2.Width / 2; x < bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x, y, p);

                }
            }
            pictureBox6.Image = bit2;


        }

        private void button19_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = 0; y < bit2.Height; y++)
            {
                for (int x = 0; x < bit2.Width / 2; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x, y, p);

                }
            }
            pictureBox6.Image = bit2;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = 0; y < bit2.Height; y++)
            {
                for (int x = bit2.Width / 2; x < bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x, y, p);

                }
            }
            pictureBox6.Image = bit2;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = bit2.Height / 4; y < 0.75 * bit2.Height; y++)
            {
                for (int x = bit2.Width / 4; x < 0.75 * bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x, y, p);

                }
            }
            pictureBox6.Image = bit2;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;
            for (int y = 0; y < bit2.Height / 2; y++)
            {
                for (int x = 0; x < bit2.Width / 2; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x, y, p);

                }
            }

            pictureBox5.Image = bit2;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = 0; y < bit2.Height / 2; y++)
            {
                for (int x = bit2.Width / 2; x < bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x - (bit2.Width / 2), y, p);

                }
            }

            pictureBox5.Image = bit2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = bit2.Height / 2; y < bit2.Height; y++)
            {
                for (int x = 0; x < bit2.Width / 2; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x, y - (bit2.Height / 2), p);

                }
            }
            pictureBox5.Image = bit2;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = bit2.Height / 2; y < bit2.Height; y++)
            {
                for (int x = bit2.Width / 2; x < bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x - (bit2.Width / 2), y - (bit2.Height / 2), p);

                }
            }
            pictureBox5.Image = bit2;


        }

        private void button21_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;
            for (int y = bit2.Height / 4; y < 0.75 * bit2.Height; y++)
            {
                for (int x = bit2.Width / 4; x < 0.75 * bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x - (bit2.Width / 4), y - (bit2.Height / 4), p);

                }
            }
            pictureBox5.Image = bit2;

        }

        private void button26_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;
            for (int y = 0; y < bit2.Height / 2; y++)
            {
                for (int x = 0; x < bit2.Width / 2; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x + (bit2.Width / 2), y, p);

                }
            }
            pictureBox8.Image = bit2;

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = 0; y < bit2.Height / 2; y++)
            {
                for (int x = bit2.Width / 2; x < bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x, y, p);

                }
            }
            pictureBox8.Image = bit2;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;
            for (int y = bit2.Height / 4; y < 0.75 * bit2.Height; y++)
            {
                for (int x = bit2.Width / 4; x < 0.75 * bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x + (bit2.Width / 4), y - (bit2.Height / 4), p);

                }
            }
            pictureBox8.Image = bit2;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = bit2.Height / 2; y < bit2.Height; y++)
            {
                for (int x = 0; x < bit2.Width / 2; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x + (bit2.Width / 2), y - (bit2.Height / 2), p);

                }
            }
            pictureBox8.Image = bit2;

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);

            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = bit2.Height / 2; y < bit2.Height; y++)
            {
                for (int x = bit2.Width / 2; x < bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x, y - (bit2.Height / 2), p);

                }
            }
            pictureBox8.Image = bit2;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;
            for (int y = 0; y < bit2.Height / 2; y++)
            {
                for (int x = 0; x < bit2.Width / 2; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x, y + (bit2.Height / 2), p);

                }
                pictureBox9.Image = bit2;

            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = 0; y < bit2.Height / 2; y++)
            {
                for (int x = bit2.Width / 2; x < bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x - (bit2.Width / 2), y + (bit2.Height / 2), p);

                }
            }
            pictureBox9.Image = bit2;

        }

        private void button29_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = bit2.Height / 2; y < bit2.Height; y++)
            {
                for (int x = 0; x < bit2.Width / 2; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x, y, p);

                }
            }
            pictureBox9.Image = bit2;

        }

        private void button27_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;
            for (int y = bit2.Height / 4; y < 0.75 * bit2.Height; y++)
            {
                for (int x = bit2.Width / 4; x < 0.75 * bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x - (bit2.Width / 4), y + (bit2.Height / 4), p);

                }
            }
            pictureBox9.Image = bit2;

        }

        private void button28_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);

            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = bit2.Height / 2; y < bit2.Height; y++)
            {
                for (int x = bit2.Width / 2; x < bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x - (bit2.Width / 2), y, p);

                }
            }
            pictureBox9.Image = bit2;

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;
            for (int y = 0; y < bit2.Height / 2; y++)
            {
                for (int x = 0; x < bit2.Width / 2; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x + (bit2.Width / 2), y + (bit2.Height / 2), p);

                }
            }
            pictureBox7.Image = bit2;

        }

        private void button35_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = 0; y < bit2.Height / 2; y++)
            {
                for (int x = bit2.Width / 2; x < bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x, y + (bit2.Height / 2), p);

                }
            }
            pictureBox7.Image = bit2;

        }

        private void button34_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = bit2.Height / 2; y < bit2.Height; y++)
            {
                for (int x = 0; x < bit2.Width / 2; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x + (bit2.Width / 2), y, p);

                }
            }
            pictureBox7.Image = bit2;

        }

        private void button32_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;
            for (int y = bit2.Height / 4; y < 0.75 * bit2.Height; y++)
            {
                for (int x = bit2.Width / 4; x < 0.75 * bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x + (bit2.Width / 4), y + (bit2.Height / 4), p);

                }
            }
            pictureBox7.Image = bit2;

        }

        private void button33_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);

            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = bit2.Height / 2; y < bit2.Height; y++)
            {
                for (int x = bit2.Width / 2; x < bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x, y, p);

                }
            }
            pictureBox7.Image = bit2;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;
            for (int y = 0; y < bit2.Height / 2; y++)
            {
                for (int x = 0; x < bit2.Width / 2; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x + (bit2.Width / 4), y + (bit2.Height / 4), p);

                }
            }
            pictureBox10.Image = bit2;

        }

        private void button40_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = 0; y < bit2.Height / 2; y++)
            {
                for (int x = bit2.Width / 2; x < bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);

                    bit2.SetPixel(x - (bit2.Width / 4), y + (bit2.Height / 4), p);

                }
            }
            pictureBox10.Image = bit2;

        }

        private void button39_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = bit2.Height / 2; y < bit2.Height; y++)
            {
                for (int x = 0; x < bit2.Width / 2; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x + (bit2.Width / 4), y - (bit2.Height / 4), p);

                }
            }
            pictureBox10.Image = bit2;

        }

        private void button37_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;
            for (int y = bit2.Height / 4; y < 0.75 * bit2.Height; y++)
            {
                for (int x = bit2.Width / 4; x < 0.75 * bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x, y, p);

                }
            }
            pictureBox10.Image = bit2;

        }

        private void button38_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);

            Bitmap bit2 = new Bitmap(bit.Width, bit.Height);

            Color p;

            for (int y = bit2.Height / 2; y < bit2.Height; y++)
            {
                for (int x = bit2.Width / 2; x < bit2.Width; x++)
                {
                    p = bit.GetPixel(x, y);
                    bit2.SetPixel(x - (bit2.Width / 4), y - (bit2.Height / 4), p);

                }
            }
            pictureBox10.Image = bit2;

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);

            int max = 0;
            Color p;
            Bitmap bit1;
            if (bit.Width > bit.Height)
            {
                max = bit.Width;
                bit1 = new Bitmap(max, bit.Height);

            }
            else
            {
                max = bit.Height;
                bit1 = new Bitmap(max, bit.Width);
            }



            for (int y = 0; y < bit.Height; y++)
            {
                for (int x = 0; x < bit.Width; x++)
                {

                    p = bit.GetPixel(x, y);

                    bit1.SetPixel(bit.Width-1-x,bit.Height-1-y , p);

                }
            }
            pictureBox2.Image = bit1;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit1 = new Bitmap((bit.Width*2), (bit.Height*2));
            Color p;
            int s = 0;int u = 0;


            for (int x = 0; x < bit.Width; x++)
            {
                s = 0;

                for (int y = 0; y < bit.Height ; y++)
                {
                    p = bit.GetPixel(x, y);

                    bit1.SetPixel (u,s, p);
                    bit1.SetPixel(u,s+1, p);
                    bit1.SetPixel(u+1,s, p);
                    bit1.SetPixel(u+1,s+1, p);

                    s =s+ 2;
                }

                u=u+2;
            }
            pictureBox4.Image = bit1;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            int max = 0;
            Color p;
            Bitmap bit1;
            if (bit.Width > bit.Height)
            {
                max = bit.Width;
                bit1 = new Bitmap(bit.Height, max);

            }
            else
            {
                max = bit.Height;
                bit1 = new Bitmap(bit.Width, max);
            }

            for (int h=0;h<bit.Height;h++)
            {
                for(int w=0;w<bit.Width;w++)
                {
                    p = bit.GetPixel(w, h);

                    bit1.SetPixel(  h ,bit1.Height- w-1, p);
                }
            }

            pictureBox2.Image = bit1;

        }

        private void button42_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);

            Color p;
            int max = 0;
            Bitmap bit1;
            if (bit.Width > bit.Height)
            {
                max = bit.Width;
                bit1 = new Bitmap( max, bit.Height);

            }
            else
            {
                max = bit.Height;
                bit1 = new Bitmap( max, bit.Width);
            }

            for (int h = 0; h < bit.Height; h++)
            {
                for (int w = 0; w < bit.Width; w++)
                {
                    p = bit.GetPixel(w, h);

                    bit1.SetPixel(w,h, p);
                  
                }
            }
            pictureBox2.Image = bit1;

        }

        private void button44_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            int max = 0;
            Color p;
            Bitmap bit1;
            if (bit.Width > bit.Height)
            {
                max = bit.Width;
                bit1 = new Bitmap(bit.Height, max);

            }
            else
            {
                max = bit.Height;
                bit1 = new Bitmap(bit.Width, max);
            }

            for (int h = 0; h < bit.Height; h++)
            {
                for (int w = 0; w < bit.Width; w++)
                {
                    p = bit.GetPixel(w, h);

                    bit1.SetPixel(h, bit1.Height - w - 1, p);
                }
            }

            pictureBox2.Image = bit1;
        }

            private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Color p;
            int max = 0;
            Bitmap bit1;
            if (bit.Width > bit.Height)
            {
                max = bit.Width;
                bit1 = new Bitmap(bit.Height, max);

            }
            else
            {
                max = bit.Height;
                bit1 = new Bitmap(bit.Width, max);
            }

            for (int h = 0; h < bit.Height; h++)
            {
                for (int w = 0; w < bit.Width; w++)
                {

                    p = bit.GetPixel(w, h);

                    bit1.SetPixel(bit1.Width - h - 1, w, p);

                }
            }
            pictureBox2.Image = bit1;


        }

        private void button45_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);

            int max = 0;
            Color p;
            Bitmap bit1;
            if (bit.Width > bit.Height)
            {
                max = bit.Width;
                bit1 = new Bitmap(max, bit.Height);

            }
            else
            {
                max = bit.Height;
                bit1 = new Bitmap(max, bit.Width);
            }



            for (int y = 0; y < bit.Height; y++)
            {
                for (int x = 0; x < bit.Width; x++)
                {

                    p = bit.GetPixel(x, y);

                    bit1.SetPixel(bit.Width - 1 - x, bit.Height - 1 - y, p);

                }
            }
            pictureBox2.Image = bit1;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);

            Color p;
            int max = 0;
            Bitmap bit1;
            if (bit.Width > bit.Height)
            {
                max = bit.Width;
                bit1 = new Bitmap(max, bit.Height);

            }
            else
            {
                max = bit.Height;
                bit1 = new Bitmap(max, bit.Width);
            }

            for (int h = 0; h < bit.Height; h++)
            {
                for (int w = 0; w < bit.Width; w++)
                {
                    p = bit.GetPixel(w, h);

                    bit1.SetPixel(w, h, p);

                }
            }
            pictureBox2.Image = bit1;

        }

        private void button47_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);
            Bitmap bit1 = new Bitmap(bit.Width / 2, bit.Height / 2);
            Color p;
            int s = 0, u = 0;


            for (int x = 0; x < bit.Width; x++)
            {

                for (int y = 0; y < bit.Height; y++)
                {
                    p = bit.GetPixel(x, y);

                    bit1.SetPixel(x/2, y/2, p);
                    y++;
                }


                x++;

            }
            pictureBox4.Image = bit1;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);

            Color p;
            Bitmap bit1 = new Bitmap(bit.Width, bit.Height);

             

            for (int h = 0; h < bit.Height; h++)
            {
                for (int w = 0; w < bit.Width; w++)
                {
                    p = bit.GetPixel(w, h);

                    bit1.SetPixel(w, h, p);

                }
            }
            pictureBox4.Image = bit1;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void button47_Click_1(object sender, EventArgs e)
        {

            Bitmap bit = new Bitmap(pictureBox1.Image);

            Color p;
            Bitmap bit1 = new Bitmap(bit.Width, bit.Height);

            int[,] value = new int[100, 100];

            for (int h = 0; h <20; h++)
            {
                for (int w = 0; w <40; w++)
                {
 
                    p = bit.GetPixel(w, h);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    int avg = (r + g + b) / 3;
                    value[h, w] = avg;
                    richTextBox1.Text +=avg+"  ";

                }
                richTextBox1.Text += "\r\n";
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            Bitmap zoom = new Bitmap((bmp.Width * 2) - 1, (bmp.Height * 2) - 1); 

            int x, y, s = 0, u = 0;

            Color p1, p2, p3, p4;
          

            for (x = 0; x < bmp.Width - 1; x++)
            {
                s = 0;

                for (y = 0; y < bmp.Height - 1; y++)
                {
                    p1 = bmp.GetPixel(x, y);
                    p3 = bmp.GetPixel(x + 1, y);
                    p2 = bmp.GetPixel(x, y + 1);
                    p4 = bmp.GetPixel(x + 1, y + 1);

                    int av1 = (p1.R + p3.R) / 2;
                    int av2 = (p1.R + p2.R) / 2;
                    int av4 = (p3.R + p4.R) / 2;
                    int av3 = (av2 + av4) / 2; // or int av3 = (av1 + (p2.R + p4.R) / 2) / 2) ; 

                    zoom.SetPixel(u, s, p1);
                    zoom.SetPixel(u + 1, s, Color.FromArgb(av1, av1, av1));
                    zoom.SetPixel(u, s + 1, Color.FromArgb(av2, av2, av2));
                    zoom.SetPixel(u + 1, s + 1, Color.FromArgb(av3, av3, av3));

                    s += 2;
                }
                u += 2;
            }
            pictureBox11.Image = zoom;

            
            s = 0;
            for (y = 0; y < bmp.Height - 1; y++)
            {
                p1 = bmp.GetPixel(x, y);
                p2 = bmp.GetPixel(x, y + 1);
                int av = (p1.R + p2.R) / 2;

               
                zoom.SetPixel(u, s, p1);

              
                zoom.SetPixel(u, s + 1, Color.FromArgb(av, av, av));
                
                s += 2;
            }


              u = 0;
            for (x = 0; x < bmp.Width - 1; x++)
            {
                p1 = bmp.GetPixel(x, y);
                p3 = bmp.GetPixel(x + 1, y);
                int av = (p1.R + p3.R) / 2;

                 zoom.SetPixel(u, s, p1);

                 zoom.SetPixel(u + 1, s, Color.FromArgb(av, av, av));
               
                u += 2;
            }
            p1 = bmp.GetPixel(x, y);
            zoom.SetPixel(u, s, p1);
            pictureBox11.Image = zoom;


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button50_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox1.Image);

            Color p;
            Bitmap bit1 = new Bitmap((bit.Width *2 )+1, (bit.Height *2) +1);
            int u = 1, s = 1;

          
            for (int x = 0; x < bit.Width; x++)
            {
                s = 1;
                for (int y = 0; y < bit.Height; y++)
                {
                    p = bit.GetPixel(x, y);

                    bit1.SetPixel(u, s, p);
                    s += 2;
                }
                u += 2;
            }
           
            double[] filter = { 0.25, 0.5, 0.25, 0.5, 1, 0.5, 0.25, 0.5, 0.25 };

 
            Bitmap conf = new Bitmap((bit.Width * 2)+1, (bit.Height * 2)+1);

            int d = 0; double sum = 0; Color r;

             
            for (int i=1; i<(bit.Width*2)-1;i++)
            {
                for(int j=1;j<(bit.Height*2)-1;j++)
                {
                    sum = 0;d = 0;

                    for (int k1 = i - 1; k1 <= i + 1;k1++)
                    {
                        for(int k2=j-1;k2<=j+1;k2++)
                        {
                            r = bit1.GetPixel(k1,k2);
                            sum += (r.R * filter[d]);
                            d++;

                          
                        }
                    }
                    conf.SetPixel(i, j, Color.FromArgb((int)sum, (int)sum, (int)sum));
                }
            }
            pictureBox12.Image = conf;

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp1 = new Bitmap((bmp.Width) + 1, (bmp.Height) + 1);
            Color p1; double avg1;
            for (int i = 1; i < (bmp.Width) - 1; i++)
            {
                for (int j = 1; j < (bmp.Height) - 1; j++)
                {
                    avg1 = 0.0;
                    for (int k1 = i - 1; k1 <= i + 1; k1++)
                    {
                        for (int k2 = j - 1; k2 <= j + 1; k2++)
                        {
                            p1 = bmp.GetPixel(k1, k2);
                            avg1 += p1.R;
                        }
                    }
                    avg1 = avg1 / 9;

                    bmp1.SetPixel(i, j, Color.FromArgb((int)avg1, (int)avg1, (int)avg1));
                }
            }
            pictureBox13.Image = bmp1;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap meadin = new Bitmap(bmp.Width + 1, bmp.Height + 1);
            int[] a = new int[9];
            Color q; int s = 0;
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    s = 0;
                    for (int m = i - 1; m <= i + 1; m++)
                    {
                        for (int n = j - 1; n <= j + 1; n++)
                        {
                            q = bmp.GetPixel(m, n);
                            a[s] = q.R;
                            s++;
                        }
                    }
                    Array.Sort(a);
                    int avg = a[4];
                    meadin.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            pictureBox13.Image = meadin;

        }

        private void button53_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap lablacin = new Bitmap((bmp.Width) + 1, (bmp.Height) + 1);
            Color p1; double sum;
            int[] mask = { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
            for (int x = 1; x < (bmp.Width) - 1; x++)
            {
                for (int y = 1; y < (bmp.Height) - 1; y++)
                {
                    sum = 0.0;
                    int d = 0;
                    for (int m = x - 1; m <= x + 1; m++)
                    {
                        for (int n = y - 1; n <= y + 1; n++)
                        {
                            p1 = bmp.GetPixel(m, n);
                            sum += (p1.R * mask[d]);
                            d++;
                        }
                    }

                    if (sum < 0)
                        sum = 0;
                    
                    else if (sum > 255)
                        sum = 255;

                    lablacin.SetPixel(x, y, Color.FromArgb((int)sum, (int)sum, (int)sum));

                }
            }
            pictureBox13.Image = lablacin;

        }

        private void button54_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap lablacin = new Bitmap((bmp.Width) + 1, (bmp.Height) + 1);
            Color p1; double sum;

            int[] mask = { 0 , 1 , 0 , 0 , 1 , 0 , 0 , -1 , 0 };

            for (int x = 1; x < (bmp.Width) - 1; x++)
            {
                for (int y = 1; y < (bmp.Height) - 1; y++)
                {
                    sum = 0.0;
                    int d = 0;
                    for (int m = x - 1; m <= x + 1; m++)
                    {
                        for (int n = y - 1; n <= y + 1; n++)
                        {
                            p1 = bmp.GetPixel(m, n);
                            sum += (p1.R * mask[d]);
                            d++;
                        }
                    }

                    if (sum < 0)
                        sum = 0;

                    else if (sum > 255)
                        sum = 255;

                    lablacin.SetPixel(x, y, Color.FromArgb((int)sum, (int)sum, (int)sum));

                }
            }
            pictureBox13.Image = lablacin;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void button56_Click(object sender, EventArgs e)
        {
            OpenFileDialog image1 = new OpenFileDialog();
            image1.Title = "select the image";
            image1.Filter = "All Image|*.*";

            if (image1.ShowDialog() == DialogResult.OK)
            {
                pictureBox14.Image = Image.FromFile(image1.FileName);
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void button55_Click(object sender, EventArgs e)
        {
            OpenFileDialog image1 = new OpenFileDialog();
            image1.Title = "select the image";
            image1.Filter = "All Image|*.*";

            if (image1.ShowDialog() == DialogResult.OK)
            {
                pictureBox15.Image = Image.FromFile(image1.FileName);
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Bitmap bit1 = new Bitmap(pictureBox14.Image);
            Bitmap bit2 = new Bitmap(pictureBox15.Image);

            Bitmap view = new Bitmap(bit1.Width, bit1.Height);

            Color p1;
            Color p2;
            Color p3;

            for (int y = 0; y < (bit1.Height) ; y++)
            {
                for (int x = 0; x< (bit1.Width); x++)
                {
                    p1 = bit1.GetPixel(x, y);
                    p2 = bit2.GetPixel(x, y);

                    int r = p1.R + p2.R;
                    if(r>255)
                    {
                        r = 255;
                    }
                    view.SetPixel(x, y, Color.FromArgb(255, r, r, r));
                 }
            }
            pictureBox16.Image = view;

        }

        private void button58_Click(object sender, EventArgs e)
        {

            Bitmap bit1 = new Bitmap(pictureBox14.Image);
            Bitmap bit2 = new Bitmap(pictureBox15.Image);

            Bitmap view = new Bitmap(bit1.Width, bit1.Height);

            Color p1;
            Color p2;
            Color p3;

            for (int y = 0; y < (bit1.Height); y++)
            {
                for (int x = 0; x < (bit1.Width); x++)
                {
                    p1 = bit1.GetPixel(x, y);
                    p2 = bit2.GetPixel(x, y);

                    int r = p1.R + 50;
                    if (r > 255)
                    {
                        r = 255;
                    }
                    view.SetPixel(x, y, Color.FromArgb(255, r, r, r));
 
                }
            }
            pictureBox16.Image = view;

        }

        private void button60_Click(object sender, EventArgs e)
        {

            Bitmap bit1 = new Bitmap(pictureBox14.Image);
            Bitmap bit2 = new Bitmap(pictureBox15.Image);

            Bitmap view = new Bitmap(bit1.Width, bit1.Height);

            Color p1;
            Color p2;
            Color p3;

            for (int y = 0; y < (bit1.Height); y++)
            {
                for (int x = 0; x < (bit1.Width); x++)
                {
                    p1 = bit1.GetPixel(x, y);
                    p2 = bit2.GetPixel(x, y);

                    int r = p1.R - p2.R;
                    if (r < 0)
                    {
                        r = 0;
                    }
                    view.SetPixel(x, y, Color.FromArgb(255, r, r, r));
                }
            }
            pictureBox16.Image = view;


        }

        private void button59_Click(object sender, EventArgs e)
        {

            Bitmap bit1 = new Bitmap(pictureBox14.Image);
            Bitmap bit2 = new Bitmap(pictureBox15.Image);

            Bitmap view = new Bitmap(bit1.Width, bit1.Height);

            Color p1;
            Color p2;
            Color p3;

            for (int y = 0; y < (bit1.Height); y++)
            {
                for (int x = 0; x < (bit1.Width); x++)
                {
                    p1 = bit1.GetPixel(x, y);
                    p2 = bit2.GetPixel(x, y);

                    int r = p1.R - 50;
                    if (r < 0)
                    {
                        r = 0;
                    }
                    view.SetPixel(x, y, Color.FromArgb(255, r, r, r));
                }
            }
            pictureBox16.Image = view;


        }

        private void button61_Click(object sender, EventArgs e)
        {

            Bitmap bit1 = new Bitmap(pictureBox14.Image);
            Bitmap bit2 = new Bitmap(pictureBox15.Image);

            Bitmap view = new Bitmap(bit1.Width, bit1.Height);

            Color p1;
            Color p2;
            Color p3;

            for (int y = 0; y < (bit1.Height); y++)
            {
                for (int x = 0; x < (bit1.Width); x++)
                {
                    p1 = bit1.GetPixel(x, y);

                    int r = p1.R * 2;
                    if (r > 255)
                    {
                        r = 255;
                    }
                    view.SetPixel(x, y, Color.FromArgb(255, r, r, r));
                }
            }

            pictureBox16.Image = view;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void button62_Click(object sender, EventArgs e)
        {

            Bitmap bit1 = new Bitmap(pictureBox14.Image);
            Bitmap bit2 = new Bitmap(pictureBox15.Image);

            Bitmap view = new Bitmap(bit1.Width, bit1.Height);

            Color p1;
            Color p2;
            Color p3;

            for (int y = 0; y < (bit1.Height); y++)
            {
                for (int x = 0; x < (bit1.Width); x++)
                {
                    p1 = bit1.GetPixel(x, y);

                    int r = p1.R / 2;
                    
                    view.SetPixel(x, y, Color.FromArgb(255, r, r, r));
                }
            }

            pictureBox16.Image = view;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            Bitmap bit1 = new Bitmap(pictureBox14.Image);
            Bitmap bit2 = new Bitmap(pictureBox15.Image);

            Bitmap view = new Bitmap(bit1.Width, bit1.Height);

            Color p1;
            Color p2;
            Color p3;

            for (int y = 0; y < (bit1.Height); y++)
            {
                for (int x = 0; x < (bit1.Width); x++)
                {
                    p1 = bit1.GetPixel(x, y);
                    p2 = bit2.GetPixel(x, y);


                    int a = p1.A;

                    int r = p1.R;
                    int r2 = p2.R;

                    int res = r | r2;
                    view.SetPixel(x, y, Color.FromArgb(255, res, res, res));
                }
            }

            pictureBox16.Image = view;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            Bitmap bit1 = new Bitmap(pictureBox14.Image);
            Bitmap bit2 = new Bitmap(pictureBox15.Image);

            Bitmap view = new Bitmap(bit1.Width, bit1.Height);

            Color p1;
            Color p2;
            Color p3;

            for (int y = 0; y < (bit1.Height); y++)
            {
                for (int x = 0; x < (bit1.Width); x++)
                {
                    p1 = bit1.GetPixel(x, y);
                    p2 = bit2.GetPixel(x, y);


                    int a = p1.A;

                    int r = p1.R;
                    int r2 = p2.R;

                    int res = r & r2;

                    view.SetPixel(x, y, Color.FromArgb(255, res, res, res));
                }
            }

            pictureBox16.Image = view;

        }

        private void button65_Click(object sender, EventArgs e)
        {
            Bitmap bit1 = new Bitmap(pictureBox14.Image);
            Bitmap bit2 = new Bitmap(pictureBox15.Image);

            Bitmap view = new Bitmap(bit1.Width, bit1.Height);

            Color p1;
          

            for (int y = 0; y < (bit1.Height); y++)
            {
                for (int x = 0; x < (bit1.Width); x++)
                {
                    p1 = bit1.GetPixel(x, y);
 

                    int a = p1.A;

                    int r = p1.R;

                    int res =255 - r;
                    view.SetPixel(x, y, Color.FromArgb(255, res, res, res));
                }
            }

            pictureBox16.Image = view;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button66_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap sopl = new Bitmap((bmp.Width) + 1, (bmp.Height) + 1);

            Color p1; double sum, sum1;

            int[] mask = { -1, -2, -1, 0, 0, 0, 1, 2, 1 };

            int[] mask1 = { -1, 0, 1, -2, 0, 2, -1, 0, 1 };

            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    sum = 0.0; 
                    sum1 = 0.0;
                    int d = 0;

                    for (int n = i - 1; n <= i + 1; n++)
                    {
                        for (int m = j - 1; m <= j + 1; m++)
                        {
                            p1 = bmp.GetPixel(n, m);

                            sum += (p1.R * mask[d]);

                            sum1 += (p1.R * mask1[d]);

                            d++;
                        }
                    }

                    double c = Math.Sqrt(Math.Pow(sum, 2) + Math.Pow(sum1, 2));

                    if (c < 0)
                        c = 0;

                    else if (c > 255)
                        c = 255;
 
                    sopl.SetPixel(i, j, Color.FromArgb((int)c, (int)c, (int)c));
                }
            }
            pictureBox13.Image = sopl;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void button67_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int mask = (int)(256 - Math.Pow(2, 8 - n));

            Bitmap bmp = new Bitmap(pictureBox1.Image);

            Bitmap black_level = new Bitmap(bmp.Width, bmp.Height);

            Bitmap white_level = new Bitmap(bmp.Width, bmp.Height);

            Color o; int addResult, result;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    o = bmp.GetPixel(i, j);
                    addResult = o.R & mask;
                    result = addResult >> (8 - n);
                    black_level.SetPixel(i, j, Color.FromArgb(result, result,result));


                    o = black_level.GetPixel(i, j);
                    result = o.R * ((int)(256 / Math.Pow(2, n)));
                    white_level.SetPixel(i, j, Color.FromArgb(result, result, result));
                }
            }
            pictureBox17.Image = black_level;
            pictureBox18.Image = white_level;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button68_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap sopl = new Bitmap((bmp.Width) + 1, (bmp.Height) + 1);
            Color p;
            Color p1;

            double[] sum= new double[8];

            int[] mask = { -3 , -3 , 5 , -3 , 0 , 5 , -3 , -3 , 5 };

            int[] mask1 = { -3 , 5 , 5 , -3 , 0 , 5 , -3 , -3 , -3 };
            int[] mask2 = { 5 , 5 , 5 , -3 , 0 , -3 , -3 , -3 , -3};
            int[] mask3 = { 5 , 5 , -3 , 5 , 0 , -3 , -3 , -3 , -3};
            int[] mask4 = { 5, -3, -3, 5, 0, -3, 5, -3, -3 };
            int[] mask5 = { -3, -3, -3, 5, 0, -3, 5, 5, -3 };
            int[] mask6 = { -3, -3, -3, -3, 0, -3, 5, 5, 5 };
            int[] mask7 = { -3, -3, -3, -3, 0, 5, -3, 5, 5 };

            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                  
                    int d = 0;

                    for (int n = i - 1; n <= i + 1; n++)
                    {
                        for (int m = j - 1; m <= j + 1; m++)
                        {
                            p1 = bmp.GetPixel(n, m);

                            sum[0] = (p1.R * mask[d]);
                            sum[1] = (p1.R * mask1[d]);
                            sum[2] = (p1.R * mask2[d]);
                            sum[3]= (p1.R * mask3[d]);
                            sum[4] = (p1.R * mask4[d]);
                            sum[5] = (p1.R * mask5[d]);
                            sum[6] = (p1.R * mask6[d]);
                            sum[7] = (p1.R * mask7[d]);
                            d++;
                        }
                    }

                    Array.Sort(sum);
                    double c = sum[7];
                    
                   // double c = Math.Sqrt(Math.Pow(sum, 2) + Math.Pow(sum1, 2));

                    if (c < 0)
                        c = 0;

                    else if (c > 255)
                        c = 255;


                    sopl.SetPixel(i, j, Color.FromArgb((int)c, (int)c, (int)c));
                }
            }
            pictureBox13.Image = sopl;
        }
    }
}
