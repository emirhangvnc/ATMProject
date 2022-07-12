using Autofac;
using BusinessLayer.Abstract;
using BusinessLayer.Abstract.Infos;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.Infos;
using BusinessLayer.Helpers;
using DataAccessLayer.Abstract;
using DataAccessLayer.Abstract.Infos;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Concrete.EntityFramework.Infos;

namespace BusinessLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();

            builder.RegisterType<CountryManager>().As<ICountryService>().SingleInstance();
            builder.RegisterType<EfCountryDal>().As<ICountryDal>().SingleInstance();

            builder.RegisterType<CalculationManager>().As<ICalculationService>().SingleInstance();
            builder.RegisterType<EfCalculationDal>().As<ICalculationDal>().SingleInstance();

            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();

            //var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            //builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
            //    .EnableInterfaceInterceptors(new ProxyGenerationOptions()
            //    {
            //        Selector = new AspectInterceptorSelector()
            //    }).SingleInstance();
        }
    }
}