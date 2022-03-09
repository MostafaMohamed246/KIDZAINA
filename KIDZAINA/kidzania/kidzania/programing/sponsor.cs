using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace kidzania.programing
{
    
    class sponsor
    {
        public DataTable view()
        {
            sqlconnention.Class1 da = new sqlconnention.Class1();
            DataTable dt = new DataTable();
            dt = da.selectbeprocedure("viewesponser", null);
            return dt;
        }
        public DataTable viewadmin()
        {
            sqlconnention.Class1 da = new sqlconnention.Class1();
            DataTable dt = new DataTable();
            dt = da.selectbeprocedure("viewadmin", null);
            return dt;
        }
      public void Editadmin(string name ,string password)
        {
            sqlconnention.Class1 da = new sqlconnention.Class1();
            SqlParameter [] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            parm[0].Value = name;
            parm[1] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            parm[1].Value = password;
           da.ex_procedure("Editadmin", parm);
        }
        public void addadv(string i, Byte[] imag)
        {
            int id = int.Parse(i);
            sqlconnention.Class1 da = new sqlconnention.Class1();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;
            parm[1] = new SqlParameter("@ima", SqlDbType.Image);
            parm[1].Value = imag;
            da.ex_procedure("updateimage", parm);
        }
        public void deletesponsor(string i)
        {
            int id = int.Parse(i);
            sqlconnention.Class1 da = new sqlconnention.Class1();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;
            da.ex_procedure("deletesponsor", parm);
        }
        public void addind(string i,int index)
        {
            int id = int.Parse(i);
            sqlconnention.Class1 da = new sqlconnention.Class1();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;
            parm[1] = new SqlParameter("@index", SqlDbType.Int);
            parm[1].Value = index;
            da.ex_procedure("addindex", parm);
        }
        public void deleteadv(string i)
        {
            int id = int.Parse(i);
            sqlconnention.Class1 da = new sqlconnention.Class1();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;
            da.ex_procedure("updateadv", parm);
        }
        public DataTable viewimage(string i)
        {
            int id = int.Parse(i);
            sqlconnention.Class1 da = new sqlconnention.Class1();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;
            DataTable dt = new DataTable();
         dt=da.selectbeprocedure("getimag", parm);
            return dt;
        }
        public DataTable checkindex(int index)
        {

            sqlconnention.Class1 da = new sqlconnention.Class1();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@index", SqlDbType.Int);
            parm[0].Value = index;
            DataTable dt = new DataTable();
            dt = da.selectbeprocedure("checkedindex", parm);
            return dt;
        }

        public DataTable viewadv(int index)
        {
            
            sqlconnention.Class1 da = new sqlconnention.Class1();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@index", SqlDbType.Int);
            parm[0].Value = index;
            DataTable dt = new DataTable();
            dt = da.selectbeprocedure("ads", parm);
            return dt;
        }
        public void addsponsor(string name, string phone ,byte[]adv,int v,string email)
        {

            sqlconnention.Class1 da = new sqlconnention.Class1();
            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@sponsor_name", SqlDbType.NVarChar, 50);
            parm[0].Value = name;
            parm[1] = new SqlParameter("@phane", SqlDbType.VarChar, 50);
            parm[1].Value = phone;
            parm[2] = new SqlParameter("@adv", SqlDbType.Image);
            parm[2].Value = adv;
            parm[3] = new SqlParameter("@adv_vaild", SqlDbType.Bit);
            parm[3].Value = v;
            parm[4] = new SqlParameter("@sponsor_email", SqlDbType.NVarChar, 50);
            parm[4].Value = email;
            da.ex_procedure("addsponsor", parm);

        }
        public void editsponsor(int id,string name, string phone, byte[] adv, int v, string email)
        {

            sqlconnention.Class1 da = new sqlconnention.Class1();
            SqlParameter[] parm = new SqlParameter[6];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;
            parm[1] = new SqlParameter("@sponsor_name", SqlDbType.NVarChar, 50);
            parm[1].Value = name;
            parm[2] = new SqlParameter("@phane", SqlDbType.VarChar, 50);
            parm[2].Value = phone;
            parm[3] = new SqlParameter("@adv", SqlDbType.Image);
            parm[3].Value = adv;
            parm[4] = new SqlParameter("@adv_vaild", SqlDbType.Bit);
            parm[4].Value = v;
            parm[5] = new SqlParameter("@sponsor_email", SqlDbType.NVarChar, 50);
            parm[5].Value = email;
            da.ex_procedure("updatesponsorr", parm);

        }
    }
}
