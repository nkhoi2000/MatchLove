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
        private List<string> listResult;
        public ResultDialog(List<string> result)
        {
            InitializeComponent();
            this.listResult = result;
            this.Load += ResultDialog_Load;

        }

        private void ResultDialog_Load(object sender, EventArgs e)
        {
            string result = "";
            try
            {

                foreach (string item in listResult)
                {
                    result += item + "\n";
                }
                this.lbl_outcome.Text = result;
            }
            catch
            {
                this.lbl_outcome.Text = "null";
            }
        }
    }
}
