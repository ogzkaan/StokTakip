using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip
{
    class SQL_Commands
    {
        public static String StrOneStrParamOneRet(String selectVar, String conRowName, String conVal)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                String SQL = "Select " + selectVar + " From Urun where " + conRowName + " = " + '\'' + conVal + '\'';
                return connection.ExecuteScalar<String>(SQL);
            }
        }
        public static String StrOneIntParamOneRet(String selectVar, String conRowName, int conVal)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                String SQL = "Select " + selectVar + " From Urun where " + conRowName + " = " + conVal  ;
                return connection.ExecuteScalar<String>(SQL);
            }
        }
        public static int  IntOneParamOneRet(String selectVar, String conRowName, String conVal)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                String SQL = "Select " + selectVar + " From Urun where " + conRowName + " = " + '\'' + conVal + '\'';
                return connection.ExecuteScalar<int>(SQL);
            }

        }
        public static int SelectID(String conVal,String conColumnName,String IDname,String tableName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                String SQL = "Select "+ IDname + " from "+ tableName + " where "+ conColumnName + "=" + '\'' + conVal + '\'';
                return connection.ExecuteScalar<int>(SQL);
            }
        }
        public static void DeleteRow2Conint(String tableName,String conColName,String conColName2,String conColName3, int conVal, int conVal2,int conVal3)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                String SQL = "DELETE FROM "+tableName+" WHERE "+conColName+ " = "+"\'"+conVal+"\'";
                String SQL2 = " and  " + conColName2 + " = " + "\'" + conVal2 + "\'";
                String SQL3 = " and  " + conColName3 + " = " + "\'" + conVal3 + "\'";
                SQL += SQL2 + SQL3;
                connection.Query(SQL);
            }
        }

    }
}
