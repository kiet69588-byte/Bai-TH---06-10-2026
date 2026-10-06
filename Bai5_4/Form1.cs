using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai5_4
{
    public partial class Form1 : Form
    {
        private List<Employee> employees;

        public Form1()
        {
            InitializeComponent();

            employees = new List<Employee>();

            CreateEmployeeData();
            CreateTree();

            cboView.SelectedIndex = 0;
        }

        private void CreateEmployeeData()
        {
            employees.Add(new Employee(
                "NV001",
                "Nguyễn Văn An",
                "Trưởng phòng",
                "10/01/2010",
                "Phòng Kinh doanh",
                "Nhóm Kinh doanh 1"));

            employees.Add(new Employee(
                "NV002",
                "Trần Thị Bình",
                "Nhân viên",
                "15/03/2022",
                "Phòng Kinh doanh",
                "Nhóm Kinh doanh 1"));

            employees.Add(new Employee(
                "NV003",
                "Lê Văn Cường",
                "Nhân viên",
                "20/06/2021",
                "Phòng Kinh doanh",
                "Nhóm Kinh doanh 2"));

            employees.Add(new Employee(
                "NV004",
                "Phạm Thị Dung",
                "Trưởng nhóm",
                "05/02/2018",
                "Phòng Kỹ thuật",
                "Nhóm Kỹ thuật 1"));

            employees.Add(new Employee(
                "NV005",
                "Hoàng Văn Em",
                "Lập trình viên",
                "12/08/2022",
                "Phòng Kỹ thuật",
                "Nhóm Kỹ thuật 1"));

            employees.Add(new Employee(
                "NV006",
                "Đỗ Thị Hoa",
                "Lập trình viên",
                "10/11/2021",
                "Phòng Kỹ thuật",
                "Nhóm Kỹ thuật 2"));

            employees.Add(new Employee(
                "NV007",
                "Vũ Văn Hùng",
                "Trưởng phòng",
                "01/04/2008",
                "Phòng Nhân sự",
                "Nhóm Nhân sự"));

            employees.Add(new Employee(
                "NV008",
                "Nguyễn Thị Lan",
                "Nhân viên",
                "15/09/2023",
                "Phòng Nhân sự",
                "Nhóm Nhân sự"));
        }

        private void CreateTree()
        {
            tvDepartments.Nodes.Clear();

            TreeNode company =
                new TreeNode("Công ty AutoSpeed", 0, 0);

            TreeNode kinhDoanh =
                new TreeNode("Phòng Kinh doanh", 1, 1);

            TreeNode kinhDoanh1 =
                new TreeNode("Nhóm Kinh doanh 1", 2, 2);

            TreeNode kinhDoanh2 =
                new TreeNode("Nhóm Kinh doanh 2", 2, 2);

            kinhDoanh.Nodes.Add(kinhDoanh1);
            kinhDoanh.Nodes.Add(kinhDoanh2);

            TreeNode kyThuat =
                new TreeNode("Phòng Kỹ thuật", 1, 1);

            TreeNode kyThuat1 =
                new TreeNode("Nhóm Kỹ thuật 1", 2, 2);

            TreeNode kyThuat2 =
                new TreeNode("Nhóm Kỹ thuật 2", 2, 2);

            kyThuat.Nodes.Add(kyThuat1);
            kyThuat.Nodes.Add(kyThuat2);

            TreeNode nhanSu =
                new TreeNode("Phòng Nhân sự", 1, 1);

            TreeNode nhanSuNhom =
                new TreeNode("Nhóm Nhân sự", 2, 2);

            nhanSu.Nodes.Add(nhanSuNhom);

            company.Nodes.Add(kinhDoanh);
            company.Nodes.Add(kyThuat);
            company.Nodes.Add(nhanSu);

            tvDepartments.Nodes.Add(company);

            company.Expand();
            kinhDoanh.Expand();
            kyThuat.Expand();
            nhanSu.Expand();
        }

        private void tvDepartments_AfterSelect(
            object sender,
            TreeViewEventArgs e)
        {
            if (e.Node == null)
            {
                return;
            }

            string nodeName = e.Node.Text;

            List<Employee> result =
                new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (nodeName == "Công ty AutoSpeed")
                {
                    result.Add(employee);
                }
                else if (employee.PhongBan == nodeName)
                {
                    result.Add(employee);
                }
                else if (employee.Nhom == nodeName)
                {
                    result.Add(employee);
                }
            }

            ShowEmployees(result);
        }

        private void ShowEmployees(List<Employee> list)
        {
            lsvEmployees.Items.Clear();

            foreach (Employee employee in list)
            {
                ListViewItem item =
                    new ListViewItem(employee.MaNV);

                item.SubItems.Add(employee.HoTen);
                item.SubItems.Add(employee.ChucVu);
                item.SubItems.Add(employee.NgayVaoLam);

                item.ImageIndex = 2;

                lsvEmployees.Items.Add(item);
            }
        }

        private void cboView_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cboView.SelectedIndex == 0)
            {
                lsvEmployees.View = View.Details;
            }
            else if (cboView.SelectedIndex == 1)
            {
                lsvEmployees.View = View.LargeIcon;
            }
            else if (cboView.SelectedIndex == 2)
            {
                lsvEmployees.View = View.List;
            }
        }
    }
}