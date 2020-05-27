using Autofac;
using restlessmedia.Module.Testimonial.Data;

namespace restlessmedia.Module.Testimonial
{
  internal class Module : IModule
  {
    public void RegisterComponents(ContainerBuilder containerBuilder)
    {
      containerBuilder.RegisterType<TestimonialDataProvider>().As<ITestimonialDataProvider>().SingleInstance();
      containerBuilder.RegisterType<TestimonialService>().As<ITestimonialService>().SingleInstance();
    }
  }
}