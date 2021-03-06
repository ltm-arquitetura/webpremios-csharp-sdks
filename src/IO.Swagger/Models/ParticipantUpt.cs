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
    public partial class ParticipantUpt :  IEquatable<ParticipantUpt>
    {
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
        /// Tipo de pessoa
        /// </summary>
        /// <value>Tipo de pessoa</value>
        public enum PersonTypeEnum
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
        /// Status do participante
        /// </summary>
        /// <value>Status do participante</value>
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Estado civil
        /// </summary>
        /// <value>Estado civil</value>
        [DataMember(Name="maritalStatus")]
        public MaritalStatusEnum? MaritalStatus { get; set; }
        /// <summary>
        /// Tipo de pessoa
        /// </summary>
        /// <value>Tipo de pessoa</value>
        [DataMember(Name="personType")]
        public PersonTypeEnum? PersonType { get; set; }
        /// <summary>
        /// Gênero
        /// </summary>
        /// <value>Gênero</value>
        [DataMember(Name="genderType")]
        public GenderTypeEnum? GenderType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantUpt" /> class.
        /// </summary>
        /// <param name="ClientId">Identificador do Cliente (required).</param>
        /// <param name="CatalogId">Identificador do Catalogo (required).</param>
        /// <param name="ProfileId">Identificador do Perfil (required).</param>
        /// <param name="Name">Nome do participante.</param>
        /// <param name="DocumentNumber">Documento ex: CPF, CNPJ.</param>
        /// <param name="Rg">RG do participante.</param>
        /// <param name="Status">Status do participante (required).</param>
        /// <param name="Password">Senha do participante.</param>
        /// <param name="MaritalStatus">Estado civil.</param>
        /// <param name="PersonType">Tipo de pessoa (required).</param>
        /// <param name="GenderType">Gênero.</param>
        /// <param name="BirthDate">Data de nascimento.</param>
        /// <param name="Emails">E-mails.</param>
        /// <param name="Phones">Telefones.</param>
        /// <param name="Address">Address.</param>
        public ParticipantUpt(string ClientId = default(string), string CatalogId = default(string), string ProfileId = default(string), string Name = default(string), string DocumentNumber = default(string), string Rg = default(string), StatusEnum? Status = default(StatusEnum?), string Password = default(string), MaritalStatusEnum? MaritalStatus = default(MaritalStatusEnum?), PersonTypeEnum? PersonType = default(PersonTypeEnum?), GenderTypeEnum? GenderType = default(GenderTypeEnum?), DateTime? BirthDate = default(DateTime?), List<Email> Emails = default(List<Email>), List<Phone> Phones = default(List<Phone>), AddressReq Address = default(AddressReq))
        {
            // to ensure "ClientId" is required (not null)
            if (ClientId == null)
            {
                throw new InvalidDataException("ClientId is a required property for ParticipantUpt and cannot be null");
            }
            else
            {
                this.ClientId = ClientId;
            }
            // to ensure "CatalogId" is required (not null)
            if (CatalogId == null)
            {
                throw new InvalidDataException("CatalogId is a required property for ParticipantUpt and cannot be null");
            }
            else
            {
                this.CatalogId = CatalogId;
            }
            // to ensure "ProfileId" is required (not null)
            if (ProfileId == null)
            {
                throw new InvalidDataException("ProfileId is a required property for ParticipantUpt and cannot be null");
            }
            else
            {
                this.ProfileId = ProfileId;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for ParticipantUpt and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "PersonType" is required (not null)
            if (PersonType == null)
            {
                throw new InvalidDataException("PersonType is a required property for ParticipantUpt and cannot be null");
            }
            else
            {
                this.PersonType = PersonType;
            }
            this.Name = Name;
            this.DocumentNumber = DocumentNumber;
            this.Rg = Rg;
            this.Password = Password;
            this.MaritalStatus = MaritalStatus;
            this.GenderType = GenderType;
            this.BirthDate = BirthDate;
            this.Emails = Emails;
            this.Phones = Phones;
            this.Address = Address;
            
        }

        /// <summary>
        /// Identificador do Cliente
        /// </summary>
        /// <value>Identificador do Cliente</value>
        [DataMember(Name="clientId")]
        public string ClientId { get; set; }
        /// <summary>
        /// Identificador do Catalogo
        /// </summary>
        /// <value>Identificador do Catalogo</value>
        [DataMember(Name="catalogId")]
        public string CatalogId { get; set; }
        /// <summary>
        /// Identificador do Perfil
        /// </summary>
        /// <value>Identificador do Perfil</value>
        [DataMember(Name="profileId")]
        public string ProfileId { get; set; }
        /// <summary>
        /// Nome do participante
        /// </summary>
        /// <value>Nome do participante</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
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
        /// Senha do participante
        /// </summary>
        /// <value>Senha do participante</value>
        [DataMember(Name="password")]
        public string Password { get; set; }
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
            sb.Append("class ParticipantUpt {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  CatalogId: ").Append(CatalogId).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  Rg: ").Append(Rg).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  MaritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  PersonType: ").Append(PersonType).Append("\n");
            sb.Append("  GenderType: ").Append(GenderType).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
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
            return Equals((ParticipantUpt)obj);
        }

        /// <summary>
        /// Returns true if ParticipantUpt instances are equal
        /// </summary>
        /// <param name="other">Instance of ParticipantUpt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParticipantUpt other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.CatalogId == other.CatalogId ||
                    this.CatalogId != null &&
                    this.CatalogId.Equals(other.CatalogId)
                ) && 
                (
                    this.ProfileId == other.ProfileId ||
                    this.ProfileId != null &&
                    this.ProfileId.Equals(other.ProfileId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.MaritalStatus == other.MaritalStatus ||
                    this.MaritalStatus != null &&
                    this.MaritalStatus.Equals(other.MaritalStatus)
                ) && 
                (
                    this.PersonType == other.PersonType ||
                    this.PersonType != null &&
                    this.PersonType.Equals(other.PersonType)
                ) && 
                (
                    this.GenderType == other.GenderType ||
                    this.GenderType != null &&
                    this.GenderType.Equals(other.GenderType)
                ) && 
                (
                    this.BirthDate == other.BirthDate ||
                    this.BirthDate != null &&
                    this.BirthDate.Equals(other.BirthDate)
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
                    if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                    if (this.CatalogId != null)
                    hash = hash * 59 + this.CatalogId.GetHashCode();
                    if (this.ProfileId != null)
                    hash = hash * 59 + this.ProfileId.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.DocumentNumber != null)
                    hash = hash * 59 + this.DocumentNumber.GetHashCode();
                    if (this.Rg != null)
                    hash = hash * 59 + this.Rg.GetHashCode();
                    if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                    if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                    if (this.MaritalStatus != null)
                    hash = hash * 59 + this.MaritalStatus.GetHashCode();
                    if (this.PersonType != null)
                    hash = hash * 59 + this.PersonType.GetHashCode();
                    if (this.GenderType != null)
                    hash = hash * 59 + this.GenderType.GetHashCode();
                    if (this.BirthDate != null)
                    hash = hash * 59 + this.BirthDate.GetHashCode();
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

        public static bool operator ==(ParticipantUpt left, ParticipantUpt right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ParticipantUpt left, ParticipantUpt right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
