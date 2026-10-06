namespace Bai5_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvDepartments;
        private System.Windows.Forms.ListView lsvEmployees;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ImageList imageList1;

        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colChucVu;
        private System.Windows.Forms.ColumnHeader colNgayVaoLam;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components =
                new System.ComponentModel.Container();

            this.splitContainer1 =
                new System.Windows.Forms.SplitContainer();

            this.tvDepartments =
                new System.Windows.Forms.TreeView();

            this.lsvEmployees =
                new System.Windows.Forms.ListView();

            this.panelTop =
                new System.Windows.Forms.Panel();

            this.lblView =
                new System.Windows.Forms.Label();

            this.cboView =
                new System.Windows.Forms.ComboBox();

            this.imageList1 =
                new System.Windows.Forms.ImageList(
                    this.components);

            this.colMaNV =
                new System.Windows.Forms.ColumnHeader();

            this.colHoTen =
                new System.Windows.Forms.ColumnHeader();

            this.colChucVu =
                new System.Windows.Forms.ColumnHeader();

            this.colNgayVaoLam =
                new System.Windows.Forms.ColumnHeader();

            ((System.ComponentModel.ISupportInitialize)
                (this.splitContainer1)).BeginInit();

            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();

            this.panelTop.SuspendLayout();

            this.SuspendLayout();

            this.splitContainer1.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.splitContainer1.Orientation =
                System.Windows.Forms.Orientation.Vertical;

            this.splitContainer1.SplitterDistance =
                300;

            this.splitContainer1.Panel1.Controls.Add(
                this.tvDepartments);

            this.splitContainer1.Panel2.Controls.Add(
                this.lsvEmployees);

            this.splitContainer1.Panel2.Controls.Add(
                this.panelTop);

            this.tvDepartments.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.tvDepartments.Name =
                "tvDepartments";

            this.tvDepartments.TabIndex = 0;

            this.tvDepartments.ImageList =
                this.imageList1;

            this.tvDepartments.AfterSelect +=
                new System.Windows.Forms.TreeViewEventHandler(
                    this.tvDepartments_AfterSelect);

            this.panelTop.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.panelTop.Height = 50;

            this.panelTop.Controls.Add(
                this.cboView);

            this.panelTop.Controls.Add(
                this.lblView);

            this.lblView.AutoSize = true;

            this.lblView.Location =
                new System.Drawing.Point(15, 15);

            this.lblView.Text =
                "Chế độ xem:";

            this.cboView.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboView.FormattingEnabled = true;

            this.cboView.Items.AddRange(
                new object[]
                {
                    "Details",
                    "LargeIcon",
                    "List"
                });

            this.cboView.Location =
                new System.Drawing.Point(95, 11);

            this.cboView.Size =
                new System.Drawing.Size(130, 23);

            this.cboView.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cboView_SelectedIndexChanged);

            this.lsvEmployees.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.lsvEmployees.Name =
                "lsvEmployees";

            this.lsvEmployees.TabIndex = 1;

            this.lsvEmployees.UseCompatibleStateImageBehavior =
                false;

            this.lsvEmployees.View =
                System.Windows.Forms.View.Details;

            this.lsvEmployees.FullRowSelect =
                true;

            this.lsvEmployees.GridLines =
                true;

            this.lsvEmployees.SmallImageList =
                this.imageList1;

            this.lsvEmployees.LargeImageList =
                this.imageList1;

            this.lsvEmployees.Columns.AddRange(
                new System.Windows.Forms.ColumnHeader[]
                {
                    this.colMaNV,
                    this.colHoTen,
                    this.colChucVu,
                    this.colNgayVaoLam
                });

            this.colMaNV.Text =
                "Mã NV";

            this.colMaNV.Width =
                100;

            this.colHoTen.Text =
                "Họ Tên";

            this.colHoTen.Width =
                180;

            this.colChucVu.Text =
                "Chức vụ";

            this.colChucVu.Width =
                150;

            this.colNgayVaoLam.Text =
                "Ngày vào làm";

            this.colNgayVaoLam.Width =
                120;

            this.imageList1.ColorDepth =
                System.Windows.Forms.ColorDepth.Depth32Bit;

            this.imageList1.ImageSize =
                new System.Drawing.Size(32, 32);

            this.imageList1.Images.Add(
                System.Drawing.SystemIcons.WinLogo);

            this.imageList1.Images.Add(
                System.Drawing.SystemIcons.Question);

            this.imageList1.Images.Add(
                System.Drawing.SystemIcons.Information);

            this.ClientSize =
                new System.Drawing.Size(1100, 650);

            this.Controls.Add(
                this.splitContainer1);

            this.Name =
                "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Quản lý nhân viên";

            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.splitContainer1)).EndInit();

            this.splitContainer1.ResumeLayout(false);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();

            this.ResumeLayout(false);
        }
    }
}