using JobTracking.Models.JobTracking;
using JobTracking.Models.Staff;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JobTracking.Models.DataContext
{
    public class ProjectTrackingDBContext : DbContext 
    {
        public ProjectTrackingDBContext() : base("ProjectTrackingDB") {
        

        }
        public DbSet<StaffInfo> StaffInfos { get; set; }

        public DbSet<StaffProjects> StaffProjectss { get; set;}
    }
}