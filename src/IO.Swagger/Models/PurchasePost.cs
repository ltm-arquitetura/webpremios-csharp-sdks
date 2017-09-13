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
    public partial class PurchasePost :  IEquatable<PurchasePost>
    {
                /// <summary>
        /// Tipo do carrinho
        /// </summary>
        /// <value>Tipo do carrinho</value>
        public enum CartTypeEnum
        {
            
            /// <summary>
            /// Enum PHISICALEnum for "PHISICAL"
            /// </summary>
            [EnumMember(Value = "PHISICAL")]
            PHISICALEnum,
            
            /// <summary>
            /// Enum VIRTUALEnum for "VIRTUAL"
            /// </summary>
            [EnumMember(Value = "VIRTUAL")]
            VIRTUALEnum
        }
                /// <summary>
        /// Canal que o pedido foi realizado
        /// </summary>
        /// <value>Canal que o pedido foi realizado</value>
        public enum ChannelTypeEnum
        {
            
            /// <summary>
            /// Enum ONLINEEnum for "ONLINE"
            /// </summary>
            [EnumMember(Value = "ONLINE")]
            ONLINEEnum,
            
            /// <summary>
            /// Enum POSEnum for "POS"
            /// </summary>
            [EnumMember(Value = "POS")]
            POSEnum,
            
            /// <summary>
            /// Enum CALLCENTEREnum for "CALLCENTER"
            /// </summary>
            [EnumMember(Value = "CALLCENTER")]
            CALLCENTEREnum,
            
            /// <summary>
            /// Enum STOREAUTHORIZEEnum for "STOREAUTHORIZE"
            /// </summary>
            [EnumMember(Value = "STOREAUTHORIZE")]
            STOREAUTHORIZEEnum,
            
            /// <summary>
            /// Enum STOREONLINEEnum for "STOREONLINE"
            /// </summary>
            [EnumMember(Value = "STOREONLINE")]
            STOREONLINEEnum,
            
            /// <summary>
            /// Enum MOBILEEnum for "MOBILE"
            /// </summary>
            [EnumMember(Value = "MOBILE")]
            MOBILEEnum,
            
            /// <summary>
            /// Enum STOREOWNEnum for "STOREOWN"
            /// </summary>
            [EnumMember(Value = "STOREOWN")]
            STOREOWNEnum,
            
            /// <summary>
            /// Enum RESALEEnum for "RESALE"
            /// </summary>
            [EnumMember(Value = "RESALE")]
            RESALEEnum,
            
            /// <summary>
            /// Enum SELFSERVICEEnum for "SELFSERVICE"
            /// </summary>
            [EnumMember(Value = "SELFSERVICE")]
            SELFSERVICEEnum,
            
            /// <summary>
            /// Enum SMSINTERACTIVEEnum for "SMSINTERACTIVE"
            /// </summary>
            [EnumMember(Value = "SMSINTERACTIVE")]
            SMSINTERACTIVEEnum,
            
            /// <summary>
            /// Enum TELESALESEnum for "TELESALES"
            /// </summary>
            [EnumMember(Value = "TELESALES")]
            TELESALESEnum,
            
            /// <summary>
            /// Enum URAEnum for "URA"
            /// </summary>
            [EnumMember(Value = "URA")]
            URAEnum,
            
            /// <summary>
            /// Enum STOREBENEFITEnum for "STOREBENEFIT"
            /// </summary>
            [EnumMember(Value = "STOREBENEFIT")]
            STOREBENEFITEnum,
            
            /// <summary>
            /// Enum NETBANKINGEnum for "NETBANKING"
            /// </summary>
            [EnumMember(Value = "NETBANKING")]
            NETBANKINGEnum,
            
            /// <summary>
            /// Enum OFFLINEEnum for "OFFLINE"
            /// </summary>
            [EnumMember(Value = "OFFLINE")]
            OFFLINEEnum
        }
        /// <summary>
        /// Tipo do carrinho
        /// </summary>
        /// <value>Tipo do carrinho</value>
        [DataMember(Name="cartType")]
        public CartTypeEnum? CartType { get; set; }
        /// <summary>
        /// Canal que o pedido foi realizado
        /// </summary>
        /// <value>Canal que o pedido foi realizado</value>
        [DataMember(Name="channelType")]
        public ChannelTypeEnum? ChannelType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchasePost" /> class.
        /// </summary>
        /// <param name="CartType">Tipo do carrinho (required).</param>
        /// <param name="ChannelType">Canal que o pedido foi realizado (required).</param>
        /// <param name="CreditCardPayment">CreditCardPayment.</param>
        public PurchasePost(CartTypeEnum? CartType = default(CartTypeEnum?), ChannelTypeEnum? ChannelType = default(ChannelTypeEnum?), CreditCardPayment CreditCardPayment = default(CreditCardPayment))
        {
            // to ensure "CartType" is required (not null)
            if (CartType == null)
            {
                throw new InvalidDataException("CartType is a required property for PurchasePost and cannot be null");
            }
            else
            {
                this.CartType = CartType;
            }
            // to ensure "ChannelType" is required (not null)
            if (ChannelType == null)
            {
                throw new InvalidDataException("ChannelType is a required property for PurchasePost and cannot be null");
            }
            else
            {
                this.ChannelType = ChannelType;
            }
            this.CreditCardPayment = CreditCardPayment;
            
        }

        /// <summary>
        /// Gets or Sets CreditCardPayment
        /// </summary>
        [DataMember(Name="creditCardPayment")]
        public CreditCardPayment CreditCardPayment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchasePost {\n");
            sb.Append("  CartType: ").Append(CartType).Append("\n");
            sb.Append("  ChannelType: ").Append(ChannelType).Append("\n");
            sb.Append("  CreditCardPayment: ").Append(CreditCardPayment).Append("\n");
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
            return Equals((PurchasePost)obj);
        }

        /// <summary>
        /// Returns true if PurchasePost instances are equal
        /// </summary>
        /// <param name="other">Instance of PurchasePost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchasePost other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.CartType == other.CartType ||
                    this.CartType != null &&
                    this.CartType.Equals(other.CartType)
                ) && 
                (
                    this.ChannelType == other.ChannelType ||
                    this.ChannelType != null &&
                    this.ChannelType.Equals(other.ChannelType)
                ) && 
                (
                    this.CreditCardPayment == other.CreditCardPayment ||
                    this.CreditCardPayment != null &&
                    this.CreditCardPayment.Equals(other.CreditCardPayment)
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
                    if (this.CartType != null)
                    hash = hash * 59 + this.CartType.GetHashCode();
                    if (this.ChannelType != null)
                    hash = hash * 59 + this.ChannelType.GetHashCode();
                    if (this.CreditCardPayment != null)
                    hash = hash * 59 + this.CreditCardPayment.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(PurchasePost left, PurchasePost right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PurchasePost left, PurchasePost right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}