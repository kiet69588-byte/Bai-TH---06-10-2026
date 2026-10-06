using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai5_2
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> services;

        public Form1()
        {
            InitializeComponent();

            services = new Dictionary<string, List<string>>();

            services["Khám bệnh"] = new List<string>()
            {
                "Khám tổng quát - 200000",
                "Khám nội khoa - 150000",
                "Khám ngoại khoa - 180000",
                "Khám chuyên khoa - 250000"
            };

            services["Xét nghiệm"] = new List<string>()
            {
                "Xét nghiệm máu - 120000",
                "Xét nghiệm nước tiểu - 80000",
                "Xét nghiệm đường huyết - 100000",
                "Xét nghiệm mỡ máu - 150000"
            };

            services["Chụp X-Quang"] = new List<string>()
            {
                "X-Quang ngực - 200000",
                "X-Quang tay - 150000",
                "X-Quang chân - 150000",
                "X-Quang cột sống - 300000"
            };

            services["Vắc-xin"] = new List<string>()
            {
                "Vắc-xin cúm - 300000",
                "Vắc-xin viêm gan B - 250000",
                "Vắc-xin HPV - 1500000",
                "Vắc-xin COVID-19 - 200000"
            };

            foreach (string category in services.Keys)
            {
                cboCategory.Items.Add(category);
            }

            if (cboCategory.Items.Count > 0)
            {
                cboCategory.SelectedIndex = 0;
            }
        }

        private void cboCategory_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            lstAvailableServices.Items.Clear();

            string category = cboCategory.SelectedItem.ToString();

            if (services.ContainsKey(category))
            {
                foreach (string service in services[category])
                {
                    lstAvailableServices.Items.Add(service);
                }
            }
        }

        private void btnSelect_Click(
            object sender,
            EventArgs e)
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                string service =
                    lstAvailableServices.SelectedItem.ToString();

                if (!lstSelectedServices.Items.Contains(service))
                {
                    lstSelectedServices.Items.Add(service);

                    lstAvailableServices.Items.Remove(service);

                    CalculateTotal();
                }
                else
                {
                    MessageBox.Show(
                        "Dịch vụ này đã được chọn!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn một dịch vụ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void lstAvailableServices_DoubleClick(
            object sender,
            EventArgs e)
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                string service =
                    lstAvailableServices.SelectedItem.ToString();

                if (!lstSelectedServices.Items.Contains(service))
                {
                    lstSelectedServices.Items.Add(service);

                    lstAvailableServices.Items.Remove(service);

                    CalculateTotal();
                }
            }
        }

        private void btnRemove_Click(
            object sender,
            EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                string service =
                    lstSelectedServices.SelectedItem.ToString();

                lstSelectedServices.Items.Remove(service);

                lstAvailableServices.Items.Add(service);

                CalculateTotal();
            }
        }

        private void btnClearAll_Click(
            object sender,
            EventArgs e)
        {

            while (lstSelectedServices.Items.Count > 0)
            {
                string service =
                    lstSelectedServices.Items[0].ToString();

                lstAvailableServices.Items.Add(service);

                lstSelectedServices.Items.RemoveAt(0);
            }

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = 0;

            foreach (object item in lstSelectedServices.Items)
            {
                string service = item.ToString();

                string[] parts = service.Split('-');

                if (parts.Length >= 2)
                {
                    string priceText =
                        parts[parts.Length - 1].Trim();

                    decimal price;

                    if (decimal.TryParse(
                        priceText,
                        out price))
                    {
                        total += price;
                    }
                }
            }

            txtTotal.Text = total.ToString("N0");

            CalculatePayment(total);
        }

        private void CalculatePayment(decimal total)
        {
            decimal discount;

            if (!decimal.TryParse(
                txtDiscount.Text,
                out discount))
            {
                discount = 0;
            }

            if (discount < 0)
            {
                discount = 0;
            }

            if (discount > 100)
            {
                discount = 100;
            }

            decimal payment =
                total - (total * discount / 100);

            txtPayment.Text =
                payment.ToString("N0");
        }

        private void txtDiscount_TextChanged(
            object sender,
            EventArgs e)
        {
            decimal total = 0;

            decimal.TryParse(
                txtTotal.Text.Replace(",", ""),
                out total);

            CalculatePayment(total);
        }
    }
}