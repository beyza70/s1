using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace GOLDA
{
    public partial class Kayıt_ol : System.Web.UI.Page
    {

        SqlConnection db = new SqlConnection("Data Source=LAPTOP-AUBEK5DU;Initial Catalog=GOLDA;User ID=sql server kullanıcı adı;Password=sql server şifre;Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            db.Open();
            SqlCommand cmd = new SqlCommand(@"insert into dbo_giris(kadi,sifre) values(@kadi,@sifre)", db);

            cmd.Parameters.AddWithValue("kadi", txt_kadi_kaydet.Text);
            cmd.Parameters.AddWithValue("sifre", txt_sifre_kaydet.Text);
            cmd.ExecuteNonQuery();
            db.Close();

            lbl_kayit.Text = "Kayıt Başarıyla Tamamlandı";
        }

        protected void giris_sayfasi_Click(object sender, EventArgs e)
        {
            Response.Redirect("Kullanici_girisi.aspx");
        }
    }
}