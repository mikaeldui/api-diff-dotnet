using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDiff
{
    public static class NuGetOrgHelper
    {
        public static Uri GetDownloadUriForPackage(string packageName, string packageVersion) =>
            new($"https://www.nuget.org/api/v2/package/{packageName}/{packageVersion}");
    }
}
