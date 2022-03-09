using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace kidzania.sqlconnention
{
    class Class1
    {
        SqlConnection sc;
        //begin connection
        public Class1()
        {
            sc = new SqlConnection("Data Source=(local);Initial Catalog=kidzania;Integrated Security = SSPI");
            
        }
        //open the connection
        public void open() {
            if (sc.State != ConnectionState.Open)
                sc.Open();
           
        }
        //close the connection
        public void close()
        {
            if (sc.State == ConnectionState.Open)
                sc.Close();

        }
        // do stored procedure return value
        public DataTable selectbeprocedure(string stored_procedure,SqlParameter [] paramet)
        {
            sc.Open();
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = sc;
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.CommandText = stored_procedure;
            if (paramet  != null)
            {
                sqlcom.Parameters.AddRange(paramet);
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sc.Close();
            return dt;

        }
        // do stored procedure return value
        public void ex_procedure(string stored_procedure, SqlParameter[] paramet)
        {
            sc.Open();
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.CommandText = stored_procedure;
            sqlcom.Connection = sc;
            if (paramet != null)
            {
                    sqlcom.Parameters.AddRange(paramet);
            }   
            sqlcom.ExecuteNonQuery();
            sc.Close();
        }
        public int countprocedure(string stored_procedure, SqlParameter[] paramet)
        {
            sc.Open();
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = sc;
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.CommandText = stored_procedure;
            if (paramet != null)
            {
                sqlcom.Parameters.AddRange(paramet);
            }

            int count = (int)sqlcom.ExecuteScalar();
            sc.Close();
            return count;

        }
    }
}
