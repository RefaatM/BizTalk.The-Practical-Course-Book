namespace BTSPracCourse.Schemas.Sample {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.MoustafaRefaat.com/DrugPriceSchema",@"Prices")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Prices"})]
    public sealed class DrugPriceSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://www.MoustafaRefaat.com/DrugPriceSchema"" targetNamespace=""http://www.MoustafaRefaat.com/DrugPriceSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo standard=""Flat File"" root_reference=""Prices"" default_pad_char="" "" pad_char_type=""char"" count_positions_by_byte=""false"" parser_optimization=""speed"" lookahead_depth=""3"" suppress_empty_nodes=""false"" generate_empty_nodes=""true"" allow_early_termination=""false"" early_terminate_optional_fields=""false"" allow_message_breakup_of_infix_root=""false"" compile_parse_tables=""false"" />
      <schemaEditorExtension:schemaInfo namespaceAlias=""b"" extensionClass=""Microsoft.BizTalk.FlatFileExtension.FlatFileExtension"" standardName=""Flat File"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Prices"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" sequence_number=""1"" rootTypeName=""Prices"" child_delimiter_type=""hex"" child_delimiter=""0x0D 0x0A"" child_order=""postfix"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:annotation>
          <xs:appinfo>
            <b:groupInfo sequence_number=""0"" />
          </xs:appinfo>
        </xs:annotation>
        <xs:element name=""DrugPrice"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo sequence_number=""1"" structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" child_delimiter_type=""char"" child_delimiter="","" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:annotation>
                <xs:appinfo>
                  <b:groupInfo sequence_number=""0"" />
                </xs:appinfo>
              </xs:annotation>
              <xs:element name=""DIN_NBR"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo sequence_number=""1"" justification=""right"" pad_char_type=""none"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Package_Size"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo sequence_number=""2"" justification=""left"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""NewAMT"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo sequence_number=""3"" structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType />
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DrugPriceSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Prices";
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
