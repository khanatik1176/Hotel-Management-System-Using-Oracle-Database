using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace HotelManagementSystem
{
    class DataAccess
    {
        private OracleConnection sqlcon;
        public OracleConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private OracleCommand sqlcom;
        public OracleCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private OracleDataAdapter sda;
        public OracleDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        //internal DataTable dt;

        public DataAccess()
        {
             this.Sqlcon = new OracleConnection(@"DATA SOURCE = localhost:1521/XE; USER ID=scott;PASSWORD=tiger");
            Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new OracleCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.Sqlcom = new OracleCommand(sql, this.Sqlcon);//this.QueryText(sql);
            this.Sda = new OracleDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            this.Sqlcom = new OracleCommand(sql, this.Sqlcon);//this.QueryText(sql);
            this.Sda = new OracleDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds.Tables[0];
        }

        public int ExecuteDMLQuery(string sql)
        {
            this.Sqlcom = new OracleCommand(sql, this.Sqlcon);//this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }
    }
}


