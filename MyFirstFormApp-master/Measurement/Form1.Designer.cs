namespace Measurement
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
            this.txt_cm = new System.Windows.Forms.TextBox();
            this.txt_dm = new System.Windows.Forms.TextBox();
            this.txt_m = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_cm = new System.Windows.Forms.Label();
            this.lbl_dm = new System.Windows.Forms.Label();
            this.lbl_m = new System.Windows.Forms.Label();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.btn_history = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cm
            // 
            this.txt_cm.Location = new System.Drawing.Point(159, 12);
            this.txt_cm.Name = "txt_cm";
            this.txt_cm.Size = new System.Drawing.Size(100, 20);
            this.txt_cm.TabIndex = 0;
            this.txt_cm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // txt_dm
            // 
            this.txt_dm.Location = new System.Drawing.Point(159, 55);
            this.txt_dm.Name = "txt_dm";
            this.txt_dm.Size = new System.Drawing.Size(100, 20);
            this.txt_dm.TabIndex = 1;
            this.txt_dm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(159, 99);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(100, 20);
            this.txt_m.TabIndex = 2;
            this.txt_m.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Caluclate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // lbl_cm
            // 
            this.lbl_cm.AutoSize = true;
            this.lbl_cm.Location = new System.Drawing.Point(115, 18);
            this.lbl_cm.Name = "lbl_cm";
            this.lbl_cm.Size = new System.Drawing.Size(23, 13);
            this.lbl_cm.TabIndex = 4;
            this.lbl_cm.Text = "SM";
            // 
            // lbl_dm
            // 
            this.lbl_dm.AutoSize = true;
            this.lbl_dm.Location = new System.Drawing.Point(115, 62);
            this.lbl_dm.Name = "lbl_dm";
            this.lbl_dm.Size = new System.Drawing.Size(24, 13);
            this.lbl_dm.TabIndex = 5;
            this.lbl_dm.Text = "DM";
            // 
            // lbl_m
            // 
            this.lbl_m.AutoSize = true;
            this.lbl_m.Location = new System.Drawing.Point(115, 106);
            this.lbl_m.Name = "lbl_m";
            this.lbl_m.Size = new System.Drawing.Size(16, 13);
            this.lbl_m.TabIndex = 6;
            this.lbl_m.Text = "M";
            // 
            // lbl_answer
            // 
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Location = new System.Drawing.Point(490, 18);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(0, 13);
            this.lbl_answer.TabIndex = 7;
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(454, 147);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(75, 23);
            this.btn_history.TabIndex = 8;
            this.btn_history.Text = "show history";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 425);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.lbl_m);
            this.Controls.Add(this.lbl_dm);
            this.Controls.Add(this.lbl_cm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_m);
            this.Controls.Add(this.txt_dm);
            this.Controls.Add(this.txt_cm);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cm;
        private System.Windows.Forms.TextBox txt_dm;
        private System.Windows.Forms.TextBox txt_m;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_cm;
        private System.Windows.Forms.Label lbl_dm;
        private System.Windows.Forms.Label lbl_m;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.Button btn_history;
    }
}

