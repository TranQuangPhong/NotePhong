using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using Note_Phong.CommonLibrary;
using Note_Phong.Model;

namespace Note_Phong.Controllers
{
    public interface IController
    {
        /// <summary>
        /// Open DB connection
        /// </summary>
        /// <returns></returns>return a SqlConnection
        SqlConnection OpenConnection();

        /// <summary>
        /// Close DB connection after finishing actions (query, insert, update, delete)
        /// </summary>
        void CloseConnection();

        /// <summary>
        /// Query all DB & return a list of DBDetailForm objects
        /// </summary>
        /// <param name="tableName"></param>Name of table in DB
        /// <returns>dr</returns>List<DBDetailForm>
        List<DBDetailForm> QueryAllData (string tableName);

        /// <summary>
        /// Query DB with specific Id & return a DBDetailForm object
        /// </summary>
        /// <param name="tableName"></param>Name of table in DB
        /// <param name="dbDetailForm"></param>use dbDetailForm.id to query
        /// <returns></returns>DBDetailForm object containing all results of columns in DB
        DBDetailForm QueryDataWithId(string tableName, DBDetailForm dbDetailForm);

        /// <summary>
        /// Get Name of parent form
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="parentId"></param>
        /// <returns></returns>
        string QueryParentName (string tableName, int parentId);

        /// <summary>
        /// Get all Id & Name of all children
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="parentId"></param>
        /// <returns></returns>Dictionary<int, string> contains Id & Name of all children
        Dictionary<int, string> QueryAllChildren (string tableName, int parentId);

        /// <summary>
        /// Insert new record to DB when user creates new form, return true if insert successfully
        /// </summary>
        /// <param name="tableName"></param>Name of table in DB
        /// <param name="dbDetailForm"></param>Object of class DBDetailForm, provide Name & Id to insert   
        /// <returns>output</returns>true if insert successfully
        bool InsertData(string tableName, DBDetailForm dbDetailForm);
        
        /// <summary>
        /// Updata entire Detail_form, return true if update successfully
        /// </summary>
        /// <param name="tableName"></param>Name of table in DB
        /// <param name="dbDetailForm"></param>Object of class DBDetailForm, provide data to update
        /// <returns>output</returns>true if update successfully
        bool UpdateData(string tableName, DBDetailForm dbDetailForm);


        /// <summary>
        /// Delete current form & all children, return true if delete successfully
        /// </summary>
        /// <param name="tableName"></param>Name of table in DB
        /// <param name="id"></param>id to delete in DB
        /// <returns>output</returns>true if delete successfully
        bool DeleteData(string tableName, int id);

        /// <summary>
        /// Util functions to get column value from datareader
        /// </summary>
        /// <param name="dr"></param>SqlDataReader
        /// <returns></returns>value of the column
        string GetName(SqlDataReader dr);
        //int GetId(SqlDataReader dr);
        int GetLevel(SqlDataReader dr);
        DateTime GetDeadline(SqlDataReader dr);
        string GetStatus(SqlDataReader dr);
        string GetDescription(SqlDataReader dr);
        string GetTaskList(SqlDataReader dr);
        int GetParentId(SqlDataReader dr);
    }
}
