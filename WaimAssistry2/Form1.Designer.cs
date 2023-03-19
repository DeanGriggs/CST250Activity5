namespace WaimAssistry2
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblHits = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMiss = new System.Windows.Forms.Label();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.tbTrueTime = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbTarget = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Location = new System.Drawing.Point(205, 379);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStop.Location = new System.Drawing.Point(363, 379);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(115, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.Location = new System.Drawing.Point(521, 379);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblHits
            // 
            this.lblHits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHits.AutoSize = true;
            this.lblHits.Location = new System.Drawing.Point(15, 10);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(13, 13);
            this.lblHits.TabIndex = 4;
            this.lblHits.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(401, 418);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblMiss);
            this.panel1.Controls.Add(this.lblHits);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 33);
            this.panel1.TabIndex = 6;
            // 
            // lblMiss
            // 
            this.lblMiss.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMiss.AutoSize = true;
            this.lblMiss.Location = new System.Drawing.Point(768, 10);
            this.lblMiss.Name = "lblMiss";
            this.lblMiss.Size = new System.Drawing.Size(13, 13);
            this.lblMiss.TabIndex = 5;
            this.lblMiss.Text = "0";
            // 
            // tmTime
            // 
            this.tmTime.Enabled = true;
            this.tmTime.Tick += new System.EventHandler(this.tmTime_Tick);
            // 
            // tbTrueTime
            // 
            this.tbTrueTime.Enabled = true;
            this.tbTrueTime.Tick += new System.EventHandler(this.tbTrueTime_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::WaimAssistry2.Properties.Resources._360_F_478490472_zDi7fiDEhoShE6xcYw08gIcfLw7fZefo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pbTarget);
            this.panel2.Location = new System.Drawing.Point(13, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 321);
            this.panel2.TabIndex = 7;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // pbTarget
            // 
            this.pbTarget.BackgroundImage = global::WaimAssistry2.Properties.Resources._58568b014f6ae202fedf2717;
            this.pbTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTarget.ErrorImage = global::WaimAssistry2.Properties.Resources._58568b014f6ae202fedf2717;
            this.pbTarget.Image = global::WaimAssistry2.Properties.Resources._58568b014f6ae202fedf2717;
            this.pbTarget.InitialImage = global::WaimAssistry2.Properties.Resources._58568b014f6ae202fedf2717;
            this.pbTarget.Location = new System.Drawing.Point(448, 78);
            this.pbTarget.Name = "pbTarget";
            this.pbTarget.Size = new System.Drawing.Size(100, 87);
            this.pbTarget.TabIndex = 4;
            this.pbTarget.TabStop = false;
            this.pbTarget.Click += new System.EventHandler(this.pbTarget_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Easy",
            "Meduim",
            "Hard"});
            this.comboBox1.Location = new System.Drawing.Point(392, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Difficulty:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblHits;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer tmTime;
        public System.Windows.Forms.Timer tbTrueTime;
        private System.Windows.Forms.PictureBox pbTarget;
        private System.Windows.Forms.Label lblMiss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

