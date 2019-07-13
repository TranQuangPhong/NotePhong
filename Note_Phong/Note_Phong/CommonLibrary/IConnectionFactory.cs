using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using Note_Phong.Model;

namespace Note_Phong.CommonLibrary
{
    public interface IConnectionFactory
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
        /// Query all DB & return a SqlDatareader
        /// </summary>
        /// <param name="tableName"></param>Name of table in DB
        /// <returns>dr</returns>SqlDataReader
        SqlDataReader QueryAllData(string tableName);

        /// <summary>
        /// Query DB with specific Id & return a SqlDatareader
        /// </summary>
        /// <param name="tableName"></param>Name of table in DB
        /// <param name="dbDetailForm"></param>use dbDetailForm.id to query
        /// <returns>dr</returns>SqlDatareader
        SqlDataReader QueryDataWithId(string tableName, DBDetailForm dbDetailForm);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="parentId"></param>
        /// <returns></returns>
        SqlDataReader QueryParentName (string tableName, int parentId);

        /// <summary>
        /// Query all children
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="parentId"></param>
        /// <returns></returns>
        SqlDataReader QueryAllChildren (string tableName, int parentId);

        /// <summary>
        /// Query all root forms
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="parentId"></param>
        /// <returns></returns>
        SqlDataReader QueryAllRoot (string tableName);

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
    }
}
