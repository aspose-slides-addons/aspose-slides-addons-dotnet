//Copyright (c) 2001-2024 Aspose Pty Ltd. All Rights Reserved
using System.Net;
using Aspose.Slides.Addons.Sdk.Api;
using Aspose.Slides.Addons.Sdk.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aspose.Slides.Addons.Sdk.Tests.UseCases;

[TestClass]
public class SplitTests
{
    [TestMethod]
    public void Split()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var splitOptions = new SplitOptions()
        {
            SlidesRange = "1,2-4,5"
        };
        var stream = api.Split(ExportFormat.Pdf, fileStream, splitOptions);
        Assert.IsTrue(stream.Length > 0);   
    }
    
    [TestMethod]
    public void SplitWithHttpInfo()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var apiResponse = api.SplitWithHttpInfo(ExportFormat.Pdf, fileStream);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task SplitAsync()
    {
        var api = new SlidesApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var stream = await api.SplitAsync(ExportFormat.Pdf, fileStream);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task SplitWithHttpInfoAsync()
    {
        var api = new SlidesApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        
        var splitOptions = new SplitOptions()
        {
            SlidesRange = "1,2-4,5"
        };
        
        var apiResponse = await api.SplitWithHttpInfoAsync(ExportFormat.Pdf, fileStream, splitOptions);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    private const string c_testFile = "../../../../TestData/test.pptx";
}