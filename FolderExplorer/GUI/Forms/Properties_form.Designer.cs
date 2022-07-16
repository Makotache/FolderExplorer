namespace FolderExplorer
{
    partial class Properties_form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.general = new System.Windows.Forms.TabPage();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_avance = new System.Windows.Forms.Button();
            this.cb_cache = new System.Windows.Forms.CheckBox();
            this.cb_lecture_seule = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastAccesTime_label = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lastWriteTime_label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.creationTime_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sizeOnDisk_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.size_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.path_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openWith_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemType_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_name = new System.Windows.Forms.TextBox();
            this.securite = new System.Windows.Forms.TabPage();
            this.details = new System.Windows.Forms.TabPage();
            this.versions_precedentes = new System.Windows.Forms.TabPage();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_appliquer = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.general);
            this.tabControl1.Controls.Add(this.securite);
            this.tabControl1.Controls.Add(this.details);
            this.tabControl1.Controls.Add(this.versions_precedentes);
            this.tabControl1.Location = new System.Drawing.Point(6, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 462);
            this.tabControl1.TabIndex = 0;
            // 
            // general
            // 
            this.general.Controls.Add(this.btn_modifier);
            this.general.Controls.Add(this.btn_avance);
            this.general.Controls.Add(this.cb_cache);
            this.general.Controls.Add(this.cb_lecture_seule);
            this.general.Controls.Add(this.label2);
            this.general.Controls.Add(this.lastAccesTime_label);
            this.general.Controls.Add(this.label15);
            this.general.Controls.Add(this.lastWriteTime_label);
            this.general.Controls.Add(this.label13);
            this.general.Controls.Add(this.creationTime_label);
            this.general.Controls.Add(this.label11);
            this.general.Controls.Add(this.sizeOnDisk_label);
            this.general.Controls.Add(this.label9);
            this.general.Controls.Add(this.size_label);
            this.general.Controls.Add(this.label7);
            this.general.Controls.Add(this.path_label);
            this.general.Controls.Add(this.label5);
            this.general.Controls.Add(this.openWith_label);
            this.general.Controls.Add(this.label3);
            this.general.Controls.Add(this.itemType_label);
            this.general.Controls.Add(this.label1);
            this.general.Controls.Add(this.Tb_name);
            this.general.Location = new System.Drawing.Point(4, 22);
            this.general.Name = "general";
            this.general.Padding = new System.Windows.Forms.Padding(3);
            this.general.Size = new System.Drawing.Size(438, 436);
            this.general.TabIndex = 0;
            this.general.Text = "Général";
            this.general.UseVisualStyleBackColor = true;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(327, 101);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 21;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // btn_avance
            // 
            this.btn_avance.Location = new System.Drawing.Point(309, 370);
            this.btn_avance.Name = "btn_avance";
            this.btn_avance.Size = new System.Drawing.Size(75, 23);
            this.btn_avance.TabIndex = 20;
            this.btn_avance.Text = "Avancé...";
            this.btn_avance.UseVisualStyleBackColor = true;
            this.btn_avance.Click += new System.EventHandler(this.btn_avance_Click);
            // 
            // cb_cache
            // 
            this.cb_cache.AutoSize = true;
            this.cb_cache.Location = new System.Drawing.Point(198, 374);
            this.cb_cache.Name = "cb_cache";
            this.cb_cache.Size = new System.Drawing.Size(57, 17);
            this.cb_cache.TabIndex = 19;
            this.cb_cache.Text = "Caché";
            this.cb_cache.UseVisualStyleBackColor = true;
            // 
            // cb_lecture_seule
            // 
            this.cb_lecture_seule.AutoSize = true;
            this.cb_lecture_seule.Location = new System.Drawing.Point(84, 374);
            this.cb_lecture_seule.Name = "cb_lecture_seule";
            this.cb_lecture_seule.Size = new System.Drawing.Size(90, 17);
            this.cb_lecture_seule.TabIndex = 18;
            this.cb_lecture_seule.Text = "Lecture seule";
            this.cb_lecture_seule.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Attributs :";
            // 
            // lastAccesTime_label
            // 
            this.lastAccesTime_label.AutoSize = true;
            this.lastAccesTime_label.Location = new System.Drawing.Point(131, 328);
            this.lastAccesTime_label.Name = "lastAccesTime_label";
            this.lastAccesTime_label.Size = new System.Drawing.Size(13, 13);
            this.lastAccesTime_label.TabIndex = 16;
            this.lastAccesTime_label.Text = "_";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 328);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Dernier accès le :";
            // 
            // lastWriteTime_label
            // 
            this.lastWriteTime_label.AutoSize = true;
            this.lastWriteTime_label.Location = new System.Drawing.Point(131, 302);
            this.lastWriteTime_label.Name = "lastWriteTime_label";
            this.lastWriteTime_label.Size = new System.Drawing.Size(13, 13);
            this.lastWriteTime_label.TabIndex = 14;
            this.lastWriteTime_label.Text = "_";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Modifié le :";
            // 
            // creationTime_label
            // 
            this.creationTime_label.AutoSize = true;
            this.creationTime_label.Location = new System.Drawing.Point(131, 276);
            this.creationTime_label.Name = "creationTime_label";
            this.creationTime_label.Size = new System.Drawing.Size(13, 13);
            this.creationTime_label.TabIndex = 12;
            this.creationTime_label.Text = "_";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Créé le  :";
            // 
            // sizeOnDisk_label
            // 
            this.sizeOnDisk_label.AutoSize = true;
            this.sizeOnDisk_label.Location = new System.Drawing.Point(131, 205);
            this.sizeOnDisk_label.Name = "sizeOnDisk_label";
            this.sizeOnDisk_label.Size = new System.Drawing.Size(13, 13);
            this.sizeOnDisk_label.TabIndex = 10;
            this.sizeOnDisk_label.Text = "_";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Sur le disque :";
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.Location = new System.Drawing.Point(131, 179);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(13, 13);
            this.size_label.TabIndex = 8;
            this.size_label.Text = "_";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Taille :";
            // 
            // path_label
            // 
            this.path_label.AutoSize = true;
            this.path_label.Location = new System.Drawing.Point(131, 153);
            this.path_label.Name = "path_label";
            this.path_label.Size = new System.Drawing.Size(13, 13);
            this.path_label.TabIndex = 6;
            this.path_label.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Emplacement :";
            // 
            // openWith_label
            // 
            this.openWith_label.AutoSize = true;
            this.openWith_label.Location = new System.Drawing.Point(131, 101);
            this.openWith_label.Name = "openWith_label";
            this.openWith_label.Size = new System.Drawing.Size(13, 13);
            this.openWith_label.TabIndex = 4;
            this.openWith_label.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "S\'ouvre avec :";
            // 
            // itemType_label
            // 
            this.itemType_label.AutoSize = true;
            this.itemType_label.Location = new System.Drawing.Point(131, 62);
            this.itemType_label.Name = "itemType_label";
            this.itemType_label.Size = new System.Drawing.Size(13, 13);
            this.itemType_label.TabIndex = 2;
            this.itemType_label.Text = "_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type du fichier :";
            // 
            // Tb_name
            // 
            this.Tb_name.Location = new System.Drawing.Point(134, 16);
            this.Tb_name.Name = "Tb_name";
            this.Tb_name.Size = new System.Drawing.Size(285, 20);
            this.Tb_name.TabIndex = 0;
            // 
            // securite
            // 
            this.securite.Location = new System.Drawing.Point(4, 22);
            this.securite.Name = "securite";
            this.securite.Padding = new System.Windows.Forms.Padding(3);
            this.securite.Size = new System.Drawing.Size(438, 436);
            this.securite.TabIndex = 1;
            this.securite.Text = "Sécurité";
            this.securite.UseVisualStyleBackColor = true;
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(4, 22);
            this.details.Name = "details";
            this.details.Padding = new System.Windows.Forms.Padding(3);
            this.details.Size = new System.Drawing.Size(438, 436);
            this.details.TabIndex = 2;
            this.details.Text = "Détails";
            this.details.UseVisualStyleBackColor = true;
            // 
            // versions_precedentes
            // 
            this.versions_precedentes.Location = new System.Drawing.Point(4, 22);
            this.versions_precedentes.Name = "versions_precedentes";
            this.versions_precedentes.Padding = new System.Windows.Forms.Padding(3);
            this.versions_precedentes.Size = new System.Drawing.Size(438, 436);
            this.versions_precedentes.TabIndex = 3;
            this.versions_precedentes.Text = "Versions précédentes";
            this.versions_precedentes.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(215, 479);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(296, 479);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 2;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_appliquer
            // 
            this.btn_appliquer.Location = new System.Drawing.Point(377, 479);
            this.btn_appliquer.Name = "btn_appliquer";
            this.btn_appliquer.Size = new System.Drawing.Size(75, 23);
            this.btn_appliquer.TabIndex = 3;
            this.btn_appliquer.Text = "Appliquer";
            this.btn_appliquer.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(94, 436);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(119, 86);
            this.test.TabIndex = 4;
            this.test.TabStop = false;
            // 
            // Properties_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 514);
            this.Controls.Add(this.test);
            this.Controls.Add(this.btn_appliquer);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Properties_form";
            this.Text = "Properties";
            this.tabControl1.ResumeLayout(false);
            this.general.ResumeLayout(false);
            this.general.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage general;
        private System.Windows.Forms.TabPage securite;
        private System.Windows.Forms.TabPage details;
        private System.Windows.Forms.TabPage versions_precedentes;
        private System.Windows.Forms.Label lastAccesTime_label;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lastWriteTime_label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label creationTime_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label sizeOnDisk_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label path_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label openWith_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label itemType_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_avance;
        private System.Windows.Forms.CheckBox cb_cache;
        private System.Windows.Forms.CheckBox cb_lecture_seule;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_appliquer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.PictureBox test;
    }
}