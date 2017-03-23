using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

public class ConfigurationFile
{
    public static readonly string DefaultCutlture = "ar-EG";

    #region Application Specs

    public static string UICultureName
    {
        get
        {
            try
            {
                return ConfigurationManager.AppSettings["UICultureName"];
            }
            catch (Exception ex)
            {
                LogException.LogSystemError(ex);
                return DefaultCutlture;
            }
        }
    }

    public static int SystemDateID
    {
        get
        {
            try
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["SystemDate"]);
            }
            catch (Exception ex)
            {
                LogException.LogSystemError(ex);
                return 1;
            }
        }
    }

    public static int NoMachineConnected
    {
        get
        {
            try
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["NoMachineConnected"]);
            }
            catch(Exception ex)
            {
                LogException.LogSystemError(ex);
                return 0;
            }
        }
    }

    public static int MTPROConnected
    {
        get
        {
            try
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["MTPROConnected"]);
            }
            catch (Exception ex)
            {
                LogException.LogSystemError(ex);
                return 0;
            }
        }
    }

    public static int RegisteryIssue
    {
        get
        {
            try
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["RegisteryIssue"]);
            }
            catch (Exception ex)
            {
                LogException.LogSystemError(ex);
                return 0;
            }
        }
    }

    public static string ConnectionString
    {
        get
        {
            return ConfigurationManager.ConnectionStrings["FingerPrintDBEntities"].ConnectionString;

        }
    }

    public static string ADODBConnectionString
    {
        get
        {
            try
            {
                return ConfigurationManager.ConnectionStrings["FingerPrintApp.Properties.Settings.FingerPrintDBConnectionString"].ConnectionString;
            }
            catch
            {
                return string.Empty;
            }
        }
    }

    #endregion

}

