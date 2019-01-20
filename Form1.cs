using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
      
        int counter = 0;
        int trycounter = 0;
        List<string> path = new List<string>();
        List<PictureBox> pic = new List<PictureBox> ();
        List<int> Pchecker = new List<int>();

        public Form1()
        {
          InitializeComponent();
            textBox1.Text = trycounter.ToString();
           
        }
        
         public bool compare()
         {
            System.Threading.Thread.Sleep(500);
            counter = 0;
            if ((path[0] == path[1]))
            {
               
                return true;

            }
           
            return false;
         }
            
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c= @"C:\Users\el aqsa\source\repos\Game\Game\76102_Thor.png";
            pictureBox1.Image = new Bitmap(c);
            path.Add(c);
            pic.Add(this.pictureBox1);
            pictureBox1.Update();
          //  System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
              
                if (compare())
               {
                    //MessageBox.Show("hi");
                    pic[0].Visible=false;
                    pic[1].Visible=false;
                    pic.Clear();
                    path.Clear();
               }
               else
               {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox1.Image = null;
                    pictureBox1.Update();

                    // pictureBox1.BackColor = Color.Blue;
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\31-314683_lego-superheroes-hulk.png";
            pictureBox2.Image = new Bitmap(c);
            path.Add(c);
            pic.Add(this.pictureBox2);
            pictureBox2.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
           // Pchecker.Add(1);
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
               
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox2.Image = null;
                    pictureBox2.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
          

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\lego-batman-3-beyond-gotham-lego-batman-the-videogame-lego-batman-2-dc-super-heroes-lego-batman.jpg";
            pictureBox4.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox4);
            pictureBox4.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox4.Image = null;
                    pictureBox4.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\lego-marvel-super-heroes-lego-marvels-avengers-wolverine-captain-america-thor-wolverine-cliparts.jpg";
            pictureBox3.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox3);
            pictureBox3.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox3.Image = null;
                    pictureBox3.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\76102_Thor.png";
            pictureBox5.Image = new Bitmap(c);
            path.Add(c);
            pic.Add(this.pictureBox5);
            pictureBox5.Update();
          //  System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
               // MessageBox.Show("coun2");
                if (compare())
                {
                    // MessageBox.Show("hi1");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();

                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox5.Image = null;
                    pictureBox5.Update();
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\31-314683_lego-superheroes-hulk.png";
            pictureBox10.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox10);
            pictureBox10.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox10.Image = null;
                    pictureBox10.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\76025_Sinestro_1488x1984_mugshot_360w_2x.png";
            pictureBox9.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox9);
            pictureBox9.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox9.Image = null;
                    pictureBox9.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\61-uTmSW6dL._SL1181_.jpg";
            pictureBox8.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox8);
            pictureBox8.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox8.Image = null;
                    pictureBox8.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\lego-batman-3-beyond-gotham-lego-batman-the-videogame-lego-batman-2-dc-super-heroes-lego-batman.jpg";
            pictureBox7.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox7);
            pictureBox7.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox7.Image = null;
                    pictureBox7.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\lego-marvel-super-heroes-lego-marvels-avengers-wolverine-captain-america-thor-wolverine-cliparts.jpg";
            pictureBox6.Image = new Bitmap(c);
            
            path.Add(c);
            pic.Add(this.pictureBox6);
            pictureBox6.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox6.Image = null;
                    pictureBox6.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\super-heroes-lego-png-7.png";
            pictureBox15.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox15);
            pictureBox15.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox15.Image = null;
                    pictureBox15.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\super-heroes-lego-png-7.png";
            pictureBox14.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox14);
            pictureBox14.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox14.Image = null;
                    pictureBox14.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\super-heroes-lego-png-7.png";
            pictureBox13.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox13);
            pictureBox13.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox13.Image = null;
                    pictureBox13.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\super-heroes-lego-png-7.png";
            pictureBox12.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox12);
            pictureBox12.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox12.Image = null;
                    pictureBox12.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\Thor.jpg";
            pictureBox11.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox11);
            pictureBox11.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox11.Image = null;
                    pictureBox11.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\61-uTmSW6dL._SL1181_.jpg";
            pictureBox20.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox20);
            pictureBox20.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox20.Image = null;
                    pictureBox20.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\fa2b30f9-2489-4102-bb1d-606dc6a24700.PNG";
            pictureBox19.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox19);
            pictureBox19.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox19.Image = null;
                    pictureBox19.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\Thor.jpg";
            pictureBox18.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox18);
            pictureBox18.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox18.Image = null;
                    pictureBox18.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\fa2b30f9-2489-4102-bb1d-606dc6a24700.PNG";
            pictureBox17.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox17);
            pictureBox17.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox17.Image = null;
                    pictureBox17.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            trycounter++;
            textBox1.Text = trycounter.ToString();
            string c = @"C:\Users\el aqsa\source\repos\Game\Game\New folder (3)\76025_Sinestro_1488x1984_mugshot_360w_2x.png";
            pictureBox16.Image = new Bitmap(c);

            path.Add(c);
            pic.Add(this.pictureBox16);
            pictureBox16.Update();
            //System.Threading.Thread.Sleep(400);
            counter++;
            if (pic.Count == 2)
            {
                if (pic[0] == pic[1])
                {
                    trycounter--;
                    textBox1.Text = trycounter.ToString();
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    counter = 0;

                }
            }
            if (counter == 2)
            {
                // MessageBox.Show("coun");
                if (compare())
                {
                    //MessageBox.Show("hi");
                    pic[0].Visible = false;
                    pic[1].Visible = false;
                    pic.Clear();
                    path.Clear();
                }
                else
                {
                    pic[0].Image = null;
                    pic.Clear();
                    path.Clear();
                    pictureBox16.Image = null;
                    pictureBox16.Update();
                    //pictureBox2.BackColor = Color.Blue;
                }
            }
        }

      
    }
}
