using System.Configuration;

namespace QuartzDynamicJob.Configuration
{
    public class ScheduleConfiguration : ConfigurationSection
    {
        [ConfigurationCollection(typeof(JobConfigurationCollection))]
        [ConfigurationProperty("jobs")]
        public JobConfigurationCollection Jobs
        {
            get
            {
                return (JobConfigurationCollection)base["jobs"];
            }
            set
            {
                base["jobs"] = value;
            }
        }

        [ConfigurationProperty("timeout")]
        public int Timeout
        {
            get
            {
                return (int)base["timeout"];
            }
            set
            {
                base["timeout"] = value;
            }
        }

        [ConfigurationProperty("logpath")]
        public string Logpath
        {
            get
            {
                return (string)base["logpath"];
            }
            set
            {
                base["logpath"] = value;
            }
        }
        [ConfigurationProperty("description")]
        public string Description
        {
            get
            {
                return (string)base["description"];
            }
            set
            {
                base["description"] = value;
            }
        }
    }
}
