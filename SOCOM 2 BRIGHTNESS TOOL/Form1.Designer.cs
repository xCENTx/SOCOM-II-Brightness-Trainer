
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
            this.ProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.pnl_PCSX2Detected = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pcsx2Status = new System.Windows.Forms.Label();
            this.BLow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lockBrightness_checkBox = new System.Windows.Forms.CheckBox();
            this.PerfectBrightness = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MemoryTimer = new System.Windows.Forms.Timer(this.components);
            this.pnl_PCSX2Detected.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessTimer
            // 
            this.ProcessTimer.Enabled = true;
            this.ProcessTimer.Tick += new System.EventHandler(this.ProcessTimer_Tick);
            // 
            // pnl_PCSX2Detected
            // 
            this.pnl_PCSX2Detected.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_PCSX2Detected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_PCSX2Detected.Controls.Add(this.checkBox1);
            this.pnl_PCSX2Detected.Controls.Add(this.pcsx2Status);
            this.pnl_PCSX2Detected.Location = new System.Drawing.Point(3, 179);
            this.pnl_PCSX2Detected.Name = "pnl_PCSX2Detected";
            this.pnl_PCSX2Detected.Size = new System.Drawing.Size(251, 32);
            this.pnl_PCSX2Detected.TabIndex = 63;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkBox1.Location = new System.Drawing.Point(150, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 20);
            this.checkBox1.TabIndex = 62;
            this.checkBox1.Text = "Discord RPC";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pcsx2Status
            // 
            this.pcsx2Status.AutoSize = true;
            this.pcsx2Status.BackColor = System.Drawing.Color.Black;
            this.pcsx2Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pcsx2Status.ForeColor = System.Drawing.SystemColors.Control;
            this.pcsx2Status.Location = new System.Drawing.Point(0, 17);
            this.pcsx2Status.Name = "pcsx2Status";
            this.pcsx2Status.Size = new System.Drawing.Size(128, 13);
            this.pcsx2Status.TabIndex = 61;
            this.pcsx2Status.Text = "PCSX2 NOT DETECTED";
            this.pcsx2Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel2.Controls.Add(this.lockBrightness_checkBox);
            this.panel2.Controls.Add(this.PerfectBrightness);
            this.panel2.Controls.Add(this.BLow);
            this.panel2.Location = new System.Drawing.Point(3, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 64);
            this.panel2.TabIndex = 65;
            // 
            // lockBrightness_checkBox
            // 
            this.lockBrightness_checkBox.AutoSize = true;
            this.lockBrightness_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lockBrightness_checkBox.ForeColor = System.Drawing.Color.Red;
            this.lockBrightness_checkBox.Location = new System.Drawing.Point(3, 0);
            this.lockBrightness_checkBox.Name = "lockBrightness_checkBox";
            this.lockBrightness_checkBox.Size = new System.Drawing.Size(240, 30);
            this.lockBrightness_checkBox.TabIndex = 52;
            this.lockBrightness_checkBox.Text = "LOCK BRIGHTNESS";
            this.lockBrightness_checkBox.UseVisualStyleBackColor = true;
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
            this.pictureBox2.Image = global::SOCOM_2_BRIGHTNESS_TRAINER.Properties.Resources.U_S__Navy_SEALs_Special_Warfare_insignia;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // MemoryTimer
            // 
            this.MemoryTimer.Enabled = true;
            this.MemoryTimer.Tick += new System.EventHandler(this.MemoryTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(257, 212);
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
        private System.Windows.Forms.Timer ProcessTimer;
        private System.Windows.Forms.Panel pnl_PCSX2Detected;
        private System.Windows.Forms.Label pcsx2Status;
        private System.Windows.Forms.Button BLow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PerfectBrightness;
        private System.Windows.Forms.Timer MemoryTimer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox lockBrightness_checkBox;
    }
}

