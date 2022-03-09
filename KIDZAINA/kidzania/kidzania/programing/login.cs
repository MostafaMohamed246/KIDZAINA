using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace kidzania.programing
{
   public struct user
    {
       public DataTable da;
       public int usertype;
    };
    class login
    {
        public  user log_in(string user, string pass)

        {
            DataTable td = new DataTable();
            user s;
            for (int i=0;i<4;i++){
                sqlconnention.Class1 da = new sqlconnention.Class1();
                SqlParameter[] parm = new SqlParameter[3];
                parm[0] = new SqlParameter("@type", SqlDbType.Int);
                parm[0].Value = i;
                parm[1] = new SqlParameter("@user", SqlDbType.NVarChar, 50);
                parm[1].Value = user;
                parm[2] = new SqlParameter("@paw", SqlDbType.NVarChar, 50);
                parm[2].Value = pass;
                td = da.selectbeprocedure("singn_i", parm);
                if (td.Rows.Count > 0)
                {

                    s.da = td;
                    s.usertype = i;
                    return s;
                }
                
            }
            s.da = td;
            s.usertype = 10;
            return s;
        }
    }
    class signup
    {
        public void sign_up(string username, string pass,string phone,int gend,string email,DateTime t)

        {
            sqlconnention.Class1 da = new sqlconnention.Class1();
            SqlParameter[] parm = new SqlParameter[6];
            parm[0] = new SqlParameter("@full_name",SqlDbType.NVarChar, 200);
            parm[0].Value = username;
            parm[1] = new SqlParameter("@email",SqlDbType.VarChar, 200);
            parm[1].Value = email;
            parm[2] = new SqlParameter("@gend", SqlDbType.Bit);
            parm[2].Value = gend;
            parm[3] = new SqlParameter("@date", SqlDbType.Date);
            parm[3].Value = t.Date;
            parm[4] = new SqlParameter("@password",SqlDbType.NVarChar, 200);
            parm[4].Value = pass;
            parm[5] = new SqlParameter("@numphone", SqlDbType.VarChar, 200);
            parm[5].Value = phone;
             da.ex_procedure("sign_up", parm);
        }
        public int checkforname(string s)
        {
            int num=0;
            int i;
            sqlconnention.Class1 da = new sqlconnention.Class1();
            SqlParameter []parm = new SqlParameter[2];
            for ( i = 0; i < 3; i++)
            {
                parm[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
                parm[0].Value = s;
                parm[1] = new SqlParameter("@x", SqlDbType.Int);
                parm[1].Value = i;
                num = da.countprocedure("foundname", parm);
                if (num == 1)
                {
                    return num;
                }
            }
           return num;
        }
        public int checkforemail(string s)
        {
            int num;
            sqlconnention.Class1 da = new sqlconnention.Class1();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@email", SqlDbType.NVarChar, 50);
            parm[0].Value = s;
            num = da.countprocedure("foundemail", parm);
            return num;
        }
        public int checkforphane(string s)
        {
            int num;
            sqlconnention.Class1 da = new sqlconnention.Class1();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            parm[0].Value = s;
            num = da.countprocedure("foundphane", parm);
            return num;
        }
    }
    
}
