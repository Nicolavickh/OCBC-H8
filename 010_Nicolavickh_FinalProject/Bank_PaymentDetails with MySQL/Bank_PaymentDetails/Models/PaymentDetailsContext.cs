using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_PaymentDetails.Models
{
    public class PaymentDetailsContext
    {
        public string ConnetionString { get; set; }

        public PaymentDetailsContext(string conn)
        {
            this.ConnetionString = conn;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnetionString);
        }

        public List<PaymentDetailsItem> GetAllPaymentDetails()
        {
            List<PaymentDetailsItem> list = new List<PaymentDetailsItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM paymentdetails", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PaymentDetailsItem()
                        {
                            paymentDetailId = reader.GetInt32("paymentDetailId"),
                            cardOwnerName = reader.GetString("cardOwnerName"),
                            cardNumber = reader.GetString("cardNumber"),
                            expirationDate = reader.GetDateTime("expirationDate"),
                            securityCode = reader.GetString("securityCode")
                        });
                    }
                }
            }
            return list;
        }

        public List<PaymentDetailsItem> GetPaymentDetailsById(int id)
        {
            List<PaymentDetailsItem> list = new List<PaymentDetailsItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM paymentdetails WHERE paymentDetailId = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PaymentDetailsItem()
                        {
                            paymentDetailId = reader.GetInt32("paymentDetailId"),
                            cardOwnerName = reader.GetString("cardOwnerName"),
                            cardNumber = reader.GetString("cardNumber"),
                            expirationDate = reader.GetDateTime("expirationDate"),
                            securityCode = reader.GetString("securityCode")
                        });
                    }
                }
            }

            return list;
        }

        public string AddPaymentDetails(PaymentDetailsItem details)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO paymentdetails(cardOwnerName, cardNumber, expirationDate, securityCode) VALUES (@cardOwnerName, @cardNumber, @expirationDate, @securityCode)", conn);
                cmd.Parameters.AddWithValue("@cardOwnerName", details.cardOwnerName);
                cmd.Parameters.AddWithValue("@cardNumber", details.cardNumber);
                cmd.Parameters.AddWithValue("@expirationDate", details.expirationDate);
                cmd.Parameters.AddWithValue("@securityCode", details.securityCode);

                var recs = cmd.ExecuteNonQuery();

                if (recs == 1)
                {
                    return "Success!";
                }
                else
                {
                    return "Failed!";
                }
            }
        }
        public string UpdatePaymentDetails(int id, PaymentDetailsItem newDetails)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand updt = new MySqlCommand("UPDATE paymentdetails SET cardOwnerName=@cardOwnerName, cardNumber=@cardNumber, expirationDate=@expirationDate, securityCode=@securityCode WHERE paymentDetailId=@id", conn);
                updt.Parameters.AddWithValue("@cardOwnerName", newDetails.cardOwnerName);
                updt.Parameters.AddWithValue("@cardNumber", newDetails.cardNumber);
                updt.Parameters.AddWithValue("@expirationDate", newDetails.expirationDate);
                updt.Parameters.AddWithValue("@securityCode", newDetails.securityCode);
                updt.Parameters.AddWithValue("@id", id);
                var recs = updt.ExecuteNonQuery();

                if (recs == 1)
                {
                    return "Success!";
                }
                else
                {
                    return "Failed!";
                }
            }
        }

        public string DeletePaymentDetails(int id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand del = new MySqlCommand("DELETE FROM paymentdetails WHERE paymentDetailId=@id", conn);
                del.Parameters.AddWithValue("@id", id);
                var recs = del.ExecuteNonQuery();

                if (recs == 1)
                {
                    return "Success!";
                }
                else
                {
                    return "Failed!";
                }
            }
        }
    }
}
