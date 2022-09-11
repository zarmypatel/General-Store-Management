using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace GeneralStoreManagementSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string InsertProduct(string item,string type,string des);

        [OperationContract]
        string DeleteProduct(string item);

        [OperationContract]
        DataTable ShowProductTable();

        [OperationContract]
        DataTable GetProduct(string item);

        [OperationContract]
        string UpdateProduct(string name, string item, string type, string des);

    }



    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "GeneralStoreManagementSystem.ContractType".

}
