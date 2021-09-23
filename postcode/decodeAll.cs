/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
	[XmlRoot(ElementName = "Callsign", Namespace = "http://xmldata.qrz.com")]
	public class Callsign
	{
		[XmlElement(ElementName = "call", Namespace = "http://xmldata.qrz.com")]
		public string Call { get; set; }
		[XmlElement(ElementName = "dxcc", Namespace = "http://xmldata.qrz.com")]
		public string Dxcc { get; set; }
		[XmlElement(ElementName = "nickname", Namespace = "http://xmldata.qrz.com")]
		public string Nickname { get; set; }
		[XmlElement(ElementName = "fname", Namespace = "http://xmldata.qrz.com")]
		public string Fname { get; set; }
		[XmlElement(ElementName = "name", Namespace = "http://xmldata.qrz.com")]
		public string Name { get; set; }
		[XmlElement(ElementName = "addr1", Namespace = "http://xmldata.qrz.com")]
		public string Addr1 { get; set; }
		[XmlElement(ElementName = "addr2", Namespace = "http://xmldata.qrz.com")]
		public string Addr2 { get; set; }
		[XmlElement(ElementName = "zip", Namespace = "http://xmldata.qrz.com")]
		public string Zip { get; set; }
		[XmlElement(ElementName = "country", Namespace = "http://xmldata.qrz.com")]
		public string Country { get; set; }
		[XmlElement(ElementName = "lat", Namespace = "http://xmldata.qrz.com")]
		public string Lat { get; set; }
		[XmlElement(ElementName = "lon", Namespace = "http://xmldata.qrz.com")]
		public string Lon { get; set; }
		[XmlElement(ElementName = "grid", Namespace = "http://xmldata.qrz.com")]
		public string Grid { get; set; }
		[XmlElement(ElementName = "ccode", Namespace = "http://xmldata.qrz.com")]
		public string Ccode { get; set; }
		[XmlElement(ElementName = "land", Namespace = "http://xmldata.qrz.com")]
		public string Land { get; set; }
		[XmlElement(ElementName = "email", Namespace = "http://xmldata.qrz.com")]
		public string Email { get; set; }
		[XmlElement(ElementName = "u_views", Namespace = "http://xmldata.qrz.com")]
		public string U_views { get; set; }
		[XmlElement(ElementName = "bio", Namespace = "http://xmldata.qrz.com")]
		public string Bio { get; set; }
		[XmlElement(ElementName = "biodate", Namespace = "http://xmldata.qrz.com")]
		public string Biodate { get; set; }
		[XmlElement(ElementName = "moddate", Namespace = "http://xmldata.qrz.com")]
		public string Moddate { get; set; }
		[XmlElement(ElementName = "eqsl", Namespace = "http://xmldata.qrz.com")]
		public string Eqsl { get; set; }
		[XmlElement(ElementName = "mqsl", Namespace = "http://xmldata.qrz.com")]
		public string Mqsl { get; set; }
		[XmlElement(ElementName = "cqzone", Namespace = "http://xmldata.qrz.com")]
		public string Cqzone { get; set; }
		[XmlElement(ElementName = "ituzone", Namespace = "http://xmldata.qrz.com")]
		public string Ituzone { get; set; }
		[XmlElement(ElementName = "lotw", Namespace = "http://xmldata.qrz.com")]
		public string Lotw { get; set; }
		[XmlElement(ElementName = "user", Namespace = "http://xmldata.qrz.com")]
		public string User { get; set; }
		[XmlElement(ElementName = "geoloc", Namespace = "http://xmldata.qrz.com")]
		public string Geoloc { get; set; }
		[XmlElement(ElementName = "name_fmt", Namespace = "http://xmldata.qrz.com")]
		public string Name_fmt { get; set; }
	}

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
		[XmlElement(ElementName = "Callsign", Namespace = "http://xmldata.qrz.com")]
		public Callsign Callsign { get; set; }
		[XmlElement(ElementName = "Session", Namespace = "http://xmldata.qrz.com")]
		public Session Session { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
		[XmlAttribute(AttributeName = "version")]
		public string Version { get; set; }
	}

}

