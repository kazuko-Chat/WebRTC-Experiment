﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebRTCExperiment.Models
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


    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = "CabData")]
	public partial class WebRTCDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRoom(Room instance);
    partial void UpdateRoom(Room instance);
    partial void DeleteRoom(Room instance);
    partial void InsertCandidatesTable(CandidatesTable instance);
    partial void UpdateCandidatesTable(CandidatesTable instance);
    partial void DeleteCandidatesTable(CandidatesTable instance);
    partial void InsertSDPMessage(SDPMessage instance);
    partial void UpdateSDPMessage(SDPMessage instance);
    partial void DeleteSDPMessage(SDPMessage instance);
    partial void InsertChat(Chat instance);
    partial void UpdateChat(Chat instance);
    partial void DeleteChat(Chat instance);
    #endregion
		
		public WebRTCDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WebRTCDataConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WebRTCDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebRTCDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebRTCDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebRTCDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Room> Rooms
		{
			get
			{
				return this.GetTable<Room>();
			}
		}
		
		public System.Data.Linq.Table<CandidatesTable> CandidatesTables
		{
			get
			{
				return this.GetTable<CandidatesTable>();
			}
		}
		
		public System.Data.Linq.Table<SDPMessage> SDPMessages
		{
			get
			{
				return this.GetTable<SDPMessage>();
			}
		}
		
		public System.Data.Linq.Table<Chat> Chats
		{
			get
			{
				return this.GetTable<Chat>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Room")]
	public partial class Room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Token;
		
		private string _Name;
		
		private string _SharedWith;
		
		private string _Status;
		
		private System.DateTime _LastUpdated;
		
		private string _OwnerName;
		
		private string _OwnerToken;
		
		private string _ParticipantName;
		
		private string _ParticipantToken;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTokenChanging(string value);
    partial void OnTokenChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSharedWithChanging(string value);
    partial void OnSharedWithChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnLastUpdatedChanging(System.DateTime value);
    partial void OnLastUpdatedChanged();
    partial void OnOwnerNameChanging(string value);
    partial void OnOwnerNameChanged();
    partial void OnOwnerTokenChanging(string value);
    partial void OnOwnerTokenChanged();
    partial void OnParticipantNameChanging(string value);
    partial void OnParticipantNameChanged();
    partial void OnParticipantTokenChanging(string value);
    partial void OnParticipantTokenChanged();
    #endregion
		
		public Room()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Token", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Token
		{
			get
			{
				return this._Token;
			}
			set
			{
				if ((this._Token != value))
				{
					this.OnTokenChanging(value);
					this.SendPropertyChanging();
					this._Token = value;
					this.SendPropertyChanged("Token");
					this.OnTokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SharedWith", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string SharedWith
		{
			get
			{
				return this._SharedWith;
			}
			set
			{
				if ((this._SharedWith != value))
				{
					this.OnSharedWithChanging(value);
					this.SendPropertyChanging();
					this._SharedWith = value;
					this.SendPropertyChanged("SharedWith");
					this.OnSharedWithChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastUpdated", DbType="DateTime NOT NULL")]
		public System.DateTime LastUpdated
		{
			get
			{
				return this._LastUpdated;
			}
			set
			{
				if ((this._LastUpdated != value))
				{
					this.OnLastUpdatedChanging(value);
					this.SendPropertyChanging();
					this._LastUpdated = value;
					this.SendPropertyChanged("LastUpdated");
					this.OnLastUpdatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string OwnerName
		{
			get
			{
				return this._OwnerName;
			}
			set
			{
				if ((this._OwnerName != value))
				{
					this.OnOwnerNameChanging(value);
					this.SendPropertyChanging();
					this._OwnerName = value;
					this.SendPropertyChanged("OwnerName");
					this.OnOwnerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerToken", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string OwnerToken
		{
			get
			{
				return this._OwnerToken;
			}
			set
			{
				if ((this._OwnerToken != value))
				{
					this.OnOwnerTokenChanging(value);
					this.SendPropertyChanging();
					this._OwnerToken = value;
					this.SendPropertyChanged("OwnerToken");
					this.OnOwnerTokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParticipantName", DbType="NVarChar(MAX)")]
		public string ParticipantName
		{
			get
			{
				return this._ParticipantName;
			}
			set
			{
				if ((this._ParticipantName != value))
				{
					this.OnParticipantNameChanging(value);
					this.SendPropertyChanging();
					this._ParticipantName = value;
					this.SendPropertyChanged("ParticipantName");
					this.OnParticipantNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParticipantToken", DbType="NVarChar(MAX)")]
		public string ParticipantToken
		{
			get
			{
				return this._ParticipantToken;
			}
			set
			{
				if ((this._ParticipantToken != value))
				{
					this.OnParticipantTokenChanging(value);
					this.SendPropertyChanging();
					this._ParticipantToken = value;
					this.SendPropertyChanged("ParticipantToken");
					this.OnParticipantTokenChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CandidatesTable")]
	public partial class CandidatesTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Candidate;
		
		private string _Label;
		
		private string _RoomToken;
		
		private string _Sender;
		
		private bool _IsProcessed;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCandidateChanging(string value);
    partial void OnCandidateChanged();
    partial void OnLabelChanging(string value);
    partial void OnLabelChanged();
    partial void OnRoomTokenChanging(string value);
    partial void OnRoomTokenChanged();
    partial void OnSenderChanging(string value);
    partial void OnSenderChanged();
    partial void OnIsProcessedChanging(bool value);
    partial void OnIsProcessedChanged();
    #endregion
		
		public CandidatesTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Candidate", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Candidate
		{
			get
			{
				return this._Candidate;
			}
			set
			{
				if ((this._Candidate != value))
				{
					this.OnCandidateChanging(value);
					this.SendPropertyChanging();
					this._Candidate = value;
					this.SendPropertyChanged("Candidate");
					this.OnCandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Label", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Label
		{
			get
			{
				return this._Label;
			}
			set
			{
				if ((this._Label != value))
				{
					this.OnLabelChanging(value);
					this.SendPropertyChanging();
					this._Label = value;
					this.SendPropertyChanged("Label");
					this.OnLabelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomToken", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string RoomToken
		{
			get
			{
				return this._RoomToken;
			}
			set
			{
				if ((this._RoomToken != value))
				{
					this.OnRoomTokenChanging(value);
					this.SendPropertyChanging();
					this._RoomToken = value;
					this.SendPropertyChanged("RoomToken");
					this.OnRoomTokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sender", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Sender
		{
			get
			{
				return this._Sender;
			}
			set
			{
				if ((this._Sender != value))
				{
					this.OnSenderChanging(value);
					this.SendPropertyChanging();
					this._Sender = value;
					this.SendPropertyChanged("Sender");
					this.OnSenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsProcessed", DbType="Bit NOT NULL")]
		public bool IsProcessed
		{
			get
			{
				return this._IsProcessed;
			}
			set
			{
				if ((this._IsProcessed != value))
				{
					this.OnIsProcessedChanging(value);
					this.SendPropertyChanging();
					this._IsProcessed = value;
					this.SendPropertyChanged("IsProcessed");
					this.OnIsProcessedChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SDPMessage")]
	public partial class SDPMessage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _SDP;
		
		private bool _IsProcessed;
		
		private string _RoomToken;
		
		private string _Sender;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnSDPChanging(string value);
    partial void OnSDPChanged();
    partial void OnIsProcessedChanging(bool value);
    partial void OnIsProcessedChanged();
    partial void OnRoomTokenChanging(string value);
    partial void OnRoomTokenChanged();
    partial void OnSenderChanging(string value);
    partial void OnSenderChanged();
    #endregion
		
		public SDPMessage()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDP", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string SDP
		{
			get
			{
				return this._SDP;
			}
			set
			{
				if ((this._SDP != value))
				{
					this.OnSDPChanging(value);
					this.SendPropertyChanging();
					this._SDP = value;
					this.SendPropertyChanged("SDP");
					this.OnSDPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsProcessed", DbType="Bit NOT NULL")]
		public bool IsProcessed
		{
			get
			{
				return this._IsProcessed;
			}
			set
			{
				if ((this._IsProcessed != value))
				{
					this.OnIsProcessedChanging(value);
					this.SendPropertyChanging();
					this._IsProcessed = value;
					this.SendPropertyChanged("IsProcessed");
					this.OnIsProcessedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomToken", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string RoomToken
		{
			get
			{
				return this._RoomToken;
			}
			set
			{
				if ((this._RoomToken != value))
				{
					this.OnRoomTokenChanging(value);
					this.SendPropertyChanging();
					this._RoomToken = value;
					this.SendPropertyChanged("RoomToken");
					this.OnRoomTokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sender", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Sender
		{
			get
			{
				return this._Sender;
			}
			set
			{
				if ((this._Sender != value))
				{
					this.OnSenderChanging(value);
					this.SendPropertyChanging();
					this._Sender = value;
					this.SendPropertyChanged("Sender");
					this.OnSenderChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Chat")]
	public partial class Chat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _RoomToken;
		
		private string _SentBy;
		
		private System.DateTime _SentAt;
		
		private string _Message;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnRoomTokenChanging(string value);
    partial void OnRoomTokenChanged();
    partial void OnSentByChanging(string value);
    partial void OnSentByChanged();
    partial void OnSentAtChanging(System.DateTime value);
    partial void OnSentAtChanged();
    partial void OnMessageChanging(string value);
    partial void OnMessageChanged();
    #endregion
		
		public Chat()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomToken", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string RoomToken
		{
			get
			{
				return this._RoomToken;
			}
			set
			{
				if ((this._RoomToken != value))
				{
					this.OnRoomTokenChanging(value);
					this.SendPropertyChanging();
					this._RoomToken = value;
					this.SendPropertyChanged("RoomToken");
					this.OnRoomTokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SentBy", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string SentBy
		{
			get
			{
				return this._SentBy;
			}
			set
			{
				if ((this._SentBy != value))
				{
					this.OnSentByChanging(value);
					this.SendPropertyChanging();
					this._SentBy = value;
					this.SendPropertyChanged("SentBy");
					this.OnSentByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SentAt", DbType="DateTime NOT NULL")]
		public System.DateTime SentAt
		{
			get
			{
				return this._SentAt;
			}
			set
			{
				if ((this._SentAt != value))
				{
					this.OnSentAtChanging(value);
					this.SendPropertyChanging();
					this._SentAt = value;
					this.SendPropertyChanged("SentAt");
					this.OnSentAtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this.OnMessageChanging(value);
					this.SendPropertyChanging();
					this._Message = value;
					this.SendPropertyChanged("Message");
					this.OnMessageChanged();
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