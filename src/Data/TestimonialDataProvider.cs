using restlessmedia.Module.Data;

namespace restlessmedia.Module.Testimonial.Data
{
  internal class TestimonialDataProvider : TestimonialSqlDataProvider, ITestimonialDataProvider
  {
    public TestimonialDataProvider(IDataContext context)
      : base(context) { }
  }
}