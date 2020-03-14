using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Job.Jobs
{
    public class JobScheduler
    {
        public static async void Start()

        {

            IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler();

            await  scheduler.Start();



            IJobDetail job = JobBuilder.Create<AddCategory>().Build();



            ITrigger trigger = TriggerBuilder.Create()

                .WithSimpleSchedule

                  (s =>

                     s.WithIntervalInSeconds(6)

                    .WithRepeatCount(7))
                    .StartNow()
                    .Build();



            await scheduler.ScheduleJob(job, trigger);
            await scheduler.Start();
        }
    }
}