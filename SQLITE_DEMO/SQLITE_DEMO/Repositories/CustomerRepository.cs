//using SQLite;
//using SQLITE_DEMO.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using System.Text;

//namespace SQLITE_DEMO.Repositories
//{
//    public class CustomerRepository
//    {
//        SQLiteConnection connection;

//        public string StatusMessage { get; set; }

//        public CustomerRepository()
//        {
//            connection =
//                new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
//            connection.CreateTable<Customer>();

//        }

//        public void AddOrUpdate(Customer _customer)
//        {
//            int result = 0;
//            try
//            {
//                //id
//                if (_customer.Id != 0)
//                {
//                    result = connection.Update(_customer);
//                    StatusMessage = $"{result} registros(s) actualizados";
//                }
//                else
//                { 
//                    result = connection.Insert(_customer);
//                    StatusMessage = $"{result} registros(s) agregados";
//                }
//            }
//            catch (Exception ex)
//            {
//                StatusMessage = $"Error: {ex.Message}";
//            }
//        }

//        public List<Customer> GetAll()
//        {
//            try
//            {
//                return connection.Table<Customer>().ToList();
//            }
//            catch (Exception ex)
//            {
//                StatusMessage = $"Error: {ex.Message}";
//            }

//            return null;
//        } 

//        public Customer Get(int id)
//        {
//            try
//            {
//                return connection
//                    .Table<Customer>()
//                    .FirstOrDefault(x => x.Id == id);
//            }
//            catch (Exception ex)
//            {
//                StatusMessage = $"Error: {ex.Message}";
//            }

//            return null;
//        }

//        public List<Customer> Get(Expression<Func<Customer, bool>> predicate)
//        {
//            try
//            {
//                return connection.Table<Customer>().Where(predicate).ToList();
//            }
//            catch (Exception ex)
//            {

//                StatusMessage = $"Error: {ex.Message}";
//            }



//        }
//        public List<Customer> GetAll2()
//        {
//            try
//            {
//                return connection.Query<Customer>("SELECT * FROM Customers");
//            }
//            catch (Exception ex)
//            {
//                StatusMessage = $"Error: {ex.Message}";
//            }

//            return null;
//        }

//        public void Delete(int customerId)
//        {
//            try
//            {
//                var customer = Get(customerId);
//                connection.Delete(customer);

//            }
//            catch(Exception ex)
//            {
//                StatusMessage = $"Error: {ex.Message}";
//            }
//        }
//    }
//}
