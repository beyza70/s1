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
    
    public partial class Kullanici_girisi : System.Web.UI.Page
    {
        //string kadi;
        SqlConnection db = new SqlConnection("Data Source=LAPTOP-AUBEK5DU;Initial Catalog=GOLDA;User ID=sql server kullanıcı adı;Password=sql server şifre;Integrated Security=True");

        public object kadi { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btn_giris_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo_giris where kadi=@kadi and sifre=@sifre", db);
            da.SelectCommand.Parameters.Add("@kadi", SqlDbType.NVarChar, 11);
            da.SelectCommand.Parameters.Add("@sifre", SqlDbType.NVarChar, 8);
            da.SelectCommand.Parameters["@kadi"].Value = kadi;
            da.SelectCommand.Parameters["@kadi"].Value = Txt_kadi.Text;
            da.SelectCommand.Parameters["@sifre"].Value = Txt_sifre.Text;
            Session["kadi"] = Txt_kadi.Text;//kullanıcı adını diğer sayfalarda kullanmak için
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                lbl_giris.Text = "Giriş Başarılı";
                Response.Redirect("Kayıt.aspx");
                

            }
            else
            {
                lbl_giris.Text = "Hatalı Giriş Yaptınız! Kaydınız yoksa lütfen kayıt olunuz";
            }
        }

        protected void btn_kayıt_ol_Click(object sender, EventArgs e)
        {
            Response.Redirect("Kayıt_ol.aspx");
        }
    }
}