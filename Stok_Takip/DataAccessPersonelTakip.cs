using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip
{
    /*
     Personel takip tableına erişim metodları
     */
    class DataAccessPersonelTakip
    {
        public List<Personel_Takip_Data> GetUrunTakip(int ID_Personel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                var output = connection.Query<Personel_Takip_Data>("dbo.GetPersonelTakipByID @ID_Personel", new { ID_Personel = @ID_Personel }).ToList();
                return output;
            }
        }
        public void InsertPersonelTakip(int urunID, int projeID, int personelID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {

                List<Personel_Takip> PT = new List<Personel_Takip>();

                PT.Add(new Personel_Takip { ID_Urun = urunID, ID_Proje = projeID, ID_Personel = personelID});

                connection.Execute("dbo.InsertPersonelTakip @ID_Urun,@ID_Proje,@ID_Personel", PT);
            }
        }
        public void DeletePersonelUrun(int ID_Urun,int ID_Personel,int ID_Proje)
        {
            SQL_Commands.DeleteRow2Conint("Personel_Takip", "ID_Urun", "ID_Personel","ID_Proje", ID_Urun,ID_Personel,ID_Proje);
        }
    }
}
