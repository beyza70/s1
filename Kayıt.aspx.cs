using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;




namespace GOLDA
{
    
    public partial class Kayıt : System.Web.UI.Page
    {
        string kadi;
        
        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-AUBEK5DU;Initial Catalog=GOLDA;User ID=sql server kullanıcı adı;Password=sql server şifre;Integrated Security=True");
        

        protected void Page_Init(object sender, EventArgs e)
        {

            //if (Request.UrlReferrer == null)

            //{

            //    Response.Redirect("Kullanici_girisi.aspx");

            //}

            //else if (!Request.UrlReferrer.ToString().ToLower().Contains("Kullanici_girisi.aspx"))

            //{

            //    Response.Redirect("Kullanici_girisi.aspx");

            //}

            

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            D_sil.Enabled = false;
            D_göster.Enabled = false;

           

        }

        protected void btn_gönder_Click(object sender, EventArgs e)
        {
            D_göster.Enabled = true;
            


            
            DateTime Tarih;
            String Vardiya;
            String Adi_Soyadi;
            String Durak;
            kadi = Session["kadi"].ToString();



            if (fu_vardiya.HasFile)
            {
                string path = Path.GetFileName(fu_vardiya.FileName);

                if (Path.GetExtension(path) == ".xlsx")
                {


                    //string path = Path.GetFileName(fu_vardiya.FileName);
                    path = path.Replace(" ", "");
                    fu_vardiya.SaveAs(Server.MapPath("~/Excel/") + path);
                    String ExcelPath = Server.MapPath("~/Excel/") + path;
                    OleDbConnection mycon = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + ExcelPath + "; Extended Properties=Excel 8.0; Persist Security Info = False");
                    mycon.Open();
                    OleDbCommand cmd = new OleDbCommand("select * from [Sayfa1$]", mycon);
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    //GridView_Vardiya.DataSource = ds.Tables[0];
                    //GridView_Vardiya.DataBind();


                    OleDbDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        //Response.Write("<br/>"+dr[0].ToString());

                        Tarih = DateTime.Parse(dr[0].ToString());
                        Vardiya = dr[1].ToString();
                        Adi_Soyadi = dr[2].ToString();
                        Durak = dr[3].ToString();
                        
                        savedata(Tarih, Vardiya, Adi_Soyadi, Durak, kadi);


                    }
                    mycon.Close();
                    lbl_kaydet.Text = "Yükleme İşlemi Başarılı." +
                           "<br /> Dosya Adı: " +
                           fu_vardiya.PostedFile.FileName +
                           "<br />Dosya Boyutu: " +
                           fu_vardiya.PostedFile.ContentLength +
                           "<br />Dosya Türü: " +
                           fu_vardiya.PostedFile.ContentType;
                }


                else
                {
                    lbl_kaydet.Text = "Excel Dosyası Seçmediniz.Lütfen Excel dosyası seçin.";
                }

            }

            else
            {
                lbl_kaydet.Text = "Dosya Seçmediniz.Lütfen Dosya Seçin ve GÖNDER Butonuna Tıklayın.";
            }
        }
        private void savedata(DateTime Tarih1, String Vardiya1, String Adi_Soyadi1, String Durak1, String kadi1)
        {
            String query = "insert into dbo_Vardiya_Kayit(Tarih,Vardiya,Adi_Soyadi,Durak,Birim) values('" + Tarih1 + "','" + Vardiya1 + "','" + Adi_Soyadi1 + "','" + Durak1 + "','" + kadi1 + "')";

            String mycon = "Data Source=LAPTOP-AUBEK5DU; Initial Catalog=GOLDA; Integrated Security=true";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }

        
        




        protected void D_göster_Click(object sender, EventArgs e)
        {
            D_sil.Enabled = true;
            
            
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-AUBEK5DU; Initial Catalog=GOLDA; Integrated Security=true");
            con.Open();
            string Select = "select * from dbo_Vardiya_Kayit "; 
            SqlDataAdapter da = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            //GridView_Vardiya.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            

            if (Calendar_Tarih.SelectedDate = GridView_Vardiya.Columns[1])
            {
            GridView_Vardiya.DataSource = dt;
            GridView_Vardiya.DataSource = ds.Tables[0];
            GridView_Vardiya.DataBind();
            con.Close();


             //string Select = "select * from dbo_Vardiya_Kayit where Tarih = '" + Calendar_Tarih.SelectedDate.ToString() + "'"; 
            }


        }

        protected void D_sil_Click(object sender, EventArgs e)
        {

            /* Label1.Text = "Silme İşlemi Başarılı!";

             SqlConnection conn = new SqlConnection("Data Source=LAPTOP-AUBEK5DU; Initial Catalog=GOLDA; Integrated Security=true");
             if (Calendar_Tarih.SelectedDate = GridView_Vardiya.Columns[1])
             {
                 SqlCommand cmd = new SqlCommand("DELETE  * from dbo_Vardiya_Kayit ");
                 conn.Open();
                 cmd.ExecuteNonQuery();
                 Label1.Text = "Silme İşlemi Başarılı!";
                 string Select = "select * from dbo_Vardiya_Kayit ";
                 SqlDataAdapter da = new SqlDataAdapter(Select, conn);
                 DataTable dt = new DataTable();
                 DataSet ds = new DataSet();
                 da.Fill(ds);
                 GridView_Vardiya.DataSource = dt;
                 GridView_Vardiya.DataSource = ds.Tables[0];
                 GridView_Vardiya.DataBind();
                 conn.Close();
             }*/
            
        }

        protected void Calendar_Tarih_SelectionChanged(object sender, EventArgs e)
        {
            D_göster.Enabled = true;

        }



        protected void tikla_test_Click(object sender, EventArgs e)
        {
           
        }
    } }
