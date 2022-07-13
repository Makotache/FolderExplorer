namespace FolderExplorer
{
    partial class AdvancedAttributes_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_indexation = new System.Windows.Forms.CheckBox();
            this.cb_archive = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_compresser = new System.Windows.Forms.CheckBox();
            this.cb_chiffrer = new System.Windows.Forms.CheckBox();
            this.btn_details = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisissez les paramètres que vous voulez pour ce dossier.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_indexation);
            this.groupBox1.Controls.Add(this.cb_archive);
            this.groupBox1.Location = new System.Drawing.Point(13, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attributs de fichier";
            // 
            // cb_indexation
            // 
            this.cb_indexation.Location = new System.Drawing.Point(15, 43);
            this.cb_indexation.Name = "cb_indexation";
            this.cb_indexation.Size = new System.Drawing.Size(297, 32);
            this.cb_indexation.TabIndex = 1;
            this.cb_indexation.Text = "Autoriser l\'indexation du contenu de ce fichier en plus des propriétés de fichier" +
    "";
            this.cb_indexation.UseVisualStyleBackColor = true;
            // 
            // cb_archive
            // 
            this.cb_archive.AutoSize = true;
            this.cb_archive.Location = new System.Drawing.Point(15, 19);
            this.cb_archive.Name = "cb_archive";
            this.cb_archive.Size = new System.Drawing.Size(175, 17);
            this.cb_archive.TabIndex = 0;
            this.cb_archive.Text = "Le fichier est prêt à être archivé";
            this.cb_archive.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_details);
            this.groupBox2.Controls.Add(this.cb_chiffrer);
            this.groupBox2.Controls.Add(this.cb_compresser);
            this.groupBox2.Location = new System.Drawing.Point(13, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attributs de compression ou de chiffrement";
            // 
            // cb_compresser
            // 
            this.cb_compresser.Location = new System.Drawing.Point(15, 33);
            this.cb_compresser.Name = "cb_compresser";
            this.cb_compresser.Size = new System.Drawing.Size(249, 35);
            this.cb_compresser.TabIndex = 0;
            this.cb_compresser.Text = "Compresser le contenu pour libérer de l\'espace disque";
            this.cb_compresser.UseVisualStyleBackColor = true;
            // 
            // cb_chiffrer
            // 
            this.cb_chiffrer.AutoSize = true;
            this.cb_chiffrer.Location = new System.Drawing.Point(15, 74);
            this.cb_chiffrer.Name = "cb_chiffrer";
            this.cb_chiffrer.Size = new System.Drawing.Size(241, 17);
            this.cb_chiffrer.TabIndex = 1;
            this.cb_chiffrer.Text = "Chiffrer le contenu pour sécuriser les données";
            this.cb_chiffrer.UseVisualStyleBackColor = true;
            // 
            // btn_details
            // 
            this.btn_details.Enabled = false;
            this.btn_details.Location = new System.Drawing.Point(283, 98);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(75, 23);
            this.btn_details.TabIndex = 2;
            this.btn_details.Text = "Détails";
            this.btn_details.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(221, 285);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(302, 285);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            // 
            // AdvancedAttributes_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 319);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancedAttributes_form";
            this.ShowIcon = false;
            this.Text = "Attributs avancées";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_indexation;
        private System.Windows.Forms.CheckBox cb_archive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_details;
        private System.Windows.Forms.CheckBox cb_chiffrer;
        private System.Windows.Forms.CheckBox cb_compresser;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_annuler;
    }
}