namespace Bai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxinput = new System.Windows.Forms.TextBox();
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxhostname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxip = new System.Windows.Forms.ListBox();
            this.listBoxalias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "input";
            // 
            // textBoxinput
            // 
            this.textBoxinput.Location = new System.Drawing.Point(96, 16);
            this.textBoxinput.Name = "textBoxinput";
            this.textBoxinput.Size = new System.Drawing.Size(246, 20);
            this.textBoxinput.TabIndex = 1;
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.Location = new System.Drawing.Point(367, 14);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonsubmit.TabIndex = 2;
            this.buttonsubmit.Text = "Tim";
            this.buttonsubmit.UseVisualStyleBackColor = true;
            this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hostname";
            // 
            // textBoxhostname
            // 
            this.textBoxhostname.Location = new System.Drawing.Point(96, 77);
            this.textBoxhostname.Name = "textBoxhostname";
            this.textBoxhostname.Size = new System.Drawing.Size(246, 20);
            this.textBoxhostname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Day IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alias";
            // 
            // listBoxip
            // 
            this.listBoxip.FormattingEnabled = true;
            this.listBoxip.Location = new System.Drawing.Point(38, 157);
            this.listBoxip.Name = "listBoxip";
            this.listBoxip.Size = new System.Drawing.Size(304, 186);
            this.listBoxip.TabIndex = 7;
            // 
            // listBoxalias
            // 
            this.listBoxalias.FormattingEnabled = true;
            this.listBoxalias.Location = new System.Drawing.Point(406, 157);
            this.listBoxalias.Name = "listBoxalias";
            this.listBoxalias.Size = new System.Drawing.Size(304, 186);
            this.listBoxalias.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxalias);
            this.Controls.Add(this.listBoxip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxhostname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.textBoxinput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxinput;
        private System.Windows.Forms.Button buttonsubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxhostname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxip;
        private System.Windows.Forms.ListBox listBoxalias;
    }
}

