using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication4.Models.DataContext.Tables
{
    public class TbEmployer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        long Id { get; set; }
        string FirstName { get; set; } 
        string Phone { get; set; }

        [ForeignKey("TWork")]
        public long? TWorkId { get; set; }

        public virtual TbWork TWork { get; set; }
       

    }
}