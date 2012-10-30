using System;
using Quartz;

namespace QuartzDynamicJob.Jobs
{
    public class Job1 : IJob
    {
        #region IJob Members

        public void Execute(IJobExecutionContext context)
        {
            try
            {
       
                Console.WriteLine("Job1 is executing.");
            }
            catch (Exception)
            {
                Console.WriteLine("Job1 throw exception.");
            }
        }

        #endregion
    }

    public class Job2 : IJob
    {
        #region IJob Members

        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Job2 is executing.");
        }

        #endregion
    }

    public class Job3 : IJob
    {
        #region IJob Members

        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Job3 is executing.");
        }

        #endregion
    }
}