﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonitorBoletos.DesktopView.MBSVC {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost/", ConfigurationName="MBSVC.DefaultSoap")]
    public interface DefaultSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/HelloWorld2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld2(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/HelloWorld2", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorld2Async(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SomarValores", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int SomarValores(int valor1, int valor2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SomarValores", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SomarValoresAsync(int valor1, int valor2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/FazerAlgo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        MonitorBoletos.DesktopView.MBSVC.MyObj FazerAlgo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/FazerAlgo", ReplyAction="*")]
        System.Threading.Tasks.Task<MonitorBoletos.DesktopView.MBSVC.MyObj> FazerAlgoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/TituloPorNossoNumero", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        MonitorBoletos.DesktopView.MBSVC.CronnSgvCobranca TituloPorNossoNumero(string nossoNumero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/TituloPorNossoNumero", ReplyAction="*")]
        System.Threading.Tasks.Task<MonitorBoletos.DesktopView.MBSVC.CronnSgvCobranca> TituloPorNossoNumeroAsync(string nossoNumero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/ObterListaTitulos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        MonitorBoletos.DesktopView.MBSVC.CronnSgvCobranca[] ObterListaTitulos(string[] ListNossoNumero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/ObterListaTitulos", ReplyAction="*")]
        System.Threading.Tasks.Task<MonitorBoletos.DesktopView.MBSVC.CronnSgvCobranca[]> ObterListaTitulosAsync(string[] ListNossoNumero);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://localhost/")]
    public partial class MyObj : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idadeField;
        
        private string nomeField;
        
        private string chatoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Idade {
            get {
                return this.idadeField;
            }
            set {
                this.idadeField = value;
                this.RaisePropertyChanged("Idade");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
                this.RaisePropertyChanged("Nome");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Chato {
            get {
                return this.chatoField;
            }
            set {
                this.chatoField = value;
                this.RaisePropertyChanged("Chato");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://localhost/")]
    public partial class CronnSgvCobranca : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long idField;
        
        private System.Nullable<System.DateTime> dataCobrancaField;
        
        private System.Nullable<decimal> valorPagtoField;
        
        private System.Nullable<decimal> valorTotalField;
        
        private string boletoLinhaDigField;
        
        private System.Nullable<decimal> boletoValorField;
        
        private string boletoNossoNroField;
        
        private string dacField;
        
        private string boletoCodBarrasField;
        
        private System.Nullable<decimal> custoBoletoField;
        
        private System.Nullable<int> tipoCobrancaField;
        
        private string situacaoField;
        
        private System.Nullable<System.DateTime> dataVencimentoField;
        
        private System.Nullable<System.DateTime> dataPagamentoField;
        
        private System.Nullable<decimal> jurosField;
        
        private System.Nullable<decimal> multaField;
        
        private System.Nullable<decimal> outrosAcrescimosField;
        
        private System.Nullable<decimal> valorTituloField;
        
        private string numeroDocumentoField;
        
        private string parcelaField;
        
        private System.Nullable<System.DateTime> dataImpressaoField;
        
        private string usuarioImpressaoField;
        
        private System.Nullable<bool> cobrancaRedeField;
        
        private System.Nullable<bool> limiteUnificadoField;
        
        private System.Nullable<bool> emailEnviadoField;
        
        private string iniciativaRegeracaoField;
        
        private System.Nullable<System.DateTime> dataProcessamentoField;
        
        private System.Nullable<long> idClienteField;
        
        private System.Nullable<long> idCobrancaOrigemField;
        
        private System.Nullable<long> idNegociacaoCobrancaField;
        
        private System.Nullable<long> idConvenioBancarioField;
        
        private System.Nullable<long> idParametroCobrancaField;
        
        private string idTerminalField;
        
        private System.Nullable<long> idRedeField;
        
        private System.Nullable<long> idResponsavelLimiteField;
        
        private System.Nullable<long> idEmpresaField;
        
        private System.Nullable<System.DateTime> dataInclusaoField;
        
        private System.Nullable<System.DateTime> dataAlteracaoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<System.DateTime> DataCobranca {
            get {
                return this.dataCobrancaField;
            }
            set {
                this.dataCobrancaField = value;
                this.RaisePropertyChanged("DataCobranca");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<decimal> ValorPagto {
            get {
                return this.valorPagtoField;
            }
            set {
                this.valorPagtoField = value;
                this.RaisePropertyChanged("ValorPagto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<decimal> ValorTotal {
            get {
                return this.valorTotalField;
            }
            set {
                this.valorTotalField = value;
                this.RaisePropertyChanged("ValorTotal");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string BoletoLinhaDig {
            get {
                return this.boletoLinhaDigField;
            }
            set {
                this.boletoLinhaDigField = value;
                this.RaisePropertyChanged("BoletoLinhaDig");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public System.Nullable<decimal> BoletoValor {
            get {
                return this.boletoValorField;
            }
            set {
                this.boletoValorField = value;
                this.RaisePropertyChanged("BoletoValor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string BoletoNossoNro {
            get {
                return this.boletoNossoNroField;
            }
            set {
                this.boletoNossoNroField = value;
                this.RaisePropertyChanged("BoletoNossoNro");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Dac {
            get {
                return this.dacField;
            }
            set {
                this.dacField = value;
                this.RaisePropertyChanged("Dac");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string BoletoCodBarras {
            get {
                return this.boletoCodBarrasField;
            }
            set {
                this.boletoCodBarrasField = value;
                this.RaisePropertyChanged("BoletoCodBarras");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public System.Nullable<decimal> CustoBoleto {
            get {
                return this.custoBoletoField;
            }
            set {
                this.custoBoletoField = value;
                this.RaisePropertyChanged("CustoBoleto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public System.Nullable<int> TipoCobranca {
            get {
                return this.tipoCobrancaField;
            }
            set {
                this.tipoCobrancaField = value;
                this.RaisePropertyChanged("TipoCobranca");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string Situacao {
            get {
                return this.situacaoField;
            }
            set {
                this.situacaoField = value;
                this.RaisePropertyChanged("Situacao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<System.DateTime> DataVencimento {
            get {
                return this.dataVencimentoField;
            }
            set {
                this.dataVencimentoField = value;
                this.RaisePropertyChanged("DataVencimento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public System.Nullable<System.DateTime> DataPagamento {
            get {
                return this.dataPagamentoField;
            }
            set {
                this.dataPagamentoField = value;
                this.RaisePropertyChanged("DataPagamento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<decimal> Juros {
            get {
                return this.jurosField;
            }
            set {
                this.jurosField = value;
                this.RaisePropertyChanged("Juros");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public System.Nullable<decimal> Multa {
            get {
                return this.multaField;
            }
            set {
                this.multaField = value;
                this.RaisePropertyChanged("Multa");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
        public System.Nullable<decimal> OutrosAcrescimos {
            get {
                return this.outrosAcrescimosField;
            }
            set {
                this.outrosAcrescimosField = value;
                this.RaisePropertyChanged("OutrosAcrescimos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=17)]
        public System.Nullable<decimal> ValorTitulo {
            get {
                return this.valorTituloField;
            }
            set {
                this.valorTituloField = value;
                this.RaisePropertyChanged("ValorTitulo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string NumeroDocumento {
            get {
                return this.numeroDocumentoField;
            }
            set {
                this.numeroDocumentoField = value;
                this.RaisePropertyChanged("NumeroDocumento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public string Parcela {
            get {
                return this.parcelaField;
            }
            set {
                this.parcelaField = value;
                this.RaisePropertyChanged("Parcela");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=20)]
        public System.Nullable<System.DateTime> DataImpressao {
            get {
                return this.dataImpressaoField;
            }
            set {
                this.dataImpressaoField = value;
                this.RaisePropertyChanged("DataImpressao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public string UsuarioImpressao {
            get {
                return this.usuarioImpressaoField;
            }
            set {
                this.usuarioImpressaoField = value;
                this.RaisePropertyChanged("UsuarioImpressao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
        public System.Nullable<bool> CobrancaRede {
            get {
                return this.cobrancaRedeField;
            }
            set {
                this.cobrancaRedeField = value;
                this.RaisePropertyChanged("CobrancaRede");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=23)]
        public System.Nullable<bool> LimiteUnificado {
            get {
                return this.limiteUnificadoField;
            }
            set {
                this.limiteUnificadoField = value;
                this.RaisePropertyChanged("LimiteUnificado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=24)]
        public System.Nullable<bool> EmailEnviado {
            get {
                return this.emailEnviadoField;
            }
            set {
                this.emailEnviadoField = value;
                this.RaisePropertyChanged("EmailEnviado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public string IniciativaRegeracao {
            get {
                return this.iniciativaRegeracaoField;
            }
            set {
                this.iniciativaRegeracaoField = value;
                this.RaisePropertyChanged("IniciativaRegeracao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=26)]
        public System.Nullable<System.DateTime> DataProcessamento {
            get {
                return this.dataProcessamentoField;
            }
            set {
                this.dataProcessamentoField = value;
                this.RaisePropertyChanged("DataProcessamento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=27)]
        public System.Nullable<long> IdCliente {
            get {
                return this.idClienteField;
            }
            set {
                this.idClienteField = value;
                this.RaisePropertyChanged("IdCliente");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=28)]
        public System.Nullable<long> IdCobrancaOrigem {
            get {
                return this.idCobrancaOrigemField;
            }
            set {
                this.idCobrancaOrigemField = value;
                this.RaisePropertyChanged("IdCobrancaOrigem");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=29)]
        public System.Nullable<long> IdNegociacaoCobranca {
            get {
                return this.idNegociacaoCobrancaField;
            }
            set {
                this.idNegociacaoCobrancaField = value;
                this.RaisePropertyChanged("IdNegociacaoCobranca");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=30)]
        public System.Nullable<long> IdConvenioBancario {
            get {
                return this.idConvenioBancarioField;
            }
            set {
                this.idConvenioBancarioField = value;
                this.RaisePropertyChanged("IdConvenioBancario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=31)]
        public System.Nullable<long> IdParametroCobranca {
            get {
                return this.idParametroCobrancaField;
            }
            set {
                this.idParametroCobrancaField = value;
                this.RaisePropertyChanged("IdParametroCobranca");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=32)]
        public string IdTerminal {
            get {
                return this.idTerminalField;
            }
            set {
                this.idTerminalField = value;
                this.RaisePropertyChanged("IdTerminal");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=33)]
        public System.Nullable<long> IdRede {
            get {
                return this.idRedeField;
            }
            set {
                this.idRedeField = value;
                this.RaisePropertyChanged("IdRede");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=34)]
        public System.Nullable<long> IdResponsavelLimite {
            get {
                return this.idResponsavelLimiteField;
            }
            set {
                this.idResponsavelLimiteField = value;
                this.RaisePropertyChanged("IdResponsavelLimite");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=35)]
        public System.Nullable<long> IdEmpresa {
            get {
                return this.idEmpresaField;
            }
            set {
                this.idEmpresaField = value;
                this.RaisePropertyChanged("IdEmpresa");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=36)]
        public System.Nullable<System.DateTime> DataInclusao {
            get {
                return this.dataInclusaoField;
            }
            set {
                this.dataInclusaoField = value;
                this.RaisePropertyChanged("DataInclusao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=37)]
        public System.Nullable<System.DateTime> DataAlteracao {
            get {
                return this.dataAlteracaoField;
            }
            set {
                this.dataAlteracaoField = value;
                this.RaisePropertyChanged("DataAlteracao");
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
    public interface DefaultSoapChannel : MonitorBoletos.DesktopView.MBSVC.DefaultSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DefaultSoapClient : System.ServiceModel.ClientBase<MonitorBoletos.DesktopView.MBSVC.DefaultSoap>, MonitorBoletos.DesktopView.MBSVC.DefaultSoap {
        
        public DefaultSoapClient() {
        }
        
        public DefaultSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DefaultSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public string HelloWorld2(string nome) {
            return base.Channel.HelloWorld2(nome);
        }
        
        public System.Threading.Tasks.Task<string> HelloWorld2Async(string nome) {
            return base.Channel.HelloWorld2Async(nome);
        }
        
        public int SomarValores(int valor1, int valor2) {
            return base.Channel.SomarValores(valor1, valor2);
        }
        
        public System.Threading.Tasks.Task<int> SomarValoresAsync(int valor1, int valor2) {
            return base.Channel.SomarValoresAsync(valor1, valor2);
        }
        
        public MonitorBoletos.DesktopView.MBSVC.MyObj FazerAlgo() {
            return base.Channel.FazerAlgo();
        }
        
        public System.Threading.Tasks.Task<MonitorBoletos.DesktopView.MBSVC.MyObj> FazerAlgoAsync() {
            return base.Channel.FazerAlgoAsync();
        }
        
        public MonitorBoletos.DesktopView.MBSVC.CronnSgvCobranca TituloPorNossoNumero(string nossoNumero) {
            return base.Channel.TituloPorNossoNumero(nossoNumero);
        }
        
        public System.Threading.Tasks.Task<MonitorBoletos.DesktopView.MBSVC.CronnSgvCobranca> TituloPorNossoNumeroAsync(string nossoNumero) {
            return base.Channel.TituloPorNossoNumeroAsync(nossoNumero);
        }
        
        public MonitorBoletos.DesktopView.MBSVC.CronnSgvCobranca[] ObterListaTitulos(string[] ListNossoNumero) {
            return base.Channel.ObterListaTitulos(ListNossoNumero);
        }
        
        public System.Threading.Tasks.Task<MonitorBoletos.DesktopView.MBSVC.CronnSgvCobranca[]> ObterListaTitulosAsync(string[] ListNossoNumero) {
            return base.Channel.ObterListaTitulosAsync(ListNossoNumero);
        }
    }
}
