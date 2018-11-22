namespace BTSPracCourse.Schemas.Sample {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.MoustafaRefaat.com/BTSPracCourseSchemasl/CustomersData",@"CustomerInfo")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CustomerInfo"})]
    public sealed class CustomersSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://www.MoustafaRefaat.com/BTSPracCourseSchemasl/CustomersData"" targetNamespace=""http://www.MoustafaRefaat.com/BTSPracCourseSchemasl/CustomersData"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CustomerInfo"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""TransactionsReport"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Customers"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Customer"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Address"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""UnitNumber"" type=""xs:string"" />
                          <xs:element minOccurs=""1"" maxOccurs=""2"" name=""Street"" type=""xs:string"" />
                          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""City"" type=""xs:string"" />
                          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Province"" type=""xs:string"" />
                          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Country"" type=""xs:string"" />
                          <xs:element minOccurs=""1"" maxOccurs=""2"" name=""PhoneNumber"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" maxOccurs=""2"" name=""FaxNumber"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                  <xs:attribute name=""CustomerID"" use=""required"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:minLength value=""1"" />
                        <xs:maxLength value=""32"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:attribute>
                  <xs:attribute name=""ParentID"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""RecType"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""ShortName"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""TransitNum"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""LocationName"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""PostalCode"" type=""xs:string"" use=""required"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""CustomerUpdateReferenceNumber"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CustomersSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CustomerInfo";
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
