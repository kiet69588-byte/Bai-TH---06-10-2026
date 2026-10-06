using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bai5_3
{
    public partial class Form1 : Form
    {
        private List<Product> products;
        private BindingSource bindingSource;

        public Form1()
        {
            InitializeComponent();

            products = new List<Product>();
            bindingSource = new BindingSource();

            bindingSource.DataSource = products;
            dgvProducts.DataSource = bindingSource;

            AddSampleData();
        }

        private void AddSampleData()
        {
            products.Add(new Product(
                "SP001",
                "iPhone 15",
                20000000,
                5,
                "Điện thoại"
            ));

            products.Add(new Product(
                "SP002",
                "Laptop Lenovo",
                18000000,
                3,
                "Laptop"
            ));

            products.Add(new Product(
                "SP003",
                "Chuột Logitech",
                500000,
                10,
                "Phụ kiện"
            ));

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            bindingSource.DataSource = null;
            bindingSource.DataSource = products;
            dgvProducts.DataSource = bindingSource;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }

            foreach (Product product in products)
            {
                if (product.ProductId.Equals(
                    txtProductId.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Mã sản phẩm đã tồn tại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
            }

            Product newProduct = new Product();

            newProduct.ProductId = txtProductId.Text.Trim();
            newProduct.ProductName = txtProductName.Text.Trim();
            newProduct.UnitPrice = decimal.Parse(txtUnitPrice.Text);
            newProduct.Quantity = int.Parse(txtQuantity.Text);
            newProduct.Category = cboCategory.Text;

            products.Add(newProduct);

            RefreshGrid();
            ClearInput();

            MessageBox.Show(
                "Thêm sản phẩm thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm!");
                txtProductId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!");
                txtProductName.Focus();
                return false;
            }

            decimal price;

            if (!decimal.TryParse(txtUnitPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0!");
                txtUnitPrice.Focus();
                return false;
            }

            int quantity;

            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                txtQuantity.Focus();
                return false;
            }

            if (cboCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục!");
                cboCategory.Focus();
                return false;
            }

            return true;
        }

        private void dgvProducts_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

            txtProductId.Text =
                row.Cells["ProductId"].Value?.ToString();

            txtProductName.Text =
                row.Cells["ProductName"].Value?.ToString();

            txtUnitPrice.Text =
                row.Cells["UnitPrice"].Value?.ToString();

            txtQuantity.Text =
                row.Cells["Quantity"].Value?.ToString();

            cboCategory.Text =
                row.Cells["Category"].Value?.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }

            Product product = null;

            foreach (Product p in products)
            {
                if (p.ProductId.Equals(
                    txtProductId.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    product = p;
                    break;
                }
            }

            if (product == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!");
                return;
            }

            product.ProductName = txtProductName.Text.Trim();
            product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
            product.Quantity = int.Parse(txtQuantity.Text);
            product.Category = cboCategory.Text;

            RefreshGrid();

            MessageBox.Show(
                "Sửa sản phẩm thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
                return;
            }

            Product product = null;

            foreach (Product p in products)
            {
                if (p.ProductId.Equals(
                    txtProductId.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    product = p;
                    break;
                }
            }

            if (product == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sản phẩm này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                products.Remove(product);

                RefreshGrid();
                ClearInput();

                MessageBox.Show(
                    "Xóa sản phẩm thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (keyword == "")
            {
                RefreshGrid();
                return;
            }

            List<Product> result =
                products
                .Where(p =>
                    p.ProductName.IndexOf(
                        keyword,
                        StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            bindingSource.DataSource = result;
            dgvProducts.DataSource = bindingSource;
        }

        private void ClearInput()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            cboCategory.SelectedIndex = -1;
            txtProductId.Focus();
        }
    }
}