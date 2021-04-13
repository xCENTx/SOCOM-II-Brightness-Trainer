
namespace SOCOM_II_TOOL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_PCSX2Detected = new System.Windows.Forms.Panel();
            this.pcsx2Status = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.BLow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PerfectBrightness = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_PCSX2Detected.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl_PCSX2Detected
            // 
            this.pnl_PCSX2Detected.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_PCSX2Detected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_PCSX2Detected.Controls.Add(this.pcsx2Status);
            this.pnl_PCSX2Detected.Location = new System.Drawing.Point(4, 188);
            this.pnl_PCSX2Detected.Name = "pnl_PCSX2Detected";
            this.pnl_PCSX2Detected.Size = new System.Drawing.Size(250, 24);
            this.pnl_PCSX2Detected.TabIndex = 63;
            // 
            // pcsx2Status
            // 
            this.pcsx2Status.AutoSize = true;
            this.pcsx2Status.BackColor = System.Drawing.Color.Black;
            this.pcsx2Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pcsx2Status.ForeColor = System.Drawing.SystemColors.Control;
            this.pcsx2Status.Location = new System.Drawing.Point(0, 9);
            this.pcsx2Status.Name = "pcsx2Status";
            this.pcsx2Status.Size = new System.Drawing.Size(128, 13);
            this.pcsx2Status.TabIndex = 61;
            this.pcsx2Status.Text = "PCSX2 NOT DETECTED";
            this.pcsx2Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(37, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 50;
            this.label2.Text = "BRIGHTNESS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BLow
            // 
            this.BLow.Location = new System.Drawing.Point(-1, 31);
            this.BLow.Name = "BLow";
            this.BLow.Size = new System.Drawing.Size(125, 32);
            this.BLow.TabIndex = 48;
            this.BLow.Text = "DEFAULT";
            this.BLow.UseVisualStyleBackColor = true;
            this.BLow.Click += new System.EventHandler(this.BLow_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.PerfectBrightness);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BLow);
            this.panel2.Location = new System.Drawing.Point(3, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 64);
            this.panel2.TabIndex = 65;
            // 
            // PerfectBrightness
            // 
            this.PerfectBrightness.Location = new System.Drawing.Point(123, 31);
            this.PerfectBrightness.Name = "PerfectBrightness";
            this.PerfectBrightness.Size = new System.Drawing.Size(125, 32);
            this.PerfectBrightness.TabIndex = 51;
            this.PerfectBrightness.Text = "PERFECT";
            this.PerfectBrightness.UseVisualStyleBackColor = true;
            this.PerfectBrightness.Click += new System.EventHandler(this.PerfectBrightness_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SOCOM_II_MULTI_TOOL.Properties.Resources.U_S__Navy_SEALs_Special_Warfare_insignia;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(257, 215);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnl_PCSX2Detected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SOCOM 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_PCSX2Detected.ResumeLayout(false);
            this.pnl_PCSX2Detected.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl_PCSX2Detected;
        private System.Windows.Forms.Label pcsx2Status;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BLow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PerfectBrightness;
    }
}

