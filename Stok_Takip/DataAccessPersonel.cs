using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Stok_Takip
{
    class DataAccessPersonel
    {
         /*
          Personel tableına erişim metodları
          */
        public List<Personel> GetSifreYetki(String KullaniciAdi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                var output = connection.Query<Personel>("dbo.GetSifre_YetkiSeviyesi  @KullaniciAdi", new { KullaniciAdi = KullaniciAdi }).ToList();
                return output;
            }
        }
        public void InsertPersonel(String isim,String soyIsim,String sifre, String kullaniciAdi, int yetkiSeviyesi )
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                int ID = GetPersonelID() + 1;

                List<Personel> personel = new List<Personel>();
                personel.Add(new Personel { ID_Personel = ID, Isim = isim, Soy_Isim = soyIsim, Sifre = sifre, Kullanici_Adi = kullaniciAdi, Yetki_Seviyesi = yetkiSeviyesi }); ;

                connection.Execute("dbo.InsertPersonel @ID_Personel,@Isim,@Soy_Isim,@Sifre,@Kullanici_Adi,@Yetki_Seviyesi", personel);

            }
        }
        public int GetPersonelID()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                int id;
                return id = connection.ExecuteScalar<int>("dbo.GetMaxPersonelID");

            }
        }
        public List<Personel> ShowPersonel()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                String SQL = "Select Isim from Personel";
                return connection.Query<Personel>(SQL).ToList();
            }
        }
        public int personelID(String personelAdi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                return SQL_Commands.SelectID(personelAdi, "Isim","ID_Personel","Personel");
            }
        }

    }
}
