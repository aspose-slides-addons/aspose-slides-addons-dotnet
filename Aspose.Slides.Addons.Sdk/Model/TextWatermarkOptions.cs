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
    /// TextWatermarkOptions
    /// </summary>
    [DataContract(Name = "TextWatermarkOptions")]
    public partial class TextWatermarkOptions : IEquatable<TextWatermarkOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextWatermarkOptions" /> class.
        /// </summary>
        /// <param name="text">text.</param>
        /// <param name="fontName">fontName.</param>
        /// <param name="fontSize">fontSize.</param>
        /// <param name="color">color.</param>
        /// <param name="angle">angle.</param>
        public TextWatermarkOptions(string text = default(string), string fontName = default(string), int? fontSize = default(int?), string color = default(string), int? angle = default(int?))
        {
            this.Text = text;
            this.FontName = fontName;
            this.FontSize = fontSize;
            this.Color = color;
            this.Angle = angle;
        }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets FontName
        /// </summary>
        [DataMember(Name = "fontName", EmitDefaultValue = true)]
        public string FontName { get; set; }

        /// <summary>
        /// Gets or Sets FontSize
        /// </summary>
        [DataMember(Name = "fontSize", EmitDefaultValue = true)]
        public int? FontSize { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets Angle
        /// </summary>
        [DataMember(Name = "angle", EmitDefaultValue = true)]
        public int? Angle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TextWatermarkOptions {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  FontName: ").Append(FontName).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Angle: ").Append(Angle).Append("\n");
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
            return this.Equals(input as TextWatermarkOptions);
        }

        /// <summary>
        /// Returns true if TextWatermarkOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of TextWatermarkOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextWatermarkOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.FontName == input.FontName ||
                    (this.FontName != null &&
                    this.FontName.Equals(input.FontName))
                ) && 
                (
                    this.FontSize == input.FontSize ||
                    (this.FontSize != null &&
                    this.FontSize.Equals(input.FontSize))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.Angle == input.Angle ||
                    (this.Angle != null &&
                    this.Angle.Equals(input.Angle))
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
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.FontName != null)
                {
                    hashCode = (hashCode * 59) + this.FontName.GetHashCode();
                }
                if (this.FontSize != null)
                {
                    hashCode = (hashCode * 59) + this.FontSize.GetHashCode();
                }
                if (this.Color != null)
                {
                    hashCode = (hashCode * 59) + this.Color.GetHashCode();
                }
                if (this.Angle != null)
                {
                    hashCode = (hashCode * 59) + this.Angle.GetHashCode();
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
