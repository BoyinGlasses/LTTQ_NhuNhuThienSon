using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LAB
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        public static void Run()
        {
            Application.EnableVisualStyles();
            Application.Run(new Bai3());
        }
        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void Change_color_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(256),random.Next(256),random.Next(256));
        }
    }
}
