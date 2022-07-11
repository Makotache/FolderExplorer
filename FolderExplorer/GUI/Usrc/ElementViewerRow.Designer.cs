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
            this.labelEditable1 = new FolderExplorer.LabelEditable();
            this.SuspendLayout();
            // 
            // labelEditable1
            // 
            this.labelEditable1.Location = new System.Drawing.Point(5, 1);
            this.labelEditable1.Name = "labelEditable1";
            this.labelEditable1.Size = new System.Drawing.Size(142, 20);
            this.labelEditable1.TabIndex = 0;
            // 
            // ElementViewerRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelEditable1);
            this.Name = "ElementViewerRow";
            this.Size = new System.Drawing.Size(386, 22);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ElementViewerRow_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelEditable labelEditable1;
    }
}
