﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResponsiveMeetingSearch.Data
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SQL2008R2_932096_meetings")]
	public partial class meetingDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMeeting(Meeting instance);
    partial void UpdateMeeting(Meeting instance);
    partial void DeleteMeeting(Meeting instance);
    #endregion
		
		public meetingDBDataContext() : 
				base(global::ResponsiveMeetingSearch.Data.Properties.Settings.Default.SQL2008R2_932096_meetingsConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public meetingDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public meetingDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public meetingDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public meetingDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Meeting> Meetings
		{
			get
			{
				return this.GetTable<Meeting>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RadiusSearch")]
		public ISingleResult<RadiusSearchResult> RadiusSearch([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,0)")] System.Nullable<decimal> longitude, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,0)")] System.Nullable<decimal> latitude, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,0)")] System.Nullable<decimal> radius, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DayOfWeek", DbType="Int")] System.Nullable<int> dayOfWeek)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), longitude, latitude, radius, dayOfWeek);
			return ((ISingleResult<RadiusSearchResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Meeting")]
	public partial class Meeting : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _Name;
		
		private string _LocationName;
		
		private string _Address;
		
		private decimal _Latitude;
		
		private decimal _Longitude;
		
		private int _DayOfWeek;
		
		private int _TypeOfMeeting;
		
		private System.Nullable<System.DateTime> _Time;
		
		private string _Options;
		
		private System.Nullable<System.DateTime> _DateCreated;
		
		private System.Nullable<System.DateTime> _DateModified;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLocationNameChanging(string value);
    partial void OnLocationNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnLatitudeChanging(decimal value);
    partial void OnLatitudeChanged();
    partial void OnLongitudeChanging(decimal value);
    partial void OnLongitudeChanged();
    partial void OnDayOfWeekChanging(int value);
    partial void OnDayOfWeekChanged();
    partial void OnTypeOfMeetingChanging(int value);
    partial void OnTypeOfMeetingChanged();
    partial void OnTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeChanged();
    partial void OnOptionsChanging(string value);
    partial void OnOptionsChanged();
    partial void OnDateCreatedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateCreatedChanged();
    partial void OnDateModifiedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateModifiedChanged();
    #endregion
		
		public Meeting()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NVarChar(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationName", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string LocationName
		{
			get
			{
				return this._LocationName;
			}
			set
			{
				if ((this._LocationName != value))
				{
					this.OnLocationNameChanging(value);
					this.SendPropertyChanging();
					this._LocationName = value;
					this.SendPropertyChanged("LocationName");
					this.OnLocationNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="Decimal(15,12) NOT NULL")]
		public decimal Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="Decimal(15,12) NOT NULL")]
		public decimal Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this.OnLongitudeChanging(value);
					this.SendPropertyChanging();
					this._Longitude = value;
					this.SendPropertyChanged("Longitude");
					this.OnLongitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DayOfWeek", DbType="Int NOT NULL")]
		public int DayOfWeek
		{
			get
			{
				return this._DayOfWeek;
			}
			set
			{
				if ((this._DayOfWeek != value))
				{
					this.OnDayOfWeekChanging(value);
					this.SendPropertyChanging();
					this._DayOfWeek = value;
					this.SendPropertyChanged("DayOfWeek");
					this.OnDayOfWeekChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeOfMeeting", DbType="Int NOT NULL")]
		public int TypeOfMeeting
		{
			get
			{
				return this._TypeOfMeeting;
			}
			set
			{
				if ((this._TypeOfMeeting != value))
				{
					this.OnTypeOfMeetingChanging(value);
					this.SendPropertyChanging();
					this._TypeOfMeeting = value;
					this.SendPropertyChanged("TypeOfMeeting");
					this.OnTypeOfMeetingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="DateTime")]
		public System.Nullable<System.DateTime> Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._Time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Options", DbType="NVarChar(50)")]
		public string Options
		{
			get
			{
				return this._Options;
			}
			set
			{
				if ((this._Options != value))
				{
					this.OnOptionsChanging(value);
					this.SendPropertyChanging();
					this._Options = value;
					this.SendPropertyChanged("Options");
					this.OnOptionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._DateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateModified", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateModified
		{
			get
			{
				return this._DateModified;
			}
			set
			{
				if ((this._DateModified != value))
				{
					this.OnDateModifiedChanging(value);
					this.SendPropertyChanging();
					this._DateModified = value;
					this.SendPropertyChanged("DateModified");
					this.OnDateModifiedChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class RadiusSearchResult
	{
		
		private string _ID;
		
		private string _Name;
		
		private string _LocationName;
		
		private string _Address;
		
		private decimal _Latitude;
		
		private decimal _Longitude;
		
		private int _DayOfWeek;
		
		private int _TypeOfMeeting;
		
		private System.Nullable<System.DateTime> _Time;
		
		private string _Options;
		
		private System.Nullable<System.DateTime> _DateCreated;
		
		private System.Nullable<System.DateTime> _DateModified;
		
		public RadiusSearchResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NVarChar(8) NOT NULL", CanBeNull=false)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationName", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string LocationName
		{
			get
			{
				return this._LocationName;
			}
			set
			{
				if ((this._LocationName != value))
				{
					this._LocationName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="Decimal(15,12) NOT NULL")]
		public decimal Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this._Latitude = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="Decimal(15,12) NOT NULL")]
		public decimal Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this._Longitude = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DayOfWeek", DbType="Int NOT NULL")]
		public int DayOfWeek
		{
			get
			{
				return this._DayOfWeek;
			}
			set
			{
				if ((this._DayOfWeek != value))
				{
					this._DayOfWeek = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeOfMeeting", DbType="Int NOT NULL")]
		public int TypeOfMeeting
		{
			get
			{
				return this._TypeOfMeeting;
			}
			set
			{
				if ((this._TypeOfMeeting != value))
				{
					this._TypeOfMeeting = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="DateTime")]
		public System.Nullable<System.DateTime> Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this._Time = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Options", DbType="NVarChar(50)")]
		public string Options
		{
			get
			{
				return this._Options;
			}
			set
			{
				if ((this._Options != value))
				{
					this._Options = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this._DateCreated = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateModified", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateModified
		{
			get
			{
				return this._DateModified;
			}
			set
			{
				if ((this._DateModified != value))
				{
					this._DateModified = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
