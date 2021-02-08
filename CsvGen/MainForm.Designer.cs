namespace CsvGen
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.txtCdnIpt = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.lblCond = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.txtOutPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCdnIpt
            // 
            this.txtCdnIpt.Location = new System.Drawing.Point(275, 142);
            this.txtCdnIpt.Name = "txtCdnIpt";
            this.txtCdnIpt.Size = new System.Drawing.Size(589, 31);
            this.txtCdnIpt.TabIndex = 0;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(924, 139);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(246, 37);
            this.btnGen.TabIndex = 1;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            // 
            // lblCond
            // 
            this.lblCond.Location = new System.Drawing.Point(61, 139);
            this.lblCond.Name = "lblCond";
            this.lblCond.Size = new System.Drawing.Size(165, 33);
            this.lblCond.TabIndex = 2;
            this.lblCond.Text = "Condition";
            this.lblCond.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOut
            // 
            this.lblOut.Location = new System.Drawing.Point(101, 236);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(125, 36);
            this.lblOut.TabIndex = 3;
            this.lblOut.Text = "Save as";
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOutPath
            // 
            this.txtOutPath.Location = new System.Drawing.Point(274, 236);
            this.txtOutPath.Name = "txtOutPath";
            this.txtOutPath.Size = new System.Drawing.Size(590, 31);
            this.txtOutPath.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(924, 231);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(246, 36);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 549);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtOutPath);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblCond);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.txtCdnIpt);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtOutPath;

        private System.Windows.Forms.Label lblOut;

        private System.Windows.Forms.Label lblCond;

        private System.Windows.Forms.Button btnGen;

        private System.Windows.Forms.TextBox txtCdnIpt;

        #endregion
    }
}