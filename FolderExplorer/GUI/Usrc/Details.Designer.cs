namespace FolderExplorer
{
    partial class Details
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
            this.header_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.property_label = new System.Windows.Forms.Label();
            this.value_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.BackColor = System.Drawing.SystemColors.Control;
            this.header_label.Location = new System.Drawing.Point(15, 1);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(13, 13);
            this.header_label.TabIndex = 0;
            this.header_label.Text = "_";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 2);
            this.label1.TabIndex = 1;
            // 
            // property_label
            // 
            this.property_label.AutoSize = true;
            this.property_label.Location = new System.Drawing.Point(15, 23);
            this.property_label.Name = "property_label";
            this.property_label.Size = new System.Drawing.Size(34, 13);
            this.property_label.TabIndex = 2;
            this.property_label.Text = "prop_";
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Location = new System.Drawing.Point(139, 23);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(27, 13);
            this.value_label.TabIndex = 3;
            this.value_label.Text = "val_";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.property_label);
            this.Controls.Add(this.header_label);
            this.Controls.Add(this.label1);
            this.Name = "Details";
            this.Size = new System.Drawing.Size(380, 41);
            this.Load += new System.EventHandler(this.Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label property_label;
        private System.Windows.Forms.Label value_label;
    }
}
