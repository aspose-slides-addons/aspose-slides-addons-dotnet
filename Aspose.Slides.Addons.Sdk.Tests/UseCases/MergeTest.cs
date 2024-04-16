//Copyright (c) 2001-2024 Aspose Pty Ltd. All Rights Reserved
using System.Net;
using Aspose.Slides.Addons.Sdk.Api;
using Aspose.Slides.Addons.Sdk.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aspose.Slides.Addons.Sdk.Tests.UseCases;

[TestClass]
public class MergeTest
{
    [TestMethod]
    public void Merge()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        using var masterFileStream = File.Open(c_masterFile, FileMode.Open);
        var mergeOptions = new MergeOptions()
        {
            MasterFileName = Path.GetFileName(c_masterFile),
            ExcludeMasterFile = false
        };
        
        var stream = api.Merge(ExportFormat.Pdf, new List<Stream>() {fileStream, masterFileStream}, mergeOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task MergeAsync()
    {
        var api = new SlidesApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        await using var masterFileStream = File.Open(c_masterFile, FileMode.Open);
        var mergeOptions = new MergeOptions()
        {
            MasterFileName = Path.GetFileName(c_masterFile),
            ExcludeMasterFile = false
        };
        
        var stream = await api.MergeAsync(ExportFormat.Pdf, new List<Stream>() {fileStream, masterFileStream}, mergeOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void MergeHttpInfo()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        using var masterFileStream = File.Open(c_masterFile, FileMode.Open);
        var mergeOptions = new MergeOptions()
        {
            MasterFileName = Path.GetFileName(c_masterFile),
            ExcludeMasterFile = false
        };
        var apiResponse = api.MergeWithHttpInfo(ExportFormat.Pdf, new List<Stream>() { fileStream, masterFileStream },
            mergeOptions);
        
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task MergeHttpInfoAsync()
    {
        var api = new SlidesApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        await using var masterFileStream = File.Open(c_masterFile, FileMode.Open);
        var mergeOptions = new MergeOptions()
        {
            MasterFileName = Path.GetFileName(c_masterFile),
            ExcludeMasterFile = false
        };
        var apiResponse = await api.MergeWithHttpInfoAsync(ExportFormat.Pdf,
            new List<Stream>() { fileStream, masterFileStream }, mergeOptions);
        
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    private const string c_testFile = "../../../../TestData/test.pptx";
    private const string c_masterFile = "../../../../TestData/master.pptx";
}