
namespace masterdata_integration
{
    partial class frmSplashScreen
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
            this.lblVersion = new MetroFramework.Controls.MetroLabel();
            this.lblLoading = new MetroFramework.Controls.MetroLabel();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.imagePanel = new MetroFramework.Controls.MetroPanel();
            this.timerSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblVersion.Location = new System.Drawing.Point(199, 380);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(57, 15);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "V . 0 . 0 . 1";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVersion.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.AutoSize = true;
            this.lblLoading.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLoading.Location = new System.Drawing.Point(190, 259);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(91, 19);
            this.lblLoading.TabIndex = 6;
            this.lblLoading.Text = "Yükleniyor...";
            this.lblLoading.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(135, 215);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(231, 13);
            this.progressBar.TabIndex = 5;
            this.progressBar.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // imagePanel
            // 
            this.imagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePanel.BackgroundImage = global::masterdata_integration.Properties.Resources.logo;
            this.imagePanel.HorizontalScrollbarBarColor = true;
            this.imagePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.imagePanel.HorizontalScrollbarSize = 10;
            this.imagePanel.Location = new System.Drawing.Point(135, 129);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(231, 51);
            this.imagePanel.TabIndex = 4;
            this.imagePanel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.imagePanel.VerticalScrollbarBarColor = true;
            this.imagePanel.VerticalScrollbarHighlightOnWheel = false;
            this.imagePanel.VerticalScrollbarSize = 10;
            // 
            // timerSplashScreen
            // 
            this.timerSplashScreen.Enabled = true;
            this.timerSplashScreen.Tick += new System.EventHandler(this.timerSplashScreen_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 395);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.imagePanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplashScreen";
            this.Resizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblVersion;
        private MetroFramework.Controls.MetroLabel lblLoading;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private MetroFramework.Controls.MetroPanel imagePanel;
        private System.Windows.Forms.Timer timerSplashScreen;
    }
}