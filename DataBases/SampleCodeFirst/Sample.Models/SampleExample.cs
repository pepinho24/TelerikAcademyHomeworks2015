namespace Sample.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SampleExample
    {
        // one sample example has one Sample
        public int SampleId { get; set; }

        public virtual Sample Sample { get; set; }


        // Properties of the Model
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        [Index(IsUnique = true)]
        public string Name { get; set; }
    }
}
