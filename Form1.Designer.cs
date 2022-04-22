namespace Clicker
{
    partial class frmClicker
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
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnClicker1 = new System.Windows.Forms.Button();
            this.btnClicker2 = new System.Windows.Forms.Button();
            this.btnClicker3 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClicker5 = new System.Windows.Forms.Button();
            this.bgwClicker1 = new System.ComponentModel.BackgroundWorker();
            this.bgwClicker2 = new System.ComponentModel.BackgroundWorker();
            this.bgwClicker3 = new System.ComponentModel.BackgroundWorker();
            this.bgwClicker4 = new System.ComponentModel.BackgroundWorker();
            this.bgwClicker5 = new System.ComponentModel.BackgroundWorker();
            this.bgwCombine = new System.ComponentModel.BackgroundWorker();
            this.lblOwned1 = new System.Windows.Forms.Label();
            this.lblOwned5 = new System.Windows.Forms.Label();
            this.lblOwned4 = new System.Windows.Forms.Label();
            this.lblOwned3 = new System.Windows.Forms.Label();
            this.lblOwned2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCounter
            // 
            this.lblCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(0, 0);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(882, 503);
            this.lblCounter.TabIndex = 0;
            this.lblCounter.Text = "0";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClick
            // 
            this.btnClick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClick.Location = new System.Drawing.Point(366, 348);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(150, 75);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnClicker1
            // 
            this.btnClicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClicker1.Location = new System.Drawing.Point(0, 1);
            this.btnClicker1.Name = "btnClicker1";
            this.btnClicker1.Size = new System.Drawing.Size(150, 100);
            this.btnClicker1.TabIndex = 2;
            this.btnClicker1.Text = "Clicker 1 (1 Click Per Second) $50";
            this.btnClicker1.UseVisualStyleBackColor = true;
            this.btnClicker1.Click += new System.EventHandler(this.btnClicker1_Click);
            // 
            // btnClicker2
            // 
            this.btnClicker2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClicker2.Location = new System.Drawing.Point(0, 101);
            this.btnClicker2.Name = "btnClicker2";
            this.btnClicker2.Size = new System.Drawing.Size(150, 100);
            this.btnClicker2.TabIndex = 3;
            this.btnClicker2.Text = "Clicker 2 (5 Clicks Per Second) $500";
            this.btnClicker2.UseVisualStyleBackColor = true;
            this.btnClicker2.Click += new System.EventHandler(this.btnClicker2_Click);
            // 
            // btnClicker3
            // 
            this.btnClicker3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClicker3.Location = new System.Drawing.Point(0, 201);
            this.btnClicker3.Name = "btnClicker3";
            this.btnClicker3.Size = new System.Drawing.Size(150, 100);
            this.btnClicker3.TabIndex = 4;
            this.btnClicker3.Text = "Clicker 3 (10 Clicks Per Second) $1250";
            this.btnClicker3.UseVisualStyleBackColor = true;
            this.btnClicker3.Click += new System.EventHandler(this.btnClicker3_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Location = new System.Drawing.Point(0, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 100);
            this.button3.TabIndex = 5;
            this.button3.Text = "Clicker 4 (25 Clicks Per Second) $3000";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnClicker4_Click);
            // 
            // btnClicker5
            // 
            this.btnClicker5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClicker5.Location = new System.Drawing.Point(0, 401);
            this.btnClicker5.Name = "btnClicker5";
            this.btnClicker5.Size = new System.Drawing.Size(150, 100);
            this.btnClicker5.TabIndex = 6;
            this.btnClicker5.Text = "Clicker 5 (50 Clicks Per Second) $7500";
            this.btnClicker5.UseVisualStyleBackColor = true;
            this.btnClicker5.Click += new System.EventHandler(this.btnClicker5_Click);
            // 
            // bgwClicker1
            // 
            this.bgwClicker1.WorkerReportsProgress = true;
            this.bgwClicker1.WorkerSupportsCancellation = true;
            this.bgwClicker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwClicker1_DoWork);
            // 
            // bgwClicker2
            // 
            this.bgwClicker2.WorkerReportsProgress = true;
            this.bgwClicker2.WorkerSupportsCancellation = true;
            this.bgwClicker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwClicker2_DoWork);
            // 
            // bgwClicker3
            // 
            this.bgwClicker3.WorkerReportsProgress = true;
            this.bgwClicker3.WorkerSupportsCancellation = true;
            this.bgwClicker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwClicker3_DoWork);
            // 
            // bgwClicker4
            // 
            this.bgwClicker4.WorkerReportsProgress = true;
            this.bgwClicker4.WorkerSupportsCancellation = true;
            this.bgwClicker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwClicker4_DoWork);
            // 
            // bgwClicker5
            // 
            this.bgwClicker5.WorkerReportsProgress = true;
            this.bgwClicker5.WorkerSupportsCancellation = true;
            this.bgwClicker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwClicker5_DoWork);
            // 
            // bgwCombine
            // 
            this.bgwCombine.WorkerReportsProgress = true;
            this.bgwCombine.WorkerSupportsCancellation = true;
            this.bgwCombine.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCombine_DoWork);
            this.bgwCombine.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwCombine_ProgressChanged);
            // 
            // lblOwned1
            // 
            this.lblOwned1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOwned1.AutoSize = true;
            this.lblOwned1.Location = new System.Drawing.Point(156, 43);
            this.lblOwned1.Name = "lblOwned1";
            this.lblOwned1.Size = new System.Drawing.Size(62, 16);
            this.lblOwned1.TabIndex = 7;
            this.lblOwned1.Text = "Owned: 0";
            this.lblOwned1.Visible = false;
            // 
            // lblOwned5
            // 
            this.lblOwned5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOwned5.AutoSize = true;
            this.lblOwned5.Location = new System.Drawing.Point(156, 443);
            this.lblOwned5.Name = "lblOwned5";
            this.lblOwned5.Size = new System.Drawing.Size(62, 16);
            this.lblOwned5.TabIndex = 8;
            this.lblOwned5.Text = "Owned: 0";
            this.lblOwned5.Visible = false;
            // 
            // lblOwned4
            // 
            this.lblOwned4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOwned4.AutoSize = true;
            this.lblOwned4.Location = new System.Drawing.Point(156, 343);
            this.lblOwned4.Name = "lblOwned4";
            this.lblOwned4.Size = new System.Drawing.Size(62, 16);
            this.lblOwned4.TabIndex = 9;
            this.lblOwned4.Text = "Owned: 0";
            this.lblOwned4.Visible = false;
            // 
            // lblOwned3
            // 
            this.lblOwned3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOwned3.AutoSize = true;
            this.lblOwned3.Location = new System.Drawing.Point(156, 243);
            this.lblOwned3.Name = "lblOwned3";
            this.lblOwned3.Size = new System.Drawing.Size(62, 16);
            this.lblOwned3.TabIndex = 10;
            this.lblOwned3.Text = "Owned: 0";
            this.lblOwned3.Visible = false;
            // 
            // lblOwned2
            // 
            this.lblOwned2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOwned2.AutoSize = true;
            this.lblOwned2.Location = new System.Drawing.Point(156, 143);
            this.lblOwned2.Name = "lblOwned2";
            this.lblOwned2.Size = new System.Drawing.Size(62, 16);
            this.lblOwned2.TabIndex = 11;
            this.lblOwned2.Text = "Owned: 0";
            this.lblOwned2.Visible = false;
            // 
            // frmClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.lblOwned2);
            this.Controls.Add(this.lblOwned3);
            this.Controls.Add(this.lblOwned4);
            this.Controls.Add(this.lblOwned5);
            this.Controls.Add(this.lblOwned1);
            this.Controls.Add(this.btnClicker5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClicker3);
            this.Controls.Add(this.btnClicker2);
            this.Controls.Add(this.btnClicker1);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblCounter);
            this.Name = "frmClicker";
            this.Text = "Clicker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClicker_FormClosed);
            this.Load += new System.EventHandler(this.frmClicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnClicker1;
        private System.Windows.Forms.Button btnClicker2;
        private System.Windows.Forms.Button btnClicker3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClicker5;
        private System.ComponentModel.BackgroundWorker bgwClicker1;
        private System.ComponentModel.BackgroundWorker bgwClicker2;
        private System.ComponentModel.BackgroundWorker bgwClicker3;
        private System.ComponentModel.BackgroundWorker bgwClicker4;
        private System.ComponentModel.BackgroundWorker bgwClicker5;
        private System.ComponentModel.BackgroundWorker bgwCombine;
        private System.Windows.Forms.Label lblOwned1;
        private System.Windows.Forms.Label lblOwned5;
        private System.Windows.Forms.Label lblOwned4;
        private System.Windows.Forms.Label lblOwned3;
        private System.Windows.Forms.Label lblOwned2;
    }
}

