namespace MatchLove
{
    partial class ResultDialog
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_outcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cancel.Location = new System.Drawing.Point(159, 485);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 28);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Ok";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_outcome
            // 
            this.lbl_outcome.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outcome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_outcome.Location = new System.Drawing.Point(11, 9);
            this.lbl_outcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_outcome.Name = "lbl_outcome";
            this.lbl_outcome.Size = new System.Drawing.Size(161, 462);
            this.lbl_outcome.TabIndex = 11;
            this.lbl_outcome.Text = "results";
            this.lbl_outcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 524);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_outcome);
            this.Name = "ResultDialog";
            this.Text = "Result";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_outcome;
    }
}