using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Injection;

namespace BrothersCompany.DataAccess
{
    public class Dependencies
    {
        public static void Start(IUnityContainer container)
        {

        }

        private static void RegisterType<TRegisteredType, TImplementationType>(IUnityContainer container, params InjectionMember[] constructorParams)
      where TImplementationType : TRegisteredType
        {
            // configuration file will prevail
            if (!container.IsRegistered<TRegisteredType>())
            {
                container.RegisterType<TRegisteredType, TImplementationType>(constructorParams);
            }
        }
    }
}
