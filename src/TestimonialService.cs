using restlessmedia.Module.Testimonial.Data;
using System;

namespace restlessmedia.Module.Testimonial
{
  internal class TestimonialService : ITestimonialService
  {
    public TestimonialService(ITestimonialDataProvider testimonialDataProvider)
    {
      _testimonialDataProvider = testimonialDataProvider ?? throw new ArgumentNullException(nameof(testimonialDataProvider));
    }

    public void Save(TestimonialEntity testimonial)
    {
      _testimonialDataProvider.Save(testimonial);
    }

    public void Delete(int testimonialId)
    {
      _testimonialDataProvider.Delete(testimonialId);
    }

    public ModelCollection<TestimonialEntity> List(int page, int maxPerPage = 10)
    {
      return _testimonialDataProvider.List(page, maxPerPage);
    }

    public TestimonialEntity Random()
    {
      return _testimonialDataProvider.Random();
    }

    public T Read<T>(int testimonialId)
      where T : TestimonialEntity
    {
      return _testimonialDataProvider.Read<T>(testimonialId);
    }

    private readonly ITestimonialDataProvider _testimonialDataProvider;
  }
}