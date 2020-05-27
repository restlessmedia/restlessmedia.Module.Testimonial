namespace restlessmedia.Module.Testimonial
{
  public interface ITestimonialService : IService
  {
    void Save(TestimonialEntity testimonial);

    void Delete(int testimonialId);

    ModelCollection<TestimonialEntity> List(int page, int maxPerPage = 10);

    TestimonialEntity Random();

    T Read<T>(int testimonialId)
      where T : TestimonialEntity;
  }
}