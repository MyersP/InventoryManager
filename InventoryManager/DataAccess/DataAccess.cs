using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;
using InventoryManager.Builders;

namespace InventoryManager.DataAccess
{
    public interface IDataAccess
    {
        SqlDataReader ReadCommand(string sql);
        string WriteCommand(string sql);
        void CloseConnection();
        string DataInsert(object objModel, string tableName);
        string DataUpdate(object objModel, string tableName, string identityColumn, int id);
        void DataDelete(string tableName, string identityColumn, string id);
        List<Dictionary<string, string>> DataSelect(object model, string tableName, string identityColumn, string id);
        void DataDeleteContact(string id);
        void DataUpdateSingleValue(string tableName, string selectColumnName, string selectColumnValue, string updateColumName, string updateColumnValue);
    }

    public class DataAccess :TableNames, IDataAccess
    {
        private IDataHelpers _dataHelpers = new DataHelpers();
        private static readonly string ConnectionString = ConfigurationManager.AppSettings["Red_Dress_DatabaseConnectionString"];
        public SqlConnection Con = new SqlConnection(ConnectionString);

        public SqlDataReader ReadCommand(string sql)
        {
            var cmd = new SqlCommand(sql, Con);
            //var cmd = new OleDbCommand(sql, Con);
            if (Con.State != ConnectionState.Open)
                Con.Open();
            return cmd.ExecuteReader();
        }

        public string WriteCommand(string sql)
        {
            var datareturned =string.Empty;
            var cmd = new SqlCommand(sql, Con);
            if (Con.State != ConnectionState.Open)
                Con.Open();
            //cmd.Parameters.Add("@ID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            var reader = cmd.ExecuteReader();
            while (reader != null && reader.Read())
            {
                 datareturned = reader.GetValue(0).ToString();
            }
            return datareturned;
        }

        public string WriteCommand(SqlCommand cmd)
        {
            var datareturned = string.Empty;
            if (Con.State != ConnectionState.Open)
                Con.Open();
            //cmd.Parameters.Add("@ID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            var reader = cmd.ExecuteReader();
            while (reader != null && reader.Read())
            {
                datareturned = reader.GetValue(0).ToString();
            }
            return datareturned;
        }

        public void CloseConnection()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
        }

        public string DataInsert(object objModel, string tableName)
        {
            var columnNames = "";
            var values = "";
            var fieldList = _dataHelpers.GetNameValuePairFromModel(objModel);
            var count = fieldList.Count;

            foreach (KeyValuePair<string, string> kv in fieldList)
            {
                if (count > 1)
                {
                    columnNames = columnNames + kv.Key + ",";
                    values = values + _dataHelpers.ConvertToNull(kv.Value) + ",";
                }
                else
                {
                    columnNames = columnNames + kv.Key;
                    values = values + _dataHelpers.ConvertToNull(kv.Value);
                }
                count--;
            }

            var sqlString =
                string.Format("INSERT INTO {0} ({1}) VALUES ({2}) SELECT @@IDENTITY",
                              tableName, columnNames, values);

           return WriteCommand(sqlString);
        }

        public string DataUpdate(object objModel, string tableName, string identityColumn, int id)
        {

            var columNames = "";
            var column=string.Empty;
            var fieldList = _dataHelpers.GetNameValuePairFromModel(objModel);

            var commandText = string.Format("UPDATE {0} Set ", tableName);

            var setString = " {0} = @{0},";

            foreach (var kv in fieldList)
            {
                columNames = columNames + string.Format(setString, kv.Key);
            }

            commandText = commandText + columNames.TrimEnd(',') +
                string.Format(" WHERE {0} = @ID ", identityColumn);
   
            var cmd = new SqlCommand(commandText, Con);
            cmd.Parameters.AddWithValue("@ID", id);

            foreach (var kv in fieldList)
            {
                column = string.Format("@{0}", kv.Key);
                cmd.Parameters.AddWithValue(column, _dataHelpers.CheckForNull(kv.Value));
            }
            
                return WriteCommand(cmd);
        }

        public void DataDelete(string tableName, string identityColumn, string id)
        {
            id = string.IsNullOrEmpty(id) ? id = "null" : id;
            var sqlString = string.Format("Delete From {0} Where {1} = {2}", tableName, identityColumn, id);
            WriteCommand(sqlString);
        }

        public void DataUpdateSingleValue(string tableName, string selectColumnName, string selectColumnValue, string updateColumName, string updateColumnValue)
        {
            var sqlString = string.Format("Update {0} SET {1} = {2} WHERE {3} = {4}",
                    tableName, updateColumName, updateColumnValue, selectColumnName, selectColumnValue);
            WriteCommand(sqlString);
        }

        public void DataDeleteContact(string id)
        {
            id = string.IsNullOrEmpty(id) ? id = "null" : id;
            DataDelete(ContactsTablename, ContactsId, id);

            var sqlString = string.Format("Update {0} SET {1} = 0 WHERE {1} = {2}", GarmentTableName, GarmentsCustomerId, id);
            WriteCommand(sqlString);
        }

        public void GarmentsInsert(Dictionary<string, string> garment )
        {
            Con.Open();
            var cmd = new SqlCommand("CreateGarment", Con) {CommandType = CommandType.StoredProcedure};
            foreach (KeyValuePair<string, string> kv in garment)
            {
                cmd.Parameters.Add(new SqlParameter("@" + kv.Key, kv.Value));
            }

            // execute the command
            var  rdr = cmd.ExecuteReader();
            Con.Close();
            // iterate through results, printing each to console
            //while (rdr.Read())
            //{
            //    Console.WriteLine(
            //        "Product: {0,-35} Total: {1,2}",
            //        rdr["ProductName"],
            //        rdr["Total"]);
            //}

        }

        public List<Dictionary<string, string>> DataSelect(object model, string tableName, string identityColumn, string id)
        {
            var fieldList = _dataHelpers.GetNamesFromModel(model);
            
            var dictList =new List<Dictionary<string,string>>();

            var sqlString = string.IsNullOrEmpty(id) ? string.Format("SELECT * from {0}", tableName) :
                string.Format("SELECT * from {0} Where {1} = {2}", tableName, identityColumn, id);
            
            var reader = ReadCommand(sqlString);
            while (reader != null && reader.Read())
            {
                var newObjectDict = new Dictionary<string, string>();
                for (int i = 0; i < fieldList.Count(); i++)
                {
                    newObjectDict.Add(fieldList[i], reader[fieldList[i]].ToString());
                }
                dictList.Add(newObjectDict);
            }
            return dictList;
        }
    }
}
