using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using RestSharp;

namespace bciis.Core
{
    public class PublicVariables
    {
        /// <summary>
        /// Server Connection String : Define in the login and the server settings
        /// </summary>
        public static DateTime ServerDate { get; set; }

        /// <summary>
        /// Define the Name of the project here!
        /// </summary>
        public static string ProjectName = "BCIIS V.1.1";

        public static double ProjectVersion = 2.0;

        #region Directory Settings

        /// <summary>
        /// Getting the working directory of the project
        /// </summary>
        public static string DefaultDirectory = Environment.CurrentDirectory;
        
        /// <summary>
        /// Define the update folder of the project
        /// This will be used by the software updater module
        /// </summary>
        public static string UpdateFolder = "\\updatefolder";

        public static string TempFolder = "\\temp";

        /// <summary>
        /// Name of the updater
        /// Change if Project is renamed
        /// </summary>
        public static string UpdaterSoftware = "\\AICSS.Updater.exe";

        /// <summary>
        /// Project update files
        /// </summary>
        public static string ProjectFile = "\\app.zip";

        public static bool CameraXMirror = false;

        public static bool CameraYMirror = false;

        public static int CameraResolutionIndex = 0;

        #endregion

        #region User Credentials

        /// <summary>
        /// Software username : the one that pass login
        /// </summary>
        public static string UserName { get; set; }

        /// <summary>
        /// Current User Id
        /// </summary>
        public static int UserId { get; set; }

        /// <summary>
        /// Current User Password
        /// </summary>
        public static string UserPassword { get; set; }

        public static DataTable UsersData { get; set; }

        public static bool CanAddNewTransactions { get; set; }
        public static bool CanGenerateReport { get; set; }
        public static bool CanManageBackEndData { get; set; }
        public static bool CanManageFunds { get; set; }
        public static bool CanManageTransactions { get; set; }

        #endregion

        #region API Credentials

       // public static string APIBaseURL = "http://localhost:5001/"; // live
        public static string APIBaseURL = "http://bciisserver-bfa5b1b8af8a.herokuapp.com/"; // live
        
        public static int RequestMaxRetries = 3;
        public static RestClient ClientGlobal { get; set; }
        public static RestRequest RequestGlobal { get; set; }
        public static IRestResponse ResponseGlobal { get; set; }

        #endregion
    }
}
