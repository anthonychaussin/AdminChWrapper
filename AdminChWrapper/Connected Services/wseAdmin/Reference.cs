﻿using AdminChWrapper.Models;

namespace wseAdmin
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse-shared/2")]
    public partial class securityFault : serviceFault
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(infrastructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(businessFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(securityFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(duplicateFault))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse-shared/2")]
    public partial class serviceFault
    {
        
        private string operationField;
        
        private string errorField;
        
        private string errorDetailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
        public string errorDetail
        {
            get
            {
                return this.errorDetailField;
            }
            set
            {
                this.errorDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class duplicateCandidateType
    {
        
        private int ratingField;
        
        private uidStructureType uidField;
        
        private string organisationNameField;
        
        private string organisationAdditionalNameField;
        
        private string streetField;
        
        private uint swissZipCodeField;
        
        private string townField;
        
        private uidregStatusEnterpriseDetailType uidregStatusEnterpriseDetailField;
        
        private uidregOrganisationTypeType uidregOrganisationTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int rating
        {
            get
            {
                return this.ratingField;
            }
            set
            {
                this.ratingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public uidStructureType uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
        public string organisationName
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=3)]
        public string organisationAdditionalName
        {
            get
            {
                return this.organisationAdditionalNameField;
            }
            set
            {
                this.organisationAdditionalNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=4)]
        public string street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public uint swissZipCode
        {
            get
            {
                return this.swissZipCodeField;
            }
            set
            {
                this.swissZipCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=6)]
        public string town
        {
            get
            {
                return this.townField;
            }
            set
            {
                this.townField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public uidregStatusEnterpriseDetailType uidregStatusEnterpriseDetail
        {
            get
            {
                return this.uidregStatusEnterpriseDetailField;
            }
            set
            {
                this.uidregStatusEnterpriseDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public uidregOrganisationTypeType uidregOrganisationType
        {
            get
            {
                return this.uidregOrganisationTypeField;
            }
            set
            {
                this.uidregOrganisationTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(reportingRegister))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0097/5")]
    public partial class uidStructureType
    {
        
        private uidOrganisationIdCategorieType uidOrganisationIdCategorieField;
        
        private string uidOrganisationIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public uidOrganisationIdCategorieType uidOrganisationIdCategorie
        {
            get
            {
                return this.uidOrganisationIdCategorieField;
            }
            set
            {
                this.uidOrganisationIdCategorieField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger", Order=1)]
        public string uidOrganisationId
        {
            get
            {
                return this.uidOrganisationIdField;
            }
            set
            {
                this.uidOrganisationIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0097/5")]
    public enum uidOrganisationIdCategorieType
    {
        
        /// <remarks/>
        CHE,
        
        /// <remarks/>
        ADM,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0116/4")]
    public partial class reportingRegister : uidStructureType
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public enum uidregStatusEnterpriseDetailType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public enum uidregOrganisationTypeType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("18")]
        Item18,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19")]
        Item19,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class involvedPersonType
    {
        
        private string roleField;
        
        private ulong vnField;
        
        private bool vnFieldSpecified;
        
        private string officialNameField;
        
        private string firstNameField;
        
        private datePartiallyKnownType dateOfBirthField;
        
        private sexType sexField;
        
        private bool sexFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ulong vn
        {
            get
            {
                return this.vnField;
            }
            set
            {
                this.vnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vnSpecified
        {
            get
            {
                return this.vnFieldSpecified;
            }
            set
            {
                this.vnFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
        public string officialName
        {
            get
            {
                return this.officialNameField;
            }
            set
            {
                this.officialNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=3)]
        public string firstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public datePartiallyKnownType dateOfBirth
        {
            get
            {
                return this.dateOfBirthField;
            }
            set
            {
                this.dateOfBirthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public sexType sex
        {
            get
            {
                return this.sexField;
            }
            set
            {
                this.sexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sexSpecified
        {
            get
            {
                return this.sexFieldSpecified;
            }
            set
            {
                this.sexFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0098/5")]
    public partial class datePartiallyKnownType
    {
        
        private object itemField;
        
        private ItemChoiceType itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("year", typeof(string), DataType="gYear", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("yearMonth", typeof(string), DataType="gYearMonth", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("yearMonthDay", typeof(System.DateTime), DataType="date", Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0098/5", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <remarks/>
        year,
        
        /// <remarks/>
        yearMonth,
        
        /// <remarks/>
        yearMonthDay,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0044/4")]
    public enum sexType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class groupRelationshipType
    {
        
        private string groupNameField;
        
        private organisationMembershipRoleType organisationMembershipRoleField;
        
        private groupRelationshipTypeGroupParticipant[] groupParticipantField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string groupName
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public organisationMembershipRoleType organisationMembershipRole
        {
            get
            {
                return this.organisationMembershipRoleField;
            }
            set
            {
                this.organisationMembershipRoleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("groupParticipant", Order=2)]
        public groupRelationshipTypeGroupParticipant[] groupParticipant
        {
            get
            {
                return this.groupParticipantField;
            }
            set
            {
                this.groupParticipantField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public enum organisationMembershipRoleType
    {
        
        /// <remarks/>
        GroupHead,
        
        /// <remarks/>
        GroupMember,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class groupRelationshipTypeGroupParticipant
    {
        
        private uidStructureType participantField;
        
        private organisationMembershipRoleType participantRoleField;
        
        private bool participantRoleFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public uidStructureType participant
        {
            get
            {
                return this.participantField;
            }
            set
            {
                this.participantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public organisationMembershipRoleType participantRole
        {
            get
            {
                return this.participantRoleField;
            }
            set
            {
                this.participantRoleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool participantRoleSpecified
        {
            get
            {
                return this.participantRoleFieldSpecified;
            }
            set
            {
                this.participantRoleFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class leiRegisterInformationType
    {
        
        private System.DateTime initialRegistrationDateField;
        
        private System.DateTime expirationDateField;
        
        private bool expirationDateFieldSpecified;
        
        private leiRegisterInformationTypeRegistrationStatus registrationStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime initialRegistrationDate
        {
            get
            {
                return this.initialRegistrationDateField;
            }
            set
            {
                this.initialRegistrationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime expirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateSpecified
        {
            get
            {
                return this.expirationDateFieldSpecified;
            }
            set
            {
                this.expirationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public leiRegisterInformationTypeRegistrationStatus registrationStatus
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public enum leiRegisterInformationTypeRegistrationStatus
    {
        
        /// <remarks/>
        ISSUED,
        
        /// <remarks/>
        DUPLICATE,
        
        /// <remarks/>
        LAPSED,
        
        /// <remarks/>
        MERGED,
        
        /// <remarks/>
        RETIRED,
        
        /// <remarks/>
        ANNULLED,
        
        /// <remarks/>
        CANCELLED,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class vatRegisterInformationType
    {
        
        private vatStatusType vatStatusField;
        
        private vatEntryStatusType vatEntryStatusField;
        
        private bool vatEntryStatusFieldSpecified;
        
        private System.DateTime vatEntryDateField;
        
        private bool vatEntryDateFieldSpecified;
        
        private System.DateTime vatLiquidationDateField;
        
        private bool vatLiquidationDateFieldSpecified;
        
        private uidStructureType uidVatField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public vatStatusType vatStatus
        {
            get
            {
                return this.vatStatusField;
            }
            set
            {
                this.vatStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public vatEntryStatusType vatEntryStatus
        {
            get
            {
                return this.vatEntryStatusField;
            }
            set
            {
                this.vatEntryStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vatEntryStatusSpecified
        {
            get
            {
                return this.vatEntryStatusFieldSpecified;
            }
            set
            {
                this.vatEntryStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime vatEntryDate
        {
            get
            {
                return this.vatEntryDateField;
            }
            set
            {
                this.vatEntryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vatEntryDateSpecified
        {
            get
            {
                return this.vatEntryDateFieldSpecified;
            }
            set
            {
                this.vatEntryDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime vatLiquidationDate
        {
            get
            {
                return this.vatLiquidationDateField;
            }
            set
            {
                this.vatLiquidationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vatLiquidationDateSpecified
        {
            get
            {
                return this.vatLiquidationDateFieldSpecified;
            }
            set
            {
                this.vatLiquidationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public uidStructureType uidVat
        {
            get
            {
                return this.uidVatField;
            }
            set
            {
                this.uidVatField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public enum vatStatusType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public enum vatEntryStatusType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class commercialRegisterInformationType
    {
        
        private commercialRegisterStatusType commercialRegisterStatusField;
        
        private commercialRegisterEntryStatusType commercialRegisterEntryStatusField;
        
        private bool commercialRegisterEntryStatusFieldSpecified;
        
        private string commercialRegisterNameTranslationField;
        
        private System.DateTime commercialRegisterEntryDateField;
        
        private bool commercialRegisterEntryDateFieldSpecified;
        
        private System.DateTime commercialRegisterLiquidationDateField;
        
        private bool commercialRegisterLiquidationDateFieldSpecified;
        
        private commercialRegisterEnterpriseTypeType commercialRegisterEnterpriseTypeField;
        
        private bool commercialRegisterEnterpriseTypeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public commercialRegisterStatusType commercialRegisterStatus
        {
            get
            {
                return this.commercialRegisterStatusField;
            }
            set
            {
                this.commercialRegisterStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public commercialRegisterEntryStatusType commercialRegisterEntryStatus
        {
            get
            {
                return this.commercialRegisterEntryStatusField;
            }
            set
            {
                this.commercialRegisterEntryStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool commercialRegisterEntryStatusSpecified
        {
            get
            {
                return this.commercialRegisterEntryStatusFieldSpecified;
            }
            set
            {
                this.commercialRegisterEntryStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
        public string commercialRegisterNameTranslation
        {
            get
            {
                return this.commercialRegisterNameTranslationField;
            }
            set
            {
                this.commercialRegisterNameTranslationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime commercialRegisterEntryDate
        {
            get
            {
                return this.commercialRegisterEntryDateField;
            }
            set
            {
                this.commercialRegisterEntryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool commercialRegisterEntryDateSpecified
        {
            get
            {
                return this.commercialRegisterEntryDateFieldSpecified;
            }
            set
            {
                this.commercialRegisterEntryDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=4)]
        public System.DateTime commercialRegisterLiquidationDate
        {
            get
            {
                return this.commercialRegisterLiquidationDateField;
            }
            set
            {
                this.commercialRegisterLiquidationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool commercialRegisterLiquidationDateSpecified
        {
            get
            {
                return this.commercialRegisterLiquidationDateFieldSpecified;
            }
            set
            {
                this.commercialRegisterLiquidationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public commercialRegisterEnterpriseTypeType commercialRegisterEnterpriseType
        {
            get
            {
                return this.commercialRegisterEnterpriseTypeField;
            }
            set
            {
                this.commercialRegisterEnterpriseTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool commercialRegisterEnterpriseTypeSpecified
        {
            get
            {
                return this.commercialRegisterEnterpriseTypeFieldSpecified;
            }
            set
            {
                this.commercialRegisterEnterpriseTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public enum commercialRegisterStatusType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public enum commercialRegisterEntryStatusType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public enum commercialRegisterEnterpriseTypeType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class uidRegSourceType
    {
        
        private uidStructureType uidField;
        
        private uidRegSourceTypeRelationType relationTypeField;
        
        private System.DateTime registrationDateField;
        
        private uidRegSourceTypeRegistrationStatus registrationStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public uidStructureType uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public uidRegSourceTypeRelationType relationType
        {
            get
            {
                return this.relationTypeField;
            }
            set
            {
                this.relationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime registrationDate
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public uidRegSourceTypeRegistrationStatus registrationStatus
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public enum uidRegSourceTypeRelationType
    {
        
        /// <remarks/>
        Responsible,
        
        /// <remarks/>
        Registered,
        
        /// <remarks/>
        Subscribed,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public enum uidRegSourceTypeRegistrationStatus
    {
        
        /// <remarks/>
        Active,
        
        /// <remarks/>
        WaitingForSuccessor,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class uidregInformationType
    {
        
        private uidregStatusEnterpriseDetailType uidregStatusEnterpriseDetailField;
        
        private bool uidregStatusEnterpriseDetailFieldSpecified;
        
        private uidregPublicStatusType uidregPublicStatusField;
        
        private bool uidregPublicStatusFieldSpecified;
        
        private uidregOrganisationTypeType uidregOrganisationTypeField;
        
        private bool uidregOrganisationTypeFieldSpecified;
        
        private uidregLiquidationReasonType uidregLiquidationReasonField;
        
        private bool uidregLiquidationReasonFieldSpecified;
        
        private uidRegSourceType[] uidregSourceField;
        
        private uidStructureType uidReplacementField;
        
        private bool uidregUidServiceField;
        
        private bool uidregUidServiceFieldSpecified;
        
        private string uidregTranslationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public uidregStatusEnterpriseDetailType uidregStatusEnterpriseDetail
        {
            get
            {
                return this.uidregStatusEnterpriseDetailField;
            }
            set
            {
                this.uidregStatusEnterpriseDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uidregStatusEnterpriseDetailSpecified
        {
            get
            {
                return this.uidregStatusEnterpriseDetailFieldSpecified;
            }
            set
            {
                this.uidregStatusEnterpriseDetailFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public uidregPublicStatusType uidregPublicStatus
        {
            get
            {
                return this.uidregPublicStatusField;
            }
            set
            {
                this.uidregPublicStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uidregPublicStatusSpecified
        {
            get
            {
                return this.uidregPublicStatusFieldSpecified;
            }
            set
            {
                this.uidregPublicStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public uidregOrganisationTypeType uidregOrganisationType
        {
            get
            {
                return this.uidregOrganisationTypeField;
            }
            set
            {
                this.uidregOrganisationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uidregOrganisationTypeSpecified
        {
            get
            {
                return this.uidregOrganisationTypeFieldSpecified;
            }
            set
            {
                this.uidregOrganisationTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public uidregLiquidationReasonType uidregLiquidationReason
        {
            get
            {
                return this.uidregLiquidationReasonField;
            }
            set
            {
                this.uidregLiquidationReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uidregLiquidationReasonSpecified
        {
            get
            {
                return this.uidregLiquidationReasonFieldSpecified;
            }
            set
            {
                this.uidregLiquidationReasonFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("uidregSource", Order=4)]
        public uidRegSourceType[] uidregSource
        {
            get
            {
                return this.uidregSourceField;
            }
            set
            {
                this.uidregSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public uidStructureType uidReplacement
        {
            get
            {
                return this.uidReplacementField;
            }
            set
            {
                this.uidReplacementField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool uidregUidService
        {
            get
            {
                return this.uidregUidServiceField;
            }
            set
            {
                this.uidregUidServiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uidregUidServiceSpecified
        {
            get
            {
                return this.uidregUidServiceFieldSpecified;
            }
            set
            {
                this.uidregUidServiceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=7)]
        public string uidregTranslation
        {
            get
            {
                return this.uidregTranslationField;
            }
            set
            {
                this.uidregTranslationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public enum uidregPublicStatusType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public enum uidregLiquidationReasonType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0046/5")]
    public partial class internetType
    {
        
        private object itemField;
        
        private string internetAddressField;
        
        private dateRangeType validityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("internetCategory", typeof(internetCategoryType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("otherInternetCategory", typeof(string), DataType="token", Order=0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string internetAddress
        {
            get
            {
                return this.internetAddressField;
            }
            set
            {
                this.internetAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public dateRangeType validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0046/5")]
    public enum internetCategoryType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0046/5")]
    public partial class dateRangeType
    {
        
        private System.DateTime dateFromField;
        
        private bool dateFromFieldSpecified;
        
        private System.DateTime dateToField;
        
        private bool dateToFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime dateFrom
        {
            get
            {
                return this.dateFromField;
            }
            set
            {
                this.dateFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateFromSpecified
        {
            get
            {
                return this.dateFromFieldSpecified;
            }
            set
            {
                this.dateFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime dateTo
        {
            get
            {
                return this.dateToField;
            }
            set
            {
                this.dateToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateToSpecified
        {
            get
            {
                return this.dateToFieldSpecified;
            }
            set
            {
                this.dateToFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0046/5")]
    public partial class phoneType
    {
        
        private object itemField;
        
        private string phoneNumberField;
        
        private dateRangeType validityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("otherPhoneCategory", typeof(string), DataType="token", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("phoneCategory", typeof(phoneCategoryType), Order=0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string phoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public dateRangeType validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0046/5")]
    public enum phoneCategoryType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0046/5")]
    public partial class emailType
    {
        
        private object itemField;
        
        private string emailAddressField;
        
        private dateRangeType validityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("emailCategory", typeof(emailCategoryType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("otherEmailCategory", typeof(string), DataType="token", Order=0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string emailAddress
        {
            get
            {
                return this.emailAddressField;
            }
            set
            {
                this.emailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public dateRangeType validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0046/5")]
    public enum emailCategoryType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0010/7")]
    public partial class countryType
    {
        
        private string countryIdField;
        
        private string countryIdISO2Field;
        
        private string countryNameShortField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=0)]
        public string countryId
        {
            get
            {
                return this.countryIdField;
            }
            set
            {
                this.countryIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string countryIdISO2
        {
            get
            {
                return this.countryIdISO2Field;
            }
            set
            {
                this.countryIdISO2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
        public string countryNameShort
        {
            get
            {
                return this.countryNameShortField;
            }
            set
            {
                this.countryNameShortField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0010/7")]
    public partial class addressInformationType
    {
        
        private string addressLine1Field;
        
        private string addressLine2Field;
        
        private string streetField;
        
        private string houseNumberField;
        
        private string dwellingNumberField;
        
        private uint postOfficeBoxNumberField;
        
        private bool postOfficeBoxNumberFieldSpecified;
        
        private string postOfficeBoxTextField;
        
        private string localityField;
        
        private string townField;
        
        private object[] itemsField;
        
        private ItemsChoiceType1[] itemsElementNameField;
        
        private countryType countryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string addressLine1
        {
            get
            {
                return this.addressLine1Field;
            }
            set
            {
                this.addressLine1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string addressLine2
        {
            get
            {
                return this.addressLine2Field;
            }
            set
            {
                this.addressLine2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
        public string street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=3)]
        public string houseNumber
        {
            get
            {
                return this.houseNumberField;
            }
            set
            {
                this.houseNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=4)]
        public string dwellingNumber
        {
            get
            {
                return this.dwellingNumberField;
            }
            set
            {
                this.dwellingNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public uint postOfficeBoxNumber
        {
            get
            {
                return this.postOfficeBoxNumberField;
            }
            set
            {
                this.postOfficeBoxNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool postOfficeBoxNumberSpecified
        {
            get
            {
                return this.postOfficeBoxNumberFieldSpecified;
            }
            set
            {
                this.postOfficeBoxNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=6)]
        public string postOfficeBoxText
        {
            get
            {
                return this.postOfficeBoxTextField;
            }
            set
            {
                this.postOfficeBoxTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=7)]
        public string locality
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=8)]
        public string town
        {
            get
            {
                return this.townField;
            }
            set
            {
                this.townField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("foreignZipCode", typeof(string), DataType="token", Order=9)]
        [System.Xml.Serialization.XmlElementAttribute("swissZipCode", typeof(uint), Order=9)]
        [System.Xml.Serialization.XmlElementAttribute("swissZipCodeAddOn", typeof(string), Order=9)]
        [System.Xml.Serialization.XmlElementAttribute("swissZipCodeId", typeof(int), Order=9)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order=10)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public countryType country
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0010/7", IncludeInSchema=false)]
    public enum ItemsChoiceType1
    {
        
        /// <remarks/>
        foreignZipCode,
        
        /// <remarks/>
        swissZipCode,
        
        /// <remarks/>
        swissZipCodeAddOn,
        
        /// <remarks/>
        swissZipCodeId,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0010/7")]
    public partial class personMailAddressInfoType
    {
        
        private mrMrsType mrMrsField;
        
        private bool mrMrsFieldSpecified;
        
        private string titleField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public mrMrsType mrMrs
        {
            get
            {
                return this.mrMrsField;
            }
            set
            {
                this.mrMrsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool mrMrsSpecified
        {
            get
            {
                return this.mrMrsFieldSpecified;
            }
            set
            {
                this.mrMrsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
        public string firstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=3)]
        public string lastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0010/7")]
    public enum mrMrsType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0010/7")]
    public partial class organisationMailAddressInfoType
    {
        
        private string organisationNameField;
        
        private string organisationNameAddOn1Field;
        
        private string organisationNameAddOn2Field;
        
        private mrMrsType mrMrsField;
        
        private bool mrMrsFieldSpecified;
        
        private string titleField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string organisationName
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string organisationNameAddOn1
        {
            get
            {
                return this.organisationNameAddOn1Field;
            }
            set
            {
                this.organisationNameAddOn1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
        public string organisationNameAddOn2
        {
            get
            {
                return this.organisationNameAddOn2Field;
            }
            set
            {
                this.organisationNameAddOn2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public mrMrsType mrMrs
        {
            get
            {
                return this.mrMrsField;
            }
            set
            {
                this.mrMrsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool mrMrsSpecified
        {
            get
            {
                return this.mrMrsFieldSpecified;
            }
            set
            {
                this.mrMrsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=4)]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=5)]
        public string firstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=6)]
        public string lastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0010/7")]
    public partial class mailAddressType
    {
        
        private object itemField;
        
        private addressInformationType addressInformationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("organisation", typeof(organisationMailAddressInfoType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("person", typeof(personMailAddressInfoType), Order=0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public addressInformationType addressInformation
        {
            get
            {
                return this.addressInformationField;
            }
            set
            {
                this.addressInformationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0046/5")]
    public partial class addressType
    {
        
        private object itemField;
        
        private mailAddressType postalAddressField;
        
        private dateRangeType validityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("addressCategory", typeof(addressCategoryType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("otherAddressCategory", typeof(string), DataType="token", Order=0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public mailAddressType postalAddress
        {
            get
            {
                return this.postalAddressField;
            }
            set
            {
                this.postalAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public dateRangeType validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0046/5")]
    public enum addressCategoryType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0044/4")]
    public partial class namedPersonIdType
    {
        
        private string personIdCategoryField;
        
        private string personIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string personIdCategory
        {
            get
            {
                return this.personIdCategoryField;
            }
            set
            {
                this.personIdCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string personId
        {
            get
            {
                return this.personIdField;
            }
            set
            {
                this.personIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0046/5")]
    public partial class contactType
    {
        
        private namedPersonIdType localIDField;
        
        private addressType[] addressField;
        
        private emailType[] emailField;
        
        private phoneType[] phoneField;
        
        private internetType[] internetField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public namedPersonIdType localID
        {
            get
            {
                return this.localIDField;
            }
            set
            {
                this.localIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address", Order=1)]
        public addressType[] address
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("email", Order=2)]
        public emailType[] email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("phone", Order=3)]
        public phoneType[] phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("internet", Order=4)]
        public internetType[] internet
        {
            get
            {
                return this.internetField;
            }
            set
            {
                this.internetField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0098/5")]
    public partial class organisationAddressType
    {
        
        private string addressCategoryField;
        
        private string addressLine1Field;
        
        private string addressLine2Field;
        
        private string streetField;
        
        private string houseNumberField;
        
        private string dwellingNumberField;
        
        private uint postOfficeBoxNumberField;
        
        private bool postOfficeBoxNumberFieldSpecified;
        
        private string townField;
        
        private object[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        private string countryIdISO2Field;
        
        private bool deliverableYesNoField;
        
        private bool deliverableYesNoFieldSpecified;
        
        private System.DateTime dateOfLastCheckField;
        
        private bool dateOfLastCheckFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string addressCategory
        {
            get
            {
                return this.addressCategoryField;
            }
            set
            {
                this.addressCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string addressLine1
        {
            get
            {
                return this.addressLine1Field;
            }
            set
            {
                this.addressLine1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
        public string addressLine2
        {
            get
            {
                return this.addressLine2Field;
            }
            set
            {
                this.addressLine2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=3)]
        public string street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=4)]
        public string houseNumber
        {
            get
            {
                return this.houseNumberField;
            }
            set
            {
                this.houseNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=5)]
        public string dwellingNumber
        {
            get
            {
                return this.dwellingNumberField;
            }
            set
            {
                this.dwellingNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public uint postOfficeBoxNumber
        {
            get
            {
                return this.postOfficeBoxNumberField;
            }
            set
            {
                this.postOfficeBoxNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool postOfficeBoxNumberSpecified
        {
            get
            {
                return this.postOfficeBoxNumberFieldSpecified;
            }
            set
            {
                this.postOfficeBoxNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=7)]
        public string town
        {
            get
            {
                return this.townField;
            }
            set
            {
                this.townField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EGID", typeof(uint), Order=8)]
        [System.Xml.Serialization.XmlElementAttribute("cantonAbbreviation", typeof(cantonAbbreviationType), Order=8)]
        [System.Xml.Serialization.XmlElementAttribute("foreignZipCode", typeof(string), DataType="token", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute("municipalityId", typeof(int), Order=8)]
        [System.Xml.Serialization.XmlElementAttribute("swissZipCode", typeof(uint), Order=8)]
        [System.Xml.Serialization.XmlElementAttribute("swissZipCodeAddOn", typeof(string), Order=8)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order=9)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=10)]
        public string countryIdISO2
        {
            get
            {
                return this.countryIdISO2Field;
            }
            set
            {
                this.countryIdISO2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public bool deliverableYesNo
        {
            get
            {
                return this.deliverableYesNoField;
            }
            set
            {
                this.deliverableYesNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deliverableYesNoSpecified
        {
            get
            {
                return this.deliverableYesNoFieldSpecified;
            }
            set
            {
                this.deliverableYesNoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=12)]
        public System.DateTime dateOfLastCheck
        {
            get
            {
                return this.dateOfLastCheckField;
            }
            set
            {
                this.dateOfLastCheckField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateOfLastCheckSpecified
        {
            get
            {
                return this.dateOfLastCheckFieldSpecified;
            }
            set
            {
                this.dateOfLastCheckFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0007/6")]
    public enum cantonAbbreviationType
    {
        
        /// <remarks/>
        ZH,
        
        /// <remarks/>
        BE,
        
        /// <remarks/>
        LU,
        
        /// <remarks/>
        UR,
        
        /// <remarks/>
        SZ,
        
        /// <remarks/>
        OW,
        
        /// <remarks/>
        NW,
        
        /// <remarks/>
        GL,
        
        /// <remarks/>
        ZG,
        
        /// <remarks/>
        FR,
        
        /// <remarks/>
        SO,
        
        /// <remarks/>
        BS,
        
        /// <remarks/>
        BL,
        
        /// <remarks/>
        SH,
        
        /// <remarks/>
        AR,
        
        /// <remarks/>
        AI,
        
        /// <remarks/>
        SG,
        
        /// <remarks/>
        GR,
        
        /// <remarks/>
        AG,
        
        /// <remarks/>
        TG,
        
        /// <remarks/>
        TI,
        
        /// <remarks/>
        VD,
        
        /// <remarks/>
        VS,
        
        /// <remarks/>
        NE,
        
        /// <remarks/>
        GE,
        
        /// <remarks/>
        JU,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0098/5", IncludeInSchema=false)]
    public enum ItemsChoiceType
    {
        
        /// <remarks/>
        EGID,
        
        /// <remarks/>
        cantonAbbreviation,
        
        /// <remarks/>
        foreignZipCode,
        
        /// <remarks/>
        municipalityId,
        
        /// <remarks/>
        swissZipCode,
        
        /// <remarks/>
        swissZipCodeAddOn,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0098/5")]
    public partial class liquidationType
    {
        
        private datePartiallyKnownType liquidationDateField;
        
        private datePartiallyKnownType liquidationStartDateField;
        
        private liquidationReasonType liquidationReasonField;
        
        private bool liquidationReasonFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public datePartiallyKnownType liquidationDate
        {
            get
            {
                return this.liquidationDateField;
            }
            set
            {
                this.liquidationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public datePartiallyKnownType liquidationStartDate
        {
            get
            {
                return this.liquidationStartDateField;
            }
            set
            {
                this.liquidationStartDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public liquidationReasonType liquidationReason
        {
            get
            {
                return this.liquidationReasonField;
            }
            set
            {
                this.liquidationReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool liquidationReasonSpecified
        {
            get
            {
                return this.liquidationReasonFieldSpecified;
            }
            set
            {
                this.liquidationReasonFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0098/5")]
    public enum liquidationReasonType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0098/5")]
    public partial class foundationType
    {
        
        private datePartiallyKnownType foundationDateField;
        
        private foundationReasonType foundationReasonField;
        
        private bool foundationReasonFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public datePartiallyKnownType foundationDate
        {
            get
            {
                return this.foundationDateField;
            }
            set
            {
                this.foundationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public foundationReasonType foundationReason
        {
            get
            {
                return this.foundationReasonField;
            }
            set
            {
                this.foundationReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool foundationReasonSpecified
        {
            get
            {
                return this.foundationReasonFieldSpecified;
            }
            set
            {
                this.foundationReasonFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0098/5")]
    public enum foundationReasonType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0097/5")]
    public partial class namedOrganisationIdType
    {
        
        private string organisationIdCategoryField;
        
        private string organisationIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string organisationIdCategory
        {
            get
            {
                return this.organisationIdCategoryField;
            }
            set
            {
                this.organisationIdCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string organisationId
        {
            get
            {
                return this.organisationIdField;
            }
            set
            {
                this.organisationIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0097/5")]
    public partial class organisationIdentificationType
    {
        
        private uidStructureType uidField;
        
        private namedOrganisationIdType localOrganisationIdField;
        
        private namedOrganisationIdType[] otherOrganisationIdField;
        
        private string organisationNameField;
        
        private string organisationLegalNameField;
        
        private string organisationAdditionalNameField;
        
        private string legalFormField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public uidStructureType uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public namedOrganisationIdType localOrganisationId
        {
            get
            {
                return this.localOrganisationIdField;
            }
            set
            {
                this.localOrganisationIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherOrganisationId", Order=2)]
        public namedOrganisationIdType[] OtherOrganisationId
        {
            get
            {
                return this.otherOrganisationIdField;
            }
            set
            {
                this.otherOrganisationIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=3)]
        public string organisationName
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=4)]
        public string organisationLegalName
        {
            get
            {
                return this.organisationLegalNameField;
            }
            set
            {
                this.organisationLegalNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=5)]
        public string organisationAdditionalName
        {
            get
            {
                return this.organisationAdditionalNameField;
            }
            set
            {
                this.organisationAdditionalNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string legalForm
        {
            get
            {
                return this.legalFormField;
            }
            set
            {
                this.legalFormField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="organisationType", Namespace="http://www.ech.ch/xmlns/eCH-0098/5")]
    public partial class organisationType1
    {
        
        private organisationIdentificationType organisationIdentificationField;
        
        private string uidBrancheTextField;
        
        private string nOGACodeField;
        
        private foundationType foundationField;
        
        private liquidationType liquidationField;
        
        private organisationAddressType[] addressField;
        
        private contactType contactField;
        
        private string languageOfCorrespondanceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public organisationIdentificationType organisationIdentification
        {
            get
            {
                return this.organisationIdentificationField;
            }
            set
            {
                this.organisationIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string uidBrancheText
        {
            get
            {
                return this.uidBrancheTextField;
            }
            set
            {
                this.uidBrancheTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
        public string NOGACode
        {
            get
            {
                return this.nOGACodeField;
            }
            set
            {
                this.nOGACodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public foundationType foundation
        {
            get
            {
                return this.foundationField;
            }
            set
            {
                this.foundationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public liquidationType liquidation
        {
            get
            {
                return this.liquidationField;
            }
            set
            {
                this.liquidationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address", Order=5)]
        public organisationAddressType[] address
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public contactType contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=7)]
        public string languageOfCorrespondance
        {
            get
            {
                return this.languageOfCorrespondanceField;
            }
            set
            {
                this.languageOfCorrespondanceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class organisationType : IOrganisation
    {
        
        private organisationType1 organisationField;
        
        private uidregInformationType uidregInformationField;
        
        private commercialRegisterInformationType commercialRegisterInformationField;
        
        private vatRegisterInformationType vatRegisterInformationField;
        
        private leiRegisterInformationType leiRegisterInformationField;
        
        private groupRelationshipType[] groupRelationshipField;
        
        private involvedPersonType[] involvedPersonField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public organisationType1 organisation
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public uidregInformationType uidregInformation
        {
            get
            {
                return this.uidregInformationField;
            }
            set
            {
                this.uidregInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public commercialRegisterInformationType commercialRegisterInformation
        {
            get
            {
                return this.commercialRegisterInformationField;
            }
            set
            {
                this.commercialRegisterInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public vatRegisterInformationType vatRegisterInformation
        {
            get
            {
                return this.vatRegisterInformationField;
            }
            set
            {
                this.vatRegisterInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public leiRegisterInformationType leiRegisterInformation
        {
            get
            {
                return this.leiRegisterInformationField;
            }
            set
            {
                this.leiRegisterInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("groupRelationship", Order=5)]
        public groupRelationshipType[] groupRelationship
        {
            get
            {
                return this.groupRelationshipField;
            }
            set
            {
                this.groupRelationshipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("involvedPerson", Order=6)]
        public involvedPersonType[] involvedPerson
        {
            get
            {
                return this.involvedPersonField;
            }
            set
            {
                this.involvedPersonField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse-shared/2")]
    public partial class infrastructureFault : serviceFault
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse-shared/2")]
    public partial class businessFault : serviceFault
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class duplicateFault : serviceFault
    {
        
        private duplicateCandidateType[] candidatesField;
        
        private string duplicateOverrideCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("candidates", Order=0)]
        public duplicateCandidateType[] candidates
        {
            get
            {
                return this.candidatesField;
            }
            set
            {
                this.candidatesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string duplicateOverrideCode
        {
            get
            {
                return this.duplicateOverrideCodeField;
            }
            set
            {
                this.duplicateOverrideCodeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse", ConfigurationName="wseAdmin.IPublicServices")]
    public interface IPublicServices
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetOrganisationSample", ReplyAction="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetOrganisationSampleRespon" +
            "se")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.securityFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetOrganisationSamplesecuri" +
            "tyFaultFault", Name="securityFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.businessFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetOrganisationSamplebusine" +
            "ssFaultFault", Name="businessFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.infrastructureFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetOrganisationSampleinfras" +
            "tructureFaultFault", Name="infrastructureFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serviceFault))]
        System.Threading.Tasks.Task<wseAdmin.organisationType> GetOrganisationSampleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetByUID", ReplyAction="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetByUIDResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.securityFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetByUIDsecurityFaultFault", Name="securityFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.businessFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetByUIDbusinessFaultFault", Name="businessFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.infrastructureFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetByUIDinfrastructureFault" +
            "Fault", Name="infrastructureFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serviceFault))]
        System.Threading.Tasks.Task<wseAdmin.organisationType[]> GetByUIDAsync(wseAdmin.uidStructureType uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/Search", ReplyAction="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/SearchResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.securityFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/SearchsecurityFaultFault", Name="securityFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.businessFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/SearchbusinessFaultFault", Name="businessFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.infrastructureFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/SearchinfrastructureFaultFa" +
            "ult", Name="infrastructureFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serviceFault))]
        System.Threading.Tasks.Task<wseAdmin.uidEntitySearchResponse> SearchAsync(wseAdmin.uidEntityPublicSearchRequest searchParameters, wseAdmin.searchConfiguration config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateVatNumber", ReplyAction="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateVatNumberResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.securityFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateVatNumbersecurityFa" +
            "ultFault", Name="securityFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.businessFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateVatNumberbusinessFa" +
            "ultFault", Name="businessFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.infrastructureFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateVatNumberinfrastruc" +
            "tureFaultFault", Name="infrastructureFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serviceFault))]
        System.Threading.Tasks.Task<bool> ValidateVatNumberAsync(string vatNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateUID", ReplyAction="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateUIDResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.securityFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateUIDsecurityFaultFau" +
            "lt", Name="securityFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.businessFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateUIDbusinessFaultFau" +
            "lt", Name="businessFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(wseAdmin.infrastructureFault), Action="http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateUIDinfrastructureFa" +
            "ultFault", Name="infrastructureFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serviceFault))]
        System.Threading.Tasks.Task<bool> ValidateUIDAsync(string uid);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class uidEntityPublicSearchRequest
    {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("otherOrganisationId", typeof(namedOrganisationIdType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("uid", typeof(uidStructureType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("uidEntitySearchParameters", typeof(uidEntityPublicSearchParameters), Order=0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class uidEntityPublicSearchParameters
    {
        
        private string organisationNameField;
        
        private personNameType personNameField;
        
        private addressSearchType addressField;
        
        private string[] legalFormField;
        
        private uidregInformationPublicSearchType uidregInformationField;
        
        private commercialRegisterInformationSearchType commercialRegisterInformationField;
        
        private vatRegisterInformationSearchType vatRegisterInformationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string organisationName
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public personNameType personName
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public addressSearchType address
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("legalForm", Order=3)]
        public string[] legalForm
        {
            get
            {
                return this.legalFormField;
            }
            set
            {
                this.legalFormField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public uidregInformationPublicSearchType uidregInformation
        {
            get
            {
                return this.uidregInformationField;
            }
            set
            {
                this.uidregInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public commercialRegisterInformationSearchType commercialRegisterInformation
        {
            get
            {
                return this.commercialRegisterInformationField;
            }
            set
            {
                this.commercialRegisterInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public vatRegisterInformationSearchType vatRegisterInformation
        {
            get
            {
                return this.vatRegisterInformationField;
            }
            set
            {
                this.vatRegisterInformationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class personNameType
    {
        
        private string officialNameField;
        
        private string firstNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string officialName
        {
            get
            {
                return this.officialNameField;
            }
            set
            {
                this.officialNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string firstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class addressSearchType
    {
        
        private string addressLine1Field;
        
        private string addressLine2Field;
        
        private string streetField;
        
        private string houseNumberField;
        
        private uint postOfficeBoxNumberField;
        
        private bool postOfficeBoxNumberFieldSpecified;
        
        private string townField;
        
        private object[] itemsField;
        
        private ItemsChoiceType2[] itemsElementNameField;
        
        private string countryIdISO2Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string addressLine1
        {
            get
            {
                return this.addressLine1Field;
            }
            set
            {
                this.addressLine1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string addressLine2
        {
            get
            {
                return this.addressLine2Field;
            }
            set
            {
                this.addressLine2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
        public string street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=3)]
        public string houseNumber
        {
            get
            {
                return this.houseNumberField;
            }
            set
            {
                this.houseNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public uint postOfficeBoxNumber
        {
            get
            {
                return this.postOfficeBoxNumberField;
            }
            set
            {
                this.postOfficeBoxNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool postOfficeBoxNumberSpecified
        {
            get
            {
                return this.postOfficeBoxNumberFieldSpecified;
            }
            set
            {
                this.postOfficeBoxNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=5)]
        public string town
        {
            get
            {
                return this.townField;
            }
            set
            {
                this.townField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EGID", typeof(uint), Order=6)]
        [System.Xml.Serialization.XmlElementAttribute("cantonAbbreviation", typeof(cantonAbbreviationType), Order=6)]
        [System.Xml.Serialization.XmlElementAttribute("foreignZipCode", typeof(string), DataType="token", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute("municipalityId", typeof(int), Order=6)]
        [System.Xml.Serialization.XmlElementAttribute("swissZipCode", typeof(uint), Order=6)]
        [System.Xml.Serialization.XmlElementAttribute("swissZipCodeAddOn", typeof(string), Order=6)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order=7)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=8)]
        public string countryIdISO2
        {
            get
            {
                return this.countryIdISO2Field;
            }
            set
            {
                this.countryIdISO2Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse/5", IncludeInSchema=false)]
    public enum ItemsChoiceType2
    {
        
        /// <remarks/>
        EGID,
        
        /// <remarks/>
        cantonAbbreviation,
        
        /// <remarks/>
        foreignZipCode,
        
        /// <remarks/>
        municipalityId,
        
        /// <remarks/>
        swissZipCode,
        
        /// <remarks/>
        swissZipCodeAddOn,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class uidregInformationPublicSearchType
    {
        
        private uidregStatusEnterpriseDetailType uidregStatusEnterpriseDetailField;
        
        private bool uidregStatusEnterpriseDetailFieldSpecified;
        
        private bool uidregUidServiceField;
        
        private bool uidregUidServiceFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public uidregStatusEnterpriseDetailType uidregStatusEnterpriseDetail
        {
            get
            {
                return this.uidregStatusEnterpriseDetailField;
            }
            set
            {
                this.uidregStatusEnterpriseDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uidregStatusEnterpriseDetailSpecified
        {
            get
            {
                return this.uidregStatusEnterpriseDetailFieldSpecified;
            }
            set
            {
                this.uidregStatusEnterpriseDetailFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool uidregUidService
        {
            get
            {
                return this.uidregUidServiceField;
            }
            set
            {
                this.uidregUidServiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uidregUidServiceSpecified
        {
            get
            {
                return this.uidregUidServiceFieldSpecified;
            }
            set
            {
                this.uidregUidServiceFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class commercialRegisterInformationSearchType
    {
        
        private commercialRegisterStatusType commercialRegisterStatusField;
        
        private bool commercialRegisterStatusFieldSpecified;
        
        private commercialRegisterEntryStatusType commercialRegisterEntryStatusField;
        
        private bool commercialRegisterEntryStatusFieldSpecified;
        
        private System.DateTime commercialRegisterEntryDateField;
        
        private bool commercialRegisterEntryDateFieldSpecified;
        
        private System.DateTime commercialRegisterLiquidationDateField;
        
        private bool commercialRegisterLiquidationDateFieldSpecified;
        
        private commercialRegisterEnterpriseTypeType commercialRegisterEnterpriseTypeField;
        
        private bool commercialRegisterEnterpriseTypeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public commercialRegisterStatusType commercialRegisterStatus
        {
            get
            {
                return this.commercialRegisterStatusField;
            }
            set
            {
                this.commercialRegisterStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool commercialRegisterStatusSpecified
        {
            get
            {
                return this.commercialRegisterStatusFieldSpecified;
            }
            set
            {
                this.commercialRegisterStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public commercialRegisterEntryStatusType commercialRegisterEntryStatus
        {
            get
            {
                return this.commercialRegisterEntryStatusField;
            }
            set
            {
                this.commercialRegisterEntryStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool commercialRegisterEntryStatusSpecified
        {
            get
            {
                return this.commercialRegisterEntryStatusFieldSpecified;
            }
            set
            {
                this.commercialRegisterEntryStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime commercialRegisterEntryDate
        {
            get
            {
                return this.commercialRegisterEntryDateField;
            }
            set
            {
                this.commercialRegisterEntryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool commercialRegisterEntryDateSpecified
        {
            get
            {
                return this.commercialRegisterEntryDateFieldSpecified;
            }
            set
            {
                this.commercialRegisterEntryDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime commercialRegisterLiquidationDate
        {
            get
            {
                return this.commercialRegisterLiquidationDateField;
            }
            set
            {
                this.commercialRegisterLiquidationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool commercialRegisterLiquidationDateSpecified
        {
            get
            {
                return this.commercialRegisterLiquidationDateFieldSpecified;
            }
            set
            {
                this.commercialRegisterLiquidationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public commercialRegisterEnterpriseTypeType commercialRegisterEnterpriseType
        {
            get
            {
                return this.commercialRegisterEnterpriseTypeField;
            }
            set
            {
                this.commercialRegisterEnterpriseTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool commercialRegisterEnterpriseTypeSpecified
        {
            get
            {
                return this.commercialRegisterEnterpriseTypeFieldSpecified;
            }
            set
            {
                this.commercialRegisterEnterpriseTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class vatRegisterInformationSearchType
    {
        
        private vatStatusType vatStatusField;
        
        private bool vatStatusFieldSpecified;
        
        private vatEntryStatusType vatEntryStatusField;
        
        private bool vatEntryStatusFieldSpecified;
        
        private System.DateTime vatEntryDateField;
        
        private bool vatEntryDateFieldSpecified;
        
        private System.DateTime vatLiquidationDateField;
        
        private bool vatLiquidationDateFieldSpecified;
        
        private uidStructureType uidVatField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public vatStatusType vatStatus
        {
            get
            {
                return this.vatStatusField;
            }
            set
            {
                this.vatStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vatStatusSpecified
        {
            get
            {
                return this.vatStatusFieldSpecified;
            }
            set
            {
                this.vatStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public vatEntryStatusType vatEntryStatus
        {
            get
            {
                return this.vatEntryStatusField;
            }
            set
            {
                this.vatEntryStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vatEntryStatusSpecified
        {
            get
            {
                return this.vatEntryStatusFieldSpecified;
            }
            set
            {
                this.vatEntryStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime vatEntryDate
        {
            get
            {
                return this.vatEntryDateField;
            }
            set
            {
                this.vatEntryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vatEntryDateSpecified
        {
            get
            {
                return this.vatEntryDateFieldSpecified;
            }
            set
            {
                this.vatEntryDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime vatLiquidationDate
        {
            get
            {
                return this.vatLiquidationDateField;
            }
            set
            {
                this.vatLiquidationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vatLiquidationDateSpecified
        {
            get
            {
                return this.vatLiquidationDateFieldSpecified;
            }
            set
            {
                this.vatLiquidationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public uidStructureType uidVat
        {
            get
            {
                return this.uidVatField;
            }
            set
            {
                this.uidVatField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse-shared/2")]
    public partial class searchConfiguration
    {
        
        private searchMode searchModeField;
        
        private int maxNumberOfRecordsField;
        
        private bool searchNameAndAddressHistoryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public searchMode searchMode
        {
            get
            {
                return this.searchModeField;
            }
            set
            {
                this.searchModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int maxNumberOfRecords
        {
            get
            {
                return this.maxNumberOfRecordsField;
            }
            set
            {
                this.maxNumberOfRecordsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool searchNameAndAddressHistory
        {
            get
            {
                return this.searchNameAndAddressHistoryField;
            }
            set
            {
                this.searchNameAndAddressHistoryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse-shared/2")]
    public enum searchMode
    {
        
        /// <remarks/>
        Auto,
        
        /// <remarks/>
        Normal,
        
        /// <remarks/>
        Fuzzy,
        
        /// <remarks/>
        FuzzyPerson,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class uidEntitySearchResponse
    {
        
        private uidEntitySearchResultItem[] uidEntitySearchResultItemField;
        
        private object extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("uidEntitySearchResultItem", Order=0)]
        public uidEntitySearchResultItem[] uidEntitySearchResultItem
        {
            get
            {
                return this.uidEntitySearchResultItemField;
            }
            set
            {
                this.uidEntitySearchResultItemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public object extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class uidEntitySearchResultItem
    {
        
        private organisationType organisationField;
        
        private int ratingField;
        
        private bool isHistoryMatchField;
        
        private object extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public organisationType organisation
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int rating
        {
            get
            {
                return this.ratingField;
            }
            set
            {
                this.ratingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool isHistoryMatch
        {
            get
            {
                return this.isHistoryMatchField;
            }
            set
            {
                this.isHistoryMatchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public object extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IPublicServicesChannel : wseAdmin.IPublicServices, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class PublicServicesClient : System.ServiceModel.ClientBase<wseAdmin.IPublicServices>, wseAdmin.IPublicServices
    {
        
        /// <summary>
        /// Implémentez cette méthode partielle pour configurer le point de terminaison de service.
        /// </summary>
        /// <param name="serviceEndpoint">Point de terminaison à configurer</param>
        /// <param name="clientCredentials">Informations d'identification du client</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PublicServicesClient() : 
                base(PublicServicesClient.GetDefaultBinding(), PublicServicesClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPublicServices.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PublicServicesClient(EndpointConfiguration endpointConfiguration) : 
                base(PublicServicesClient.GetBindingForEndpoint(endpointConfiguration), PublicServicesClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PublicServicesClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PublicServicesClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PublicServicesClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PublicServicesClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PublicServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<wseAdmin.organisationType> GetOrganisationSampleAsync()
        {
            return base.Channel.GetOrganisationSampleAsync();
        }
        
        public System.Threading.Tasks.Task<wseAdmin.organisationType[]> GetByUIDAsync(wseAdmin.uidStructureType uid)
        {
            return base.Channel.GetByUIDAsync(uid);
        }
        
        public System.Threading.Tasks.Task<wseAdmin.uidEntitySearchResponse> SearchAsync(wseAdmin.uidEntityPublicSearchRequest searchParameters, wseAdmin.searchConfiguration config)
        {
            return base.Channel.SearchAsync(searchParameters, config);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateVatNumberAsync(string vatNumber)
        {
            return base.Channel.ValidateVatNumberAsync(vatNumber);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateUIDAsync(string uid)
        {
            return base.Channel.ValidateUIDAsync(uid);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPublicServices))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPublicServices))
            {
                return new System.ServiceModel.EndpointAddress("https://www.uid-wse.admin.ch/V5.0/PublicServices.svc");
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PublicServicesClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPublicServices);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PublicServicesClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPublicServices);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IPublicServices,
        }
    }
}
