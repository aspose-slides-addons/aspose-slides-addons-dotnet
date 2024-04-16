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
    /// UnprotectRequest
    /// </summary>
    [DataContract(Name = "Unprotect_request")]
    public partial class UnprotectRequest : IEquatable<UnprotectRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnprotectRequest" /> class.
        /// </summary>
        /// <param name="document">document.</param>
        public UnprotectRequest(System.IO.Stream document = default(System.IO.Stream))
        {
            this.Document = document;
        }

        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name = "document", EmitDefaultValue = false)]
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnprotectRequest {\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
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
            return this.Equals(input as UnprotectRequest);
        }

        /// <summary>
        /// Returns true if UnprotectRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UnprotectRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnprotectRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
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
                if (this.Document != null)
                {
                    hashCode = (hashCode * 59) + this.Document.GetHashCode();
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
