namespace TwoAutoClicker
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timesOfClicksPerLocationInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clickPhaseTxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.firstPosLbl = new System.Windows.Forms.Label();
            this.secondPosLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clickCountLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(38, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 90);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Click Pos";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(42, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start Clicking";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timesOfClicksPerLocationInput
            // 
            this.timesOfClicksPerLocationInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timesOfClicksPerLocationInput.Location = new System.Drawing.Point(153, 73);
            this.timesOfClicksPerLocationInput.Name = "timesOfClicksPerLocationInput";
            this.timesOfClicksPerLocationInput.Size = new System.Drawing.Size(70, 20);
            this.timesOfClicksPerLocationInput.TabIndex = 3;
            this.timesOfClicksPerLocationInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timesOfClicksPerLocationInput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Repeatition Count";
            // 
            // clickPhaseTxt
            // 
            this.clickPhaseTxt.AutoSize = true;
            this.clickPhaseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickPhaseTxt.Location = new System.Drawing.Point(132, 118);
            this.clickPhaseTxt.Name = "clickPhaseTxt";
            this.clickPhaseTxt.Size = new System.Drawing.Size(103, 25);
            this.clickPhaseTxt.TabIndex = 5;
            this.clickPhaseTxt.Text = "1st Click";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(31, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Pos";
            // 
            // firstPosLbl
            // 
            this.firstPosLbl.AutoSize = true;
            this.firstPosLbl.Location = new System.Drawing.Point(257, 67);
            this.firstPosLbl.Name = "firstPosLbl";
            this.firstPosLbl.Size = new System.Drawing.Size(16, 13);
            this.firstPosLbl.TabIndex = 7;
            this.firstPosLbl.Text = "---";
            // 
            // secondPosLbl
            // 
            this.secondPosLbl.AutoSize = true;
            this.secondPosLbl.Location = new System.Drawing.Point(257, 103);
            this.secondPosLbl.Name = "secondPosLbl";
            this.secondPosLbl.Size = new System.Drawing.Size(16, 13);
            this.secondPosLbl.TabIndex = 9;
            this.secondPosLbl.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Second Pos";
            // 
            // clickCountLbl
            // 
            this.clickCountLbl.AutoSize = true;
            this.clickCountLbl.Location = new System.Drawing.Point(276, 130);
            this.clickCountLbl.Name = "clickCountLbl";
            this.clickCountLbl.Size = new System.Drawing.Size(13, 13);
            this.clickCountLbl.TabIndex = 10;
            this.clickCountLbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(343, 175);
            this.Controls.Add(this.clickCountLbl);
            this.Controls.Add(this.secondPosLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstPosLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clickPhaseTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timesOfClicksPerLocationInput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox timesOfClicksPerLocationInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label clickPhaseTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label firstPosLbl;
        private System.Windows.Forms.Label secondPosLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label clickCountLbl;
    }
}

