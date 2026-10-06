namespace Bai5_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblSelected;

        private System.Windows.Forms.ComboBox cboCategory;

        private System.Windows.Forms.ListBox lstAvailableServices;
        private System.Windows.Forms.ListBox lstSelectedServices;

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblPayment;

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtPayment;

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

            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();

            this.cboCategory = new System.Windows.Forms.ComboBox();

            this.lstAvailableServices = new System.Windows.Forms.ListBox();
            this.lstSelectedServices = new System.Windows.Forms.ListBox();

            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();

            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();

            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, 30);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(76, 15);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Loại dịch vụ:";

            // cboCategory
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(130, 27);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(250, 23);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.SelectedIndexChanged +=
                new System.EventHandler(this.cboCategory_SelectedIndexChanged);

            // lblAvailable
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(30, 75);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(112, 15);
            this.lblAvailable.TabIndex = 2;
            this.lblAvailable.Text = "Dịch vụ có sẵn:";

            // lblSelected
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(480, 75);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(116, 15);
            this.lblSelected.TabIndex = 3;
            this.lblSelected.Text = "Dịch vụ đã chọn:";

            // lstAvailableServices
            this.lstAvailableServices.FormattingEnabled = true;
            this.lstAvailableServices.ItemHeight = 15;
            this.lstAvailableServices.Location = new System.Drawing.Point(30, 100);
            this.lstAvailableServices.Name = "lstAvailableServices";
            this.lstAvailableServices.Size = new System.Drawing.Size(330, 184);
            this.lstAvailableServices.TabIndex = 4;
            this.lstAvailableServices.DoubleClick +=
                new System.EventHandler(this.lstAvailableServices_DoubleClick);

            // lstSelectedServices 
            this.lstSelectedServices.FormattingEnabled = true;
            this.lstSelectedServices.ItemHeight = 15;
            this.lstSelectedServices.Location = new System.Drawing.Point(480, 100);
            this.lstSelectedServices.Name = "lstSelectedServices";
            this.lstSelectedServices.Size = new System.Drawing.Size(330, 184);
            this.lstSelectedServices.TabIndex = 5;

            // btnSelect
            this.btnSelect.Location = new System.Drawing.Point(390, 120);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(60, 35);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = ">";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click +=
                new System.EventHandler(this.btnSelect_Click);

            // btnRemove
            this.btnRemove.Location = new System.Drawing.Point(390, 170);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 35);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click +=
                new System.EventHandler(this.btnRemove_Click);
 
            // btnClearAll
            this.btnClearAll.Location = new System.Drawing.Point(390, 220);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(60, 35);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "<<";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click +=
                new System.EventHandler(this.btnClearAll_Click);

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(30, 325);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 15);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Tổng tiền chưa giảm:";

            // txtTotal
            this.txtTotal.Location = new System.Drawing.Point(180, 322);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(250, 23);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.Text = "0";

            // lblDiscount
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(30, 365);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(126, 15);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "Tỷ lệ chiết khấu (%):";

            // txtDiscount
            this.txtDiscount.Location = new System.Drawing.Point(180, 362);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(250, 23);
            this.txtDiscount.TabIndex = 12;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged +=
                new System.EventHandler(this.txtDiscount_TextChanged);

            // lblPayment
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(30, 405);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(137, 15);
            this.lblPayment.TabIndex = 13;
            this.lblPayment.Text = "Thành tiền thanh toán:";

            // txtPayment
            this.txtPayment.Location = new System.Drawing.Point(180, 402);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(250, 23);
            this.txtPayment.TabIndex = 14;
            this.txtPayment.Text = "0";

            // Form1
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(850, 470);

            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);

            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSelect);

            this.Controls.Add(this.lstSelectedServices);
            this.Controls.Add(this.lstAvailableServices);

            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lblAvailable);

            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblCategory);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Bảng tính tiền dịch vụ";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}