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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// PolyLine
    /// </summary>
    [DataContract]
    public partial class PolyLine :  IEquatable<PolyLine>, IValidatableObject
    {
        public PolyLine()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolyLine" /> class.
        /// </summary>
        /// <param name="X1">.</param>
        /// <param name="X2">.</param>
        /// <param name="Y1">.</param>
        /// <param name="Y2">.</param>
        public PolyLine(string X1 = default(string), string X2 = default(string), string Y1 = default(string), string Y2 = default(string))
        {
            this.X1 = X1;
            this.X2 = X2;
            this.Y1 = Y1;
            this.Y2 = Y2;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="x1", EmitDefaultValue=false)]
        public string X1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="x2", EmitDefaultValue=false)]
        public string X2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="y1", EmitDefaultValue=false)]
        public string Y1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="y2", EmitDefaultValue=false)]
        public string Y2 { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolyLine {\n");
            sb.Append("  X1: ").Append(X1).Append("\n");
            sb.Append("  X2: ").Append(X2).Append("\n");
            sb.Append("  Y1: ").Append(Y1).Append("\n");
            sb.Append("  Y2: ").Append(Y2).Append("\n");
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
            return this.Equals(obj as PolyLine);
        }

        /// <summary>
        /// Returns true if PolyLine instances are equal
        /// </summary>
        /// <param name="other">Instance of PolyLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolyLine other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.X1 == other.X1 ||
                    this.X1 != null &&
                    this.X1.Equals(other.X1)
                ) && 
                (
                    this.X2 == other.X2 ||
                    this.X2 != null &&
                    this.X2.Equals(other.X2)
                ) && 
                (
                    this.Y1 == other.Y1 ||
                    this.Y1 != null &&
                    this.Y1.Equals(other.Y1)
                ) && 
                (
                    this.Y2 == other.Y2 ||
                    this.Y2 != null &&
                    this.Y2.Equals(other.Y2)
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
                if (this.X1 != null)
                    hash = hash * 59 + this.X1.GetHashCode();
                if (this.X2 != null)
                    hash = hash * 59 + this.X2.GetHashCode();
                if (this.Y1 != null)
                    hash = hash * 59 + this.Y1.GetHashCode();
                if (this.Y2 != null)
                    hash = hash * 59 + this.Y2.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
