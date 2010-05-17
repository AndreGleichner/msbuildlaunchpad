﻿namespace Lextm.MSBuildLaunchPad
{
    internal partial class Form1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnStart = new System.Windows.Forms.ToolStripButton();
            this.tscbTarget = new System.Windows.Forms.ToolStripComboBox();
            this.tspbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tscbConfiguration = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tscbVersion = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnShowPrompt = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAutoHide = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnStart,
            this.tscbTarget,
            this.tspbProgress,
            this.tscbConfiguration});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(523, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbtnStart
            // 
            this.tsbtnStart.Image = global::Lextm.MSBuildLaunchPad.Properties.Resources.FormRunHS;
            this.tsbtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStart.Name = "tsbtnStart";
            this.tsbtnStart.Size = new System.Drawing.Size(51, 24);
            this.tsbtnStart.Text = "Start";
            this.tsbtnStart.Click += new System.EventHandler(this.TsbtnStartClick);
            // 
            // tscbTarget
            // 
            this.tscbTarget.Name = "tscbTarget";
            this.tscbTarget.Size = new System.Drawing.Size(120, 27);
            this.tscbTarget.Text = "Build";
            // 
            // tspbProgress
            // 
            this.tspbProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspbProgress.Name = "tspbProgress";
            this.tspbProgress.Size = new System.Drawing.Size(120, 24);
            // 
            // tscbConfiguration
            // 
            this.tscbConfiguration.Items.AddRange(new object[] {
            "Debug",
            "Release"});
            this.tscbConfiguration.Name = "tscbConfiguration";
            this.tscbConfiguration.Size = new System.Drawing.Size(120, 27);
            this.tscbConfiguration.Text = "Debug";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tscbVersion,
            this.toolStripSeparator1,
            this.tsbtnShowPrompt,
            this.tsbtnAutoHide});
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(523, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel2.Text = "MSBuild";
            // 
            // tscbVersion
            // 
            this.tscbVersion.Items.AddRange(new object[] {
            "v2.0.50727",
            "v3.5",
            "v4.0.30319"});
            this.tscbVersion.Name = "tscbVersion";
            this.tscbVersion.Size = new System.Drawing.Size(121, 25);
            this.tscbVersion.Text = "v2.0.50727";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnShowPrompt
            // 
            this.tsbtnShowPrompt.CheckOnClick = true;
            this.tsbtnShowPrompt.Image = global::Lextm.MSBuildLaunchPad.Properties.Resources.FullView;
            this.tsbtnShowPrompt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShowPrompt.Name = "tsbtnShowPrompt";
            this.tsbtnShowPrompt.Size = new System.Drawing.Size(99, 22);
            this.tsbtnShowPrompt.Text = "Show Prompt";
            // 
            // tsbtnAutoHide
            // 
            this.tsbtnAutoHide.Checked = true;
            this.tsbtnAutoHide.CheckOnClick = true;
            this.tsbtnAutoHide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbtnAutoHide.Image = global::Lextm.MSBuildLaunchPad.Properties.Resources.Close;
            this.tsbtnAutoHide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAutoHide.Name = "tsbtnAutoHide";
            this.tsbtnAutoHide.Size = new System.Drawing.Size(81, 22);
            this.tsbtnAutoHide.Text = "Auto Hide";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 50);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::Lextm.MSBuildLaunchPad.Properties.Resources.MSBuild_APPICON;
            this.Name = "Form1";
            this.Text = "MSBuild Launch Pad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnStart;
        private System.Windows.Forms.ToolStripComboBox tscbTarget;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripProgressBar tspbProgress;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox tscbVersion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox tscbConfiguration;
        private System.Windows.Forms.ToolStripButton tsbtnShowPrompt;
        private System.Windows.Forms.ToolStripButton tsbtnAutoHide;
        private System.Windows.Forms.Timer timer1;
    }
}

