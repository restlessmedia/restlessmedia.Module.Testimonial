using Dapper;
using restlessmedia.Module.Data;
using restlessmedia.Module.Data.Sql;
using System.Linq;

namespace restlessmedia.Module.Testimonial.Data
{
  internal class TestimonialSqlDataProvider : SqlDataProviderBase
  {
    public TestimonialSqlDataProvider(IDataContext context)
      : base(context) { }

    public void Save(TestimonialEntity testimonial)
    {
      DynamicParameters parameters = new DynamicParameters();
      parameters.Add(testimonial);
      Execute("dbo.SPSaveTestimonial", parameters);
      testimonial.TestimonialId = parameters.Get<int>("@testimonialId");
    }

    public void Delete(int testimonialId)
    {
      Execute("dbo.SPDeleteTestimonial", new { testimonialId });
    }

    public ModelCollection<TestimonialEntity> List(int page, int maxPerPage)
    {
      return ModelQuery<TestimonialEntity>("dbo.SPListTestimonials", new { page, maxPerPage });
    }

    public TestimonialEntity Random()
    {
      return base.Query<TestimonialEntity>("dbo.SPRandomTestimonial").FirstOrDefault();
    }

    public T Read<T>(int testimonialId)
      where T : TestimonialEntity
    {
      return Query<T>("dbo.SPReadTestimonial", new { testimonialId }).FirstOrDefault();
    }
  }
}
