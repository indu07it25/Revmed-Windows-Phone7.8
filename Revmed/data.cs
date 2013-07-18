﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :2.0.50727.5456
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Revmed
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
    using System.Xml.Linq;
    using System.IO;
    using System.Xml;
    using System.IO.IsolatedStorage;
    using System.Xml.Serialization;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="data")]
	public partial class RevmedDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChoice(Choice instance);
    partial void UpdateChoice(Choice instance);
    partial void DeleteChoice(Choice instance);
    partial void InsertObjective(Objective instance);
    partial void UpdateObjective(Objective instance);
    partial void DeleteObjective(Objective instance);
    partial void InsertQuestion(Question instance);
    partial void UpdateQuestion(Question instance);
    partial void DeleteQuestion(Question instance);
    partial void InsertSpeciality(Speciality instance);
    partial void UpdateSpeciality(Speciality instance);
    partial void DeleteSpeciality(Speciality instance);
    #endregion
		
		public RevmedDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		/*
		public RevmedDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		*/
		public RevmedDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		/*
		public RevmedDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		*/
		public System.Data.Linq.Table<Choice> Choices
		{
			get
			{
				return this.GetTable<Choice>();
			}
		}
		
		public System.Data.Linq.Table<Objective> Objectives
		{
			get
			{
				return this.GetTable<Objective>();
			}
		}
		
		public System.Data.Linq.Table<Question> Questions
		{
			get
			{
				return this.GetTable<Question>();
			}
		}
		
		public System.Data.Linq.Table<Speciality> Specialities
		{
			get
			{
				return this.GetTable<Speciality>();
			}
		}
	}
	
	[Table(Name="choices")]
	public partial class Choice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Num;
		
		private string _Choice1;

        private string _color = "Black";
		
		private System.Nullable<int> _Question_id;
		
		private System.Nullable<bool> _State;
		
		private System.Nullable<int> _Id;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNumChanging(int value);
    partial void OnNumChanged();
    partial void OnChoice1Changing(string value);
    partial void OnChoice1Changed();
    partial void OnQuestion_idChanging(System.Nullable<int> value);
    partial void OnQuestion_idChanged();
    partial void OnStateChanging(System.Nullable<bool> value);
    partial void OnStateChanged();
    partial void OnIdChanging(System.Nullable<int> value);
    partial void OnIdChanged();
    #endregion
		
		public Choice()
		{
			OnCreated();
		}

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Color"));
            }
        }

        private string _image;
        public string Image
        {
            get { return _image; }
            set
            {
                _image = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Image"));
            }
        }

		[Column(Name="num", Storage="_Num", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Num
		{
			get
			{
				return this._Num;
			}
			set
			{
				if ((this._Num != value))
				{
					this.OnNumChanging(value);
					this.SendPropertyChanging();
					this._Num = value;
					this.SendPropertyChanged("Num");
					this.OnNumChanged();
				}
			}
		}
		
		[Column(Name="choice", Storage="_Choice1", DbType="NVarChar(500)")]
		public string Choice1
		{
			get
			{
				return this._Choice1;
			}
			set
			{
				if ((this._Choice1 != value))
				{
					this.OnChoice1Changing(value);
					this.SendPropertyChanging();
					this._Choice1 = value;
					this.SendPropertyChanged("Choice1");
					this.OnChoice1Changed();
				}
			}
		}
		
		[Column(Name="question_id", Storage="_Question_id", DbType="Int")]
		public System.Nullable<int> Question_id
		{
			get
			{
				return this._Question_id;
			}
			set
			{
				if ((this._Question_id != value))
				{
					this.OnQuestion_idChanging(value);
					this.SendPropertyChanging();
					this._Question_id = value;
					this.SendPropertyChanged("Question_id");
					this.OnQuestion_idChanged();
				}
			}
		}
		
		[Column(Name="state", Storage="_State", DbType="Bit")]
		public System.Nullable<bool> State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[Column(Name="id", Storage="_Id", DbType="Int")]
		public System.Nullable<int> Id
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
	
	[Table(Name="objectives")]
	public partial class Objective : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Num;
		
		private string _Objective1;
		
		private System.Nullable<int> _Speciality_id;
		
		private System.Nullable<int> _Id;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNumChanging(int value);
    partial void OnNumChanged();
    partial void OnObjective1Changing(string value);
    partial void OnObjective1Changed();
    partial void OnSpeciality_idChanging(System.Nullable<int> value);
    partial void OnSpeciality_idChanged();
    partial void OnIdChanging(System.Nullable<int> value);
    partial void OnIdChanged();
    #endregion
		
		public Objective()
		{
			OnCreated();
		}
		
		[Column(Name="num", Storage="_Num", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Num
		{
			get
			{
				return this._Num;
			}
			set
			{
				if ((this._Num != value))
				{
					this.OnNumChanging(value);
					this.SendPropertyChanging();
					this._Num = value;
					this.SendPropertyChanged("Num");
					this.OnNumChanged();
				}
			}
		}
		
		[Column(Name="objective", Storage="_Objective1", DbType="NVarChar(100)")]
		public string Objective1
		{
			get
			{
				return this._Objective1;
			}
			set
			{
				if ((this._Objective1 != value))
				{
					this.OnObjective1Changing(value);
					this.SendPropertyChanging();
					this._Objective1 = value;
					this.SendPropertyChanged("Objective1");
					this.OnObjective1Changed();
				}
			}
		}
		
		[Column(Name="speciality_id", Storage="_Speciality_id", DbType="Int")]
		public System.Nullable<int> Speciality_id
		{
			get
			{
				return this._Speciality_id;
			}
			set
			{
				if ((this._Speciality_id != value))
				{
					this.OnSpeciality_idChanging(value);
					this.SendPropertyChanging();
					this._Speciality_id = value;
					this.SendPropertyChanged("Speciality_id");
					this.OnSpeciality_idChanged();
				}
			}
		}
		
		[Column(Name="id", Storage="_Id", DbType="Int")]
		public System.Nullable<int> Id
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
	
	[Table(Name="questions")]
	public partial class Question : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Num;
		
		private System.Nullable<int> _Id;
		
		private string _Question1;
		
		private string _Revision;
		
		private System.Nullable<int> _Objective_id;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNumChanging(int value);
    partial void OnNumChanged();
    partial void OnIdChanging(System.Nullable<int> value);
    partial void OnIdChanged();
    partial void OnQuestion1Changing(string value);
    partial void OnQuestion1Changed();
    partial void OnRevisionChanging(string value);
    partial void OnRevisionChanged();
    partial void OnObjective_idChanging(System.Nullable<int> value);
    partial void OnObjective_idChanged();
    #endregion
		
		public Question()
		{
			OnCreated();
		}
		
		[Column(Name="num", Storage="_Num", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Num
		{
			get
			{
				return this._Num;
			}
			set
			{
				if ((this._Num != value))
				{
					this.OnNumChanging(value);
					this.SendPropertyChanging();
					this._Num = value;
					this.SendPropertyChanged("Num");
					this.OnNumChanged();
				}
			}
		}
		
		[Column(Name="id", Storage="_Id", DbType="Int")]
		public System.Nullable<int> Id
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
		
		[Column(Name="question", Storage="_Question1", DbType="NVarChar(4000)")]
		public string Question1
		{
			get
			{
				return this._Question1;
			}
			set
			{
				if ((this._Question1 != value))
				{
					this.OnQuestion1Changing(value);
					this.SendPropertyChanging();
					this._Question1 = value;
					this.SendPropertyChanged("Question1");
					this.OnQuestion1Changed();
				}
			}
		}
		
		[Column(Name="revision", Storage="_Revision", DbType="NVarChar(4000)")]
		public string Revision
		{
			get
			{
				return this._Revision;
			}
			set
			{
				if ((this._Revision != value))
				{
					this.OnRevisionChanging(value);
					this.SendPropertyChanging();
					this._Revision = value;
					this.SendPropertyChanged("Revision");
					this.OnRevisionChanged();
				}
			}
		}
		
		[Column(Name="objective_id", Storage="_Objective_id", DbType="Int")]
		public System.Nullable<int> Objective_id
		{
			get
			{
				return this._Objective_id;
			}
			set
			{
				if ((this._Objective_id != value))
				{
					this.OnObjective_idChanging(value);
					this.SendPropertyChanging();
					this._Objective_id = value;
					this.SendPropertyChanged("Objective_id");
					this.OnObjective_idChanged();
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
	
	[Table(Name="specialities")]
	public partial class Speciality : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Num;
		
		private System.Nullable<int> _Id;
		
		private string _Speciality1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNumChanging(int value);
    partial void OnNumChanged();
    partial void OnIdChanging(System.Nullable<int> value);
    partial void OnIdChanged();
    partial void OnSpeciality1Changing(string value);
    partial void OnSpeciality1Changed();
    #endregion
		
		public Speciality()
		{
			OnCreated();
		}
		
		[Column(Name="num", Storage="_Num", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Num
		{
			get
			{
				return this._Num;
			}
			set
			{
				if ((this._Num != value))
				{
					this.OnNumChanging(value);
					this.SendPropertyChanging();
					this._Num = value;
					this.SendPropertyChanged("Num");
					this.OnNumChanged();
				}
			}
		}
		
		[Column(Name="id", Storage="_Id", DbType="Int")]
		public System.Nullable<int> Id
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
		
		[Column(Name="speciality", Storage="_Speciality1", DbType="NVarChar(100)")]
		public string Speciality1
		{
			get
			{
				return this._Speciality1;
			}
			set
			{
				if ((this._Speciality1 != value))
				{
					this.OnSpeciality1Changing(value);
					this.SendPropertyChanging();
					this._Speciality1 = value;
					this.SendPropertyChanged("Speciality1");
					this.OnSpeciality1Changed();
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


    public class ScoresData :  INotifyPropertyChanged
    {
     
        public event PropertyChangedEventHandler PropertyChanged;
        
        private string _pseudo;
        private string _score;
        private string _date;
        private string _objectif;

        public string RealPseudo { get; set; }
        public string Pseudo
        {
            get
            {
                return _pseudo;
            }
            set
            {
                _pseudo = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Pseudo"));
            }
        }

        public string Score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Score"));
            }
        }

        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Date"));
            }
        }

        public string Objectif
        {
            get
            {
                return _objectif;
            }
            set
            {
                _objectif = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Objectif"));
            }
        }

        public ScoresData()
        { }
        private static string _fileName = "scoresTest.xml";

        public static List<ScoresData> GetScores()
        {
            List<ScoresData> Scores = new List<ScoresData>();
           //CreateXml();
            using (var file = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (file.FileExists(_fileName))
                using (var stream = file.OpenFile(_fileName, FileMode.Open, FileAccess.Read))
                {
                    //StreamReader sx = new StreamReader(stream);
                    //string xxx = sx.ReadToEnd();
                    XDocument xmlDoc = XDocument.Load(stream);
                    var ScoresT = xmlDoc.Descendants("score")
                                            .Select(score => new
                                            {
                                                Pseudo = score.Element("pseudo").Value,
                                                Date = score.Element("date").Value,
                                                Objectif = score.Element("objectif").Value,
                                                Scorx = score.Attribute("value").Value
                                            }).ToList();
                    foreach (var x in ScoresT)
                    {
                        ScoresData s = new ScoresData { Pseudo = x.Pseudo, Date = x.Date, Score = x.Scorx, Objectif = x.Objectif, RealPseudo = x.Pseudo };
                            Scores.Add(s);
                    }
                }
            }
            return Scores;
        }

        public static void AddScore(ScoresData s)
        {
            List<ScoresData> list = ScoresData.GetScores();
            using (var file = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (var stream = file.OpenFile(_fileName, FileMode.Create, FileAccess.ReadWrite))
                {
                    XElement xml = new XElement("scores");
                    foreach (ScoresData x in list)
                    {
                       
                        XElement score1 = new XElement("score", new XAttribute("value", x.Score));
                        XElement date1 = new XElement("date"); date1.Value = x.Date;
                        XElement pseudo1 = new XElement("pseudo"); pseudo1.Value = x.Pseudo;
                        XElement objectif1 = new XElement("objectif"); objectif1.Value = x.Objectif;
                        score1.Add(pseudo1);
                        score1.Add(date1);
                        score1.Add(objectif1);
                        xml.Add(score1);
                    }
                    XElement score = new XElement("score", new XAttribute("value", s.Score));
                    XElement date = new XElement("date"); date.Value = s.Date;
                    XElement pseudo = new XElement("pseudo"); pseudo.Value = s.Pseudo;
                    XElement objectif = new XElement("objectif"); objectif.Value = s.Objectif;
                    score.Add(pseudo);
                    score.Add(date);
                    score.Add(objectif);
                    xml.Add(score);
                    xml.Save(stream);
                }
            }
        }
    }
}
#pragma warning restore 1591
