using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class frmMain : Form
    {
        private Serializer serializer;
        private Dictionary<string, Laptop> laptops;
        private Dictionary<string, UCLaptop> uCLaptops;

        public frmMain()
        {
            InitializeComponent();
            CenterToScreen();
            serializer = new Serializer();
            laptops = new Dictionary<string, Laptop>();
            uCLaptops = new Dictionary<string, UCLaptop>();
            Reload();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            serializer.Save(laptops);
        }

        private void Reload()
        {
            flpLaptops.Controls.Clear();
            uCLaptops.Clear();
            LoadFromDB();
        }

        private void SubscribeUClaptopEvents(UCLaptop uclap)
        {
            uclap.SaveLaptop += Uclap_SaveLaptop;
            uclap.DeleteLaptop += Uclap_DeleteLaptop;
            uclap.LaptopSaveError += Uclap_LaptopSaveError;

            if(!string.IsNullOrWhiteSpace(uclap.GetSN()))
                uCLaptops.Add(uclap.GetSN(), uclap);//else --> do it while saving
        }

        private void Uclap_LaptopSaveError(LaptopSaveErrorEventArgs args)
        {
            lbConsole.Items.Add(args.Msg);
        }

        private void Uclap_DeleteLaptop(DeleteLaptopEventArgs args)
        {
            UCLaptop uclap = args.UCLaptop;
            laptops.Remove(uclap.GetSN());
            flpLaptops.Controls.Remove(uclap);
            uCLaptops.Remove(uclap.GetSN());
            Save();
        }

        private void Uclap_SaveLaptop(SaveLaptopEventArgs args)
        {
            UCLaptop uclap = args.UCLaptop;

            try
            {
                if (!laptops.ContainsKey(uclap.GetSN()))
                {
                    laptops.Remove(uclap.GetSN());
                    laptops.Add(uclap.GetSN(), new Laptop(uclap));
                }
                else {

                    if (!string.IsNullOrWhiteSpace(uclap.GetSN()) && !uCLaptops.ContainsKey(uclap.GetSN()))
                        uCLaptops.Add(uclap.GetSN(), uclap);

                    //if (uCLaptops.ContainsKey(uclap.GetSN())) {
                    //    DialogResult dialogResult = MessageBox.Show("This SN already exists in the DB.\nAre you sure you want to Replace?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    //    if (dialogResult != DialogResult.Yes)
                    //    {
                    //        flpLaptops.Controls.Remove(uclap);
                    //        return;
                    //    }
                    //}
                    laptops[uclap.GetSN()] = new Laptop(uclap);
                }
            }
            catch (ArgumentException)
            {
                lbConsole.Items.Add($"Laptop sn {uclap.GetSN()} already exists in db -- Could not save!");
                return;
            }

            Save();
            Reload();
        }

        private UCLaptop GetNewLaptopUC()
        {
            UCLaptop uclap = new UCLaptop(true);
            SubscribeUClaptopEvents(uclap);
            return uclap;
        }

        private UCLaptop GetExistiongLaptopUC(KeyValuePair<string, Laptop> pair)
        {
            UCLaptop uclap = new UCLaptop(pair.Value);
            SubscribeUClaptopEvents(uclap);
            return uclap;
        }

        private void LoadFromDB()
        {
            lbConsole.Items.Clear();    
            try
            {
                laptops = (Dictionary<string, Laptop>)serializer.Load();
                if (laptops != null && laptops.Count > 0)
                {
                    foreach (KeyValuePair<string, Laptop> laptop in laptops)
                        flpLaptops.Controls.Add(GetExistiongLaptopUC(laptop));
                }
                if (laptops == null)
                    laptops = new Dictionary<string, Laptop>();
            }
            catch (Exception e)
            {
                lbConsole.Items.Add($"ERROR -- Could not load from db::\n\n{e}");
                return;
            }
            lbConsole.Items.Add($"Loaded {laptops.Count} laptops from DB");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnNewLaptop_Click(object sender, EventArgs e)
        {
            flpLaptops.Controls.Add(GetNewLaptopUC());
        }
    }
}
