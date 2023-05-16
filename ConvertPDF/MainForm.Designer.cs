namespace ConvertPDF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.tulparCard8 = new TulparUI.Controls.TulparCard();
            this.BtnJpegToPdf = new TulparUI.Controls.TulparButton();
            this.tulparCard7 = new TulparUI.Controls.TulparCard();
            this.BtnTiftoPdf = new TulparUI.Controls.TulparButton();
            this.tulparCard6 = new TulparUI.Controls.TulparCard();
            this.BtnConvertPngtoPdf = new TulparUI.Controls.TulparButton();
            this.tulparCard8.SuspendLayout();
            this.tulparCard7.SuspendLayout();
            this.tulparCard6.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // tulparCard8
            // 
            this.tulparCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tulparCard8.Controls.Add(this.BtnJpegToPdf);
            this.tulparCard8.Depth = 0;
            this.tulparCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tulparCard8.Location = new System.Drawing.Point(245, 78);
            this.tulparCard8.Margin = new System.Windows.Forms.Padding(14);
            this.tulparCard8.MouseState = TulparUI.MouseState.HOVER;
            this.tulparCard8.Name = "tulparCard8";
            this.tulparCard8.Padding = new System.Windows.Forms.Padding(14);
            this.tulparCard8.Size = new System.Drawing.Size(200, 150);
            this.tulparCard8.TabIndex = 5;
            // 
            // BtnJpegToPdf
            // 
            this.BtnJpegToPdf.AutoSize = false;
            this.BtnJpegToPdf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnJpegToPdf.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnJpegToPdf.Depth = 0;
            this.BtnJpegToPdf.HighEmphasis = true;
            this.BtnJpegToPdf.Icon = null;
            this.BtnJpegToPdf.Location = new System.Drawing.Point(18, 20);
            this.BtnJpegToPdf.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnJpegToPdf.MouseState = TulparUI.MouseState.HOVER;
            this.BtnJpegToPdf.Name = "BtnJpegToPdf";
            this.BtnJpegToPdf.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnJpegToPdf.Size = new System.Drawing.Size(164, 110);
            this.BtnJpegToPdf.TabIndex = 0;
            this.BtnJpegToPdf.Text = "JPEG to PDF";
            this.BtnJpegToPdf.Type = TulparUI.Controls.TulparButton.TulparButtonType.Contained;
            this.BtnJpegToPdf.UseAccentColor = false;
            this.BtnJpegToPdf.UseVisualStyleBackColor = true;
            this.BtnJpegToPdf.Click += new System.EventHandler(this.BtnJpegToPdf_Click);
            // 
            // tulparCard7
            // 
            this.tulparCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tulparCard7.Controls.Add(this.BtnTiftoPdf);
            this.tulparCard7.Depth = 0;
            this.tulparCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tulparCard7.Location = new System.Drawing.Point(473, 78);
            this.tulparCard7.Margin = new System.Windows.Forms.Padding(14);
            this.tulparCard7.MouseState = TulparUI.MouseState.HOVER;
            this.tulparCard7.Name = "tulparCard7";
            this.tulparCard7.Padding = new System.Windows.Forms.Padding(14);
            this.tulparCard7.Size = new System.Drawing.Size(200, 150);
            this.tulparCard7.TabIndex = 4;
            // 
            // BtnTiftoPdf
            // 
            this.BtnTiftoPdf.AutoSize = false;
            this.BtnTiftoPdf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnTiftoPdf.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnTiftoPdf.Depth = 0;
            this.BtnTiftoPdf.HighEmphasis = true;
            this.BtnTiftoPdf.Icon = null;
            this.BtnTiftoPdf.Location = new System.Drawing.Point(18, 20);
            this.BtnTiftoPdf.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnTiftoPdf.MouseState = TulparUI.MouseState.HOVER;
            this.BtnTiftoPdf.Name = "BtnTiftoPdf";
            this.BtnTiftoPdf.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnTiftoPdf.Size = new System.Drawing.Size(164, 110);
            this.BtnTiftoPdf.TabIndex = 0;
            this.BtnTiftoPdf.Text = "TIF to PDF";
            this.BtnTiftoPdf.Type = TulparUI.Controls.TulparButton.TulparButtonType.Contained;
            this.BtnTiftoPdf.UseAccentColor = false;
            this.BtnTiftoPdf.UseVisualStyleBackColor = true;
            this.BtnTiftoPdf.Click += new System.EventHandler(this.BtnTiftoPdf_Click);
            // 
            // tulparCard6
            // 
            this.tulparCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tulparCard6.Controls.Add(this.BtnConvertPngtoPdf);
            this.tulparCard6.Depth = 0;
            this.tulparCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tulparCard6.Location = new System.Drawing.Point(17, 78);
            this.tulparCard6.Margin = new System.Windows.Forms.Padding(14);
            this.tulparCard6.MouseState = TulparUI.MouseState.HOVER;
            this.tulparCard6.Name = "tulparCard6";
            this.tulparCard6.Padding = new System.Windows.Forms.Padding(14);
            this.tulparCard6.Size = new System.Drawing.Size(200, 150);
            this.tulparCard6.TabIndex = 3;
            // 
            // BtnConvertPngtoPdf
            // 
            this.BtnConvertPngtoPdf.AutoSize = false;
            this.BtnConvertPngtoPdf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnConvertPngtoPdf.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnConvertPngtoPdf.Depth = 0;
            this.BtnConvertPngtoPdf.HighEmphasis = true;
            this.BtnConvertPngtoPdf.Icon = null;
            this.BtnConvertPngtoPdf.Location = new System.Drawing.Point(18, 20);
            this.BtnConvertPngtoPdf.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnConvertPngtoPdf.MouseState = TulparUI.MouseState.HOVER;
            this.BtnConvertPngtoPdf.Name = "BtnConvertPngtoPdf";
            this.BtnConvertPngtoPdf.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnConvertPngtoPdf.Size = new System.Drawing.Size(164, 110);
            this.BtnConvertPngtoPdf.TabIndex = 0;
            this.BtnConvertPngtoPdf.Text = "PNG to PDF";
            this.BtnConvertPngtoPdf.Type = TulparUI.Controls.TulparButton.TulparButtonType.Contained;
            this.BtnConvertPngtoPdf.UseAccentColor = false;
            this.BtnConvertPngtoPdf.UseVisualStyleBackColor = true;
            this.BtnConvertPngtoPdf.Click += new System.EventHandler(this.BtnConvertPngtoPdf_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 247);
            this.Controls.Add(this.tulparCard8);
            this.Controls.Add(this.tulparCard7);
            this.Controls.Add(this.tulparCard6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.Text = "Alırım bii Dua ";
            this.tulparCard8.ResumeLayout(false);
            this.tulparCard7.ResumeLayout(false);
            this.tulparCard6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFile;
        private TulparUI.Controls.TulparCard tulparCard8;
        private TulparUI.Controls.TulparButton BtnJpegToPdf;
        private TulparUI.Controls.TulparCard tulparCard7;
        private TulparUI.Controls.TulparButton BtnTiftoPdf;
        private TulparUI.Controls.TulparCard tulparCard6;
        private TulparUI.Controls.TulparButton BtnConvertPngtoPdf;
    }
}

