﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sear.ServiceApp {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Input", Namespace="http://config.soap.it")]
    [System.SerializableAttribute()]
    public partial class Input : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Sear.ServiceApp.ArrayOf_xsd_int vectorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public Sear.ServiceApp.ArrayOf_xsd_int vector {
            get {
                return this.vectorField;
            }
            set {
                if ((object.ReferenceEquals(this.vectorField, value) != true)) {
                    this.vectorField = value;
                    this.RaisePropertyChanged("vector");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOf_xsd_int", Namespace="http://config.soap.it", ItemName="item")]
    [System.SerializableAttribute()]
    public class ArrayOf_xsd_int : System.Collections.Generic.List<int> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Output", Namespace="http://config.soap.it")]
    [System.SerializableAttribute()]
    public partial class Output : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Sear.ServiceApp.ArrayOf_xsd_int sortedVectorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public Sear.ServiceApp.ArrayOf_xsd_int sortedVector {
            get {
                return this.sortedVectorField;
            }
            set {
                if ((object.ReferenceEquals(this.sortedVectorField, value) != true)) {
                    this.sortedVectorField = value;
                    this.RaisePropertyChanged("sortedVector");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://config.soap.it", ConfigurationName="ServiceApp.MyService")]
    public interface MyService {
        
        // CODEGEN: Generazione di un contratto di messaggio perché il nome di elemento input dallo spazio dei nomi http://config.soap.it non è contrassegnato come nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        Sear.ServiceApp.sortResponse sort(Sear.ServiceApp.sortRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<Sear.ServiceApp.sortResponse> sortAsync(Sear.ServiceApp.sortRequest request);
        
        // CODEGEN: Generazione di un contratto di messaggio perché il nome di elemento username dallo spazio dei nomi http://config.soap.it non è contrassegnato come nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        Sear.ServiceApp.echoResponse echo(Sear.ServiceApp.echoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<Sear.ServiceApp.echoResponse> echoAsync(Sear.ServiceApp.echoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class sortRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="sort", Namespace="http://config.soap.it", Order=0)]
        public Sear.ServiceApp.sortRequestBody Body;
        
        public sortRequest() {
        }
        
        public sortRequest(Sear.ServiceApp.sortRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://config.soap.it")]
    public partial class sortRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Sear.ServiceApp.Input input;
        
        public sortRequestBody() {
        }
        
        public sortRequestBody(Sear.ServiceApp.Input input) {
            this.input = input;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class sortResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="sortResponse", Namespace="http://config.soap.it", Order=0)]
        public Sear.ServiceApp.sortResponseBody Body;
        
        public sortResponse() {
        }
        
        public sortResponse(Sear.ServiceApp.sortResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://config.soap.it")]
    public partial class sortResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Sear.ServiceApp.Output sortReturn;
        
        public sortResponseBody() {
        }
        
        public sortResponseBody(Sear.ServiceApp.Output sortReturn) {
            this.sortReturn = sortReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class echoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="echo", Namespace="http://config.soap.it", Order=0)]
        public Sear.ServiceApp.echoRequestBody Body;
        
        public echoRequest() {
        }
        
        public echoRequest(Sear.ServiceApp.echoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://config.soap.it")]
    public partial class echoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public echoRequestBody() {
        }
        
        public echoRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class echoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="echoResponse", Namespace="http://config.soap.it", Order=0)]
        public Sear.ServiceApp.echoResponseBody Body;
        
        public echoResponse() {
        }
        
        public echoResponse(Sear.ServiceApp.echoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://config.soap.it")]
    public partial class echoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int echoReturn;
        
        public echoResponseBody() {
        }
        
        public echoResponseBody(int echoReturn) {
            this.echoReturn = echoReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MyServiceChannel : Sear.ServiceApp.MyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<Sear.ServiceApp.MyService>, Sear.ServiceApp.MyService {
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sear.ServiceApp.sortResponse Sear.ServiceApp.MyService.sort(Sear.ServiceApp.sortRequest request) {
            return base.Channel.sort(request);
        }
        
        public Sear.ServiceApp.Output sort(Sear.ServiceApp.Input input) {
            Sear.ServiceApp.sortRequest inValue = new Sear.ServiceApp.sortRequest();
            inValue.Body = new Sear.ServiceApp.sortRequestBody();
            inValue.Body.input = input;
            Sear.ServiceApp.sortResponse retVal = ((Sear.ServiceApp.MyService)(this)).sort(inValue);
            return retVal.Body.sortReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Sear.ServiceApp.sortResponse> Sear.ServiceApp.MyService.sortAsync(Sear.ServiceApp.sortRequest request) {
            return base.Channel.sortAsync(request);
        }
        
        public System.Threading.Tasks.Task<Sear.ServiceApp.sortResponse> sortAsync(Sear.ServiceApp.Input input) {
            Sear.ServiceApp.sortRequest inValue = new Sear.ServiceApp.sortRequest();
            inValue.Body = new Sear.ServiceApp.sortRequestBody();
            inValue.Body.input = input;
            return ((Sear.ServiceApp.MyService)(this)).sortAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sear.ServiceApp.echoResponse Sear.ServiceApp.MyService.echo(Sear.ServiceApp.echoRequest request) {
            return base.Channel.echo(request);
        }
        
        public int echo(string username, string password) {
            Sear.ServiceApp.echoRequest inValue = new Sear.ServiceApp.echoRequest();
            inValue.Body = new Sear.ServiceApp.echoRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            Sear.ServiceApp.echoResponse retVal = ((Sear.ServiceApp.MyService)(this)).echo(inValue);
            return retVal.Body.echoReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Sear.ServiceApp.echoResponse> Sear.ServiceApp.MyService.echoAsync(Sear.ServiceApp.echoRequest request) {
            return base.Channel.echoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Sear.ServiceApp.echoResponse> echoAsync(string username, string password) {
            Sear.ServiceApp.echoRequest inValue = new Sear.ServiceApp.echoRequest();
            inValue.Body = new Sear.ServiceApp.echoRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((Sear.ServiceApp.MyService)(this)).echoAsync(inValue);
        }
    }
}
