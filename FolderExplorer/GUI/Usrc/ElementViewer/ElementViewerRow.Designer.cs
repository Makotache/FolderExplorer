namespace FolderExplorer
{
    partial class ElementViewerRow
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
            this.name_labelEdit = new FolderExplorer.LabelEditable();
            this.SuspendLayout();
            // 
            // name_labelEdit
            // 
            this.name_labelEdit.ForeColor = System.Drawing.Color.White;
            this.name_labelEdit.Location = new System.Drawing.Point(5, 1);
            this.name_labelEdit.Name = "name_labelEdit";
            this.name_labelEdit.Size = new System.Drawing.Size(142, 20);
            this.name_labelEdit.TabIndex = 0;
            // 
            // ElementViewerRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.name_labelEdit);
            this.Name = "ElementViewerRow";
            this.Size = new System.Drawing.Size(386, 22);
            this.Click += new System.EventHandler(this.ElementViewerRow_Click);
            this.DoubleClick += new System.EventHandler(this.ElementViewerRow_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ElementViewerRow_KeyDown);
            this.MouseLeave += new System.EventHandler(this.ElementViewerRow_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ElementViewerRow_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelEditable name_labelEdit;
    }
}
