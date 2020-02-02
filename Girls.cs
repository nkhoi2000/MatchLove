using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchLove
{   
    public partial class Girls : Form
    {
        public int input { get; set; } 
        public Girls()
        {
            InitializeComponent();
            this.btn_girl_rand.Click += Btn_girl_rand_Click;
        }

        private void Btn_girl_rand_Click(object sender, EventArgs e)
        {
            input = System.Convert.ToInt32(this.txt_girl_number.Text);
        }
    }
}
