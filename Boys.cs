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
    public partial class Boys : Form
    {
        Random randommize = new Random();
        public int input { get; set; }
        public Boys()
        {
            InitializeComponent();
            this.btn_boy_rand.Click += Btn_boy_rand_Click;
        }

        private void Btn_boy_rand_Click(object sender, EventArgs e)
        {
            input = System.Convert.ToInt32(this.txt_boy_number.Text);
        }
    }
}
