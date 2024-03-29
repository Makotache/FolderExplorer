﻿namespace FolderExplorer
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
            this.refresh_timer = new System.Windows.Forms.Timer(this.components);
            this.containerRow_panel = new System.Windows.Forms.Panel();
            this.size_evh_usrc = new FolderExplorer.ElementViewerHeader();
            this.type_evh_usrc = new FolderExplorer.ElementViewerHeader();
            this.lastWriteTime_evh_usrc = new FolderExplorer.ElementViewerHeader();
            this.name_evh_usrc = new FolderExplorer.ElementViewerHeader();
            this.SuspendLayout();
            // 
            // moveHeader_timer
            // 
            this.refresh_timer.Interval = 15;
            this.refresh_timer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // containerRow_panel
            // 
            this.containerRow_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerRow_panel.AutoScroll = true;
            this.containerRow_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.containerRow_panel.Location = new System.Drawing.Point(0, 30);
            this.containerRow_panel.Name = "containerRow_panel";
            this.containerRow_panel.Size = new System.Drawing.Size(1237, 500);
            this.containerRow_panel.TabIndex = 4;
            this.containerRow_panel.Click += new System.EventHandler(this.Evr_Click);
            // 
            // size_evh_usrc
            // 
            this.size_evh_usrc.leftCursor = System.Windows.Forms.Cursors.Default;
            this.size_evh_usrc.Location = new System.Drawing.Point(488, 0);
            this.size_evh_usrc.metaDataElement = FolderExplorer.MetaDataElement.Size;
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
            this.type_evh_usrc.metaDataElement = FolderExplorer.MetaDataElement.ItemType;
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.containerRow_panel);
            this.Controls.Add(this.size_evh_usrc);
            this.Controls.Add(this.type_evh_usrc);
            this.Controls.Add(this.lastWriteTime_evh_usrc);
            this.Controls.Add(this.name_evh_usrc);
            this.Name = "ElementViewer";
            this.Size = new System.Drawing.Size(1237, 530);
            this.ResumeLayout(false);

        }

        #endregion

        private ElementViewerHeader name_evh_usrc;
        private ElementViewerHeader lastWriteTime_evh_usrc;
        private System.Windows.Forms.Timer refresh_timer;
        private ElementViewerHeader size_evh_usrc;
        private ElementViewerHeader type_evh_usrc;
        private System.Windows.Forms.Panel containerRow_panel;
    }
}
