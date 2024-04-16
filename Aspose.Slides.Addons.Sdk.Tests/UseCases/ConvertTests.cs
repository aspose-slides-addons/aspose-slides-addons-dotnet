//Copyright (c) 2001-2024 Aspose Pty Ltd. All Rights Reserved
using System.Net;
using Aspose.Slides.Addons.Sdk.Api;
using Aspose.Slides.Addons.Sdk.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aspose.Slides.Addons.Sdk.Tests.UseCases;

[TestClass]
public class ConvertTests
{
    [TestMethod]
    public void Convert()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var stream = api.Convert(ExportFormat.Pdf, new List<Stream>() {fileStream});
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void ConvertWithHttpInfo()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var apiResponse = api.ConvertWithHttpInfo(ExportFormat.Pdf, new List<Stream>() {fileStream});
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task ConvertAsync()
    {
        var api = new SlidesApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var stream = await api.ConvertAsync(ExportFormat.Pdf, new List<Stream>() {fileStream});
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task ConvertWithHttpInfoAsync()
    {
        var api = new SlidesApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var apiResponse = await api.ConvertWithHttpInfoAsync(ExportFormat.Pdf, new List<Stream>() {fileStream});
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }

    private const string c_testFile = "../../../../TestData/test.pptx";
}