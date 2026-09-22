

using System.Data;
using clsDataAccesDVDL;

namespace clsCountry
{
    public class clsCountry
    {
        public int ID { set; get; }
        public string CountryName { set; get; }

        public clsCountry()
        {
            this.ID = -1;
            this.CountryName = "";

        }
        private clsCountry(int ID, string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;
        }
        public static clsCountry Find(int ID)
        {
            string CountryName = "";
            bool Isfound = clsCountryData.GetCountryInfoByID(ID, ref CountryName);

            if (Isfound)
            {
                return new clsCountry(ID, CountryName);
            }
            else
            {
                return null;
            }
        }
        public static clsCountry Find(string CountryName)
        {
            int ID = -1;
            bool Isfound = clsCountryData.GetCountryInfoByName(CountryName, ref ID);

            if (Isfound)
            {
                return new clsCountry(ID, CountryName);
            }
            else
            {
                return new clsCountry(ID,CountryName);
            }
        }
        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }
    }
}
