/*
 * Marketplace
 *
 * API Cloud Loyalty LTM - Webpremios
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Email :  IEquatable<Email>
    {
                /// <summary>
        /// Tipo
        /// </summary>
        /// <value>Tipo</value>
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum PERSONALEnum for "PERSONAL"
            /// </summary>
            [EnumMember(Value = "PERSONAL")]
            PERSONALEnum,
            
            /// <summary>
            /// Enum COMMERCIALEnum for "COMMERCIAL"
            /// </summary>
            [EnumMember(Value = "COMMERCIAL")]
            COMMERCIALEnum
        }
        /// <summary>
        /// Tipo
        /// </summary>
        /// <value>Tipo</value>
        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="_Email">E-mail.</param>
        /// <param name="Type">Tipo.</param>
        public Email(string _Email = default(string), TypeEnum? Type = default(TypeEnum?))
        {
            this._Email = _Email;
            this.Type = Type;
            
        }

        /// <summary>
        /// E-mail
        /// </summary>
        /// <value>E-mail</value>
        [DataMember(Name="email")]
        public string _Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Email {\n");
            sb.Append("  _Email: ").Append(_Email).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Email)obj);
        }

        /// <summary>
        /// Returns true if Email instances are equal
        /// </summary>
        /// <param name="other">Instance of Email to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Email other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this._Email == other._Email ||
                    this._Email != null &&
                    this._Email.Equals(other._Email)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                    if (this._Email != null)
                    hash = hash * 59 + this._Email.GetHashCode();
                    if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Email left, Email right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Email left, Email right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
