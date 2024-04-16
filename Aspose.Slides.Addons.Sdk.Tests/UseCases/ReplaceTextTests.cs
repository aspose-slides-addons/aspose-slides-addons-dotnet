//Copyright (c) 2001-2024 Aspose Pty Ltd. All Rights Reserved
using System.Net;
using Aspose.Slides.Addons.Sdk.Api;
using Aspose.Slides.Addons.Sdk.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aspose.Slides.Addons.Sdk.Tests.UseCases;

[TestClass]
public class ReplaceTextTests
{
    [TestMethod]
    public void ReplaceText()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var replaceTextOptions = new ReplaceTextOptions()
        {
            IgnoreCase = true,
            NewValue = c_newValue,
            OldValue = c_oldValue
        };
        var stream = api.ReplaceText(replaceTextOptions, new List<Stream>(){fileStream});
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void ReplaceTextWithHttpInfo()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var replaceTextOptions = new ReplaceTextOptions()
        {
            IgnoreCase = true,
            NewValue = c_newValue,
            OldValue = c_oldValue
        };
        var apiResponse = api.ReplaceTextWithHttpInfo(replaceTextOptions, new List<Stream>(){fileStream});
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task ReplaceTextAsync()
    {
        var api = new SlidesApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var replaceTextOptions = new ReplaceTextOptions()
        {
            IgnoreCase = true,
            NewValue = c_newValue,
            OldValue = c_oldValue
        };
        var stream = await api.ReplaceTextAsync(replaceTextOptions, new List<Stream>(){fileStream});
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task ReplaceTextWithHttpInfoAsync()
    {
        var api = new SlidesApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var replaceTextOptions = new ReplaceTextOptions()
        {
            IgnoreCase = true,
            NewValue = c_newValue,
            OldValue = c_oldValue
        };
        var apiResponse = await api.ReplaceTextWithHttpInfoAsync(replaceTextOptions, new List<Stream>(){fileStream});
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }

    private const string c_testFile = "../../../../TestData/test.pptx";
    private const string c_oldValue = "Text to replace";
    private const string c_newValue = "New value";
}