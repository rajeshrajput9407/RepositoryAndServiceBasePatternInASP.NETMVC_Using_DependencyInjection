using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Repository;
using Repository.IRepository;
using Repository.Repository;
using Services.IService;
using Services.Service;

namespace RepositoryServicePatternWithMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<IStudentService, StudentService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}