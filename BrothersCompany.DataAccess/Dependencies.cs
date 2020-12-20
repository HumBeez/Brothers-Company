using BrothersCompany.DataAccess.Admin;
using BrothersCompany.DataAccess.Catalog;
using BrothersCompany.DataAccess.Inquiry;
using BrothersCompany.DataAccess.Product;
using BrothersCompany.DataAccess.Query;
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

namespace BrothersCompany.DataAccess
{
    public class Dependencies
    {
        public static void Start(IUnityContainer container)
        {
            RegisterType<IDatabaseAdapter<SaveInquiryDetailsDomainRequest, SaveInquiryDetailsDomainResponse>, SaveInquiryDetailsAdapter>(container);
            RegisterType<IDatabaseAdapter<GetInquiryDetailsDomainRequest, GetInquiryDetailsDomainResponse>, GetInquiryDetailsAdapter>(container);
            RegisterType<IDatabaseAdapter<SaveProductDetailsDomainRequest, SaveProductDetailsDomainResponse>, SaveProductDetailsAdapter>(container);
            RegisterType<IDatabaseAdapter<GetProductDetailsDomainRequest, GetProductDetailsDomainResponse>, GetProductDetailsAdapter>(container);
            RegisterType<IDatabaseAdapter<SaveCustomerQueryDomainRequest, SaveCustomerQueryDomainResponse>, SaveCustomerQueryAdapter>(container);
            RegisterType<IDatabaseAdapter<GetQueriesDomainRequest, GetQueriesDomainResponse>, GetQueriesAdapter>(container);
            RegisterType<IDatabaseAdapter<GetCatalogDomainRequest, GetCatalogDomainResponse>, GetCatalogAdapter>(container);
            RegisterType<IDatabaseAdapter<AuthenticateDomainRequest, AuthenticateDomainResponse>, AuthenticateAdapter>(container);
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
