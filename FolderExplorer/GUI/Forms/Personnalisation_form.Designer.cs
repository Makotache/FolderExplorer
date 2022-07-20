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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ajout_details = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ajout_details);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 926);
            this.panel1.TabIndex = 0;
            // 
            // btn_ajout_details
            // 
            this.btn_ajout_details.Location = new System.Drawing.Point(15, 15);
            this.btn_ajout_details.Name = "btn_ajout_details";
            this.btn_ajout_details.Size = new System.Drawing.Size(75, 23);
            this.btn_ajout_details.TabIndex = 0;
            this.btn_ajout_details.Text = "Ajout détail";
            this.btn_ajout_details.UseVisualStyleBackColor = true;
            this.btn_ajout_details.Click += new System.EventHandler(this.btn_ajout_details_Click);
            // 
            // Personnalisation_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 951);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Personnalisation_form";
            this.Text = "Personnalisation_form";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ajout_details;
    }
}