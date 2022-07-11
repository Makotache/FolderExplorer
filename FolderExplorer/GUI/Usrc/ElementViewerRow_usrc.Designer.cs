namespace FolderExplorer
{
    partial class ElementViewerRow_usrc
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
            this.name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.Location = new System.Drawing.Point(15, 8);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(77, 13);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "_";
            // 
            // ElementViewerRow_usrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.name_label);
            this.Name = "ElementViewerRow_usrc";
            this.Size = new System.Drawing.Size(386, 31);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name_label;
    }
}
