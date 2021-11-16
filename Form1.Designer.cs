
namespace KvadratnaJednadzba
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
            this.displayPanel1 = new KvadratnaJednadzba.DisplayPanel();
            this.displayPanel2 = new KvadratnaJednadzba.DisplayPanel();
            this.SuspendLayout();
            // 
            // displayPanel1
            // 
            this.displayPanel1.Location = new System.Drawing.Point(12, 12);
            this.displayPanel1.Name = "displayPanel1";
            this.displayPanel1.Size = new System.Drawing.Size(310, 472);
            this.displayPanel1.TabIndex = 2;
            // 
            // displayPanel2
            // 
            this.displayPanel2.Location = new System.Drawing.Point(374, 151);
            this.displayPanel2.Name = "displayPanel2";
            this.displayPanel2.Size = new System.Drawing.Size(8, 8);
            this.displayPanel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 541);
            this.Controls.Add(this.displayPanel1);
            this.Controls.Add(this.displayPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private DisplayPanel displayPanel2;
        private DisplayPanel displayPanel1;
    }
}

