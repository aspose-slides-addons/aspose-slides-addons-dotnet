//Copyright (c) 2001-2024 Aspose Pty Ltd. All Rights Reserved
using System.Net;
using Aspose.Slides.Addons.Sdk.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aspose.Slides.Addons.Sdk.Tests.UseCases;

[TestClass]
public class RemoveMacrosTests
{
    [TestMethod]
    public void RemoveMacros()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var stream = api.RemoveMacros(fileStream);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void RemoveMacrosWithHttpInfo()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var apiResponse = api.RemoveMacrosWithHttpInfo(fileStream);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task RemoveMacrosAsync()
    {
        var api = new SlidesApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var stream = await api.RemoveMacrosAsync(fileStream);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task RemoveMacrosWithHttpInfoAsync()
    {
        var api = new SlidesApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var apiResponse = await api.RemoveMacrosWithHttpInfoAsync(fileStream);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }

    private const string c_testFile = "../../../../TestData/macros.pptm";
}