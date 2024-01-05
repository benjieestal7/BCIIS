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
using Newtonsoft.Json.Linq;

namespace bciis.Dal
{
    class Address
    {
   
        public static string GetProvinceDataErrorMessage = string.Empty;
        public static bool GetProvinceDataIsSuccessfull = true;
        public static DataTable GetProvinceData()
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "address/province_get");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.GET);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    GetProvinceDataIsSuccessfull = false;
                    GetProvinceDataErrorMessage = content;
                    return null;
                }
                else if (content.Contains("Error has occured"))
                {
                    GetProvinceDataIsSuccessfull = false;
                    GetProvinceDataErrorMessage = content;
                    return null;
                }

                DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                GetProvinceDataIsSuccessfull = true;

                return tableX;
            }
            catch (Exception ex)
            {
                GetProvinceDataIsSuccessfull = false;
                GetProvinceDataErrorMessage = ex.Message + "\nFunction : Get";
                MessageBox.Show("Error Getting data in Database!");
                return null;
            }
        }

        public static string GetMunicipalityDataErrorMessage = string.Empty;
        public static bool GetMunicipalityDataIsSuccessfull = true;
        public static DataTable GetMunicipalityData()
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "address/municipality_get");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.GET);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    GetMunicipalityDataIsSuccessfull = false;
                    GetMunicipalityDataErrorMessage = content;
                    return null;
                }
                else if (content.Contains("Error has occured"))
                {
                    GetMunicipalityDataIsSuccessfull = false;
                    GetMunicipalityDataErrorMessage = content;
                    return null;
                }

                DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                GetMunicipalityDataIsSuccessfull = true;

                return tableX;
            }
            catch (Exception ex)
            {
                GetMunicipalityDataIsSuccessfull = false;
                GetMunicipalityDataErrorMessage = ex.Message + "\nFunction : Get";
                MessageBox.Show("Error Getting data in Database!");
                return null;
            }
        }

        public static string GetBarangayDataErrorMessage = string.Empty;
        public static bool GetBarangayDataIsSuccessfull = true;
        public static DataTable GetBarangayData()
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "address/barangay_get");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.GET);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    GetMunicipalityDataIsSuccessfull = false;
                    GetBarangayDataErrorMessage = content;
                    return null;
                }
                else if (content.Contains("Error has occured"))
                {
                    GetBarangayDataIsSuccessfull = false;
                    GetBarangayDataErrorMessage = content;
                    return null;
                }

                DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                GetBarangayDataIsSuccessfull = true;

                return tableX;
            }
            catch (Exception ex)
            {
                GetBarangayDataIsSuccessfull = false;
                GetBarangayDataErrorMessage = ex.Message + "\nFunction : Get";
                MessageBox.Show("Error Getting data in Database!");
                return null;
            }
        }

   
    }
}
