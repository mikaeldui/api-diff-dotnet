using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiDiff.Tests;

[TestClass]
public class DiffTest
{
    private const string PACKAGE_NAME = "mikaeldui.riotgames.client";
    private const string PACKAGE_VERSION = "12.3.1.296";

    [TestMethod]
    public async Task TestMethod1()
    {
        var packageUri = NuGetOrgHelper.GetDownloadUriForPackage(PACKAGE_NAME, PACKAGE_VERSION);

        using var client = new HttpClient();
        await using var stream = await client.GetStreamAsync(packageUri);
        await using var file = File.Create($"{PACKAGE_NAME}.nupkg");
        await stream.CopyToAsync(file);
        await file.FlushAsync();


    }
}