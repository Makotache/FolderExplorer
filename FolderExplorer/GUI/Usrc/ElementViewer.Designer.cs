namespace FolderExplorer
{
    partial class ElementViewer
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.moveHeader_timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.size_evh_usrc = new FolderExplorer.ElementViewerHeader();
            this.type_evh_usrc = new FolderExplorer.ElementViewerHeader();
            this.lastWriteTime_evh_usrc = new FolderExplorer.ElementViewerHeader();
            this.name_evh_usrc = new FolderExplorer.ElementViewerHeader();
            this.SuspendLayout();
            // 
            // moveHeader_timer
            // 
            this.moveHeader_timer.Interval = 15;
            this.moveHeader_timer.Tick += new System.EventHandler(this.MoveHeader_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(800, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(600, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            // 
            // size_evh_usrc
            // 
            this.size_evh_usrc.leftCursor = System.Windows.Forms.Cursors.Default;
            this.size_evh_usrc.Location = new System.Drawing.Point(488, 0);
            this.size_evh_usrc.metaDataElement = FolderExplorer.MetaDataElement.Name;
            this.size_evh_usrc.MinimumSize = new System.Drawing.Size(90, 0);
            this.size_evh_usrc.Name = "size_evh_usrc";
            this.size_evh_usrc.rightCursor = System.Windows.Forms.Cursors.VSplit;
            this.size_evh_usrc.Size = new System.Drawing.Size(113, 21);
            this.size_evh_usrc.sortDirection = FolderExplorer.SortDirection.None;
            this.size_evh_usrc.TabIndex = 3;
            // 
            // type_evh_usrc
            // 
            this.type_evh_usrc.leftCursor = System.Windows.Forms.Cursors.Default;
            this.type_evh_usrc.Location = new System.Drawing.Point(358, 0);
            this.type_evh_usrc.metaDataElement = FolderExplorer.MetaDataElement.Name;
            this.type_evh_usrc.MinimumSize = new System.Drawing.Size(90, 0);
            this.type_evh_usrc.Name = "type_evh_usrc";
            this.type_evh_usrc.rightCursor = System.Windows.Forms.Cursors.VSplit;
            this.type_evh_usrc.Size = new System.Drawing.Size(131, 21);
            this.type_evh_usrc.sortDirection = FolderExplorer.SortDirection.None;
            this.type_evh_usrc.TabIndex = 2;
            // 
            // lastWriteTime_evh_usrc
            // 
            this.lastWriteTime_evh_usrc.leftCursor = System.Windows.Forms.Cursors.Default;
            this.lastWriteTime_evh_usrc.Location = new System.Drawing.Point(179, 0);
            this.lastWriteTime_evh_usrc.metaDataElement = FolderExplorer.MetaDataElement.LastWriteTime;
            this.lastWriteTime_evh_usrc.MinimumSize = new System.Drawing.Size(90, 0);
            this.lastWriteTime_evh_usrc.Name = "lastWriteTime_evh_usrc";
            this.lastWriteTime_evh_usrc.rightCursor = System.Windows.Forms.Cursors.VSplit;
            this.lastWriteTime_evh_usrc.Size = new System.Drawing.Size(180, 21);
            this.lastWriteTime_evh_usrc.sortDirection = FolderExplorer.SortDirection.None;
            this.lastWriteTime_evh_usrc.TabIndex = 1;
            // 
            // name_evh_usrc
            // 
            this.name_evh_usrc.leftCursor = System.Windows.Forms.Cursors.Default;
            this.name_evh_usrc.Location = new System.Drawing.Point(0, 0);
            this.name_evh_usrc.metaDataElement = FolderExplorer.MetaDataElement.Name;
            this.name_evh_usrc.MinimumSize = new System.Drawing.Size(90, 0);
            this.name_evh_usrc.Name = "name_evh_usrc";
            this.name_evh_usrc.rightCursor = System.Windows.Forms.Cursors.VSplit;
            this.name_evh_usrc.Size = new System.Drawing.Size(180, 21);
            this.name_evh_usrc.sortDirection = FolderExplorer.SortDirection.None;
            this.name_evh_usrc.TabIndex = 0;
            // 
            // ElementViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size_evh_usrc);
            this.Controls.Add(this.type_evh_usrc);
            this.Controls.Add(this.lastWriteTime_evh_usrc);
            this.Controls.Add(this.name_evh_usrc);
            this.Name = "ElementViewer";
            this.Size = new System.Drawing.Size(1664, 259);
            this.Load += new System.EventHandler(this.ElementViewer_usrc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ElementViewerHeader name_evh_usrc;
        private ElementViewerHeader lastWriteTime_evh_usrc;
        private System.Windows.Forms.Timer moveHeader_timer;
        private ElementViewerHeader size_evh_usrc;
        private ElementViewerHeader type_evh_usrc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
