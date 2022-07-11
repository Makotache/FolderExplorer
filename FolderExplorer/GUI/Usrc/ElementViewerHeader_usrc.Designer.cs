namespace FolderExplorer
{
    partial class ElementViewerHeader_usrc
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
            this.header_button = new System.Windows.Forms.Button();
            this.filter_comboBox = new System.Windows.Forms.ComboBox();
            this.border_panel = new System.Windows.Forms.Panel();
            this.rightDrag_panel = new System.Windows.Forms.Panel();
            this.leftDrag_panel = new System.Windows.Forms.Panel();
            this.rightDrag_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_button
            // 
            this.header_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header_button.Location = new System.Drawing.Point(12, -1);
            this.header_button.Margin = new System.Windows.Forms.Padding(0);
            this.header_button.Name = "header_button";
            this.header_button.Size = new System.Drawing.Size(186, 23);
            this.header_button.TabIndex = 0;
            this.header_button.Text = "_";
            this.header_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.header_button.UseVisualStyleBackColor = true;
            this.header_button.Click += new System.EventHandler(this.header_button_Click);
            // 
            // filter_comboBox
            // 
            this.filter_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filter_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter_comboBox.FormattingEnabled = true;
            this.filter_comboBox.Location = new System.Drawing.Point(196, 0);
            this.filter_comboBox.Name = "filter_comboBox";
            this.filter_comboBox.Size = new System.Drawing.Size(17, 21);
            this.filter_comboBox.TabIndex = 0;
            // 
            // border_panel
            // 
            this.border_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.border_panel.BackColor = System.Drawing.Color.Black;
            this.border_panel.Location = new System.Drawing.Point(10, 0);
            this.border_panel.Name = "border_panel";
            this.border_panel.Size = new System.Drawing.Size(2, 21);
            this.border_panel.TabIndex = 1;
            // 
            // rightDrag_panel
            // 
            this.rightDrag_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightDrag_panel.Controls.Add(this.border_panel);
            this.rightDrag_panel.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.rightDrag_panel.Location = new System.Drawing.Point(213, 0);
            this.rightDrag_panel.Name = "rightDrag_panel";
            this.rightDrag_panel.Size = new System.Drawing.Size(13, 21);
            this.rightDrag_panel.TabIndex = 2;
            // 
            // leftDrag_panel
            // 
            this.leftDrag_panel.Location = new System.Drawing.Point(0, 0);
            this.leftDrag_panel.Name = "leftDrag_panel";
            this.leftDrag_panel.Size = new System.Drawing.Size(13, 21);
            this.leftDrag_panel.TabIndex = 3;
            // 
            // ElementViewerHeader_usrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.leftDrag_panel);
            this.Controls.Add(this.rightDrag_panel);
            this.Controls.Add(this.header_button);
            this.Controls.Add(this.filter_comboBox);
            this.MinimumSize = new System.Drawing.Size(90, 0);
            this.Name = "ElementViewerHeader_usrc";
            this.Size = new System.Drawing.Size(226, 21);
            this.rightDrag_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button header_button;
        public System.Windows.Forms.ComboBox filter_comboBox;
        private System.Windows.Forms.Panel border_panel;
        private System.Windows.Forms.Panel rightDrag_panel;
        private System.Windows.Forms.Panel leftDrag_panel;
    }
}
