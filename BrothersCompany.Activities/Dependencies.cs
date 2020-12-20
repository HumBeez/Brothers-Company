using BrothersCompany.Activities.Admin;
using BrothersCompany.Activities.Catalog;
using BrothersCompany.Activities.Inquiry;
using BrothersCompany.Activities.Product;
using BrothersCompany.Activities.Query;
using BrothersCompany.Activities.Test;
using BrothersCompany.Contracts.Test;
using BrothersCompany.Domain.Admin;
using BrothersCompany.Domain.Catalog;
using BrothersCompany.Domain.Inquiry;
using BrothersCompany.Domain.Product;
using BrothersCompany.Domain.Query;
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
            RegisterType<IActivity<SaveInquiryDetailsDomainRequest, SaveInquiryDetailsDomainResponse>, SaveInquiryDetailsActivity>(container);
            RegisterType<IActivity<GetInquiryDetailsDomainRequest, GetInquiryDetailsDomainResponse>, GetInquiryDetailsActivity>(container);
            RegisterType<IActivity<SaveProductDetailsDomainRequest, SaveProductDetailsDomainResponse>, SaveProductDetailsActivity>(container);
            RegisterType<IActivity<GetProductDetailsDomainRequest, GetProductDetailsDomainResponse>, GetProductDetailsActivity>(container);
            RegisterType<IActivity<SaveCustomerQueryDomainRequest, SaveCustomerQueryDomainResponse>, SaveCustomerQueryActivity>(container);
            RegisterType<IActivity<GetQueriesDomainRequest, GetQueriesDomainResponse>, GetQueriesActivity>(container);
            RegisterType<IActivity<GetCatalogDomainRequest, GetCatalogDomainResponse>, GetCatalogActivity>(container);
            RegisterType<IActivity<AuthenticateDomainRequest, AuthenticateDomainResponse>, AuthenticateActivity>(container);
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
