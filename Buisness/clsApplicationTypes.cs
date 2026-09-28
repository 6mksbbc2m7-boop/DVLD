using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessDVD;

namespace Buisness
{
    public class clsApplicationTypes
    {
        public  enum enMode  { AddNew = 0, Update = 1 }
        public enMode _Mode=enMode.AddNew;
        public int ID { get; set; }
        public string Title { get; set; }
        public float Fees { get; set; }

        public clsApplicationTypes()
        {
            this.ID = -1;
            this.Title = "";
            this.Fees = 0;
            _Mode = enMode.AddNew;
        }
        public clsApplicationTypes(int ID, string Title, float Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
            _Mode = enMode.Update;
        }

        private bool _AddNewApplicationTypes()
        {
            this.ID = clsApplycationType.AddNewApplicationType(this.Title, this.Fees);
            return (this.ID != -1);
        }
        private bool _UpdateApplicationTypes()
        {
            return clsApplycationType.UpdateApplicationType(this.ID, this.Title, this.Fees);
        }
        public static clsApplicationTypes Find(int ID)
        {
            string Title = "";
            float Fees = 0;
            if (clsApplycationType.GetApplicationTypeInfoById(ID, ref Title, ref Fees))
                return new clsApplicationTypes(ID, Title, Fees);
            else
                return null;
        }
        public static DataTable GetAllApplication()
        {
            return clsApplycationType.GetAllApplicationType();
        }
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if(_AddNewApplicationTypes())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateApplicationTypes();



            }
            return false;
        }

        

    }
}
