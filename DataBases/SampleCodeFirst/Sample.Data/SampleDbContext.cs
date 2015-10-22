namespace Sample.Data
{
    using System.Data.Entity;
    using Sample.Models;

    public class SampleDbContext : DbContext
    {
        public SampleDbContext()
            : base("Sample")
        {

        }

        public virtual IDbSet<Sample> Samples { get; set; }

        public virtual IDbSet<AnotherSample> AnotherSamples { get; set; }

        public virtual IDbSet<SampleExample> SampleExamples { get; set; }
    }
}
