
#pragma warning disable 162

namespace AutoErrorHandler
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_RecieveError",
        new System.Type[]{
            typeof(AutoErrorHandler.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ErrorsPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ErrorsPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ErrorsPortType(ErrorsPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ErrorsPortType p = new ErrorsPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_RecieveError = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_RecieveError",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ErrorsPortType),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_RecieveError" ] = Operation_RecieveError;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __AutoErrorHandler_GTErrorSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static AutoErrorHandler.GTErrorSchema _schema = new AutoErrorHandler.GTErrorSchema();

        public __AutoErrorHandler_GTErrorSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "AutoErrorHandler.GTErrorSchema",
        new System.Type[]{
            typeof(AutoErrorHandler.GTErrorSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__AutoErrorHandler_GTErrorSchema__)
        },
        0,
        @"http://AutoErrorHandler.GTErrorSchema#ErrorMessage"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_AutoErrorHandler_GTErrorSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __AutoErrorHandler_GTErrorSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __AutoErrorHandler_GTErrorSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_AutoErrorHandler_GTErrorSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(AutoErrorHandler.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ArchivePortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ArchivePortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ArchivePortType(ArchivePortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ArchivePortType p = new ArchivePortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ArchivePortType),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(AutoErrorHandler.__messagetype_AutoErrorHandler_GTErrorSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ErrorMsgPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ErrorMsgPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ErrorMsgPortType(ErrorMsgPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ErrorMsgPortType p = new ErrorMsgPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ErrorMsgPortType),
            typeof(__messagetype_AutoErrorHandler_GTErrorSchema),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(AutoErrorHandler.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_DynamixSend : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_DynamixSend(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_DynamixSend(PortType_DynamixSend p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_DynamixSend p = new PortType_DynamixSend(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_DynamixSend),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 396 "C:\XTProjects\CODE\BizTalk\AutoErrorHandler\AutoErrorHandler\ErrorHandlerLogic.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ErrorsPort", "Operation_RecieveError", 0, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ActivationPredicateAttribute(
        0,
        new bool[] {
            true
        },
        new System.Type[] {
            typeof(ErrorReport.ErrorType)
        },
        new Microsoft.XLANGs.BaseTypes.EXLangPredicateOperator[] {
            Microsoft.XLANGs.BaseTypes.EXLangPredicateOperator.eOpExists
        },
        new System.Object[] {
            0
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(AutoErrorHandler.ErrorsPortType),
            typeof(AutoErrorHandler.PortType_DynamixSend),
            typeof(AutoErrorHandler.ErrorMsgPortType)
        },
        new System.String[] {
            "ErrorsPort",
            "ArchiveDynmicPort",
            "ErrorMessagePort"
        },
        new System.Type[] {
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class ErrorHandlerLogic : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ErrorHandlerLogic));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static ErrorHandlerLogic()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 3, 3),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment4), 1, 3, 4),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment5), 1, 4, 5),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment6), 1, 4, 6),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment7), 1, 5, 7),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment8), 1, 5, 8),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment9), 1, 6, 9),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment10), 1, 6, 10),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment11), 1, 2, 11)
            };

            _Locks = 1;
            _rootContext = new __ErrorHandlerLogic_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[7];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ErrorHandlerLogic(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ErrorHandlerLogic", tracker)
        {
            ConstructorHelper();
        }

        public ErrorHandlerLogic(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ErrorHandlerLogic")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>50fe447b-f5bd-4159-b889-2a8157dff756</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>1faf0c64-57cd-4a3f-bd4a-42e3a79a96fa</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_Main Scope</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>ca6a9015-ac86-4081-a849-cf18b163a680</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_ErrorMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DNFPredicateShape</shapeType>      <ShapeID>2594645d-d308-405e-b6b6-00ce16676c74</ShapeID>      <ParentLink>Receive_DNFPredicate</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>b753edac-a087-49f2-bcde-4a55bad23ceb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_SetTheErrors</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>dd29a6e6-6cd3-4336-923f-3bea5ec6a865</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Scope_MessageType</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a75a30b1-8651-4cf8-84be-86dc18342a9f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_MessageType</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>8db7a76a-111c-4ccb-be6c-6992f4550c70</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_MessageTypeNotSet</shapeText>                      <ExceptionType>Microsoft.XLANGs.BaseTypes.MissingPropertyException</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>0aa8d45a-7fd3-4f01-a444-2d732fc387ad</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_UndefinedMessageType</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>841ed7dd-b9c2-42c9-be9b-b3aa87e88e02</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Scope_Receiver</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>72c7552f-99f5-484f-9434-a887fa225dac</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_ReceiverInfo</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>7178b8b3-80d3-4377-be98-0359f4cd80b6</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_Receiver</shapeText>                      <ExceptionType>General Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>9c6e0e16-aac5-47cb-94e7-29c088251fe4</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_NoReceiver</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>7ffc3a6a-dc15-4ecd-a1ad-7ade80c33ecc</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Scope_SendPort</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>0281cfe6-9ddd-417b-807f-598d9876b014</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_SendPort</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>743418cf-6a24-4615-9cca-50c9177f8772</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_NoSendPort</shapeText>                      <ExceptionType>General Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>49c93231-7e9d-4a54-9399-4f2e93a6ef41</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_NoSendPort</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>5fbb41b4-1963-4897-be10-5cde1dfbc835</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_SetDynamicPort</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>307fd43c-f5c3-4daa-9448-d4cb004af4d2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_Archive</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>68f1f996-7940-444d-bdd2-817b11489515</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Scope_SetMessageData</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>8dfa8d8c-3cc3-44e6-b959-73bc931b8357</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_SetMessgae</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>635308d3-eef9-4cce-b72a-8e30829d137e</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_SetMessageData</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>fd37fff4-e28f-4e48-a00a-0efe251eaf4d</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_SetMessageException</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a6041da3-b188-4f3e-b24f-05c762ea930f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_ErrorReportMsg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>03e73e15-67d5-41d5-bc67-98a04d9accee</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_ErrorReportMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>3c2ffff2-77f4-40c4-8eb7-8e4e27ffd1cb</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>c95ce7bd-1385-4ed7-90cb-0e1917a3e0ce</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_ErrorReport</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>7394c9d9-2840-4377-b19e-faaad6e5d8a6</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_MainAll</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>3b602618-4c79-4364-9acc-e0e091533224</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_Excption</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow>
<Metadata>

<TrkMetadata>
<ActionName>'ErrorHandlerLogic'</ActionName><IsAtomic>0</IsAtomic><Line>396</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>410</Line><Position>13</Position><ShapeID>'1faf0c64-57cd-4a3f-bd4a-42e3a79a96fa'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>415</Line><Position>62</Position><ShapeID>'ca6a9015-ac86-4081-a849-cf18b163a680'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>418</Line><Position>30</Position><ShapeID>'b753edac-a087-49f2-bcde-4a55bad23ceb'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope34'</ActionName><IsAtomic>0</IsAtomic><Line>433</Line><Position>21</Position><ShapeID>'dd29a6e6-6cd3-4336-923f-3bea5ec6a865'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>438</Line><Position>56</Position><ShapeID>'a75a30b1-8651-4cf8-84be-86dc18342a9f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>444</Line><Position>29</Position><ShapeID>'8db7a76a-111c-4ccb-be6c-6992f4550c70'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>447</Line><Position>60</Position><ShapeID>'0aa8d45a-7fd3-4f01-a444-2d732fc387ad'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope35'</ActionName><IsAtomic>0</IsAtomic><Line>453</Line><Position>21</Position><ShapeID>'841ed7dd-b9c2-42c9-be9b-b3aa87e88e02'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>459</Line><Position>69</Position><ShapeID>'72c7552f-99f5-484f-9434-a887fa225dac'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>465</Line><Position>29</Position><ShapeID>'7178b8b3-80d3-4377-be98-0359f4cd80b6'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>469</Line><Position>73</Position><ShapeID>'9c6e0e16-aac5-47cb-94e7-29c088251fe4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope36'</ActionName><IsAtomic>0</IsAtomic><Line>475</Line><Position>21</Position><ShapeID>'7ffc3a6a-dc15-4ecd-a1ad-7ade80c33ecc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>480</Line><Position>70</Position><ShapeID>'0281cfe6-9ddd-417b-807f-598d9876b014'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>486</Line><Position>29</Position><ShapeID>'743418cf-6a24-4615-9cca-50c9177f8772'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>489</Line><Position>74</Position><ShapeID>'49c93231-7e9d-4a54-9399-4f2e93a6ef41'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>495</Line><Position>75</Position><ShapeID>'5fbb41b4-1963-4897-be10-5cde1dfbc835'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>497</Line><Position>21</Position><ShapeID>'307fd43c-f5c3-4daa-9448-d4cb004af4d2'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope37'</ActionName><IsAtomic>0</IsAtomic><Line>499</Line><Position>21</Position><ShapeID>'68f1f996-7940-444d-bdd2-817b11489515'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>504</Line><Position>46</Position><ShapeID>'8dfa8d8c-3cc3-44e6-b959-73bc931b8357'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>510</Line><Position>29</Position><ShapeID>'635308d3-eef9-4cce-b72a-8e30829d137e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>513</Line><Position>50</Position><ShapeID>'fd37fff4-e28f-4e48-a00a-0efe251eaf4d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>519</Line><Position>21</Position><ShapeID>'a6041da3-b188-4f3e-b24f-05c762ea930f'</ShapeID>
<Messages>
	<MsgInfo><name>ErrorReportMsg</name><part>part</part><schema>AutoErrorHandler.GTErrorSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>527</Line><Position>21</Position><ShapeID>'c95ce7bd-1385-4ed7-90cb-0e1917a3e0ce'</ShapeID>
<Messages>
	<MsgInfo><name>ErrorReportMsg</name><part>part</part><schema>AutoErrorHandler.GTErrorSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>532</Line><Position>21</Position><ShapeID>'7394c9d9-2840-4377-b19e-faaad6e5d8a6'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>535</Line><Position>59</Position><ShapeID>'3b602618-4c79-4364-9acc-e0e091533224'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='049c8522-6b0d-4236-9e83-61fe41a6d4a1' LowerBound='1.1' HigherBound='179.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='AutoErrorHandler' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='df559828-0bbb-4397-89ec-6bca410a20cb' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ErrorsPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='8534c551-d073-429a-90ef-eaf8088b26c1' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_RecieveError' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='340572fd-6004-4660-bd5b-dc8d9c006580' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='a6c1ba3d-a0b4-4130-9ca9-16a03a01abf4' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ArchivePortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='b7938f75-59e0-4ae0-a0a2-1b18b72829cf' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='d42cc6e2-d243-4348-9059-750c47399e4e' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='3dd32176-8f78-4dbf-bfd4-d417ab321c28' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ErrorMsgPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='82111c34-2c74-44b7-89fa-0c0b843d2075' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='bc0e34af-220a-4a98-afa4-cd02bd3665e0' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.26'>
                    <om:Property Name='Ref' Value='AutoErrorHandler.GTErrorSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='7356bd4e-a38f-4060-8541-903d542ac3be' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_DynamixSend' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='9a1df924-eeb7-44d0-b337-135e4d170e7d' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='db3168d2-58ac-4a87-8680-a3708386464d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='4791abb0-b33f-450f-9598-a4df8d36f02a' ParentLink='Module_ServiceDeclaration' LowerBound='32.1' HigherBound='178.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ErrorHandlerLogic' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='043abc7a-7389-4b57-8d03-89902dad7d74' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='ErrorMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TheError' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c865ac34-eb08-4cc1-96fa-87c46a71a6b8' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='41.1' HigherBound='42.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ErrorMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4960b62d-4fac-476d-9f36-2e4437b4953b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='42.1' HigherBound='43.1'>
                <om:Property Name='Type' Value='AutoErrorHandler.GTErrorSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ErrorReportMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='50fe447b-f5bd-4159-b889-2a8157dff756' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Scope' OID='1faf0c64-57cd-4a3f-bd4a-42e3a79a96fa' ParentLink='ServiceBody_Statement' LowerBound='46.1' HigherBound='176.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_Main Scope' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Receive' OID='ca6a9015-ac86-4081-a849-cf18b163a680' ParentLink='ComplexStatement_Statement' LowerBound='51.1' HigherBound='54.1'>
                        <om:Property Name='Activate' Value='True' />
                        <om:Property Name='PortName' Value='ErrorsPort' />
                        <om:Property Name='MessageName' Value='ErrorMsg' />
                        <om:Property Name='OperationName' Value='Operation_RecieveError' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Receive_ErrorMessage' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='DNFPredicate' OID='2594645d-d308-405e-b6b6-00ce16676c74' ParentLink='Receive_DNFPredicate'>
                            <om:Property Name='LHS' Value='ErrorReport.ErrorType' />
                            <om:Property Name='Grouping' Value='AND' />
                            <om:Property Name='Operator' Value='Exists' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='b753edac-a087-49f2-bcde-4a55bad23ceb' ParentLink='ComplexStatement_Statement' LowerBound='54.1' HigherBound='69.1'>
                        <om:Property Name='Expression' Value='TheError = new ErrorMessage();&#xD;&#xA;TheError.Error.ErrorType = ErrorMsg(ErrorReport.ErrorType);&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;ErrorType = &quot;+TheError.Error.ErrorType);&#xD;&#xA;TheError.Error.Description = ErrorMsg(ErrorReport.Description);&#xD;&#xA;&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;TheError.Error.Description = &quot;+TheError.Error.Description);&#xD;&#xA;TheError.Error.FailureCategory = 0 ;//ErrorMsg(ErrorReport.FailureCategory);&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;FailureCategory = &quot;+TheError.Error.FailureCategory.ToString());&#xD;&#xA;&#xD;&#xA;TheError.Error.FailureCode= ErrorMsg(ErrorReport.FailureCode);&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;FailureCode = &quot;+TheError.Error.FailureCode);&#xD;&#xA;TheError.Error.RoutingFailureReportID = ErrorMsg(ErrorReport.RoutingFailureReportID);&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;RoutingFailureReportID = &quot;+TheError.Error.RoutingFailureReportID);&#xD;&#xA;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Expression_SetTheErrors' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Scope' OID='dd29a6e6-6cd3-4336-923f-3bea5ec6a865' ParentLink='ComplexStatement_Statement' LowerBound='69.1' HigherBound='89.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Scope_MessageType' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='a75a30b1-8651-4cf8-84be-86dc18342a9f' ParentLink='ComplexStatement_Statement' LowerBound='74.1' HigherBound='77.1'>
                            <om:Property Name='Expression' Value='TheError.Error.MessageType = ErrorMsg(ErrorReport.MessageType);&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;MessageType = &quot;+TheError.Error.MessageType);&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_MessageType' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Catch' OID='8db7a76a-111c-4ccb-be6c-6992f4550c70' ParentLink='Scope_Catch' LowerBound='80.1' HigherBound='87.1'>
                            <om:Property Name='ExceptionName' Value='vExcp' />
                            <om:Property Name='ExceptionType' Value='Microsoft.XLANGs.BaseTypes.MissingPropertyException' />
                            <om:Property Name='IsFaultMessage' Value='False' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='CatchException_MessageTypeNotSet' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='VariableAssignment' OID='0aa8d45a-7fd3-4f01-a444-2d732fc387ad' ParentLink='Catch_Statement' LowerBound='83.1' HigherBound='86.1'>
                                <om:Property Name='Expression' Value='TheError.Error.MessageType = &quot;Undefined&quot;;&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;MessageType = &quot;+TheError.Error.MessageType);&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Expression_UndefinedMessageType' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Scope' OID='841ed7dd-b9c2-42c9-be9b-b3aa87e88e02' ParentLink='ComplexStatement_Statement' LowerBound='89.1' HigherBound='111.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Scope_Receiver' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='72c7552f-99f5-484f-9434-a887fa225dac' ParentLink='ComplexStatement_Statement' LowerBound='94.1' HigherBound='98.1'>
                            <om:Property Name='Expression' Value='//The optional one&#xD;&#xA;TheError.Error.InboundTransportLocation = ErrorMsg(ErrorReport.InboundTransportLocation);&#xD;&#xA;TheError.Error.ReceivePortName = ErrorMsg(ErrorReport.ReceivePortName);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_ReceiverInfo' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Catch' OID='7178b8b3-80d3-4377-be98-0359f4cd80b6' ParentLink='Scope_Catch' LowerBound='101.1' HigherBound='109.1'>
                            <om:Property Name='ExceptionType' Value='General Exception' />
                            <om:Property Name='IsFaultMessage' Value='False' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='CatchException_Receiver' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='VariableAssignment' OID='9c6e0e16-aac5-47cb-94e7-29c088251fe4' ParentLink='Catch_Statement' LowerBound='104.1' HigherBound='108.1'>
                                <om:Property Name='Expression' Value='//The optional one&#xD;&#xA;TheError.Error.InboundTransportLocation = System.String.Empty;&#xD;&#xA;TheError.Error.ReceivePortName = System.String.Empty;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Expression_NoReceiver' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Scope' OID='7ffc3a6a-dc15-4ecd-a1ad-7ade80c33ecc' ParentLink='ComplexStatement_Statement' LowerBound='111.1' HigherBound='131.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Scope_SendPort' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='0281cfe6-9ddd-417b-807f-598d9876b014' ParentLink='ComplexStatement_Statement' LowerBound='116.1' HigherBound='119.1'>
                            <om:Property Name='Expression' Value='TheError.Error.OutboundTransportLocation = ErrorMsg(ErrorReport.OutboundTransportLocation);&#xD;&#xA;TheError.Error.SendPortName = ErrorMsg(ErrorReport.SendPortName);&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_SendPort' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Catch' OID='743418cf-6a24-4615-9cca-50c9177f8772' ParentLink='Scope_Catch' LowerBound='122.1' HigherBound='129.1'>
                            <om:Property Name='ExceptionType' Value='General Exception' />
                            <om:Property Name='IsFaultMessage' Value='False' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='CatchException_NoSendPort' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='VariableAssignment' OID='49c93231-7e9d-4a54-9399-4f2e93a6ef41' ParentLink='Catch_Statement' LowerBound='125.1' HigherBound='128.1'>
                                <om:Property Name='Expression' Value='TheError.Error.OutboundTransportLocation = System.String.Empty;&#xD;&#xA;TheError.Error.SendPortName = System.String.Empty;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Expression_NoSendPort' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='5fbb41b4-1963-4897-be10-5cde1dfbc835' ParentLink='ComplexStatement_Statement' LowerBound='131.1' HigherBound='133.1'>
                        <om:Property Name='Expression' Value='ArchiveDynmicPort(Microsoft.XLANGs.BaseTypes.Address) = @&quot;file://C:\XTProjects\CODE\BizTalk\AutoErrorHandler\DataFolders\BadMessages\&quot;+ErrorMsg(BTS.MessageID)+&quot;.bad&quot; ;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Expression_SetDynamicPort' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Send' OID='307fd43c-f5c3-4daa-9448-d4cb004af4d2' ParentLink='ComplexStatement_Statement' LowerBound='133.1' HigherBound='135.1'>
                        <om:Property Name='PortName' Value='ArchiveDynmicPort' />
                        <om:Property Name='MessageName' Value='ErrorMsg' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_Archive' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Scope' OID='68f1f996-7940-444d-bdd2-817b11489515' ParentLink='ComplexStatement_Statement' LowerBound='135.1' HigherBound='155.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Scope_SetMessageData' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='8dfa8d8c-3cc3-44e6-b959-73bc931b8357' ParentLink='ComplexStatement_Statement' LowerBound='140.1' HigherBound='143.1'>
                            <om:Property Name='Expression' Value='TheError.Message = @&quot;C:\XTProjects\CODE\BizTalk\AutoErrorHandler\DataFolders\BadMessages\&quot;+ErrorMsg(BTS.MessageID)+&quot;.bad&quot;;&#xD;&#xA;System.Diagnostics.Debug.WriteLine(&quot;OutFileName = &quot;+TheError.Message.ToString());&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_SetMessgae' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Catch' OID='635308d3-eef9-4cce-b72a-8e30829d137e' ParentLink='Scope_Catch' LowerBound='146.1' HigherBound='153.1'>
                            <om:Property Name='ExceptionName' Value='vexcxp' />
                            <om:Property Name='ExceptionType' Value='System.Exception' />
                            <om:Property Name='IsFaultMessage' Value='False' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='CatchException_SetMessageData' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='VariableAssignment' OID='fd37fff4-e28f-4e48-a00a-0efe251eaf4d' ParentLink='Catch_Statement' LowerBound='149.1' HigherBound='152.1'>
                                <om:Property Name='Expression' Value='TheError.Message = System.String.Empty;&#xD;&#xA;System.Diagnostics.Debug.WriteLine(&quot;could not assign the messgae: \n&quot;+vexcxp.ToString());&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Expression_SetMessageException' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Construct' OID='a6041da3-b188-4f3e-b24f-05c762ea930f' ParentLink='ComplexStatement_Statement' LowerBound='155.1' HigherBound='163.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_ErrorReportMsg' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageAssignment' OID='03e73e15-67d5-41d5-bc67-98a04d9accee' ParentLink='ComplexStatement_Statement' LowerBound='158.1' HigherBound='162.1'>
                            <om:Property Name='Expression' Value='ErrorReportMsg = TheError.ToXML();&#xD;&#xA;System.Diagnostics.Debug.WriteLine(TheError.ToString());&#xD;&#xA;&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_ErrorReportMsg' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='3c2ffff2-77f4-40c4-8eb7-8e4e27ffd1cb' ParentLink='Construct_MessageRef' LowerBound='156.31' HigherBound='156.45'>
                            <om:Property Name='Ref' Value='ErrorReportMsg' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='c95ce7bd-1385-4ed7-90cb-0e1917a3e0ce' ParentLink='ComplexStatement_Statement' LowerBound='163.1' HigherBound='165.1'>
                        <om:Property Name='PortName' Value='ErrorMessagePort' />
                        <om:Property Name='MessageName' Value='ErrorReportMsg' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_ErrorReport' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Catch' OID='7394c9d9-2840-4377-b19e-faaad6e5d8a6' ParentLink='Scope_Catch' LowerBound='168.1' HigherBound='174.1'>
                        <om:Property Name='ExceptionName' Value='excp' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_MainAll' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='3b602618-4c79-4364-9acc-e0e091533224' ParentLink='Catch_Statement' LowerBound='171.1' HigherBound='173.1'>
                            <om:Property Name='Expression' Value='System.Diagnostics.Debug.WriteLine(&quot;Exception Thrown&quot;+excp.ToString());' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_Excption' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='67f475f2-af49-40d7-b7ec-11199840156e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='35.1' HigherBound='37.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='3' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='AutoErrorHandler.ErrorsPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ErrorsPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='bf8a78d1-f064-4d80-b29e-1921a9ba954f' ParentLink='PortDeclaration_CLRAttribute' LowerBound='35.1' HigherBound='36.1'>
                    <om:Property Name='DirectBindingType' Value='MessageBox' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='449641a9-c187-4722-bb6b-dd06d4be3509' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='37.1' HigherBound='39.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='130' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='AutoErrorHandler.ErrorMsgPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ErrorMessagePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='aa52612c-ac49-4ecf-8085-1a43d879bdf6' ParentLink='PortDeclaration_CLRAttribute' LowerBound='37.1' HigherBound='38.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='0da2a748-fc1c-47ab-ba79-ca52ea07b624' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='39.1' HigherBound='41.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='95' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='AutoErrorHandler.PortType_DynamixSend' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ArchiveDynmicPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='PhysicalBindingAttribute' OID='9fe71975-845c-48c6-b881-0dbd27fa5c69' ParentLink='PortDeclaration_CLRAttribute' LowerBound='39.1' HigherBound='40.1'>
                    <om:Property Name='InPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLReceive' />
                    <om:Property Name='OutPipeline' Value='Microsoft.BizTalk.DefaultPipelines.PassThruTransmit' />
                    <om:Property Name='TransportType' Value='HTTP' />
                    <om:Property Name='URI' Value='http://tempURI' />
                    <om:Property Name='IsDynamic' Value='True' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ErrorHandlerLogic_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ErrorHandlerLogic_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ErrorHandlerLogic")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                ErrorHandlerLogic __svc__ = (ErrorHandlerLogic)_service;
                __ErrorHandlerLogic_root_0 __ctx0__ = (__ErrorHandlerLogic_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ErrorMessagePort != null)
                {
                    __svc__.ErrorMessagePort.Close(this, null);
                    __svc__.ErrorMessagePort = null;
                }
                if (__svc__.ErrorsPort != null)
                {
                    __svc__.ErrorsPort.Close(this, null);
                    __svc__.ErrorsPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __ErrorHandlerLogic_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __ErrorHandlerLogic_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ErrorHandlerLogic")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                ErrorHandlerLogic __svc__ = (ErrorHandlerLogic)_service;
                __ErrorHandlerLogic_root_0 __ctx0__ = (__ErrorHandlerLogic_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ArchiveDynmicPort != null)
                {
                    __svc__.ArchiveDynmicPort.Close(this, null);
                    __svc__.ArchiveDynmicPort = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("ErrorMsg")]
            public __messagetype_System_Xml_XmlDocument __ErrorMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ErrorReportMsg")]
            public __messagetype_AutoErrorHandler_GTErrorSchema __ErrorReportMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TheError")]
            internal ErrorMessage __TheError;
        }


        [System.SerializableAttribute]
        public class ____scope33_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope33_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope33")
            {
            }

            public override int Index { get { return 2; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Exception))
                    {
                        __seg__ = _service._segments[11];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                ErrorHandlerLogic __svc__ = (ErrorHandlerLogic)_service;
                ____scope33_2 __ctx2__ = (____scope33_2)(__svc__._stateMgrs[2]);
                __ErrorHandlerLogic_1 __ctx1__ = (__ErrorHandlerLogic_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__TheError = null;
                if (__ctx1__ != null && __ctx1__.__ErrorReportMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ErrorReportMsg);
                    __ctx1__.__ErrorReportMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__ErrorMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ErrorMsg);
                    __ctx1__.__ErrorMsg = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__excp_0 = null;
                base.Finally();
            }

            internal object __exv__;
            internal System.Exception __excp_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }


        [System.SerializableAttribute]
        public class ____scope34_3 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope34_3(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope34")
            {
            }

            public override int Index { get { return 3; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[3]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[3]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is Microsoft.XLANGs.BaseTypes.MissingPropertyException))
                    {
                        __seg__ = _service._segments[4];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                ErrorHandlerLogic __svc__ = (ErrorHandlerLogic)_service;
                base.Finally();
            }

            internal object __exv__;
            internal Microsoft.XLANGs.BaseTypes.MissingPropertyException __vExcp_0
            {
                get { return (Microsoft.XLANGs.BaseTypes.MissingPropertyException)__exv__; }
                set { __exv__ = value; }
            }
        }


        [System.SerializableAttribute]
        public class ____scope35_4 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope35_4(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope35")
            {
            }

            public override int Index { get { return 4; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[5]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[5]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;

                __seg__ = _service._segments[6];
                __seg__.Reset(1);
                __seg__.PredecessorDone(_service);
                return true;
            }

            public override void Finally()
            {
                ErrorHandlerLogic __svc__ = (ErrorHandlerLogic)_service;
                base.Finally();
            }

        }


        [System.SerializableAttribute]
        public class ____scope36_5 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope36_5(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope36")
            {
            }

            public override int Index { get { return 5; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[7]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[7]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;

                __seg__ = _service._segments[8];
                __seg__.Reset(1);
                __seg__.PredecessorDone(_service);
                return true;
            }

            public override void Finally()
            {
                ErrorHandlerLogic __svc__ = (ErrorHandlerLogic)_service;
                base.Finally();
            }

        }


        [System.SerializableAttribute]
        public class ____scope37_6 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope37_6(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope37")
            {
            }

            public override int Index { get { return 6; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[9]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[9]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Exception))
                    {
                        __seg__ = _service._segments[10];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                ErrorHandlerLogic __svc__ = (ErrorHandlerLogic)_service;
                ____scope37_6 __ctx6__ = (____scope37_6)(__svc__._stateMgrs[6]);

                if (__ctx6__ != null)
                    __ctx6__.__vexcxp_0 = null;
                base.Finally();
            }

            internal object __exv__;
            internal System.Exception __vexcxp_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ErrorsPort")]
        internal ErrorsPortType ErrorsPort;
        [Microsoft.XLANGs.BaseTypes.PhysicalBindingAttribute(typeof(Microsoft.BizTalk.DefaultPipelines.PassThruTransmit))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ArchiveDynmicPort")]
        internal PortType_DynamixSend ArchiveDynmicPort;  // lock index = 0
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ErrorMessagePort")]
        internal ErrorMsgPortType ErrorMessagePort;
        private static ErrorReport.ErrorType _prop_ErrorReport_ErrorType = new ErrorReport.ErrorType();

        sealed private class PredicateSet0_0 : Microsoft.XLANGs.Core.PredicateGroup
        {
            public PredicateSet0_0() : base(1)
            {
                Add(new Microsoft.XLANGs.Core.FullySpecifiedPredicate(_prop_ErrorReport_ErrorType, Microsoft.XLANGs.Core.PredicateBase.Operators.eExists, null));
            }
        }


        private static Microsoft.XLANGs.Core.PredicateGroup[] _predicates0 = {
            new PredicateSet0_0()
        };


        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ErrorsPortType.Operation_RecieveError},
                                               typeof(ErrorHandlerLogic).GetField("ErrorsPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ErrorHandlerLogic), "ErrorsPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_DynamixSend.Operation_1},
                                               typeof(ErrorHandlerLogic).GetField("ArchiveDynmicPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               true,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ErrorHandlerLogic), "ArchiveDynmicPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ErrorMsgPortType.Operation_1},
                                               typeof(ErrorHandlerLogic).GetField("ErrorMessagePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ErrorHandlerLogic), "ErrorMessagePort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, _predicates0 , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "1faf0c64-57cd-4a3f-bd4a-42e3a79a96fa", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "ca6a9015-ac86-4081-a849-cf18b163a680", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "ca6a9015-ac86-4081-a849-cf18b163a680", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "b753edac-a087-49f2-bcde-4a55bad23ceb", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "b753edac-a087-49f2-bcde-4a55bad23ceb", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "dd29a6e6-6cd3-4336-923f-3bea5ec6a865", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "a75a30b1-8651-4cf8-84be-86dc18342a9f", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "a75a30b1-8651-4cf8-84be-86dc18342a9f", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "8db7a76a-111c-4ccb-be6c-6992f4550c70", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "0aa8d45a-7fd3-4f01-a444-2d732fc387ad", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "0aa8d45a-7fd3-4f01-a444-2d732fc387ad", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "00000000-0000-0000-0000-000000000000", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "00000000-0000-0000-0000-000000000000", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "8db7a76a-111c-4ccb-be6c-6992f4550c70", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "dd29a6e6-6cd3-4336-923f-3bea5ec6a865", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "841ed7dd-b9c2-42c9-be9b-b3aa87e88e02", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "00000000-0000-0000-0000-000000000000", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "72c7552f-99f5-484f-9434-a887fa225dac", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "72c7552f-99f5-484f-9434-a887fa225dac", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "00000000-0000-0000-0000-000000000000", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "7178b8b3-80d3-4377-be98-0359f4cd80b6", 6, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "9c6e0e16-aac5-47cb-94e7-29c088251fe4", 6, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "9c6e0e16-aac5-47cb-94e7-29c088251fe4", 6, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "00000000-0000-0000-0000-000000000000", 6, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "00000000-0000-0000-0000-000000000000", 6, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "7178b8b3-80d3-4377-be98-0359f4cd80b6", 6, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "841ed7dd-b9c2-42c9-be9b-b3aa87e88e02", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "7ffc3a6a-dc15-4ecd-a1ad-7ade80c33ecc", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "00000000-0000-0000-0000-000000000000", 7, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "0281cfe6-9ddd-417b-807f-598d9876b014", 7, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "0281cfe6-9ddd-417b-807f-598d9876b014", 7, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "00000000-0000-0000-0000-000000000000", 7, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "743418cf-6a24-4615-9cca-50c9177f8772", 8, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "49c93231-7e9d-4a54-9399-4f2e93a6ef41", 8, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "49c93231-7e9d-4a54-9399-4f2e93a6ef41", 8, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "00000000-0000-0000-0000-000000000000", 8, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "00000000-0000-0000-0000-000000000000", 8, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "743418cf-6a24-4615-9cca-50c9177f8772", 8, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "7ffc3a6a-dc15-4ecd-a1ad-7ade80c33ecc", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(44, "5fbb41b4-1963-4897-be10-5cde1dfbc835", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(45, "5fbb41b4-1963-4897-be10-5cde1dfbc835", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(46, "307fd43c-f5c3-4daa-9448-d4cb004af4d2", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(47, "307fd43c-f5c3-4daa-9448-d4cb004af4d2", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(48, "68f1f996-7940-444d-bdd2-817b11489515", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(49, "00000000-0000-0000-0000-000000000000", 9, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(50, "8dfa8d8c-3cc3-44e6-b959-73bc931b8357", 9, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(51, "8dfa8d8c-3cc3-44e6-b959-73bc931b8357", 9, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(52, "00000000-0000-0000-0000-000000000000", 9, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(53, "635308d3-eef9-4cce-b72a-8e30829d137e", 10, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(54, "fd37fff4-e28f-4e48-a00a-0efe251eaf4d", 10, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(55, "fd37fff4-e28f-4e48-a00a-0efe251eaf4d", 10, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(56, "00000000-0000-0000-0000-000000000000", 10, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(57, "00000000-0000-0000-0000-000000000000", 10, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(58, "635308d3-eef9-4cce-b72a-8e30829d137e", 10, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(59, "68f1f996-7940-444d-bdd2-817b11489515", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(60, "a6041da3-b188-4f3e-b24f-05c762ea930f", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(61, "a6041da3-b188-4f3e-b24f-05c762ea930f", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(62, "c95ce7bd-1385-4ed7-90cb-0e1917a3e0ce", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(63, "c95ce7bd-1385-4ed7-90cb-0e1917a3e0ce", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(64, "7394c9d9-2840-4377-b19e-faaad6e5d8a6", 11, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(65, "3b602618-4c79-4364-9acc-e0e091533224", 11, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(66, "3b602618-4c79-4364-9acc-e0e091533224", 11, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(67, "7394c9d9-2840-4377-b19e-faaad6e5d8a6", 11, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(68, "1faf0c64-57cd-4a3f-bd4a-42e3a79a96fa", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(69, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,69,69,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,68,69,69,69,69,};
        public static int[] __progressLocation2 = new int[] { 3,3,3,4,4,6,6,7,7,7,7,7,7,7,7,7,7,7,8,8,8,19,20,20,20,31,32,32,32,43,44,44,45,46,46,46,47,48,48,48,59,60,60,61,62,62,62,63,63,63,63,};
        public static int[] __progressLocation3 = new int[] { 10,10,10,11,11,11,11,11,};
        public static int[] __progressLocation4 = new int[] { 13,13,14,14,15,15,18,18,};
        public static int[] __progressLocation5 = new int[] { 22,22,22,23,23,23,23,23,};
        public static int[] __progressLocation6 = new int[] { 25,25,26,26,27,27,30,30,};
        public static int[] __progressLocation7 = new int[] { 34,34,34,35,35,35,35,35,};
        public static int[] __progressLocation8 = new int[] { 37,37,38,38,39,39,42,42,};
        public static int[] __progressLocation9 = new int[] { 50,50,50,51,51,51,51,51,};
        public static int[] __progressLocation10 = new int[] { 53,53,54,54,55,55,58,58,};
        public static int[] __progressLocation11 = new int[] { 64,64,65,65,66,67,67,};

        public static int[][] __progressLocations = new int[12] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3,__progressLocation4,__progressLocation5,__progressLocation6,__progressLocation7,__progressLocation8,__progressLocation9,__progressLocation10,__progressLocation11};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ErrorHandlerLogic_1 __ctx1__ = (__ErrorHandlerLogic_1)_stateMgrs[1];
            __ErrorHandlerLogic_root_0 __ctx0__ = (__ErrorHandlerLogic_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                ErrorsPort = new ErrorsPortType(0, this);
                ErrorMessagePort = new ErrorMsgPortType(2, this);
                ArchiveDynmicPort = new PortType_DynamixSend(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ErrorsPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ErrorHandlerLogic_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __ErrorHandlerLogic_1 __ctx1__ = (__ErrorHandlerLogic_1)_stateMgrs[1];
            __ErrorHandlerLogic_root_0 __ctx0__ = (__ErrorHandlerLogic_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__TheError = default(ErrorMessage);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx2__ = new ____scope33_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (ArchiveDynmicPort != null)
                {
                    ArchiveDynmicPort.Close(__ctx1__, __seg__);
                    ArchiveDynmicPort = null;
                }
                if (ErrorMessagePort != null)
                {
                    ErrorMessagePort.Close(__ctx1__, __seg__);
                    ErrorMessagePort = null;
                }
                if (ErrorsPort != null)
                {
                    ErrorsPort.Close(__ctx1__, __seg__);
                    ErrorsPort = null;
                }
                Tracker.FireEvent(__eventLocations[68],__eventData[7],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[69],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 9;
            case 9:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope36_5 __ctx5__ = (____scope36_5)_stateMgrs[5];
            ____scope37_6 __ctx6__ = (____scope37_6)_stateMgrs[6];
            ____scope35_4 __ctx4__ = (____scope35_4)_stateMgrs[4];
            ____scope34_3 __ctx3__ = (____scope34_3)_stateMgrs[3];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __ErrorHandlerLogic_1 __ctx1__ = (__ErrorHandlerLogic_1)_stateMgrs[1];
            __ErrorHandlerLogic_root_0 __ctx0__ = (__ErrorHandlerLogic_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if (!ErrorsPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__ErrorMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__ErrorMsg);
                __ctx1__.__ErrorMsg = new __messagetype_System_Xml_XmlDocument("ErrorMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__ErrorMsg);
                ErrorsPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__ErrorMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__ErrorMsg);
                    __edata.PortName = @"ErrorsPort";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                __ctx1__.__TheError = new ErrorMessage();
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __ctx1__.__TheError = new ErrorMessage();
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                __ctx1__.__TheError.Error.ErrorType = (System.String)__ctx1__.__ErrorMsg.GetPropertyValueThrows(typeof(ErrorReport.ErrorType));
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                System.Diagnostics.Trace.WriteLine("ErrorType = " + __ctx1__.__TheError.Error.ErrorType);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__TheError.Error.Description = (System.String)__ctx1__.__ErrorMsg.GetPropertyValueThrows(typeof(ErrorReport.Description));
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                System.Diagnostics.Trace.WriteLine("TheError.Error.Description = " + __ctx1__.__TheError.Error.Description);
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__TheError.Error.FailureCategory = 0;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                System.Diagnostics.Trace.WriteLine("FailureCategory = " + __ctx1__.__TheError.Error.FailureCategory.ToString());
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__TheError.Error.FailureCode = (System.String)__ctx1__.__ErrorMsg.GetPropertyValueThrows(typeof(ErrorReport.FailureCode));
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                System.Diagnostics.Trace.WriteLine("FailureCode = " + __ctx1__.__TheError.Error.FailureCode);
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__TheError.Error.RoutingFailureReportID = (System.String)__ctx1__.__ErrorMsg.GetPropertyValueThrows(typeof(ErrorReport.RoutingFailureReportID));
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                System.Diagnostics.Trace.WriteLine("RoutingFailureReportID = " + __ctx1__.__TheError.Error.RoutingFailureReportID);
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                __ctx3__ = new ____scope34_3(this);
                _stateMgrs[3] = __ctx3__;
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                __ctx2__.StartContext(__seg__, __ctx3__);
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[7],_stateMgrs[2].TrackDataStream );
                __ctx3__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                __ctx4__ = new ____scope35_4(this);
                _stateMgrs[4] = __ctx4__;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                __ctx2__.StartContext(__seg__, __ctx4__);
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[31],__eventData[7],_stateMgrs[2].TrackDataStream );
                __ctx4__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                __ctx5__ = new ____scope36_5(this);
                _stateMgrs[5] = __ctx5__;
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                __ctx2__.StartContext(__seg__, __ctx5__);
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[43],__eventData[7],_stateMgrs[2].TrackDataStream );
                __ctx5__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[44],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                ArchiveDynmicPort.SetPropertyValue(typeof(Microsoft.XLANGs.BaseTypes.Address), @"file://C:\XTProjects\CODE\BizTalk\AutoErrorHandler\DataFolders\BadMessages\" + (System.String)__ctx1__.__ErrorMsg.GetPropertyValueThrows(typeof(BTS.MessageID)) + ".bad");
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[45],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[46],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                ArchiveDynmicPort.SendMessage(0, __ctx1__.__ErrorMsg, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ErrorMsg);
                    __edata.PortName = @"ArchiveDynmicPort";
                    Tracker.FireEvent(__eventLocations[47],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[48],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                __ctx6__ = new ____scope37_6(this);
                _stateMgrs[6] = __ctx6__;
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                __ctx2__.StartContext(__seg__, __ctx6__);
                if ( !PostProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__ErrorMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ErrorMsg);
                    __ctx1__.__ErrorMsg = null;
                }
                Tracker.FireEvent(__eventLocations[59],__eventData[7],_stateMgrs[2].TrackDataStream );
                __ctx6__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                if ( !PreProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[60],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 42;
            case 42:
                {
                    __messagetype_AutoErrorHandler_GTErrorSchema __ErrorReportMsg = new __messagetype_AutoErrorHandler_GTErrorSchema("ErrorReportMsg", __ctx1__);

                    __ErrorReportMsg.part.LoadFrom(__ctx1__.__TheError.ToXML());
                    System.Diagnostics.Debug.WriteLine(__ctx1__.__TheError.ToString());
                    if (__ctx1__ != null)
                        __ctx1__.__TheError = null;

                    if (__ctx1__.__ErrorReportMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ErrorReportMsg);
                    __ctx1__.__ErrorReportMsg = __ErrorReportMsg;
                    __ctx1__.RefMessage(__ctx1__.__ErrorReportMsg);
                }
                __ctx1__.__ErrorReportMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__ErrorReportMsg);
                    Tracker.FireEvent(__eventLocations[61],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[62],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                ErrorMessagePort.SendMessage(0, __ctx1__.__ErrorReportMsg, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 47;
            case 47:
                if ( !PreProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ErrorReportMsg);
                    __edata.PortName = @"ErrorMessagePort";
                    Tracker.FireEvent(__eventLocations[63],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__ErrorReportMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ErrorReportMsg);
                    __ctx1__.__ErrorReportMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 48;
            case 48:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 49;
            case 49:
                if ( !PreProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 50;
            case 50:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[3];
            ____scope34_3 __ctx3__ = (____scope34_3)_stateMgrs[3];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __ErrorHandlerLogic_1 __ctx1__ = (__ErrorHandlerLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx1__.__TheError.Error.MessageType = (System.String)__ctx1__.__ErrorMsg.GetPropertyValueThrows(typeof(ErrorReport.MessageType));
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[4],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                System.Diagnostics.Trace.WriteLine("MessageType = " + __ctx1__.__TheError.Error.MessageType);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if (!__ctx3__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx3__.OnCommit();
                goto case 7;
            case 7:
                __seg__.SegmentDone();
                _segments[2].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment4(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[4];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[3];
            ____scope34_3 __ctx3__ = (____scope34_3)_stateMgrs[3];
            __ErrorHandlerLogic_1 __ctx1__ = (__ErrorHandlerLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(3);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[5],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__TheError.Error.MessageType = "Undefined";
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[4],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                System.Diagnostics.Trace.WriteLine("MessageType = " + __ctx1__.__TheError.Error.MessageType);
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[6],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __ctx3__.__exv__ = null;
                OnEndCatchHandler(3, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment5(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[5];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[4];
            ____scope35_4 __ctx4__ = (____scope35_4)_stateMgrs[4];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __ErrorHandlerLogic_1 __ctx1__ = (__ErrorHandlerLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[3],_stateMgrs[4].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx1__.__TheError.Error.InboundTransportLocation = (System.String)__ctx1__.__ErrorMsg.GetPropertyValueThrows(typeof(ErrorReport.InboundTransportLocation));
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[4],_stateMgrs[4].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                __ctx1__.__TheError.Error.ReceivePortName = (System.String)__ctx1__.__ErrorMsg.GetPropertyValueThrows(typeof(ErrorReport.ReceivePortName));
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if (!__ctx4__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx4__.OnCommit();
                goto case 7;
            case 7:
                __seg__.SegmentDone();
                _segments[2].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment6(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[6];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[4];
            ____scope35_4 __ctx4__ = (____scope35_4)_stateMgrs[4];
            __ErrorHandlerLogic_1 __ctx1__ = (__ErrorHandlerLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(4);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[5],_stateMgrs[4].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[3],_stateMgrs[4].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__TheError.Error.InboundTransportLocation = System.String.Empty;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[4],_stateMgrs[4].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__TheError.Error.ReceivePortName = System.String.Empty;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[6],_stateMgrs[4].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                OnEndCatchHandler(4, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment7(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[7];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[5];
            ____scope36_5 __ctx5__ = (____scope36_5)_stateMgrs[5];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __ErrorHandlerLogic_1 __ctx1__ = (__ErrorHandlerLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[34],__eventData[3],_stateMgrs[5].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx1__.__TheError.Error.OutboundTransportLocation = (System.String)__ctx1__.__ErrorMsg.GetPropertyValueThrows(typeof(ErrorReport.OutboundTransportLocation));
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[35],__eventData[4],_stateMgrs[5].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                __ctx1__.__TheError.Error.SendPortName = (System.String)__ctx1__.__ErrorMsg.GetPropertyValueThrows(typeof(ErrorReport.SendPortName));
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if (!__ctx5__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx5__.OnCommit();
                goto case 7;
            case 7:
                __seg__.SegmentDone();
                _segments[2].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment8(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[8];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[5];
            ____scope36_5 __ctx5__ = (____scope36_5)_stateMgrs[5];
            __ErrorHandlerLogic_1 __ctx1__ = (__ErrorHandlerLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(5);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[37],__eventData[5],_stateMgrs[5].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[38],__eventData[3],_stateMgrs[5].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__TheError.Error.OutboundTransportLocation = System.String.Empty;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[39],__eventData[4],_stateMgrs[5].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__TheError.Error.SendPortName = System.String.Empty;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[42],__eventData[6],_stateMgrs[5].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                OnEndCatchHandler(5, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment9(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[9];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[6];
            ____scope37_6 __ctx6__ = (____scope37_6)_stateMgrs[6];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __ErrorHandlerLogic_1 __ctx1__ = (__ErrorHandlerLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[50],__eventData[3],_stateMgrs[6].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx1__.__TheError.Message = @"C:\XTProjects\CODE\BizTalk\AutoErrorHandler\DataFolders\BadMessages\" + (System.String)__ctx1__.__ErrorMsg.GetPropertyValueThrows(typeof(BTS.MessageID)) + ".bad";
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[51],__eventData[4],_stateMgrs[6].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                System.Diagnostics.Debug.WriteLine("OutFileName = " + __ctx1__.__TheError.Message.ToString());
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if (!__ctx6__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx6__.OnCommit();
                goto case 7;
            case 7:
                __seg__.SegmentDone();
                _segments[2].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment10(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[10];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[6];
            ____scope37_6 __ctx6__ = (____scope37_6)_stateMgrs[6];
            __ErrorHandlerLogic_1 __ctx1__ = (__ErrorHandlerLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(6);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[53],__eventData[5],_stateMgrs[6].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[54],__eventData[3],_stateMgrs[6].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__TheError.Message = System.String.Empty;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[55],__eventData[4],_stateMgrs[6].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                System.Diagnostics.Debug.WriteLine("could not assign the messgae: \n" + __ctx6__.__vexcxp_0.ToString());
                if (__ctx6__ != null)
                    __ctx6__.__vexcxp_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[58],__eventData[6],_stateMgrs[6].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __ctx6__.__exv__ = null;
                OnEndCatchHandler(6, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment11(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[11];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[64],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[65],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                System.Diagnostics.Debug.WriteLine("Exception Thrown" + __ctx2__.__excp_0.ToString());
                if (__ctx2__ != null)
                    __ctx2__.__excp_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[66],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[67],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Microsoft_XLANGs_BaseTypes_Any__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Microsoft.XLANGs.BaseTypes.Any _schema = new Microsoft.XLANGs.BaseTypes.Any();

        public __Microsoft_XLANGs_BaseTypes_Any__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.Xml.XmlDocument",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_Xml_XmlDocument : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ part;

        private void __CreatePartWrappers()
        {
            part = new __Microsoft_XLANGs_BaseTypes_Any__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_Xml_XmlDocument(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
