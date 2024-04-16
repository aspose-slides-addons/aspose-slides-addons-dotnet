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
    /// ImageWatermarkOptions
    /// </summary>
    [DataContract(Name = "ImageWatermarkOptions")]
    public partial class ImageWatermarkOptions : IEquatable<ImageWatermarkOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageWatermarkOptions" /> class.
        /// </summary>
        /// <param name="angle">angle.</param>
        /// <param name="zoom">zoom.</param>
        public ImageWatermarkOptions(int? angle = default(int?), int? zoom = default(int?))
        {
            this.Angle = angle;
            this.Zoom = zoom;
        }

        /// <summary>
        /// Gets or Sets Angle
        /// </summary>
        [DataMember(Name = "angle", EmitDefaultValue = true)]
        public int? Angle { get; set; }

        /// <summary>
        /// Gets or Sets Zoom
        /// </summary>
        [DataMember(Name = "zoom", EmitDefaultValue = true)]
        public int? Zoom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImageWatermarkOptions {\n");
            sb.Append("  Angle: ").Append(Angle).Append("\n");
            sb.Append("  Zoom: ").Append(Zoom).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageWatermarkOptions);
        }

        /// <summary>
        /// Returns true if ImageWatermarkOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageWatermarkOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageWatermarkOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Angle == input.Angle ||
                    (this.Angle != null &&
                    this.Angle.Equals(input.Angle))
                ) && 
                (
                    this.Zoom == input.Zoom ||
                    (this.Zoom != null &&
                    this.Zoom.Equals(input.Zoom))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Angle != null)
                {
                    hashCode = (hashCode * 59) + this.Angle.GetHashCode();
                }
                if (this.Zoom != null)
                {
                    hashCode = (hashCode * 59) + this.Zoom.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
