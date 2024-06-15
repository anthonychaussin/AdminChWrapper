namespace WseAdmin.Enums
{
    /// <summary>
    /// The lei register information type registration status.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ech.ch/xmlns/eCH-0108/5")]
    public enum LeiRegisterInformationTypeRegistrationStatus
    {
        ISSUED,
        DUPLICATE,
        LAPSED,
        MERGED,
        RETIRED,
        ANNULLED,
        CANCELLED,
    }
}