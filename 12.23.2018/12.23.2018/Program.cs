using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._23._2018
{
    class Program
    {
        static object lock_object = new object();

        public static List<string> file_list = new List<string>();
        static void Main(string[] args)
        {

            Task task1 = Task.Run(
                () =>
                {
                        StreamReader sr = new StreamReader("stack_items.txt");
                        string line = "";
                        while ((line = sr.ReadLine()) != null)
                        {
                            file_list.Add("z"+line);
                        }

                   

                });
            

            task1.Wait();

Console.WriteLine(file_list.Count);
            var connString = @"Data source=192.168.19.35\SQLExpress; Initial Catalog=P504;User Id=sa; Password=123456";
            string query = "";
            SqlConnection conn = new SqlConnection(connString);
            
       



                Task task2 = Task.Run(
                        () =>
                        {
                            lock (lock_object)
                            {
                                conn.Open();
                                for (var i = 0; i < file_list.Count; i++)
                                {
                                    query += "INSERT INTO stack (items) values ('" + file_list[i] + "');";
                                    file_list.RemoveAt(i);
                                }

                                SqlCommand cmd = new SqlCommand(query, conn);
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }


                        });



                Task task3 = Task.Run(
                         () =>
                         {
                             lock (lock_object)
                             {
                                 conn.Open();
                                 for (var i = 0; i < file_list.Count; i++)
                                 {
                                     query += "INSERT INTO stack (items) values ('" + file_list[i] + "');";
                                     file_list.RemoveAt(i);
                                 }

                                 SqlCommand cmd = new SqlCommand(query, conn);
                                 cmd.ExecuteNonQuery();
                                 conn.Close();
                             }
                         });




                Task task4 = Task.Run(
                     () =>
                     {
                         lock (lock_object)
                         {
                             conn.Open();
                             for (var i = 0; i <file_list.Count; i++)
                             {
                                 query += "INSERT INTO stack (items) values ('" + file_list[i] + "');";
                                 file_list.RemoveAt(i);
                             }

                             SqlCommand cmd = new SqlCommand(query, conn);
                             cmd.ExecuteNonQuery();
                             conn.Close();
                         }

                     });




                Task task5 = Task.Run(
                     () =>
                     {
                         lock (lock_object)
                         {
                             conn.Open();
                             for (var i = 0; i < file_list.Count; i++)
                             {
                                 query += "INSERT INTO stack (items) values ('" + file_list[i] + "');";
                                 file_list.RemoveAt(i);
                             }

                             SqlCommand cmd = new SqlCommand(query, conn);
                             cmd.ExecuteNonQuery();
                             conn.Close();
                         }

                     });
            Task.WaitAll(task2, task3,task4,task5);
            }

        }
    }


