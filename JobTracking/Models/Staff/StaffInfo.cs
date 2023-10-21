using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobTracking.Models.Staff
{
    public class StaffInfo
    {
        public int StaffId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Authorization { get; set; }
        public string NameSurname { get; set; }
        public int IdNumber { get; set; }
        public string Department { get; set; }
        public string Task { get; set; }
        public string PositionDetail { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string MaritalStatus { get; set; }
        public string RelativeInformation { get; set; }
        public int RelativesIdNumber { get; set; }
        public string RelativesPhoneNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime? EmploymentDate { get; set; }


    }
}