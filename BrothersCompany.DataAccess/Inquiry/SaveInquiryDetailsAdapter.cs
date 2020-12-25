using BrothersCompany.Domain.Inquiry;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BrothersCompany.DataAccess.Inquiry
{
    public class SaveInquiryDetailsAdapter : IDatabaseAdapter<SaveInquiryDetailsDomainRequest, SaveInquiryDetailsDomainResponse>
    {
        private readonly IConnectionRetreiver _connectionRetreiver;
        public SaveInquiryDetailsAdapter(IConnectionRetreiver connectionRetreiver)
        {
            _connectionRetreiver = connectionRetreiver;
        }
        public SaveInquiryDetailsDomainResponse Execute(SaveInquiryDetailsDomainRequest requestInput)
        {
            try
            {
                var response = new SaveInquiryDetailsDomainResponse();
                using (SqlCommand cmd = new SqlCommand())
                {
                    using(var bCDbConnection = (SqlConnection)_connectionRetreiver.GetDbConnection())
                    {
                        cmd.Connection = bCDbConnection;
                        cmd.CommandTimeout = 120;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "BCSP_Insert_Inquiry_Details";
                        cmd.Parameters.AddWithValue("@INQUIRY_EMAIL", requestInput.InquiryEmail);
                        cmd.Parameters.AddWithValue("@INQUIRY_MESSAGE", requestInput.InquiryMessage);
                        cmd.Parameters.AddWithValue("@INQUIRY_NAME", requestInput.InquiryName);
                        cmd.Parameters.AddWithValue("@INQUIRY_PHONENO", requestInput.InquiryPhoneNo);
                        cmd.Parameters.AddWithValue("@PRODUCT_ID", requestInput.ProductId);
                        cmd.Parameters.AddWithValue("@QUANTITY", requestInput.Quantity);
                        cmd.Parameters.AddWithValue("@STATUS", requestInput.Status);
                        bCDbConnection.Open();
                        var result = cmd.ExecuteScalar();
                        bCDbConnection.Close();
                        response.IsInquirySaved = Convert.ToBoolean(result);
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
