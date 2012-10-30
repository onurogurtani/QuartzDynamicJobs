using System;
using System.Configuration;
using Quartz;
using Quartz.Impl;
using QuartzDynamicJob.Configuration;

namespace QuartzDynamicJob
{

  
    class Program
    {


        static void Main(string[] args)
        {

            ISchedulerFactory sf = new StdSchedulerFactory();
            IScheduler sched = sf.GetScheduler();


            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var section = config.GetSection("ScheduleConfig") as ScheduleConfiguration;

            if (section != null)
                foreach (JobConfiguration f in section.Jobs)
                {
                    if (f.Run)
                    {
                        IJobDetail jobdetail = JobBuilder.Create(Type.GetType(f.JobName)).WithIdentity(f.JobName, "group1").Build();

                        ICronTrigger trigger = (ICronTrigger)TriggerBuilder.Create()
                                                                  .WithIdentity(f.JobName, "group1").StartNow()
                                                                  .WithCronSchedule(f.Cronexpression)
                                                                  .Build();
                        sched.ScheduleJob(jobdetail, trigger);
                    }





                }
            sched.Start();

            Console.ReadLine();
        }
    }


}
