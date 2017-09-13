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
    public partial class ProductDetailVendor :  IEquatable<ProductDetailVendor>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDetailVendor" /> class.
        /// </summary>
        /// <param name="Id">Identificador do parceiro.</param>
        /// <param name="Name">Nome do parceiro.</param>
        /// <param name="LogoType">URL do logotipo do parceiro.</param>
        /// <param name="Type">Tipo do parceiro.</param>
        public ProductDetailVendor(string Id = default(string), string Name = default(string), string LogoType = default(string), int? Type = default(int?))
        {
            this.Id = Id;
            this.Name = Name;
            this.LogoType = LogoType;
            this.Type = Type;
            
        }

        /// <summary>
        /// Identificador do parceiro
        /// </summary>
        /// <value>Identificador do parceiro</value>
        [DataMember(Name="id")]
        public string Id { get; set; }
        /// <summary>
        /// Nome do parceiro
        /// </summary>
        /// <value>Nome do parceiro</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// URL do logotipo do parceiro
        /// </summary>
        /// <value>URL do logotipo do parceiro</value>
        [DataMember(Name="logoType")]
        public string LogoType { get; set; }
        /// <summary>
        /// Tipo do parceiro
        /// </summary>
        /// <value>Tipo do parceiro</value>
        [DataMember(Name="type")]
        public int? Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductDetailVendor {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LogoType: ").Append(LogoType).Append("\n");
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
            return Equals((ProductDetailVendor)obj);
        }

        /// <summary>
        /// Returns true if ProductDetailVendor instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductDetailVendor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductDetailVendor other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.LogoType == other.LogoType ||
                    this.LogoType != null &&
                    this.LogoType.Equals(other.LogoType)
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
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.LogoType != null)
                    hash = hash * 59 + this.LogoType.GetHashCode();
                    if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ProductDetailVendor left, ProductDetailVendor right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProductDetailVendor left, ProductDetailVendor right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
