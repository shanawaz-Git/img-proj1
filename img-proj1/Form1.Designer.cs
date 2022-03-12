namespace img_proj1
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picorg = new System.Windows.Forms.PictureBox();
            this.picgrey = new System.Windows.Forms.PictureBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.btngrey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picorg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgrey)).BeginInit();
            this.SuspendLayout();
            // 
            // picorg
            // 
            this.picorg.Location = new System.Drawing.Point(12, 12);
            this.picorg.Name = "picorg";
            this.picorg.Size = new System.Drawing.Size(343, 216);
            this.picorg.TabIndex = 0;
            this.picorg.TabStop = false;
            // 
            // picgrey
            // 
            this.picgrey.Location = new System.Drawing.Point(374, 12);
            this.picgrey.Name = "picgrey";
            this.picgrey.Size = new System.Drawing.Size(367, 216);
            this.picgrey.TabIndex = 1;
            this.picgrey.TabStop = false;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(118, 234);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(94, 29);
            this.btnopen.TabIndex = 2;
            this.btnopen.Text = "open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btngrey
            // 
            this.btngrey.Location = new System.Drawing.Point(523, 234);
            this.btngrey.Name = "btngrey";
            this.btngrey.Size = new System.Drawing.Size(94, 29);
            this.btngrey.TabIndex = 3;
            this.btngrey.Text = "grey";
            this.btngrey.UseVisualStyleBackColor = true;
            this.btngrey.Click += new System.EventHandler(this.btngrey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngrey);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.picgrey);
            this.Controls.Add(this.picorg);
            this.Name = "Form1";
            this.Text = "image-processing";
            ((System.ComponentModel.ISupportInitialize)(this.picorg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgrey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picorg;
        private PictureBox picgrey;
        private Button btnopen;
        private Button btngrey;
    }
}