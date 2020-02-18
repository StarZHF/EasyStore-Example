namespace EasyStore_Example
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
            this.lbWatermark = new System.Windows.Forms.Label();
            this.btnCompile = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbWatermark
            // 
            this.lbWatermark.AutoSize = true;
            this.lbWatermark.Location = new System.Drawing.Point(10, 44);
            this.lbWatermark.Name = "lbWatermark";
            this.lbWatermark.Size = new System.Drawing.Size(49, 13);
            this.lbWatermark.TabIndex = 0;
            this.lbWatermark.Text = "StarLabs";
            // 
            // btnCompile
            // 
            this.btnCompile.Enabled = false;
            this.btnCompile.Location = new System.Drawing.Point(244, 39);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(75, 23);
            this.btnCompile.TabIndex = 1;
            this.btnCompile.Text = "Compile";
            this.btnCompile.UseVisualStyleBackColor = true;
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(13, 13);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(306, 20);
            this.tbPath.TabIndex = 2;
            this.tbPath.Text = "Select Payload...";
            this.tbPath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbPath_MouseDoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 73);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnCompile);
            this.Controls.Add(this.lbWatermark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "CodeDOM Crypter Easy Storage Example | UID: 69588";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWatermark;
        private System.Windows.Forms.Button btnCompile;
        private System.Windows.Forms.TextBox tbPath;
    }
}

