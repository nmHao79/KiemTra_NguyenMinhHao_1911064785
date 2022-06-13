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

namespace KiemTra_NguyenMinhHao.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Test01")]
	public partial class MyDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChiTietDangKy(ChiTietDangKy instance);
    partial void UpdateChiTietDangKy(ChiTietDangKy instance);
    partial void DeleteChiTietDangKy(ChiTietDangKy instance);
    partial void InsertDangKy(DangKy instance);
    partial void UpdateDangKy(DangKy instance);
    partial void DeleteDangKy(DangKy instance);
    partial void InsertHocPhan(HocPhan instance);
    partial void UpdateHocPhan(HocPhan instance);
    partial void DeleteHocPhan(HocPhan instance);
    partial void InsertNganhHoc(NganhHoc instance);
    partial void UpdateNganhHoc(NganhHoc instance);
    partial void DeleteNganhHoc(NganhHoc instance);
    partial void InsertSinhVien(SinhVien instance);
    partial void UpdateSinhVien(SinhVien instance);
    partial void DeleteSinhVien(SinhVien instance);
    #endregion
		
		public MyDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Test01ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ChiTietDangKy> ChiTietDangKies
		{
			get
			{
				return this.GetTable<ChiTietDangKy>();
			}
		}
		
		public System.Data.Linq.Table<DangKy> DangKies
		{
			get
			{
				return this.GetTable<DangKy>();
			}
		}
		
		public System.Data.Linq.Table<HocPhan> HocPhans
		{
			get
			{
				return this.GetTable<HocPhan>();
			}
		}
		
		public System.Data.Linq.Table<NganhHoc> NganhHocs
		{
			get
			{
				return this.GetTable<NganhHoc>();
			}
		}
		
		public System.Data.Linq.Table<SinhVien> SinhViens
		{
			get
			{
				return this.GetTable<SinhVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietDangKy")]
	public partial class ChiTietDangKy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDK;
		
		private string _MaHP;
		
		private EntityRef<DangKy> _DangKy;
		
		private EntityRef<HocPhan> _HocPhan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDKChanging(int value);
    partial void OnMaDKChanged();
    partial void OnMaHPChanging(string value);
    partial void OnMaHPChanged();
    #endregion
		
		public ChiTietDangKy()
		{
			this._DangKy = default(EntityRef<DangKy>);
			this._HocPhan = default(EntityRef<HocPhan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDK", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDK
		{
			get
			{
				return this._MaDK;
			}
			set
			{
				if ((this._MaDK != value))
				{
					if (this._DangKy.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDKChanging(value);
					this.SendPropertyChanging();
					this._MaDK = value;
					this.SendPropertyChanged("MaDK");
					this.OnMaDKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHP", DbType="Char(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHP
		{
			get
			{
				return this._MaHP;
			}
			set
			{
				if ((this._MaHP != value))
				{
					if (this._HocPhan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHPChanging(value);
					this.SendPropertyChanging();
					this._MaHP = value;
					this.SendPropertyChanged("MaHP");
					this.OnMaHPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DangKy_ChiTietDangKy", Storage="_DangKy", ThisKey="MaDK", OtherKey="MaDK", IsForeignKey=true)]
		public DangKy DangKy
		{
			get
			{
				return this._DangKy.Entity;
			}
			set
			{
				DangKy previousValue = this._DangKy.Entity;
				if (((previousValue != value) 
							|| (this._DangKy.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DangKy.Entity = null;
						previousValue.ChiTietDangKies.Remove(this);
					}
					this._DangKy.Entity = value;
					if ((value != null))
					{
						value.ChiTietDangKies.Add(this);
						this._MaDK = value.MaDK;
					}
					else
					{
						this._MaDK = default(int);
					}
					this.SendPropertyChanged("DangKy");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HocPhan_ChiTietDangKy", Storage="_HocPhan", ThisKey="MaHP", OtherKey="MaHP", IsForeignKey=true)]
		public HocPhan HocPhan
		{
			get
			{
				return this._HocPhan.Entity;
			}
			set
			{
				HocPhan previousValue = this._HocPhan.Entity;
				if (((previousValue != value) 
							|| (this._HocPhan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HocPhan.Entity = null;
						previousValue.ChiTietDangKies.Remove(this);
					}
					this._HocPhan.Entity = value;
					if ((value != null))
					{
						value.ChiTietDangKies.Add(this);
						this._MaHP = value.MaHP;
					}
					else
					{
						this._MaHP = default(string);
					}
					this.SendPropertyChanged("HocPhan");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DangKy")]
	public partial class DangKy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDK;
		
		private System.Nullable<System.DateTime> _NgayDK;
		
		private string _MaSV;
		
		private EntitySet<ChiTietDangKy> _ChiTietDangKies;
		
		private EntityRef<SinhVien> _SinhVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDKChanging(int value);
    partial void OnMaDKChanged();
    partial void OnNgayDKChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayDKChanged();
    partial void OnMaSVChanging(string value);
    partial void OnMaSVChanged();
    #endregion
		
		public DangKy()
		{
			this._ChiTietDangKies = new EntitySet<ChiTietDangKy>(new Action<ChiTietDangKy>(this.attach_ChiTietDangKies), new Action<ChiTietDangKy>(this.detach_ChiTietDangKies));
			this._SinhVien = default(EntityRef<SinhVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDK", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDK
		{
			get
			{
				return this._MaDK;
			}
			set
			{
				if ((this._MaDK != value))
				{
					this.OnMaDKChanging(value);
					this.SendPropertyChanging();
					this._MaDK = value;
					this.SendPropertyChanged("MaDK");
					this.OnMaDKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDK", DbType="Date")]
		public System.Nullable<System.DateTime> NgayDK
		{
			get
			{
				return this._NgayDK;
			}
			set
			{
				if ((this._NgayDK != value))
				{
					this.OnNgayDKChanging(value);
					this.SendPropertyChanging();
					this._NgayDK = value;
					this.SendPropertyChanged("NgayDK");
					this.OnNgayDKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="Char(10)")]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					if (this._SinhVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSVChanging(value);
					this.SendPropertyChanging();
					this._MaSV = value;
					this.SendPropertyChanged("MaSV");
					this.OnMaSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DangKy_ChiTietDangKy", Storage="_ChiTietDangKies", ThisKey="MaDK", OtherKey="MaDK")]
		public EntitySet<ChiTietDangKy> ChiTietDangKies
		{
			get
			{
				return this._ChiTietDangKies;
			}
			set
			{
				this._ChiTietDangKies.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SinhVien_DangKy", Storage="_SinhVien", ThisKey="MaSV", OtherKey="MaSV", IsForeignKey=true)]
		public SinhVien SinhVien
		{
			get
			{
				return this._SinhVien.Entity;
			}
			set
			{
				SinhVien previousValue = this._SinhVien.Entity;
				if (((previousValue != value) 
							|| (this._SinhVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SinhVien.Entity = null;
						previousValue.DangKies.Remove(this);
					}
					this._SinhVien.Entity = value;
					if ((value != null))
					{
						value.DangKies.Add(this);
						this._MaSV = value.MaSV;
					}
					else
					{
						this._MaSV = default(string);
					}
					this.SendPropertyChanged("SinhVien");
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
		
		private void attach_ChiTietDangKies(ChiTietDangKy entity)
		{
			this.SendPropertyChanging();
			entity.DangKy = this;
		}
		
		private void detach_ChiTietDangKies(ChiTietDangKy entity)
		{
			this.SendPropertyChanging();
			entity.DangKy = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HocPhan")]
	public partial class HocPhan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHP;
		
		private string _TenHP;
		
		private System.Nullable<int> _SoTinChi;
		
		private EntitySet<ChiTietDangKy> _ChiTietDangKies;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHPChanging(string value);
    partial void OnMaHPChanged();
    partial void OnTenHPChanging(string value);
    partial void OnTenHPChanged();
    partial void OnSoTinChiChanging(System.Nullable<int> value);
    partial void OnSoTinChiChanged();
    #endregion
		
		public HocPhan()
		{
			this._ChiTietDangKies = new EntitySet<ChiTietDangKy>(new Action<ChiTietDangKy>(this.attach_ChiTietDangKies), new Action<ChiTietDangKy>(this.detach_ChiTietDangKies));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHP", DbType="Char(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHP
		{
			get
			{
				return this._MaHP;
			}
			set
			{
				if ((this._MaHP != value))
				{
					this.OnMaHPChanging(value);
					this.SendPropertyChanging();
					this._MaHP = value;
					this.SendPropertyChanged("MaHP");
					this.OnMaHPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHP", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenHP
		{
			get
			{
				return this._TenHP;
			}
			set
			{
				if ((this._TenHP != value))
				{
					this.OnTenHPChanging(value);
					this.SendPropertyChanging();
					this._TenHP = value;
					this.SendPropertyChanged("TenHP");
					this.OnTenHPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTinChi", DbType="Int")]
		public System.Nullable<int> SoTinChi
		{
			get
			{
				return this._SoTinChi;
			}
			set
			{
				if ((this._SoTinChi != value))
				{
					this.OnSoTinChiChanging(value);
					this.SendPropertyChanging();
					this._SoTinChi = value;
					this.SendPropertyChanged("SoTinChi");
					this.OnSoTinChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HocPhan_ChiTietDangKy", Storage="_ChiTietDangKies", ThisKey="MaHP", OtherKey="MaHP")]
		public EntitySet<ChiTietDangKy> ChiTietDangKies
		{
			get
			{
				return this._ChiTietDangKies;
			}
			set
			{
				this._ChiTietDangKies.Assign(value);
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
		
		private void attach_ChiTietDangKies(ChiTietDangKy entity)
		{
			this.SendPropertyChanging();
			entity.HocPhan = this;
		}
		
		private void detach_ChiTietDangKies(ChiTietDangKy entity)
		{
			this.SendPropertyChanging();
			entity.HocPhan = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NganhHoc")]
	public partial class NganhHoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNganh;
		
		private string _TenNganh;
		
		private EntitySet<SinhVien> _SinhViens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNganhChanging(string value);
    partial void OnMaNganhChanged();
    partial void OnTenNganhChanging(string value);
    partial void OnTenNganhChanged();
    #endregion
		
		public NganhHoc()
		{
			this._SinhViens = new EntitySet<SinhVien>(new Action<SinhVien>(this.attach_SinhViens), new Action<SinhVien>(this.detach_SinhViens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNganh", DbType="Char(4) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNganh
		{
			get
			{
				return this._MaNganh;
			}
			set
			{
				if ((this._MaNganh != value))
				{
					this.OnMaNganhChanging(value);
					this.SendPropertyChanging();
					this._MaNganh = value;
					this.SendPropertyChanged("MaNganh");
					this.OnMaNganhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNganh", DbType="NVarChar(30)")]
		public string TenNganh
		{
			get
			{
				return this._TenNganh;
			}
			set
			{
				if ((this._TenNganh != value))
				{
					this.OnTenNganhChanging(value);
					this.SendPropertyChanging();
					this._TenNganh = value;
					this.SendPropertyChanged("TenNganh");
					this.OnTenNganhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NganhHoc_SinhVien", Storage="_SinhViens", ThisKey="MaNganh", OtherKey="MaNganh")]
		public EntitySet<SinhVien> SinhViens
		{
			get
			{
				return this._SinhViens;
			}
			set
			{
				this._SinhViens.Assign(value);
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
		
		private void attach_SinhViens(SinhVien entity)
		{
			this.SendPropertyChanging();
			entity.NganhHoc = this;
		}
		
		private void detach_SinhViens(SinhVien entity)
		{
			this.SendPropertyChanging();
			entity.NganhHoc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SinhVien")]
	public partial class SinhVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSV;
		
		private string _HoTen;
		
		private string _GioiTinh;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private string _Hinh;
		
		private string _MaNganh;
		
		private EntitySet<DangKy> _DangKies;
		
		private EntityRef<NganhHoc> _NganhHoc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSVChanging(string value);
    partial void OnMaSVChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnHinhChanging(string value);
    partial void OnHinhChanged();
    partial void OnMaNganhChanging(string value);
    partial void OnMaNganhChanged();
    #endregion
		
		public SinhVien()
		{
			this._DangKies = new EntitySet<DangKy>(new Action<DangKy>(this.attach_DangKies), new Action<DangKy>(this.detach_DangKies));
			this._NganhHoc = default(EntityRef<NganhHoc>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					this.OnMaSVChanging(value);
					this.SendPropertyChanging();
					this._MaSV = value;
					this.SendPropertyChanged("MaSV");
					this.OnMaSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(5)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh", DbType="VarChar(50)")]
		public string Hinh
		{
			get
			{
				return this._Hinh;
			}
			set
			{
				if ((this._Hinh != value))
				{
					this.OnHinhChanging(value);
					this.SendPropertyChanging();
					this._Hinh = value;
					this.SendPropertyChanged("Hinh");
					this.OnHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNganh", DbType="Char(4)")]
		public string MaNganh
		{
			get
			{
				return this._MaNganh;
			}
			set
			{
				if ((this._MaNganh != value))
				{
					if (this._NganhHoc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNganhChanging(value);
					this.SendPropertyChanging();
					this._MaNganh = value;
					this.SendPropertyChanged("MaNganh");
					this.OnMaNganhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SinhVien_DangKy", Storage="_DangKies", ThisKey="MaSV", OtherKey="MaSV")]
		public EntitySet<DangKy> DangKies
		{
			get
			{
				return this._DangKies;
			}
			set
			{
				this._DangKies.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NganhHoc_SinhVien", Storage="_NganhHoc", ThisKey="MaNganh", OtherKey="MaNganh", IsForeignKey=true)]
		public NganhHoc NganhHoc
		{
			get
			{
				return this._NganhHoc.Entity;
			}
			set
			{
				NganhHoc previousValue = this._NganhHoc.Entity;
				if (((previousValue != value) 
							|| (this._NganhHoc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NganhHoc.Entity = null;
						previousValue.SinhViens.Remove(this);
					}
					this._NganhHoc.Entity = value;
					if ((value != null))
					{
						value.SinhViens.Add(this);
						this._MaNganh = value.MaNganh;
					}
					else
					{
						this._MaNganh = default(string);
					}
					this.SendPropertyChanged("NganhHoc");
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
		
		private void attach_DangKies(DangKy entity)
		{
			this.SendPropertyChanging();
			entity.SinhVien = this;
		}
		
		private void detach_DangKies(DangKy entity)
		{
			this.SendPropertyChanging();
			entity.SinhVien = null;
		}
	}
}
#pragma warning restore 1591
