namespace FolderExplorer
{
    partial class Personnalisation_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_details = new System.Windows.Forms.DataGridView();
            this.btn_ajout_details = new System.Windows.Forms.Button();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catégorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_details);
            this.panel1.Controls.Add(this.btn_ajout_details);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 926);
            this.panel1.TabIndex = 0;
            // 
            // dgv_details
            // 
            this.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_details.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Type,
            this.Catégorie});
            this.dgv_details.Location = new System.Drawing.Point(15, 57);
            this.dgv_details.Name = "dgv_details";
            this.dgv_details.Size = new System.Drawing.Size(530, 150);
            this.dgv_details.TabIndex = 1;
            // 
            // btn_ajout_details
            // 
            this.btn_ajout_details.Location = new System.Drawing.Point(15, 15);
            this.btn_ajout_details.Name = "btn_ajout_details";
            this.btn_ajout_details.Size = new System.Drawing.Size(75, 23);
            this.btn_ajout_details.TabIndex = 0;
            this.btn_ajout_details.Text = "Ajout détail";
            this.btn_ajout_details.UseVisualStyleBackColor = true;
            this.btn_ajout_details.Click += new System.EventHandler(this.btn_ajout_details_Click);
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nom.HeaderText = "Nom Détails";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nom.Width = 160;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Type.HeaderText = "Type Détails";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Type.Width = 160;
            // 
            // Catégorie
            // 
            this.Catégorie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Catégorie.HeaderText = "Catégorie Détails";
            this.Catégorie.Name = "Catégorie";
            this.Catégorie.ReadOnly = true;
            this.Catégorie.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Catégorie.Width = 160;
            // 
            // Personnalisation_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 951);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Personnalisation_form";
            this.Text = "Personnalisation_form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ajout_details;
        private System.Windows.Forms.DataGridView dgv_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catégorie;
    }
}