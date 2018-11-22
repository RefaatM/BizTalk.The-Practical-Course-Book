namespace PractBTS.ErrorCollection.ErrorHandler {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.MoustafaRefaat.com/PractBTS/ErrorCollection/ErrorMessage",@"ErrorMessage")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ErrorMessage"})]
    public sealed class EHErrorSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://www.MoustafaRefaat.com/PractBTS/ErrorCollection/ErrorMessage"" targetNamespace=""http://www.MoustafaRefaat.com/PractBTS/ErrorCollection/ErrorMessage"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ErrorMessage"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""ErrorMessage"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Error"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Description"" type=""xs:string"" />
            </xs:sequence>
            <xs:attribute name=""ErrorType"" type=""xs:string"" />
            <xs:attribute name=""RoutingFailureReportID"" type=""xs:string"" />
            <xs:attribute name=""OutboundTransportLocation"" type=""xs:string"" />
            <xs:attribute name=""SendPortName"" type=""xs:string"" use=""optional"" />
            <xs:attribute name=""InboundTransportLocation"" type=""xs:string"" use=""optional"" />
            <xs:attribute name=""ReceivePortName"" type=""xs:string"" use=""optional"" />
            <xs:attribute name=""MessageType"" type=""xs:string"" />
            <xs:attribute name=""FailureCategory"" type=""xs:int"" />
            <xs:attribute name=""FailureCode"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
        <xs:element maxOccurs=""0"" name=""Message"" type=""xs:anyType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public EHErrorSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ErrorMessage";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
