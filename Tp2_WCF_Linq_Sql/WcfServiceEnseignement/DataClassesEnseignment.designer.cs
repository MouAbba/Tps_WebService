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

namespace WcfServiceEnseignement
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Enseignment")]
	public partial class DataClassesEnseignmentDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEleve(Eleve instance);
    partial void UpdateEleve(Eleve instance);
    partial void DeleteEleve(Eleve instance);
    #endregion
		
		public DataClassesEnseignmentDataContext() : 
				base(global::WcfServiceEnseignement.Properties.Settings.Default.EnseignmentConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesEnseignmentDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesEnseignmentDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesEnseignmentDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesEnseignmentDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Eleve> Eleves
		{
			get
			{
				return this.GetTable<Eleve>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Eleves")]
	public partial class Eleve : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Eleve;
		
		private string _CNE;
		
		private string _Nom;
		
		private string _Prenom;
		
		private System.Data.Linq.Binary _Photo;
		
		private string _Tel;
		
		private string _Email;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_EleveChanging(int value);
    partial void OnId_EleveChanged();
    partial void OnCNEChanging(string value);
    partial void OnCNEChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnPrenomChanging(string value);
    partial void OnPrenomChanged();
    partial void OnPhotoChanging(System.Data.Linq.Binary value);
    partial void OnPhotoChanged();
    partial void OnTelChanging(string value);
    partial void OnTelChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Eleve()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Eleve", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id_Eleve
		{
			get
			{
				return this._Id_Eleve;
			}
			set
			{
				if ((this._Id_Eleve != value))
				{
					this.OnId_EleveChanging(value);
					this.SendPropertyChanging();
					this._Id_Eleve = value;
					this.SendPropertyChanged("Id_Eleve");
					this.OnId_EleveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CNE", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string CNE
		{
			get
			{
				return this._CNE;
			}
			set
			{
				if ((this._CNE != value))
				{
					this.OnCNEChanging(value);
					this.SendPropertyChanging();
					this._CNE = value;
					this.SendPropertyChanged("CNE");
					this.OnCNEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prenom", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Prenom
		{
			get
			{
				return this._Prenom;
			}
			set
			{
				if ((this._Prenom != value))
				{
					this.OnPrenomChanging(value);
					this.SendPropertyChanging();
					this._Prenom = value;
					this.SendPropertyChanged("Prenom");
					this.OnPrenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this.OnPhotoChanging(value);
					this.SendPropertyChanging();
					this._Photo = value;
					this.SendPropertyChanged("Photo");
					this.OnPhotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tel", DbType="NChar(25) NOT NULL", CanBeNull=false)]
		public string Tel
		{
			get
			{
				return this._Tel;
			}
			set
			{
				if ((this._Tel != value))
				{
					this.OnTelChanging(value);
					this.SendPropertyChanging();
					this._Tel = value;
					this.SendPropertyChanged("Tel");
					this.OnTelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NChar(30) NOT NULL", CanBeNull=false)]
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
