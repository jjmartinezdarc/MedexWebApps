namespace MedexWebApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IT_Weekly_Shift
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IT_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Week_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Shift_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Remarks { get; set; }

        public virtual IT_Staff IT_Staff { get; set; }

        public virtual Shift Shift { get; set; }

        public virtual Week Week { get; set; }
    }
}
