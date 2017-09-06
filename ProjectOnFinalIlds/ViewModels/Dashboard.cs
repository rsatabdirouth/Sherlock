using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectOnFinalIlds.Models;
using ProjectOnFinalIlds.ViewModels;
using System.ComponentModel.DataAnnotations;


namespace ProjectOnFinalIlds.ViewModels
{
    public class Dashboard
    {
        [Display(Name = "Search By ProductName")]
        public ICollection<ProductMaster> ProductList { get; set; }

        [Display(Name = "Search By website")]
        public ICollection<WebsiteMaster> WebsiteList { get; set; }

        [Display(Name = "Search By TransferredOn")]
        public ICollection<TransferLog> TransferList { get; set; }

        [Display(Name = "Search By BuyerName")]
        public ICollection<BuyerMaster> BuyerList { get; set; }

        public ICollection<CommonLead> commonLead { get; set; }
        public ICollection<UserMaster> UserList { get; set; }

        public ICollection<Lead> Lead { get; set; }

        public ICollection<CommissionMaster> CommisionsList { get; set; }
        [Display(Name = "Transfer Status")]
        public ICollection<LeadStatusByName> LeadStatus { get; set; }


    }
}
