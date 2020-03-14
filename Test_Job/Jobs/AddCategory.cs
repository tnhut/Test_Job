using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using Quartz.Impl;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using Test_Job.DbContent;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.Mvc;

namespace Test_Job.Jobs
{
    public class AddCategory : IJob
    {
        CommandDb cmd = new CommandDb();
        Connection con = new Connection();
        public async Task  Execute(IJobExecutionContext context)
        {
            //using (con.Connect())
            //{
            //    // 1.  create a command object identifying the stored procedure
            //    var ins = cmd.ExecuteNonQueryAsync("InsertData");

            //    throw new NotImplementedException();
            //}
            try
            {
                con.Connect();
                 await Task.Run(()=> cmd.ExecuteNonQueryAsync("InsertData"));
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }


            Console.WriteLine("\nSorry for the delay. . . .\n");
            // 


        }
    }
}