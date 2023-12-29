using JobTracking.Models.JobTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobTracking.Models.Staff
{
    public class StaffInfo
    {
        public StaffInfo() { 
        
            this.StaffProjectss=new HashSet<StaffProjects>();

        }

        [Key]
        public int StaffId { get; set; }

        [DisplayName("E-Mail")]
        public string Email { get; set; }

        [DisplayName("Password")]
        [StringLength(16,ErrorMessage = "maximum length cannot be more than 16 characters")]
        public string Password { get; set; }

        [DisplayName("Authorization")]
        [StringLength(30, ErrorMessage = "maximum length cannot be more than 30 characters")]
        public string Authorization { get; set; }
 
        [DisplayName("Full Name")]
        [StringLength(50, ErrorMessage = "maximum length cannot be more than 50 characters")]
        public string NameSurname { get; set; }


        [DisplayName("Profile Picture")]
        public string StaffPhoto { get; set; }

        [DisplayName("Identity Number")]
        [StringLength(25, ErrorMessage = "maximum length cannot be more than 25 characters")]
        public string IdNumber { get; set; }

        [DisplayName("Department")]
        [StringLength(50, ErrorMessage = "maximum length cannot be more than 50 characters")]
        public string Department { get; set; }


        [DisplayName("Task")]
        [StringLength(50, ErrorMessage = "maximum length cannot be more than 50 characters")]
        public string Task { get; set; }

       
        [DisplayName("Details")]
        [StringLength(500, ErrorMessage = "maximum length cannot be more than 500 characters")]
        public string PositionDetail { get; set; }

        
        [DisplayName("Phone Number")]
        [StringLength(20, ErrorMessage = "maximum length cannot be more than 20 characters")]
        public string PhoneNumber { get; set; }

        
        [DisplayName("Address")]
        [StringLength(400, ErrorMessage = "maximum length cannot be more than 400 characters")]
        public string Address { get; set; }

        
        [DisplayName("Marital Status")]
        [StringLength(12, ErrorMessage = "maximum length cannot be more than 12 characters")]
        public string MaritalStatus { get; set; }

        
        [DisplayName("Relative's Information")]
        [StringLength(256, ErrorMessage = "maximum length cannot be more than 256 characters")]
        public string RelativesInformation { get; set; }

        [DisplayName("Relative's Full Name")]
        [StringLength(75, ErrorMessage = "maximum length cannot be more than 75 characters")]
        public string RelativesFullName { get; set; }


        [DisplayName("Relative's Identity Number")]
        [StringLength(25, ErrorMessage = "maximum length cannot be more than 25 characters")]
        public string RelativesIdNumber { get; set; }

        
        [DisplayName("Relative's Phone Number")]
        [StringLength(20, ErrorMessage = "maximum length cannot be more than 20 characters")]
        public string RelativesPhoneNumber { get; set; }

       
        [DisplayName("Birthdate")]
        public DateTime Birthdate { get; set; }

       
        [DisplayName("Employment Date")]
        public DateTime? EmploymentDate { get; set; }

        public virtual ICollection<StaffProjects> StaffProjectss { get; set;}

        


    }
}