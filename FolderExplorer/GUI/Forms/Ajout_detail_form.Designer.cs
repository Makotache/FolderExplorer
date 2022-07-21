namespace FolderExplorer
{
    partial class Ajout_detail_form
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
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.cb_categories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_creer = new System.Windows.Forms.Button();
            this.tb_detail_nom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Nom - Name",
            "Type - Type",
            "Chemin du dossier - FolderPath",
            "Taille - Taille",
            "Date de création - DateC",
            "Modifié le - Modif",
            "Attributs - Attributs",
            "Propriétaire - Owner",
            "Ordinateur - Computer"});
            this.cb_type.Location = new System.Drawing.Point(22, 84);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(299, 21);
            this.cb_type.TabIndex = 0;
            // 
            // cb_categories
            // 
            this.cb_categories.FormattingEnabled = true;
            this.cb_categories.Location = new System.Drawing.Point(22, 141);
            this.cb_categories.Name = "cb_categories";
            this.cb_categories.Size = new System.Drawing.Size(299, 21);
            this.cb_categories.TabIndex = 1;
            this.cb_categories.SelectedValueChanged += new System.EventHandler(this.cb_categories_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type Détail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Catégorie";
            // 
            // btn_creer
            // 
            this.btn_creer.Location = new System.Drawing.Point(246, 180);
            this.btn_creer.Name = "btn_creer";
            this.btn_creer.Size = new System.Drawing.Size(75, 23);
            this.btn_creer.TabIndex = 4;
            this.btn_creer.Text = "Creer";
            this.btn_creer.UseVisualStyleBackColor = true;
            this.btn_creer.Click += new System.EventHandler(this.btn_creer_Click);
            // 
            // tb_detail_nom
            // 
            this.tb_detail_nom.Location = new System.Drawing.Point(22, 30);
            this.tb_detail_nom.Name = "tb_detail_nom";
            this.tb_detail_nom.Size = new System.Drawing.Size(299, 20);
            this.tb_detail_nom.TabIndex = 5;
            this.tb_detail_nom.Text = "Nom Détail";
            // 
            // Ajout_detail_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 225);
            this.Controls.Add(this.tb_detail_nom);
            this.Controls.Add(this.btn_creer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_categories);
            this.Controls.Add(this.cb_type);
            this.Name = "Ajout_detail_form";
            this.Text = "Ajout Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.ComboBox cb_categories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_creer;
        private System.Windows.Forms.TextBox tb_detail_nom;
    }
}