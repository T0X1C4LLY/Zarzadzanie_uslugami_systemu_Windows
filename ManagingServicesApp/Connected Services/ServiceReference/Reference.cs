﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagingServicesApp.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://MSService", ConfigurationName="ServiceReference.IMSService")]
    public interface IMSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://MSService/IMSService/StartService", ReplyAction="http://MSService/IMSService/StartServiceResponse")]
        void StartService(string displayName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://MSService/IMSService/StartService", ReplyAction="http://MSService/IMSService/StartServiceResponse")]
        System.Threading.Tasks.Task StartServiceAsync(string displayName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://MSService/IMSService/StopService", ReplyAction="http://MSService/IMSService/StopServiceResponse")]
        void StopService(string displayName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://MSService/IMSService/StopService", ReplyAction="http://MSService/IMSService/StopServiceResponse")]
        System.Threading.Tasks.Task StopServiceAsync(string displayName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMSServiceChannel : ManagingServicesApp.ServiceReference.IMSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MSServiceClient : System.ServiceModel.ClientBase<ManagingServicesApp.ServiceReference.IMSService>, ManagingServicesApp.ServiceReference.IMSService {
        
        public MSServiceClient() {
        }
        
        public MSServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MSServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MSServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MSServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void StartService(string displayName) {
            base.Channel.StartService(displayName);
        }
        
        public System.Threading.Tasks.Task StartServiceAsync(string displayName) {
            return base.Channel.StartServiceAsync(displayName);
        }
        
        public void StopService(string displayName) {
            base.Channel.StopService(displayName);
        }
        
        public System.Threading.Tasks.Task StopServiceAsync(string displayName) {
            return base.Channel.StopServiceAsync(displayName);
        }
    }
}