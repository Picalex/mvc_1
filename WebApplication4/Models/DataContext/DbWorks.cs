using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication4.Models.DataContext.Tables;

namespace WebApplication4.Models
{
    public class HomeContext : DbContext       
    {
        //public WorkContext()
        //   : base("name=WorkContext")
        //{
        //}

        public virtual DbSet<TbWork> TbWorks { get; set; }
        public virtual DbSet<TbEmployer> TbEmployers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbWork>()
                .HasMany(x => x.Employers)
                .WithOptional(x => x.TWork)
                .HasForeignKey(x => x.TWorkId)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }


    }
}