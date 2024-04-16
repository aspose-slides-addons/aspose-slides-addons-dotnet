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
    /// MergeOptions
    /// </summary>
    [DataContract(Name = "MergeOptions")]
    public partial class MergeOptions : IEquatable<MergeOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeOptions" /> class.
        /// </summary>
        /// <param name="masterFileName">masterFileName.</param>
        /// <param name="excludeMasterFile">excludeMasterFile.</param>
        public MergeOptions(string masterFileName = default(string), bool excludeMasterFile = default(bool))
        {
            this.MasterFileName = masterFileName;
            this.ExcludeMasterFile = excludeMasterFile;
        }

        /// <summary>
        /// Gets or Sets MasterFileName
        /// </summary>
        [DataMember(Name = "masterFileName", EmitDefaultValue = true)]
        public string MasterFileName { get; set; }

        /// <summary>
        /// Gets or Sets ExcludeMasterFile
        /// </summary>
        [DataMember(Name = "excludeMasterFile", EmitDefaultValue = true)]
        public bool ExcludeMasterFile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MergeOptions {\n");
            sb.Append("  MasterFileName: ").Append(MasterFileName).Append("\n");
            sb.Append("  ExcludeMasterFile: ").Append(ExcludeMasterFile).Append("\n");
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
            return this.Equals(input as MergeOptions);
        }

        /// <summary>
        /// Returns true if MergeOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of MergeOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MergeOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MasterFileName == input.MasterFileName ||
                    (this.MasterFileName != null &&
                    this.MasterFileName.Equals(input.MasterFileName))
                ) && 
                (
                    this.ExcludeMasterFile == input.ExcludeMasterFile ||
                    this.ExcludeMasterFile.Equals(input.ExcludeMasterFile)
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
                if (this.MasterFileName != null)
                {
                    hashCode = (hashCode * 59) + this.MasterFileName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExcludeMasterFile.GetHashCode();
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
