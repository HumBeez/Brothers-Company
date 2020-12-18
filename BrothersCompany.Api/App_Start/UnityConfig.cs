using BrothersCompany.DomainCore.Interface;
using System;
using System.Web.Http;
using Unity;
using Unity.Injection;

namespace BrothersCompany.Api
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterHelpers(container);
              RegisterActivities(container);
              RegisterAdapters(container);
              RegisterMappers(container);
              RegisterServices(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        private static void RegisterType<TRegisteredType, TImplementationType>(IUnityContainer container, params InjectionMember[] constructorParams)
      where TImplementationType : TRegisteredType
        {
            // configuration file will prevail
            if (!container.IsRegistered<TRegisteredType>())
            {
                container.RegisterType<TRegisteredType, TImplementationType>(constructorParams);
            }
        }
        public static void RegisterHelpers(IUnityContainer container)
        {
            RegisterType<IConnectionRetreiver, IConnectionRetreiver>(container);
        }
        public static void RegisterActivities(IUnityContainer container)
        {
            BrothersCompany.Activities.Dependencies.Start(container);
        }

        public static void RegisterAdapters(IUnityContainer container)
        {
            BrothersCompany.DataAccess.Dependencies.Start(container);
        }

        public static void RegisterMappers(IUnityContainer container)
        {
            BrothersCompany.Mappers.Dependencies.Start(container);
        }

        public static void RegisterServices(IUnityContainer container)
        {
            BrothersCompany.ServiceIntegration.Dependencies.Start(container);
        }

        public static void CreateResolver(this IUnityContainer container)
        {
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.AspNet.WebApi.UnityDependencyResolver(container);
        }
    }
}