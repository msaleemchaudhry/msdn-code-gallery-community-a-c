﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_app
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="kaafi")]
	public partial class employeeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertemployeetab(employeetab instance);
    partial void Updateemployeetab(employeetab instance);
    partial void Deleteemployeetab(employeetab instance);
    #endregion
		
		public employeeDataContext() : 
				base(global::CRUD_app.Properties.Settings.Default.kaafiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public employeeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public employeeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public employeeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public employeeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<employeetab> employeetabs
		{
			get
			{
				return this.GetTable<employeetab>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.employeetab")]
	public partial class employeetab : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _empid;
		
		private string _empname;
		
		private string _empdep;
		
		private System.Data.Linq.Binary _empimage;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnempidChanging(string value);
    partial void OnempidChanged();
    partial void OnempnameChanging(string value);
    partial void OnempnameChanged();
    partial void OnempdepChanging(string value);
    partial void OnempdepChanged();
    partial void OnempimageChanging(System.Data.Linq.Binary value);
    partial void OnempimageChanged();
    #endregion
		
		public employeetab()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empid", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string empid
		{
			get
			{
				return this._empid;
			}
			set
			{
				if ((this._empid != value))
				{
					this.OnempidChanging(value);
					this.SendPropertyChanging();
					this._empid = value;
					this.SendPropertyChanged("empid");
					this.OnempidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string empname
		{
			get
			{
				return this._empname;
			}
			set
			{
				if ((this._empname != value))
				{
					this.OnempnameChanging(value);
					this.SendPropertyChanging();
					this._empname = value;
					this.SendPropertyChanged("empname");
					this.OnempnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empdep", DbType="NVarChar(50)")]
		public string empdep
		{
			get
			{
				return this._empdep;
			}
			set
			{
				if ((this._empdep != value))
				{
					this.OnempdepChanging(value);
					this.SendPropertyChanging();
					this._empdep = value;
					this.SendPropertyChanged("empdep");
					this.OnempdepChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empimage", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary empimage
		{
			get
			{
				return this._empimage;
			}
			set
			{
				if ((this._empimage != value))
				{
					this.OnempimageChanging(value);
					this.SendPropertyChanging();
					this._empimage = value;
					this.SendPropertyChanged("empimage");
					this.OnempimageChanged();
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
}
#pragma warning restore 1591
