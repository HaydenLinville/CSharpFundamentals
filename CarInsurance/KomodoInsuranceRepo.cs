using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    public class KomodoInsuranceRepo
    {


        protected readonly List<InsuranceInfo> _insurance = new List<InsuranceInfo>();

        //CRUD

        //Create

        public bool AddInsuranceInfoToInsurance(InsuranceInfo info)
        {
            int startCount = _insurance.Count();
            _insurance.Add(info);
            bool wasAdded = (_insurance.Count() > startCount) ? true : false;
            return wasAdded;
        }

        //Read

        public List<InsuranceInfo> GetInfo()
        {
            return _insurance;
        }

        public InsuranceInfo GetInfoByCustomerId(int id)
        {
            foreach(InsuranceInfo info in _insurance)
            {
                if(info.CustomerId == id)
                {
                    return info;
                }
            }
            return null;


        }

        public InsuranceInfo GetInfoByLastName(string lastName)
        {
            foreach(InsuranceInfo info in _insurance)
            {
                if(info.LastName.ToLower() == lastName.ToLower())
                {
                    return info;
                }
            }
            return null;
        }


        public InsuranceInfo GetInfoByYears(int year)
        {
            foreach(InsuranceInfo info in _insurance)
            {
                if(info.YearsUsed <= 1 && info.YearsUsed <= 5)
                {
                    return info;
                }
            }
            return null;

        }


        //Update

        public bool UpdateInsuranceInfo(int ogId, InsuranceInfo newInfo)
        {
            InsuranceInfo oldInfo = GetInfoByCustomerId(ogId);
            if(oldInfo != null)
            {
                oldInfo.CustomerId = newInfo.CustomerId;
                oldInfo.LastName = newInfo.LastName;
                oldInfo.EnrollDate = newInfo.EnrollDate;
                oldInfo.Age = newInfo.Age;
                oldInfo.YearsUsed = newInfo.YearsUsed;
                return true;
            }
            else
            {
                return false;
            }
        }


        //Delete
        public bool DeleteExistingInfo(InsuranceInfo currentInfo)
        {
            bool deleteInfo = _insurance.Remove(currentInfo);
            return deleteInfo;
        }

    }
}
