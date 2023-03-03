using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class UCLaptop : UserControl
    {
        public event SaveLaptopEventHandler SaveLaptop;
        public event DeleteLaptopEventHandler DeleteLaptop;
        public event LaptopSaveErrorEventHandler LaptopSaveError;
        private bool IsNew { get; set; }

        public UCLaptop(bool isNew = false)
        {
            InitializeComponent();
            fieldsControl(isNew);
        }

        public UCLaptop(Laptop laptop, bool isNew = false)
        {
            InitializeComponent();
            fieldsControl(isNew);

            SetModel(laptop.GetModel());
            SetNumInSystem(laptop.GetNumInSystem());
            SetSN(laptop.GetSN());
            SetSuppliedTo(laptop.GetSuppliedTo());
            SetIsInStock(laptop.GetIsInStock());
        }

        private void fieldsControl(bool mode = false)
        {
            IsNew = mode;

            if (!mode)
            {
                tbModel.Enabled = mode;
                tbNumInSystem.Enabled = mode;
                tbSN.Enabled = mode;
            }
            cbIsInStock.Enabled = mode;
            tbSuppliedTo.Enabled = mode;

            if (mode)
                btnEditSave.Text = "Save";
            else
            {
                btnEditSave.Text = "Edit";

                if (SaveLaptop != null)
                {
                    if (!string.IsNullOrWhiteSpace(GetSN()) || !string.IsNullOrWhiteSpace(GetModel()) || !string.IsNullOrWhiteSpace(GetNumInSystem()))
                    {
                        SaveLaptop.Invoke(new SaveLaptopEventArgs(this));
                    }
                    else
                    {
                        LaptopSaveError.Invoke(new LaptopSaveErrorEventArgs("SN, Model and Number in system cannot be empty!"));
                        
                        /*Forcing it...*/
                        tbModel.Enabled = true;
                        tbNumInSystem.Enabled = true;
                        tbSN.Enabled = true;
                        cbIsInStock.Enabled = true;
                        tbSuppliedTo.Enabled = true;
                        btnEditSave.Text = "Save";


                        return;
                    }

                }
            }
        }

        public bool GetIsInStock() { return cbIsInStock.Checked; }
        public string GetModel() { return tbModel.Text; }
        public string GetNumInSystem() { return tbNumInSystem.Text; }
        public string GetSN() { return tbSN.Text; }
        public string GetSuppliedTo() { return tbSuppliedTo.Text; }
        public bool GetIsNew()
        {
            return IsNew;
        }

        public void SetIsInStock(bool isInStock) { cbIsInStock.Checked = isInStock; }
        public void SetModel(string model) { tbModel.Text = model; }
        public void SetNumInSystem(string num) { tbNumInSystem.Text = num; }
        public void SetSN(string sn) { tbSN.Text = sn; }
        public void SetSuppliedTo(string suppliedTo) { tbSuppliedTo.Text = suppliedTo; }





        private void cbIsInStock_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsInStock.Checked)
            {
                pnlStockIndicator.BackColor = Color.Green;
                pnlStockIndicator.Visible = true;
                pnlStockIndicator.ForeColor = Color.Black;
                lblisInStockIndicator.Text = "In Stock";

            }
            else
            {
                pnlStockIndicator.BackColor = Color.Red;
                pnlStockIndicator.Visible = true;
                pnlStockIndicator.ForeColor = Color.White;
                lblisInStockIndicator.Text = "Not In Stock";
            }
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (btnEditSave.Text == "Save")
                fieldsControl();
            else
                fieldsControl(true);
        }

        private void tb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fieldsControl();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this laptop?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes)
                return;

            DeleteLaptop.Invoke(new DeleteLaptopEventArgs(this));
        }
    }
}
