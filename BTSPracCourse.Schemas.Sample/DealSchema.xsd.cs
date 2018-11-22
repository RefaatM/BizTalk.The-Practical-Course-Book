namespace BTSPracCourse.Schemas.Sample {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DealSchema",@"Deal")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Deal"})]
    public sealed class DealSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DealSchema"" targetNamespace=""http://www.MoustafaRefaat.com/BTSPracCourseSchemas/DealSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Deal"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Policies"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Policy"">
                <xs:complexType>
                  <xs:sequence />
                  <xs:attribute name=""PolicyNUM"" type=""xs:string"" use=""optional"" />
                  <xs:attribute name=""EffectiveDate"" type=""xs:string"" />
                  <xs:attribute name=""Liabilty"" type=""xs:string"" />
                  <xs:attribute name=""CTIIssueDate"" type=""xs:string"" />
                  <xs:attribute name=""Status"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Borrowers"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""Borrower"">
                <xs:complexType>
                  <xs:attribute name=""FirstName"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""Initial"" type=""xs:string"" use=""optional"" />
                  <xs:attribute name=""LastName"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""Primary"" type=""xs:boolean"" use=""required"" />
                  <xs:attribute name=""MortgageID"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Services"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Service"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo notes=""SHould be renamed to service "" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Taxes"">
                      <xs:complexType>
                        <xs:attribute name=""TaxID"" type=""xs:string"" />
                        <xs:attribute name=""Value"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                  <xs:attribute name=""ProvinceCode"" use=""required"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:length value=""2"" />
                        <xs:enumeration value=""ON"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:attribute>
                  <xs:attribute name=""BillingID"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""ExpenseOnly"" type=""xs:string"" use=""optional"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo notes=""Shall we have a different name as cost of sale"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                  <xs:attribute name=""OriginalSourceTrxNum"" type=""xs:string"" use=""optional"" />
                  <xs:attribute name=""SourceTrxNum"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""ServiceID"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""RecipientID"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""Amount"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""CustomerRefNum"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""PolicyNum"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""Division"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""ProgramNum"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""LineOfBusiness"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""ServiceCompletionDate"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Loans"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""Loan"">
                <xs:complexType>
                  <xs:sequence />
                  <xs:attribute name=""ProductType"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""Amount"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""Number"" type=""xs:string"" use=""required"" />
                  <xs:attribute name=""LoanID"" type=""xs:string"" />
                  <xs:attribute name=""PolicyNum"" type=""xs:string"" />
                  <xs:attribute name=""Term"" type=""xs:string"" />
                  <xs:attribute name=""FundingDate"" type=""xs:string"" />
                  <xs:attribute name=""Liability"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Properties"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Property"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Address"">
                      <xs:complexType>
                        <xs:attribute name=""UnitNumber"" type=""xs:string"" />
                        <xs:attribute name=""Street"" type=""xs:string"" />
                        <xs:attribute name=""City"" type=""xs:string"" />
                        <xs:attribute name=""Province"" type=""xs:string"" />
                        <xs:attribute name=""ZipCode"" type=""xs:string"" />
                        <xs:attribute name=""Country"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""Registration"">
                      <xs:complexType>
                        <xs:attribute name=""Date"" type=""xs:string"" />
                        <xs:attribute name=""Number"" type=""xs:string"" />
                        <xs:attribute name=""Status"" type=""xs:string"" />
                        <xs:attribute name=""Period"" type=""xs:string"" />
                        <xs:attribute name=""Province"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                  <xs:attribute name=""Type"" type=""xs:string"" />
                  <xs:attribute name=""Identification"" type=""xs:string"" />
                  <xs:attribute name=""LoanID"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""DealRefNum"" type=""xs:integer"" use=""required"" />
      <xs:attribute name=""SourceSystem"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""POSDate"" type=""xs:date"" use=""required"" />
      <xs:attribute name=""ClosingDate"" type=""xs:date"" use=""required"" />
      <xs:attribute name=""ProvinceCode"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""ExternalRefNum"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""FinanceType"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""OriginatingBranchTransitNum"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""MortgageCenterContact"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""BranchContact"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""SigningBranchContact"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""SourceOption"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DealSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Deal";
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
