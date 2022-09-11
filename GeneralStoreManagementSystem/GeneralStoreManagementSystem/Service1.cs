using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GeneralStoreManagementSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        
        public string InsertProduct(string item,string type,string des)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GeneralStoreManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Product(Product_title,Product_type,Product_descripation) values('"+item+"','"+type+"','"+des+"')";
                con.Open();
                int id = cmd.ExecuteNonQuery();
                //Console.Write(id);
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return "Product Successfully Inserted!";
        }

        public string UpdateProduct(string name, string item, string type, string des)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GeneralStoreManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Product set Product_title='"+item+"',Product_type='"+type+"',Product_descripation='"+des+"' where Product_title='"+name+"'";
                con.Open();
                int id = cmd.ExecuteNonQuery();
                Console.Write(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return "Product Successfully Updated!";
        }


        public DataTable ShowProductTable()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GeneralStoreManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Product", con);
                    DataTable dtbl = new DataTable();
                    da.Fill(dtbl);
                    dtbl.TableName = "Product";
                    return dtbl;
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }

        public string DeleteProduct(string item)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GeneralStoreManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Product where Product_title='"+item+"'";
                con.Open();
                int id = cmd.ExecuteNonQuery();
                Console.Write(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return "Product Successfully Deleted!";
        }


        public DataTable GetProduct(string item)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GeneralStoreManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {

                    con.Open();
                    string query = "select * from Product where Product_title = '" + item + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dtbl = new DataTable();
                    da.Fill(dtbl);
                    dtbl.TableName = "Product";
                    return dtbl;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }

    }
}
