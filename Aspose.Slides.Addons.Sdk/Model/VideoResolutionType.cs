//Copyright (c) 2001-2024 Aspose Pty Ltd. All Rights Reserved


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Aspose.Slides.Addons.Sdk.Client.OpenAPIDateConverter;

namespace Aspose.Slides.Addons.Sdk.Model
{
    /// <summary>
    /// Defines VideoResolutionType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VideoResolutionType
    {
        /// <summary>
        /// Enum SD for value: SD
        /// </summary>
        [EnumMember(Value = "SD")]
        SD = 1,

        /// <summary>
        /// Enum HD for value: HD
        /// </summary>
        [EnumMember(Value = "HD")]
        HD = 2,

        /// <summary>
        /// Enum FullHD for value: FullHD
        /// </summary>
        [EnumMember(Value = "FullHD")]
        FullHD = 3,

        /// <summary>
        /// Enum QHD for value: QHD
        /// </summary>
        [EnumMember(Value = "QHD")]
        QHD = 4

    }

}
