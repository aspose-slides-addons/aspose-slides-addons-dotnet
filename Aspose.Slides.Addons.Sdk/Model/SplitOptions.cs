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
    /// SplitOptions
    /// </summary>
    [DataContract(Name = "SplitOptions")]
    public partial class SplitOptions : IEquatable<SplitOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitOptions" /> class.
        /// </summary>
        /// <param name="slidesRange">slidesRange.</param>
        public SplitOptions(string slidesRange = default(string))
        {
            this.SlidesRange = slidesRange;
        }

        /// <summary>
        /// Gets or Sets SlidesRange
        /// </summary>
        [DataMember(Name = "slidesRange", EmitDefaultValue = true)]
        public string SlidesRange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SplitOptions {\n");
            sb.Append("  SlidesRange: ").Append(SlidesRange).Append("\n");
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
            return this.Equals(input as SplitOptions);
        }

        /// <summary>
        /// Returns true if SplitOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SplitOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SplitOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SlidesRange == input.SlidesRange ||
                    (this.SlidesRange != null &&
                    this.SlidesRange.Equals(input.SlidesRange))
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
                if (this.SlidesRange != null)
                {
                    hashCode = (hashCode * 59) + this.SlidesRange.GetHashCode();
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
