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

namespace SMKRestaurant
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="smknus")]
	public partial class koneksikuDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertdetailorder(detailorder instance);
    partial void Updatedetailorder(detailorder instance);
    partial void Deletedetailorder(detailorder instance);
    partial void Insertheadorder(headorder instance);
    partial void Updateheadorder(headorder instance);
    partial void Deleteheadorder(headorder instance);
    partial void Insertmsemployee(msemployee instance);
    partial void Updatemsemployee(msemployee instance);
    partial void Deletemsemployee(msemployee instance);
    partial void Insertmsmember(msmember instance);
    partial void Updatemsmember(msmember instance);
    partial void Deletemsmember(msmember instance);
    partial void Insertmsmenu(msmenu instance);
    partial void Updatemsmenu(msmenu instance);
    partial void Deletemsmenu(msmenu instance);
    #endregion
		
		public koneksikuDataContext() : 
				base(global::SMKRestaurant.Properties.Settings.Default.smknusConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public koneksikuDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public koneksikuDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public koneksikuDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public koneksikuDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<detailorder> detailorders
		{
			get
			{
				return this.GetTable<detailorder>();
			}
		}
		
		public System.Data.Linq.Table<headorder> headorders
		{
			get
			{
				return this.GetTable<headorder>();
			}
		}
		
		public System.Data.Linq.Table<msemployee> msemployees
		{
			get
			{
				return this.GetTable<msemployee>();
			}
		}
		
		public System.Data.Linq.Table<msmember> msmembers
		{
			get
			{
				return this.GetTable<msmember>();
			}
		}
		
		public System.Data.Linq.Table<msmenu> msmenus
		{
			get
			{
				return this.GetTable<msmenu>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.detailorder")]
	public partial class detailorder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _detailid;
		
		private int _orderid;
		
		private int _menuid;
		
		private int _qty;
		
		private int _price;
		
		private string _status;
		
		private EntityRef<headorder> _headorder;
		
		private EntityRef<msmenu> _msmenu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OndetailidChanging(int value);
    partial void OndetailidChanged();
    partial void OnorderidChanging(int value);
    partial void OnorderidChanged();
    partial void OnmenuidChanging(int value);
    partial void OnmenuidChanged();
    partial void OnqtyChanging(int value);
    partial void OnqtyChanged();
    partial void OnpriceChanging(int value);
    partial void OnpriceChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    #endregion
		
		public detailorder()
		{
			this._headorder = default(EntityRef<headorder>);
			this._msmenu = default(EntityRef<msmenu>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_detailid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int detailid
		{
			get
			{
				return this._detailid;
			}
			set
			{
				if ((this._detailid != value))
				{
					this.OndetailidChanging(value);
					this.SendPropertyChanging();
					this._detailid = value;
					this.SendPropertyChanged("detailid");
					this.OndetailidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderid", DbType="Int NOT NULL")]
		public int orderid
		{
			get
			{
				return this._orderid;
			}
			set
			{
				if ((this._orderid != value))
				{
					if (this._headorder.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnorderidChanging(value);
					this.SendPropertyChanging();
					this._orderid = value;
					this.SendPropertyChanged("orderid");
					this.OnorderidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_menuid", DbType="Int NOT NULL")]
		public int menuid
		{
			get
			{
				return this._menuid;
			}
			set
			{
				if ((this._menuid != value))
				{
					if (this._msmenu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmenuidChanging(value);
					this.SendPropertyChanging();
					this._menuid = value;
					this.SendPropertyChanged("menuid");
					this.OnmenuidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qty", DbType="Int NOT NULL")]
		public int qty
		{
			get
			{
				return this._qty;
			}
			set
			{
				if ((this._qty != value))
				{
					this.OnqtyChanging(value);
					this.SendPropertyChanging();
					this._qty = value;
					this.SendPropertyChanged("qty");
					this.OnqtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Int NOT NULL")]
		public int price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="headorder_detailorder", Storage="_headorder", ThisKey="orderid", OtherKey="orderid", IsForeignKey=true)]
		public headorder headorder
		{
			get
			{
				return this._headorder.Entity;
			}
			set
			{
				headorder previousValue = this._headorder.Entity;
				if (((previousValue != value) 
							|| (this._headorder.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._headorder.Entity = null;
						previousValue.detailorders.Remove(this);
					}
					this._headorder.Entity = value;
					if ((value != null))
					{
						value.detailorders.Add(this);
						this._orderid = value.orderid;
					}
					else
					{
						this._orderid = default(int);
					}
					this.SendPropertyChanged("headorder");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="msmenu_detailorder", Storage="_msmenu", ThisKey="menuid", OtherKey="menuid", IsForeignKey=true)]
		public msmenu msmenu
		{
			get
			{
				return this._msmenu.Entity;
			}
			set
			{
				msmenu previousValue = this._msmenu.Entity;
				if (((previousValue != value) 
							|| (this._msmenu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._msmenu.Entity = null;
						previousValue.detailorders.Remove(this);
					}
					this._msmenu.Entity = value;
					if ((value != null))
					{
						value.detailorders.Add(this);
						this._menuid = value.menuid;
					}
					else
					{
						this._menuid = default(int);
					}
					this.SendPropertyChanged("msmenu");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.headorder")]
	public partial class headorder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _orderid;
		
		private string _employeeid;
		
		private int _memberid;
		
		private System.DateTime _date;
		
		private string _payment;
		
		private string _bank;
		
		private EntitySet<detailorder> _detailorders;
		
		private EntityRef<msemployee> _msemployee;
		
		private EntityRef<msmember> _msmember;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnorderidChanging(int value);
    partial void OnorderidChanged();
    partial void OnemployeeidChanging(string value);
    partial void OnemployeeidChanged();
    partial void OnmemberidChanging(int value);
    partial void OnmemberidChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    partial void OnpaymentChanging(string value);
    partial void OnpaymentChanged();
    partial void OnbankChanging(string value);
    partial void OnbankChanged();
    #endregion
		
		public headorder()
		{
			this._detailorders = new EntitySet<detailorder>(new Action<detailorder>(this.attach_detailorders), new Action<detailorder>(this.detach_detailorders));
			this._msemployee = default(EntityRef<msemployee>);
			this._msmember = default(EntityRef<msmember>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int orderid
		{
			get
			{
				return this._orderid;
			}
			set
			{
				if ((this._orderid != value))
				{
					this.OnorderidChanging(value);
					this.SendPropertyChanging();
					this._orderid = value;
					this.SendPropertyChanged("orderid");
					this.OnorderidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employeeid", DbType="NVarChar(6) NOT NULL", CanBeNull=false)]
		public string employeeid
		{
			get
			{
				return this._employeeid;
			}
			set
			{
				if ((this._employeeid != value))
				{
					if (this._msemployee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnemployeeidChanging(value);
					this.SendPropertyChanging();
					this._employeeid = value;
					this.SendPropertyChanged("employeeid");
					this.OnemployeeidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_memberid", DbType="Int NOT NULL")]
		public int memberid
		{
			get
			{
				return this._memberid;
			}
			set
			{
				if ((this._memberid != value))
				{
					if (this._msmember.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmemberidChanging(value);
					this.SendPropertyChanging();
					this._memberid = value;
					this.SendPropertyChanged("memberid");
					this.OnmemberidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="Date NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_payment", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string payment
		{
			get
			{
				return this._payment;
			}
			set
			{
				if ((this._payment != value))
				{
					this.OnpaymentChanging(value);
					this.SendPropertyChanging();
					this._payment = value;
					this.SendPropertyChanged("payment");
					this.OnpaymentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bank", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string bank
		{
			get
			{
				return this._bank;
			}
			set
			{
				if ((this._bank != value))
				{
					this.OnbankChanging(value);
					this.SendPropertyChanging();
					this._bank = value;
					this.SendPropertyChanged("bank");
					this.OnbankChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="headorder_detailorder", Storage="_detailorders", ThisKey="orderid", OtherKey="orderid")]
		public EntitySet<detailorder> detailorders
		{
			get
			{
				return this._detailorders;
			}
			set
			{
				this._detailorders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="msemployee_headorder", Storage="_msemployee", ThisKey="employeeid", OtherKey="employeeid", IsForeignKey=true)]
		public msemployee msemployee
		{
			get
			{
				return this._msemployee.Entity;
			}
			set
			{
				msemployee previousValue = this._msemployee.Entity;
				if (((previousValue != value) 
							|| (this._msemployee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._msemployee.Entity = null;
						previousValue.headorders.Remove(this);
					}
					this._msemployee.Entity = value;
					if ((value != null))
					{
						value.headorders.Add(this);
						this._employeeid = value.employeeid;
					}
					else
					{
						this._employeeid = default(string);
					}
					this.SendPropertyChanged("msemployee");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="msmember_headorder", Storage="_msmember", ThisKey="memberid", OtherKey="memberid", IsForeignKey=true)]
		public msmember msmember
		{
			get
			{
				return this._msmember.Entity;
			}
			set
			{
				msmember previousValue = this._msmember.Entity;
				if (((previousValue != value) 
							|| (this._msmember.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._msmember.Entity = null;
						previousValue.headorders.Remove(this);
					}
					this._msmember.Entity = value;
					if ((value != null))
					{
						value.headorders.Add(this);
						this._memberid = value.memberid;
					}
					else
					{
						this._memberid = default(int);
					}
					this.SendPropertyChanged("msmember");
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
		
		private void attach_detailorders(detailorder entity)
		{
			this.SendPropertyChanging();
			entity.headorder = this;
		}
		
		private void detach_detailorders(detailorder entity)
		{
			this.SendPropertyChanging();
			entity.headorder = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.msemployee")]
	public partial class msemployee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _employeeid;
		
		private string _name;
		
		private string _email;
		
		private string _password;
		
		private string _handphone;
		
		private string _position;
		
		private EntitySet<headorder> _headorders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnemployeeidChanging(string value);
    partial void OnemployeeidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnhandphoneChanging(string value);
    partial void OnhandphoneChanged();
    partial void OnpositionChanging(string value);
    partial void OnpositionChanged();
    #endregion
		
		public msemployee()
		{
			this._headorders = new EntitySet<headorder>(new Action<headorder>(this.attach_headorders), new Action<headorder>(this.detach_headorders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employeeid", DbType="NVarChar(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string employeeid
		{
			get
			{
				return this._employeeid;
			}
			set
			{
				if ((this._employeeid != value))
				{
					this.OnemployeeidChanging(value);
					this.SendPropertyChanging();
					this._employeeid = value;
					this.SendPropertyChanged("employeeid");
					this.OnemployeeidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_handphone", DbType="NVarChar(13) NOT NULL", CanBeNull=false)]
		public string handphone
		{
			get
			{
				return this._handphone;
			}
			set
			{
				if ((this._handphone != value))
				{
					this.OnhandphoneChanging(value);
					this.SendPropertyChanging();
					this._handphone = value;
					this.SendPropertyChanged("handphone");
					this.OnhandphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_position", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string position
		{
			get
			{
				return this._position;
			}
			set
			{
				if ((this._position != value))
				{
					this.OnpositionChanging(value);
					this.SendPropertyChanging();
					this._position = value;
					this.SendPropertyChanged("position");
					this.OnpositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="msemployee_headorder", Storage="_headorders", ThisKey="employeeid", OtherKey="employeeid")]
		public EntitySet<headorder> headorders
		{
			get
			{
				return this._headorders;
			}
			set
			{
				this._headorders.Assign(value);
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
		
		private void attach_headorders(headorder entity)
		{
			this.SendPropertyChanging();
			entity.msemployee = this;
		}
		
		private void detach_headorders(headorder entity)
		{
			this.SendPropertyChanging();
			entity.msemployee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.msmember")]
	public partial class msmember : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _memberid;
		
		private string _name;
		
		private string _email;
		
		private string _handphone;
		
		private System.DateTime _joindate;
		
		private string _password;
		
		private EntitySet<headorder> _headorders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmemberidChanging(int value);
    partial void OnmemberidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnhandphoneChanging(string value);
    partial void OnhandphoneChanged();
    partial void OnjoindateChanging(System.DateTime value);
    partial void OnjoindateChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public msmember()
		{
			this._headorders = new EntitySet<headorder>(new Action<headorder>(this.attach_headorders), new Action<headorder>(this.detach_headorders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_memberid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int memberid
		{
			get
			{
				return this._memberid;
			}
			set
			{
				if ((this._memberid != value))
				{
					this.OnmemberidChanging(value);
					this.SendPropertyChanging();
					this._memberid = value;
					this.SendPropertyChanged("memberid");
					this.OnmemberidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_handphone", DbType="NVarChar(13) NOT NULL", CanBeNull=false)]
		public string handphone
		{
			get
			{
				return this._handphone;
			}
			set
			{
				if ((this._handphone != value))
				{
					this.OnhandphoneChanging(value);
					this.SendPropertyChanging();
					this._handphone = value;
					this.SendPropertyChanged("handphone");
					this.OnhandphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_joindate", DbType="Date NOT NULL")]
		public System.DateTime joindate
		{
			get
			{
				return this._joindate;
			}
			set
			{
				if ((this._joindate != value))
				{
					this.OnjoindateChanging(value);
					this.SendPropertyChanging();
					this._joindate = value;
					this.SendPropertyChanged("joindate");
					this.OnjoindateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="msmember_headorder", Storage="_headorders", ThisKey="memberid", OtherKey="memberid")]
		public EntitySet<headorder> headorders
		{
			get
			{
				return this._headorders;
			}
			set
			{
				this._headorders.Assign(value);
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
		
		private void attach_headorders(headorder entity)
		{
			this.SendPropertyChanging();
			entity.msmember = this;
		}
		
		private void detach_headorders(headorder entity)
		{
			this.SendPropertyChanging();
			entity.msmember = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.msmenu")]
	public partial class msmenu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _menuid;
		
		private string _name;
		
		private int _price;
		
		private System.Data.Linq.Binary _photo;
		
		private string _path;
		
		private EntitySet<detailorder> _detailorders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmenuidChanging(int value);
    partial void OnmenuidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnpriceChanging(int value);
    partial void OnpriceChanged();
    partial void OnphotoChanging(System.Data.Linq.Binary value);
    partial void OnphotoChanged();
    partial void OnpathChanging(string value);
    partial void OnpathChanged();
    #endregion
		
		public msmenu()
		{
			this._detailorders = new EntitySet<detailorder>(new Action<detailorder>(this.attach_detailorders), new Action<detailorder>(this.detach_detailorders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_menuid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int menuid
		{
			get
			{
				return this._menuid;
			}
			set
			{
				if ((this._menuid != value))
				{
					this.OnmenuidChanging(value);
					this.SendPropertyChanging();
					this._menuid = value;
					this.SendPropertyChanged("menuid");
					this.OnmenuidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Int NOT NULL")]
		public int price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photo", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary photo
		{
			get
			{
				return this._photo;
			}
			set
			{
				if ((this._photo != value))
				{
					this.OnphotoChanging(value);
					this.SendPropertyChanging();
					this._photo = value;
					this.SendPropertyChanged("photo");
					this.OnphotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_path", DbType="VarChar(150)", CanBeNull=false)]
		public string path
		{
			get
			{
				return this._path;
			}
			set
			{
				if ((this._path != value))
				{
					this.OnpathChanging(value);
					this.SendPropertyChanging();
					this._path = value;
					this.SendPropertyChanged("path");
					this.OnpathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="msmenu_detailorder", Storage="_detailorders", ThisKey="menuid", OtherKey="menuid")]
		public EntitySet<detailorder> detailorders
		{
			get
			{
				return this._detailorders;
			}
			set
			{
				this._detailorders.Assign(value);
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
		
		private void attach_detailorders(detailorder entity)
		{
			this.SendPropertyChanging();
			entity.msmenu = this;
		}
		
		private void detach_detailorders(detailorder entity)
		{
			this.SendPropertyChanging();
			entity.msmenu = null;
		}
	}
}
#pragma warning restore 1591