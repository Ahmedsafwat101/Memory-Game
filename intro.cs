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
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 i = new Form1();
            i.Show();
            this.Hide();

        }

        private void intro_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\el aqsa\source\repos\Game\Game\Alan.wav");

            sp.PlayLooping();

          
        }
    }
}
