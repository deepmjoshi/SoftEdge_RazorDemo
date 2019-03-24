using RazorDemo.Models.MyDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorDemo.Models
{
    public class ModelAddress
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ContactNo { get; set; }

        public static List<ModelAddress> GetAllFranchiseAddresses()
        {
            ModelAddress objmodelAddress = new ModelAddress
            {
                Country = "India",
                State = "Maharashtra",
                Address1 = "Pune",
                Address2 = "Aundh",
                ContactNo = "5487896585"
            };

            ModelAddress objmodelAddress2 = new ModelAddress
            {
                Country = "India",
                State = "Maharashtra",
                Address1 = "Pune",
                Address2 = "Satara Road",
                ContactNo = "5896978458"
            };

            clsAddressTable.lstAddress.Add(objmodelAddress);
            clsAddressTable.lstAddress.Add(objmodelAddress2);

            return clsAddressTable.lstAddress;
        }
    }
}