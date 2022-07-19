namespace FolderExplorer
{
    partial class Personnalisation_form
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
            this.Pan_Dispo = new System.Windows.Forms.Panel();
            this.Pan_Final = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Pan_Dispo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pan_Dispo
            // 
            this.Pan_Dispo.Controls.Add(this.button2);
            this.Pan_Dispo.Controls.Add(this.button1);
            this.Pan_Dispo.Location = new System.Drawing.Point(12, 12);
            this.Pan_Dispo.Name = "Pan_Dispo";
            this.Pan_Dispo.Size = new System.Drawing.Size(375, 906);
            this.Pan_Dispo.TabIndex = 0;
            // 
            // Pan_Final
            // 
            this.Pan_Final.Location = new System.Drawing.Point(406, 12);
            this.Pan_Final.Name = "Pan_Final";
            this.Pan_Final.Size = new System.Drawing.Size(382, 906);
            this.Pan_Final.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Personnalisation_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 951);
            this.Controls.Add(this.Pan_Final);
            this.Controls.Add(this.Pan_Dispo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Personnalisation_form";
            this.Text = "Personnalisation_form";
            this.Pan_Dispo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pan_Dispo;
        private System.Windows.Forms.Panel Pan_Final;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}