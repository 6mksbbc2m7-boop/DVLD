using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessDVD;


namespace Buisness
{

    public class clsTestType
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;
        public enum enTestType { VisionTest = 1, WritenTest = 2, StreetTest = 3 }
        public clsTestType.enTestType ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Fees { get; set; }
        public clsTestType()
        {
            this.ID = clsTestType.enTestType.VisionTest;
            this.Title = "";
            this.Description = "";
            this.Fees = 0;
            Mode = enMode.AddNew;
        }
        public clsTestType(clsTestType.enTestType ID, string Title, string Description, float Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;
            Mode = enMode.Update;
        }
        private bool _AddNewTestType()

        {
            this.ID = (clsTestType.enTestType)clsTestTypes.AddnewTestType(this.Title, this.Description, this.Fees);
            return (this.Title != "");
        }
        private bool _UpdateTestType()
        {
            return clsTestTypes.UpdateTestType((int)this.ID, this.Title, this.Description, this.Fees);
        }
        public static clsTestType Find(clsTestType.enTestType TestTypeID)
        {
            string Title = "", Description = "";
            float fees = 0;
            if (clsTestTypes.GetTestTypeInfoByID((int)TestTypeID, ref Title, ref Description, ref fees))
                return new clsTestType(TestTypeID, Title, Description, fees);
            else
                return null;
        }
        public static DataTable GetAllTestTypes()
        {
            return clsTestTypes.GetAllTestTypes();
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateTestType();

            }
            return false;

        }
    }
}