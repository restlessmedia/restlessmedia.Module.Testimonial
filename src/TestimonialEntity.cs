using System;

namespace restlessmedia.Module.Testimonial
{
  public class TestimonialEntity : Entity
  {
    public TestimonialEntity() { }

    public override EntityType EntityType
    {
      get
      {
        return EntityType.Testimonial;
      }
    }

    public override int? EntityId
    {
      get
      {
        return TestimonialId;
      }
    }

    public int? TestimonialId { get; set; }

    public string Message { get; set; }

    public string Source { get; set; }

    public DateTime? SourceDate { get; set; }
  }
}