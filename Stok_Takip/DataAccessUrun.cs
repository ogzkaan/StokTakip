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
    public class DataAccessUrun
    {
        /*
         * ürün tableına erişim metodları
         */
        public List<Kategori> GetUrun(String urunSeriNo) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1"))) 
            {
                var output = connection.Query<Kategori>("dbo.Urun_GetByUrunSeriNo @Urun_Seri_No", new { Urun_Seri_No =  urunSeriNo }).ToList();
                return output;
            }
        }
        public void InsertUrun(String Model, String Seri, int Adet,String Tip,String Marka)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                int  ID = getUrunId()+1;
               
                List<Kategori> kategori = new List<Kategori>();
                kategori.Add(new Kategori { ID_Urun = ID, Urun_Tip=Tip ,Urun_Marka=Marka, Urun_Model = Model, Urun_Seri_No = Seri, Urun_Adet = Adet }); ;

                connection.Execute("dbo.Urun_Insert @ID_Urun,@Urun_Tip,@Urun_Marka,@Urun_Model,@Urun_Seri_No,@Urun_Adet", kategori);
                
            }
        }
        public List<Kategori> Show_Urun() 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                var output = connection.Query<Kategori>("dbo.Select_Urun").ToList();
                return output;     
            }
        }
        public int getUrunId()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                int id;
                return  id = connection.ExecuteScalar<int>("dbo.GetMaxUrunID");
               
            }
        }
        public int GetUrunAdet(String seriNo)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                return SQL_Commands.IntOneParamOneRet("Urun_Adet", "Urun_Seri_No", seriNo);
            }
        }
        public void UpdateUrun(int Adet,String seriNo)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                
                var parameters = new DynamicParameters();
                
                parameters.Add("@UpdateValue", Adet);
                parameters.Add("@UpdateConVal", seriNo);
                connection.Execute("dbo.updateUrun", parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public String GetUrunModelFromSeri(String SeriNo)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                return SQL_Commands.StrOneStrParamOneRet("Urun_Model", "Urun_Seri_No",SeriNo);
            }
        }
 

        
    }
}
