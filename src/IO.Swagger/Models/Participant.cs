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
    public partial class Participant :  IEquatable<Participant>
    {
                /// <summary>
        /// Tipo de pessoa
        /// </summary>
        /// <value>Tipo de pessoa</value>
        public enum PersontypeEnum
        {
            
            /// <summary>
            /// Enum INDIVIDUALEnum for "INDIVIDUAL"
            /// </summary>
            [EnumMember(Value = "INDIVIDUAL")]
            INDIVIDUALEnum,
            
            /// <summary>
            /// Enum COMPANYEnum for "COMPANY"
            /// </summary>
            [EnumMember(Value = "COMPANY")]
            COMPANYEnum
        }
                /// <summary>
        /// Gênero
        /// </summary>
        /// <value>Gênero</value>
        public enum GenderTypeEnum
        {
            
            /// <summary>
            /// Enum MALEEnum for "MALE"
            /// </summary>
            [EnumMember(Value = "MALE")]
            MALEEnum,
            
            /// <summary>
            /// Enum FEMALEEnum for "FEMALE"
            /// </summary>
            [EnumMember(Value = "FEMALE")]
            FEMALEEnum,
            
            /// <summary>
            /// Enum UNINFORMEDEnum for "UNINFORMED"
            /// </summary>
            [EnumMember(Value = "UNINFORMED")]
            UNINFORMEDEnum
        }
                /// <summary>
        /// Estado civil
        /// </summary>
        /// <value>Estado civil</value>
        public enum MaritalStatusEnum
        {
            
            /// <summary>
            /// Enum MARRIEDEnum for "MARRIED"
            /// </summary>
            [EnumMember(Value = "MARRIED")]
            MARRIEDEnum,
            
            /// <summary>
            /// Enum DIVORCEDEnum for "DIVORCED"
            /// </summary>
            [EnumMember(Value = "DIVORCED")]
            DIVORCEDEnum,
            
            /// <summary>
            /// Enum SINGLEEnum for "SINGLE"
            /// </summary>
            [EnumMember(Value = "SINGLE")]
            SINGLEEnum,
            
            /// <summary>
            /// Enum WIDOWEREnum for "WIDOWER"
            /// </summary>
            [EnumMember(Value = "WIDOWER")]
            WIDOWEREnum,
            
            /// <summary>
            /// Enum SEPARATEDEnum for "SEPARATED"
            /// </summary>
            [EnumMember(Value = "SEPARATED")]
            SEPARATEDEnum,
            
            /// <summary>
            /// Enum UNINFORMEDEnum for "UNINFORMED"
            /// </summary>
            [EnumMember(Value = "UNINFORMED")]
            UNINFORMEDEnum
        }
                /// <summary>
        /// Status do participante
        /// </summary>
        /// <value>Status do participante</value>
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum ACTIVEEnum for "ACTIVE"
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVEEnum,
            
            /// <summary>
            /// Enum SIGNPENDANTEnum for "SIGNPENDANT"
            /// </summary>
            [EnumMember(Value = "SIGNPENDANT")]
            SIGNPENDANTEnum,
            
            /// <summary>
            /// Enum INACTIVEEnum for "INACTIVE"
            /// </summary>
            [EnumMember(Value = "INACTIVE")]
            INACTIVEEnum,
            
            /// <summary>
            /// Enum WAITEnum for "WAIT"
            /// </summary>
            [EnumMember(Value = "WAIT")]
            WAITEnum,
            
            /// <summary>
            /// Enum PENDINGVALIDATIONEnum for "PENDINGVALIDATION"
            /// </summary>
            [EnumMember(Value = "PENDINGVALIDATION")]
            PENDINGVALIDATIONEnum,
            
            /// <summary>
            /// Enum PENDINGREGISTRATIONEnum for "PENDINGREGISTRATION"
            /// </summary>
            [EnumMember(Value = "PENDINGREGISTRATION")]
            PENDINGREGISTRATIONEnum,
            
            /// <summary>
            /// Enum PENDINGPAYMENTEnum for "PENDINGPAYMENT"
            /// </summary>
            [EnumMember(Value = "PENDINGPAYMENT")]
            PENDINGPAYMENTEnum,
            
            /// <summary>
            /// Enum CANCELLEDCARDEnum for "CANCELLEDCARD"
            /// </summary>
            [EnumMember(Value = "CANCELLEDCARD")]
            CANCELLEDCARDEnum,
            
            /// <summary>
            /// Enum STANDBYWITHOUTPRIZEEnum for "STANDBYWITHOUTPRIZE"
            /// </summary>
            [EnumMember(Value = "STANDBYWITHOUTPRIZE")]
            STANDBYWITHOUTPRIZEEnum,
            
            /// <summary>
            /// Enum PASSWORDSIGNPENDANTEnum for "PASSWORDSIGNPENDANT"
            /// </summary>
            [EnumMember(Value = "PASSWORDSIGNPENDANT")]
            PASSWORDSIGNPENDANTEnum
        }
        /// <summary>
        /// Tipo de pessoa
        /// </summary>
        /// <value>Tipo de pessoa</value>
        [DataMember(Name="persontype")]
        public PersontypeEnum? Persontype { get; set; }
        /// <summary>
        /// Gênero
        /// </summary>
        /// <value>Gênero</value>
        [DataMember(Name="genderType")]
        public GenderTypeEnum? GenderType { get; set; }
        /// <summary>
        /// Estado civil
        /// </summary>
        /// <value>Estado civil</value>
        [DataMember(Name="maritalStatus")]
        public MaritalStatusEnum? MaritalStatus { get; set; }
        /// <summary>
        /// Status do participante
        /// </summary>
        /// <value>Status do participante</value>
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Participant" /> class.
        /// </summary>
        /// <param name="Id">Identificador do participante.</param>
        /// <param name="Name">Nome do participante.</param>
        /// <param name="Username">Login do participante.</param>
        /// <param name="DocumentNumber">Documento ex: CPF, CNPJ.</param>
        /// <param name="Rg">RG do participante.</param>
        /// <param name="BirthDate">Data de nascimento.</param>
        /// <param name="Persontype">Tipo de pessoa.</param>
        /// <param name="GenderType">Gênero.</param>
        /// <param name="MaritalStatus">Estado civil.</param>
        /// <param name="Status">Status do participante.</param>
        /// <param name="Emails">E-mails.</param>
        /// <param name="Phones">Telefones.</param>
        /// <param name="Address">Address.</param>
        public Participant(string Id = default(string), string Name = default(string), string Username = default(string), string DocumentNumber = default(string), string Rg = default(string), DateTime? BirthDate = default(DateTime?), PersontypeEnum? Persontype = default(PersontypeEnum?), GenderTypeEnum? GenderType = default(GenderTypeEnum?), MaritalStatusEnum? MaritalStatus = default(MaritalStatusEnum?), StatusEnum? Status = default(StatusEnum?), List<Email> Emails = default(List<Email>), List<Phone> Phones = default(List<Phone>), AddressReq Address = default(AddressReq))
        {
            this.Id = Id;
            this.Name = Name;
            this.Username = Username;
            this.DocumentNumber = DocumentNumber;
            this.Rg = Rg;
            this.BirthDate = BirthDate;
            this.Persontype = Persontype;
            this.GenderType = GenderType;
            this.MaritalStatus = MaritalStatus;
            this.Status = Status;
            this.Emails = Emails;
            this.Phones = Phones;
            this.Address = Address;
            
        }

        /// <summary>
        /// Identificador do participante
        /// </summary>
        /// <value>Identificador do participante</value>
        [DataMember(Name="id")]
        public string Id { get; set; }
        /// <summary>
        /// Nome do participante
        /// </summary>
        /// <value>Nome do participante</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// Login do participante
        /// </summary>
        /// <value>Login do participante</value>
        [DataMember(Name="username")]
        public string Username { get; set; }
        /// <summary>
        /// Documento ex: CPF, CNPJ
        /// </summary>
        /// <value>Documento ex: CPF, CNPJ</value>
        [DataMember(Name="documentNumber")]
        public string DocumentNumber { get; set; }
        /// <summary>
        /// RG do participante
        /// </summary>
        /// <value>RG do participante</value>
        [DataMember(Name="rg")]
        public string Rg { get; set; }
        /// <summary>
        /// Data de nascimento
        /// </summary>
        /// <value>Data de nascimento</value>
        [DataMember(Name="birthDate")]
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// E-mails
        /// </summary>
        /// <value>E-mails</value>
        [DataMember(Name="emails")]
        public List<Email> Emails { get; set; }
        /// <summary>
        /// Telefones
        /// </summary>
        /// <value>Telefones</value>
        [DataMember(Name="phones")]
        public List<Phone> Phones { get; set; }
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address")]
        public AddressReq Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Participant {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  Rg: ").Append(Rg).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  Persontype: ").Append(Persontype).Append("\n");
            sb.Append("  GenderType: ").Append(GenderType).Append("\n");
            sb.Append("  MaritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Phones: ").Append(Phones).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return Equals((Participant)obj);
        }

        /// <summary>
        /// Returns true if Participant instances are equal
        /// </summary>
        /// <param name="other">Instance of Participant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Participant other)
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
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.DocumentNumber == other.DocumentNumber ||
                    this.DocumentNumber != null &&
                    this.DocumentNumber.Equals(other.DocumentNumber)
                ) && 
                (
                    this.Rg == other.Rg ||
                    this.Rg != null &&
                    this.Rg.Equals(other.Rg)
                ) && 
                (
                    this.BirthDate == other.BirthDate ||
                    this.BirthDate != null &&
                    this.BirthDate.Equals(other.BirthDate)
                ) && 
                (
                    this.Persontype == other.Persontype ||
                    this.Persontype != null &&
                    this.Persontype.Equals(other.Persontype)
                ) && 
                (
                    this.GenderType == other.GenderType ||
                    this.GenderType != null &&
                    this.GenderType.Equals(other.GenderType)
                ) && 
                (
                    this.MaritalStatus == other.MaritalStatus ||
                    this.MaritalStatus != null &&
                    this.MaritalStatus.Equals(other.MaritalStatus)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Emails == other.Emails ||
                    this.Emails != null &&
                    this.Emails.SequenceEqual(other.Emails)
                ) && 
                (
                    this.Phones == other.Phones ||
                    this.Phones != null &&
                    this.Phones.SequenceEqual(other.Phones)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
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
                    if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                    if (this.DocumentNumber != null)
                    hash = hash * 59 + this.DocumentNumber.GetHashCode();
                    if (this.Rg != null)
                    hash = hash * 59 + this.Rg.GetHashCode();
                    if (this.BirthDate != null)
                    hash = hash * 59 + this.BirthDate.GetHashCode();
                    if (this.Persontype != null)
                    hash = hash * 59 + this.Persontype.GetHashCode();
                    if (this.GenderType != null)
                    hash = hash * 59 + this.GenderType.GetHashCode();
                    if (this.MaritalStatus != null)
                    hash = hash * 59 + this.MaritalStatus.GetHashCode();
                    if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                    if (this.Emails != null)
                    hash = hash * 59 + this.Emails.GetHashCode();
                    if (this.Phones != null)
                    hash = hash * 59 + this.Phones.GetHashCode();
                    if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Participant left, Participant right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Participant left, Participant right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
