using BrothersCompany.Activities.Test;
using BrothersCompany.Contracts.Test;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Injection;

namespace BrothersCompany.Activities
{
    public static class Dependencies
    {
        public static void Start(IUnityContainer container)
        {
            RegisterType<IActivity<TestRequest, TestResponse>, TestActivity>(container);
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
