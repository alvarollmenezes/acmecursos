﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcmeCursos.WCFClient.ProfessorService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Professor", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Models")]
    [System.SerializableAttribute()]
    public partial class Professor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.WCFClient.ProfessorService.Curso[] CursosField;
        
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
        public AcmeCursos.WCFClient.ProfessorService.Curso[] Cursos {
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
        private AcmeCursos.WCFClient.ProfessorService.Inscricao[] InscricoesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.WCFClient.ProfessorService.Professor[] ProfessoresField;
        
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
        public AcmeCursos.WCFClient.ProfessorService.Inscricao[] Inscricoes {
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
        public AcmeCursos.WCFClient.ProfessorService.Professor[] Professores {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Inscricao", Namespace="http://schemas.datacontract.org/2004/07/AcmeCursos.Models")]
    [System.SerializableAttribute()]
    public partial class Inscricao : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.WCFClient.ProfessorService.Curso CursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CursoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataInscricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AcmeCursos.WCFClient.ProfessorService.Estudante EstudanteField;
        
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
        public AcmeCursos.WCFClient.ProfessorService.Curso Curso {
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
        public AcmeCursos.WCFClient.ProfessorService.Estudante Estudante {
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
        private AcmeCursos.WCFClient.ProfessorService.Inscricao[] InscricoesField;
        
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
        public AcmeCursos.WCFClient.ProfessorService.Inscricao[] Inscricoes {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProfessorService.IProfessorService")]
    public interface IProfessorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetAll", ReplyAction="http://tempuri.org/IProfessorService/GetAllResponse")]
        AcmeCursos.WCFClient.ProfessorService.Professor[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetAll", ReplyAction="http://tempuri.org/IProfessorService/GetAllResponse")]
        System.Threading.Tasks.Task<AcmeCursos.WCFClient.ProfessorService.Professor[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetById", ReplyAction="http://tempuri.org/IProfessorService/GetByIdResponse")]
        AcmeCursos.WCFClient.ProfessorService.Professor GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetById", ReplyAction="http://tempuri.org/IProfessorService/GetByIdResponse")]
        System.Threading.Tasks.Task<AcmeCursos.WCFClient.ProfessorService.Professor> GetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetByIdWithCursos", ReplyAction="http://tempuri.org/IProfessorService/GetByIdWithCursosResponse")]
        AcmeCursos.WCFClient.ProfessorService.Professor GetByIdWithCursos(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetByIdWithCursos", ReplyAction="http://tempuri.org/IProfessorService/GetByIdWithCursosResponse")]
        System.Threading.Tasks.Task<AcmeCursos.WCFClient.ProfessorService.Professor> GetByIdWithCursosAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Create", ReplyAction="http://tempuri.org/IProfessorService/CreateResponse")]
        void Create(AcmeCursos.WCFClient.ProfessorService.Professor professor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Create", ReplyAction="http://tempuri.org/IProfessorService/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(AcmeCursos.WCFClient.ProfessorService.Professor professor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Edit", ReplyAction="http://tempuri.org/IProfessorService/EditResponse")]
        void Edit(AcmeCursos.WCFClient.ProfessorService.Professor professor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Edit", ReplyAction="http://tempuri.org/IProfessorService/EditResponse")]
        System.Threading.Tasks.Task EditAsync(AcmeCursos.WCFClient.ProfessorService.Professor professor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Delete", ReplyAction="http://tempuri.org/IProfessorService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Delete", ReplyAction="http://tempuri.org/IProfessorService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProfessorServiceChannel : AcmeCursos.WCFClient.ProfessorService.IProfessorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProfessorServiceClient : System.ServiceModel.ClientBase<AcmeCursos.WCFClient.ProfessorService.IProfessorService>, AcmeCursos.WCFClient.ProfessorService.IProfessorService {
        
        public ProfessorServiceClient() {
        }
        
        public ProfessorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProfessorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProfessorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProfessorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AcmeCursos.WCFClient.ProfessorService.Professor[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<AcmeCursos.WCFClient.ProfessorService.Professor[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public AcmeCursos.WCFClient.ProfessorService.Professor GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<AcmeCursos.WCFClient.ProfessorService.Professor> GetByIdAsync(int id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public AcmeCursos.WCFClient.ProfessorService.Professor GetByIdWithCursos(int id) {
            return base.Channel.GetByIdWithCursos(id);
        }
        
        public System.Threading.Tasks.Task<AcmeCursos.WCFClient.ProfessorService.Professor> GetByIdWithCursosAsync(int id) {
            return base.Channel.GetByIdWithCursosAsync(id);
        }
        
        public void Create(AcmeCursos.WCFClient.ProfessorService.Professor professor) {
            base.Channel.Create(professor);
        }
        
        public System.Threading.Tasks.Task CreateAsync(AcmeCursos.WCFClient.ProfessorService.Professor professor) {
            return base.Channel.CreateAsync(professor);
        }
        
        public void Edit(AcmeCursos.WCFClient.ProfessorService.Professor professor) {
            base.Channel.Edit(professor);
        }
        
        public System.Threading.Tasks.Task EditAsync(AcmeCursos.WCFClient.ProfessorService.Professor professor) {
            return base.Channel.EditAsync(professor);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
