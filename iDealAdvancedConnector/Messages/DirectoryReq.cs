using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

/// <summary>
/// ING.iDealAdvanced connector
/// </summary>
namespace ING.iDealAdvanced.Messages
{
    /// <summary>
    /// This class represents a Directory Request
    /// </summary>
    public partial class DirectoryReq : IRequest
    {
        /// <summary>
        /// Creation DateTimeStamp formatted to iDeal format.
        /// </summary>
        [XmlElement(ElementName = "createDateTimestamp")]
        public string createDateTimestampIdealFormatted
        {
            get { return createDateTimestamp.ToUniversalTime().ToString(Constants.iDealDateFormat); }
            set { createDateTimestamp = DateTime.ParseExact(value, Constants.iDealDateFormat, null, System.Globalization.DateTimeStyles.AssumeUniversal); }
        }

    }
}
