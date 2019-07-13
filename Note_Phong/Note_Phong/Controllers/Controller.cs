using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

using Note_Phong.CommonLibrary;
using Note_Phong.Model;


namespace Note_Phong.Controllers
{
    public class Controller// : IController
    {
        private ConnectionFactory connFactory;

        public Controller()
        {
            connFactory = new ConnectionFactory();
        }

        //DB common methods
        public SqlConnection OpenConnection()
        {
            return connFactory.OpenConnection();
        }

        public void CloseConnection()
        {
            connFactory.CloseConnection();
        }

        public List<DBDetailForm> QueryAllData(string tableName)
        {
            List<DBDetailForm> listDb = new List<DBDetailForm>();
            SqlDataReader dr = connFactory.QueryAllData(tableName);
            DBDetailForm db = new DBDetailForm();
            while ( dr.Read() ) {
                db.Name = this.GetName(dr);
                db.Id = this.GetId(dr);
                db.Level = this.GetLevel(dr);
                db.Deadline = this.GetDeadline(dr);
                db.Status = this.GetStatus(dr);
                db.Description = this.GetDescription(dr);
                db.TaskList = this.GetTaskList(dr);
                db.ParentId = this.GetParentId(dr);

                listDb.Add(new DBDetailForm(db));
            }
            this.CloseConnection();

            return listDb;
        }

        public DBDetailForm QueryDataWithId(string tableName, DBDetailForm dbDetailForm)
        {
            DBDetailForm dbOutput = new DBDetailForm();
            dbOutput.Id = dbDetailForm.Id;

            SqlDataReader dr = connFactory.QueryDataWithId(tableName, dbDetailForm);
            while (dr.Read())
            {
                dbOutput.Name = this.GetName(dr);
                dbOutput.Level = this.GetLevel(dr);
                dbOutput.Deadline = this.GetDeadline(dr);
                dbOutput.Status = this.GetStatus(dr);
                dbOutput.Description = this.GetDescription(dr);
                dbOutput.TaskList = this.GetTaskList(dr);
                dbOutput.ParentId = this.GetParentId(dr);
            }
            this.CloseConnection();
            return dbOutput;
        }

        public string QueryParentName (string tableName, int parentId) {
            string parentName = "";
            SqlDataReader dr = connFactory.QueryParentName(tableName, parentId);
            while(dr.Read()){
                try {
                    parentName = dr.GetString(0);
                }catch(Exception e){
                    MessageBox.Show(e.ToString());
                }
            }
            this.CloseConnection();
            return parentName;
        }

        public Dictionary<int, string> QueryAllChildren (string tableName, int parentId) {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            SqlDataReader dr = connFactory.QueryAllChildren(tableName, parentId);
            while ( dr.Read() ) {
                int columnNameIndex = dr.GetOrdinal("Name");
                int columnIdIndex = dr.GetOrdinal("Id");
                try {
                    string childName = dr.GetString(columnNameIndex);
                    int childId = dr.GetInt32(columnIdIndex);
                    dictionary.Add(childId, childName);
                } catch ( Exception e ) {
                    MessageBox.Show(e.ToString());
                }
            }
            this.CloseConnection();
            return dictionary;
        }

        public Dictionary<int, string> QueryAllRoot (string tableName) {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            SqlDataReader dr = connFactory.QueryAllRoot(tableName);
            while ( dr.Read() ) {
                int columnNameIndex = dr.GetOrdinal("Name");
                int columnIdIndex = dr.GetOrdinal("Id");
                try {
                    string childName = dr.GetString(columnNameIndex);
                    int childId = dr.GetInt32(columnIdIndex);
                    dictionary.Add(childId, childName);
                } catch ( Exception e ) {
                    MessageBox.Show(e.ToString());
                }
            }
            this.CloseConnection();
            return dictionary;
        }

        public bool InsertData(string tableName, DBDetailForm dbDetailForm)
        {
            return connFactory.InsertData(tableName, dbDetailForm);
        }

        public bool UpdateData(string tableName, DBDetailForm dbDetailForm)
        {
            return connFactory.UpdateData(tableName, dbDetailForm);
        }

        public bool DeleteData(string tableName, int id)
        {
            return connFactory.DeleteData(tableName, id);
        } //End DB common methods

        //Methods for querying specific column
        string GetName(SqlDataReader dr)
        {
            string name = "Fail to query name!";
                int columnIndex = dr.GetOrdinal("Name");
                try
                {
                    name = dr.GetString(columnIndex);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            return name;
        }

        int GetId (SqlDataReader dr) {
            int Id = -1;
            try {
                int columnIndex = dr.GetOrdinal("Id");
                Id = dr.GetInt32(columnIndex);
            } catch ( Exception e ) {
                MessageBox.Show(e.ToString());
            }
            return Id;
        }

        int GetLevel(SqlDataReader dr)
        {
            int level = -1;
            try
            {
                int columnIndex = dr.GetOrdinal("Level");
                level = dr.GetInt32(columnIndex);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return level;
        }

        DateTime GetDeadline(SqlDataReader dr)
        {
            DateTime dt = DateTimePicker.MinimumDateTime;
            try
            {
                int columnIndex = dr.GetOrdinal("Deadline");
                dt = dr.GetDateTime(columnIndex);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return dt;
        }

        string GetStatus(SqlDataReader dr)
        {
            string status = "Fail to query status!";

            try
            {
                int columnIndex = dr.GetOrdinal("Status");
                status = dr.GetString(columnIndex);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return status;
        }

        string GetDescription(SqlDataReader dr)
        {
            string description = "Fail to query description!";

            try
            {
                int columnIndex = dr.GetOrdinal("Description");
                description = dr.GetString(columnIndex);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return description;
        }

        string GetTaskList(SqlDataReader dr)
        {
            string taskList = "Fail to query taskList!";

            try
            {
                int columnIndex = dr.GetOrdinal("TaskList");
                taskList = dr.GetString(columnIndex);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return taskList;
        }

        int GetParentId(SqlDataReader dr)
        {
            int parentId = -1;

            try
            {
                int columnIndex = dr.GetOrdinal("ParentId");
                parentId = dr.GetInt32(columnIndex);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            };
            return parentId;
        }

    }
}
