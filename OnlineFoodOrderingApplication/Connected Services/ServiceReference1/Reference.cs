﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineFoodOrderingApplication.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="userADD", Namespace="http://schemas.datacontract.org/2004/07/OrderFoodAddUser")]
    [System.SerializableAttribute()]
    public partial class userADD : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeFirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeLastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeFirstName {
            get {
                return this.EmployeFirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeFirstNameField, value) != true)) {
                    this.EmployeFirstNameField = value;
                    this.RaisePropertyChanged("EmployeFirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeLastName {
            get {
                return this.EmployeLastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeLastNameField, value) != true)) {
                    this.EmployeLastNameField = value;
                    this.RaisePropertyChanged("EmployeLastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string EmailId {
            get {
                return this.EmailIdField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailIdField, value) != true)) {
                    this.EmailIdField = value;
                    this.RaisePropertyChanged("EmailId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IaddMe")]
    public interface IaddMe {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IaddMe/AddUSer", ReplyAction="http://tempuri.org/IaddMe/AddUSerResponse")]
        string AddUSer(OnlineFoodOrderingApplication.ServiceReference1.userADD useradd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IaddMe/AddUSer", ReplyAction="http://tempuri.org/IaddMe/AddUSerResponse")]
        System.Threading.Tasks.Task<string> AddUSerAsync(OnlineFoodOrderingApplication.ServiceReference1.userADD useradd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IaddMeChannel : OnlineFoodOrderingApplication.ServiceReference1.IaddMe, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IaddMeClient : System.ServiceModel.ClientBase<OnlineFoodOrderingApplication.ServiceReference1.IaddMe>, OnlineFoodOrderingApplication.ServiceReference1.IaddMe {
        
        public IaddMeClient() {
        }
        
        public IaddMeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IaddMeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IaddMeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IaddMeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AddUSer(OnlineFoodOrderingApplication.ServiceReference1.userADD useradd) {
            return base.Channel.AddUSer(useradd);
        }
        
        public System.Threading.Tasks.Task<string> AddUSerAsync(OnlineFoodOrderingApplication.ServiceReference1.userADD useradd) {
            return base.Channel.AddUSerAsync(useradd);
        }
    }
}
