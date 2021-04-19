
using System;
using System.Windows.Forms;

namespace masterdata_integration
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFileName = new MetroFramework.Controls.MetroTextBox();
            this.lblFileName = new MetroFramework.Controls.MetroLabel();
            this.lblSheet = new MetroFramework.Controls.MetroLabel();
            this.cboSheet = new MetroFramework.Controls.MetroComboBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnSendData = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            // 
            // 
            // 
            this.txtFileName.CustomButton.Image = null;
            this.txtFileName.CustomButton.Location = new System.Drawing.Point(714, 1);
            this.txtFileName.CustomButton.Name = "";
            this.txtFileName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFileName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFileName.CustomButton.TabIndex = 1;
            this.txtFileName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFileName.CustomButton.UseSelectable = true;
            this.txtFileName.CustomButton.Visible = false;
            this.txtFileName.Lines = new string[0];
            this.txtFileName.Location = new System.Drawing.Point(102, 36);
            this.txtFileName.MaxLength = 32767;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.PasswordChar = '\0';
            this.txtFileName.ReadOnly = true;
            this.txtFileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFileName.SelectedText = "";
            this.txtFileName.SelectionLength = 0;
            this.txtFileName.SelectionStart = 0;
            this.txtFileName.ShortcutsEnabled = true;
            this.txtFileName.Size = new System.Drawing.Size(736, 23);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.UseSelectable = true;
            this.txtFileName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFileName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblFileName.Location = new System.Drawing.Point(6, 40);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(61, 15);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "Dosya Adı:";
            // 
            // lblSheet
            // 
            this.lblSheet.AutoSize = true;
            this.lblSheet.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblSheet.Location = new System.Drawing.Point(6, 81);
            this.lblSheet.Name = "lblSheet";
            this.lblSheet.Size = new System.Drawing.Size(70, 15);
            this.lblSheet.TabIndex = 2;
            this.lblSheet.Text = "Excel Sayfası:";
            // 
            // cboSheet
            // 
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.ItemHeight = 23;
            this.cboSheet.Location = new System.Drawing.Point(102, 75);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(900, 29);
            this.cboSheet.TabIndex = 3;
            this.cboSheet.UseSelectable = true;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(844, 36);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(158, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Dosya Yükleyiniz...";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(6, 123);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(996, 674);
            this.dataGrid.TabIndex = 5;
            // 
            // btnSendData
            // 
            this.btnSendData.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSendData.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSendData.Location = new System.Drawing.Point(6, 804);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(996, 46);
            this.btnSendData.TabIndex = 6;
            this.btnSendData.Text = "Verileri SalesArt Veritabanına Gönder";
            this.btnSendData.UseSelectable = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 856);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cboSheet);
            this.Controls.Add(this.lblSheet);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private MetroFramework.Controls.MetroTextBox txtFileName;
        private MetroFramework.Controls.MetroLabel lblFileName;
        private MetroFramework.Controls.MetroLabel lblSheet;
        private MetroFramework.Controls.MetroComboBox cboSheet;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private DataGridView dataGrid;
        private MetroFramework.Controls.MetroButton btnSendData;
    }
}

