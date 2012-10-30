using System.Configuration;

namespace QuartzDynamicJob.Configuration
{
    public class JobConfiguration : ConfigurationElement
    {
        [ConfigurationProperty("jobName")]
        public string JobName
        {
            get
            {
                return (string)base["jobName"];
            }
            set
            {
                base["jobName"] = value;
            }
        }

        [ConfigurationProperty("cronexpression")]
        public string Cronexpression
        {
            get
            {
                return (string)base["cronexpression"];
            }
            set
            {
                base["cronexpression"] = value;
            }
        }


        [ConfigurationProperty("desciption")]
        public string Desciption
        {
            get
            {
                return (string)base["desciption"];
            }
            set
            {
                base["desciption"] = value;
            }
        }


        [ConfigurationProperty("run")]
        public bool Run
        {
            get
            {
                return (bool)base["run"];
            }
            set
            {
                base["run"] = value;
            }
        }





    }
}