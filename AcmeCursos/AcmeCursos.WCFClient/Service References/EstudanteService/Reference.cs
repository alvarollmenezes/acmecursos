﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcmeCursos.WCFClient.EstudanteService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Estudante", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Models")]
    [System.SerializableAttribute()]
    public partial class Estudante : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataMatriculaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.WCFClient.EstudanteService.Inscricao[] InscricoesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SobrenomeField;
        
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
        public System.DateTime DataMatricula {
            get {
                return this.DataMatriculaField;
            }
            set {
                if ((this.DataMatriculaField.Equals(value) != true)) {
                    this.DataMatriculaField = value;
                    this.RaisePropertyChanged("DataMatricula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AcmeCursos.WCFClient.EstudanteService.Inscricao[] Inscricoes {
            get {
                return this.InscricoesField;
            }
            set {
                if ((object.ReferenceEquals(this.InscricoesField, value) != true)) {
                    this.InscricoesField = value;
                    this.RaisePropertyChanged("Inscricoes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sobrenome {
            get {
                return this.SobrenomeField;
            }
            set {
                if ((object.ReferenceEquals(this.SobrenomeField, value) != true)) {
                    this.SobrenomeField = value;
                    this.RaisePropertyChanged("Sobrenome");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Inscricao", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Models")]
    [System.SerializableAttribute()]
    public partial class Inscricao : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.WCFClient.EstudanteService.Curso CursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CursoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataInscricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.WCFClient.EstudanteService.Estudante EstudanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstudanteIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public AcmeCursos.WCFClient.EstudanteService.Curso Curso {
            get {
                return this.CursoField;
            }
            set {
                if ((object.ReferenceEquals(this.CursoField, value) != true)) {
                    this.CursoField = value;
                    this.RaisePropertyChanged("Curso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CursoId {
            get {
                return this.CursoIdField;
            }
            set {
                if ((this.CursoIdField.Equals(value) != true)) {
                    this.CursoIdField = value;
                    this.RaisePropertyChanged("CursoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataInscricao {
            get {
                return this.DataInscricaoField;
            }
            set {
                if ((this.DataInscricaoField.Equals(value) != true)) {
                    this.DataInscricaoField = value;
                    this.RaisePropertyChanged("DataInscricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AcmeCursos.WCFClient.EstudanteService.Estudante Estudante {
            get {
                return this.EstudanteField;
            }
            set {
                if ((object.ReferenceEquals(this.EstudanteField, value) != true)) {
                    this.EstudanteField = value;
                    this.RaisePropertyChanged("Estudante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EstudanteId {
            get {
                return this.EstudanteIdField;
            }
            set {
                if ((this.EstudanteIdField.Equals(value) != true)) {
                    this.EstudanteIdField = value;
                    this.RaisePropertyChanged("EstudanteId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Curso", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Models")]
    [System.SerializableAttribute()]
    public partial class Curso : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataLimiteInscricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.WCFClient.EstudanteService.Inscricao[] InscricoesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.WCFClient.EstudanteService.Professor[] ProfessoresField;
        
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
        public System.DateTime DataLimiteInscricao {
            get {
                return this.DataLimiteInscricaoField;
            }
            set {
                if ((this.DataLimiteInscricaoField.Equals(value) != true)) {
                    this.DataLimiteInscricaoField = value;
                    this.RaisePropertyChanged("DataLimiteInscricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AcmeCursos.WCFClient.EstudanteService.Inscricao[] Inscricoes {
            get {
                return this.InscricoesField;
            }
            set {
                if ((object.ReferenceEquals(this.InscricoesField, value) != true)) {
                    this.InscricoesField = value;
                    this.RaisePropertyChanged("Inscricoes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AcmeCursos.WCFClient.EstudanteService.Professor[] Professores {
            get {
                return this.ProfessoresField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfessoresField, value) != true)) {
                    this.ProfessoresField = value;
                    this.RaisePropertyChanged("Professores");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Professor", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Models")]
    [System.SerializableAttribute()]
    public partial class Professor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.WCFClient.EstudanteService.Curso[] CursosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SobrenomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitulacaoField;
        
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
        public AcmeCursos.WCFClient.EstudanteService.Curso[] Cursos {
            get {
                return this.CursosField;
            }
            set {
                if ((object.ReferenceEquals(this.CursosField, value) != true)) {
                    this.CursosField = value;
                    this.RaisePropertyChanged("Cursos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sobrenome {
            get {
                return this.SobrenomeField;
            }
            set {
                if ((object.ReferenceEquals(this.SobrenomeField, value) != true)) {
                    this.SobrenomeField = value;
                    this.RaisePropertyChanged("Sobrenome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titulacao {
            get {
                return this.TitulacaoField;
            }
            set {
                if ((object.ReferenceEquals(this.TitulacaoField, value) != true)) {
                    this.TitulacaoField = value;
                    this.RaisePropertyChanged("Titulacao");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EstudanteService.IEstudanteService")]
    public interface IEstudanteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudanteService/GetAll", ReplyAction="http://tempuri.org/IEstudanteService/GetAllResponse")]
        AcmeCursos.WCFClient.EstudanteService.Estudante[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudanteService/GetAll", ReplyAction="http://tempuri.org/IEstudanteService/GetAllResponse")]
        System.Threading.Tasks.Task<AcmeCursos.WCFClient.EstudanteService.Estudante[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudanteService/GetById", ReplyAction="http://tempuri.org/IEstudanteService/GetByIdResponse")]
        AcmeCursos.WCFClient.EstudanteService.Estudante GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudanteService/GetById", ReplyAction="http://tempuri.org/IEstudanteService/GetByIdResponse")]
        System.Threading.Tasks.Task<AcmeCursos.WCFClient.EstudanteService.Estudante> GetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudanteService/GetByIdWithInscricoes", ReplyAction="http://tempuri.org/IEstudanteService/GetByIdWithInscricoesResponse")]
        AcmeCursos.WCFClient.EstudanteService.Estudante GetByIdWithInscricoes(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudanteService/GetByIdWithInscricoes", ReplyAction="http://tempuri.org/IEstudanteService/GetByIdWithInscricoesResponse")]
        System.Threading.Tasks.Task<AcmeCursos.WCFClient.EstudanteService.Estudante> GetByIdWithInscricoesAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudanteService/Create", ReplyAction="http://tempuri.org/IEstudanteService/CreateResponse")]
        void Create(AcmeCursos.WCFClient.EstudanteService.Estudante estudante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudanteService/Create", ReplyAction="http://tempuri.org/IEstudanteService/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(AcmeCursos.WCFClient.EstudanteService.Estudante estudante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudanteService/Edit", ReplyAction="http://tempuri.org/IEstudanteService/EditResponse")]
        void Edit(AcmeCursos.WCFClient.EstudanteService.Estudante estudante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudanteService/Edit", ReplyAction="http://tempuri.org/IEstudanteService/EditResponse")]
        System.Threading.Tasks.Task EditAsync(AcmeCursos.WCFClient.EstudanteService.Estudante estudante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudanteService/Delete", ReplyAction="http://tempuri.org/IEstudanteService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudanteService/Delete", ReplyAction="http://tempuri.org/IEstudanteService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEstudanteServiceChannel : AcmeCursos.WCFClient.EstudanteService.IEstudanteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EstudanteServiceClient : System.ServiceModel.ClientBase<AcmeCursos.WCFClient.EstudanteService.IEstudanteService>, AcmeCursos.WCFClient.EstudanteService.IEstudanteService {
        
        public EstudanteServiceClient() {
        }
        
        public EstudanteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EstudanteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstudanteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstudanteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AcmeCursos.WCFClient.EstudanteService.Estudante[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<AcmeCursos.WCFClient.EstudanteService.Estudante[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public AcmeCursos.WCFClient.EstudanteService.Estudante GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<AcmeCursos.WCFClient.EstudanteService.Estudante> GetByIdAsync(int id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public AcmeCursos.WCFClient.EstudanteService.Estudante GetByIdWithInscricoes(int id) {
            return base.Channel.GetByIdWithInscricoes(id);
        }
        
        public System.Threading.Tasks.Task<AcmeCursos.WCFClient.EstudanteService.Estudante> GetByIdWithInscricoesAsync(int id) {
            return base.Channel.GetByIdWithInscricoesAsync(id);
        }
        
        public void Create(AcmeCursos.WCFClient.EstudanteService.Estudante estudante) {
            base.Channel.Create(estudante);
        }
        
        public System.Threading.Tasks.Task CreateAsync(AcmeCursos.WCFClient.EstudanteService.Estudante estudante) {
            return base.Channel.CreateAsync(estudante);
        }
        
        public void Edit(AcmeCursos.WCFClient.EstudanteService.Estudante estudante) {
            base.Channel.Edit(estudante);
        }
        
        public System.Threading.Tasks.Task EditAsync(AcmeCursos.WCFClient.EstudanteService.Estudante estudante) {
            return base.Channel.EditAsync(estudante);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}