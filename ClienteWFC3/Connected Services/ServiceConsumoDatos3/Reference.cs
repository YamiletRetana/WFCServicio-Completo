﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWFC3.ServiceConsumoDatos3 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Respuesta", Namespace="http://schemas.datacontract.org/2004/07/WCFServicio")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClienteWFC3.ServiceConsumoDatos3.Empleado))]
    public partial class Respuesta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Empleado", Namespace="http://schemas.datacontract.org/2004/07/WCFServicio")]
    [System.SerializableAttribute()]
    public partial class Empleado : ClienteWFC3.ServiceConsumoDatos3.Respuesta {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PuestoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SalararioField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoM {
            get {
                return this.ApellidoMField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoMField, value) != true)) {
                    this.ApellidoMField = value;
                    this.RaisePropertyChanged("ApellidoM");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoP {
            get {
                return this.ApellidoPField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoPField, value) != true)) {
                    this.ApellidoPField = value;
                    this.RaisePropertyChanged("ApellidoP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Puesto {
            get {
                return this.PuestoField;
            }
            set {
                if ((object.ReferenceEquals(this.PuestoField, value) != true)) {
                    this.PuestoField = value;
                    this.RaisePropertyChanged("Puesto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Salarario {
            get {
                return this.SalararioField;
            }
            set {
                if ((object.ReferenceEquals(this.SalararioField, value) != true)) {
                    this.SalararioField = value;
                    this.RaisePropertyChanged("Salarario");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Respuesta3", Namespace="http://schemas.datacontract.org/2004/07/WCFServicio")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClienteWFC3.ServiceConsumoDatos3.Numeros))]
    public partial class Respuesta3 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Numeros", Namespace="http://schemas.datacontract.org/2004/07/WCFServicio")]
    [System.SerializableAttribute()]
    public partial class Numeros : ClienteWFC3.ServiceConsumoDatos3.Respuesta3 {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Numero1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Numero2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Numero3Field;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Numero1 {
            get {
                return this.Numero1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Numero1Field, value) != true)) {
                    this.Numero1Field = value;
                    this.RaisePropertyChanged("Numero1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Numero2 {
            get {
                return this.Numero2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Numero2Field, value) != true)) {
                    this.Numero2Field = value;
                    this.RaisePropertyChanged("Numero2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Numero3 {
            get {
                return this.Numero3Field;
            }
            set {
                if ((object.ReferenceEquals(this.Numero3Field, value) != true)) {
                    this.Numero3Field = value;
                    this.RaisePropertyChanged("Numero3");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Respuesta2", Namespace="http://schemas.datacontract.org/2004/07/WCFServicio")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClienteWFC3.ServiceConsumoDatos3.Escuela))]
    public partial class Respuesta2 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Escuela", Namespace="http://schemas.datacontract.org/2004/07/WCFServicio")]
    [System.SerializableAttribute()]
    public partial class Escuela : ClienteWFC3.ServiceConsumoDatos3.Respuesta2 {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AP_MaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AP_PaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EspecialidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PromedioField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AP_Materno {
            get {
                return this.AP_MaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.AP_MaternoField, value) != true)) {
                    this.AP_MaternoField = value;
                    this.RaisePropertyChanged("AP_Materno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AP_Paterno {
            get {
                return this.AP_PaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.AP_PaternoField, value) != true)) {
                    this.AP_PaternoField = value;
                    this.RaisePropertyChanged("AP_Paterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Curso {
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
        public string Especialidad {
            get {
                return this.EspecialidadField;
            }
            set {
                if ((object.ReferenceEquals(this.EspecialidadField, value) != true)) {
                    this.EspecialidadField = value;
                    this.RaisePropertyChanged("Especialidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Promedio {
            get {
                return this.PromedioField;
            }
            set {
                if ((object.ReferenceEquals(this.PromedioField, value) != true)) {
                    this.PromedioField = value;
                    this.RaisePropertyChanged("Promedio");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceConsumoDatos3.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetNumeroEmpleado", ReplyAction="http://tempuri.org/IService1/GetNumeroEmpleadoResponse")]
        ClienteWFC3.ServiceConsumoDatos3.Empleado GetNumeroEmpleado(string trabajador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/conversionDolares", ReplyAction="http://tempuri.org/IService1/conversionDolaresResponse")]
        double conversionDolares(double dolares);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSuma", ReplyAction="http://tempuri.org/IService1/GetSumaResponse")]
        int GetSuma(int a, int b, int c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetObtenerSuma", ReplyAction="http://tempuri.org/IService1/GetObtenerSumaResponse")]
        ClienteWFC3.ServiceConsumoDatos3.Numeros GetObtenerSuma(int Pelicula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetObtenerAlumno", ReplyAction="http://tempuri.org/IService1/GetObtenerAlumnoResponse")]
        ClienteWFC3.ServiceConsumoDatos3.Escuela GetObtenerAlumno(int Alumno);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClienteWFC3.ServiceConsumoDatos3.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClienteWFC3.ServiceConsumoDatos3.IService1>, ClienteWFC3.ServiceConsumoDatos3.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClienteWFC3.ServiceConsumoDatos3.Empleado GetNumeroEmpleado(string trabajador) {
            return base.Channel.GetNumeroEmpleado(trabajador);
        }
        
        public double conversionDolares(double dolares) {
            return base.Channel.conversionDolares(dolares);
        }
        
        public int GetSuma(int a, int b, int c) {
            return base.Channel.GetSuma(a, b, c);
        }
        
        public ClienteWFC3.ServiceConsumoDatos3.Numeros GetObtenerSuma(int Pelicula) {
            return base.Channel.GetObtenerSuma(Pelicula);
        }
        
        public ClienteWFC3.ServiceConsumoDatos3.Escuela GetObtenerAlumno(int Alumno) {
            return base.Channel.GetObtenerAlumno(Alumno);
        }
    }
}