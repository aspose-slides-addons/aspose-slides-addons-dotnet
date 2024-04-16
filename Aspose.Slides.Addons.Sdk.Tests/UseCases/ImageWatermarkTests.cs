﻿//Copyright (c) 2001-2024 Aspose Pty Ltd. All Rights Reserved
using System.Net;
using Aspose.Slides.Addons.Sdk.Api;
using Aspose.Slides.Addons.Sdk.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aspose.Slides.Addons.Sdk.Tests.UseCases;

[TestClass]
public class ImageWatermarkTests
{
    [TestMethod]
    public void ImageWatermark()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        using var watermarkImageStream = File.Open(c_watermarkFile, FileMode.Open);
        var watermarkOptions = new ImageWatermarkOptions()
        {
            Angle = c_fontAngle,
            Zoom = c_zoom
        };
        var stream = api.ImageWatermark(new List<Stream>(){fileStream}, watermarkImageStream, watermarkOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void ImageWatermarkHttpInfo()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        using var watermarkImageStream = File.Open(c_watermarkFile, FileMode.Open);
        var watermarkOptions = new ImageWatermarkOptions()
        {
            Angle = c_fontAngle,
            Zoom = c_zoom
        };
        var apiResponse = api.ImageWatermarkWithHttpInfo(new List<Stream>(){fileStream}, watermarkImageStream, watermarkOptions);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task ImageWatermarkAsync()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        using var watermarkImageStream = File.Open(c_watermarkFile, FileMode.Open);
        var watermarkOptions = new ImageWatermarkOptions()
        {
            Angle = c_fontAngle,
            Zoom = c_zoom
        };
        var stream = await api.ImageWatermarkAsync(new List<Stream>(){fileStream}, watermarkImageStream, watermarkOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task ImageWatermarkWithHttpInfoAsync()
    {
        var api = new SlidesApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        using var watermarkImageStream = File.Open(c_watermarkFile, FileMode.Open);
        var watermarkOptions = new ImageWatermarkOptions()
        {
            Angle = c_fontAngle,
            Zoom = c_zoom
        };
        var apiResponse = await api.ImageWatermarkWithHttpInfoAsync(new List<Stream>(){fileStream}, watermarkImageStream, watermarkOptions);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }

    private const string c_testFile = "../../../../TestData/test.pptx";
    private const string c_watermarkFile = "../../../../TestData/watermark.png";
    private const int c_fontAngle = -45;
    private const int c_zoom = 50;
}