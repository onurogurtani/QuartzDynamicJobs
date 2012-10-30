using System.Configuration;

namespace QuartzDynamicJob.Configuration
{
    public class JobConfigurationCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new JobConfiguration();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as JobConfiguration).JobName;
        }
    }
}