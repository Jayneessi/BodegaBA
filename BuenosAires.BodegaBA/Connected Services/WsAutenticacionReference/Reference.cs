﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuenosAires.BodegaBA.WsAutenticacionReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WsAutenticacionReference.IWsAutenticacion")]
    public interface IWsAutenticacion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsAutenticacion/Autenticar", ReplyAction="http://tempuri.org/IWsAutenticacion/AutenticarResponse")]
        BuenosAires.Model.Respuesta Autenticar(string tipousu, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsAutenticacion/Autenticar", ReplyAction="http://tempuri.org/IWsAutenticacion/AutenticarResponse")]
        System.Threading.Tasks.Task<BuenosAires.Model.Respuesta> AutenticarAsync(string tipousu, string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWsAutenticacionChannel : BuenosAires.BodegaBA.WsAutenticacionReference.IWsAutenticacion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WsAutenticacionClient : System.ServiceModel.ClientBase<BuenosAires.BodegaBA.WsAutenticacionReference.IWsAutenticacion>, BuenosAires.BodegaBA.WsAutenticacionReference.IWsAutenticacion {
        
        public WsAutenticacionClient() {
        }
        
        public WsAutenticacionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WsAutenticacionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsAutenticacionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsAutenticacionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BuenosAires.Model.Respuesta Autenticar(string tipousu, string username, string password) {
            return base.Channel.Autenticar(tipousu, username, password);
        }
        
        public System.Threading.Tasks.Task<BuenosAires.Model.Respuesta> AutenticarAsync(string tipousu, string username, string password) {
            return base.Channel.AutenticarAsync(tipousu, username, password);
        }
    }
}
