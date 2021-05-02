using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip
{
    class DataAccessProjeler
    {
       
        /*
         projeler tableına erişim metodları
         */
        public void InsertProje(String ad, String detay)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                List<Projeler> projeler = new List<Projeler>();
                projeler.Add(new Projeler { ID_Proje= getProjeId()+1,Proje_Adi=ad,Detay=detay,Ekleme_Tarihi=DateTime.Now,Bitis_Tarihi=null }); 

                connection.Execute("dbo.InsertProje @ID_Proje,@Proje_Adi,@Detay,@Ekleme_Tarihi,@Bitis_Tarihi", projeler);
            }
        }
        public int getProjeId()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                String SQL = "Select Max(ID_Proje) from Projeler";  
                return  connection.ExecuteScalar<int>(SQL);
            }
        }
        public void ProjeBitir(String projeAdi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                String SQL = "Update Projeler set Bitis_Tarihi = " + '\'' + DateTime.Now + '\'' + " Where Proje_Adi=" + '\'' + projeAdi + '\'';
                connection.Execute(SQL);
            }
           
        }
        public List<Projeler> ShowProje()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                String SQL = "Select Proje_Adi from Projeler";
                return connection.Query<Projeler>(SQL).ToList();
            }
        }
        public int ProjeID (String projeAdi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                return SQL_Commands.SelectID(projeAdi,"Proje_Adi","ID_Proje","Projeler");
            }
        }
        
       
    }
}
