using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using JobTracking.Models.Staff;

namespace JobTracking.Models.JobTracking
{
    public class StaffProjects
    {
        public StaffProjects() { 
        
            this.StaffInfos=new HashSet<StaffInfo>();
        }

        [Key]
        public int  StaffProjectId { get; set; }



        [DisplayName("Project Title")]
        [StringLength(75, ErrorMessage = "maximum length cannot be more than 75 characters")]
        public string ProjectTitle { get; set; }

        [DisplayName("Project Detail")]
        [StringLength(500, ErrorMessage = "maximum length cannot be more than 500 characters")]
        public string ProjectDetail { get; set; }

        public DateTime ProjectAssignmentDate { get; set; }

        [DisplayName("Project Priority Status")]
        [StringLength(16, ErrorMessage = "maximum length cannot be more than 16 characters")]
        public string ProjectPriorityStatus { get; set; }

        [DisplayName("Project Progress Status")]
        [StringLength(4, ErrorMessage = "maximum length cannot be more than 4 characters")]
        public string ProjectProgressStatus { get; set; }

        public DateTime? ProjectCompletionDate { get; set; }

        [DisplayName("Project Completion Status")]
        //[StringLength(16, ErrorMessage = "maximum length cannot be more than 3 characters")]
        public bool ProjectCompletionStatus { get; set; }

        public virtual ICollection<StaffInfo> StaffInfos { get; set; }

    }
}