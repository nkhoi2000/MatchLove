namespace MatchLove
{
    partial class Boys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btn_boy_rand = new System.Windows.Forms.Button();
            this.txt_boy_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(47, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tìm kiếm công chúa của đời mình thôi nào";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_boy_rand
            // 
            this.btn_boy_rand.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_boy_rand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_boy_rand.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_boy_rand.Location = new System.Drawing.Point(117, 133);
            this.btn_boy_rand.Margin = new System.Windows.Forms.Padding(2);
            this.btn_boy_rand.Name = "btn_boy_rand";
            this.btn_boy_rand.Size = new System.Drawing.Size(131, 38);
            this.btn_boy_rand.TabIndex = 8;
            this.btn_boy_rand.Text = "GO";
            this.btn_boy_rand.UseVisualStyleBackColor = true;
            // 
            // txt_boy_number
            // 
            this.txt_boy_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txt_boy_number.Location = new System.Drawing.Point(143, 45);
            this.txt_boy_number.Margin = new System.Windows.Forms.Padding(2);
            this.txt_boy_number.MaximumSize = new System.Drawing.Size(500, 500);
            this.txt_boy_number.Name = "txt_boy_number";
            this.txt_boy_number.Size = new System.Drawing.Size(77, 44);
            this.txt_boy_number.TabIndex = 7;
            this.txt_boy_number.Text = "50";
            this.txt_boy_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập số của bạn vào nào : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Boys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 184);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_boy_rand);
            this.Controls.Add(this.txt_boy_number);
            this.Controls.Add(this.label1);
            this.Name = "Boys";
            this.Text = "You Are Boy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_boy_rand;
        private System.Windows.Forms.TextBox txt_boy_number;
        private System.Windows.Forms.Label label1;
    }
}