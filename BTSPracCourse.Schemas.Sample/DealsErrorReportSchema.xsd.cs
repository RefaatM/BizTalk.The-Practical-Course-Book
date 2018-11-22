namespace BTSPracCourse.Schemas.Sample {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DeslReportSchema",@"DealsErrorReport")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DealsErrorReport"})]
    public sealed class DealsErrorReportSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DeslReportSchema"" targetNamespace=""http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DeslReportSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""DealsErrorReport"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""Error"">
          <xs:complexType>
            <xs:attribute name=""DealRefNumber"" type=""xs:string"" />
            <xs:attribute name=""ErrorCode"" type=""xs:string"" />
            <xs:attribute name=""ErrorMsg"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""ErrorReportID"" type=""xs:string"" />
      <xs:attribute name=""DealsReportReferenceNumber"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DealsErrorReportSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "DealsErrorReport";
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
