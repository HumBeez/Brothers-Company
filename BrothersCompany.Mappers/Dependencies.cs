using BrothersCompany.Contracts.Inquiry;
using BrothersCompany.Domain.Inquiry;
using BrothersCompany.DomainCore.Abstract;
using BrothersCompany.Mappers.ContractToDomain.Inquiry;
using BrothersCompany.Mappers.DomainToContract;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Injection;

namespace BrothersCompany.Mappers
{
    public class Dependencies
    {
        public static void Start(IUnityContainer container)
        {
            RegisterType<BaseMapper<SaveInquiryDetailsRequest, SaveInquiryDetailsDomainRequest>, SaveInquiryDetailsContractToDomainMapper>(container);
            RegisterType<BaseMapper<GetInquiryDetailsDomainResponse, GetInquiryDetailsResponse>, GetInquiryDetailsDomainToContractMapper>(container);
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
