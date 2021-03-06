/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = DocuSign.eSign.Client.SwaggerDateConverter;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// DowngradePlanUpdateResponse
    /// </summary>
    [DataContract]
    public partial class DowngradePlanUpdateResponse :  IEquatable<DowngradePlanUpdateResponse>, IValidatableObject
    {
        public DowngradePlanUpdateResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DowngradePlanUpdateResponse" /> class.
        /// </summary>
        /// <param name="AccountPaymentMethod">AccountPaymentMethod.</param>
        /// <param name="DowngradeEffectiveDate">DowngradeEffectiveDate.</param>
        /// <param name="DowngradePaymentCycle">DowngradePaymentCycle.</param>
        /// <param name="DowngradePlanId">DowngradePlanId.</param>
        /// <param name="DowngradePlanName">DowngradePlanName.</param>
        /// <param name="DowngradeRequestStatus">DowngradeRequestStatus.</param>
        /// <param name="Message">Message.</param>
        public DowngradePlanUpdateResponse(string AccountPaymentMethod = default(string), string DowngradeEffectiveDate = default(string), string DowngradePaymentCycle = default(string), string DowngradePlanId = default(string), string DowngradePlanName = default(string), string DowngradeRequestStatus = default(string), string Message = default(string))
        {
            this.AccountPaymentMethod = AccountPaymentMethod;
            this.DowngradeEffectiveDate = DowngradeEffectiveDate;
            this.DowngradePaymentCycle = DowngradePaymentCycle;
            this.DowngradePlanId = DowngradePlanId;
            this.DowngradePlanName = DowngradePlanName;
            this.DowngradeRequestStatus = DowngradeRequestStatus;
            this.Message = Message;
        }
        
        /// <summary>
        /// Gets or Sets AccountPaymentMethod
        /// </summary>
        [DataMember(Name="accountPaymentMethod", EmitDefaultValue=false)]
        public string AccountPaymentMethod { get; set; }
        /// <summary>
        /// Gets or Sets DowngradeEffectiveDate
        /// </summary>
        [DataMember(Name="downgradeEffectiveDate", EmitDefaultValue=false)]
        public string DowngradeEffectiveDate { get; set; }
        /// <summary>
        /// Gets or Sets DowngradePaymentCycle
        /// </summary>
        [DataMember(Name="downgradePaymentCycle", EmitDefaultValue=false)]
        public string DowngradePaymentCycle { get; set; }
        /// <summary>
        /// Gets or Sets DowngradePlanId
        /// </summary>
        [DataMember(Name="downgradePlanId", EmitDefaultValue=false)]
        public string DowngradePlanId { get; set; }
        /// <summary>
        /// Gets or Sets DowngradePlanName
        /// </summary>
        [DataMember(Name="downgradePlanName", EmitDefaultValue=false)]
        public string DowngradePlanName { get; set; }
        /// <summary>
        /// Gets or Sets DowngradeRequestStatus
        /// </summary>
        [DataMember(Name="downgradeRequestStatus", EmitDefaultValue=false)]
        public string DowngradeRequestStatus { get; set; }
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DowngradePlanUpdateResponse {\n");
            sb.Append("  AccountPaymentMethod: ").Append(AccountPaymentMethod).Append("\n");
            sb.Append("  DowngradeEffectiveDate: ").Append(DowngradeEffectiveDate).Append("\n");
            sb.Append("  DowngradePaymentCycle: ").Append(DowngradePaymentCycle).Append("\n");
            sb.Append("  DowngradePlanId: ").Append(DowngradePlanId).Append("\n");
            sb.Append("  DowngradePlanName: ").Append(DowngradePlanName).Append("\n");
            sb.Append("  DowngradeRequestStatus: ").Append(DowngradeRequestStatus).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as DowngradePlanUpdateResponse);
        }

        /// <summary>
        /// Returns true if DowngradePlanUpdateResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DowngradePlanUpdateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DowngradePlanUpdateResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountPaymentMethod == other.AccountPaymentMethod ||
                    this.AccountPaymentMethod != null &&
                    this.AccountPaymentMethod.Equals(other.AccountPaymentMethod)
                ) && 
                (
                    this.DowngradeEffectiveDate == other.DowngradeEffectiveDate ||
                    this.DowngradeEffectiveDate != null &&
                    this.DowngradeEffectiveDate.Equals(other.DowngradeEffectiveDate)
                ) && 
                (
                    this.DowngradePaymentCycle == other.DowngradePaymentCycle ||
                    this.DowngradePaymentCycle != null &&
                    this.DowngradePaymentCycle.Equals(other.DowngradePaymentCycle)
                ) && 
                (
                    this.DowngradePlanId == other.DowngradePlanId ||
                    this.DowngradePlanId != null &&
                    this.DowngradePlanId.Equals(other.DowngradePlanId)
                ) && 
                (
                    this.DowngradePlanName == other.DowngradePlanName ||
                    this.DowngradePlanName != null &&
                    this.DowngradePlanName.Equals(other.DowngradePlanName)
                ) && 
                (
                    this.DowngradeRequestStatus == other.DowngradeRequestStatus ||
                    this.DowngradeRequestStatus != null &&
                    this.DowngradeRequestStatus.Equals(other.DowngradeRequestStatus)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AccountPaymentMethod != null)
                    hash = hash * 59 + this.AccountPaymentMethod.GetHashCode();
                if (this.DowngradeEffectiveDate != null)
                    hash = hash * 59 + this.DowngradeEffectiveDate.GetHashCode();
                if (this.DowngradePaymentCycle != null)
                    hash = hash * 59 + this.DowngradePaymentCycle.GetHashCode();
                if (this.DowngradePlanId != null)
                    hash = hash * 59 + this.DowngradePlanId.GetHashCode();
                if (this.DowngradePlanName != null)
                    hash = hash * 59 + this.DowngradePlanName.GetHashCode();
                if (this.DowngradeRequestStatus != null)
                    hash = hash * 59 + this.DowngradeRequestStatus.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
