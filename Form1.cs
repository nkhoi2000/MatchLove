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
    public partial class Form1 : Form
    {
        Boys boyForm = new Boys();
        Girls girlForm = new Girls();
        Random randomize = new Random();
        int input;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.ptr_boy.Click += Ptr_boy_Click;
            this.ptr_girl.Click += Ptr_girl_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomize.crearteGirlsArray();
            randomize.createBoysArray();
        }

        private void Ptr_girl_Click(object sender, EventArgs e)
        {
            girlForm.ShowDialog();
            if (girlForm.DialogResult.Equals(DialogResult.OK))
            {
                input = girlForm.input;
                if (randomize.findNumb(randomize.girls, input) != true)
                {
                    MessageBox.Show("Số bạn vừa nhập không đúng hoặc bị trùng, hãy nhập lại.", "OOPS!!!");
                }
                else
                {
                    randomize.removeRandom(randomize.girls, input);
                    int rand = randomize.random(randomize.b);
                    randomize.removeRandom(randomize.girls, rand);
                    ResultDialog result = new ResultDialog(rand);
                    result.ShowDialog();
                }
            }
        }

        private void Ptr_boy_Click(object sender, EventArgs e)
        {
            boyForm.ShowDialog();
            if (boyForm.DialogResult.Equals(DialogResult.OK))
            {
                input = boyForm.input;
                if (randomize.findNumb(randomize.boys, input)!= true)
                {
                    MessageBox.Show("Số bạn vừa nhập không đúng hoặc bị trùng, hãy nhập lại.", "OOPS!!!");
                }
                else
                {
                    randomize.removeRandom(randomize.boys, input);
                    int rand = randomize.random(randomize.girls);
                    randomize.removeRandom(randomize.girls, rand);
                    ResultDialog result = new ResultDialog(rand);
                    result.ShowDialog();
                }
            }
        }
    }
}
