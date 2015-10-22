namespace Sample.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AnotherSample
    {
        // one to many relationship stuff
        private ICollection<Sample> samples;

        public AnotherSample()
        {
            this.samples = new HashSet<Sample>();
        }

        public virtual ICollection<Sample> Samples
        {
            get { return this.samples; }
            set { this.samples = value; }
        }

        // Properties of the Model
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
