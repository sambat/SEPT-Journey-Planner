﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("TimeTableModel", "FK_addresses_stations", "stations", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(JourneyPlanner.Data.station), "addresses", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(JourneyPlanner.Data.address), true)]
[assembly: EdmRelationshipAttribute("TimeTableModel", "FK_stations_lines", "lines", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(JourneyPlanner.Data.line), "stations", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(JourneyPlanner.Data.station), true)]
[assembly: EdmRelationshipAttribute("TimeTableModel", "FK_times_stations", "stations", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(JourneyPlanner.Data.station), "times", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(JourneyPlanner.Data.time), true)]

#endregion

namespace JourneyPlanner.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class TimeTableEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new TimeTableEntities object using the connection string found in the 'TimeTableEntities' section of the application configuration file.
        /// </summary>
        public TimeTableEntities() : base("name=TimeTableEntities", "TimeTableEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TimeTableEntities object.
        /// </summary>
        public TimeTableEntities(string connectionString) : base(connectionString, "TimeTableEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TimeTableEntities object.
        /// </summary>
        public TimeTableEntities(EntityConnection connection) : base(connection, "TimeTableEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<address> addresses
        {
            get
            {
                if ((_addresses == null))
                {
                    _addresses = base.CreateObjectSet<address>("addresses");
                }
                return _addresses;
            }
        }
        private ObjectSet<address> _addresses;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<line> lines
        {
            get
            {
                if ((_lines == null))
                {
                    _lines = base.CreateObjectSet<line>("lines");
                }
                return _lines;
            }
        }
        private ObjectSet<line> _lines;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<station> stations
        {
            get
            {
                if ((_stations == null))
                {
                    _stations = base.CreateObjectSet<station>("stations");
                }
                return _stations;
            }
        }
        private ObjectSet<station> _stations;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<time> times
        {
            get
            {
                if ((_times == null))
                {
                    _times = base.CreateObjectSet<time>("times");
                }
                return _times;
            }
        }
        private ObjectSet<time> _times;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the addresses EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToaddresses(address address)
        {
            base.AddObject("addresses", address);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the lines EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTolines(line line)
        {
            base.AddObject("lines", line);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the stations EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTostations(station station)
        {
            base.AddObject("stations", station);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the times EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotimes(time time)
        {
            base.AddObject("times", time);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TimeTableModel", Name="address")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class address : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new address object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="station_id">Initial value of the station_id property.</param>
        /// <param name="address1">Initial value of the address1 property.</param>
        /// <param name="longitude">Initial value of the longitude property.</param>
        /// <param name="latitude">Initial value of the latitude property.</param>
        public static address Createaddress(global::System.Int32 id, global::System.Int32 station_id, global::System.String address1, global::System.String longitude, global::System.String latitude)
        {
            address address = new address();
            address.id = id;
            address.station_id = station_id;
            address.address1 = address1;
            address.longitude = longitude;
            address.latitude = latitude;
            return address;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 station_id
        {
            get
            {
                return _station_id;
            }
            set
            {
                Onstation_idChanging(value);
                ReportPropertyChanging("station_id");
                _station_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("station_id");
                Onstation_idChanged();
            }
        }
        private global::System.Int32 _station_id;
        partial void Onstation_idChanging(global::System.Int32 value);
        partial void Onstation_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String address1
        {
            get
            {
                return _address1;
            }
            set
            {
                Onaddress1Changing(value);
                ReportPropertyChanging("address1");
                _address1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("address1");
                Onaddress1Changed();
            }
        }
        private global::System.String _address1;
        partial void Onaddress1Changing(global::System.String value);
        partial void Onaddress1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String longitude
        {
            get
            {
                return _longitude;
            }
            set
            {
                OnlongitudeChanging(value);
                ReportPropertyChanging("longitude");
                _longitude = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("longitude");
                OnlongitudeChanged();
            }
        }
        private global::System.String _longitude;
        partial void OnlongitudeChanging(global::System.String value);
        partial void OnlongitudeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String latitude
        {
            get
            {
                return _latitude;
            }
            set
            {
                OnlatitudeChanging(value);
                ReportPropertyChanging("latitude");
                _latitude = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("latitude");
                OnlatitudeChanged();
            }
        }
        private global::System.String _latitude;
        partial void OnlatitudeChanging(global::System.String value);
        partial void OnlatitudeChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TimeTableModel", "FK_addresses_stations", "stations")]
        public station station
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<station>("TimeTableModel.FK_addresses_stations", "stations").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<station>("TimeTableModel.FK_addresses_stations", "stations").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<station> stationReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<station>("TimeTableModel.FK_addresses_stations", "stations");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<station>("TimeTableModel.FK_addresses_stations", "stations", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TimeTableModel", Name="line")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class line : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new line object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        public static line Createline(global::System.Int32 id, global::System.String name)
        {
            line line = new line();
            line.id = id;
            line.name = name;
            return line;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TimeTableModel", "FK_stations_lines", "stations")]
        public EntityCollection<station> stations
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<station>("TimeTableModel.FK_stations_lines", "stations");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<station>("TimeTableModel.FK_stations_lines", "stations", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TimeTableModel", Name="station")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class station : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new station object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="line_id">Initial value of the line_id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        public static station Createstation(global::System.Int32 id, global::System.Int32 line_id, global::System.String name)
        {
            station station = new station();
            station.id = id;
            station.line_id = line_id;
            station.name = name;
            return station;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 line_id
        {
            get
            {
                return _line_id;
            }
            set
            {
                Online_idChanging(value);
                ReportPropertyChanging("line_id");
                _line_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("line_id");
                Online_idChanged();
            }
        }
        private global::System.Int32 _line_id;
        partial void Online_idChanging(global::System.Int32 value);
        partial void Online_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TimeTableModel", "FK_addresses_stations", "addresses")]
        public EntityCollection<address> addresses
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<address>("TimeTableModel.FK_addresses_stations", "addresses");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<address>("TimeTableModel.FK_addresses_stations", "addresses", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TimeTableModel", "FK_stations_lines", "lines")]
        public line line
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<line>("TimeTableModel.FK_stations_lines", "lines").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<line>("TimeTableModel.FK_stations_lines", "lines").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<line> lineReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<line>("TimeTableModel.FK_stations_lines", "lines");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<line>("TimeTableModel.FK_stations_lines", "lines", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TimeTableModel", "FK_times_stations", "times")]
        public EntityCollection<time> times
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<time>("TimeTableModel.FK_times_stations", "times");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<time>("TimeTableModel.FK_times_stations", "times", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TimeTableModel", Name="time")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class time : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new time object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="station_id">Initial value of the station_id property.</param>
        /// <param name="time1">Initial value of the time1 property.</param>
        /// <param name="number">Initial value of the number property.</param>
        public static time Createtime(global::System.Int32 id, global::System.Int32 station_id, global::System.String time1, global::System.Int32 number)
        {
            time time = new time();
            time.id = id;
            time.station_id = station_id;
            time.time1 = time1;
            time.number = number;
            return time;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 station_id
        {
            get
            {
                return _station_id;
            }
            set
            {
                Onstation_idChanging(value);
                ReportPropertyChanging("station_id");
                _station_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("station_id");
                Onstation_idChanged();
            }
        }
        private global::System.Int32 _station_id;
        partial void Onstation_idChanging(global::System.Int32 value);
        partial void Onstation_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String time1
        {
            get
            {
                return _time1;
            }
            set
            {
                Ontime1Changing(value);
                ReportPropertyChanging("time1");
                _time1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("time1");
                Ontime1Changed();
            }
        }
        private global::System.String _time1;
        partial void Ontime1Changing(global::System.String value);
        partial void Ontime1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 number
        {
            get
            {
                return _number;
            }
            set
            {
                OnnumberChanging(value);
                ReportPropertyChanging("number");
                _number = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("number");
                OnnumberChanged();
            }
        }
        private global::System.Int32 _number;
        partial void OnnumberChanging(global::System.Int32 value);
        partial void OnnumberChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TimeTableModel", "FK_times_stations", "stations")]
        public station station
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<station>("TimeTableModel.FK_times_stations", "stations").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<station>("TimeTableModel.FK_times_stations", "stations").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<station> stationReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<station>("TimeTableModel.FK_times_stations", "stations");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<station>("TimeTableModel.FK_times_stations", "stations", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}