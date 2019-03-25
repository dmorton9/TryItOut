using System.Web.Mvc;
using TryItOut.CommonInterfaces;
using TryItOut.DataAccess;
using TryItOut.Service;
using Unity;
using Unity.Mvc5;

namespace TryItOut
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ILogin_Service, Login_Service>();

            container.RegisterType<IRegisteredUserRepository, RegisteredUserRepository>();

        DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}