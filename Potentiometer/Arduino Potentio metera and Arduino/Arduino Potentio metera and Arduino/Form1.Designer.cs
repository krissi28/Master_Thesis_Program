namespace Arduino_Potentio_metera_and_Arduino
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
            this.Btn_On = new System.Windows.Forms.Button();
            this.Btn_Off = new System.Windows.Forms.Button();
            this.Txt_box_1 = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Btn_On
            // 
            this.Btn_On.Location = new System.Drawing.Point(60, 343);
            this.Btn_On.Name = "Btn_On";
            this.Btn_On.Size = new System.Drawing.Size(199, 115);
            this.Btn_On.TabIndex = 0;
            this.Btn_On.Text = "ON";
            this.Btn_On.UseVisualStyleBackColor = true;
            this.Btn_On.Click += new System.EventHandler(this.Btn_On_Click);
            // 
            // Btn_Off
            // 
            this.Btn_Off.Location = new System.Drawing.Point(477, 343);
            this.Btn_Off.Name = "Btn_Off";
            this.Btn_Off.Size = new System.Drawing.Size(199, 115);
            this.Btn_Off.TabIndex = 1;
            this.Btn_Off.Text = "OFF";
            this.Btn_Off.UseVisualStyleBackColor = true;
            this.Btn_Off.Click += new System.EventHandler(this.Btn_Off_Click);
            // 
            // Txt_box_1
            // 
            this.Txt_box_1.Location = new System.Drawing.Point(60, 160);
            this.Txt_box_1.Name = "Txt_box_1";
            this.Txt_box_1.Size = new System.Drawing.Size(131, 20);
            this.Txt_box_1.TabIndex = 2;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(208, 277);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(348, 23);
            this.pb.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 496);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.Txt_box_1);
            this.Controls.Add(this.Btn_Off);
            this.Controls.Add(this.Btn_On);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_On;
        private System.Windows.Forms.Button Btn_Off;
        private System.Windows.Forms.TextBox Txt_box_1;
        private System.Windows.Forms.ProgressBar pb;
    }
}

