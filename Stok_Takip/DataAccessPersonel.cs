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
        public String GetSifre(String KullaniciAdi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                String output;

                var parameters = new DynamicParameters();
                parameters.Add("@KullaniciAdi", KullaniciAdi);
                return output = connection.ExecuteScalar<String>("dbo.GetPersonelSifre  @KullaniciAdi", new { KullaniciAdi = KullaniciAdi });
            }
        }
    }
}
