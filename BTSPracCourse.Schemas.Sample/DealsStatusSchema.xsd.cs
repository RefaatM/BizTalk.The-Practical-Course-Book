namespace BTSPracCourse.Schemas.Sample {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DeslReportSchema",@"StatusReport")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"StatusReport"})]
    public sealed class DealsStatusSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DeslReportSchema"" targetNamespace=""http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DeslReportSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""StatusReport"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""DealStatus"">
          <xs:complexType>
            <xs:attribute name=""FCTReferenceNumber"" type=""xs:string"" />
            <xs:attribute name=""Status"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""DealsReportReferenceNumber"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DealsStatusSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "StatusReport";
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
