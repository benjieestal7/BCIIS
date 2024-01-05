using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using RestSharp;
using bciis;
using System.Windows.Forms;
using bciis.Core;

namespace bciis.Dal
{
    class Admins
    {
        public static string GetUsersAllDataErrorMessage = string.Empty;
        public static bool GetUsersAllDataIsSuccessfull = true;
        public static DataTable GetUsersAllData(string Username, string Passcode)
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "admins/login");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.GET);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");
                PublicVariables.RequestGlobal.AddParameter("username", Username);
                PublicVariables.RequestGlobal.AddParameter("password", Passcode);

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    GetUsersAllDataIsSuccessfull = false;
                    GetUsersAllDataErrorMessage = content;
                    return null;
                }
                else if (content.Contains("Error has occured"))
                {
                    GetUsersAllDataIsSuccessfull = false;
                    GetUsersAllDataErrorMessage = content;
                    return null;
                }

                DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                GetUsersAllDataIsSuccessfull = true;

                return tableX;
            }
            catch (Exception ex)
            {
                GetUsersAllDataIsSuccessfull = false;
                GetUsersAllDataErrorMessage = ex.Message + "\nFunction : Get";
                MessageBox.Show("Error Getting data in Database!");
                return null;
            }

        }

 
        public static string SaveAdminErrorMessage = string.Empty;
        public static bool SaveAdminIsSuccessfull = false;
        public static bool SaveAdmin(int Id, string Fullname, string Gender, string Username, string Passcode)
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "admins/save");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.POST);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");
                PublicVariables.RequestGlobal.AddParameter("id", Id);
                PublicVariables.RequestGlobal.AddParameter("fullname", Fullname);
                PublicVariables.RequestGlobal.AddParameter("gender", Gender);
                PublicVariables.RequestGlobal.AddParameter("username", Username);
                PublicVariables.RequestGlobal.AddParameter("passcode", Passcode);

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    SaveAdminIsSuccessfull = true;
                    SaveAdminErrorMessage = content;
                    return SaveAdminIsSuccessfull;
                }
                else if (content.Contains("Error has occured"))
                {
                    SaveAdminIsSuccessfull = false;
                    SaveAdminErrorMessage = content;
                    return SaveAdminIsSuccessfull;
                }
                else if (content.Contains("duplicate_entry"))
                {
                    SaveAdminIsSuccessfull = true;
                    SaveAdminErrorMessage = content;
                   // MessageBox.Show("Duplicate entry!");
                    return SaveAdminIsSuccessfull;
                }

                SaveAdminIsSuccessfull = true;

                return SaveAdminIsSuccessfull;
            }
            catch (Exception ex)
            {
                SaveAdminIsSuccessfull = false;
                SaveAdminErrorMessage = ex.Message + "\nFunction : Get";
                // MessageBox.Show("Error Getting data in Database!");
                return SaveAdminIsSuccessfull;
            }
        }


        public static string GetAdminsAllDataErrorMessage = string.Empty;
        public static bool GetAdminsAllDataIsSuccessfull = true;
        public static DataTable GetAdminsAllData()
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "admins/get_all");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.GET);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    GetAdminsAllDataIsSuccessfull = false;
                    GetAdminsAllDataErrorMessage = content;
                    return null;
                }
                else if (content.Contains("Error has occured"))
                {
                    GetAdminsAllDataIsSuccessfull = false;
                    GetAdminsAllDataErrorMessage = content;
                    return null;
                }

                DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                GetAdminsAllDataIsSuccessfull = true;

                return tableX;
            }
            catch (Exception ex)
            {
                GetAdminsAllDataIsSuccessfull = false;
                GetAdminsAllDataErrorMessage = ex.Message + "\nFunction : Get";
                MessageBox.Show("Error Getting data in Database!");
                return null;
            }

        }

    }
}
