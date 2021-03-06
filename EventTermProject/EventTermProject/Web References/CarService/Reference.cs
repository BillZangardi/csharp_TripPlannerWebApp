﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34014.
// 
#pragma warning disable 1591

namespace EventTermProject.CarService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CarServiceSoap", Namespace="http://tempuri.org/")]
    public partial class CarService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetCarsOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindCarsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetRentalCarAgenciesOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReserveOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CarService() {
            this.Url = global::EventTermProject.Properties.Settings.Default.EventTermProject_CarService_CarService;
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
        public event GetCarsCompletedEventHandler GetCarsCompleted;
        
        /// <remarks/>
        public event FindCarsCompletedEventHandler FindCarsCompleted;
        
        /// <remarks/>
        public event GetRentalCarAgenciesCompletedEventHandler GetRentalCarAgenciesCompleted;
        
        /// <remarks/>
        public event ReserveCompletedEventHandler ReserveCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCars", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetCars(Agency agency, string city, string state) {
            object[] results = this.Invoke("GetCars", new object[] {
                        agency,
                        city,
                        state});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetCarsAsync(Agency agency, string city, string state) {
            this.GetCarsAsync(agency, city, state, null);
        }
        
        /// <remarks/>
        public void GetCarsAsync(Agency agency, string city, string state, object userState) {
            if ((this.GetCarsOperationCompleted == null)) {
                this.GetCarsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCarsOperationCompleted);
            }
            this.InvokeAsync("GetCars", new object[] {
                        agency,
                        city,
                        state}, this.GetCarsOperationCompleted, userState);
        }
        
        private void OnGetCarsOperationCompleted(object arg) {
            if ((this.GetCarsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCarsCompleted(this, new GetCarsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindCars", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet FindCars(Requirements requirements, string city, string state) {
            object[] results = this.Invoke("FindCars", new object[] {
                        requirements,
                        city,
                        state});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void FindCarsAsync(Requirements requirements, string city, string state) {
            this.FindCarsAsync(requirements, city, state, null);
        }
        
        /// <remarks/>
        public void FindCarsAsync(Requirements requirements, string city, string state, object userState) {
            if ((this.FindCarsOperationCompleted == null)) {
                this.FindCarsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindCarsOperationCompleted);
            }
            this.InvokeAsync("FindCars", new object[] {
                        requirements,
                        city,
                        state}, this.FindCarsOperationCompleted, userState);
        }
        
        private void OnFindCarsOperationCompleted(object arg) {
            if ((this.FindCarsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindCarsCompleted(this, new FindCarsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetRentalCarAgencies", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetRentalCarAgencies(string city, string state) {
            object[] results = this.Invoke("GetRentalCarAgencies", new object[] {
                        city,
                        state});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetRentalCarAgenciesAsync(string city, string state) {
            this.GetRentalCarAgenciesAsync(city, state, null);
        }
        
        /// <remarks/>
        public void GetRentalCarAgenciesAsync(string city, string state, object userState) {
            if ((this.GetRentalCarAgenciesOperationCompleted == null)) {
                this.GetRentalCarAgenciesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRentalCarAgenciesOperationCompleted);
            }
            this.InvokeAsync("GetRentalCarAgencies", new object[] {
                        city,
                        state}, this.GetRentalCarAgenciesOperationCompleted, userState);
        }
        
        private void OnGetRentalCarAgenciesOperationCompleted(object arg) {
            if ((this.GetRentalCarAgenciesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRentalCarAgenciesCompleted(this, new GetRentalCarAgenciesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Reserve", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Reserve(Customer customer, Car car) {
            object[] results = this.Invoke("Reserve", new object[] {
                        customer,
                        car});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ReserveAsync(Customer customer, Car car) {
            this.ReserveAsync(customer, car, null);
        }
        
        /// <remarks/>
        public void ReserveAsync(Customer customer, Car car, object userState) {
            if ((this.ReserveOperationCompleted == null)) {
                this.ReserveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReserveOperationCompleted);
            }
            this.InvokeAsync("Reserve", new object[] {
                        customer,
                        car}, this.ReserveOperationCompleted, userState);
        }
        
        private void OnReserveOperationCompleted(object arg) {
            if ((this.ReserveCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReserveCompleted(this, new ReserveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Agency {
        
        private int agencyIDField;
        
        private string nameField;
        
        private string phoneField;
        
        private string emailField;
        
        private string cityField;
        
        private string stateField;
        
        /// <remarks/>
        public int agencyID {
            get {
                return this.agencyIDField;
            }
            set {
                this.agencyIDField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Car {
        
        private int carIDField;
        
        private string yearField;
        
        private string makeField;
        
        private string modelField;
        
        private float priceField;
        
        private string gpsField;
        
        private string carClassField;
        
        private string typeField;
        
        private string electricField;
        
        private int passengersField;
        
        private int luggageField;
        
        private int doorsField;
        
        private int mileageField;
        
        /// <remarks/>
        public int carID {
            get {
                return this.carIDField;
            }
            set {
                this.carIDField = value;
            }
        }
        
        /// <remarks/>
        public string year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
            }
        }
        
        /// <remarks/>
        public string make {
            get {
                return this.makeField;
            }
            set {
                this.makeField = value;
            }
        }
        
        /// <remarks/>
        public string model {
            get {
                return this.modelField;
            }
            set {
                this.modelField = value;
            }
        }
        
        /// <remarks/>
        public float price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        public string gps {
            get {
                return this.gpsField;
            }
            set {
                this.gpsField = value;
            }
        }
        
        /// <remarks/>
        public string carClass {
            get {
                return this.carClassField;
            }
            set {
                this.carClassField = value;
            }
        }
        
        /// <remarks/>
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string electric {
            get {
                return this.electricField;
            }
            set {
                this.electricField = value;
            }
        }
        
        /// <remarks/>
        public int passengers {
            get {
                return this.passengersField;
            }
            set {
                this.passengersField = value;
            }
        }
        
        /// <remarks/>
        public int luggage {
            get {
                return this.luggageField;
            }
            set {
                this.luggageField = value;
            }
        }
        
        /// <remarks/>
        public int doors {
            get {
                return this.doorsField;
            }
            set {
                this.doorsField = value;
            }
        }
        
        /// <remarks/>
        public int mileage {
            get {
                return this.mileageField;
            }
            set {
                this.mileageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Customer {
        
        private int customerIDField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private int ageField;
        
        private string emailField;
        
        private string addressField;
        
        private string phoneNumberField;
        
        /// <remarks/>
        public int customerID {
            get {
                return this.customerIDField;
            }
            set {
                this.customerIDField = value;
            }
        }
        
        /// <remarks/>
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        public int age {
            get {
                return this.ageField;
            }
            set {
                this.ageField = value;
            }
        }
        
        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        public string phoneNumber {
            get {
                return this.phoneNumberField;
            }
            set {
                this.phoneNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Requirements {
        
        private float priceField;
        
        private string gpsField;
        
        private string typeField;
        
        private string carClassField;
        
        private string electricField;
        
        private int passengersField;
        
        private int luggageField;
        
        private int doorsField;
        
        private int mileageField;
        
        /// <remarks/>
        public float price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        public string gps {
            get {
                return this.gpsField;
            }
            set {
                this.gpsField = value;
            }
        }
        
        /// <remarks/>
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string carClass {
            get {
                return this.carClassField;
            }
            set {
                this.carClassField = value;
            }
        }
        
        /// <remarks/>
        public string electric {
            get {
                return this.electricField;
            }
            set {
                this.electricField = value;
            }
        }
        
        /// <remarks/>
        public int passengers {
            get {
                return this.passengersField;
            }
            set {
                this.passengersField = value;
            }
        }
        
        /// <remarks/>
        public int luggage {
            get {
                return this.luggageField;
            }
            set {
                this.luggageField = value;
            }
        }
        
        /// <remarks/>
        public int doors {
            get {
                return this.doorsField;
            }
            set {
                this.doorsField = value;
            }
        }
        
        /// <remarks/>
        public int mileage {
            get {
                return this.mileageField;
            }
            set {
                this.mileageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetCarsCompletedEventHandler(object sender, GetCarsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCarsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCarsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void FindCarsCompletedEventHandler(object sender, FindCarsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindCarsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindCarsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetRentalCarAgenciesCompletedEventHandler(object sender, GetRentalCarAgenciesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRentalCarAgenciesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetRentalCarAgenciesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void ReserveCompletedEventHandler(object sender, ReserveCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReserveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReserveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591