using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace kidzania.programing
{
    
    class employee
    {
        sqlconnention.Class1 da = new sqlconnention.Class1();
        public void addquestion(string i,string text)
        {
            int id = int.Parse(i);
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@Emp_id", SqlDbType.Int);
            parm[0].Value = id;
            parm[1] = new SqlParameter("@problems", SqlDbType.Text);
            parm[1].Value = text;
            da.ex_procedure("addproblem", parm);
        }
        public DataTable viewpro(string i)
        {
            DataTable td = new DataTable();
            int id = int.Parse(i);
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@Emp_id", SqlDbType.Int);
            parm[0].Value = id;
           td= da.selectbeprocedure("viewproblem", parm);
            return td;
        }
        
        public DataTable viewem()
        {
            DataTable td = new DataTable();
            td = da.selectbeprocedure("viewemployee",null);
            return td;
        }
        public DataTable viewp(int id)
        {
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@em_id", SqlDbType.Int);
            parm[0].Value = id;
            DataTable td = new DataTable();
            td = da.selectbeprocedure("getp", parm);
            return td;
        }
        public DataTable viewvisiter(int id)
        {
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@employee_id", SqlDbType.Int);
            parm[0].Value = id;
            DataTable td = new DataTable();
            td = da.selectbeprocedure("tick", parm);
            return td;
        }
        public DataTable deleteem(string i)
        {
            DataTable td = new DataTable();
            int id = int.Parse(i);
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;
            td = da.selectbeprocedure("deleteem", parm);
            return td;
        }
        public void addem(string name ,string phone ,string depart,string pass,int sar,byte[] imag)
        {
            SqlParameter[] parm = new SqlParameter[6];
            parm[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            parm[0].Value = name;
            parm[1] = new SqlParameter("@depart", SqlDbType.NVarChar, 50);
            parm[1].Value = depart;
            parm[2] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            parm[2].Value = phone;
            parm[3] = new SqlParameter("@sar", SqlDbType.Int);
            parm[3].Value = sar;
            parm[4] = new SqlParameter("@pass ", SqlDbType.NVarChar, 50);
            parm[4].Value = pass;
            parm[5] = new SqlParameter("@img", SqlDbType.Image);
            parm[5].Value = imag;
            da.ex_procedure("addem", parm);
        }
        public void upem(string name, string phone, string depart, string pass, int sar, byte[] imag)
        {
            SqlParameter[] parm = new SqlParameter[6];
            parm[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            parm[0].Value = name;
            parm[1] = new SqlParameter("@depart", SqlDbType.NVarChar, 50);
            parm[1].Value = depart;
            parm[2] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            parm[2].Value = phone;
            parm[3] = new SqlParameter("@sar", SqlDbType.Int);
            parm[3].Value = sar;
            parm[4] = new SqlParameter("@pass ", SqlDbType.NVarChar, 50);
            parm[4].Value = pass;
            parm[5] = new SqlParameter("@img", SqlDbType.Image);
            parm[5].Value = imag;
            da.ex_procedure("upem", parm);
        }
    }
}
