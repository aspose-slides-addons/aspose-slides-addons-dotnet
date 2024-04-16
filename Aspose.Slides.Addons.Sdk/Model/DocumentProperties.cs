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
    /// DocumentProperties
    /// </summary>
    [DataContract(Name = "DocumentProperties")]
    public partial class DocumentProperties : IEquatable<DocumentProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentProperties" /> class.
        /// </summary>
        /// <param name="appVersion">appVersion.</param>
        /// <param name="nameOfApplication">nameOfApplication.</param>
        /// <param name="company">company.</param>
        /// <param name="manager">manager.</param>
        /// <param name="presentationFormat">presentationFormat.</param>
        /// <param name="sharedDoc">sharedDoc.</param>
        /// <param name="applicationTemplate">applicationTemplate.</param>
        /// <param name="totalEditingTime">totalEditingTime.</param>
        /// <param name="title">title.</param>
        /// <param name="subject">subject.</param>
        /// <param name="author">author.</param>
        /// <param name="keywords">keywords.</param>
        /// <param name="comments">comments.</param>
        /// <param name="category">category.</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="lastSavedTime">lastSavedTime.</param>
        /// <param name="lastPrinted">lastPrinted.</param>
        /// <param name="lastSavedBy">lastSavedBy.</param>
        /// <param name="revisionNumber">revisionNumber.</param>
        /// <param name="contentStatus">contentStatus.</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="hyperlinkBase">hyperlinkBase.</param>
        /// <param name="customProperties">customProperties.</param>
        public DocumentProperties(string appVersion = default(string), string nameOfApplication = default(string), string company = default(string), string manager = default(string), string presentationFormat = default(string), bool? sharedDoc = default(bool?), string applicationTemplate = default(string), TimeSpan totalEditingTime = default(TimeSpan), string title = default(string), string subject = default(string), string author = default(string), string keywords = default(string), string comments = default(string), string category = default(string), DateTime? createdTime = default(DateTime?), DateTime? lastSavedTime = default(DateTime?), DateTime? lastPrinted = default(DateTime?), string lastSavedBy = default(string), int? revisionNumber = default(int?), string contentStatus = default(string), string contentType = default(string), string hyperlinkBase = default(string), List<CustomDocumentProperty> customProperties = default(List<CustomDocumentProperty>))
        {
            this.AppVersion = appVersion;
            this.NameOfApplication = nameOfApplication;
            this.Company = company;
            this.Manager = manager;
            this.PresentationFormat = presentationFormat;
            this.SharedDoc = sharedDoc;
            this.ApplicationTemplate = applicationTemplate;
            this.TotalEditingTime = totalEditingTime;
            this.Title = title;
            this.Subject = subject;
            this.Author = author;
            this.Keywords = keywords;
            this.Comments = comments;
            this.Category = category;
            this.CreatedTime = createdTime;
            this.LastSavedTime = lastSavedTime;
            this.LastPrinted = lastPrinted;
            this.LastSavedBy = lastSavedBy;
            this.RevisionNumber = revisionNumber;
            this.ContentStatus = contentStatus;
            this.ContentType = contentType;
            this.HyperlinkBase = hyperlinkBase;
            this.CustomProperties = customProperties;
        }

        /// <summary>
        /// Gets or Sets AppVersion
        /// </summary>
        [DataMember(Name = "appVersion", EmitDefaultValue = true)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Gets or Sets NameOfApplication
        /// </summary>
        [DataMember(Name = "nameOfApplication", EmitDefaultValue = true)]
        public string NameOfApplication { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name = "company", EmitDefaultValue = true)]
        public string Company { get; set; }

        /// <summary>
        /// Gets or Sets Manager
        /// </summary>
        [DataMember(Name = "manager", EmitDefaultValue = true)]
        public string Manager { get; set; }

        /// <summary>
        /// Gets or Sets PresentationFormat
        /// </summary>
        [DataMember(Name = "presentationFormat", EmitDefaultValue = true)]
        public string PresentationFormat { get; set; }

        /// <summary>
        /// Gets or Sets SharedDoc
        /// </summary>
        [DataMember(Name = "sharedDoc", EmitDefaultValue = true)]
        public bool? SharedDoc { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationTemplate
        /// </summary>
        [DataMember(Name = "applicationTemplate", EmitDefaultValue = true)]
        public string ApplicationTemplate { get; set; }

        /// <summary>
        /// Gets or Sets TotalEditingTime
        /// </summary>
        [DataMember(Name = "totalEditingTime", EmitDefaultValue = false)]
        public TimeSpan TotalEditingTime { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", EmitDefaultValue = true)]
        public string Author { get; set; }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name = "keywords", EmitDefaultValue = true)]
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name = "comments", EmitDefaultValue = true)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = true)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "createdTime", EmitDefaultValue = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets LastSavedTime
        /// </summary>
        [DataMember(Name = "lastSavedTime", EmitDefaultValue = true)]
        public DateTime? LastSavedTime { get; set; }

        /// <summary>
        /// Gets or Sets LastPrinted
        /// </summary>
        [DataMember(Name = "lastPrinted", EmitDefaultValue = true)]
        public DateTime? LastPrinted { get; set; }

        /// <summary>
        /// Gets or Sets LastSavedBy
        /// </summary>
        [DataMember(Name = "lastSavedBy", EmitDefaultValue = true)]
        public string LastSavedBy { get; set; }

        /// <summary>
        /// Gets or Sets RevisionNumber
        /// </summary>
        [DataMember(Name = "revisionNumber", EmitDefaultValue = true)]
        public int? RevisionNumber { get; set; }

        /// <summary>
        /// Gets or Sets ContentStatus
        /// </summary>
        [DataMember(Name = "contentStatus", EmitDefaultValue = true)]
        public string ContentStatus { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name = "contentType", EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or Sets HyperlinkBase
        /// </summary>
        [DataMember(Name = "hyperlinkBase", EmitDefaultValue = true)]
        public string HyperlinkBase { get; set; }

        /// <summary>
        /// Gets or Sets CustomProperties
        /// </summary>
        [DataMember(Name = "customProperties", EmitDefaultValue = true)]
        public List<CustomDocumentProperty> CustomProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentProperties {\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  NameOfApplication: ").Append(NameOfApplication).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  PresentationFormat: ").Append(PresentationFormat).Append("\n");
            sb.Append("  SharedDoc: ").Append(SharedDoc).Append("\n");
            sb.Append("  ApplicationTemplate: ").Append(ApplicationTemplate).Append("\n");
            sb.Append("  TotalEditingTime: ").Append(TotalEditingTime).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  LastSavedTime: ").Append(LastSavedTime).Append("\n");
            sb.Append("  LastPrinted: ").Append(LastPrinted).Append("\n");
            sb.Append("  LastSavedBy: ").Append(LastSavedBy).Append("\n");
            sb.Append("  RevisionNumber: ").Append(RevisionNumber).Append("\n");
            sb.Append("  ContentStatus: ").Append(ContentStatus).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  HyperlinkBase: ").Append(HyperlinkBase).Append("\n");
            sb.Append("  CustomProperties: ").Append(CustomProperties).Append("\n");
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
            return this.Equals(input as DocumentProperties);
        }

        /// <summary>
        /// Returns true if DocumentProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentProperties input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.NameOfApplication == input.NameOfApplication ||
                    (this.NameOfApplication != null &&
                    this.NameOfApplication.Equals(input.NameOfApplication))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Manager == input.Manager ||
                    (this.Manager != null &&
                    this.Manager.Equals(input.Manager))
                ) && 
                (
                    this.PresentationFormat == input.PresentationFormat ||
                    (this.PresentationFormat != null &&
                    this.PresentationFormat.Equals(input.PresentationFormat))
                ) && 
                (
                    this.SharedDoc == input.SharedDoc ||
                    (this.SharedDoc != null &&
                    this.SharedDoc.Equals(input.SharedDoc))
                ) && 
                (
                    this.ApplicationTemplate == input.ApplicationTemplate ||
                    (this.ApplicationTemplate != null &&
                    this.ApplicationTemplate.Equals(input.ApplicationTemplate))
                ) && 
                (
                    this.TotalEditingTime == input.TotalEditingTime ||
                    (this.TotalEditingTime != null &&
                    this.TotalEditingTime.Equals(input.TotalEditingTime))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    (this.Keywords != null &&
                    this.Keywords.Equals(input.Keywords))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.LastSavedTime == input.LastSavedTime ||
                    (this.LastSavedTime != null &&
                    this.LastSavedTime.Equals(input.LastSavedTime))
                ) && 
                (
                    this.LastPrinted == input.LastPrinted ||
                    (this.LastPrinted != null &&
                    this.LastPrinted.Equals(input.LastPrinted))
                ) && 
                (
                    this.LastSavedBy == input.LastSavedBy ||
                    (this.LastSavedBy != null &&
                    this.LastSavedBy.Equals(input.LastSavedBy))
                ) && 
                (
                    this.RevisionNumber == input.RevisionNumber ||
                    (this.RevisionNumber != null &&
                    this.RevisionNumber.Equals(input.RevisionNumber))
                ) && 
                (
                    this.ContentStatus == input.ContentStatus ||
                    (this.ContentStatus != null &&
                    this.ContentStatus.Equals(input.ContentStatus))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.HyperlinkBase == input.HyperlinkBase ||
                    (this.HyperlinkBase != null &&
                    this.HyperlinkBase.Equals(input.HyperlinkBase))
                ) && 
                (
                    this.CustomProperties == input.CustomProperties ||
                    this.CustomProperties != null &&
                    input.CustomProperties != null &&
                    this.CustomProperties.SequenceEqual(input.CustomProperties)
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
                if (this.AppVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppVersion.GetHashCode();
                }
                if (this.NameOfApplication != null)
                {
                    hashCode = (hashCode * 59) + this.NameOfApplication.GetHashCode();
                }
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                if (this.Manager != null)
                {
                    hashCode = (hashCode * 59) + this.Manager.GetHashCode();
                }
                if (this.PresentationFormat != null)
                {
                    hashCode = (hashCode * 59) + this.PresentationFormat.GetHashCode();
                }
                if (this.SharedDoc != null)
                {
                    hashCode = (hashCode * 59) + this.SharedDoc.GetHashCode();
                }
                if (this.ApplicationTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationTemplate.GetHashCode();
                }
                if (this.TotalEditingTime != null)
                {
                    hashCode = (hashCode * 59) + this.TotalEditingTime.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.Author != null)
                {
                    hashCode = (hashCode * 59) + this.Author.GetHashCode();
                }
                if (this.Keywords != null)
                {
                    hashCode = (hashCode * 59) + this.Keywords.GetHashCode();
                }
                if (this.Comments != null)
                {
                    hashCode = (hashCode * 59) + this.Comments.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.CreatedTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedTime.GetHashCode();
                }
                if (this.LastSavedTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastSavedTime.GetHashCode();
                }
                if (this.LastPrinted != null)
                {
                    hashCode = (hashCode * 59) + this.LastPrinted.GetHashCode();
                }
                if (this.LastSavedBy != null)
                {
                    hashCode = (hashCode * 59) + this.LastSavedBy.GetHashCode();
                }
                if (this.RevisionNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RevisionNumber.GetHashCode();
                }
                if (this.ContentStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ContentStatus.GetHashCode();
                }
                if (this.ContentType != null)
                {
                    hashCode = (hashCode * 59) + this.ContentType.GetHashCode();
                }
                if (this.HyperlinkBase != null)
                {
                    hashCode = (hashCode * 59) + this.HyperlinkBase.GetHashCode();
                }
                if (this.CustomProperties != null)
                {
                    hashCode = (hashCode * 59) + this.CustomProperties.GetHashCode();
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
