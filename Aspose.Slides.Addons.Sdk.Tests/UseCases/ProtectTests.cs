//Copyright (c) 2001-2024 Aspose Pty Ltd. All Rights Reserved
using System.Net;
using Aspose.Slides.Addons.Sdk.Api;
using Aspose.Slides.Addons.Sdk.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aspose.Slides.Addons.Sdk.Tests.UseCases;

[TestClass]
public class ProtectTests
{
    [TestMethod]
    public void Protect()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var protectionOptions = new ProtectionOptions()
        {
            ViewPassword = c_password,
            EditPassword = c_password,
            MarkAsFinal = true
        };
        var stream = api.Protect(fileStream, protectionOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void ProtectWithHttpInfo()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var protectionOptions = new ProtectionOptions()
        {
            ViewPassword = c_password,
            EditPassword = c_password,
            MarkAsFinal = true
        };
        var apiResponse = api.ProtectWithHttpInfo(fileStream, protectionOptions);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task ProtectAsync()
    {
        var api = new SlidesApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var protectionOptions = new ProtectionOptions()
        {
            ViewPassword = c_password,
            EditPassword = c_password,
            MarkAsFinal = true
        };
        var stream = await api.ProtectAsync(fileStream, protectionOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task ProtectWithHttpInfoAsync()
    {
        var api = new SlidesApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var protectionOptions = new ProtectionOptions()
        {
            ViewPassword = c_password,
            EditPassword = c_password,
            MarkAsFinal = true
        };
        var apiResponse = await api.ProtectWithHttpInfoAsync(fileStream, protectionOptions);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }

    private const string c_testFile = "../../../../TestData/test.pptx";
    private const string c_password = "password";
}