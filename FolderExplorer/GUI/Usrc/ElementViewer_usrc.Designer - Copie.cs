namespace FolderExplorer
{
    partial class ElementViewer_usrc
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
            this.name_evh_usrc = new FolderExplorer.ElementViwerHeader_usrc();
            this.lastWriteTime_evh_usrc = new FolderExplorer.ElementViwerHeader_usrc();
            this.SuspendLayout();
            // 
            // name_evh_usrc
            // 
            this.name_evh_usrc.leftCursor = System.Windows.Forms.Cursors.Default;
            this.name_evh_usrc.Location = new System.Drawing.Point(0, 0);
            this.name_evh_usrc.Name = "name_evh_usrc";
            this.name_evh_usrc.rightCursor = System.Windows.Forms.Cursors.VSplit;
            this.name_evh_usrc.Size = new System.Drawing.Size(180, 21);
            this.name_evh_usrc.sortDirection = FolderExplorer.SortDirection.None;
            this.name_evh_usrc.TabIndex = 0;
            this.name_evh_usrc.text = "Name";
            // 
            // lastWriteTime_evh_usrc
            // 
            this.lastWriteTime_evh_usrc.leftCursor = System.Windows.Forms.Cursors.Default;
            this.lastWriteTime_evh_usrc.Location = new System.Drawing.Point(179, 0);
            this.lastWriteTime_evh_usrc.Name = "lastWriteTime_evh_usrc";
            this.lastWriteTime_evh_usrc.rightCursor = System.Windows.Forms.Cursors.VSplit;
            this.lastWriteTime_evh_usrc.Size = new System.Drawing.Size(180, 21);
            this.lastWriteTime_evh_usrc.sortDirection = FolderExplorer.SortDirection.None;
            this.lastWriteTime_evh_usrc.TabIndex = 1;
            this.lastWriteTime_evh_usrc.text = "Modifié le";
            // 
            // ElementViewer_usrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lastWriteTime_evh_usrc);
            this.Controls.Add(this.name_evh_usrc);
            this.Name = "ElementViewer_usrc";
            this.Size = new System.Drawing.Size(647, 262);
            this.Load += new System.EventHandler(this.ElementViewer_usrc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ElementViwerHeader_usrc name_evh_usrc;
        private ElementViwerHeader_usrc lastWriteTime_evh_usrc;
    }
}
