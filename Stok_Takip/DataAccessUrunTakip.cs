using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Stok_Takip
{
    class DataAccessUrunTakip
    {
      
        /*
         ürün takip tableına erişim metodları
         */
        public int UrunID(String SeriNo)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                return SQL_Commands.SelectID(SeriNo,"Urun_Seri_No","ID_Urun","Urun");
            }
        }
        public void InsertUrunTakip(int adet, int urunID ,int projeID,int personelID, String aciklama,int state)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
               
                List<Urun_Takip> UT = new List<Urun_Takip>();
                
                UT.Add(new Urun_Takip { ID_Urun= urunID, ID_Proje= projeID, ID_Personel= personelID, Tarih=DateTime.Now,Aciklama=aciklama,Adet=adet,State=state});

                connection.Execute("dbo.InsertUrunTakip @ID_Urun,@ID_Proje,@ID_Personel,@Tarih,@Adet,@Aciklama,@State", UT);
            }
        }
        public List<Urun_Takip_Data> GetUrunTakip(String ID_Urun)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                var output = connection.Query<Urun_Takip_Data>("dbo.GetUrunTakipByID @ID_Urun", new { ID_Urun = @ID_Urun }).ToList();
                return output;
            }
        }


    }
}
