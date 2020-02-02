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
    public partial class ResultDialog : Form
    {
        public ResultDialog(int result)
        {
            InitializeComponent();
            this.lbl_result.Text = result.ToString();
        }
    }
}
