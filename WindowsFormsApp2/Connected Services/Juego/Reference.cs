﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2.Juego {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ECCI_Juego", ConfigurationName="Juego.ECCI_JuegoPort")]
    public interface ECCI_JuegoPort {
        
        // CODEGEN: Generating message contract since the wrapper name (saludeReturn) of message saludeResponse does not match the default value (salude)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Juego#Juego#salude", ReplyAction="*")]
        WindowsFormsApp2.Juego.saludeResponse salude(WindowsFormsApp2.Juego.saludeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Juego#Juego#salude", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp2.Juego.saludeResponse> saludeAsync(WindowsFormsApp2.Juego.saludeRequest request);
        
        // CODEGEN: Generating message contract since the wrapper name (servidorEstampillaDeTiempoReturn) of message servidorEstampillaDeTiempoResponse does not match the default value (servidorEstampillaDeTiempo)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Juego#Juego#servidorEstampillaDeTiempo", ReplyAction="*")]
        WindowsFormsApp2.Juego.servidorEstampillaDeTiempoResponse servidorEstampillaDeTiempo(WindowsFormsApp2.Juego.servidorEstampillaDeTiempoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Juego#Juego#servidorEstampillaDeTiempo", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp2.Juego.servidorEstampillaDeTiempoResponse> servidorEstampillaDeTiempoAsync(WindowsFormsApp2.Juego.servidorEstampillaDeTiempoRequest request);
        
        // CODEGEN: Generating message contract since the wrapper name (ultimoSaludoReturn) of message ultimoSaludoResponse does not match the default value (ultimoSaludo)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Juego#Juego#ultimoSaludo", ReplyAction="*")]
        WindowsFormsApp2.Juego.ultimoSaludoResponse ultimoSaludo(WindowsFormsApp2.Juego.ultimoSaludoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Juego#Juego#ultimoSaludo", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp2.Juego.ultimoSaludoResponse> ultimoSaludoAsync(WindowsFormsApp2.Juego.ultimoSaludoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="salude", WrapperNamespace="urn:ECCI_Juego", IsWrapped=true)]
    public partial class saludeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string nombre;
        
        public saludeRequest() {
        }
        
        public saludeRequest(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="saludeReturn", WrapperNamespace="urn:ECCI_Juego", IsWrapped=true)]
    public partial class saludeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string saludeResult;
        
        public saludeResponse() {
        }
        
        public saludeResponse(string saludeResult) {
            this.saludeResult = saludeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="servidorEstampillaDeTiempo", WrapperNamespace="urn:ECCI_Juego", IsWrapped=true)]
    public partial class servidorEstampillaDeTiempoRequest {
        
        public servidorEstampillaDeTiempoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="servidorEstampillaDeTiempoReturn", WrapperNamespace="urn:ECCI_Juego", IsWrapped=true)]
    public partial class servidorEstampillaDeTiempoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string servidorEstampillaDeTiempoResult;
        
        public servidorEstampillaDeTiempoResponse() {
        }
        
        public servidorEstampillaDeTiempoResponse(string servidorEstampillaDeTiempoResult) {
            this.servidorEstampillaDeTiempoResult = servidorEstampillaDeTiempoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ultimoSaludo", WrapperNamespace="urn:ECCI_Juego", IsWrapped=true)]
    public partial class ultimoSaludoRequest {
        
        public ultimoSaludoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ultimoSaludoReturn", WrapperNamespace="urn:ECCI_Juego", IsWrapped=true)]
    public partial class ultimoSaludoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string ultimoSaludoResult;
        
        public ultimoSaludoResponse() {
        }
        
        public ultimoSaludoResponse(string ultimoSaludoResult) {
            this.ultimoSaludoResult = ultimoSaludoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ECCI_JuegoPortChannel : WindowsFormsApp2.Juego.ECCI_JuegoPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ECCI_JuegoPortClient : System.ServiceModel.ClientBase<WindowsFormsApp2.Juego.ECCI_JuegoPort>, WindowsFormsApp2.Juego.ECCI_JuegoPort {
        
        public ECCI_JuegoPortClient() {
        }
        
        public ECCI_JuegoPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ECCI_JuegoPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ECCI_JuegoPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ECCI_JuegoPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp2.Juego.saludeResponse WindowsFormsApp2.Juego.ECCI_JuegoPort.salude(WindowsFormsApp2.Juego.saludeRequest request) {
            return base.Channel.salude(request);
        }
        
        public string salude(string nombre) {
            WindowsFormsApp2.Juego.saludeRequest inValue = new WindowsFormsApp2.Juego.saludeRequest();
            inValue.nombre = nombre;
            WindowsFormsApp2.Juego.saludeResponse retVal = ((WindowsFormsApp2.Juego.ECCI_JuegoPort)(this)).salude(inValue);
            return retVal.saludeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp2.Juego.saludeResponse> WindowsFormsApp2.Juego.ECCI_JuegoPort.saludeAsync(WindowsFormsApp2.Juego.saludeRequest request) {
            return base.Channel.saludeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp2.Juego.saludeResponse> saludeAsync(string nombre) {
            WindowsFormsApp2.Juego.saludeRequest inValue = new WindowsFormsApp2.Juego.saludeRequest();
            inValue.nombre = nombre;
            return ((WindowsFormsApp2.Juego.ECCI_JuegoPort)(this)).saludeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp2.Juego.servidorEstampillaDeTiempoResponse WindowsFormsApp2.Juego.ECCI_JuegoPort.servidorEstampillaDeTiempo(WindowsFormsApp2.Juego.servidorEstampillaDeTiempoRequest request) {
            return base.Channel.servidorEstampillaDeTiempo(request);
        }
        
        public string servidorEstampillaDeTiempo() {
            WindowsFormsApp2.Juego.servidorEstampillaDeTiempoRequest inValue = new WindowsFormsApp2.Juego.servidorEstampillaDeTiempoRequest();
            WindowsFormsApp2.Juego.servidorEstampillaDeTiempoResponse retVal = ((WindowsFormsApp2.Juego.ECCI_JuegoPort)(this)).servidorEstampillaDeTiempo(inValue);
            return retVal.servidorEstampillaDeTiempoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp2.Juego.servidorEstampillaDeTiempoResponse> WindowsFormsApp2.Juego.ECCI_JuegoPort.servidorEstampillaDeTiempoAsync(WindowsFormsApp2.Juego.servidorEstampillaDeTiempoRequest request) {
            return base.Channel.servidorEstampillaDeTiempoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp2.Juego.servidorEstampillaDeTiempoResponse> servidorEstampillaDeTiempoAsync() {
            WindowsFormsApp2.Juego.servidorEstampillaDeTiempoRequest inValue = new WindowsFormsApp2.Juego.servidorEstampillaDeTiempoRequest();
            return ((WindowsFormsApp2.Juego.ECCI_JuegoPort)(this)).servidorEstampillaDeTiempoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp2.Juego.ultimoSaludoResponse WindowsFormsApp2.Juego.ECCI_JuegoPort.ultimoSaludo(WindowsFormsApp2.Juego.ultimoSaludoRequest request) {
            return base.Channel.ultimoSaludo(request);
        }
        
        public string ultimoSaludo() {
            WindowsFormsApp2.Juego.ultimoSaludoRequest inValue = new WindowsFormsApp2.Juego.ultimoSaludoRequest();
            WindowsFormsApp2.Juego.ultimoSaludoResponse retVal = ((WindowsFormsApp2.Juego.ECCI_JuegoPort)(this)).ultimoSaludo(inValue);
            return retVal.ultimoSaludoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp2.Juego.ultimoSaludoResponse> WindowsFormsApp2.Juego.ECCI_JuegoPort.ultimoSaludoAsync(WindowsFormsApp2.Juego.ultimoSaludoRequest request) {
            return base.Channel.ultimoSaludoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp2.Juego.ultimoSaludoResponse> ultimoSaludoAsync() {
            WindowsFormsApp2.Juego.ultimoSaludoRequest inValue = new WindowsFormsApp2.Juego.ultimoSaludoRequest();
            return ((WindowsFormsApp2.Juego.ECCI_JuegoPort)(this)).ultimoSaludoAsync(inValue);
        }
    }
}