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
        static int boy;
        static int girl;
        public List<string> outcome { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.btn_main_result.Click += Btn_main_result_Click;
            this.btn_main_reset.Click += Btn_main_reset_Click;
            this.btn_random.Click += Btn_random_Click;
        }


        private void Btn_main_reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset?", "RESET", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                randomize.removeAll();
                randomize.crearteGirlsArray();
                randomize.createBoysArray();
            }
        }

        // result
        private void Btn_main_result_Click(object sender, EventArgs e)
        {
            ResultDialog resultDialog = new ResultDialog(randomize.results);
            resultDialog.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomize.crearteGirlsArray();
            randomize.createBoysArray();
        }

        // set placeholder txt_boy
        private void txt_boy_Leave(object sender, EventArgs e)
        {
            if (txt_boy.Text == "Boy")
            {
                txt_boy.Text = "0";
                txt_boy.ForeColor = Color.Firebrick;
            }
        }

        private void txt_boy_Enter(object sender, EventArgs e)
        {
            if (txt_boy.Text == "")
                txt_boy.Text = "0";
            else
                txt_boy.ForeColor = Color.Firebrick;
        }

        // set placeholder txt_girl
        private void txt_girl_Leave(object sender, EventArgs e)
        {
            if (txt_girl.Text == "Girl")
            {
                txt_girl.Text = "0";
                txt_girl.ForeColor = Color.Silver;
            }
            else
                txt_girl.ForeColor = Color.Firebrick;
        }

        private void txt_girl_Enter(object sender, EventArgs e)
        {
            if (txt_girl.Text == "")
                txt_girl.Text = "0";
            else
                txt_girl.ForeColor = Color.Firebrick;
        }

        // set action

        private void Btn_random_Click(object sender, EventArgs e)
        {
            if (randomize.findNumb(randomize.boys, System.Convert.ToInt32(this.txt_boy.Text)) == true)
            {
                boy = System.Convert.ToInt32(this.txt_boy.Text);
                girl = randomize.random(randomize.girls);
                this.txt_girl.ForeColor = Color.Firebrick;
                this.txt_girl.Text = girl.ToString();
                randomize.removeRandom(randomize.boys, boy);
                randomize.removeRandom(randomize.girls, girl);
                randomize.outcome(boy, girl);
            }
            else if (randomize.findNumb(randomize.girls, System.Convert.ToInt32(this.txt_girl.Text)) == true)
            {
                girl = System.Convert.ToInt32(this.txt_girl.Text);
                boy = randomize.random(randomize.boys);
                this.txt_boy.ForeColor = Color.Firebrick;
                this.txt_boy.Text = boy.ToString();
                randomize.removeRandom(randomize.girls, girl);
                randomize.removeRandom(randomize.boys, boy);
                randomize.outcome(boy, girl);
            }
            else
            {
                MessageBox.Show("Số bạn vừa nhập không đúng hoặc bị trùng, hãy nhập lại.", "OOPS!!!");
            }
        }
    }
}
