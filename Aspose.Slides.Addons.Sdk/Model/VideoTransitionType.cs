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
    /// Defines VideoTransitionType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VideoTransitionType
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Random for value: Random
        /// </summary>
        [EnumMember(Value = "Random")]
        Random = 2,

        /// <summary>
        /// Enum FromPresentation for value: FromPresentation
        /// </summary>
        [EnumMember(Value = "FromPresentation")]
        FromPresentation = 3,

        /// <summary>
        /// Enum Fade for value: Fade
        /// </summary>
        [EnumMember(Value = "Fade")]
        Fade = 4,

        /// <summary>
        /// Enum Distance for value: Distance
        /// </summary>
        [EnumMember(Value = "Distance")]
        Distance = 5,

        /// <summary>
        /// Enum SlideLeft for value: SlideLeft
        /// </summary>
        [EnumMember(Value = "SlideLeft")]
        SlideLeft = 6,

        /// <summary>
        /// Enum CircleCrop for value: CircleCrop
        /// </summary>
        [EnumMember(Value = "CircleCrop")]
        CircleCrop = 7,

        /// <summary>
        /// Enum Dissolve for value: Dissolve
        /// </summary>
        [EnumMember(Value = "Dissolve")]
        Dissolve = 8

    }

}
