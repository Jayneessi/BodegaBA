﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuenosAires.BodegaBA.WsGuiaDespachoReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WsGuiaDespachoReference.IWsGuiaDespacho")]
    public interface IWsGuiaDespacho {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsGuiaDespacho/obtener_guias_de_despacho", ReplyAction="http://tempuri.org/IWsGuiaDespacho/obtener_guias_de_despachoResponse")]
        BuenosAires.Model.Respuesta obtener_guias_de_despacho();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsGuiaDespacho/obtener_guias_de_despacho", ReplyAction="http://tempuri.org/IWsGuiaDespacho/obtener_guias_de_despachoResponse")]
        System.Threading.Tasks.Task<BuenosAires.Model.Respuesta> obtener_guias_de_despachoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWsGuiaDespachoChannel : BuenosAires.BodegaBA.WsGuiaDespachoReference.IWsGuiaDespacho, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WsGuiaDespachoClient : System.ServiceModel.ClientBase<BuenosAires.BodegaBA.WsGuiaDespachoReference.IWsGuiaDespacho>, BuenosAires.BodegaBA.WsGuiaDespachoReference.IWsGuiaDespacho {
        
        public WsGuiaDespachoClient() {
        }
        
        public WsGuiaDespachoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WsGuiaDespachoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsGuiaDespachoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsGuiaDespachoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BuenosAires.Model.Respuesta obtener_guias_de_despacho() {
            return base.Channel.obtener_guias_de_despacho();
        }
        
        public System.Threading.Tasks.Task<BuenosAires.Model.Respuesta> obtener_guias_de_despachoAsync() {
            return base.Channel.obtener_guias_de_despachoAsync();
        }
    }
}
