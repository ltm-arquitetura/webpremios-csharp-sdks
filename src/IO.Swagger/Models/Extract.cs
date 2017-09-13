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
    public partial class Extract :  IEquatable<Extract>
    {
                /// <summary>
        /// Total de débitos em pontos
        /// </summary>
        /// <value>Total de débitos em pontos</value>
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum DEBITEnum for "DEBIT"
            /// </summary>
            [EnumMember(Value = "DEBIT")]
            DEBITEnum,
            
            /// <summary>
            /// Enum CREDITEnum for "CREDIT"
            /// </summary>
            [EnumMember(Value = "CREDIT")]
            CREDITEnum
        }
        /// <summary>
        /// Total de débitos em pontos
        /// </summary>
        /// <value>Total de débitos em pontos</value>
        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Extract" /> class.
        /// </summary>
        /// <param name="AuthorizationCode">Código de autorização.</param>
        /// <param name="Date">Data/Hora da transação.</param>
        /// <param name="Description">Descrição da transação.</param>
        /// <param name="ValuePoints">Valor em pontos.</param>
        /// <param name="Type">Total de débitos em pontos.</param>
        public Extract(string AuthorizationCode = default(string), string Date = default(string), string Description = default(string), decimal? ValuePoints = default(decimal?), TypeEnum? Type = default(TypeEnum?))
        {
            this.AuthorizationCode = AuthorizationCode;
            this.Date = Date;
            this.Description = Description;
            this.ValuePoints = ValuePoints;
            this.Type = Type;
            
        }

        /// <summary>
        /// Código de autorização
        /// </summary>
        /// <value>Código de autorização</value>
        [DataMember(Name="authorizationCode")]
        public string AuthorizationCode { get; set; }
        /// <summary>
        /// Data/Hora da transação
        /// </summary>
        /// <value>Data/Hora da transação</value>
        [DataMember(Name="date")]
        public string Date { get; set; }
        /// <summary>
        /// Descrição da transação
        /// </summary>
        /// <value>Descrição da transação</value>
        [DataMember(Name="description")]
        public string Description { get; set; }
        /// <summary>
        /// Valor em pontos
        /// </summary>
        /// <value>Valor em pontos</value>
        [DataMember(Name="valuePoints")]
        public decimal? ValuePoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Extract {\n");
            sb.Append("  AuthorizationCode: ").Append(AuthorizationCode).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ValuePoints: ").Append(ValuePoints).Append("\n");
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
            return Equals((Extract)obj);
        }

        /// <summary>
        /// Returns true if Extract instances are equal
        /// </summary>
        /// <param name="other">Instance of Extract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Extract other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.AuthorizationCode == other.AuthorizationCode ||
                    this.AuthorizationCode != null &&
                    this.AuthorizationCode.Equals(other.AuthorizationCode)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.ValuePoints == other.ValuePoints ||
                    this.ValuePoints != null &&
                    this.ValuePoints.Equals(other.ValuePoints)
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
                    if (this.AuthorizationCode != null)
                    hash = hash * 59 + this.AuthorizationCode.GetHashCode();
                    if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                    if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                    if (this.ValuePoints != null)
                    hash = hash * 59 + this.ValuePoints.GetHashCode();
                    if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Extract left, Extract right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Extract left, Extract right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}