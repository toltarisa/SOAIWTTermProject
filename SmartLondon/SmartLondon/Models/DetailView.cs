using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLondon.Models
{
    public class DetailView
    {
        public string Safety { get; set; }
        public string School { get; set; }
        public string GreenSpace { get; set; }
        public string RentPerMonth { get; set; }
        public string TravelInfo { get; set; }
        public string GeneralDescription { get; set; }
        public string SchoolCount { get; set; }
        public string GetAverageTax { get; set; }
        public double SafetyPercentage { get; set; }
        public Comments CommentsDetail { get; set; }
    }
}
