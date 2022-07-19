namespace FolderExplorer
{
    partial class LabelEditable
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
            this.edit_textBox = new System.Windows.Forms.TextBox();
            this.visible_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // edit_textBox
            // 
            this.edit_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_textBox.Location = new System.Drawing.Point(0, 0);
            this.edit_textBox.Name = "edit_textBox";
            this.edit_textBox.Size = new System.Drawing.Size(142, 20);
            this.edit_textBox.TabIndex = 0;
            this.edit_textBox.Visible = false;
            this.edit_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edit_textBox_KeyDown);
            // 
            // visible_label
            // 
            this.visible_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visible_label.Location = new System.Drawing.Point(0, 3);
            this.visible_label.Name = "visible_label";
            this.visible_label.Size = new System.Drawing.Size(142, 14);
            this.visible_label.TabIndex = 1;
            this.visible_label.Text = "_";
            // 
            // LabelEditable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.visible_label);
            this.Controls.Add(this.edit_textBox);
            this.Name = "LabelEditable";
            this.Size = new System.Drawing.Size(142, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edit_textBox;
        private System.Windows.Forms.Label visible_label;
    }
}
