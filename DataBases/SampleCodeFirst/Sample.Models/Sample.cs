namespace Sample.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Sample
    {
        // one sample has many another samples
        private ICollection<AnotherSample> anotherSamples;
        // one sample has many sample examples
        private ICollection<SampleExample> sampleExamples;

        public Sample()
        {
            this.anotherSamples = new HashSet<AnotherSample>();
            this.sampleExamples = new HashSet<SampleExample>();
        }

        public virtual ICollection<AnotherSample> AnotherSamples
        {
            get { return this.anotherSamples; }
            set { this.anotherSamples = value; }
        }

        public virtual ICollection<SampleExample> SampleExamples
        {
            get { return this.sampleExamples; }
            set { this.sampleExamples = value; }
        }

        // Properties of the Model
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
