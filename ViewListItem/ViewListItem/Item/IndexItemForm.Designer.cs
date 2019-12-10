namespace ViewListItem
{
    partial class IndexItemForm
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
            this.grdViewItem = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewAZ = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewAmount = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewItem)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdViewItem
            // 
            this.grdViewItem.AllowUserToAddRows = false;
            this.grdViewItem.AllowUserToDeleteRows = false;
            this.grdViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewItem.Location = new System.Drawing.Point(0, 24);
            this.grdViewItem.Name = "grdViewItem";
            this.grdViewItem.ReadOnly = true;
            this.grdViewItem.Size = new System.Drawing.Size(384, 437);
            this.grdViewItem.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editItemToolStripMenuItem,
            this.viewItemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnUpdate,
            this.btnDelete});
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 22);
            this.btnAdd.Text = "Add Item";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 22);
            this.btnUpdate.Text = "Update Item";
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 22);
            this.btnDelete.Text = "Delete Item";
            // 
            // viewItemToolStripMenuItem
            // 
            this.viewItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewAZ,
            this.btnViewPrice,
            this.btnViewAmount});
            this.viewItemToolStripMenuItem.Name = "viewItemToolStripMenuItem";
            this.viewItemToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.viewItemToolStripMenuItem.Text = "View Item";
            // 
            // btnViewAZ
            // 
            this.btnViewAZ.Name = "btnViewAZ";
            this.btnViewAZ.Size = new System.Drawing.Size(152, 22);
            this.btnViewAZ.Text = "A-Z";
            // 
            // btnViewPrice
            // 
            this.btnViewPrice.Name = "btnViewPrice";
            this.btnViewPrice.Size = new System.Drawing.Size(152, 22);
            this.btnViewPrice.Text = "Price";
            // 
            // btnViewAmount
            // 
            this.btnViewAmount.Name = "btnViewAmount";
            this.btnViewAmount.Size = new System.Drawing.Size(152, 22);
            this.btnViewAmount.Text = "Amount";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(291, 1);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(61, 19);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(216, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(69, 20);
            this.txtFind.TabIndex = 3;
            // 
            // IndexItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.grdViewItem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IndexItemForm";
            this.Text = "View Item From";
            ((System.ComponentModel.ISupportInitialize)(this.grdViewItem)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAdd;
        private System.Windows.Forms.ToolStripMenuItem btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripMenuItem viewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnViewAZ;
        private System.Windows.Forms.ToolStripMenuItem btnViewPrice;
        private System.Windows.Forms.ToolStripMenuItem btnViewAmount;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
    }
}

