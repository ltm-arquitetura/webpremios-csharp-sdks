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
    public partial class Password :  IEquatable<Password>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Password" /> class.
        /// </summary>
        /// <param name="OldPassword">Senha atual.</param>
        /// <param name="NewPassword">Nova senha.</param>
        public Password(string OldPassword = default(string), string NewPassword = default(string))
        {
            this.OldPassword = OldPassword;
            this.NewPassword = NewPassword;
            
        }

        /// <summary>
        /// Senha atual
        /// </summary>
        /// <value>Senha atual</value>
        [DataMember(Name="oldPassword")]
        public string OldPassword { get; set; }
        /// <summary>
        /// Nova senha
        /// </summary>
        /// <value>Nova senha</value>
        [DataMember(Name="newPassword")]
        public string NewPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Password {\n");
            sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
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
            return Equals((Password)obj);
        }

        /// <summary>
        /// Returns true if Password instances are equal
        /// </summary>
        /// <param name="other">Instance of Password to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Password other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.OldPassword == other.OldPassword ||
                    this.OldPassword != null &&
                    this.OldPassword.Equals(other.OldPassword)
                ) && 
                (
                    this.NewPassword == other.NewPassword ||
                    this.NewPassword != null &&
                    this.NewPassword.Equals(other.NewPassword)
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
                    if (this.OldPassword != null)
                    hash = hash * 59 + this.OldPassword.GetHashCode();
                    if (this.NewPassword != null)
                    hash = hash * 59 + this.NewPassword.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Password left, Password right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Password left, Password right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}