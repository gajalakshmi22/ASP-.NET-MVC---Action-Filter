using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;
using System.Configuration;

namespace DemoFile.Common
{
    public class PartialCacheAttribute : OutputCacheAttribute
    {
        public PartialCacheAttribute(string cacheProfileName)
        {
            OutputCacheSettingsSection outputCacheSettingsSection =
            (OutputCacheSettingsSection) WebConfigurationManager.GetSection("system.web/caching/outputCacheSettings");
            OutputCacheProfile outputCacheProfile = outputCacheSettingsSection.OutputCacheProfiles[cacheProfileName];
            Duration = outputCacheProfile.Duration;
            VaryByParam = outputCacheProfile.VaryByParam;
        }
    }
}