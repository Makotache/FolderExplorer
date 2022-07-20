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
            this.general_tab = new System.Windows.Forms.TabPage();
            this.openwith_Image_Nom = new System.Windows.Forms.PictureBox();
            this.openwith_Icon = new System.Windows.Forms.PictureBox();
            this.btn_modifier = new System.Windows.Forms.Button();
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
            this.compatibilite_tab = new System.Windows.Forms.TabPage();
            this.signature_tab = new System.Windows.Forms.TabPage();
            this.securite_tab = new System.Windows.Forms.TabPage();
            this.details_tab = new System.Windows.Forms.TabPage();
            this.versions_tab = new System.Windows.Forms.TabPage();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_appliquer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_config_details = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.general_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openwith_Image_Nom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openwith_Icon)).BeginInit();
            this.details_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.general_tab);
            this.tabControl1.Controls.Add(this.compatibilite_tab);
            this.tabControl1.Controls.Add(this.signature_tab);
            this.tabControl1.Controls.Add(this.securite_tab);
            this.tabControl1.Controls.Add(this.details_tab);
            this.tabControl1.Controls.Add(this.versions_tab);
            this.tabControl1.Location = new System.Drawing.Point(6, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 462);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // general_tab
            // 
            this.general_tab.Controls.Add(this.openwith_Image_Nom);
            this.general_tab.Controls.Add(this.openwith_Icon);
            this.general_tab.Controls.Add(this.btn_modifier);
            this.general_tab.Controls.Add(this.cb_cache);
            this.general_tab.Controls.Add(this.cb_lecture_seule);
            this.general_tab.Controls.Add(this.label2);
            this.general_tab.Controls.Add(this.lastAccesTime_label);
            this.general_tab.Controls.Add(this.label15);
            this.general_tab.Controls.Add(this.lastWriteTime_label);
            this.general_tab.Controls.Add(this.label13);
            this.general_tab.Controls.Add(this.creationTime_label);
            this.general_tab.Controls.Add(this.label11);
            this.general_tab.Controls.Add(this.sizeOnDisk_label);
            this.general_tab.Controls.Add(this.label9);
            this.general_tab.Controls.Add(this.size_label);
            this.general_tab.Controls.Add(this.label7);
            this.general_tab.Controls.Add(this.path_label);
            this.general_tab.Controls.Add(this.label5);
            this.general_tab.Controls.Add(this.openWith_label);
            this.general_tab.Controls.Add(this.label3);
            this.general_tab.Controls.Add(this.itemType_label);
            this.general_tab.Controls.Add(this.label1);
            this.general_tab.Controls.Add(this.Tb_name);
            this.general_tab.Location = new System.Drawing.Point(4, 22);
            this.general_tab.Name = "general_tab";
            this.general_tab.Padding = new System.Windows.Forms.Padding(3);
            this.general_tab.Size = new System.Drawing.Size(438, 436);
            this.general_tab.TabIndex = 0;
            this.general_tab.Text = "Général";
            this.general_tab.UseVisualStyleBackColor = true;
            // 
            // openwith_Image_Nom
            // 
            this.openwith_Image_Nom.Location = new System.Drawing.Point(18, 6);
            this.openwith_Image_Nom.Name = "openwith_Image_Nom";
            this.openwith_Image_Nom.Size = new System.Drawing.Size(46, 43);
            this.openwith_Image_Nom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openwith_Image_Nom.TabIndex = 22;
            this.openwith_Image_Nom.TabStop = false;
            // 
            // openwith_Icon
            // 
            this.openwith_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openwith_Icon.Location = new System.Drawing.Point(120, 101);
            this.openwith_Icon.Name = "openwith_Icon";
            this.openwith_Icon.Size = new System.Drawing.Size(24, 23);
            this.openwith_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openwith_Icon.TabIndex = 4;
            this.openwith_Icon.TabStop = false;
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
            this.openWith_label.Location = new System.Drawing.Point(161, 106);
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
            // compatibilite_tab
            // 
            this.compatibilite_tab.Location = new System.Drawing.Point(4, 22);
            this.compatibilite_tab.Name = "compatibilite_tab";
            this.compatibilite_tab.Padding = new System.Windows.Forms.Padding(3);
            this.compatibilite_tab.Size = new System.Drawing.Size(438, 436);
            this.compatibilite_tab.TabIndex = 1;
            this.compatibilite_tab.Text = "Compatibilité";
            this.compatibilite_tab.UseVisualStyleBackColor = true;
            // 
            // signature_tab
            // 
            this.signature_tab.Location = new System.Drawing.Point(4, 22);
            this.signature_tab.Name = "signature_tab";
            this.signature_tab.Padding = new System.Windows.Forms.Padding(3);
            this.signature_tab.Size = new System.Drawing.Size(438, 436);
            this.signature_tab.TabIndex = 2;
            this.signature_tab.Text = "Signature numériques";
            this.signature_tab.UseVisualStyleBackColor = true;
            // 
            // securite_tab
            // 
            this.securite_tab.Location = new System.Drawing.Point(4, 22);
            this.securite_tab.Name = "securite_tab";
            this.securite_tab.Padding = new System.Windows.Forms.Padding(3);
            this.securite_tab.Size = new System.Drawing.Size(438, 436);
            this.securite_tab.TabIndex = 3;
            this.securite_tab.Text = "Sécurité";
            this.securite_tab.UseVisualStyleBackColor = true;
            // 
            // details_tab
            // 
            this.details_tab.Controls.Add(this.btn_config_details);
            this.details_tab.Controls.Add(this.groupBox1);
            this.details_tab.Location = new System.Drawing.Point(4, 22);
            this.details_tab.Name = "details_tab";
            this.details_tab.Padding = new System.Windows.Forms.Padding(3);
            this.details_tab.Size = new System.Drawing.Size(438, 436);
            this.details_tab.TabIndex = 4;
            this.details_tab.Text = "Détails";
            this.details_tab.UseVisualStyleBackColor = true;
            // 
            // versions_tab
            // 
            this.versions_tab.Location = new System.Drawing.Point(4, 22);
            this.versions_tab.Name = "versions_tab";
            this.versions_tab.Padding = new System.Windows.Forms.Padding(3);
            this.versions_tab.Size = new System.Drawing.Size(438, 436);
            this.versions_tab.TabIndex = 5;
            this.versions_tab.Text = "Versions précédentes";
            this.versions_tab.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_config_details
            // 
            this.btn_config_details.Location = new System.Drawing.Point(312, 403);
            this.btn_config_details.Name = "btn_config_details";
            this.btn_config_details.Size = new System.Drawing.Size(120, 23);
            this.btn_config_details.TabIndex = 1;
            this.btn_config_details.Text = "Configuration Détails";
            this.btn_config_details.UseVisualStyleBackColor = true;
            this.btn_config_details.Click += new System.EventHandler(this.btn_config_details_Click);
            // 
            // Properties_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 514);
            this.Controls.Add(this.btn_appliquer);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Properties_form";
            this.Text = "Properties";
            this.tabControl1.ResumeLayout(false);
            this.general_tab.ResumeLayout(false);
            this.general_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openwith_Image_Nom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openwith_Icon)).EndInit();
            this.details_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage general_tab;
        private System.Windows.Forms.TabPage compatibilite_tab;
        private System.Windows.Forms.TabPage signature_tab;
        private System.Windows.Forms.TabPage securite_tab;
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
        private System.Windows.Forms.CheckBox cb_cache;
        private System.Windows.Forms.CheckBox cb_lecture_seule;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_appliquer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.PictureBox openwith_Icon;
        private System.Windows.Forms.PictureBox openwith_Image_Nom;
        private System.Windows.Forms.TabPage details_tab;
        private System.Windows.Forms.TabPage versions_tab;
        private System.Windows.Forms.Button btn_config_details;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}