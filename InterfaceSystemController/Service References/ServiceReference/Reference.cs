﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InterfaceSystemController.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.SystemControllerSoap")]
    public interface SystemControllerSoap {
        
        // CODEGEN: Generating message contract since element name route from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/initialize_List", ReplyAction="*")]
        InterfaceSystemController.ServiceReference.initialize_ListResponse initialize_List(InterfaceSystemController.ServiceReference.initialize_ListRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class initialize_ListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="initialize_List", Namespace="http://tempuri.org/", Order=0)]
        public InterfaceSystemController.ServiceReference.initialize_ListRequestBody Body;
        
        public initialize_ListRequest() {
        }
        
        public initialize_ListRequest(InterfaceSystemController.ServiceReference.initialize_ListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class initialize_ListRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string route;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string action;
        
        public initialize_ListRequestBody() {
        }
        
        public initialize_ListRequestBody(string route, string name, string action) {
            this.route = route;
            this.name = name;
            this.action = action;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class initialize_ListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="initialize_ListResponse", Namespace="http://tempuri.org/", Order=0)]
        public InterfaceSystemController.ServiceReference.initialize_ListResponseBody Body;
        
        public initialize_ListResponse() {
        }
        
        public initialize_ListResponse(InterfaceSystemController.ServiceReference.initialize_ListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class initialize_ListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string initialize_ListResult;
        
        public initialize_ListResponseBody() {
        }
        
        public initialize_ListResponseBody(string initialize_ListResult) {
            this.initialize_ListResult = initialize_ListResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SystemControllerSoapChannel : InterfaceSystemController.ServiceReference.SystemControllerSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SystemControllerSoapClient : System.ServiceModel.ClientBase<InterfaceSystemController.ServiceReference.SystemControllerSoap>, InterfaceSystemController.ServiceReference.SystemControllerSoap {
        
        public SystemControllerSoapClient() {
        }
        
        public SystemControllerSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SystemControllerSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SystemControllerSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SystemControllerSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InterfaceSystemController.ServiceReference.initialize_ListResponse InterfaceSystemController.ServiceReference.SystemControllerSoap.initialize_List(InterfaceSystemController.ServiceReference.initialize_ListRequest request) {
            return base.Channel.initialize_List(request);
        }
        
        public string initialize_List(string route, string name, string action) {
            InterfaceSystemController.ServiceReference.initialize_ListRequest inValue = new InterfaceSystemController.ServiceReference.initialize_ListRequest();
            inValue.Body = new InterfaceSystemController.ServiceReference.initialize_ListRequestBody();
            inValue.Body.route = route;
            inValue.Body.name = name;
            inValue.Body.action = action;
            InterfaceSystemController.ServiceReference.initialize_ListResponse retVal = ((InterfaceSystemController.ServiceReference.SystemControllerSoap)(this)).initialize_List(inValue);
            return retVal.Body.initialize_ListResult;
        }
    }
}
