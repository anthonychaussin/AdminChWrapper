namespace AdminChWrapper.Models
{
    /// <summary>
    /// The address.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the line1.
        /// </summary>
        public string? Line1 { get; set; }

        /// <summary>
        /// Gets or sets the line2.
        /// </summary>
        public string? Line2 { get; set; }

        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        public string? Street { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        public string? Number { get; set; }

        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        public string? Town { get; set; }

        /// <summary>
        /// To the string.
        /// </summary>
        /// <returns>A String.</returns>
        public override String ToString()
        {
            return $"{Line1}, {(Line2 is not null ? (Line2 + ", ") : "")}{Street} {Number}, {Town}";
        }
    }
}