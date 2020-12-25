using BrothersCompany.Contracts.Inquiry;
using BrothersCompany.Domain.Inquiry;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BrothersCompany.DataAccess.Inquiry
{
    public class GetInquiryDetailsAdapter : IDatabaseAdapter<GetInquiryDetailsDomainRequest, GetInquiryDetailsDomainResponse>
    {
        private readonly IConnectionRetreiver _connectionRetreiver;
        public GetInquiryDetailsAdapter(IConnectionRetreiver connectionRetreiver)
        {
            _connectionRetreiver = connectionRetreiver;
        }
        public GetInquiryDetailsDomainResponse Execute(GetInquiryDetailsDomainRequest requestInput)
        {
            try
            {
                SqlDataReader dr;
                var response = new GetInquiryDetailsDomainResponse();
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (var bCDbConnection = (SqlConnection)_connectionRetreiver.GetDbConnection())
                    {
                        cmd.Connection = bCDbConnection;
                        cmd.CommandTimeout = 120;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "BCSP_Get_Inquiry_Details";
                        //cmd.Parameters.AddWithValue("", requestInput.);
                        bCDbConnection.Open();
                        dr = cmd.ExecuteReader();
                        if(dr.HasRows)
                        {
                            while(dr.Read())
                            {
                                InquiryDetailsList inquiryDetailsList = new InquiryDetailsList
                                {
                                    Quantity = dr["quantity"] != DBNull.Value ? Convert.ToInt32(dr["quantity"]) : 0,
                                    InquiryEmail = dr["inquiry_email"] != DBNull.Value ? Convert.ToString(dr["inquiry_email"]) : string.Empty,
                                    InquiryMessage = dr["inquiry_message"] != DBNull.Value ? Convert.ToString(dr["inquiry_message"]) : string.Empty,
                                    InquiryName = dr["inquiry_name"] != DBNull.Value ? Convert.ToString(dr["inquiry_name"]) : string.Empty,
                                    InquiryPhoneNo = dr["inquiry_phoneno"] != DBNull.Value ? Convert.ToInt64(dr["inquiry_phoneno"]) : 0,
                                    ProductId = dr["product_id"] != DBNull.Value ? Convert.ToInt32(dr["product_id"]) : 0,
                                    Status = dr["status"] != DBNull.Value ? Convert.ToInt32(dr["status"]) : 0
                                };
                                response.InquiryDomainDetails.Add(inquiryDetailsList);
                            }
                        }
                        bCDbConnection.Close();
                        
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
