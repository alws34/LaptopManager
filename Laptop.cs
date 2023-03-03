using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace InventoryManager
{
    public class Laptop
    {
        public string Model { get; set; }
        public string SN { get; set; }
        public string NumInLaptopSys { get; set; }
        public string SuppliedTo { get; set; }
        public bool IsInStock { get; set; }

        public Laptop() { }
        public Laptop(UCLaptop us)
        {
            SetModel(us.GetModel());
            SetNumInSystem(us.GetNumInSystem());
            SetSN(us.GetSN());
            SetSuppliedTo(us.GetSuppliedTo());
            SetIsInStock(us.GetIsInStock());
        }


        public string GetSN() { return SN; }
        public string GetSuppliedTo() { return SuppliedTo; }
        public bool GetIsInStock() { return IsInStock; }
        public string GetNumInSystem() { return NumInLaptopSys; }
        public string GetModel() { return Model; }


        public void SetSN(string sn) { SN = sn; }
        public void SetSuppliedTo(string suppliedTo) { SuppliedTo = suppliedTo; }
        public void SetIsInStock(bool isInStock) { IsInStock = isInStock; }
        public void SetNumInSystem(string numInSys) { NumInLaptopSys = numInSys; }
        public void SetModel(string model) { Model = model; }
    }
}

