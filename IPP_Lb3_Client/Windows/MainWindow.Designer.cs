namespace IPP_Lb3.Windows
{
    partial class MainWindow
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
            this.buttonDrawSin = new System.Windows.Forms.Button();
            this.buttonDrawPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDrawSin
            // 
            this.buttonDrawSin.Location = new System.Drawing.Point(12, 12);
            this.buttonDrawSin.Name = "buttonDrawSin";
            this.buttonDrawSin.Size = new System.Drawing.Size(150, 150);
            this.buttonDrawSin.TabIndex = 0;
            this.buttonDrawSin.Text = "Побудувати графік y=sin(x)";
            this.buttonDrawSin.UseVisualStyleBackColor = true;
            this.buttonDrawSin.Click += new System.EventHandler(this.buttonDrawSin_Click);
            // 
            // buttonDrawPar
            // 
            this.buttonDrawPar.Location = new System.Drawing.Point(222, 12);
            this.buttonDrawPar.Name = "buttonDrawPar";
            this.buttonDrawPar.Size = new System.Drawing.Size(150, 150);
            this.buttonDrawPar.TabIndex = 1;
            this.buttonDrawPar.Text = "Побудувати графік -y=x*x";
            this.buttonDrawPar.UseVisualStyleBackColor = true;
            this.buttonDrawPar.Click += new System.EventHandler(this.buttonDrawPar_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 173);
            this.Controls.Add(this.buttonDrawPar);
            this.Controls.Add(this.buttonDrawSin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 212);
            this.MinimumSize = new System.Drawing.Size(400, 212);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кліентська програма";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonDrawSin;
        private System.Windows.Forms.Button buttonDrawPar;

        #endregion
    }
}