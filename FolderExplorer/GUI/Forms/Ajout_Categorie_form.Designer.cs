namespace FolderExplorer
{
    partial class Ajout_Categorie_form
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
            this.tb_nom_categorie = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_nom_categorie
            // 
            this.tb_nom_categorie.Location = new System.Drawing.Point(13, 24);
            this.tb_nom_categorie.Name = "tb_nom_categorie";
            this.tb_nom_categorie.Size = new System.Drawing.Size(178, 20);
            this.tb_nom_categorie.TabIndex = 0;
            this.tb_nom_categorie.Text = "Nom Categorie";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(209, 20);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(44, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Ajout_Categorie_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 71);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_nom_categorie);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ajout_Categorie_form";
            this.Text = "Ajout Categorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nom_categorie;
        private System.Windows.Forms.Button btn_ok;
    }
}