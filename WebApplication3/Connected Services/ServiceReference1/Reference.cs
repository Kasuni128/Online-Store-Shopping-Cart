//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.SupplierAWebServiceSoap")]
    public interface SupplierAWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebApplication3.ServiceReference1.HelloWorldResponse HelloWorld(WebApplication3.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication3.ServiceReference1.HelloWorldResponse> HelloWorldAsync(WebApplication3.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPrice", ReplyAction="*")]
        int getPrice(int Id, int qun);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPrice", ReplyAction="*")]
        System.Threading.Tasks.Task<int> getPriceAsync(int Id, int qun);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateQuantity", ReplyAction="*")]
        void updateQuantity(int Id, int qun);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateQuantity", ReplyAction="*")]
        System.Threading.Tasks.Task updateQuantityAsync(int Id, int qun);
        
        // CODEGEN: Generating message contract since element name Customer from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/placeOder", ReplyAction="*")]
        WebApplication3.ServiceReference1.placeOderResponse placeOder(WebApplication3.ServiceReference1.placeOderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/placeOder", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication3.ServiceReference1.placeOderResponse> placeOderAsync(WebApplication3.ServiceReference1.placeOderRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication3.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebApplication3.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication3.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebApplication3.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class placeOderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="placeOder", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication3.ServiceReference1.placeOderRequestBody Body;
        
        public placeOderRequest() {
        }
        
        public placeOderRequest(WebApplication3.ServiceReference1.placeOderRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class placeOderRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Id;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int Quantity;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Customer;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Address;
        
        public placeOderRequestBody() {
        }
        
        public placeOderRequestBody(int Id, int Quantity, string Customer, string Address) {
            this.Id = Id;
            this.Quantity = Quantity;
            this.Customer = Customer;
            this.Address = Address;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class placeOderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="placeOderResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication3.ServiceReference1.placeOderResponseBody Body;
        
        public placeOderResponse() {
        }
        
        public placeOderResponse(WebApplication3.ServiceReference1.placeOderResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class placeOderResponseBody {
        
        public placeOderResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SupplierAWebServiceSoapChannel : WebApplication3.ServiceReference1.SupplierAWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SupplierAWebServiceSoapClient : System.ServiceModel.ClientBase<WebApplication3.ServiceReference1.SupplierAWebServiceSoap>, WebApplication3.ServiceReference1.SupplierAWebServiceSoap {
        
        public SupplierAWebServiceSoapClient() {
        }
        
        public SupplierAWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SupplierAWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SupplierAWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SupplierAWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication3.ServiceReference1.HelloWorldResponse WebApplication3.ServiceReference1.SupplierAWebServiceSoap.HelloWorld(WebApplication3.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebApplication3.ServiceReference1.HelloWorldRequest inValue = new WebApplication3.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebApplication3.ServiceReference1.HelloWorldRequestBody();
            WebApplication3.ServiceReference1.HelloWorldResponse retVal = ((WebApplication3.ServiceReference1.SupplierAWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication3.ServiceReference1.HelloWorldResponse> WebApplication3.ServiceReference1.SupplierAWebServiceSoap.HelloWorldAsync(WebApplication3.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication3.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            WebApplication3.ServiceReference1.HelloWorldRequest inValue = new WebApplication3.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebApplication3.ServiceReference1.HelloWorldRequestBody();
            return ((WebApplication3.ServiceReference1.SupplierAWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int getPrice(int Id, int qun) {
            return base.Channel.getPrice(Id, qun);
        }
        
        public System.Threading.Tasks.Task<int> getPriceAsync(int Id, int qun) {
            return base.Channel.getPriceAsync(Id, qun);
        }
        
        public void updateQuantity(int Id, int qun) {
            base.Channel.updateQuantity(Id, qun);
        }
        
        public System.Threading.Tasks.Task updateQuantityAsync(int Id, int qun) {
            return base.Channel.updateQuantityAsync(Id, qun);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication3.ServiceReference1.placeOderResponse WebApplication3.ServiceReference1.SupplierAWebServiceSoap.placeOder(WebApplication3.ServiceReference1.placeOderRequest request) {
            return base.Channel.placeOder(request);
        }
        
        public void placeOder(int Id, int Quantity, string Customer, string Address) {
            WebApplication3.ServiceReference1.placeOderRequest inValue = new WebApplication3.ServiceReference1.placeOderRequest();
            inValue.Body = new WebApplication3.ServiceReference1.placeOderRequestBody();
            inValue.Body.Id = Id;
            inValue.Body.Quantity = Quantity;
            inValue.Body.Customer = Customer;
            inValue.Body.Address = Address;
            WebApplication3.ServiceReference1.placeOderResponse retVal = ((WebApplication3.ServiceReference1.SupplierAWebServiceSoap)(this)).placeOder(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication3.ServiceReference1.placeOderResponse> WebApplication3.ServiceReference1.SupplierAWebServiceSoap.placeOderAsync(WebApplication3.ServiceReference1.placeOderRequest request) {
            return base.Channel.placeOderAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication3.ServiceReference1.placeOderResponse> placeOderAsync(int Id, int Quantity, string Customer, string Address) {
            WebApplication3.ServiceReference1.placeOderRequest inValue = new WebApplication3.ServiceReference1.placeOderRequest();
            inValue.Body = new WebApplication3.ServiceReference1.placeOderRequestBody();
            inValue.Body.Id = Id;
            inValue.Body.Quantity = Quantity;
            inValue.Body.Customer = Customer;
            inValue.Body.Address = Address;
            return ((WebApplication3.ServiceReference1.SupplierAWebServiceSoap)(this)).placeOderAsync(inValue);
        }
    }
}
