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
    /// DocumentPropertiesSetRequest
    /// </summary>
    [DataContract(Name = "DocumentPropertiesSet_request")]
    public partial class DocumentPropertiesSetRequest : IEquatable<DocumentPropertiesSetRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentPropertiesSetRequest" /> class.
        /// </summary>
        /// <param name="document">document.</param>
        /// <param name="documentProperties">documentProperties.</param>
        public DocumentPropertiesSetRequest(System.IO.Stream document = default(System.IO.Stream), DocumentProperties documentProperties = default(DocumentProperties))
        {
            this.Document = document;
            this.DocumentProperties = documentProperties;
        }

        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name = "document", EmitDefaultValue = false)]
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// Gets or Sets DocumentProperties
        /// </summary>
        [DataMember(Name = "documentProperties", EmitDefaultValue = false)]
        public DocumentProperties DocumentProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentPropertiesSetRequest {\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  DocumentProperties: ").Append(DocumentProperties).Append("\n");
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
            return this.Equals(input as DocumentPropertiesSetRequest);
        }

        /// <summary>
        /// Returns true if DocumentPropertiesSetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentPropertiesSetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentPropertiesSetRequest input)
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
                ) && 
                (
                    this.DocumentProperties == input.DocumentProperties ||
                    (this.DocumentProperties != null &&
                    this.DocumentProperties.Equals(input.DocumentProperties))
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
                if (this.DocumentProperties != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentProperties.GetHashCode();
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
