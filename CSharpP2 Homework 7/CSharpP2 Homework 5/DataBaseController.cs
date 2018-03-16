using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace CSharpP2_Homework_5
{
    class DataBaseController
    {
        string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        private object sqlDbType;

        public DataBaseController ()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
        }
       
        public DataTable GetData(SqlCommand command)
        {
            adapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void DeleteData(string command, DataGrid dataGrid)
        {
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            SqlParameter parameter = sqlCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");
            parameter.SourceVersion = DataRowVersion.Original;
            adapter.DeleteCommand = sqlCommand;

            DataRowView rowView = (DataRowView)dataGrid.SelectedItem;
            rowView.Row.Delete();
            adapter.Update(dataTable);
        }

        public void AddData(string command, string surname, string name, string patronimyc, int depID)
        {
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            sqlCommand.Parameters.Add("@SURNAME", SqlDbType.NVarChar, -1, "SURNAME");
            sqlCommand.Parameters.Add("@NAME", SqlDbType.NVarChar, -1, "NAME");
            sqlCommand.Parameters.Add("@PATRONIMYC", SqlDbType.NVarChar, -1, "PATRONIMYC");
            sqlCommand.Parameters.Add("@DEPID", SqlDbType.Int, -1, "DEPID");
        }



    }
}
