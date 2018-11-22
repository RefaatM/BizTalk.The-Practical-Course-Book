namespace BTSPracCourse.Schemas.Sample {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DeslReportSchema",@"DealsReport")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DealsReport"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTSPracCourse.Schemas.Sample.DealSchema", typeof(BTSPracCourse.Schemas.Sample.DealSchema))]
    public sealed class DealsReportSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns0=""http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DealSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DeslReportSchema"" targetNamespace=""http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DeslReportSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""BTSPracCourse.Schemas.Sample.DealSchema"" namespace=""http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DealSchema"" />
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo version=""1.0"" is_envelope=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:references>
        <b:reference targetNamespace=""http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DealSchema"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""DealsReport"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""DealsReport"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:all minOccurs=""0"" maxOccurs=""1"">
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Deals"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q1=""http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DealSchema"" minOccurs=""0"" maxOccurs=""unbounded"" ref=""q1:Deal"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:all>
      <xs:attribute name=""DealReferenceNumber"" type=""xs:integer"" />
      <xs:attribute name=""DealSentReportDate"" type=""xs:dateTime"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DealsReportSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "DealsReport";
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
