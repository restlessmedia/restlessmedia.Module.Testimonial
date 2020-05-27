using Dapper;
using System.Data;

namespace restlessmedia.Module.Testimonial
{
  internal static class DynamicParameterExtensions
  {
    public static void Add(this DynamicParameters parameters, TestimonialEntity testimonial)
    {
      parameters.Add("testimonialId", testimonial.TestimonialId, DbType.Int32, ParameterDirection.InputOutput, 4);
      parameters.Add("message", testimonial.Message);
      parameters.Add("source", testimonial.Source);
      parameters.Add("sourceDate", testimonial.SourceDate);
    }
  }
}