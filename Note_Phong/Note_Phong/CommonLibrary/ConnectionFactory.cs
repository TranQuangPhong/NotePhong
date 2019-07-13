using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using Note_Phong.Model;

namespace Note_Phong.CommonLibrary {
    public class ConnectionFactory : IConnectionFactory {
        private string connectionString = @"Data Source=DESKTOP-AEC1TNP\SQLEXPRESS;"
            + "Initial Catalog=NotePhong;"
            + "Persist Security Info=False;"
            + "User ID=sa;Password=sqlserver";
        /* Use below string fomat for local DB
         * 
         * private string connectionString = @"Data Source=(LocalDB)\v11.0;"
         * + @"AttachDbFilename=D:\Phong\BK_Softwares\visual_studio\workspace\C_Sharp\DBSQLTest\DBSQLTest\DB1Test.mdf;"
         * + "Integrated Security=True;"
         * + "Connect Timeout=30";
         */

        private SqlCommand sqlCmd;
        private SqlConnection conn;
        private SqlDataReader dataReader;

        public ConnectionFactory () {
            conn = new SqlConnection(connectionString);
        }

        public SqlConnection OpenConnection () {
            try {
                if ( conn.State == ConnectionState.Closed ) {
                    conn.Open();
                }
            } catch ( Exception e ) {
                MessageBox.Show(e.ToString());
            }
            return conn;
        }

        public void CloseConnection () {
            try {
                if ( conn.State == ConnectionState.Open ) {
                    conn.Close();
                }
            } catch ( Exception e ) {
                MessageBox.Show(e.ToString());
            }
        }

        public SqlDataReader QueryAllData (string tableName) {
            this.OpenConnection();
            try {
                string sqlString = "select * from " + tableName;
                sqlCmd = new SqlCommand(sqlString, conn);
                dataReader = sqlCmd.ExecuteReader();
            } catch ( Exception e ) {
                MessageBox.Show(e.ToString());
            }
            return dataReader;
            //Keep connection opening, only close connection after completing reading SqlDataReader
        }

        public SqlDataReader QueryDataWithId (string tableName, DBDetailForm dbDetailForm) {
            this.OpenConnection();
            try {
                string sqlString = "select * from " + tableName + " where Id = @Id";
                sqlCmd = new SqlCommand(sqlString, conn);
                sqlCmd.Parameters.Add("@Id", SqlDbType.Int).Value = dbDetailForm.Id;
                dataReader = sqlCmd.ExecuteReader();
            } catch ( Exception e ) {
                MessageBox.Show(e.ToString());
            }
            return dataReader;
            //Keep connection opening, only close connection after completing reading SqlDataReader
        }

        public SqlDataReader QueryParentName (string tableName, int parentId) {
            this.OpenConnection();
            try {
                string sqlString = "select Name from " + tableName + " where Id = @ParentId";
                sqlCmd = new SqlCommand(sqlString, conn);
                sqlCmd.Parameters.Add("@ParentId", SqlDbType.NVarChar).Value = parentId;
                dataReader = sqlCmd.ExecuteReader();
            } catch ( Exception e ) {
                MessageBox.Show(e.ToString());
            }

            return dataReader;
        }

        public SqlDataReader QueryAllChildren (string tableName, int parentId) {
            this.OpenConnection();
            try {
                string sqlString = "select Name, Id from " + tableName + " where ParentId = @ParentId";
                sqlCmd = new SqlCommand(sqlString, conn);
                sqlCmd.Parameters.Add("@ParentId", SqlDbType.Int).Value = parentId;
                dataReader = sqlCmd.ExecuteReader();
            } catch ( Exception e ) {
                MessageBox.Show(e.ToString());
            }

            return dataReader;
        }

        public SqlDataReader QueryAllRoot (string tableName) {
            this.OpenConnection();
            try {
                string sqlString = "select Name, Id from " + tableName + " where ParentId = @DefaultParentId";
                sqlCmd = new SqlCommand(sqlString, conn);
                sqlCmd.Parameters.Add("@DefaultParentId", SqlDbType.Int).Value = -1;
                dataReader = sqlCmd.ExecuteReader();
            } catch ( Exception e ) {
                MessageBox.Show(e.ToString());
            }

            return dataReader;
        }

        public bool InsertData (string tableName, DBDetailForm dbDetailForm) {
            bool output = false;
            this.OpenConnection();
            try {
                string sqlString = "insert into " + tableName + "(Name, Id, Level, Deadline, Status, Description, TaskList, ParentId)"
                    + " values(@Name, @Id, @Level, @Deadline, @Status, @Description, @TaskList, @ParentId)";

                sqlCmd = new SqlCommand(sqlString, conn);

                sqlCmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = dbDetailForm.Name;
                sqlCmd.Parameters.Add("@Id", SqlDbType.Int).Value = dbDetailForm.Id;
                sqlCmd.Parameters.Add("@Level", SqlDbType.Int).Value = dbDetailForm.Level;
                sqlCmd.Parameters.Add("@Deadline", SqlDbType.Date).Value = dbDetailForm.Deadline;
                sqlCmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = dbDetailForm.Status;
                sqlCmd.Parameters.Add("@Description", SqlDbType.NVarChar, -1).Value = dbDetailForm.Description;
                sqlCmd.Parameters.Add("@TaskList", SqlDbType.NVarChar, -1).Value = dbDetailForm.TaskList;
                sqlCmd.Parameters.Add("@ParentId", SqlDbType.Int).Value = dbDetailForm.ParentId;

                if ( sqlCmd.ExecuteNonQuery() >= 1 )
                    output = true;
            } catch ( Exception e ) {
                if ( e is SqlException ) {
                    //Cast e from 'Exeption' to 'SqlExeption', to get the 'Number' of exeption
                    SqlException innerExeption = e as SqlException;

                    // Exception number 2627 = Violation of %ls constraint '%.*ls'. Cannot insert duplicate key in object '%.*ls'.
                    // Exception number 2601 = Cannot insert duplicate key row in object '%.*ls' with unique index '%.*ls'.
                    // See http://msdn.microsoft.com/en-us/library/cc645603.aspx for more information and possible exception numbers
                    if ( innerExeption != null && (innerExeption.Number == 2627 || innerExeption.Number == 2601) ) {
                        MessageBox.Show("Conflict with existed Id, re-type another Id!");
                    }
                } else
                    MessageBox.Show(e.ToString());
            } finally {
                this.CloseConnection();
            }
            return output;
        }

        public bool UpdateData (string tableName, DBDetailForm dbDetailForm) {
            bool output = false;
            this.OpenConnection();
            try {
                string sqlString = "update " + tableName + " set "
                    + "Name = @Name, Level = @Level, Deadline = @Deadline, Status = @Status, "
                    + "Description = @Description, TaskList = @TaskList "
                    + "where Id = @Id";

                sqlCmd = new SqlCommand(sqlString, conn);

                sqlCmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = dbDetailForm.Name;
                sqlCmd.Parameters.Add("@Level", SqlDbType.Int).Value = dbDetailForm.Level;
                sqlCmd.Parameters.Add("@Deadline", SqlDbType.Date).Value = dbDetailForm.Deadline;
                sqlCmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = dbDetailForm.Status;
                sqlCmd.Parameters.Add("@Description", SqlDbType.NVarChar, -1).Value = dbDetailForm.Description;
                sqlCmd.Parameters.Add("@TaskList", SqlDbType.NVarChar, -1).Value = dbDetailForm.TaskList;

                sqlCmd.Parameters.Add("@Id", SqlDbType.Int).Value = dbDetailForm.Id;

                if ( sqlCmd.ExecuteNonQuery() >= 1 )
                    output = true;
            } catch ( Exception e ) {
                MessageBox.Show(e.ToString());
            } finally {
                this.CloseConnection();
            }
            return output;
        }

        public bool DeleteData (string tableName, int id) {
            bool output = false;
            this.OpenConnection();
            try {
                string sqlString = "delete from " + tableName
                    + " where convert(nvarchar, ParentId) like @IdString + '%'"
                    + " or Id = @Id";

                sqlCmd = new SqlCommand(sqlString, conn);

                sqlCmd.Parameters.Add("@IdString", SqlDbType.NVarChar).Value = id.ToString();
                sqlCmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                if ( sqlCmd.ExecuteNonQuery() >= 1 )
                    output = true;
            } catch ( Exception e ) {
                MessageBox.Show(e.ToString());
            } finally {
                this.CloseConnection();
            }
            return output;
        }
    }
}
