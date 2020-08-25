using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Stok_Takip
{
    public class DataAccess
    {
        public List<Urun> GetUrun(String urunAdi) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1"))) 
            {
                var output = connection.Query<Urun>("dbo.Urun_GetByUrunAdi @Urun_Adi", new { Urun_Adi = urunAdi }).ToList();
                return output;
            }
        }

        public void InsertUrun(int ID, string Ad, DateTime Ekleme, DateTime Cikis, int Seri, int Adet)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                
                List<Urun> urun1 = new List<Urun>();
                urun1.Add(new Urun { ID_Urun = ID,Urun_Adi=Ad, Ekleme_Tarihi = Ekleme, Cikis_Tarihi = Cikis, Urun_Seri_No = Seri, Urun_Adet = Adet });

                connection.Execute("dbo.Urun_Insert @ID_Urun,@Urun_Adi,@Ekleme_Tarihi,@Cikis_Tarihi,@Urun_Seri_No,@Urun_Adet",urun1);
            }
        }
        public List<Urun> Show_Urun() 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                var output = connection.Query<Urun>("dbo.Select_Urun").ToList();
                return output;     
            }
        }
    }
}
