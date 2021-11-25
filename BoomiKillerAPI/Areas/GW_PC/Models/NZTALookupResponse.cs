using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class NZTALookupResponse
    {


        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2003/05/soap-envelope", IsNullable = false)]
        public partial class Envelope
        {

            private EnvelopeHeader headerField;

            private EnvelopeBody bodyField;

            /// <remarks/>
            public EnvelopeHeader Header
            {
                get
                {
                    return this.headerField;
                }
                set
                {
                    this.headerField = value;
                }
            }

            /// <remarks/>
            public EnvelopeBody Body
            {
                get
                {
                    return this.bodyField;
                }
                set
                {
                    this.bodyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public partial class EnvelopeHeader
        {

            private Security securityField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0" +
                ".xsd")]
            public Security Security
            {
                get
                {
                    return this.securityField;
                }
                set
                {
                    this.securityField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0" +
            ".xsd")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0" +
            ".xsd", IsNullable = false)]
        public partial class Security
        {

            private SecurityUserNameToken userNameTokenField;

            private CDIToken cDITokenField;

            private string cDISessionTokenField;

            private SecuritySecurityTokenReference securityTokenReferenceField;

            private ClientIdentifiers clientIdentifiersField;

            /// <remarks/>
            public SecurityUserNameToken UserNameToken
            {
                get
                {
                    return this.userNameTokenField;
                }
                set
                {
                    this.userNameTokenField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.cdi.ltsa.govt.nz/SecurityService")]
            public CDIToken CDIToken
            {
                get
                {
                    return this.cDITokenField;
                }
                set
                {
                    this.cDITokenField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.cdi.ltsa.govt.nz/SecurityService")]
            public string CDISessionToken
            {
                get
                {
                    return this.cDISessionTokenField;
                }
                set
                {
                    this.cDISessionTokenField = value;
                }
            }

            /// <remarks/>
            public SecuritySecurityTokenReference SecurityTokenReference
            {
                get
                {
                    return this.securityTokenReferenceField;
                }
                set
                {
                    this.securityTokenReferenceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.cdi.ltsa.govt.nz/SecurityService")]
            public ClientIdentifiers ClientIdentifiers
            {
                get
                {
                    return this.clientIdentifiersField;
                }
                set
                {
                    this.clientIdentifiersField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0" +
            ".xsd")]
        public partial class SecurityUserNameToken
        {

            private string userNameField;

            private string groupNameField;

            private string passwordField;

            private string locationIDField;

            private string endPointIDField;

            /// <remarks/>
            public string UserName
            {
                get
                {
                    return this.userNameField;
                }
                set
                {
                    this.userNameField = value;
                }
            }

            /// <remarks/>
            public string GroupName
            {
                get
                {
                    return this.groupNameField;
                }
                set
                {
                    this.groupNameField = value;
                }
            }

            /// <remarks/>
            public string Password
            {
                get
                {
                    return this.passwordField;
                }
                set
                {
                    this.passwordField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.cdi.ltsa.govt.nz/SecurityService.xsd")]
            public string LocationID
            {
                get
                {
                    return this.locationIDField;
                }
                set
                {
                    this.locationIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.cdi.ltsa.govt.nz/SecurityService.xsd")]
            public string EndPointID
            {
                get
                {
                    return this.endPointIDField;
                }
                set
                {
                    this.endPointIDField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.cdi.ltsa.govt.nz/SecurityService")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.cdi.ltsa.govt.nz/SecurityService", IsNullable = false)]
        public partial class CDIToken
        {

            private string tokenValueField;

            private string groupNameField;

            private string functionNameField;

            private string userNameField;

            private string idField;

            /// <remarks/>
            public string TokenValue
            {
                get
                {
                    return this.tokenValueField;
                }
                set
                {
                    this.tokenValueField = value;
                }
            }

            /// <remarks/>
            public string GroupName
            {
                get
                {
                    return this.groupNameField;
                }
                set
                {
                    this.groupNameField = value;
                }
            }

            /// <remarks/>
            public string FunctionName
            {
                get
                {
                    return this.functionNameField;
                }
                set
                {
                    this.functionNameField = value;
                }
            }

            /// <remarks/>
            public string UserName
            {
                get
                {
                    return this.userNameField;
                }
                set
                {
                    this.userNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0" +
            ".xsd")]
        public partial class SecuritySecurityTokenReference
        {

            private string idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1." +
                "0.xsd")]
            public string Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.cdi.ltsa.govt.nz/SecurityService")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.cdi.ltsa.govt.nz/SecurityService", IsNullable = false)]
        public partial class ClientIdentifiers
        {

            private string userNameField;

            private ClientIdentifiersAccountId accountIdField;

            private string iPAddressField;

            /// <remarks/>
            public string UserName
            {
                get
                {
                    return this.userNameField;
                }
                set
                {
                    this.userNameField = value;
                }
            }

            /// <remarks/>
            public ClientIdentifiersAccountId AccountId
            {
                get
                {
                    return this.accountIdField;
                }
                set
                {
                    this.accountIdField = value;
                }
            }

            /// <remarks/>
            public string IPAddress
            {
                get
                {
                    return this.iPAddressField;
                }
                set
                {
                    this.iPAddressField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.cdi.ltsa.govt.nz/SecurityService")]
        public partial class ClientIdentifiersAccountId
        {

            private string accountTypeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string AccountType
            {
                get
                {
                    return this.accountTypeField;
                }
                set
                {
                    this.accountTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public partial class EnvelopeBody
        {

            private InquireVehicleDetailsResponse inquireVehicleDetailsResponseField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.cdi.ltsa.govt.nz/Vehicle/Vehicle/")]
            public InquireVehicleDetailsResponse InquireVehicleDetailsResponse
            {
                get
                {
                    return this.inquireVehicleDetailsResponseField;
                }
                set
                {
                    this.inquireVehicleDetailsResponseField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.cdi.ltsa.govt.nz/Vehicle/Vehicle/")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.cdi.ltsa.govt.nz/Vehicle/Vehicle/", IsNullable = false)]
        public partial class InquireVehicleDetailsResponse
        {

            private InquireVehicleDetailsResult inquireVehicleDetailsResultField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/VehicleTypes")]
            public InquireVehicleDetailsResult InquireVehicleDetailsResult
            {
                get
                {
                    return this.inquireVehicleDetailsResultField;
                }
                set
                {
                    this.inquireVehicleDetailsResultField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/VehicleTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/VehicleTypes", IsNullable = false)]
        public partial class InquireVehicleDetailsResult
        {

            private ServiceHeader serviceHeaderField;

            private InquireVehicleDetailsResultResponseBody responseBodyField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiServiceTypes")]
            public ServiceHeader ServiceHeader
            {
                get
                {
                    return this.serviceHeaderField;
                }
                set
                {
                    this.serviceHeaderField = value;
                }
            }

            /// <remarks/>
            public InquireVehicleDetailsResultResponseBody ResponseBody
            {
                get
                {
                    return this.responseBodyField;
                }
                set
                {
                    this.responseBodyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiServiceTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiServiceTypes", IsNullable = false)]
        public partial class ServiceHeader
        {

            private ServiceHeaderIdentification identificationField;

            private ServiceHeaderStatus statusField;

            private ServiceHeaderNextService nextServiceField;

            /// <remarks/>
            public ServiceHeaderIdentification Identification
            {
                get
                {
                    return this.identificationField;
                }
                set
                {
                    this.identificationField = value;
                }
            }

            /// <remarks/>
            public ServiceHeaderStatus Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public ServiceHeaderNextService NextService
            {
                get
                {
                    return this.nextServiceField;
                }
                set
                {
                    this.nextServiceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiServiceTypes")]
        public partial class ServiceHeaderIdentification
        {

            private ServiceHeaderIdentificationCdiReference cdiReferenceField;

            /// <remarks/>
            public ServiceHeaderIdentificationCdiReference CdiReference
            {
                get
                {
                    return this.cdiReferenceField;
                }
                set
                {
                    this.cdiReferenceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiServiceTypes")]
        public partial class ServiceHeaderIdentificationCdiReference
        {

            private string messageIdField;

            private ServiceHeaderIdentificationCdiReferenceEnvironment environmentField;

            private ServiceHeaderIdentificationCdiReferenceFinancialSession financialSessionField;

            /// <remarks/>
            public string MessageId
            {
                get
                {
                    return this.messageIdField;
                }
                set
                {
                    this.messageIdField = value;
                }
            }

            /// <remarks/>
            public ServiceHeaderIdentificationCdiReferenceEnvironment Environment
            {
                get
                {
                    return this.environmentField;
                }
                set
                {
                    this.environmentField = value;
                }
            }

            /// <remarks/>
            public ServiceHeaderIdentificationCdiReferenceFinancialSession FinancialSession
            {
                get
                {
                    return this.financialSessionField;
                }
                set
                {
                    this.financialSessionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiServiceTypes")]
        public partial class ServiceHeaderIdentificationCdiReferenceEnvironment
        {

            private string codeField;

            private string releaseField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Code
            {
                get
                {
                    return this.codeField;
                }
                set
                {
                    this.codeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Release
            {
                get
                {
                    return this.releaseField;
                }
                set
                {
                    this.releaseField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiServiceTypes")]
        public partial class ServiceHeaderIdentificationCdiReferenceFinancialSession
        {

            private string idField;

            private string statusField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiServiceTypes")]
        public partial class ServiceHeaderStatus
        {

            private ServiceHeaderStatusMessages messagesField;

            private string codeField;

            private string textField;

            /// <remarks/>
            public ServiceHeaderStatusMessages Messages
            {
                get
                {
                    return this.messagesField;
                }
                set
                {
                    this.messagesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Code
            {
                get
                {
                    return this.codeField;
                }
                set
                {
                    this.codeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiServiceTypes")]
        public partial class ServiceHeaderStatusMessages
        {

            private ServiceHeaderStatusMessagesMessage messageField;

            /// <remarks/>
            public ServiceHeaderStatusMessagesMessage Message
            {
                get
                {
                    return this.messageField;
                }
                set
                {
                    this.messageField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiServiceTypes")]
        public partial class ServiceHeaderStatusMessagesMessage
        {

            private string typeField;

            private string codeField;

            private string originField;

            private string lineField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Code
            {
                get
                {
                    return this.codeField;
                }
                set
                {
                    this.codeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Origin
            {
                get
                {
                    return this.originField;
                }
                set
                {
                    this.originField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Line
            {
                get
                {
                    return this.lineField;
                }
                set
                {
                    this.lineField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiServiceTypes")]
        public partial class ServiceHeaderNextService
        {

            private string serviceField;

            private string methodField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Service
            {
                get
                {
                    return this.serviceField;
                }
                set
                {
                    this.serviceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Method
            {
                get
                {
                    return this.methodField;
                }
                set
                {
                    this.methodField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/VehicleTypes")]
        public partial class InquireVehicleDetailsResultResponseBody
        {

            private InquireVehicleDetailsResultResponseBodyResponseDetail responseDetailField;

            /// <remarks/>
            public InquireVehicleDetailsResultResponseBodyResponseDetail ResponseDetail
            {
                get
                {
                    return this.responseDetailField;
                }
                set
                {
                    this.responseDetailField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/VehicleTypes")]
        public partial class InquireVehicleDetailsResultResponseBodyResponseDetail
        {

            private InquireVehicleDetailsResultResponseBodyResponseDetailRequestDetail requestDetailField;

            private InquireVehicleDetailsResultResponseBodyResponseDetailVehicle vehicleField;

            private string responseTypeField;

            /// <remarks/>
            public InquireVehicleDetailsResultResponseBodyResponseDetailRequestDetail RequestDetail
            {
                get
                {
                    return this.requestDetailField;
                }
                set
                {
                    this.requestDetailField = value;
                }
            }

            /// <remarks/>
            public InquireVehicleDetailsResultResponseBodyResponseDetailVehicle Vehicle
            {
                get
                {
                    return this.vehicleField;
                }
                set
                {
                    this.vehicleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ResponseType
            {
                get
                {
                    return this.responseTypeField;
                }
                set
                {
                    this.responseTypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/VehicleTypes")]
        public partial class InquireVehicleDetailsResultResponseBodyResponseDetailRequestDetail
        {

            private Plate plateField;

            private Vehicle vehicleField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public Plate Plate
            {
                get
                {
                    return this.plateField;
                }
                set
                {
                    this.plateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public Vehicle Vehicle
            {
                get
                {
                    return this.vehicleField;
                }
                set
                {
                    this.vehicleField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class Plate
        {

            private string plateNumberField;

            private PlateStatus statusField;

            private PlatePlateType plateTypeField;

            private string effectiveDateField;

            private string plateStatusField;

            /// <remarks/>
            public string PlateNumber
            {
                get
                {
                    return this.plateNumberField;
                }
                set
                {
                    this.plateNumberField = value;
                }
            }

            /// <remarks/>
            public PlateStatus Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public PlatePlateType PlateType
            {
                get
                {
                    return this.plateTypeField;
                }
                set
                {
                    this.plateTypeField = value;
                }
            }

            /// <remarks/>
            public string EffectiveDate
            {
                get
                {
                    return this.effectiveDateField;
                }
                set
                {
                    this.effectiveDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string PlateStatus
            {
                get
                {
                    return this.plateStatusField;
                }
                set
                {
                    this.plateStatusField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class PlateStatus
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class PlatePlateType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class Vehicle
        {

            private string vehicleSystemIdField;

            private string yearOfManufactureField;

            private string makeField;

            private string modelField;

            private string subModelField;

            private VehicleBodyStyle bodyStyleField;

            private VehicleVehicleType vehicleTypeField;

            private VehicleVehicleClass vehicleClassField;

            private string vINField;

            private string chassisNumberField;

            private string basicColourField;

            private string reportedStolenField;

            private string engineNumberField;

            private string secondColourField;

            private string cCRatingField;

            private string powerField;

            private VehicleCountryOfOrigin countryOfOriginField;

            private VehiclePreviousCountryOfRegistration previousCountryOfRegistrationField;

            private VehicleAssemblyType assemblyTypeField;

            private string grossVehicleMassField;

            private string numberOfSeatsField;

            private VehicleFuelType fuelTypeField;

            private VehicleAlternateFuelType alternateFuelTypeField;

            private string reliableOdometerField;

            private string maximumRatedTowedMassForUnbrakedTrailerField;

            private string maximumRatedTowedMassForBrakedTrailerField;

            private string tareWeightField;

            private string numberOfAxlesField;

            private VehicleAxleType axleTypeField;

            private string wheelBaseField;

            private string frontAxleGroupRatingField;

            private string rearAxleGroupField;

            private string dateOfFirstNZRegistrationField;

            private VehicleCauseOfLatestRegistration causeOfLatestRegistrationField;

            private string subjectToWOFField;

            private string subjectToCOFField;

            private string subjectToRUCField;

            private string dateOfLastRegistrationField;

            private string currentVehicleOdometerUnitField;

            private string importedDamagedField;

            private string registeredOverseasField;

            private VehicleDateOfFirstRegistrationOverseas dateOfFirstRegistrationOverseasField;

            private string inspectionAgentField;

            private string numberOfOwnersField;

            private VehicleVehicleUsages vehicleUsagesField;

            private VehicleVehicleRegistrationStatus vehicleRegistrationStatusField;

            private string latestDateOfRegistrationCancellationField;

            private VehicleLatestRegistrationCancellationReason latestRegistrationCancellationReasonField;

            /// <remarks/>
            public string VehicleSystemId
            {
                get
                {
                    return this.vehicleSystemIdField;
                }
                set
                {
                    this.vehicleSystemIdField = value;
                }
            }

            /// <remarks/>
            public string YearOfManufacture
            {
                get
                {
                    return this.yearOfManufactureField;
                }
                set
                {
                    this.yearOfManufactureField = value;
                }
            }

            /// <remarks/>
            public string Make
            {
                get
                {
                    return this.makeField;
                }
                set
                {
                    this.makeField = value;
                }
            }

            /// <remarks/>
            public string Model
            {
                get
                {
                    return this.modelField;
                }
                set
                {
                    this.modelField = value;
                }
            }

            /// <remarks/>
            public string SubModel
            {
                get
                {
                    return this.subModelField;
                }
                set
                {
                    this.subModelField = value;
                }
            }

            /// <remarks/>
            public VehicleBodyStyle BodyStyle
            {
                get
                {
                    return this.bodyStyleField;
                }
                set
                {
                    this.bodyStyleField = value;
                }
            }

            /// <remarks/>
            public VehicleVehicleType VehicleType
            {
                get
                {
                    return this.vehicleTypeField;
                }
                set
                {
                    this.vehicleTypeField = value;
                }
            }

            /// <remarks/>
            public VehicleVehicleClass VehicleClass
            {
                get
                {
                    return this.vehicleClassField;
                }
                set
                {
                    this.vehicleClassField = value;
                }
            }

            /// <remarks/>
            public string VIN
            {
                get
                {
                    return this.vINField;
                }
                set
                {
                    this.vINField = value;
                }
            }

            /// <remarks/>
            public string ChassisNumber
            {
                get
                {
                    return this.chassisNumberField;
                }
                set
                {
                    this.chassisNumberField = value;
                }
            }

            /// <remarks/>
            public string BasicColour
            {
                get
                {
                    return this.basicColourField;
                }
                set
                {
                    this.basicColourField = value;
                }
            }

            /// <remarks/>
            public string ReportedStolen
            {
                get
                {
                    return this.reportedStolenField;
                }
                set
                {
                    this.reportedStolenField = value;
                }
            }

            /// <remarks/>
            public string EngineNumber
            {
                get
                {
                    return this.engineNumberField;
                }
                set
                {
                    this.engineNumberField = value;
                }
            }

            /// <remarks/>
            public string SecondColour
            {
                get
                {
                    return this.secondColourField;
                }
                set
                {
                    this.secondColourField = value;
                }
            }

            /// <remarks/>
            public string CCRating
            {
                get
                {
                    return this.cCRatingField;
                }
                set
                {
                    this.cCRatingField = value;
                }
            }

            /// <remarks/>
            public string Power
            {
                get
                {
                    return this.powerField;
                }
                set
                {
                    this.powerField = value;
                }
            }

            /// <remarks/>
            public VehicleCountryOfOrigin CountryOfOrigin
            {
                get
                {
                    return this.countryOfOriginField;
                }
                set
                {
                    this.countryOfOriginField = value;
                }
            }

            /// <remarks/>
            public VehiclePreviousCountryOfRegistration PreviousCountryOfRegistration
            {
                get
                {
                    return this.previousCountryOfRegistrationField;
                }
                set
                {
                    this.previousCountryOfRegistrationField = value;
                }
            }

            /// <remarks/>
            public VehicleAssemblyType AssemblyType
            {
                get
                {
                    return this.assemblyTypeField;
                }
                set
                {
                    this.assemblyTypeField = value;
                }
            }

            /// <remarks/>
            public string GrossVehicleMass
            {
                get
                {
                    return this.grossVehicleMassField;
                }
                set
                {
                    this.grossVehicleMassField = value;
                }
            }

            /// <remarks/>
            public string NumberOfSeats
            {
                get
                {
                    return this.numberOfSeatsField;
                }
                set
                {
                    this.numberOfSeatsField = value;
                }
            }

            /// <remarks/>
            public VehicleFuelType FuelType
            {
                get
                {
                    return this.fuelTypeField;
                }
                set
                {
                    this.fuelTypeField = value;
                }
            }

            /// <remarks/>
            public VehicleAlternateFuelType AlternateFuelType
            {
                get
                {
                    return this.alternateFuelTypeField;
                }
                set
                {
                    this.alternateFuelTypeField = value;
                }
            }

            /// <remarks/>
            public string ReliableOdometer
            {
                get
                {
                    return this.reliableOdometerField;
                }
                set
                {
                    this.reliableOdometerField = value;
                }
            }

            /// <remarks/>
            public string MaximumRatedTowedMassForUnbrakedTrailer
            {
                get
                {
                    return this.maximumRatedTowedMassForUnbrakedTrailerField;
                }
                set
                {
                    this.maximumRatedTowedMassForUnbrakedTrailerField = value;
                }
            }

            /// <remarks/>
            public string MaximumRatedTowedMassForBrakedTrailer
            {
                get
                {
                    return this.maximumRatedTowedMassForBrakedTrailerField;
                }
                set
                {
                    this.maximumRatedTowedMassForBrakedTrailerField = value;
                }
            }

            /// <remarks/>
            public string TareWeight
            {
                get
                {
                    return this.tareWeightField;
                }
                set
                {
                    this.tareWeightField = value;
                }
            }

            /// <remarks/>
            public string NumberOfAxles
            {
                get
                {
                    return this.numberOfAxlesField;
                }
                set
                {
                    this.numberOfAxlesField = value;
                }
            }

            /// <remarks/>
            public VehicleAxleType AxleType
            {
                get
                {
                    return this.axleTypeField;
                }
                set
                {
                    this.axleTypeField = value;
                }
            }

            /// <remarks/>
            public string WheelBase
            {
                get
                {
                    return this.wheelBaseField;
                }
                set
                {
                    this.wheelBaseField = value;
                }
            }

            /// <remarks/>
            public string FrontAxleGroupRating
            {
                get
                {
                    return this.frontAxleGroupRatingField;
                }
                set
                {
                    this.frontAxleGroupRatingField = value;
                }
            }

            /// <remarks/>
            public string RearAxleGroup
            {
                get
                {
                    return this.rearAxleGroupField;
                }
                set
                {
                    this.rearAxleGroupField = value;
                }
            }

            /// <remarks/>
            public string DateOfFirstNZRegistration
            {
                get
                {
                    return this.dateOfFirstNZRegistrationField;
                }
                set
                {
                    this.dateOfFirstNZRegistrationField = value;
                }
            }

            /// <remarks/>
            public VehicleCauseOfLatestRegistration CauseOfLatestRegistration
            {
                get
                {
                    return this.causeOfLatestRegistrationField;
                }
                set
                {
                    this.causeOfLatestRegistrationField = value;
                }
            }

            /// <remarks/>
            public string SubjectToWOF
            {
                get
                {
                    return this.subjectToWOFField;
                }
                set
                {
                    this.subjectToWOFField = value;
                }
            }

            /// <remarks/>
            public string SubjectToCOF
            {
                get
                {
                    return this.subjectToCOFField;
                }
                set
                {
                    this.subjectToCOFField = value;
                }
            }

            /// <remarks/>
            public string SubjectToRUC
            {
                get
                {
                    return this.subjectToRUCField;
                }
                set
                {
                    this.subjectToRUCField = value;
                }
            }

            /// <remarks/>
            public string DateOfLastRegistration
            {
                get
                {
                    return this.dateOfLastRegistrationField;
                }
                set
                {
                    this.dateOfLastRegistrationField = value;
                }
            }

            /// <remarks/>
            public string CurrentVehicleOdometerUnit
            {
                get
                {
                    return this.currentVehicleOdometerUnitField;
                }
                set
                {
                    this.currentVehicleOdometerUnitField = value;
                }
            }

            /// <remarks/>
            public string ImportedDamaged
            {
                get
                {
                    return this.importedDamagedField;
                }
                set
                {
                    this.importedDamagedField = value;
                }
            }

            /// <remarks/>
            public string RegisteredOverseas
            {
                get
                {
                    return this.registeredOverseasField;
                }
                set
                {
                    this.registeredOverseasField = value;
                }
            }

            /// <remarks/>
            public VehicleDateOfFirstRegistrationOverseas DateOfFirstRegistrationOverseas
            {
                get
                {
                    return this.dateOfFirstRegistrationOverseasField;
                }
                set
                {
                    this.dateOfFirstRegistrationOverseasField = value;
                }
            }

            /// <remarks/>
            public string InspectionAgent
            {
                get
                {
                    return this.inspectionAgentField;
                }
                set
                {
                    this.inspectionAgentField = value;
                }
            }

            /// <remarks/>
            public string NumberOfOwners
            {
                get
                {
                    return this.numberOfOwnersField;
                }
                set
                {
                    this.numberOfOwnersField = value;
                }
            }

            /// <remarks/>
            public VehicleVehicleUsages VehicleUsages
            {
                get
                {
                    return this.vehicleUsagesField;
                }
                set
                {
                    this.vehicleUsagesField = value;
                }
            }

            /// <remarks/>
            public VehicleVehicleRegistrationStatus VehicleRegistrationStatus
            {
                get
                {
                    return this.vehicleRegistrationStatusField;
                }
                set
                {
                    this.vehicleRegistrationStatusField = value;
                }
            }

            /// <remarks/>
            public string LatestDateOfRegistrationCancellation
            {
                get
                {
                    return this.latestDateOfRegistrationCancellationField;
                }
                set
                {
                    this.latestDateOfRegistrationCancellationField = value;
                }
            }

            /// <remarks/>
            public VehicleLatestRegistrationCancellationReason LatestRegistrationCancellationReason
            {
                get
                {
                    return this.latestRegistrationCancellationReasonField;
                }
                set
                {
                    this.latestRegistrationCancellationReasonField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleBodyStyle
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleVehicleType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleVehicleClass
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleCountryOfOrigin
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehiclePreviousCountryOfRegistration
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleAssemblyType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleFuelType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleAlternateFuelType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleAxleType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleCauseOfLatestRegistration
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleDateOfFirstRegistrationOverseas
        {

            private string yearField;

            private string monthField;

            private string dayField;

            /// <remarks/>
            public string Year
            {
                get
                {
                    return this.yearField;
                }
                set
                {
                    this.yearField = value;
                }
            }

            /// <remarks/>
            public string Month
            {
                get
                {
                    return this.monthField;
                }
                set
                {
                    this.monthField = value;
                }
            }

            /// <remarks/>
            public string Day
            {
                get
                {
                    return this.dayField;
                }
                set
                {
                    this.dayField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleVehicleUsages
        {

            private VehicleVehicleUsagesVehicleUsage vehicleUsageField;

            /// <remarks/>
            public VehicleVehicleUsagesVehicleUsage VehicleUsage
            {
                get
                {
                    return this.vehicleUsageField;
                }
                set
                {
                    this.vehicleUsageField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleVehicleUsagesVehicleUsage
        {

            private VehicleVehicleUsagesVehicleUsageVehicleUsageCode vehicleUsageCodeField;

            private string effectiveDateField;

            /// <remarks/>
            public VehicleVehicleUsagesVehicleUsageVehicleUsageCode VehicleUsageCode
            {
                get
                {
                    return this.vehicleUsageCodeField;
                }
                set
                {
                    this.vehicleUsageCodeField = value;
                }
            }

            /// <remarks/>
            public string EffectiveDate
            {
                get
                {
                    return this.effectiveDateField;
                }
                set
                {
                    this.effectiveDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleVehicleUsagesVehicleUsageVehicleUsageCode
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleVehicleRegistrationStatus
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleLatestRegistrationCancellationReason
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/VehicleTypes")]
        public partial class InquireVehicleDetailsResultResponseBodyResponseDetailVehicle
        {

            private string vehicleSystemIdField;

            private string yearOfManufactureField;

            private string makeField;

            private string modelField;

            private string subModelField;

            private BodyStyle bodyStyleField;

            private VehicleType vehicleTypeField;

            private VehicleClass vehicleClassField;

            private string vINField;

            private string chassisNumberField;

            private string basicColourField;

            private string reportedStolenField;

            private string engineNumberField;

            private string secondColourField;

            private string cCRatingField;

            private string powerField;

            private CountryOfOrigin countryOfOriginField;

            private PreviousCountryOfRegistration previousCountryOfRegistrationField;

            private AssemblyType assemblyTypeField;

            private string grossVehicleMassField;

            private string numberOfSeatsField;

            private FuelType fuelTypeField;

            private AlternateFuelType alternateFuelTypeField;

            private string reliableOdometerField;

            private string maximumRatedTowedMassForUnbrakedTrailerField;

            private string maximumRatedTowedMassForBrakedTrailerField;

            private string tareWeightField;

            private string numberOfAxlesField;

            private AxleType axleTypeField;

            private string wheelBaseField;

            private string frontAxleGroupRatingField;

            private string rearAxleGroupField;

            private string dateOfFirstNZRegistrationField;

            private CauseOfLatestRegistration causeOfLatestRegistrationField;

            private string subjectToWOFField;

            private string subjectToCOFField;

            private string subjectToRUCField;

            private string dateOfLastRegistrationField;

            private string currentVehicleOdometerUnitField;

            private string importedDamagedField;

            private string registeredOverseasField;

            private DateOfFirstRegistrationOverseas dateOfFirstRegistrationOverseasField;

            private string inspectionAgentField;

            private string numberOfOwnersField;

            private VehicleUsages vehicleUsagesField;

            private VehicleRegistrationStatus vehicleRegistrationStatusField;

            private string latestDateOfRegistrationCancellationField;

            private LatestRegistrationCancellationReason latestRegistrationCancellationReasonField;

            private Plates platesField;

            private Inspections inspectionsField;

            private Registrations registrationsField;

            private RucLicences rucLicencesField;

            private MvrLicences mvrLicencesField;

            private OdometerReadings odometerReadingsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string VehicleSystemId
            {
                get
                {
                    return this.vehicleSystemIdField;
                }
                set
                {
                    this.vehicleSystemIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string YearOfManufacture
            {
                get
                {
                    return this.yearOfManufactureField;
                }
                set
                {
                    this.yearOfManufactureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string Make
            {
                get
                {
                    return this.makeField;
                }
                set
                {
                    this.makeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string Model
            {
                get
                {
                    return this.modelField;
                }
                set
                {
                    this.modelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string SubModel
            {
                get
                {
                    return this.subModelField;
                }
                set
                {
                    this.subModelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public BodyStyle BodyStyle
            {
                get
                {
                    return this.bodyStyleField;
                }
                set
                {
                    this.bodyStyleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public VehicleType VehicleType
            {
                get
                {
                    return this.vehicleTypeField;
                }
                set
                {
                    this.vehicleTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public VehicleClass VehicleClass
            {
                get
                {
                    return this.vehicleClassField;
                }
                set
                {
                    this.vehicleClassField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string VIN
            {
                get
                {
                    return this.vINField;
                }
                set
                {
                    this.vINField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string ChassisNumber
            {
                get
                {
                    return this.chassisNumberField;
                }
                set
                {
                    this.chassisNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string BasicColour
            {
                get
                {
                    return this.basicColourField;
                }
                set
                {
                    this.basicColourField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string ReportedStolen
            {
                get
                {
                    return this.reportedStolenField;
                }
                set
                {
                    this.reportedStolenField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string EngineNumber
            {
                get
                {
                    return this.engineNumberField;
                }
                set
                {
                    this.engineNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string SecondColour
            {
                get
                {
                    return this.secondColourField;
                }
                set
                {
                    this.secondColourField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string CCRating
            {
                get
                {
                    return this.cCRatingField;
                }
                set
                {
                    this.cCRatingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string Power
            {
                get
                {
                    return this.powerField;
                }
                set
                {
                    this.powerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public CountryOfOrigin CountryOfOrigin
            {
                get
                {
                    return this.countryOfOriginField;
                }
                set
                {
                    this.countryOfOriginField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public PreviousCountryOfRegistration PreviousCountryOfRegistration
            {
                get
                {
                    return this.previousCountryOfRegistrationField;
                }
                set
                {
                    this.previousCountryOfRegistrationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public AssemblyType AssemblyType
            {
                get
                {
                    return this.assemblyTypeField;
                }
                set
                {
                    this.assemblyTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string GrossVehicleMass
            {
                get
                {
                    return this.grossVehicleMassField;
                }
                set
                {
                    this.grossVehicleMassField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string NumberOfSeats
            {
                get
                {
                    return this.numberOfSeatsField;
                }
                set
                {
                    this.numberOfSeatsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public FuelType FuelType
            {
                get
                {
                    return this.fuelTypeField;
                }
                set
                {
                    this.fuelTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public AlternateFuelType AlternateFuelType
            {
                get
                {
                    return this.alternateFuelTypeField;
                }
                set
                {
                    this.alternateFuelTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string ReliableOdometer
            {
                get
                {
                    return this.reliableOdometerField;
                }
                set
                {
                    this.reliableOdometerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string MaximumRatedTowedMassForUnbrakedTrailer
            {
                get
                {
                    return this.maximumRatedTowedMassForUnbrakedTrailerField;
                }
                set
                {
                    this.maximumRatedTowedMassForUnbrakedTrailerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string MaximumRatedTowedMassForBrakedTrailer
            {
                get
                {
                    return this.maximumRatedTowedMassForBrakedTrailerField;
                }
                set
                {
                    this.maximumRatedTowedMassForBrakedTrailerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string TareWeight
            {
                get
                {
                    return this.tareWeightField;
                }
                set
                {
                    this.tareWeightField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string NumberOfAxles
            {
                get
                {
                    return this.numberOfAxlesField;
                }
                set
                {
                    this.numberOfAxlesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public AxleType AxleType
            {
                get
                {
                    return this.axleTypeField;
                }
                set
                {
                    this.axleTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string WheelBase
            {
                get
                {
                    return this.wheelBaseField;
                }
                set
                {
                    this.wheelBaseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string FrontAxleGroupRating
            {
                get
                {
                    return this.frontAxleGroupRatingField;
                }
                set
                {
                    this.frontAxleGroupRatingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string RearAxleGroup
            {
                get
                {
                    return this.rearAxleGroupField;
                }
                set
                {
                    this.rearAxleGroupField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string DateOfFirstNZRegistration
            {
                get
                {
                    return this.dateOfFirstNZRegistrationField;
                }
                set
                {
                    this.dateOfFirstNZRegistrationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public CauseOfLatestRegistration CauseOfLatestRegistration
            {
                get
                {
                    return this.causeOfLatestRegistrationField;
                }
                set
                {
                    this.causeOfLatestRegistrationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string SubjectToWOF
            {
                get
                {
                    return this.subjectToWOFField;
                }
                set
                {
                    this.subjectToWOFField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string SubjectToCOF
            {
                get
                {
                    return this.subjectToCOFField;
                }
                set
                {
                    this.subjectToCOFField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string SubjectToRUC
            {
                get
                {
                    return this.subjectToRUCField;
                }
                set
                {
                    this.subjectToRUCField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string DateOfLastRegistration
            {
                get
                {
                    return this.dateOfLastRegistrationField;
                }
                set
                {
                    this.dateOfLastRegistrationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string CurrentVehicleOdometerUnit
            {
                get
                {
                    return this.currentVehicleOdometerUnitField;
                }
                set
                {
                    this.currentVehicleOdometerUnitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string ImportedDamaged
            {
                get
                {
                    return this.importedDamagedField;
                }
                set
                {
                    this.importedDamagedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string RegisteredOverseas
            {
                get
                {
                    return this.registeredOverseasField;
                }
                set
                {
                    this.registeredOverseasField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public DateOfFirstRegistrationOverseas DateOfFirstRegistrationOverseas
            {
                get
                {
                    return this.dateOfFirstRegistrationOverseasField;
                }
                set
                {
                    this.dateOfFirstRegistrationOverseasField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string InspectionAgent
            {
                get
                {
                    return this.inspectionAgentField;
                }
                set
                {
                    this.inspectionAgentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string NumberOfOwners
            {
                get
                {
                    return this.numberOfOwnersField;
                }
                set
                {
                    this.numberOfOwnersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public VehicleUsages VehicleUsages
            {
                get
                {
                    return this.vehicleUsagesField;
                }
                set
                {
                    this.vehicleUsagesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public VehicleRegistrationStatus VehicleRegistrationStatus
            {
                get
                {
                    return this.vehicleRegistrationStatusField;
                }
                set
                {
                    this.vehicleRegistrationStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public string LatestDateOfRegistrationCancellation
            {
                get
                {
                    return this.latestDateOfRegistrationCancellationField;
                }
                set
                {
                    this.latestDateOfRegistrationCancellationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public LatestRegistrationCancellationReason LatestRegistrationCancellationReason
            {
                get
                {
                    return this.latestRegistrationCancellationReasonField;
                }
                set
                {
                    this.latestRegistrationCancellationReasonField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public Plates Plates
            {
                get
                {
                    return this.platesField;
                }
                set
                {
                    this.platesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public Inspections Inspections
            {
                get
                {
                    return this.inspectionsField;
                }
                set
                {
                    this.inspectionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public Registrations Registrations
            {
                get
                {
                    return this.registrationsField;
                }
                set
                {
                    this.registrationsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public RucLicences RucLicences
            {
                get
                {
                    return this.rucLicencesField;
                }
                set
                {
                    this.rucLicencesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public MvrLicences MvrLicences
            {
                get
                {
                    return this.mvrLicencesField;
                }
                set
                {
                    this.mvrLicencesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes")]
            public OdometerReadings OdometerReadings
            {
                get
                {
                    return this.odometerReadingsField;
                }
                set
                {
                    this.odometerReadingsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class BodyStyle
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class VehicleType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class VehicleClass
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class CountryOfOrigin
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class PreviousCountryOfRegistration
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class AssemblyType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class FuelType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class AlternateFuelType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class AxleType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class CauseOfLatestRegistration
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class DateOfFirstRegistrationOverseas
        {

            private string yearField;

            private string monthField;

            private string dayField;

            /// <remarks/>
            public string Year
            {
                get
                {
                    return this.yearField;
                }
                set
                {
                    this.yearField = value;
                }
            }

            /// <remarks/>
            public string Month
            {
                get
                {
                    return this.monthField;
                }
                set
                {
                    this.monthField = value;
                }
            }

            /// <remarks/>
            public string Day
            {
                get
                {
                    return this.dayField;
                }
                set
                {
                    this.dayField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class VehicleUsages
        {

            private VehicleUsagesVehicleUsage vehicleUsageField;

            /// <remarks/>
            public VehicleUsagesVehicleUsage VehicleUsage
            {
                get
                {
                    return this.vehicleUsageField;
                }
                set
                {
                    this.vehicleUsageField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleUsagesVehicleUsage
        {

            private VehicleUsagesVehicleUsageVehicleUsageCode vehicleUsageCodeField;

            private string effectiveDateField;

            /// <remarks/>
            public VehicleUsagesVehicleUsageVehicleUsageCode VehicleUsageCode
            {
                get
                {
                    return this.vehicleUsageCodeField;
                }
                set
                {
                    this.vehicleUsageCodeField = value;
                }
            }

            /// <remarks/>
            public string EffectiveDate
            {
                get
                {
                    return this.effectiveDateField;
                }
                set
                {
                    this.effectiveDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class VehicleUsagesVehicleUsageVehicleUsageCode
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class VehicleRegistrationStatus
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class LatestRegistrationCancellationReason
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class Plates
        {

            private PlatesPlate plateField;

            /// <remarks/>
            public PlatesPlate Plate
            {
                get
                {
                    return this.plateField;
                }
                set
                {
                    this.plateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class PlatesPlate
        {

            private string plateNumberField;

            private PlatesPlateStatus statusField;

            private PlatesPlatePlateType plateTypeField;

            private string effectiveDateField;

            private string plateStatusField;

            /// <remarks/>
            public string PlateNumber
            {
                get
                {
                    return this.plateNumberField;
                }
                set
                {
                    this.plateNumberField = value;
                }
            }

            /// <remarks/>
            public PlatesPlateStatus Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public PlatesPlatePlateType PlateType
            {
                get
                {
                    return this.plateTypeField;
                }
                set
                {
                    this.plateTypeField = value;
                }
            }

            /// <remarks/>
            public string EffectiveDate
            {
                get
                {
                    return this.effectiveDateField;
                }
                set
                {
                    this.effectiveDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string PlateStatus
            {
                get
                {
                    return this.plateStatusField;
                }
                set
                {
                    this.plateStatusField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class PlatesPlateStatus
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class PlatesPlatePlateType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class Inspections
        {

            private InspectionsInspection inspectionField;

            /// <remarks/>
            public InspectionsInspection Inspection
            {
                get
                {
                    return this.inspectionField;
                }
                set
                {
                    this.inspectionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class InspectionsInspection
        {

            private string typeField;

            private string dateField;

            private InspectionsInspectionResult resultField;

            private string expiryDateField;

            private string bTNField;

            private string latestField;

            /// <remarks/>
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            public string Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }

            /// <remarks/>
            public InspectionsInspectionResult Result
            {
                get
                {
                    return this.resultField;
                }
                set
                {
                    this.resultField = value;
                }
            }

            /// <remarks/>
            public string ExpiryDate
            {
                get
                {
                    return this.expiryDateField;
                }
                set
                {
                    this.expiryDateField = value;
                }
            }

            /// <remarks/>
            public string BTN
            {
                get
                {
                    return this.bTNField;
                }
                set
                {
                    this.bTNField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Latest
            {
                get
                {
                    return this.latestField;
                }
                set
                {
                    this.latestField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class InspectionsInspectionResult
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class Registrations
        {

            private RegistrationsRegistration registrationField;

            /// <remarks/>
            public RegistrationsRegistration Registration
            {
                get
                {
                    return this.registrationField;
                }
                set
                {
                    this.registrationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class RegistrationsRegistration
        {

            private string registrationNumberField;

            private string registrationDateField;

            private RegistrationsRegistrationRegistrationStatus registrationStatusField;

            private RegistrationsRegistrationOdometerReading odometerReadingField;

            private RegistrationsRegistrationParties partiesField;

            /// <remarks/>
            public string RegistrationNumber
            {
                get
                {
                    return this.registrationNumberField;
                }
                set
                {
                    this.registrationNumberField = value;
                }
            }

            /// <remarks/>
            public string RegistrationDate
            {
                get
                {
                    return this.registrationDateField;
                }
                set
                {
                    this.registrationDateField = value;
                }
            }

            /// <remarks/>
            public RegistrationsRegistrationRegistrationStatus RegistrationStatus
            {
                get
                {
                    return this.registrationStatusField;
                }
                set
                {
                    this.registrationStatusField = value;
                }
            }

            /// <remarks/>
            public RegistrationsRegistrationOdometerReading OdometerReading
            {
                get
                {
                    return this.odometerReadingField;
                }
                set
                {
                    this.odometerReadingField = value;
                }
            }

            /// <remarks/>
            public RegistrationsRegistrationParties Parties
            {
                get
                {
                    return this.partiesField;
                }
                set
                {
                    this.partiesField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class RegistrationsRegistrationRegistrationStatus
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class RegistrationsRegistrationOdometerReading
        {

            private string readingField;

            private string readingDateField;

            private RegistrationsRegistrationOdometerReadingUnit unitField;

            private RegistrationsRegistrationOdometerReadingSource sourceField;

            /// <remarks/>
            public string Reading
            {
                get
                {
                    return this.readingField;
                }
                set
                {
                    this.readingField = value;
                }
            }

            /// <remarks/>
            public string ReadingDate
            {
                get
                {
                    return this.readingDateField;
                }
                set
                {
                    this.readingDateField = value;
                }
            }

            /// <remarks/>
            public RegistrationsRegistrationOdometerReadingUnit Unit
            {
                get
                {
                    return this.unitField;
                }
                set
                {
                    this.unitField = value;
                }
            }

            /// <remarks/>
            public RegistrationsRegistrationOdometerReadingSource Source
            {
                get
                {
                    return this.sourceField;
                }
                set
                {
                    this.sourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class RegistrationsRegistrationOdometerReadingUnit
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class RegistrationsRegistrationOdometerReadingSource
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class RegistrationsRegistrationParties
        {

            private RegistrationsRegistrationPartiesParty partyField;

            /// <remarks/>
            public RegistrationsRegistrationPartiesParty Party
            {
                get
                {
                    return this.partyField;
                }
                set
                {
                    this.partyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class RegistrationsRegistrationPartiesParty
        {

            private FreeTextLines freeTextLinesField;

            private PartyName partyNameField;

            private Addresses addressesField;

            private Accounts accountsField;

            private ContactNumbers contactNumbersField;

            private Documents documentsField;

            private ElectronicAddressIdentifiers electronicAddressIdentifiersField;

            private Events eventsField;

            private Identifiers identifiersField;

            private Memberships membershipsField;

            private Relationships relationshipsField;

            private Revenues revenuesField;

            private Stocks stocksField;

            private Vehicles vehiclesField;

            private OrganisationInfo organisationInfoField;

            private PersonInfo personInfoField;

            private BirthInfo birthInfoField;

            private CountriesOfResidence countriesOfResidenceField;

            private Favourites favouritesField;

            private Habits habitsField;

            private Hobbies hobbiesField;

            private Languages languagesField;

            private Nationalities nationalitiesField;

            private Occupations occupationsField;

            private PhysicalInfo physicalInfoField;

            private Preferences preferencesField;

            private Qualifications qualificationsField;

            private Visas visasField;

            private string goneNoAddressField;

            private string confidentialFlagField;

            private string partyTypeField;

            private string partyIDField;

            private string partyIDTypeField;

            private string idField;

            private string usageField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string partyKeyField;

            private string partyKeyRefField;

            private string typeField;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public FreeTextLines FreeTextLines
            {
                get
                {
                    return this.freeTextLinesField;
                }
                set
                {
                    this.freeTextLinesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public PartyName PartyName
            {
                get
                {
                    return this.partyNameField;
                }
                set
                {
                    this.partyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Addresses Addresses
            {
                get
                {
                    return this.addressesField;
                }
                set
                {
                    this.addressesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Accounts Accounts
            {
                get
                {
                    return this.accountsField;
                }
                set
                {
                    this.accountsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public ContactNumbers ContactNumbers
            {
                get
                {
                    return this.contactNumbersField;
                }
                set
                {
                    this.contactNumbersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Documents Documents
            {
                get
                {
                    return this.documentsField;
                }
                set
                {
                    this.documentsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public ElectronicAddressIdentifiers ElectronicAddressIdentifiers
            {
                get
                {
                    return this.electronicAddressIdentifiersField;
                }
                set
                {
                    this.electronicAddressIdentifiersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Events Events
            {
                get
                {
                    return this.eventsField;
                }
                set
                {
                    this.eventsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Identifiers Identifiers
            {
                get
                {
                    return this.identifiersField;
                }
                set
                {
                    this.identifiersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Memberships Memberships
            {
                get
                {
                    return this.membershipsField;
                }
                set
                {
                    this.membershipsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Relationships Relationships
            {
                get
                {
                    return this.relationshipsField;
                }
                set
                {
                    this.relationshipsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Revenues Revenues
            {
                get
                {
                    return this.revenuesField;
                }
                set
                {
                    this.revenuesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Stocks Stocks
            {
                get
                {
                    return this.stocksField;
                }
                set
                {
                    this.stocksField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Vehicles Vehicles
            {
                get
                {
                    return this.vehiclesField;
                }
                set
                {
                    this.vehiclesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public OrganisationInfo OrganisationInfo
            {
                get
                {
                    return this.organisationInfoField;
                }
                set
                {
                    this.organisationInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public PersonInfo PersonInfo
            {
                get
                {
                    return this.personInfoField;
                }
                set
                {
                    this.personInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public BirthInfo BirthInfo
            {
                get
                {
                    return this.birthInfoField;
                }
                set
                {
                    this.birthInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public CountriesOfResidence CountriesOfResidence
            {
                get
                {
                    return this.countriesOfResidenceField;
                }
                set
                {
                    this.countriesOfResidenceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Favourites Favourites
            {
                get
                {
                    return this.favouritesField;
                }
                set
                {
                    this.favouritesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Habits Habits
            {
                get
                {
                    return this.habitsField;
                }
                set
                {
                    this.habitsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Hobbies Hobbies
            {
                get
                {
                    return this.hobbiesField;
                }
                set
                {
                    this.hobbiesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Languages Languages
            {
                get
                {
                    return this.languagesField;
                }
                set
                {
                    this.languagesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Nationalities Nationalities
            {
                get
                {
                    return this.nationalitiesField;
                }
                set
                {
                    this.nationalitiesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Occupations Occupations
            {
                get
                {
                    return this.occupationsField;
                }
                set
                {
                    this.occupationsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public PhysicalInfo PhysicalInfo
            {
                get
                {
                    return this.physicalInfoField;
                }
                set
                {
                    this.physicalInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Preferences Preferences
            {
                get
                {
                    return this.preferencesField;
                }
                set
                {
                    this.preferencesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Qualifications Qualifications
            {
                get
                {
                    return this.qualificationsField;
                }
                set
                {
                    this.qualificationsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public Visas Visas
            {
                get
                {
                    return this.visasField;
                }
                set
                {
                    this.visasField = value;
                }
            }

            /// <remarks/>
            public string GoneNoAddress
            {
                get
                {
                    return this.goneNoAddressField;
                }
                set
                {
                    this.goneNoAddressField = value;
                }
            }

            /// <remarks/>
            public string ConfidentialFlag
            {
                get
                {
                    return this.confidentialFlagField;
                }
                set
                {
                    this.confidentialFlagField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public string PartyType
            {
                get
                {
                    return this.partyTypeField;
                }
                set
                {
                    this.partyTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public string PartyID
            {
                get
                {
                    return this.partyIDField;
                }
                set
                {
                    this.partyIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public string PartyIDType
            {
                get
                {
                    return this.partyIDTypeField;
                }
                set
                {
                    this.partyIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public string PartyKey
            {
                get
                {
                    return this.partyKeyField;
                }
                set
                {
                    this.partyKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
            public string PartyKeyRef
            {
                get
                {
                    return this.partyKeyRefField;
                }
                set
                {
                    this.partyKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class FreeTextLines
        {

            private FreeTextLinesFreeTextLine freeTextLineField;

            /// <remarks/>
            public FreeTextLinesFreeTextLine FreeTextLine
            {
                get
                {
                    return this.freeTextLineField;
                }
                set
                {
                    this.freeTextLineField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class FreeTextLinesFreeTextLine
        {

            private string typeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class PartyName
        {

            private NameLine nameLineField;

            private PersonName personNameField;

            private OrganisationName organisationNameField;

            private string partyNameIDField;

            private string partyNameIDTypeField;

            private string idField;

            private string usageField;

            private string statusField;

            private string jointNameConnectorField;

            private string dateValidFromField;

            private string dateValidToField;

            private string nameKeyField;

            private string nameKeyRefField;

            private string typeField;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public NameLine NameLine
            {
                get
                {
                    return this.nameLineField;
                }
                set
                {
                    this.nameLineField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public PersonName PersonName
            {
                get
                {
                    return this.personNameField;
                }
                set
                {
                    this.personNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public OrganisationName OrganisationName
            {
                get
                {
                    return this.organisationNameField;
                }
                set
                {
                    this.organisationNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string PartyNameID
            {
                get
                {
                    return this.partyNameIDField;
                }
                set
                {
                    this.partyNameIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string PartyNameIDType
            {
                get
                {
                    return this.partyNameIDTypeField;
                }
                set
                {
                    this.partyNameIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string JointNameConnector
            {
                get
                {
                    return this.jointNameConnectorField;
                }
                set
                {
                    this.jointNameConnectorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKey
            {
                get
                {
                    return this.nameKeyField;
                }
                set
                {
                    this.nameKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKeyRef
            {
                get
                {
                    return this.nameKeyRefField;
                }
                set
                {
                    this.nameKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3", IsNullable = false)]
        public partial class NameLine
        {

            private string typeField;

            private string abbreviationField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3", IsNullable = false)]
        public partial class PersonName
        {

            private PersonNameNameElement nameElementField;

            private string typeField;

            private string personIDField;

            private string personIDTypeField;

            private string idField;

            private string usageField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string nameKeyField;

            private string nameKeyRefField;

            private string typeField1;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            public PersonNameNameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string PersonID
            {
                get
                {
                    return this.personIDField;
                }
                set
                {
                    this.personIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string PersonIDType
            {
                get
                {
                    return this.personIDTypeField;
                }
                set
                {
                    this.personIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameKey
            {
                get
                {
                    return this.nameKeyField;
                }
                set
                {
                    this.nameKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameKeyRef
            {
                get
                {
                    return this.nameKeyRefField;
                }
                set
                {
                    this.nameKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField1;
                }
                set
                {
                    this.typeField1 = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
        public partial class PersonNameNameElement
        {

            private string elementTypeField;

            private string abbreviationField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string ElementType
            {
                get
                {
                    return this.elementTypeField;
                }
                set
                {
                    this.elementTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3", IsNullable = false)]
        public partial class OrganisationName
        {

            private OrganisationNameNameElement nameElementField;

            private OrganisationNameSubDivisionName subDivisionNameField;

            private string typeField;

            private string organisationIDField;

            private string organisationIDTypeField;

            private string idField;

            private string usageField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string nameKeyField;

            private string nameKeyRefField;

            private string typeField1;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            public OrganisationNameNameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            public OrganisationNameSubDivisionName SubDivisionName
            {
                get
                {
                    return this.subDivisionNameField;
                }
                set
                {
                    this.subDivisionNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string OrganisationID
            {
                get
                {
                    return this.organisationIDField;
                }
                set
                {
                    this.organisationIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string OrganisationIDType
            {
                get
                {
                    return this.organisationIDTypeField;
                }
                set
                {
                    this.organisationIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameKey
            {
                get
                {
                    return this.nameKeyField;
                }
                set
                {
                    this.nameKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameKeyRef
            {
                get
                {
                    return this.nameKeyRefField;
                }
                set
                {
                    this.nameKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField1;
                }
                set
                {
                    this.typeField1 = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
        public partial class OrganisationNameNameElement
        {

            private string elementTypeField;

            private string abbreviationField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string ElementType
            {
                get
                {
                    return this.elementTypeField;
                }
                set
                {
                    this.elementTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
        public partial class OrganisationNameSubDivisionName
        {

            private string typeField;

            private string abbreviationField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Addresses
        {

            private AddressesAddress addressField;

            /// <remarks/>
            public AddressesAddress Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class AddressesAddress
        {

            private FreeTextAddress freeTextAddressField;

            private Country countryField;

            private AdministrativeArea administrativeAreaField;

            private Locality localityField;

            private Thoroughfare thoroughfareField;

            private Premises premisesField;

            private PostCode postCodeField;

            private RuralDelivery ruralDeliveryField;

            private PostalDeliveryPoint postalDeliveryPointField;

            private PostOffice postOfficeField;

            private object geoRSSField;

            private LocationByCoordinates locationByCoordinatesField;

            private string typeField;

            private string addressIDField;

            private string addressIDTypeField;

            private string idField;

            private string usageField;

            private string deliveryModeField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string addressKeyField;

            private string addressKeyRefField;

            private string typeField1;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public FreeTextAddress FreeTextAddress
            {
                get
                {
                    return this.freeTextAddressField;
                }
                set
                {
                    this.freeTextAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Country Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public AdministrativeArea AdministrativeArea
            {
                get
                {
                    return this.administrativeAreaField;
                }
                set
                {
                    this.administrativeAreaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Locality Locality
            {
                get
                {
                    return this.localityField;
                }
                set
                {
                    this.localityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Thoroughfare Thoroughfare
            {
                get
                {
                    return this.thoroughfareField;
                }
                set
                {
                    this.thoroughfareField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Premises Premises
            {
                get
                {
                    return this.premisesField;
                }
                set
                {
                    this.premisesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public PostCode PostCode
            {
                get
                {
                    return this.postCodeField;
                }
                set
                {
                    this.postCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public RuralDelivery RuralDelivery
            {
                get
                {
                    return this.ruralDeliveryField;
                }
                set
                {
                    this.ruralDeliveryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public PostalDeliveryPoint PostalDeliveryPoint
            {
                get
                {
                    return this.postalDeliveryPointField;
                }
                set
                {
                    this.postalDeliveryPointField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public PostOffice PostOffice
            {
                get
                {
                    return this.postOfficeField;
                }
                set
                {
                    this.postOfficeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public object GeoRSS
            {
                get
                {
                    return this.geoRSSField;
                }
                set
                {
                    this.geoRSSField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public LocationByCoordinates LocationByCoordinates
            {
                get
                {
                    return this.locationByCoordinatesField;
                }
                set
                {
                    this.locationByCoordinatesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressID
            {
                get
                {
                    return this.addressIDField;
                }
                set
                {
                    this.addressIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressIDType
            {
                get
                {
                    return this.addressIDTypeField;
                }
                set
                {
                    this.addressIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string DeliveryMode
            {
                get
                {
                    return this.deliveryModeField;
                }
                set
                {
                    this.deliveryModeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressKey
            {
                get
                {
                    return this.addressKeyField;
                }
                set
                {
                    this.addressKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressKeyRef
            {
                get
                {
                    return this.addressKeyRefField;
                }
                set
                {
                    this.addressKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField1;
                }
                set
                {
                    this.typeField1 = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3", IsNullable = false)]
        public partial class FreeTextAddress
        {

            private FreeTextAddressAddressLine addressLineField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public FreeTextAddressAddressLine AddressLine
            {
                get
                {
                    return this.addressLineField;
                }
                set
                {
                    this.addressLineField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class FreeTextAddressAddressLine
        {

            private string typeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3", IsNullable = false)]
        public partial class Country
        {

            private CountryNameElement nameElementField;

            /// <remarks/>
            public CountryNameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class CountryNameElement
        {

            private string abbreviationField;

            private string nameTypeField;

            private string nameCodeField;

            private string nameCodeTypeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameType
            {
                get
                {
                    return this.nameTypeField;
                }
                set
                {
                    this.nameTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameCode
            {
                get
                {
                    return this.nameCodeField;
                }
                set
                {
                    this.nameCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameCodeType
            {
                get
                {
                    return this.nameCodeTypeField;
                }
                set
                {
                    this.nameCodeTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3", IsNullable = false)]
        public partial class AdministrativeArea
        {

            private AdministrativeAreaNameElement nameElementField;

            private AdministrativeAreaSubAdministrativeArea subAdministrativeAreaField;

            private string typeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public AdministrativeAreaNameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            public AdministrativeAreaSubAdministrativeArea SubAdministrativeArea
            {
                get
                {
                    return this.subAdministrativeAreaField;
                }
                set
                {
                    this.subAdministrativeAreaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class AdministrativeAreaNameElement
        {

            private string abbreviationField;

            private string nameTypeField;

            private string nameCodeField;

            private string nameCodeTypeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameType
            {
                get
                {
                    return this.nameTypeField;
                }
                set
                {
                    this.nameTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameCode
            {
                get
                {
                    return this.nameCodeField;
                }
                set
                {
                    this.nameCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameCodeType
            {
                get
                {
                    return this.nameCodeTypeField;
                }
                set
                {
                    this.nameCodeTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class AdministrativeAreaSubAdministrativeArea
        {

            private AdministrativeAreaSubAdministrativeAreaNameElement nameElementField;

            private string typeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public AdministrativeAreaSubAdministrativeAreaNameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class AdministrativeAreaSubAdministrativeAreaNameElement
        {

            private string abbreviationField;

            private string nameTypeField;

            private string nameCodeField;

            private string nameCodeTypeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameType
            {
                get
                {
                    return this.nameTypeField;
                }
                set
                {
                    this.nameTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameCode
            {
                get
                {
                    return this.nameCodeField;
                }
                set
                {
                    this.nameCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameCodeType
            {
                get
                {
                    return this.nameCodeTypeField;
                }
                set
                {
                    this.nameCodeTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3", IsNullable = false)]
        public partial class Locality
        {

            private LocalityNameElement nameElementField;

            private LocalitySubLocality subLocalityField;

            private string typeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public LocalityNameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            public LocalitySubLocality SubLocality
            {
                get
                {
                    return this.subLocalityField;
                }
                set
                {
                    this.subLocalityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class LocalityNameElement
        {

            private string abbreviationField;

            private string nameTypeField;

            private string nameCodeField;

            private string nameCodeTypeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameType
            {
                get
                {
                    return this.nameTypeField;
                }
                set
                {
                    this.nameTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameCode
            {
                get
                {
                    return this.nameCodeField;
                }
                set
                {
                    this.nameCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameCodeType
            {
                get
                {
                    return this.nameCodeTypeField;
                }
                set
                {
                    this.nameCodeTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class LocalitySubLocality
        {

            private LocalitySubLocalityNameElement nameElementField;

            private string typeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public LocalitySubLocalityNameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class LocalitySubLocalityNameElement
        {

            private string abbreviationField;

            private string nameTypeField;

            private string nameCodeField;

            private string nameCodeTypeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameType
            {
                get
                {
                    return this.nameTypeField;
                }
                set
                {
                    this.nameTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameCode
            {
                get
                {
                    return this.nameCodeField;
                }
                set
                {
                    this.nameCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameCodeType
            {
                get
                {
                    return this.nameCodeTypeField;
                }
                set
                {
                    this.nameCodeTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3", IsNullable = false)]
        public partial class Thoroughfare
        {

            private ThoroughfareNameElement nameElementField;

            private ThoroughfareNumber numberField;

            private ThoroughfareSubThoroughfare subThoroughfareField;

            private string typeField;

            private string typeCodeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public ThoroughfareNameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            public ThoroughfareNumber Number
            {
                get
                {
                    return this.numberField;
                }
                set
                {
                    this.numberField = value;
                }
            }

            /// <remarks/>
            public ThoroughfareSubThoroughfare SubThoroughfare
            {
                get
                {
                    return this.subThoroughfareField;
                }
                set
                {
                    this.subThoroughfareField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string TypeCode
            {
                get
                {
                    return this.typeCodeField;
                }
                set
                {
                    this.typeCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class ThoroughfareNameElement
        {

            private string abbreviationField;

            private string nameTypeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameType
            {
                get
                {
                    return this.nameTypeField;
                }
                set
                {
                    this.nameTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class ThoroughfareNumber
        {

            private string typeField;

            private string abbreviationField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class ThoroughfareSubThoroughfare
        {

            private ThoroughfareSubThoroughfareNameElement nameElementField;

            private ThoroughfareSubThoroughfareNumber numberField;

            private string typeField;

            private string typeCodeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public ThoroughfareSubThoroughfareNameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            public ThoroughfareSubThoroughfareNumber Number
            {
                get
                {
                    return this.numberField;
                }
                set
                {
                    this.numberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string TypeCode
            {
                get
                {
                    return this.typeCodeField;
                }
                set
                {
                    this.typeCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class ThoroughfareSubThoroughfareNameElement
        {

            private string abbreviationField;

            private string nameTypeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameType
            {
                get
                {
                    return this.nameTypeField;
                }
                set
                {
                    this.nameTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class ThoroughfareSubThoroughfareNumber
        {

            private string typeField;

            private string abbreviationField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3", IsNullable = false)]
        public partial class Premises
        {

            private PremisesNameElement nameElementField;

            private PremisesNumber numberField;

            private PremisesSubPremises subPremisesField;

            private string typeField;

            private string typeCodeField;

            /// <remarks/>
            public PremisesNameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            public PremisesNumber Number
            {
                get
                {
                    return this.numberField;
                }
                set
                {
                    this.numberField = value;
                }
            }

            /// <remarks/>
            public PremisesSubPremises SubPremises
            {
                get
                {
                    return this.subPremisesField;
                }
                set
                {
                    this.subPremisesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string TypeCode
            {
                get
                {
                    return this.typeCodeField;
                }
                set
                {
                    this.typeCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class PremisesNameElement
        {

            private string abbreviationField;

            private string nameTypeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameType
            {
                get
                {
                    return this.nameTypeField;
                }
                set
                {
                    this.nameTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class PremisesNumber
        {

            private string typeField;

            private string abbreviationField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class PremisesSubPremises
        {

            private PremisesSubPremisesNameElement nameElementField;

            private PremisesSubPremisesNumber numberField;

            private string typeField;

            private string typeCodeField;

            /// <remarks/>
            public PremisesSubPremisesNameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            public PremisesSubPremisesNumber Number
            {
                get
                {
                    return this.numberField;
                }
                set
                {
                    this.numberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string TypeCode
            {
                get
                {
                    return this.typeCodeField;
                }
                set
                {
                    this.typeCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class PremisesSubPremisesNameElement
        {

            private string abbreviationField;

            private string nameTypeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameType
            {
                get
                {
                    return this.nameTypeField;
                }
                set
                {
                    this.nameTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class PremisesSubPremisesNumber
        {

            private string typeField;

            private string abbreviationField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3", IsNullable = false)]
        public partial class PostCode
        {

            private PostCodeIdentifier identifierField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public PostCodeIdentifier Identifier
            {
                get
                {
                    return this.identifierField;
                }
                set
                {
                    this.identifierField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class PostCodeIdentifier
        {

            private string typeField;

            private string abbreviationField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3", IsNullable = false)]
        public partial class RuralDelivery
        {

            private RuralDeliveryIdentifier identifierField;

            private string typeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public RuralDeliveryIdentifier Identifier
            {
                get
                {
                    return this.identifierField;
                }
                set
                {
                    this.identifierField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class RuralDeliveryIdentifier
        {

            private string typeField;

            private string abbreviationField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3", IsNullable = false)]
        public partial class PostalDeliveryPoint
        {

            private PostalDeliveryPointIdentifier identifierField;

            private string typeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public PostalDeliveryPointIdentifier Identifier
            {
                get
                {
                    return this.identifierField;
                }
                set
                {
                    this.identifierField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class PostalDeliveryPointIdentifier
        {

            private string typeField;

            private string abbreviationField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3", IsNullable = false)]
        public partial class PostOffice
        {

            private PostOfficeIdentifier identifierField;

            private string typeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public PostOfficeIdentifier Identifier
            {
                get
                {
                    return this.identifierField;
                }
                set
                {
                    this.identifierField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class PostOfficeIdentifier
        {

            private string typeField;

            private string abbreviationField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3", IsNullable = false)]
        public partial class LocationByCoordinates
        {

            private LocationByCoordinatesLatitude latitudeField;

            private LocationByCoordinatesLongitude longitudeField;

            private string meridianField;

            private string meridianCodeTypeField;

            private string datumField;

            private string datumCodeTypeField;

            private string projectionField;

            private string projectionCodeTypeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public LocationByCoordinatesLatitude Latitude
            {
                get
                {
                    return this.latitudeField;
                }
                set
                {
                    this.latitudeField = value;
                }
            }

            /// <remarks/>
            public LocationByCoordinatesLongitude Longitude
            {
                get
                {
                    return this.longitudeField;
                }
                set
                {
                    this.longitudeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Meridian
            {
                get
                {
                    return this.meridianField;
                }
                set
                {
                    this.meridianField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string MeridianCodeType
            {
                get
                {
                    return this.meridianCodeTypeField;
                }
                set
                {
                    this.meridianCodeTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Datum
            {
                get
                {
                    return this.datumField;
                }
                set
                {
                    this.datumField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string DatumCodeType
            {
                get
                {
                    return this.datumCodeTypeField;
                }
                set
                {
                    this.datumCodeTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Projection
            {
                get
                {
                    return this.projectionField;
                }
                set
                {
                    this.projectionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string ProjectionCodeType
            {
                get
                {
                    return this.projectionCodeTypeField;
                }
                set
                {
                    this.projectionCodeTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class LocationByCoordinatesLatitude
        {

            private string degreesMeasureField;

            private string minutesMeasureField;

            private string secondsMeasureField;

            private string directionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string DegreesMeasure
            {
                get
                {
                    return this.degreesMeasureField;
                }
                set
                {
                    this.degreesMeasureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string MinutesMeasure
            {
                get
                {
                    return this.minutesMeasureField;
                }
                set
                {
                    this.minutesMeasureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string SecondsMeasure
            {
                get
                {
                    return this.secondsMeasureField;
                }
                set
                {
                    this.secondsMeasureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Direction
            {
                get
                {
                    return this.directionField;
                }
                set
                {
                    this.directionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        public partial class LocationByCoordinatesLongitude
        {

            private string degreesMeasureField;

            private string minutesMeasureField;

            private string secondsMeasureField;

            private string directionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string DegreesMeasure
            {
                get
                {
                    return this.degreesMeasureField;
                }
                set
                {
                    this.degreesMeasureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string MinutesMeasure
            {
                get
                {
                    return this.minutesMeasureField;
                }
                set
                {
                    this.minutesMeasureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string SecondsMeasure
            {
                get
                {
                    return this.secondsMeasureField;
                }
                set
                {
                    this.secondsMeasureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Direction
            {
                get
                {
                    return this.directionField;
                }
                set
                {
                    this.directionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Accounts
        {

            private AccountsAccount accountField;

            /// <remarks/>
            public AccountsAccount Account
            {
                get
                {
                    return this.accountField;
                }
                set
                {
                    this.accountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class AccountsAccount
        {

            private AccountsAccountAccountElement accountElementField;

            private AccountsAccountOrganisation organisationField;

            private string typeField;

            private string ownershipTypeField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public AccountsAccountAccountElement AccountElement
            {
                get
                {
                    return this.accountElementField;
                }
                set
                {
                    this.accountElementField = value;
                }
            }

            /// <remarks/>
            public AccountsAccountOrganisation Organisation
            {
                get
                {
                    return this.organisationField;
                }
                set
                {
                    this.organisationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string OwnershipType
            {
                get
                {
                    return this.ownershipTypeField;
                }
                set
                {
                    this.ownershipTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class AccountsAccountAccountElement
        {

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class AccountsAccountOrganisation
        {

            private NameElement nameElementField;

            private SubDivisionName subDivisionNameField;

            private string typeField;

            private string organisationIDField;

            private string organisationIDTypeField;

            private string idField;

            private string usageField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string nameKeyField;

            private string nameKeyRefField;

            private string typeField1;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public NameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public SubDivisionName SubDivisionName
            {
                get
                {
                    return this.subDivisionNameField;
                }
                set
                {
                    this.subDivisionNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string OrganisationID
            {
                get
                {
                    return this.organisationIDField;
                }
                set
                {
                    this.organisationIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string OrganisationIDType
            {
                get
                {
                    return this.organisationIDTypeField;
                }
                set
                {
                    this.organisationIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKey
            {
                get
                {
                    return this.nameKeyField;
                }
                set
                {
                    this.nameKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKeyRef
            {
                get
                {
                    return this.nameKeyRefField;
                }
                set
                {
                    this.nameKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField1;
                }
                set
                {
                    this.typeField1 = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3", IsNullable = false)]
        public partial class NameElement
        {

            private string elementTypeField;

            private string abbreviationField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string ElementType
            {
                get
                {
                    return this.elementTypeField;
                }
                set
                {
                    this.elementTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3", IsNullable = false)]
        public partial class SubDivisionName
        {

            private string typeField;

            private string abbreviationField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class ContactNumbers
        {

            private ContactNumbersContactNumber contactNumberField;

            /// <remarks/>
            public ContactNumbersContactNumber ContactNumber
            {
                get
                {
                    return this.contactNumberField;
                }
                set
                {
                    this.contactNumberField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class ContactNumbersContactNumber
        {

            private ContactNumbersContactNumberContactNumberElement contactNumberElementField;

            private string communicationMediaTypeField;

            private string statusField;

            private string usageField;

            private string contactHoursField;

            private string dateValidFromField;

            private string dateValidToField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public ContactNumbersContactNumberContactNumberElement ContactNumberElement
            {
                get
                {
                    return this.contactNumberElementField;
                }
                set
                {
                    this.contactNumberElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string CommunicationMediaType
            {
                get
                {
                    return this.communicationMediaTypeField;
                }
                set
                {
                    this.communicationMediaTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string ContactHours
            {
                get
                {
                    return this.contactHoursField;
                }
                set
                {
                    this.contactHoursField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class ContactNumbersContactNumberContactNumberElement
        {

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Documents
        {

            private DocumentsDocument documentField;

            /// <remarks/>
            public DocumentsDocument Document
            {
                get
                {
                    return this.documentField;
                }
                set
                {
                    this.documentField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class DocumentsDocument
        {

            private DocumentsDocumentDocumentElement documentElementField;

            private DocumentsDocumentNameOnDocument nameOnDocumentField;

            private DocumentsDocumentAddressOnDocument addressOnDocumentField;

            private DocumentsDocumentIssuerName issuerNameField;

            private string typeField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public DocumentsDocumentDocumentElement DocumentElement
            {
                get
                {
                    return this.documentElementField;
                }
                set
                {
                    this.documentElementField = value;
                }
            }

            /// <remarks/>
            public DocumentsDocumentNameOnDocument NameOnDocument
            {
                get
                {
                    return this.nameOnDocumentField;
                }
                set
                {
                    this.nameOnDocumentField = value;
                }
            }

            /// <remarks/>
            public DocumentsDocumentAddressOnDocument AddressOnDocument
            {
                get
                {
                    return this.addressOnDocumentField;
                }
                set
                {
                    this.addressOnDocumentField = value;
                }
            }

            /// <remarks/>
            public DocumentsDocumentIssuerName IssuerName
            {
                get
                {
                    return this.issuerNameField;
                }
                set
                {
                    this.issuerNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class DocumentsDocumentDocumentElement
        {

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class DocumentsDocumentNameOnDocument
        {

            private NameLine nameLineField;

            private PersonName personNameField;

            private OrganisationName organisationNameField;

            private string partyNameIDField;

            private string partyNameIDTypeField;

            private string idField;

            private string usageField;

            private string statusField;

            private string jointNameConnectorField;

            private string dateValidFromField;

            private string dateValidToField;

            private string nameKeyField;

            private string nameKeyRefField;

            private string typeField;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public NameLine NameLine
            {
                get
                {
                    return this.nameLineField;
                }
                set
                {
                    this.nameLineField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public PersonName PersonName
            {
                get
                {
                    return this.personNameField;
                }
                set
                {
                    this.personNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public OrganisationName OrganisationName
            {
                get
                {
                    return this.organisationNameField;
                }
                set
                {
                    this.organisationNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string PartyNameID
            {
                get
                {
                    return this.partyNameIDField;
                }
                set
                {
                    this.partyNameIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string PartyNameIDType
            {
                get
                {
                    return this.partyNameIDTypeField;
                }
                set
                {
                    this.partyNameIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string JointNameConnector
            {
                get
                {
                    return this.jointNameConnectorField;
                }
                set
                {
                    this.jointNameConnectorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKey
            {
                get
                {
                    return this.nameKeyField;
                }
                set
                {
                    this.nameKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKeyRef
            {
                get
                {
                    return this.nameKeyRefField;
                }
                set
                {
                    this.nameKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class DocumentsDocumentAddressOnDocument
        {

            private FreeTextAddress freeTextAddressField;

            private Country countryField;

            private AdministrativeArea administrativeAreaField;

            private Locality localityField;

            private Thoroughfare thoroughfareField;

            private Premises premisesField;

            private PostCode postCodeField;

            private RuralDelivery ruralDeliveryField;

            private PostalDeliveryPoint postalDeliveryPointField;

            private PostOffice postOfficeField;

            private object geoRSSField;

            private LocationByCoordinates locationByCoordinatesField;

            private string typeField;

            private string addressIDField;

            private string addressIDTypeField;

            private string idField;

            private string usageField;

            private string deliveryModeField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string addressKeyField;

            private string addressKeyRefField;

            private string typeField1;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public FreeTextAddress FreeTextAddress
            {
                get
                {
                    return this.freeTextAddressField;
                }
                set
                {
                    this.freeTextAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Country Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public AdministrativeArea AdministrativeArea
            {
                get
                {
                    return this.administrativeAreaField;
                }
                set
                {
                    this.administrativeAreaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Locality Locality
            {
                get
                {
                    return this.localityField;
                }
                set
                {
                    this.localityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Thoroughfare Thoroughfare
            {
                get
                {
                    return this.thoroughfareField;
                }
                set
                {
                    this.thoroughfareField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Premises Premises
            {
                get
                {
                    return this.premisesField;
                }
                set
                {
                    this.premisesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public PostCode PostCode
            {
                get
                {
                    return this.postCodeField;
                }
                set
                {
                    this.postCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public RuralDelivery RuralDelivery
            {
                get
                {
                    return this.ruralDeliveryField;
                }
                set
                {
                    this.ruralDeliveryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public PostalDeliveryPoint PostalDeliveryPoint
            {
                get
                {
                    return this.postalDeliveryPointField;
                }
                set
                {
                    this.postalDeliveryPointField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public PostOffice PostOffice
            {
                get
                {
                    return this.postOfficeField;
                }
                set
                {
                    this.postOfficeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public object GeoRSS
            {
                get
                {
                    return this.geoRSSField;
                }
                set
                {
                    this.geoRSSField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public LocationByCoordinates LocationByCoordinates
            {
                get
                {
                    return this.locationByCoordinatesField;
                }
                set
                {
                    this.locationByCoordinatesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressID
            {
                get
                {
                    return this.addressIDField;
                }
                set
                {
                    this.addressIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressIDType
            {
                get
                {
                    return this.addressIDTypeField;
                }
                set
                {
                    this.addressIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string DeliveryMode
            {
                get
                {
                    return this.deliveryModeField;
                }
                set
                {
                    this.deliveryModeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressKey
            {
                get
                {
                    return this.addressKeyField;
                }
                set
                {
                    this.addressKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressKeyRef
            {
                get
                {
                    return this.addressKeyRefField;
                }
                set
                {
                    this.addressKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField1;
                }
                set
                {
                    this.typeField1 = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class DocumentsDocumentIssuerName
        {

            private NameElement nameElementField;

            private SubDivisionName subDivisionNameField;

            private string typeField;

            private string organisationIDField;

            private string organisationIDTypeField;

            private string idField;

            private string usageField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string nameKeyField;

            private string nameKeyRefField;

            private string typeField1;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public NameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public SubDivisionName SubDivisionName
            {
                get
                {
                    return this.subDivisionNameField;
                }
                set
                {
                    this.subDivisionNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string OrganisationID
            {
                get
                {
                    return this.organisationIDField;
                }
                set
                {
                    this.organisationIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string OrganisationIDType
            {
                get
                {
                    return this.organisationIDTypeField;
                }
                set
                {
                    this.organisationIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKey
            {
                get
                {
                    return this.nameKeyField;
                }
                set
                {
                    this.nameKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKeyRef
            {
                get
                {
                    return this.nameKeyRefField;
                }
                set
                {
                    this.nameKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField1;
                }
                set
                {
                    this.typeField1 = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class ElectronicAddressIdentifiers
        {

            private ElectronicAddressIdentifiersElectronicAddressIdentifier electronicAddressIdentifierField;

            /// <remarks/>
            public ElectronicAddressIdentifiersElectronicAddressIdentifier ElectronicAddressIdentifier
            {
                get
                {
                    return this.electronicAddressIdentifierField;
                }
                set
                {
                    this.electronicAddressIdentifierField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class ElectronicAddressIdentifiersElectronicAddressIdentifier
        {

            private string typeField;

            private string statusField;

            private string usageField;

            private string labelField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Events
        {

            private EventsEvent eventField;

            /// <remarks/>
            public EventsEvent Event
            {
                get
                {
                    return this.eventField;
                }
                set
                {
                    this.eventField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class EventsEvent
        {

            private string typeField;

            private string dateValidFromField;

            private string dateValidToField;

            private string dateField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Identifiers
        {

            private IdentifiersIdentifier identifierField;

            /// <remarks/>
            public IdentifiersIdentifier Identifier
            {
                get
                {
                    return this.identifierField;
                }
                set
                {
                    this.identifierField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class IdentifiersIdentifier
        {

            private IdentifiersIdentifierIdentifierElement identifierElementField;

            private IdentifiersIdentifierIssuerName issuerNameField;

            private string typeField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public IdentifiersIdentifierIdentifierElement IdentifierElement
            {
                get
                {
                    return this.identifierElementField;
                }
                set
                {
                    this.identifierElementField = value;
                }
            }

            /// <remarks/>
            public IdentifiersIdentifierIssuerName IssuerName
            {
                get
                {
                    return this.issuerNameField;
                }
                set
                {
                    this.issuerNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class IdentifiersIdentifierIdentifierElement
        {

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class IdentifiersIdentifierIssuerName
        {

            private NameElement nameElementField;

            private SubDivisionName subDivisionNameField;

            private string typeField;

            private string organisationIDField;

            private string organisationIDTypeField;

            private string idField;

            private string usageField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string nameKeyField;

            private string nameKeyRefField;

            private string typeField1;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public NameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public SubDivisionName SubDivisionName
            {
                get
                {
                    return this.subDivisionNameField;
                }
                set
                {
                    this.subDivisionNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string OrganisationID
            {
                get
                {
                    return this.organisationIDField;
                }
                set
                {
                    this.organisationIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string OrganisationIDType
            {
                get
                {
                    return this.organisationIDTypeField;
                }
                set
                {
                    this.organisationIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKey
            {
                get
                {
                    return this.nameKeyField;
                }
                set
                {
                    this.nameKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKeyRef
            {
                get
                {
                    return this.nameKeyRefField;
                }
                set
                {
                    this.nameKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField1;
                }
                set
                {
                    this.typeField1 = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Memberships
        {

            private MembershipsMembership membershipField;

            /// <remarks/>
            public MembershipsMembership Membership
            {
                get
                {
                    return this.membershipField;
                }
                set
                {
                    this.membershipField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class MembershipsMembership
        {

            private MembershipsMembershipMembershipElement membershipElementField;

            private MembershipsMembershipOrganisation organisationField;

            private string typeField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public MembershipsMembershipMembershipElement MembershipElement
            {
                get
                {
                    return this.membershipElementField;
                }
                set
                {
                    this.membershipElementField = value;
                }
            }

            /// <remarks/>
            public MembershipsMembershipOrganisation Organisation
            {
                get
                {
                    return this.organisationField;
                }
                set
                {
                    this.organisationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class MembershipsMembershipMembershipElement
        {

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class MembershipsMembershipOrganisation
        {

            private NameElement nameElementField;

            private SubDivisionName subDivisionNameField;

            private string typeField;

            private string organisationIDField;

            private string organisationIDTypeField;

            private string idField;

            private string usageField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string nameKeyField;

            private string nameKeyRefField;

            private string typeField1;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public NameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public SubDivisionName SubDivisionName
            {
                get
                {
                    return this.subDivisionNameField;
                }
                set
                {
                    this.subDivisionNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string OrganisationID
            {
                get
                {
                    return this.organisationIDField;
                }
                set
                {
                    this.organisationIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string OrganisationIDType
            {
                get
                {
                    return this.organisationIDTypeField;
                }
                set
                {
                    this.organisationIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKey
            {
                get
                {
                    return this.nameKeyField;
                }
                set
                {
                    this.nameKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKeyRef
            {
                get
                {
                    return this.nameKeyRefField;
                }
                set
                {
                    this.nameKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField1;
                }
                set
                {
                    this.typeField1 = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Relationships
        {

            private RelationshipsRelationship relationshipField;

            /// <remarks/>
            public RelationshipsRelationship Relationship
            {
                get
                {
                    return this.relationshipField;
                }
                set
                {
                    this.relationshipField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class RelationshipsRelationship
        {

            private NameLine nameLineField;

            private PersonName personNameField;

            private OrganisationName organisationNameField;

            private RelationshipsRelationshipAddresses addressesField;

            private RelationshipsRelationshipContactNumbers contactNumbersField;

            private RelationshipsRelationshipElectronicAddressIdentifiers electronicAddressIdentifiersField;

            private string statusField;

            private string partyTypeField;

            private string relationshipWithPersonField;

            private string relationshipWithOrganisationField;

            private string relationshipValidFromField;

            private string relationshipValidToField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public NameLine NameLine
            {
                get
                {
                    return this.nameLineField;
                }
                set
                {
                    this.nameLineField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public PersonName PersonName
            {
                get
                {
                    return this.personNameField;
                }
                set
                {
                    this.personNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public OrganisationName OrganisationName
            {
                get
                {
                    return this.organisationNameField;
                }
                set
                {
                    this.organisationNameField = value;
                }
            }

            /// <remarks/>
            public RelationshipsRelationshipAddresses Addresses
            {
                get
                {
                    return this.addressesField;
                }
                set
                {
                    this.addressesField = value;
                }
            }

            /// <remarks/>
            public RelationshipsRelationshipContactNumbers ContactNumbers
            {
                get
                {
                    return this.contactNumbersField;
                }
                set
                {
                    this.contactNumbersField = value;
                }
            }

            /// <remarks/>
            public RelationshipsRelationshipElectronicAddressIdentifiers ElectronicAddressIdentifiers
            {
                get
                {
                    return this.electronicAddressIdentifiersField;
                }
                set
                {
                    this.electronicAddressIdentifiersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string PartyType
            {
                get
                {
                    return this.partyTypeField;
                }
                set
                {
                    this.partyTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string RelationshipWithPerson
            {
                get
                {
                    return this.relationshipWithPersonField;
                }
                set
                {
                    this.relationshipWithPersonField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string RelationshipWithOrganisation
            {
                get
                {
                    return this.relationshipWithOrganisationField;
                }
                set
                {
                    this.relationshipWithOrganisationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string RelationshipValidFrom
            {
                get
                {
                    return this.relationshipValidFromField;
                }
                set
                {
                    this.relationshipValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string RelationshipValidTo
            {
                get
                {
                    return this.relationshipValidToField;
                }
                set
                {
                    this.relationshipValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class RelationshipsRelationshipAddresses
        {

            private RelationshipsRelationshipAddressesAddress addressField;

            /// <remarks/>
            public RelationshipsRelationshipAddressesAddress Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class RelationshipsRelationshipAddressesAddress
        {

            private FreeTextAddress freeTextAddressField;

            private Country countryField;

            private AdministrativeArea administrativeAreaField;

            private Locality localityField;

            private Thoroughfare thoroughfareField;

            private Premises premisesField;

            private PostCode postCodeField;

            private RuralDelivery ruralDeliveryField;

            private PostalDeliveryPoint postalDeliveryPointField;

            private PostOffice postOfficeField;

            private object geoRSSField;

            private LocationByCoordinates locationByCoordinatesField;

            private string typeField;

            private string addressIDField;

            private string addressIDTypeField;

            private string idField;

            private string usageField;

            private string deliveryModeField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string addressKeyField;

            private string addressKeyRefField;

            private string typeField1;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public FreeTextAddress FreeTextAddress
            {
                get
                {
                    return this.freeTextAddressField;
                }
                set
                {
                    this.freeTextAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Country Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public AdministrativeArea AdministrativeArea
            {
                get
                {
                    return this.administrativeAreaField;
                }
                set
                {
                    this.administrativeAreaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Locality Locality
            {
                get
                {
                    return this.localityField;
                }
                set
                {
                    this.localityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Thoroughfare Thoroughfare
            {
                get
                {
                    return this.thoroughfareField;
                }
                set
                {
                    this.thoroughfareField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Premises Premises
            {
                get
                {
                    return this.premisesField;
                }
                set
                {
                    this.premisesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public PostCode PostCode
            {
                get
                {
                    return this.postCodeField;
                }
                set
                {
                    this.postCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public RuralDelivery RuralDelivery
            {
                get
                {
                    return this.ruralDeliveryField;
                }
                set
                {
                    this.ruralDeliveryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public PostalDeliveryPoint PostalDeliveryPoint
            {
                get
                {
                    return this.postalDeliveryPointField;
                }
                set
                {
                    this.postalDeliveryPointField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public PostOffice PostOffice
            {
                get
                {
                    return this.postOfficeField;
                }
                set
                {
                    this.postOfficeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public object GeoRSS
            {
                get
                {
                    return this.geoRSSField;
                }
                set
                {
                    this.geoRSSField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public LocationByCoordinates LocationByCoordinates
            {
                get
                {
                    return this.locationByCoordinatesField;
                }
                set
                {
                    this.locationByCoordinatesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressID
            {
                get
                {
                    return this.addressIDField;
                }
                set
                {
                    this.addressIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressIDType
            {
                get
                {
                    return this.addressIDTypeField;
                }
                set
                {
                    this.addressIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string DeliveryMode
            {
                get
                {
                    return this.deliveryModeField;
                }
                set
                {
                    this.deliveryModeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressKey
            {
                get
                {
                    return this.addressKeyField;
                }
                set
                {
                    this.addressKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressKeyRef
            {
                get
                {
                    return this.addressKeyRefField;
                }
                set
                {
                    this.addressKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField1;
                }
                set
                {
                    this.typeField1 = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class RelationshipsRelationshipContactNumbers
        {

            private RelationshipsRelationshipContactNumbersContactNumber contactNumberField;

            /// <remarks/>
            public RelationshipsRelationshipContactNumbersContactNumber ContactNumber
            {
                get
                {
                    return this.contactNumberField;
                }
                set
                {
                    this.contactNumberField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class RelationshipsRelationshipContactNumbersContactNumber
        {

            private RelationshipsRelationshipContactNumbersContactNumberContactNumberElement contactNumberElementField;

            private string communicationMediaTypeField;

            private string statusField;

            private string usageField;

            private string contactHoursField;

            private string dateValidFromField;

            private string dateValidToField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public RelationshipsRelationshipContactNumbersContactNumberContactNumberElement ContactNumberElement
            {
                get
                {
                    return this.contactNumberElementField;
                }
                set
                {
                    this.contactNumberElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string CommunicationMediaType
            {
                get
                {
                    return this.communicationMediaTypeField;
                }
                set
                {
                    this.communicationMediaTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string ContactHours
            {
                get
                {
                    return this.contactHoursField;
                }
                set
                {
                    this.contactHoursField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class RelationshipsRelationshipContactNumbersContactNumberContactNumberElement
        {

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class RelationshipsRelationshipElectronicAddressIdentifiers
        {

            private RelationshipsRelationshipElectronicAddressIdentifiersElectronicAddressIdentifier electronicAddressIdentifierField;

            /// <remarks/>
            public RelationshipsRelationshipElectronicAddressIdentifiersElectronicAddressIdentifier ElectronicAddressIdentifier
            {
                get
                {
                    return this.electronicAddressIdentifierField;
                }
                set
                {
                    this.electronicAddressIdentifierField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class RelationshipsRelationshipElectronicAddressIdentifiersElectronicAddressIdentifier
        {

            private string typeField;

            private string statusField;

            private string usageField;

            private string labelField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Revenues
        {

            private RevenuesRevenue revenueField;

            /// <remarks/>
            public RevenuesRevenue Revenue
            {
                get
                {
                    return this.revenueField;
                }
                set
                {
                    this.revenueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class RevenuesRevenue
        {

            private string currencyCodeField;

            private string statusField;

            private string periodFromField;

            private string periodToField;

            private string typeField;

            private string precisionField;

            private string sourceField;

            private string countryNameField;

            private string afterTaxField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string CurrencyCode
            {
                get
                {
                    return this.currencyCodeField;
                }
                set
                {
                    this.currencyCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string PeriodFrom
            {
                get
                {
                    return this.periodFromField;
                }
                set
                {
                    this.periodFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string PeriodTo
            {
                get
                {
                    return this.periodToField;
                }
                set
                {
                    this.periodToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Precision
            {
                get
                {
                    return this.precisionField;
                }
                set
                {
                    this.precisionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Source
            {
                get
                {
                    return this.sourceField;
                }
                set
                {
                    this.sourceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string CountryName
            {
                get
                {
                    return this.countryNameField;
                }
                set
                {
                    this.countryNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string AfterTax
            {
                get
                {
                    return this.afterTaxField;
                }
                set
                {
                    this.afterTaxField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Stocks
        {

            private StocksStock stockField;

            /// <remarks/>
            public StocksStock Stock
            {
                get
                {
                    return this.stockField;
                }
                set
                {
                    this.stockField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class StocksStock
        {

            private string listedCodeField;

            private string marketNameField;

            private string countryNameField;

            private string investedDateField;

            private string shareQuantityField;

            private string listedDateField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string ListedCode
            {
                get
                {
                    return this.listedCodeField;
                }
                set
                {
                    this.listedCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string MarketName
            {
                get
                {
                    return this.marketNameField;
                }
                set
                {
                    this.marketNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string CountryName
            {
                get
                {
                    return this.countryNameField;
                }
                set
                {
                    this.countryNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string InvestedDate
            {
                get
                {
                    return this.investedDateField;
                }
                set
                {
                    this.investedDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string ShareQuantity
            {
                get
                {
                    return this.shareQuantityField;
                }
                set
                {
                    this.shareQuantityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string ListedDate
            {
                get
                {
                    return this.listedDateField;
                }
                set
                {
                    this.listedDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Vehicles
        {

            private VehiclesVehicle vehicleField;

            /// <remarks/>
            public VehiclesVehicle Vehicle
            {
                get
                {
                    return this.vehicleField;
                }
                set
                {
                    this.vehicleField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class VehiclesVehicle
        {

            private VehiclesVehicleVehicleElement vehicleElementField;

            private string typeField;

            private string statusField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public VehiclesVehicleVehicleElement VehicleElement
            {
                get
                {
                    return this.vehicleElementField;
                }
                set
                {
                    this.vehicleElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class VehiclesVehicleVehicleElement
        {

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class OrganisationInfo
        {

            private string typeField;

            private string categoryTypeField;

            private string statusField;

            private string natureField;

            private string industryTypeField;

            private string industryCodeField;

            private string industryCodeTypeField;

            private string numberOfEmployeesField;

            private string operatingHourStartTimeField;

            private string operatingHourEndTimeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string CategoryType
            {
                get
                {
                    return this.categoryTypeField;
                }
                set
                {
                    this.categoryTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Nature
            {
                get
                {
                    return this.natureField;
                }
                set
                {
                    this.natureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string IndustryType
            {
                get
                {
                    return this.industryTypeField;
                }
                set
                {
                    this.industryTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string IndustryCode
            {
                get
                {
                    return this.industryCodeField;
                }
                set
                {
                    this.industryCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string IndustryCodeType
            {
                get
                {
                    return this.industryCodeTypeField;
                }
                set
                {
                    this.industryCodeTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NumberOfEmployees
            {
                get
                {
                    return this.numberOfEmployeesField;
                }
                set
                {
                    this.numberOfEmployeesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string OperatingHourStartTime
            {
                get
                {
                    return this.operatingHourStartTimeField;
                }
                set
                {
                    this.operatingHourStartTimeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string OperatingHourEndTime
            {
                get
                {
                    return this.operatingHourEndTimeField;
                }
                set
                {
                    this.operatingHourEndTimeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class PersonInfo
        {

            private string ageField;

            private string categoryTypeField;

            private string physicalStatusField;

            private string maritalStatusField;

            private string ethnicityField;

            private string genderField;

            private string religionField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Age
            {
                get
                {
                    return this.ageField;
                }
                set
                {
                    this.ageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string CategoryType
            {
                get
                {
                    return this.categoryTypeField;
                }
                set
                {
                    this.categoryTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string PhysicalStatus
            {
                get
                {
                    return this.physicalStatusField;
                }
                set
                {
                    this.physicalStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string MaritalStatus
            {
                get
                {
                    return this.maritalStatusField;
                }
                set
                {
                    this.maritalStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Ethnicity
            {
                get
                {
                    return this.ethnicityField;
                }
                set
                {
                    this.ethnicityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Gender
            {
                get
                {
                    return this.genderField;
                }
                set
                {
                    this.genderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Religion
            {
                get
                {
                    return this.religionField;
                }
                set
                {
                    this.religionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class BirthInfo
        {

            private BirthInfoBirthInfoElement birthInfoElementField;

            private BirthInfoBirthPlaceDetails birthPlaceDetailsField;

            private string birthDateTimeField;

            private string birthDateTimePrecisionField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public BirthInfoBirthInfoElement BirthInfoElement
            {
                get
                {
                    return this.birthInfoElementField;
                }
                set
                {
                    this.birthInfoElementField = value;
                }
            }

            /// <remarks/>
            public BirthInfoBirthPlaceDetails BirthPlaceDetails
            {
                get
                {
                    return this.birthPlaceDetailsField;
                }
                set
                {
                    this.birthPlaceDetailsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string BirthDateTime
            {
                get
                {
                    return this.birthDateTimeField;
                }
                set
                {
                    this.birthDateTimeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string BirthDateTimePrecision
            {
                get
                {
                    return this.birthDateTimePrecisionField;
                }
                set
                {
                    this.birthDateTimePrecisionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class BirthInfoBirthInfoElement
        {

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class BirthInfoBirthPlaceDetails
        {

            private FreeTextAddress freeTextAddressField;

            private Country countryField;

            private AdministrativeArea administrativeAreaField;

            private Locality localityField;

            private Thoroughfare thoroughfareField;

            private Premises premisesField;

            private PostCode postCodeField;

            private RuralDelivery ruralDeliveryField;

            private PostalDeliveryPoint postalDeliveryPointField;

            private PostOffice postOfficeField;

            private object geoRSSField;

            private LocationByCoordinates locationByCoordinatesField;

            private string typeField;

            private string addressIDField;

            private string addressIDTypeField;

            private string idField;

            private string usageField;

            private string deliveryModeField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string addressKeyField;

            private string addressKeyRefField;

            private string typeField1;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public FreeTextAddress FreeTextAddress
            {
                get
                {
                    return this.freeTextAddressField;
                }
                set
                {
                    this.freeTextAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Country Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public AdministrativeArea AdministrativeArea
            {
                get
                {
                    return this.administrativeAreaField;
                }
                set
                {
                    this.administrativeAreaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Locality Locality
            {
                get
                {
                    return this.localityField;
                }
                set
                {
                    this.localityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Thoroughfare Thoroughfare
            {
                get
                {
                    return this.thoroughfareField;
                }
                set
                {
                    this.thoroughfareField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public Premises Premises
            {
                get
                {
                    return this.premisesField;
                }
                set
                {
                    this.premisesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public PostCode PostCode
            {
                get
                {
                    return this.postCodeField;
                }
                set
                {
                    this.postCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public RuralDelivery RuralDelivery
            {
                get
                {
                    return this.ruralDeliveryField;
                }
                set
                {
                    this.ruralDeliveryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public PostalDeliveryPoint PostalDeliveryPoint
            {
                get
                {
                    return this.postalDeliveryPointField;
                }
                set
                {
                    this.postalDeliveryPointField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public PostOffice PostOffice
            {
                get
                {
                    return this.postOfficeField;
                }
                set
                {
                    this.postOfficeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public object GeoRSS
            {
                get
                {
                    return this.geoRSSField;
                }
                set
                {
                    this.geoRSSField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public LocationByCoordinates LocationByCoordinates
            {
                get
                {
                    return this.locationByCoordinatesField;
                }
                set
                {
                    this.locationByCoordinatesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressID
            {
                get
                {
                    return this.addressIDField;
                }
                set
                {
                    this.addressIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressIDType
            {
                get
                {
                    return this.addressIDTypeField;
                }
                set
                {
                    this.addressIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string DeliveryMode
            {
                get
                {
                    return this.deliveryModeField;
                }
                set
                {
                    this.deliveryModeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressKey
            {
                get
                {
                    return this.addressKeyField;
                }
                set
                {
                    this.addressKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public string AddressKeyRef
            {
                get
                {
                    return this.addressKeyRefField;
                }
                set
                {
                    this.addressKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField1;
                }
                set
                {
                    this.typeField1 = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class CountriesOfResidence
        {

            private CountriesOfResidenceCountry countryField;

            /// <remarks/>
            public CountriesOfResidenceCountry Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class CountriesOfResidenceCountry
        {

            private NameElement1 nameElementField;

            private string typeField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public NameElement1 NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xal:3")]
        [System.Xml.Serialization.XmlRootAttribute("NameElement", Namespace = "urn:oasis:names:tc:ciq:xal:3", IsNullable = false)]
        public partial class NameElement1
        {

            private string abbreviationField;

            private string nameTypeField;

            private string nameCodeField;

            private string nameCodeTypeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string Abbreviation
            {
                get
                {
                    return this.abbreviationField;
                }
                set
                {
                    this.abbreviationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameType
            {
                get
                {
                    return this.nameTypeField;
                }
                set
                {
                    this.nameTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameCode
            {
                get
                {
                    return this.nameCodeField;
                }
                set
                {
                    this.nameCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string NameCodeType
            {
                get
                {
                    return this.nameCodeTypeField;
                }
                set
                {
                    this.nameCodeTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Favourites
        {

            private FavouritesFavourite favouriteField;

            /// <remarks/>
            public FavouritesFavourite Favourite
            {
                get
                {
                    return this.favouriteField;
                }
                set
                {
                    this.favouriteField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class FavouritesFavourite
        {

            private string typeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Habits
        {

            private HabitsHabit habitField;

            /// <remarks/>
            public HabitsHabit Habit
            {
                get
                {
                    return this.habitField;
                }
                set
                {
                    this.habitField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class HabitsHabit
        {

            private string typeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Hobbies
        {

            private HobbiesHobby hobbyField;

            /// <remarks/>
            public HobbiesHobby Hobby
            {
                get
                {
                    return this.hobbyField;
                }
                set
                {
                    this.hobbyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class HobbiesHobby
        {

            private string typeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Languages
        {

            private LanguagesLanguage languageField;

            /// <remarks/>
            public LanguagesLanguage Language
            {
                get
                {
                    return this.languageField;
                }
                set
                {
                    this.languageField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class LanguagesLanguage
        {

            private string typeField;

            private string speakField;

            private string readField;

            private string writeField;

            private string understandField;

            private string preferenceField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Speak
            {
                get
                {
                    return this.speakField;
                }
                set
                {
                    this.speakField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Read
            {
                get
                {
                    return this.readField;
                }
                set
                {
                    this.readField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Write
            {
                get
                {
                    return this.writeField;
                }
                set
                {
                    this.writeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Understand
            {
                get
                {
                    return this.understandField;
                }
                set
                {
                    this.understandField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Preference
            {
                get
                {
                    return this.preferenceField;
                }
                set
                {
                    this.preferenceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Nationalities
        {

            private NationalitiesCountry countryField;

            /// <remarks/>
            public NationalitiesCountry Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class NationalitiesCountry
        {

            private NameElement1 nameElementField;

            private string typeField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xal:3")]
            public NameElement1 NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Occupations
        {

            private OccupationsOccupation occupationField;

            /// <remarks/>
            public OccupationsOccupation Occupation
            {
                get
                {
                    return this.occupationField;
                }
                set
                {
                    this.occupationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class OccupationsOccupation
        {

            private OccupationsOccupationOccupationElement occupationElementField;

            private OccupationsOccupationEmployer employerField;

            private string isSelfEmployedField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public OccupationsOccupationOccupationElement OccupationElement
            {
                get
                {
                    return this.occupationElementField;
                }
                set
                {
                    this.occupationElementField = value;
                }
            }

            /// <remarks/>
            public OccupationsOccupationEmployer Employer
            {
                get
                {
                    return this.employerField;
                }
                set
                {
                    this.employerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string isSelfEmployed
            {
                get
                {
                    return this.isSelfEmployedField;
                }
                set
                {
                    this.isSelfEmployedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class OccupationsOccupationOccupationElement
        {

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class OccupationsOccupationEmployer
        {

            private NameElement nameElementField;

            private SubDivisionName subDivisionNameField;

            private string typeField;

            private string organisationIDField;

            private string organisationIDTypeField;

            private string idField;

            private string usageField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string nameKeyField;

            private string nameKeyRefField;

            private string typeField1;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public NameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public SubDivisionName SubDivisionName
            {
                get
                {
                    return this.subDivisionNameField;
                }
                set
                {
                    this.subDivisionNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string OrganisationID
            {
                get
                {
                    return this.organisationIDField;
                }
                set
                {
                    this.organisationIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string OrganisationIDType
            {
                get
                {
                    return this.organisationIDTypeField;
                }
                set
                {
                    this.organisationIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKey
            {
                get
                {
                    return this.nameKeyField;
                }
                set
                {
                    this.nameKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKeyRef
            {
                get
                {
                    return this.nameKeyRefField;
                }
                set
                {
                    this.nameKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField1;
                }
                set
                {
                    this.typeField1 = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class PhysicalInfo
        {

            private PhysicalInfoFreeTextLine freeTextLineField;

            private PhysicalInfoFeature featureField;

            private PhysicalInfoBodyMark bodyMarkField;

            private PhysicalInfoDisability disabilityField;

            private PhysicalInfoAllergy allergyField;

            private PhysicalInfoHealthCondition healthConditionField;

            private string bloodGroupField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public PhysicalInfoFreeTextLine FreeTextLine
            {
                get
                {
                    return this.freeTextLineField;
                }
                set
                {
                    this.freeTextLineField = value;
                }
            }

            /// <remarks/>
            public PhysicalInfoFeature Feature
            {
                get
                {
                    return this.featureField;
                }
                set
                {
                    this.featureField = value;
                }
            }

            /// <remarks/>
            public PhysicalInfoBodyMark BodyMark
            {
                get
                {
                    return this.bodyMarkField;
                }
                set
                {
                    this.bodyMarkField = value;
                }
            }

            /// <remarks/>
            public PhysicalInfoDisability Disability
            {
                get
                {
                    return this.disabilityField;
                }
                set
                {
                    this.disabilityField = value;
                }
            }

            /// <remarks/>
            public PhysicalInfoAllergy Allergy
            {
                get
                {
                    return this.allergyField;
                }
                set
                {
                    this.allergyField = value;
                }
            }

            /// <remarks/>
            public PhysicalInfoHealthCondition HealthCondition
            {
                get
                {
                    return this.healthConditionField;
                }
                set
                {
                    this.healthConditionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string BloodGroup
            {
                get
                {
                    return this.bloodGroupField;
                }
                set
                {
                    this.bloodGroupField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class PhysicalInfoFreeTextLine
        {

            private string typeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class PhysicalInfoFeature
        {

            private string typeField;

            private string unitTypeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string UnitType
            {
                get
                {
                    return this.unitTypeField;
                }
                set
                {
                    this.unitTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class PhysicalInfoBodyMark
        {

            private string partField;

            private string locationField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Part
            {
                get
                {
                    return this.partField;
                }
                set
                {
                    this.partField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Location
            {
                get
                {
                    return this.locationField;
                }
                set
                {
                    this.locationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class PhysicalInfoDisability
        {

            private string causeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Cause
            {
                get
                {
                    return this.causeField;
                }
                set
                {
                    this.causeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class PhysicalInfoAllergy
        {

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class PhysicalInfoHealthCondition
        {

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Preferences
        {

            private PreferencesPreference preferenceField;

            /// <remarks/>
            public PreferencesPreference Preference
            {
                get
                {
                    return this.preferenceField;
                }
                set
                {
                    this.preferenceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class PreferencesPreference
        {

            private string typeField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Qualifications
        {

            private QualificationsQualification qualificationField;

            /// <remarks/>
            public QualificationsQualification Qualification
            {
                get
                {
                    return this.qualificationField;
                }
                set
                {
                    this.qualificationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class QualificationsQualification
        {

            private QualificationsQualificationQualificationElement qualificationElementField;

            private QualificationsQualificationInstitution institutionField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public QualificationsQualificationQualificationElement QualificationElement
            {
                get
                {
                    return this.qualificationElementField;
                }
                set
                {
                    this.qualificationElementField = value;
                }
            }

            /// <remarks/>
            public QualificationsQualificationInstitution Institution
            {
                get
                {
                    return this.institutionField;
                }
                set
                {
                    this.institutionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class QualificationsQualificationQualificationElement
        {

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class QualificationsQualificationInstitution
        {

            private NameElement nameElementField;

            private SubDivisionName subDivisionNameField;

            private string typeField;

            private string organisationIDField;

            private string organisationIDTypeField;

            private string idField;

            private string usageField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string nameKeyField;

            private string nameKeyRefField;

            private string typeField1;

            private string labelField;

            private string hrefField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            private string languageCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public NameElement NameElement
            {
                get
                {
                    return this.nameElementField;
                }
                set
                {
                    this.nameElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public SubDivisionName SubDivisionName
            {
                get
                {
                    return this.subDivisionNameField;
                }
                set
                {
                    this.subDivisionNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string OrganisationID
            {
                get
                {
                    return this.organisationIDField;
                }
                set
                {
                    this.organisationIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string OrganisationIDType
            {
                get
                {
                    return this.organisationIDTypeField;
                }
                set
                {
                    this.organisationIDTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKey
            {
                get
                {
                    return this.nameKeyField;
                }
                set
                {
                    this.nameKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:xnl:3")]
            public string NameKeyRef
            {
                get
                {
                    return this.nameKeyRefField;
                }
                set
                {
                    this.nameKeyRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string type
            {
                get
                {
                    return this.typeField1;
                }
                set
                {
                    this.typeField1 = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
            public string href
            {
                get
                {
                    return this.hrefField;
                }
                set
                {
                    this.hrefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string LanguageCode
            {
                get
                {
                    return this.languageCodeField;
                }
                set
                {
                    this.languageCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:ciq:xpil:3", IsNullable = false)]
        public partial class Visas
        {

            private VisasVisa visaField;

            /// <remarks/>
            public VisasVisa Visa
            {
                get
                {
                    return this.visaField;
                }
                set
                {
                    this.visaField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class VisasVisa
        {

            private VisasVisaVisaElement visaElementField;

            private string statusField;

            private string dateValidFromField;

            private string dateValidToField;

            private string entryByDateField;

            private string dataQualityTypeField;

            private string validFromField;

            private string validToField;

            /// <remarks/>
            public VisasVisaVisaElement VisaElement
            {
                get
                {
                    return this.visaElementField;
                }
                set
                {
                    this.visaElementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidFrom
            {
                get
                {
                    return this.dateValidFromField;
                }
                set
                {
                    this.dateValidFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DateValidTo
            {
                get
                {
                    return this.dateValidToField;
                }
                set
                {
                    this.dateValidToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string EntryByDate
            {
                get
                {
                    return this.entryByDateField;
                }
                set
                {
                    this.entryByDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string DataQualityType
            {
                get
                {
                    return this.dataQualityTypeField;
                }
                set
                {
                    this.dataQualityTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidFrom
            {
                get
                {
                    return this.validFromField;
                }
                set
                {
                    this.validFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:ciq:ct:3")]
            public string ValidTo
            {
                get
                {
                    return this.validToField;
                }
                set
                {
                    this.validToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ciq:xpil:3")]
        public partial class VisasVisaVisaElement
        {

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class RucLicences
        {

            private RucLicencesRucLicence rucLicenceField;

            /// <remarks/>
            public RucLicencesRucLicence RucLicence
            {
                get
                {
                    return this.rucLicenceField;
                }
                set
                {
                    this.rucLicenceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class RucLicencesRucLicence
        {

            private string numberField;

            private RucLicencesRucLicenceLicenceType licenceTypeField;

            private RucLicencesRucLicenceVehicleType vehicleTypeField;

            private string endDistanceField;

            private RucLicencesRucLicenceHubodometer hubodometerField;

            private RucLicencesRucLicenceOdometerUnit odometerUnitField;

            private string endDateField;

            private string startDateField;

            private string startDistanceField;

            private string vehicleWeightField;

            private string issueDateField;

            /// <remarks/>
            public string Number
            {
                get
                {
                    return this.numberField;
                }
                set
                {
                    this.numberField = value;
                }
            }

            /// <remarks/>
            public RucLicencesRucLicenceLicenceType LicenceType
            {
                get
                {
                    return this.licenceTypeField;
                }
                set
                {
                    this.licenceTypeField = value;
                }
            }

            /// <remarks/>
            public RucLicencesRucLicenceVehicleType VehicleType
            {
                get
                {
                    return this.vehicleTypeField;
                }
                set
                {
                    this.vehicleTypeField = value;
                }
            }

            /// <remarks/>
            public string EndDistance
            {
                get
                {
                    return this.endDistanceField;
                }
                set
                {
                    this.endDistanceField = value;
                }
            }

            /// <remarks/>
            public RucLicencesRucLicenceHubodometer Hubodometer
            {
                get
                {
                    return this.hubodometerField;
                }
                set
                {
                    this.hubodometerField = value;
                }
            }

            /// <remarks/>
            public RucLicencesRucLicenceOdometerUnit OdometerUnit
            {
                get
                {
                    return this.odometerUnitField;
                }
                set
                {
                    this.odometerUnitField = value;
                }
            }

            /// <remarks/>
            public string EndDate
            {
                get
                {
                    return this.endDateField;
                }
                set
                {
                    this.endDateField = value;
                }
            }

            /// <remarks/>
            public string StartDate
            {
                get
                {
                    return this.startDateField;
                }
                set
                {
                    this.startDateField = value;
                }
            }

            /// <remarks/>
            public string StartDistance
            {
                get
                {
                    return this.startDistanceField;
                }
                set
                {
                    this.startDistanceField = value;
                }
            }

            /// <remarks/>
            public string VehicleWeight
            {
                get
                {
                    return this.vehicleWeightField;
                }
                set
                {
                    this.vehicleWeightField = value;
                }
            }

            /// <remarks/>
            public string IssueDate
            {
                get
                {
                    return this.issueDateField;
                }
                set
                {
                    this.issueDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class RucLicencesRucLicenceLicenceType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class RucLicencesRucLicenceVehicleType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class RucLicencesRucLicenceHubodometer
        {

            private RucLicencesRucLicenceHubodometerMake makeField;

            private string serialNumberField;

            /// <remarks/>
            public RucLicencesRucLicenceHubodometerMake Make
            {
                get
                {
                    return this.makeField;
                }
                set
                {
                    this.makeField = value;
                }
            }

            /// <remarks/>
            public string SerialNumber
            {
                get
                {
                    return this.serialNumberField;
                }
                set
                {
                    this.serialNumberField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class RucLicencesRucLicenceHubodometerMake
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class RucLicencesRucLicenceOdometerUnit
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class MvrLicences
        {

            private MvrLicencesMvrLicence mvrLicenceField;

            /// <remarks/>
            public MvrLicencesMvrLicence MvrLicence
            {
                get
                {
                    return this.mvrLicenceField;
                }
                set
                {
                    this.mvrLicenceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class MvrLicencesMvrLicence
        {

            private string numberField;

            private MvrLicencesMvrLicenceLicenceType licenceTypeField;

            private string continuousLicenceField;

            private string expiryDateField;

            private string issueDateTimeField;

            /// <remarks/>
            public string Number
            {
                get
                {
                    return this.numberField;
                }
                set
                {
                    this.numberField = value;
                }
            }

            /// <remarks/>
            public MvrLicencesMvrLicenceLicenceType LicenceType
            {
                get
                {
                    return this.licenceTypeField;
                }
                set
                {
                    this.licenceTypeField = value;
                }
            }

            /// <remarks/>
            public string ContinuousLicence
            {
                get
                {
                    return this.continuousLicenceField;
                }
                set
                {
                    this.continuousLicenceField = value;
                }
            }

            /// <remarks/>
            public string ExpiryDate
            {
                get
                {
                    return this.expiryDateField;
                }
                set
                {
                    this.expiryDateField = value;
                }
            }

            /// <remarks/>
            public string IssueDateTime
            {
                get
                {
                    return this.issueDateTimeField;
                }
                set
                {
                    this.issueDateTimeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class MvrLicencesMvrLicenceLicenceType
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://localhost/Schema/CdiCommonTypes", IsNullable = false)]
        public partial class OdometerReadings
        {

            private OdometerReadingsOdometerReading odometerReadingField;

            /// <remarks/>
            public OdometerReadingsOdometerReading OdometerReading
            {
                get
                {
                    return this.odometerReadingField;
                }
                set
                {
                    this.odometerReadingField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class OdometerReadingsOdometerReading
        {

            private string readingField;

            private string readingDateField;

            private OdometerReadingsOdometerReadingUnit unitField;

            private OdometerReadingsOdometerReadingSource sourceField;

            /// <remarks/>
            public string Reading
            {
                get
                {
                    return this.readingField;
                }
                set
                {
                    this.readingField = value;
                }
            }

            /// <remarks/>
            public string ReadingDate
            {
                get
                {
                    return this.readingDateField;
                }
                set
                {
                    this.readingDateField = value;
                }
            }

            /// <remarks/>
            public OdometerReadingsOdometerReadingUnit Unit
            {
                get
                {
                    return this.unitField;
                }
                set
                {
                    this.unitField = value;
                }
            }

            /// <remarks/>
            public OdometerReadingsOdometerReadingSource Source
            {
                get
                {
                    return this.sourceField;
                }
                set
                {
                    this.sourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class OdometerReadingsOdometerReadingUnit
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public partial class OdometerReadingsOdometerReadingSource
        {

            private string descriptionField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }



    }
}