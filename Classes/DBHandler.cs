using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;

namespace RackKeyV07
{
    public class DBHandler
    {
        private OleDbConnection connection ;
        public static string DBPath;
        public DBHandler()
        {
            string connectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Properties.Settings.Default.DBLocation;
            connection = new OleDbConnection(connectionstring);

        }
        public DBHandler(string DBfilepath)
        {

            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+DBfilepath);
            DBPath = DBfilepath;
        }

        public void Insert(string sql)
        {
            try
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();

        }
        public DataTable Select(string sql)
        {
            using (OleDbCommand selectCommand = new OleDbCommand(sql, connection))
            {
                try
                {
                    connection.Open();
                    DataTable table = new DataTable();
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = selectCommand;
                    adapter.Fill(table);                
                    connection.Close();
                    return table;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }
                return null;

            }
        }

        public void Update(string sql)
        {
            try
            {
                connection.Open();

                OleDbCommand cmd;
                cmd = new OleDbCommand(sql, connection);

                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Delete(string sql)
        {
            try
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();

        }
        
        public int InsertAndSelect(string sql)
        {
            try
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                int id = (int)(cmd.ExecuteScalar());
                connection.Close();                
                return id;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                connection.Close();
                return -1;
            }
            
        }
        
    }
}
