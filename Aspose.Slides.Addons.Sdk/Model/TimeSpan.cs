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
    /// TimeSpan
    /// </summary>
    [DataContract(Name = "TimeSpan")]
    public partial class TimeSpan : IEquatable<TimeSpan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSpan" /> class.
        /// </summary>
        /// <param name="ticks">ticks.</param>
        public TimeSpan(long ticks = default(long))
        {
            this.Ticks = ticks;
        }

        /// <summary>
        /// Gets or Sets Ticks
        /// </summary>
        [DataMember(Name = "ticks", EmitDefaultValue = false)]
        public long Ticks { get; set; }

        /// <summary>
        /// Gets or Sets Days
        /// </summary>
        [DataMember(Name = "days", EmitDefaultValue = false)]
        public int Days { get; private set; }

        /// <summary>
        /// Returns false as Days should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDays()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Hours
        /// </summary>
        [DataMember(Name = "hours", EmitDefaultValue = false)]
        public int Hours { get; private set; }

        /// <summary>
        /// Returns false as Hours should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHours()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Milliseconds
        /// </summary>
        [DataMember(Name = "milliseconds", EmitDefaultValue = false)]
        public int Milliseconds { get; private set; }

        /// <summary>
        /// Returns false as Milliseconds should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMilliseconds()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Minutes
        /// </summary>
        [DataMember(Name = "minutes", EmitDefaultValue = false)]
        public int Minutes { get; private set; }

        /// <summary>
        /// Returns false as Minutes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMinutes()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Seconds
        /// </summary>
        [DataMember(Name = "seconds", EmitDefaultValue = false)]
        public int Seconds { get; private set; }

        /// <summary>
        /// Returns false as Seconds should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSeconds()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TotalDays
        /// </summary>
        [DataMember(Name = "totalDays", EmitDefaultValue = false)]
        public double TotalDays { get; private set; }

        /// <summary>
        /// Returns false as TotalDays should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalDays()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TotalHours
        /// </summary>
        [DataMember(Name = "totalHours", EmitDefaultValue = false)]
        public double TotalHours { get; private set; }

        /// <summary>
        /// Returns false as TotalHours should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalHours()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TotalMilliseconds
        /// </summary>
        [DataMember(Name = "totalMilliseconds", EmitDefaultValue = false)]
        public double TotalMilliseconds { get; private set; }

        /// <summary>
        /// Returns false as TotalMilliseconds should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalMilliseconds()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TotalMinutes
        /// </summary>
        [DataMember(Name = "totalMinutes", EmitDefaultValue = false)]
        public double TotalMinutes { get; private set; }

        /// <summary>
        /// Returns false as TotalMinutes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalMinutes()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TotalSeconds
        /// </summary>
        [DataMember(Name = "totalSeconds", EmitDefaultValue = false)]
        public double TotalSeconds { get; private set; }

        /// <summary>
        /// Returns false as TotalSeconds should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalSeconds()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimeSpan {\n");
            sb.Append("  Ticks: ").Append(Ticks).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            sb.Append("  Milliseconds: ").Append(Milliseconds).Append("\n");
            sb.Append("  Minutes: ").Append(Minutes).Append("\n");
            sb.Append("  Seconds: ").Append(Seconds).Append("\n");
            sb.Append("  TotalDays: ").Append(TotalDays).Append("\n");
            sb.Append("  TotalHours: ").Append(TotalHours).Append("\n");
            sb.Append("  TotalMilliseconds: ").Append(TotalMilliseconds).Append("\n");
            sb.Append("  TotalMinutes: ").Append(TotalMinutes).Append("\n");
            sb.Append("  TotalSeconds: ").Append(TotalSeconds).Append("\n");
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
            return this.Equals(input as TimeSpan);
        }

        /// <summary>
        /// Returns true if TimeSpan instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeSpan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSpan input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ticks == input.Ticks ||
                    this.Ticks.Equals(input.Ticks)
                ) && 
                (
                    this.Days == input.Days ||
                    this.Days.Equals(input.Days)
                ) && 
                (
                    this.Hours == input.Hours ||
                    this.Hours.Equals(input.Hours)
                ) && 
                (
                    this.Milliseconds == input.Milliseconds ||
                    this.Milliseconds.Equals(input.Milliseconds)
                ) && 
                (
                    this.Minutes == input.Minutes ||
                    this.Minutes.Equals(input.Minutes)
                ) && 
                (
                    this.Seconds == input.Seconds ||
                    this.Seconds.Equals(input.Seconds)
                ) && 
                (
                    this.TotalDays == input.TotalDays ||
                    this.TotalDays.Equals(input.TotalDays)
                ) && 
                (
                    this.TotalHours == input.TotalHours ||
                    this.TotalHours.Equals(input.TotalHours)
                ) && 
                (
                    this.TotalMilliseconds == input.TotalMilliseconds ||
                    this.TotalMilliseconds.Equals(input.TotalMilliseconds)
                ) && 
                (
                    this.TotalMinutes == input.TotalMinutes ||
                    this.TotalMinutes.Equals(input.TotalMinutes)
                ) && 
                (
                    this.TotalSeconds == input.TotalSeconds ||
                    this.TotalSeconds.Equals(input.TotalSeconds)
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
                hashCode = (hashCode * 59) + this.Ticks.GetHashCode();
                hashCode = (hashCode * 59) + this.Days.GetHashCode();
                hashCode = (hashCode * 59) + this.Hours.GetHashCode();
                hashCode = (hashCode * 59) + this.Milliseconds.GetHashCode();
                hashCode = (hashCode * 59) + this.Minutes.GetHashCode();
                hashCode = (hashCode * 59) + this.Seconds.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalDays.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalHours.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalMilliseconds.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalMinutes.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalSeconds.GetHashCode();
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
