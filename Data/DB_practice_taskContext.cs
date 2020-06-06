using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DB_practice_task.Data
{
    public class DB_practice_taskContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DB_practice_taskContext() : base("name=DB_practice_taskContext")
        {
        }

        public System.Data.Entity.DbSet<DB_practice_task.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<DB_practice_task.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<DB_practice_task.Models.Enrollment> Enrollments { get; set; }
    }
}
