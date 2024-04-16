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
    /// ProtectionOptions
    /// </summary>
    [DataContract(Name = "ProtectionOptions")]
    public partial class ProtectionOptions : IEquatable<ProtectionOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionOptions" /> class.
        /// </summary>
        /// <param name="viewPassword">viewPassword.</param>
        /// <param name="editPassword">editPassword.</param>
        /// <param name="markAsFinal">markAsFinal.</param>
        public ProtectionOptions(string viewPassword = default(string), string editPassword = default(string), bool markAsFinal = default(bool))
        {
            this.ViewPassword = viewPassword;
            this.EditPassword = editPassword;
            this.MarkAsFinal = markAsFinal;
        }

        /// <summary>
        /// Gets or Sets ViewPassword
        /// </summary>
        [DataMember(Name = "viewPassword", EmitDefaultValue = true)]
        public string ViewPassword { get; set; }

        /// <summary>
        /// Gets or Sets EditPassword
        /// </summary>
        [DataMember(Name = "editPassword", EmitDefaultValue = true)]
        public string EditPassword { get; set; }

        /// <summary>
        /// Gets or Sets MarkAsFinal
        /// </summary>
        [DataMember(Name = "markAsFinal", EmitDefaultValue = true)]
        public bool MarkAsFinal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProtectionOptions {\n");
            sb.Append("  ViewPassword: ").Append(ViewPassword).Append("\n");
            sb.Append("  EditPassword: ").Append(EditPassword).Append("\n");
            sb.Append("  MarkAsFinal: ").Append(MarkAsFinal).Append("\n");
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
            return this.Equals(input as ProtectionOptions);
        }

        /// <summary>
        /// Returns true if ProtectionOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ViewPassword == input.ViewPassword ||
                    (this.ViewPassword != null &&
                    this.ViewPassword.Equals(input.ViewPassword))
                ) && 
                (
                    this.EditPassword == input.EditPassword ||
                    (this.EditPassword != null &&
                    this.EditPassword.Equals(input.EditPassword))
                ) && 
                (
                    this.MarkAsFinal == input.MarkAsFinal ||
                    this.MarkAsFinal.Equals(input.MarkAsFinal)
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
                if (this.ViewPassword != null)
                {
                    hashCode = (hashCode * 59) + this.ViewPassword.GetHashCode();
                }
                if (this.EditPassword != null)
                {
                    hashCode = (hashCode * 59) + this.EditPassword.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MarkAsFinal.GetHashCode();
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
