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
    public partial class VendorRate :  IEquatable<VendorRate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="VendorRate" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DeliveryDate">Data estimada de entrega.</param>
        /// <param name="Total">Valor total dos items do parceiro.</param>
        public VendorRate(string Id = default(string), DateTime? DeliveryDate = default(DateTime?), decimal? Total = default(decimal?))
        {
            this.Id = Id;
            this.DeliveryDate = DeliveryDate;
            this.Total = Total;
            
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public string Id { get; set; }
        /// <summary>
        /// Data estimada de entrega
        /// </summary>
        /// <value>Data estimada de entrega</value>
        [DataMember(Name="deliveryDate")]
        public DateTime? DeliveryDate { get; set; }
        /// <summary>
        /// Valor total dos items do parceiro
        /// </summary>
        /// <value>Valor total dos items do parceiro</value>
        [DataMember(Name="total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VendorRate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return Equals((VendorRate)obj);
        }

        /// <summary>
        /// Returns true if VendorRate instances are equal
        /// </summary>
        /// <param name="other">Instance of VendorRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorRate other)
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
                    this.DeliveryDate == other.DeliveryDate ||
                    this.DeliveryDate != null &&
                    this.DeliveryDate.Equals(other.DeliveryDate)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
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
                    if (this.DeliveryDate != null)
                    hash = hash * 59 + this.DeliveryDate.GetHashCode();
                    if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(VendorRate left, VendorRate right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(VendorRate left, VendorRate right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
