namespace MatchLove
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_ = new System.Windows.Forms.Label();
            this.ptr_girl = new System.Windows.Forms.PictureBox();
            this.ptr_boy = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_main_result = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_main_reset = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_girl = new System.Windows.Forms.TextBox();
            this.txt_boy = new System.Windows.Forms.TextBox();
            this.btn_random = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_girl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_boy)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_
            // 
            this.btn_.AutoSize = true;
            this.btn_.BackColor = System.Drawing.Color.Transparent;
            this.btn_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_.Location = new System.Drawing.Point(282, 190);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(46, 31);
            this.btn_.TabIndex = 7;
            this.btn_.Text = "♥";
            // 
            // ptr_girl
            // 
            this.ptr_girl.Image = ((System.Drawing.Image)(resources.GetObject("ptr_girl.Image")));
            this.ptr_girl.ImageLocation = "";
            this.ptr_girl.Location = new System.Drawing.Point(371, 95);
            this.ptr_girl.Name = "ptr_girl";
            this.ptr_girl.Size = new System.Drawing.Size(151, 223);
            this.ptr_girl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptr_girl.TabIndex = 6;
            this.ptr_girl.TabStop = false;
            // 
            // ptr_boy
            // 
            this.ptr_boy.Image = ((System.Drawing.Image)(resources.GetObject("ptr_boy.Image")));
            this.ptr_boy.ImageLocation = "";
            this.ptr_boy.Location = new System.Drawing.Point(76, 86);
            this.ptr_boy.Name = "ptr_boy";
            this.ptr_boy.Size = new System.Drawing.Size(163, 232);
            this.ptr_boy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptr_boy.TabIndex = 5;
            this.ptr_boy.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(191, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "MATCH  LOVE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_main_result,
            this.btn_main_reset});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_main_result
            // 
            this.btn_main_result.Name = "btn_main_result";
            this.btn_main_result.Size = new System.Drawing.Size(51, 20);
            this.btn_main_result.Text = "Result";
            // 
            // btn_main_reset
            // 
            this.btn_main_reset.Name = "btn_main_reset";
            this.btn_main_reset.Size = new System.Drawing.Size(47, 20);
            this.btn_main_reset.Text = "Reset";
            // 
            // txt_girl
            // 
            this.txt_girl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_girl.ForeColor = System.Drawing.Color.Silver;
            this.txt_girl.Location = new System.Drawing.Point(407, 335);
            this.txt_girl.Margin = new System.Windows.Forms.Padding(2);
            this.txt_girl.MaximumSize = new System.Drawing.Size(500, 500);
            this.txt_girl.Name = "txt_girl";
            this.txt_girl.Size = new System.Drawing.Size(77, 35);
            this.txt_girl.TabIndex = 13;
            this.txt_girl.Text = "Girl";
            this.txt_girl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_girl.Enter += new System.EventHandler(this.txt_girl_Enter);
            this.txt_girl.Leave += new System.EventHandler(this.txt_girl_Leave);
            // 
            // txt_boy
            // 
            this.txt_boy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_boy.ForeColor = System.Drawing.Color.Silver;
            this.txt_boy.Location = new System.Drawing.Point(109, 335);
            this.txt_boy.Margin = new System.Windows.Forms.Padding(2);
            this.txt_boy.MaximumSize = new System.Drawing.Size(500, 500);
            this.txt_boy.Name = "txt_boy";
            this.txt_boy.Size = new System.Drawing.Size(100, 35);
            this.txt_boy.TabIndex = 13;
            this.txt_boy.Tag = "";
            this.txt_boy.Text = "Boy";
            this.txt_boy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_boy.Enter += new System.EventHandler(this.txt_boy_Enter);
            this.txt_boy.Leave += new System.EventHandler(this.txt_boy_Leave);
            // 
            // btn_random
            // 
            this.btn_random.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_random.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_random.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_random.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_random.Location = new System.Drawing.Point(253, 335);
            this.btn_random.Margin = new System.Windows.Forms.Padding(2);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(103, 35);
            this.btn_random.TabIndex = 14;
            this.btn_random.Text = "Random";
            this.btn_random.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 421);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.txt_boy);
            this.Controls.Add(this.txt_girl);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.ptr_girl);
            this.Controls.Add(this.ptr_boy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Match Love";
            ((System.ComponentModel.ISupportInitialize)(this.ptr_girl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_boy)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_;
        private System.Windows.Forms.PictureBox ptr_girl;
        private System.Windows.Forms.PictureBox ptr_boy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_main_result;
        private System.Windows.Forms.ToolStripMenuItem btn_main_reset;
        private System.Windows.Forms.TextBox txt_girl;
        private System.Windows.Forms.TextBox txt_boy;
        private System.Windows.Forms.Button btn_random;
    }
}

