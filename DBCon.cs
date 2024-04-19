﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADOproj1
{
    class DBCon
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-6VND87VR\\SQLEXPRESS;Initial Catalog=B49proj1;uid=sa;pwd=jeeva122478");
        public int InsertProduct(int @pid, string @pname, string @pdesc)
        {
            SqlCommand cmd = new SqlCommand("insprod", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@pdesc", pdesc);
            int x = cmd.ExecuteNonQuery();
            con.Close();

            return x;
        }
        public DataTable VIEWPRODUCT()
        {
            SqlCommand cmd = new SqlCommand("dispro", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable VIEWPEODUCTBYPID(int @pid)
        {
            SqlCommand cmd = new SqlCommand("dispro1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", pid);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;

        }
        public int DeleteProduct(int @pid)
        {
            SqlCommand cmd = new SqlCommand("delepro1", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;


        }
        public int Editproduct(int @pid, string @pname, string @pdesc)
        {
            SqlCommand cmd = new SqlCommand("updpro", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@pdesc", pdesc);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }

        public int Insertmodel(int @mid, string @mname, int @pid, string @pname, string @spec, int @uprice, int @soh)
        {
            SqlCommand cmd = new SqlCommand("InsModel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@mname", mname);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@spec", spec);
            cmd.Parameters.AddWithValue("@uprice", uprice);
            cmd.Parameters.AddWithValue("@soh", soh);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public int Editmodel(int @mid, string @mname, int @pid, string @pname, string @spec, int @uprice, int @soh)
        {
            SqlCommand cmd = new SqlCommand("UpdModel",con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@mname", mname);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@spec", spec);
            cmd.Parameters.AddWithValue("@uprice", uprice);
            cmd.Parameters.AddWithValue("@soh", soh);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

           
            
            
        }
        public DataTable VIEWMODEL()
        {
            SqlCommand cmd = new SqlCommand("dispmodel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable VIEWMODELBYMID(int @mid)
        {
            SqlCommand cmd = new SqlCommand("dispmodel1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mid",mid);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;

        }
        public int DELETEMODEL(int @mid)
        {
            SqlCommand cmd = new SqlCommand("Delmodel1", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            cmd.Parameters.AddWithValue("@mid",mid);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;


        }
        public int INSERTUSER(string @uid, string @pwd, string @utype)
        {
            
            SqlCommand cmd = new SqlCommand("Insuser", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@utype",utype);
            int x = cmd.ExecuteNonQuery();
            con.Close();

            return x;

        }
        public DataTable VIEWUSER()
        {
            SqlCommand cmd = new SqlCommand("dispuser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
            
        }
        public DataTable VIEWUSERBYUID(string @uid)
        {
            SqlCommand cmd = new SqlCommand("dispuser1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uid",uid);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;

        }
        public int EDITUSER(string @uid,string @pwd,string @utype)
        {
            SqlCommand cmd = new SqlCommand("Updusers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@uid",uid);
            cmd.Parameters.AddWithValue("@pwd",pwd);
            cmd.Parameters.AddWithValue("@utype",utype);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public int CHKLOGIN(string uid,string pwd,string utype)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("chklog", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@utype", utype);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int x = int.Parse(dr[0].ToString());
            con.Close();
            return x;


        }
        public int DELETEUSER(string @uid)
        {
            SqlCommand cmd = new SqlCommand("deluser1", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            cmd.Parameters.AddWithValue("@uid",uid);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;


        }

        public int INSERTUSERVIEWMODEL(int @pid, string @pname,int @mid,string @mname,string @spec,int @uprice,int @quantity ,int @totalamount)
        {
            SqlCommand cmd = new SqlCommand("InsSales",con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@mid",mid);
            cmd.Parameters.AddWithValue("@mname", mname);
            cmd.Parameters.AddWithValue("@spec", spec);
            cmd.Parameters.AddWithValue("uprice", uprice);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@totalamount", totalamount);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public DataTable dailysalesreport()
        {
            SqlCommand cmd = new SqlCommand("dailyrpt",con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;


        }

        public DataTable datebetween2dates(DateTime @fdate,DateTime @tdate)
        {
            SqlCommand cmd = new SqlCommand("salesrpt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@fdate", fdate);
            cmd.Parameters.AddWithValue("@tdate", tdate);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;


        }
        public DataTable productwisereport(int @pid)
        {
            SqlCommand cmd = new SqlCommand("productwiserpt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid",pid);
            
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;


        }
        public DataTable Loadsales()
        {
            SqlCommand cmd = new SqlCommand("loadfromsales ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
           

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;


        }
        public DataTable modelwisereport(int @mid)
        {
            SqlCommand cmd = new SqlCommand("modelwiserpt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@mid",mid);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;


        }
























    }
}
