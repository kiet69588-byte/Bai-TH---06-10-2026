namespace Bai5_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpProductInfo;
        private System.Windows.Forms.GroupBox grpFunction;

        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSearch;

        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.ComboBox cboCategory;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.DataGridView dgvProducts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.grpProductInfo = new System.Windows.Forms.GroupBox();
            this.grpFunction = new System.Windows.Forms.GroupBox();

            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();

            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();

            this.cboCategory = new System.Windows.Forms.ComboBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();

            this.dgvProducts = new System.Windows.Forms.DataGridView();

            this.grpProductInfo.SuspendLayout();
            this.grpFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            this.grpProductInfo.Controls.Add(this.txtProductId);
            this.grpProductInfo.Controls.Add(this.txtProductName);
            this.grpProductInfo.Controls.Add(this.txtUnitPrice);
            this.grpProductInfo.Controls.Add(this.txtQuantity);
            this.grpProductInfo.Controls.Add(this.cboCategory);
            this.grpProductInfo.Controls.Add(this.lblProductId);
            this.grpProductInfo.Controls.Add(this.lblProductName);
            this.grpProductInfo.Controls.Add(this.lblUnitPrice);
            this.grpProductInfo.Controls.Add(this.lblQuantity);
            this.grpProductInfo.Controls.Add(this.lblCategory);

            this.grpProductInfo.Location = new System.Drawing.Point(20, 20);
            this.grpProductInfo.Name = "grpProductInfo";
            this.grpProductInfo.Size = new System.Drawing.Size(850, 150);
            this.grpProductInfo.TabIndex = 0;
            this.grpProductInfo.TabStop = false;
            this.grpProductInfo.Text = "Thông tin sản phẩm";

            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(20, 35);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Text = "Mã SP:";

            this.txtProductId.Location = new System.Drawing.Point(100, 32);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(250, 23);

            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(420, 35);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Text = "Tên SP:";

            this.txtProductName.Location = new System.Drawing.Point(500, 32);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(300, 23);

            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(20, 75);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Text = "Đơn giá:";

            this.txtUnitPrice.Location = new System.Drawing.Point(100, 72);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(250, 23);

            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(420, 75);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Text = "Số lượng:";

            this.txtQuantity.Location = new System.Drawing.Point(500, 72);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(300, 23);

            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 115);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Text = "Danh mục:";

            this.cboCategory.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboCategory.FormattingEnabled = true;

            this.cboCategory.Items.AddRange(new object[]
            {
                "Điện thoại",
                "Laptop",
                "Phụ kiện"
            });

            this.cboCategory.Location =
                new System.Drawing.Point(100, 112);

            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size =
                new System.Drawing.Size(250, 23);

            this.grpFunction.Controls.Add(this.btnAdd);
            this.grpFunction.Controls.Add(this.btnEdit);
            this.grpFunction.Controls.Add(this.btnDelete);
            this.grpFunction.Controls.Add(this.lblSearch);
            this.grpFunction.Controls.Add(this.txtSearch);
            this.grpFunction.Controls.Add(this.btnSearch);

            this.grpFunction.Location =
                new System.Drawing.Point(20, 185);

            this.grpFunction.Name = "grpFunction";
            this.grpFunction.Size =
                new System.Drawing.Size(850, 80);

            this.grpFunction.TabIndex = 1;
            this.grpFunction.TabStop = false;
            this.grpFunction.Text = "Chức năng";

            this.btnAdd.Location =
                new System.Drawing.Point(20, 30);

            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size =
                new System.Drawing.Size(90, 30);

            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;

            this.btnAdd.Click +=
                new System.EventHandler(this.btnAdd_Click);

            this.btnEdit.Location =
                new System.Drawing.Point(120, 30);

            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size =
                new System.Drawing.Size(90, 30);

            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;

            this.btnEdit.Click +=
                new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Location =
                new System.Drawing.Point(220, 30);

            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size =
                new System.Drawing.Size(90, 30);

            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;

            this.btnDelete.Click +=
                new System.EventHandler(this.btnDelete_Click);

            this.lblSearch.AutoSize = true;
            this.lblSearch.Location =
                new System.Drawing.Point(360, 37);

            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Tên SP:";

            this.txtSearch.Location =
                new System.Drawing.Point(420, 33);

            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size =
                new System.Drawing.Size(250, 23);

            this.btnSearch.Location =
                new System.Drawing.Point(690, 30);

            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size =
                new System.Drawing.Size(100, 30);

            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;

            this.btnSearch.Click +=
                new System.EventHandler(this.btnSearch_Click);

            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;

            this.dgvProducts.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvProducts.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvProducts.Location =
                new System.Drawing.Point(20, 285);

            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";

            this.dgvProducts.ReadOnly = true;

            this.dgvProducts.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvProducts.Size =
                new System.Drawing.Size(850, 250);

            this.dgvProducts.TabIndex = 2;

            this.dgvProducts.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvProducts_CellClick);

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(900, 560);

            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.grpFunction);
            this.Controls.Add(this.grpProductInfo);

            this.Name = "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Quản lý danh sách sản phẩm";

            this.grpProductInfo.ResumeLayout(false);
            this.grpProductInfo.PerformLayout();

            this.grpFunction.ResumeLayout(false);
            this.grpFunction.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();

            this.ResumeLayout(false);
        }
    }
}