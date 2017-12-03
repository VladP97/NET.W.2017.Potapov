namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; set; }

        public int TypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountOwner { get; set; }

        public int Bonus { get; set; }

        public decimal Balance { get; set; }

        public virtual AccountType AccountType { get; set; }
    }
}
