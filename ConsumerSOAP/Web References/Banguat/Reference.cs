﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Este código-fonte foi gerado automaticamente por Microsoft.VSDesigner, Versão 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ConsumerSOAP.Banguat {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TipoCambioSoap", Namespace="http://www.banguat.gob.gt/variables/ws/")]
    public partial class TipoCambio : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback VariablesDisponiblesOperationCompleted;
        
        private System.Threading.SendOrPostCallback VariablesOperationCompleted;
        
        private System.Threading.SendOrPostCallback TipoCambioFechaInicialOperationCompleted;
        
        private System.Threading.SendOrPostCallback TipoCambioRangoOperationCompleted;
        
        private System.Threading.SendOrPostCallback TipoCambioFechaInicialMonedaOperationCompleted;
        
        private System.Threading.SendOrPostCallback TipoCambioRangoMonedaOperationCompleted;
        
        private System.Threading.SendOrPostCallback TipoCambioDiaOperationCompleted;
        
        private System.Threading.SendOrPostCallback TipoCambioDiaStringOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TipoCambio() {
            this.Url = global::ConsumerSOAP.Properties.Settings.Default.ConsumerSOAP_Banguat_TipoCambio;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event VariablesDisponiblesCompletedEventHandler VariablesDisponiblesCompleted;
        
        /// <remarks/>
        public event VariablesCompletedEventHandler VariablesCompleted;
        
        /// <remarks/>
        public event TipoCambioFechaInicialCompletedEventHandler TipoCambioFechaInicialCompleted;
        
        /// <remarks/>
        public event TipoCambioRangoCompletedEventHandler TipoCambioRangoCompleted;
        
        /// <remarks/>
        public event TipoCambioFechaInicialMonedaCompletedEventHandler TipoCambioFechaInicialMonedaCompleted;
        
        /// <remarks/>
        public event TipoCambioRangoMonedaCompletedEventHandler TipoCambioRangoMonedaCompleted;
        
        /// <remarks/>
        public event TipoCambioDiaCompletedEventHandler TipoCambioDiaCompleted;
        
        /// <remarks/>
        public event TipoCambioDiaStringCompletedEventHandler TipoCambioDiaStringCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.banguat.gob.gt/variables/ws/VariablesDisponibles", RequestNamespace="http://www.banguat.gob.gt/variables/ws/", ResponseNamespace="http://www.banguat.gob.gt/variables/ws/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public InfoVariable VariablesDisponibles() {
            object[] results = this.Invoke("VariablesDisponibles", new object[0]);
            return ((InfoVariable)(results[0]));
        }
        
        /// <remarks/>
        public void VariablesDisponiblesAsync() {
            this.VariablesDisponiblesAsync(null);
        }
        
        /// <remarks/>
        public void VariablesDisponiblesAsync(object userState) {
            if ((this.VariablesDisponiblesOperationCompleted == null)) {
                this.VariablesDisponiblesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVariablesDisponiblesOperationCompleted);
            }
            this.InvokeAsync("VariablesDisponibles", new object[0], this.VariablesDisponiblesOperationCompleted, userState);
        }
        
        private void OnVariablesDisponiblesOperationCompleted(object arg) {
            if ((this.VariablesDisponiblesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VariablesDisponiblesCompleted(this, new VariablesDisponiblesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.banguat.gob.gt/variables/ws/Variables", RequestNamespace="http://www.banguat.gob.gt/variables/ws/", ResponseNamespace="http://www.banguat.gob.gt/variables/ws/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public InfoVariable Variables(int variable) {
            object[] results = this.Invoke("Variables", new object[] {
                        variable});
            return ((InfoVariable)(results[0]));
        }
        
        /// <remarks/>
        public void VariablesAsync(int variable) {
            this.VariablesAsync(variable, null);
        }
        
        /// <remarks/>
        public void VariablesAsync(int variable, object userState) {
            if ((this.VariablesOperationCompleted == null)) {
                this.VariablesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVariablesOperationCompleted);
            }
            this.InvokeAsync("Variables", new object[] {
                        variable}, this.VariablesOperationCompleted, userState);
        }
        
        private void OnVariablesOperationCompleted(object arg) {
            if ((this.VariablesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VariablesCompleted(this, new VariablesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.banguat.gob.gt/variables/ws/TipoCambioFechaInicial", RequestNamespace="http://www.banguat.gob.gt/variables/ws/", ResponseNamespace="http://www.banguat.gob.gt/variables/ws/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DataVariable TipoCambioFechaInicial(string fechainit) {
            object[] results = this.Invoke("TipoCambioFechaInicial", new object[] {
                        fechainit});
            return ((DataVariable)(results[0]));
        }
        
        /// <remarks/>
        public void TipoCambioFechaInicialAsync(string fechainit) {
            this.TipoCambioFechaInicialAsync(fechainit, null);
        }
        
        /// <remarks/>
        public void TipoCambioFechaInicialAsync(string fechainit, object userState) {
            if ((this.TipoCambioFechaInicialOperationCompleted == null)) {
                this.TipoCambioFechaInicialOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTipoCambioFechaInicialOperationCompleted);
            }
            this.InvokeAsync("TipoCambioFechaInicial", new object[] {
                        fechainit}, this.TipoCambioFechaInicialOperationCompleted, userState);
        }
        
        private void OnTipoCambioFechaInicialOperationCompleted(object arg) {
            if ((this.TipoCambioFechaInicialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TipoCambioFechaInicialCompleted(this, new TipoCambioFechaInicialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.banguat.gob.gt/variables/ws/TipoCambioRango", RequestNamespace="http://www.banguat.gob.gt/variables/ws/", ResponseNamespace="http://www.banguat.gob.gt/variables/ws/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DataVariable TipoCambioRango(string fechainit, string fechafin) {
            object[] results = this.Invoke("TipoCambioRango", new object[] {
                        fechainit,
                        fechafin});
            return ((DataVariable)(results[0]));
        }
        
        /// <remarks/>
        public void TipoCambioRangoAsync(string fechainit, string fechafin) {
            this.TipoCambioRangoAsync(fechainit, fechafin, null);
        }
        
        /// <remarks/>
        public void TipoCambioRangoAsync(string fechainit, string fechafin, object userState) {
            if ((this.TipoCambioRangoOperationCompleted == null)) {
                this.TipoCambioRangoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTipoCambioRangoOperationCompleted);
            }
            this.InvokeAsync("TipoCambioRango", new object[] {
                        fechainit,
                        fechafin}, this.TipoCambioRangoOperationCompleted, userState);
        }
        
        private void OnTipoCambioRangoOperationCompleted(object arg) {
            if ((this.TipoCambioRangoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TipoCambioRangoCompleted(this, new TipoCambioRangoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.banguat.gob.gt/variables/ws/TipoCambioFechaInicialMoneda", RequestNamespace="http://www.banguat.gob.gt/variables/ws/", ResponseNamespace="http://www.banguat.gob.gt/variables/ws/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DataVariable TipoCambioFechaInicialMoneda(string fechainit, int moneda) {
            object[] results = this.Invoke("TipoCambioFechaInicialMoneda", new object[] {
                        fechainit,
                        moneda});
            return ((DataVariable)(results[0]));
        }
        
        /// <remarks/>
        public void TipoCambioFechaInicialMonedaAsync(string fechainit, int moneda) {
            this.TipoCambioFechaInicialMonedaAsync(fechainit, moneda, null);
        }
        
        /// <remarks/>
        public void TipoCambioFechaInicialMonedaAsync(string fechainit, int moneda, object userState) {
            if ((this.TipoCambioFechaInicialMonedaOperationCompleted == null)) {
                this.TipoCambioFechaInicialMonedaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTipoCambioFechaInicialMonedaOperationCompleted);
            }
            this.InvokeAsync("TipoCambioFechaInicialMoneda", new object[] {
                        fechainit,
                        moneda}, this.TipoCambioFechaInicialMonedaOperationCompleted, userState);
        }
        
        private void OnTipoCambioFechaInicialMonedaOperationCompleted(object arg) {
            if ((this.TipoCambioFechaInicialMonedaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TipoCambioFechaInicialMonedaCompleted(this, new TipoCambioFechaInicialMonedaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.banguat.gob.gt/variables/ws/TipoCambioRangoMoneda", RequestNamespace="http://www.banguat.gob.gt/variables/ws/", ResponseNamespace="http://www.banguat.gob.gt/variables/ws/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DataVariable TipoCambioRangoMoneda(string fechainit, string fechafin, int moneda) {
            object[] results = this.Invoke("TipoCambioRangoMoneda", new object[] {
                        fechainit,
                        fechafin,
                        moneda});
            return ((DataVariable)(results[0]));
        }
        
        /// <remarks/>
        public void TipoCambioRangoMonedaAsync(string fechainit, string fechafin, int moneda) {
            this.TipoCambioRangoMonedaAsync(fechainit, fechafin, moneda, null);
        }
        
        /// <remarks/>
        public void TipoCambioRangoMonedaAsync(string fechainit, string fechafin, int moneda, object userState) {
            if ((this.TipoCambioRangoMonedaOperationCompleted == null)) {
                this.TipoCambioRangoMonedaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTipoCambioRangoMonedaOperationCompleted);
            }
            this.InvokeAsync("TipoCambioRangoMoneda", new object[] {
                        fechainit,
                        fechafin,
                        moneda}, this.TipoCambioRangoMonedaOperationCompleted, userState);
        }
        
        private void OnTipoCambioRangoMonedaOperationCompleted(object arg) {
            if ((this.TipoCambioRangoMonedaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TipoCambioRangoMonedaCompleted(this, new TipoCambioRangoMonedaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.banguat.gob.gt/variables/ws/TipoCambioDia", RequestNamespace="http://www.banguat.gob.gt/variables/ws/", ResponseNamespace="http://www.banguat.gob.gt/variables/ws/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public InfoVariable TipoCambioDia() {
            object[] results = this.Invoke("TipoCambioDia", new object[0]);
            return ((InfoVariable)(results[0]));
        }
        
        /// <remarks/>
        public void TipoCambioDiaAsync() {
            this.TipoCambioDiaAsync(null);
        }
        
        /// <remarks/>
        public void TipoCambioDiaAsync(object userState) {
            if ((this.TipoCambioDiaOperationCompleted == null)) {
                this.TipoCambioDiaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTipoCambioDiaOperationCompleted);
            }
            this.InvokeAsync("TipoCambioDia", new object[0], this.TipoCambioDiaOperationCompleted, userState);
        }
        
        private void OnTipoCambioDiaOperationCompleted(object arg) {
            if ((this.TipoCambioDiaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TipoCambioDiaCompleted(this, new TipoCambioDiaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.banguat.gob.gt/variables/ws/TipoCambioDiaString", RequestNamespace="http://www.banguat.gob.gt/variables/ws/", ResponseNamespace="http://www.banguat.gob.gt/variables/ws/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string TipoCambioDiaString() {
            object[] results = this.Invoke("TipoCambioDiaString", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void TipoCambioDiaStringAsync() {
            this.TipoCambioDiaStringAsync(null);
        }
        
        /// <remarks/>
        public void TipoCambioDiaStringAsync(object userState) {
            if ((this.TipoCambioDiaStringOperationCompleted == null)) {
                this.TipoCambioDiaStringOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTipoCambioDiaStringOperationCompleted);
            }
            this.InvokeAsync("TipoCambioDiaString", new object[0], this.TipoCambioDiaStringOperationCompleted, userState);
        }
        
        private void OnTipoCambioDiaStringOperationCompleted(object arg) {
            if ((this.TipoCambioDiaStringCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TipoCambioDiaStringCompleted(this, new TipoCambioDiaStringCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.banguat.gob.gt/variables/ws/")]
    public partial class InfoVariable {
        
        private Variable[] variablesField;
        
        private Var[] cambioDiaField;
        
        private VarDolar[] cambioDolarField;
        
        private int totalItemsField;
        
        /// <remarks/>
        public Variable[] Variables {
            get {
                return this.variablesField;
            }
            set {
                this.variablesField = value;
            }
        }
        
        /// <remarks/>
        public Var[] CambioDia {
            get {
                return this.cambioDiaField;
            }
            set {
                this.cambioDiaField = value;
            }
        }
        
        /// <remarks/>
        public VarDolar[] CambioDolar {
            get {
                return this.cambioDolarField;
            }
            set {
                this.cambioDolarField = value;
            }
        }
        
        /// <remarks/>
        public int TotalItems {
            get {
                return this.totalItemsField;
            }
            set {
                this.totalItemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.banguat.gob.gt/variables/ws/")]
    public partial class Variable {
        
        private int monedaField;
        
        private string descripcionField;
        
        /// <remarks/>
        public int moneda {
            get {
                return this.monedaField;
            }
            set {
                this.monedaField = value;
            }
        }
        
        /// <remarks/>
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.banguat.gob.gt/variables/ws/")]
    public partial class DataVariable {
        
        private Var[] varsField;
        
        private int totalItemsField;
        
        /// <remarks/>
        public Var[] Vars {
            get {
                return this.varsField;
            }
            set {
                this.varsField = value;
            }
        }
        
        /// <remarks/>
        public int TotalItems {
            get {
                return this.totalItemsField;
            }
            set {
                this.totalItemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.banguat.gob.gt/variables/ws/")]
    public partial class Var {
        
        private int monedaField;
        
        private string fechaField;
        
        private float ventaField;
        
        private float compraField;
        
        /// <remarks/>
        public int moneda {
            get {
                return this.monedaField;
            }
            set {
                this.monedaField = value;
            }
        }
        
        /// <remarks/>
        public string fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
            }
        }
        
        /// <remarks/>
        public float venta {
            get {
                return this.ventaField;
            }
            set {
                this.ventaField = value;
            }
        }
        
        /// <remarks/>
        public float compra {
            get {
                return this.compraField;
            }
            set {
                this.compraField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.banguat.gob.gt/variables/ws/")]
    public partial class VarDolar {
        
        private string fechaField;
        
        private float referenciaField;
        
        /// <remarks/>
        public string fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
            }
        }
        
        /// <remarks/>
        public float referencia {
            get {
                return this.referenciaField;
            }
            set {
                this.referenciaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void VariablesDisponiblesCompletedEventHandler(object sender, VariablesDisponiblesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VariablesDisponiblesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VariablesDisponiblesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public InfoVariable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((InfoVariable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void VariablesCompletedEventHandler(object sender, VariablesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VariablesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VariablesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public InfoVariable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((InfoVariable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void TipoCambioFechaInicialCompletedEventHandler(object sender, TipoCambioFechaInicialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TipoCambioFechaInicialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TipoCambioFechaInicialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DataVariable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DataVariable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void TipoCambioRangoCompletedEventHandler(object sender, TipoCambioRangoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TipoCambioRangoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TipoCambioRangoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DataVariable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DataVariable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void TipoCambioFechaInicialMonedaCompletedEventHandler(object sender, TipoCambioFechaInicialMonedaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TipoCambioFechaInicialMonedaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TipoCambioFechaInicialMonedaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DataVariable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DataVariable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void TipoCambioRangoMonedaCompletedEventHandler(object sender, TipoCambioRangoMonedaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TipoCambioRangoMonedaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TipoCambioRangoMonedaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DataVariable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DataVariable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void TipoCambioDiaCompletedEventHandler(object sender, TipoCambioDiaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TipoCambioDiaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TipoCambioDiaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public InfoVariable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((InfoVariable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void TipoCambioDiaStringCompletedEventHandler(object sender, TipoCambioDiaStringCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TipoCambioDiaStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TipoCambioDiaStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591