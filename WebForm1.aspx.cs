using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GOLDA
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {

           
                    SqlConnection baglanti;
                    SqlCommand komut;

                    string baglanStr = ConfigurationManager.ConnectionStrings["GoldaBaglanti"].ConnectionString;
                    baglanti = new SqlConnection(baglanStr);
                    
                    komut = new SqlCommand("INSERT INTO dbo_Vardiya(Tarih ,Vardiya,Adi_Soyadi,Durak) VALUES(@Tarih, @Vardiya, @Adi_Soyadi,@Durak)", baglanti);
                    komut.Parameters.AddWithValue("@Tarih", txt_tarih.Text);
                    komut.Parameters.AddWithValue("@Vardiya", txt_vardiya.Text);
                    komut.Parameters.AddWithValue("@Adi_Soyadi", txt_adi_soyadi.Text);
                    komut.Parameters.AddWithValue("@Durak", txt_durak.Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    LblMesaj.Text = "Kayıt Eklendi";

                
                    baglanti.Close();
                }
            }
        }
    
