
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
            this.functionPanel = new KvadratnaJednadzba.FunctionPanel();
            this.displayPanel = new KvadratnaJednadzba.DisplayPanel();
            this.displayPanel2 = new KvadratnaJednadzba.DisplayPanel();
            ((System.ComponentModel.ISupportInitialize)(this.functionPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // functionPanel
            // 
            this.functionPanel.BackColor = System.Drawing.SystemColors.Window;
            this.functionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.functionPanel.Location = new System.Drawing.Point(402, 24);
            this.functionPanel.Name = "functionPanel";
            this.functionPanel.Size = new System.Drawing.Size(700, 593);
            this.functionPanel.TabIndex = 3;
            this.functionPanel.TabStop = false;
            // 
            // displayPanel
            // 
            this.displayPanel.Location = new System.Drawing.Point(12, 12);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(310, 472);
            this.displayPanel.TabIndex = 2;
            this.displayPanel.CoefficientChanged += new System.EventHandler(this.displayPanel_CoefficientChanged);
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
            this.ClientSize = new System.Drawing.Size(1204, 681);
            this.Controls.Add(this.functionPanel);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.displayPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.functionPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DisplayPanel displayPanel2;
        private DisplayPanel displayPanel;
        private FunctionPanel functionPanel;
    }
}

