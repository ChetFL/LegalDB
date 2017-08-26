using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using LegalDB.Models;
using LegalDB.Repositories;

namespace LegalDB
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            //Register the Repository in the Unity Container
            container.RegisterType<IRepository<ICCallLog, int>, ICCallLogInfoRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}