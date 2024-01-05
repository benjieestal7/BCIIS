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
    class Occupation
    {
        public static string GetOccupationtionAllDataErrorMessage = string.Empty;
        public static bool GetOccupationAllDataIsSuccessfull = true;
        public static DataTable GetOccupationAllData()
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "occupation/get_all");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.GET);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    GetOccupationAllDataIsSuccessfull = false;
                    GetOccupationtionAllDataErrorMessage = content;
                    return null;
                }
                else if (content.Contains("Error has occured"))
                {
                    GetOccupationAllDataIsSuccessfull = false;
                    GetOccupationtionAllDataErrorMessage = content;
                    return null;
                }

                DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                GetOccupationAllDataIsSuccessfull = true;

                return tableX;
            }
            catch (Exception ex)
            {
                GetOccupationAllDataIsSuccessfull = false;
                GetOccupationtionAllDataErrorMessage = ex.Message + "\nFunction : Get";
                MessageBox.Show("Error Getting data in Database!");
                return null;
            }
        }


        public static string SaveOccupationErrorMessage = string.Empty;
        public static bool SaveOccupationIsSuccessfull = false;
        public static bool SaveOccupation(int Id, string Occupation_Name)
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "occupation/save");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.POST);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");
                PublicVariables.RequestGlobal.AddParameter("id", Id);
                PublicVariables.RequestGlobal.AddParameter("occupation_name", Occupation_Name);

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    SaveOccupationIsSuccessfull = true;
                    SaveOccupationErrorMessage = content;
                    return SaveOccupationIsSuccessfull;
                }
                else if (content.Contains("Error has occured"))
                {
                    SaveOccupationIsSuccessfull = false;
                    SaveOccupationErrorMessage = content;
                    return SaveOccupationIsSuccessfull;
                }
                else if (content.Contains("duplicate_entry"))
                {
                    SaveOccupationIsSuccessfull = true;
                    SaveOccupationErrorMessage = content;
                    // MessageBox.Show("Duplicate entry!");
                    return SaveOccupationIsSuccessfull;
                }

                SaveOccupationIsSuccessfull = true;
                return SaveOccupationIsSuccessfull;
            }
            catch (Exception ex)
            {
                SaveOccupationIsSuccessfull = false;
                SaveOccupationErrorMessage = ex.Message + "\nFunction : Get";
                // MessageBox.Show("Error Getting data in Database!");
                return SaveOccupationIsSuccessfull;
            }
        }
    }
}
