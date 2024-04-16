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
    /// ReplaceTextOptions
    /// </summary>
    [DataContract(Name = "ReplaceTextOptions")]
    public partial class ReplaceTextOptions : IEquatable<ReplaceTextOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceTextOptions" /> class.
        /// </summary>
        /// <param name="oldValue">oldValue.</param>
        /// <param name="newValue">newValue.</param>
        /// <param name="ignoreCase">ignoreCase.</param>
        public ReplaceTextOptions(string oldValue = default(string), string newValue = default(string), bool ignoreCase = default(bool))
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
            this.IgnoreCase = ignoreCase;
        }

        /// <summary>
        /// Gets or Sets OldValue
        /// </summary>
        [DataMember(Name = "oldValue", EmitDefaultValue = true)]
        public string OldValue { get; set; }

        /// <summary>
        /// Gets or Sets NewValue
        /// </summary>
        [DataMember(Name = "newValue", EmitDefaultValue = true)]
        public string NewValue { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreCase
        /// </summary>
        [DataMember(Name = "ignoreCase", EmitDefaultValue = true)]
        public bool IgnoreCase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReplaceTextOptions {\n");
            sb.Append("  OldValue: ").Append(OldValue).Append("\n");
            sb.Append("  NewValue: ").Append(NewValue).Append("\n");
            sb.Append("  IgnoreCase: ").Append(IgnoreCase).Append("\n");
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
            return this.Equals(input as ReplaceTextOptions);
        }

        /// <summary>
        /// Returns true if ReplaceTextOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplaceTextOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplaceTextOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OldValue == input.OldValue ||
                    (this.OldValue != null &&
                    this.OldValue.Equals(input.OldValue))
                ) && 
                (
                    this.NewValue == input.NewValue ||
                    (this.NewValue != null &&
                    this.NewValue.Equals(input.NewValue))
                ) && 
                (
                    this.IgnoreCase == input.IgnoreCase ||
                    this.IgnoreCase.Equals(input.IgnoreCase)
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
                if (this.OldValue != null)
                {
                    hashCode = (hashCode * 59) + this.OldValue.GetHashCode();
                }
                if (this.NewValue != null)
                {
                    hashCode = (hashCode * 59) + this.NewValue.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IgnoreCase.GetHashCode();
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
