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

namespace LoginGG.DataAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name= "SiteSqlServer")]
	public partial class HnueEmailDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHnueEmail(HnueEmail instance);
    partial void UpdateHnueEmail(HnueEmail instance);
    partial void DeleteHnueEmail(HnueEmail instance);
        #endregion

        
		public HnueEmailDataContext() :
                base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SiteSqlServer"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
        public HnueEmailDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HnueEmailDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HnueEmailDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HnueEmailDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<HnueEmail> HnueEmails
		{
			get
			{
				return this.GetTable<HnueEmail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HnueEmail")]
	public partial class HnueEmail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Email;
		
		private string _Fullname;
		
		private string _PictureUrl;
		
		private string _Accesstoken;
		
		private System.Nullable<System.DateTime> _CreateAt;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnFullnameChanging(string value);
    partial void OnFullnameChanged();
    partial void OnPictureUrlChanging(string value);
    partial void OnPictureUrlChanged();
    partial void OnAccesstokenChanging(string value);
    partial void OnAccesstokenChanged();
    partial void OnCreateAtChanging(System.Nullable<System.DateTime> value);
    partial void OnCreateAtChanged();
    #endregion
		
		public HnueEmail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fullname", DbType="NVarChar(255)")]
		public string Fullname
		{
			get
			{
				return this._Fullname;
			}
			set
			{
				if ((this._Fullname != value))
				{
					this.OnFullnameChanging(value);
					this.SendPropertyChanging();
					this._Fullname = value;
					this.SendPropertyChanged("Fullname");
					this.OnFullnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PictureUrl", DbType="NVarChar(255)")]
		public string PictureUrl
		{
			get
			{
				return this._PictureUrl;
			}
			set
			{
				if ((this._PictureUrl != value))
				{
					this.OnPictureUrlChanging(value);
					this.SendPropertyChanging();
					this._PictureUrl = value;
					this.SendPropertyChanged("PictureUrl");
					this.OnPictureUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Accesstoken", DbType="NVarChar(255)")]
		public string Accesstoken
		{
			get
			{
				return this._Accesstoken;
			}
			set
			{
				if ((this._Accesstoken != value))
				{
					this.OnAccesstokenChanging(value);
					this.SendPropertyChanging();
					this._Accesstoken = value;
					this.SendPropertyChanged("Accesstoken");
					this.OnAccesstokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateAt", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreateAt
		{
			get
			{
				return this._CreateAt;
			}
			set
			{
				if ((this._CreateAt != value))
				{
					this.OnCreateAtChanging(value);
					this.SendPropertyChanging();
					this._CreateAt = value;
					this.SendPropertyChanged("CreateAt");
					this.OnCreateAtChanged();
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
