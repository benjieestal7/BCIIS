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
    class Affiliation
    {
        public static string GetAffiliationAllDataErrorMessage = string.Empty;
        public static bool GetAffiliationAllDataIsSuccessfull = true;
        public static DataTable GetAffiliationAllData()
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "affiliation/get_all");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.GET);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    GetAffiliationAllDataIsSuccessfull = false;
                    GetAffiliationAllDataErrorMessage = content;
                    return null;
                }
                else if (content.Contains("Error has occured"))
                {
                    GetAffiliationAllDataIsSuccessfull = false;
                    GetAffiliationAllDataErrorMessage = content;
                    return null;
                }

                DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                GetAffiliationAllDataIsSuccessfull = true;

                return tableX;
            }
            catch (Exception ex)
            {
                GetAffiliationAllDataIsSuccessfull = false;
                GetAffiliationAllDataErrorMessage = ex.Message + "\nFunction : Get";
                MessageBox.Show("Error Getting data in Database!");
                return null;
            }

        }


        public static string SaveAffiliationErrorMessage = string.Empty;
        public static bool SaveAffiliationIsSuccessfull = false;
        public static bool SaveAffiliation(int Id, string Affiliation_Name)
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "affiliation/save");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.POST);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");
                PublicVariables.RequestGlobal.AddParameter("id", Id);
                PublicVariables.RequestGlobal.AddParameter("affiliation_name", Affiliation_Name);

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    SaveAffiliationIsSuccessfull = true;
                    SaveAffiliationErrorMessage = content;
                    return SaveAffiliationIsSuccessfull;
                }
                else if (content.Contains("Error has occured"))
                {
                    SaveAffiliationIsSuccessfull = false;
                    SaveAffiliationErrorMessage = content;
                    return SaveAffiliationIsSuccessfull;
                }
                else if (content.Contains("invalid_affiliation_duplicate_entry"))
                {
                    SaveAffiliationIsSuccessfull = true;
                    SaveAffiliationErrorMessage = content;
                    // MessageBox.Show("Duplicate entry!");
                    return SaveAffiliationIsSuccessfull;
                }

                SaveAffiliationIsSuccessfull = true;

                return SaveAffiliationIsSuccessfull;
            }
            catch (Exception ex)
            {
                SaveAffiliationIsSuccessfull = false;
                SaveAffiliationErrorMessage = ex.Message + "\nFunction : Get";
                // MessageBox.Show("Error Getting data in Database!");
                return SaveAffiliationIsSuccessfull;
            }
        }

        public static string DeleteAffiliationErrorMessage = string.Empty;
        public static bool DeleteAffiliationIsSuccessfull = false;
        public static bool DeleteAffiliation(int Id)
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "affiliation/delete");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.POST);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");
                PublicVariables.RequestGlobal.AddParameter("id", Id);

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("Affiliation Successfully deleted."))
                {
                    DeleteAffiliationIsSuccessfull = true;
                    DeleteAffiliationErrorMessage = content;
                    return DeleteAffiliationIsSuccessfull;
                }
                else if (content.Contains("Error has occured"))
                {
                    DeleteAffiliationIsSuccessfull = false;
                    DeleteAffiliationErrorMessage = content;
                    return DeleteAffiliationIsSuccessfull;
                }


                DeleteAffiliationIsSuccessfull = true;

                return DeleteAffiliationIsSuccessfull;
            }
            catch (Exception ex)
            {
                DeleteAffiliationIsSuccessfull = false;
                DeleteAffiliationErrorMessage = ex.Message + "\nFunction : Get";
                // MessageBox.Show("Error Getting data in Database!");
                return DeleteAffiliationIsSuccessfull;
            }
        }
    }
}
