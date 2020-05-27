using restlessmedia.Module.Data;

namespace restlessmedia.Module.Testimonial.Data
{
  public interface ITestimonialDataProvider : IDataProvider
  {
    void Save(TestimonialEntity testimonial);

    void Delete(int testimonialId);

    ModelCollection<TestimonialEntity> List(int page, int maxPerPage);

    TestimonialEntity Random();

    T Read<T>(int testimonialId) where T : TestimonialEntity;
  }
}