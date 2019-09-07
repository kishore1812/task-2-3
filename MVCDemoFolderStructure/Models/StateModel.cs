using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemoFolderStructure.Models
{
    public class StateModel
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public CountryModel CountryId { get; set; }
        public  List<CountryModel> GetCountries
        {
            get
            {
                return new List<CountryModel>()
                {
                    new CountryModel()
                    {
                     CountryId=1,
                     CountryName="India",
                    },
                    new CountryModel()
                    {
                        CountryId=2,
                        CountryName="USA",
                    },
                };
            }
        }
    }
}