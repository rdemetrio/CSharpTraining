using Meridian.ETL.Configuration;
using Rhino.Etl.Core;
using Rhino.Etl.Core.Operations;

namespace Meridian.ETL
{
  /// <summary>
  /// Derived abstract version of Rhino.Etl.Core.EtlProcess class that contains additional functionality.
  /// </summary>
  public abstract class MeridianEtlProcess : EtlProcess
  {
    #region Constructors
    public MeridianEtlProcess()
    {
        EtlConfiguration = new EtlConfiguration();
    }

    public MeridianEtlProcess(EtlConfiguration config)
    {
      EtlConfiguration = config;
    }

    public MeridianEtlProcess(EtlConfiguration config, string logConfigFilePath):base(logConfigFilePath)
    {
      EtlConfiguration = config;
    }
    #endregion

    /// <summary>
    /// Overridden Method that writes a log entry when processing is complete.
    /// </summary>
    /// <param name="op"></param>
    protected override void OnFinishedProcessing(IOperation op)
    {
      Warn("{0}   in    {1}", op.Name, op.Statistics);
      base.OnFinishedProcessing(op);
    }

    #region Protected Properties
    protected EtlConfiguration EtlConfiguration
    {
      get;
      set;
    } 
    #endregion
  }
}
