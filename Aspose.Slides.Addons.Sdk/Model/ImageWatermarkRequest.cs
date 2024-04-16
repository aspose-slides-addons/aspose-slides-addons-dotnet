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
    /// ImageWatermarkRequest
    /// </summary>
    [DataContract(Name = "ImageWatermark_request")]
    public partial class ImageWatermarkRequest : IEquatable<ImageWatermarkRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageWatermarkRequest" /> class.
        /// </summary>
        /// <param name="documents">documents.</param>
        /// <param name="image">image.</param>
        /// <param name="options">options.</param>
        public ImageWatermarkRequest(List<System.IO.Stream> documents = default(List<System.IO.Stream>), System.IO.Stream image = default(System.IO.Stream), ImageWatermarkOptions options = default(ImageWatermarkOptions))
        {
            this.Documents = documents;
            this.Image = image;
            this.Options = options;
        }

        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [DataMember(Name = "documents", EmitDefaultValue = false)]
        public List<System.IO.Stream> Documents { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public System.IO.Stream Image { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public ImageWatermarkOptions Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImageWatermarkRequest {\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as ImageWatermarkRequest);
        }

        /// <summary>
        /// Returns true if ImageWatermarkRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageWatermarkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageWatermarkRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Documents == input.Documents ||
                    this.Documents != null &&
                    input.Documents != null &&
                    this.Documents.SequenceEqual(input.Documents)
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.Documents != null)
                {
                    hashCode = (hashCode * 59) + this.Documents.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
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
