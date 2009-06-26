//========================================================================
// This file was generated using the MyGeneration tool in combination
// with the Gentle.NET Business Entity template, $Rev: 965 $
//========================================================================
using System;
using System.Collections.Generic;
using Gentle.Framework;
using TvLibrary.Log;

namespace TvDatabase
{
  /// <summary>
  /// Instances of this class represent the properties and methods of a row in the table <b>TvMovieMapping</b>.
  /// </summary>
  [TableName("TvMovieMapping")]
  public class TvMovieMapping : Persistent
  {
    #region Members

    private bool isChanged;
    [TableColumn("idMapping", NotNull = true), PrimaryKey(AutoGenerated = true)] private int idMapping;
    [TableColumn("idChannel", NotNull = true), ForeignKey("Channel", "idChannel")] private int idChannel;
    [TableColumn("stationName", NotNull = true)] private string stationName;
    [TableColumn("timeSharingStart", NotNull = true)] private string timeSharingStart;
    [TableColumn("timeSharingEnd", NotNull = true)] private string timeSharingEnd;

    #endregion

    #region Constructors

    /// <summary> 
    /// Create an object from an existing row of data. This will be used by Gentle to 
    /// construct objects from retrieved rows. 
    /// </summary> 
    //public TvMovieMapping(int idMapping, int idChannel, string stationName, string timeSharingStart, string timeSharingEnd)
    //{
    //  isChanged = true;
    //  this.idMapping = idMapping;
    //  this.idChannel = idChannel;
    //  this.stationName = stationName;
    //  this.timeSharingStart = timeSharingStart;
    //  this.timeSharingEnd = timeSharingEnd;
    //}
    public TvMovieMapping(int idChannel, string stationName, string timeSharingStart, string timeSharingEnd)
    {
      this.idChannel = idChannel;
      this.stationName = stationName;
      this.timeSharingStart = timeSharingStart;
      this.timeSharingEnd = timeSharingEnd;
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// Indicates whether the entity is changed and requires saving or not.
    /// </summary>
    public bool IsChanged
    {
      get { return isChanged; }
    }

    /// <summary>
    /// Property relating to database column idMapping
    /// </summary>
    public int IdMapping
    {
      get { return idMapping; }
      set
      {
        isChanged |= idMapping != value;
        idMapping = value;
      }
    }

    /// <summary>
    /// Property relating to database column idChannel
    /// </summary>
    public int IdChannel
    {
      get { return idChannel; }
      set
      {
        isChanged |= idChannel != value;
        idChannel = value;
      }
    }

    /// <summary>
    /// Property relating to database column stationName
    /// </summary>
    public string StationName
    {
      get { return stationName; }
      set
      {
        isChanged |= stationName != value;
        stationName = value;
      }
    }

    /// <summary>
    /// Property relating to database column timeSharingStart
    /// </summary>
    public string TimeSharingStart
    {
      get { return timeSharingStart; }
      set
      {
        isChanged |= timeSharingStart != value;
        timeSharingStart = value;
      }
    }

    /// <summary>
    /// Property relating to database column timeSharingEnd
    /// </summary>
    public string TimeSharingEnd
    {
      get { return timeSharingEnd; }
      set
      {
        isChanged |= timeSharingEnd != value;
        timeSharingEnd = value;
      }
    }

    #endregion

    #region Storage and Retrieval

    /// <summary>
    /// Static method to retrieve all instances that are stored in the database in one call
    /// </summary>
    public static IList<TvMovieMapping> ListAll()
    {
      return Broker.RetrieveList<TvMovieMapping>();
    }

    /// <summary>
    /// Retrieves an entity given it's id.
    /// </summary>
    public static TvMovieMapping Retrieve(int id)
    {
      Key key = new Key(typeof (TvMovieMapping), true, "idMapping", id);
      return Broker.RetrieveInstance<TvMovieMapping>(key);
    }

    /// <summary>
    /// Retrieves an entity given it's id, using Gentle.Framework.Key class.
    /// This allows retrieval based on multi-column keys.
    /// </summary>
    public static TvMovieMapping Retrieve(Key key)
    {
      return Broker.RetrieveInstance<TvMovieMapping>(key);
    }

    /// <summary>
    /// Persists the entity if it was never persisted or was changed.
    /// </summary>
    public override void Persist()
    {
      if (IsChanged || !IsPersisted)
      {
        try
        {
          base.Persist();
        }
        catch (Exception ex)
        {
          Log.Error("Exception in TvMovieMapping.Persist() with Message {0}", ex.Message);
          return;
        }
        isChanged = false;
      }
    }

    #endregion

    #region Relations

    /// <summary>
    ///
    /// </summary>
    public Channel ReferencedChannel()
    {
      return Channel.Retrieve(IdChannel);
    }

    #endregion
  }
}