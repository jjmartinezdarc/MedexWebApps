namespace MedexWebApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IT_Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IT_Staff()
        {
            IT_Weekly_Shift = new HashSet<IT_Weekly_Shift>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string IT_Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Mobile_No { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Sort_No { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IT_Weekly_Shift> IT_Weekly_Shift { get; set; }
    }
}
