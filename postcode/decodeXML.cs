using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace postcode
{
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(QRZDatabase));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (QRZDatabase)serializer.Deserialize(reader);
	// }

	/* 
	 Licensed under the Apache License, Version 2.0

	 http://www.apache.org/licenses/LICENSE-2.0
	 */
	using System;
	using System.Xml.Serialization;
	using System.Collections.Generic;
	namespace Xml3CSharp
	{
		[XmlRoot(ElementName = "Session", Namespace = "http://xmldata.qrz.com")]
		public class Session
		{
			[XmlElement(ElementName = "Key", Namespace = "http://xmldata.qrz.com")]
			public string Key { get; set; }
			[XmlElement(ElementName = "Count", Namespace = "http://xmldata.qrz.com")]
			public string Count { get; set; }
			[XmlElement(ElementName = "SubExp", Namespace = "http://xmldata.qrz.com")]
			public string SubExp { get; set; }
			[XmlElement(ElementName = "GMTime", Namespace = "http://xmldata.qrz.com")]
			public string GMTime { get; set; }
			[XmlElement(ElementName = "Remark", Namespace = "http://xmldata.qrz.com")]
			public string Remark { get; set; }
		}

		[XmlRoot(ElementName = "QRZDatabase", Namespace = "http://xmldata.qrz.com")]
		public class QRZDatabase
		{
			[XmlElement(ElementName = "Session", Namespace = "http://xmldata.qrz.com")]
			public Session Session { get; set; }
			[XmlAttribute(AttributeName = "xmlns")]
			public string Xmlns { get; set; }
			[XmlAttribute(AttributeName = "version")]
			public string Version { get; set; }
		}

	}


}
