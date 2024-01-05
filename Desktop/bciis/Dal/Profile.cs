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
    class Profile
    {
        public static string SaveProfileFarmerProcessorErrorMessage = string.Empty;
        public static bool SaveProfileFarmerProcessorIsSuccessfull = false;
        public static int profileId = 0;
        public static bool SaveProfileFarmerProcessor(
            string Name, 
            int Barangay_ID, 
            int Age, 
            string Gender, 
            string Civil_Status, 
            string Educational_Attainment, 
            int No_of_Household_Members, 
            string Annual_Farm_Income, 
            string Name_of_Business, 
            string Business_Address, 
            int Year_Business_Start, 
            long Contact_No, 
            string Business_Status, 
            string Business_Type, 
            decimal Initial_Investment, 
            decimal Ave_Annual_Gross_Income, 
            string Purok,
            int Regular,
            int Casual,
            int Contractual,
            int Others)
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "profile/add");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.POST);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");
                PublicVariables.RequestGlobal.AddParameter("id_number", 0);
                PublicVariables.RequestGlobal.AddParameter("name", Name);
                PublicVariables.RequestGlobal.AddParameter("barangay_id", Barangay_ID);
                PublicVariables.RequestGlobal.AddParameter("age", Age);
                PublicVariables.RequestGlobal.AddParameter("gender", Gender);
                PublicVariables.RequestGlobal.AddParameter("civil_status", Civil_Status);
                PublicVariables.RequestGlobal.AddParameter("educational_attainment", Educational_Attainment);
                PublicVariables.RequestGlobal.AddParameter("no_of_household_members", No_of_Household_Members);
                PublicVariables.RequestGlobal.AddParameter("annual_farm_income", Annual_Farm_Income);
                PublicVariables.RequestGlobal.AddParameter("name_of_business", Name_of_Business);
                PublicVariables.RequestGlobal.AddParameter("business_address", Business_Address);
                PublicVariables.RequestGlobal.AddParameter("year_business_start", Year_Business_Start);
                PublicVariables.RequestGlobal.AddParameter("contact_no", Contact_No);
                PublicVariables.RequestGlobal.AddParameter("business_status", Business_Status);
                PublicVariables.RequestGlobal.AddParameter("business_type", Business_Type);
                PublicVariables.RequestGlobal.AddParameter("initial_investment", Initial_Investment);
                PublicVariables.RequestGlobal.AddParameter("ave_annual_gross_income", Ave_Annual_Gross_Income);
                PublicVariables.RequestGlobal.AddParameter("purok", Purok);
                PublicVariables.RequestGlobal.AddParameter("regular", Regular);
                PublicVariables.RequestGlobal.AddParameter("casual", Casual);
                PublicVariables.RequestGlobal.AddParameter("contractual", Contractual);
                PublicVariables.RequestGlobal.AddParameter("others", Others);
                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

             
                if (content.Contains("No data found"))
                {
                    SaveProfileFarmerProcessorIsSuccessfull = true;
                    SaveProfileFarmerProcessorErrorMessage = content;
                    return SaveProfileFarmerProcessorIsSuccessfull;
                }
                else if (content.Contains("Error has occured"))
                {
                    SaveProfileFarmerProcessorIsSuccessfull = false;
                    SaveProfileFarmerProcessorErrorMessage = content;
                    return SaveProfileFarmerProcessorIsSuccessfull;
                }
                else if (content.Contains("id_number_duplicate"))
                {
                    SaveProfileFarmerProcessorIsSuccessfull = false;
                    SaveProfileFarmerProcessorErrorMessage = "Check your inputs. Name/ID duplicate!";
                    // MessageBox.Show("Duplicate entry!");
                    return SaveProfileFarmerProcessorIsSuccessfull;
                }
                else if (content.Contains("Unknown Error")) // this one must be change, the server must change, please refer to the store procedure
                {
                    SaveProfileFarmerProcessorIsSuccessfull = false;
                    SaveProfileFarmerProcessorErrorMessage = "Check your inputs. Name/ID duplicate!";
                    // MessageBox.Show("Duplicate entry!");
                    return SaveProfileFarmerProcessorIsSuccessfull;
                }

               // System.Data.DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                SaveProfileFarmerProcessorIsSuccessfull = true;
                JObject json = JObject.Parse(content);
                profileId = (int)json["_profile_id"];

                return SaveProfileFarmerProcessorIsSuccessfull;
            }
            catch (Exception ex)
            {
                SaveProfileFarmerProcessorIsSuccessfull = false;
                SaveProfileFarmerProcessorErrorMessage = ex.Message + "\nFunction : Get";
                // MessageBox.Show("Error Getting data in Database!");
                return SaveProfileFarmerProcessorIsSuccessfull;
            }
        }

        public static string GetProfileAllDataErrorMessage = string.Empty;
        public static bool GetProfileAllDataIsSuccessfull = true;
        public static DataTable GetProfileAllData()
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "profile/get_all");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.GET);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    GetProfileAllDataIsSuccessfull = false;
                    GetProfileAllDataErrorMessage = content;
                    return null;
                }
                else if (content.Contains("Error has occured"))
                {
                    GetProfileAllDataIsSuccessfull = false;
                    GetProfileAllDataErrorMessage = content;
                    return null;
                }

                DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                GetProfileAllDataIsSuccessfull = true;

                return tableX;
            }
            catch (Exception ex)
            {
                GetProfileAllDataIsSuccessfull = false;
                GetProfileAllDataErrorMessage = ex.Message + "\nFunction : Get";
                MessageBox.Show("Error Getting data in Database!");
                return null;
            }
        }

        public static string SaveProfileTypeChecklistErrorMessage = string.Empty;
        public static bool SaveProfileTypeChecklistIsSuccessfull = false;
        public static bool SaveProfileTypeChecklist(
            int ProfileId,
            int ProfileTypeId)
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "profile_checklist/add");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.POST);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");
                PublicVariables.RequestGlobal.AddParameter("profile_id", ProfileId);
                PublicVariables.RequestGlobal.AddParameter("profile_type_id", ProfileTypeId);

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                JObject json = JObject.Parse(content);
                profileId = (int)json["_profile_id"];

                if (content.Contains("No data found"))
                {
                    SaveProfileTypeChecklistIsSuccessfull = true;
                    SaveProfileTypeChecklistErrorMessage = content;
                    return SaveProfileFarmerProcessorIsSuccessfull;
                }
                else if (content.Contains("Error has occured"))
                {
                    SaveProfileTypeChecklistIsSuccessfull = false;
                    SaveProfileTypeChecklistErrorMessage = content;
                    return SaveProfileFarmerProcessorIsSuccessfull;
                }
                else if (content.Contains("invalid_profile_duplicate_entry"))
                {
                    SaveProfileTypeChecklistIsSuccessfull = true;
                    SaveProfileTypeChecklistErrorMessage = content;
                    // MessageBox.Show("Duplicate entry!");
                    return SaveProfileFarmerProcessorIsSuccessfull;
                }

                // System.Data.DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                SaveProfileFarmerProcessorIsSuccessfull = true;

                return SaveProfileFarmerProcessorIsSuccessfull;
            }
            catch (Exception ex)
            {
                SaveProfileTypeChecklistIsSuccessfull = false;
                SaveProfileTypeChecklistErrorMessage = ex.Message + "\nFunction : Get";
                // MessageBox.Show("Error Getting data in Database!");
                return SaveProfileFarmerProcessorIsSuccessfull;
            }
        }


        public static string DeleteProfileFarmerProcessorErrorMessage = string.Empty;
        public static bool DeleteProfileFarmerProcessorIsSuccessfull = false;
        public static bool DeleteProfileFarmerProcessor(
            int Profile_ID)
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "profile/delete");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.POST);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");
                PublicVariables.RequestGlobal.AddParameter("profile_id", Profile_ID);
                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                JObject json = JObject.Parse(content);

                if (content.Contains("Delete Successfully"))
                {
                    DeleteProfileFarmerProcessorIsSuccessfull = true;
                    DeleteProfileFarmerProcessorErrorMessage = content;
                    return SaveProfileFarmerProcessorIsSuccessfull;
                }
                else if (content.Contains("Unknown Error."))
                {
                    DeleteProfileFarmerProcessorIsSuccessfull = false;
                    DeleteProfileFarmerProcessorErrorMessage = content;
                    return SaveProfileFarmerProcessorIsSuccessfull;
                }
                else if (content.Contains("ID does not exist"))
                {
                    DeleteProfileFarmerProcessorIsSuccessfull = true;
                    DeleteProfileFarmerProcessorErrorMessage = content;
                    // MessageBox.Show("Duplicate entry!");
                    return SaveProfileFarmerProcessorIsSuccessfull;
                }

                // System.Data.DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                DeleteProfileFarmerProcessorIsSuccessfull = true;

                return DeleteProfileFarmerProcessorIsSuccessfull;
            }
            catch (Exception ex)
            {
                SaveProfileFarmerProcessorIsSuccessfull = false;
                SaveProfileFarmerProcessorErrorMessage = ex.Message + "\nFunction : Get";
                // MessageBox.Show("Error Getting data in Database!");
                return SaveProfileFarmerProcessorIsSuccessfull;
            }
        }

        public static string GetProfileAffiliationChecklistAllDataErrorMessage = string.Empty;
        public static bool GetProfileAffiliationChecklistAllDataIsSuccessfull = true;
        public static bool GetProfileAffiliationChecklistEmptyResult = true;
        public static DataTable GetProfileAffiliationChecklistAllData(int ID_Number)
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "affiliation_checklist/get_all");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.POST);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");
                PublicVariables.RequestGlobal.AddParameter("id_number", ID_Number);

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    GetProfileAffiliationChecklistAllDataIsSuccessfull = false;
                    GetProfileAffiliationChecklistAllDataErrorMessage = content;
                    return null;
                }

                else if (content.Contains("[]"))
                {
                    GetProfileAffiliationChecklistEmptyResult = false;
                    return null;
                }

                else if (content.Contains("Error has occured"))
                {
                    GetProfileAffiliationChecklistAllDataIsSuccessfull = false;
                    GetProfileAffiliationChecklistAllDataErrorMessage = content;
                    return null;
                }

                DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                GetProfileAffiliationChecklistAllDataIsSuccessfull = true;

                return tableX;
            }
            catch (Exception ex)
            {
                GetProfileAffiliationChecklistAllDataIsSuccessfull = false;
                GetProfileAffiliationChecklistAllDataErrorMessage = ex.Message + "\nFunction : Get";
                MessageBox.Show("Error Getting data in Database!");
                return null;
            }
        }

        public static string AddProfileOccupationChecklistAllDataErrorMessage = string.Empty;
        public static bool AddProfileOccupationChecklistAllDataIsSuccessfull = true;
        public static bool AddProfileOccupationChecklistEmptyResult = true;
        public static bool AddProfileOccupationChecklistAllData(int Profile_ID, int Occupation_ID)
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "occupation_checklist/add");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.POST);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");
                PublicVariables.RequestGlobal.AddParameter("profile_id", Profile_ID);
                PublicVariables.RequestGlobal.AddParameter("occupation_id", Occupation_ID);

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    AddProfileOccupationChecklistAllDataIsSuccessfull = true;
                    AddProfileOccupationChecklistAllDataErrorMessage = content;
                    return AddProfileOccupationChecklistAllDataIsSuccessfull;
                }
                else if (content.Contains("Error has occured"))
                {
                    AddProfileOccupationChecklistAllDataIsSuccessfull = false;
                    AddProfileOccupationChecklistAllDataErrorMessage = content;
                    return AddProfileOccupationChecklistAllDataIsSuccessfull;
                }
                else if (content.Contains("invalid_occupation_checklist_duplicate"))
                {
                    AddProfileOccupationChecklistAllDataIsSuccessfull = true;
                    AddProfileOccupationChecklistAllDataErrorMessage = content;
                    // MessageBox.Show("Duplicate entry!");
                    return AddProfileOccupationChecklistAllDataIsSuccessfull;
                }

                // System.Data.DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                SaveProfileFarmerProcessorIsSuccessfull = true;

                return AddProfileOccupationChecklistAllDataIsSuccessfull;
            }
            catch (Exception ex)
            {
                AddProfileOccupationChecklistAllDataIsSuccessfull = false;
                AddProfileOccupationChecklistAllDataErrorMessage = ex.Message + "\nFunction : Add";
                // MessageBox.Show("Error Getting data in Database!");
                return AddProfileOccupationChecklistAllDataIsSuccessfull;
            }
        }

        public static string GetProfileOccupationChecklistAllDataErrorMessage = string.Empty;
        public static bool GetProfileOccupationChecklistAllDataIsSuccessfull = true;
        public static bool GetProfileOccupationChecklistEmptyResult = true;
        public static DataTable GetProfileOccupationChecklistAllData(int Profile_ID)
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "occupation_checklist/get_all");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.POST);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");
                PublicVariables.RequestGlobal.AddParameter("profile_id", Profile_ID);

                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    GetProfileOccupationChecklistAllDataIsSuccessfull = false;
                    GetProfileOccupationChecklistAllDataErrorMessage = content;
                    return null;
                }

                else if (content.Contains("[]"))
                {
                    GetProfileOccupationChecklistEmptyResult = false;
                    return null;
                }

                else if (content.Contains("Error has occured"))
                {
                    GetProfileOccupationChecklistAllDataIsSuccessfull = false;
                    GetProfileOccupationChecklistAllDataErrorMessage = content;
                    return null;
                }

                DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                GetProfileAffiliationChecklistAllDataIsSuccessfull = true;

                return tableX;
            }
            catch (Exception ex)
            {
                GetProfileOccupationChecklistAllDataIsSuccessfull = false;
                GetProfileOccupationChecklistAllDataErrorMessage = ex.Message + "\nFunction : Get";
                MessageBox.Show("Error Getting data in Database!");
                return null;
            }
        }

        public static string AddProfileAffiliationChecklistAllDataErrorMessage = string.Empty;
        public static bool AddProfileAffiliationChecklistAllDataIsSuccessfull = true;
        public static bool AddProfileAffiliationChecklistEmptyResult = true;
        public static bool AddProfileAffiliationChecklistAllData(int ID, int Profile_ID_Number, int Affiliation_ID, int Is_Active, string Position, string Years_In_Membership)
        {
            DataSet dt = new DataSet();
            try
            {
                PublicVariables.ClientGlobal = new RestClient(PublicVariables.APIBaseURL + "affiliation_checklist/save");
                //PublicVariables.ClientGlobal.Authenticator = new HttpBasicAuthenticator(PublicVariables.APIAuthUsername, PublicVariables.APIAuthPassword);

                PublicVariables.RequestGlobal = new RestRequest(Method.POST);
                //PublicVariables.RequestGlobal.AddHeader(PublicVariables.APIKeyHeader, PublicVariables.APIKey);

                PublicVariables.RequestGlobal.AddHeader("content-type", "application/x-www-form-urlencoded");
                PublicVariables.RequestGlobal.AddParameter("id", ID);
                PublicVariables.RequestGlobal.AddParameter("profile_id_number", Profile_ID_Number);
                PublicVariables.RequestGlobal.AddParameter("affiliation_id", Affiliation_ID);
                PublicVariables.RequestGlobal.AddParameter("is_active", Is_Active);
                PublicVariables.RequestGlobal.AddParameter("position", Position);
                PublicVariables.RequestGlobal.AddParameter("years_in_membership", Years_In_Membership);


                PublicVariables.ResponseGlobal = PublicVariables.ClientGlobal.Execute(PublicVariables.RequestGlobal);
                string content = PublicVariables.ResponseGlobal.Content;

                if (content.Contains("No data found"))
                {
                    AddProfileAffiliationChecklistAllDataIsSuccessfull = true;
                    AddProfileAffiliationChecklistAllDataErrorMessage = content;
                    return AddProfileAffiliationChecklistAllDataIsSuccessfull;
                }
                else if (content.Contains("Error has occured"))
                {
                    AddProfileAffiliationChecklistAllDataIsSuccessfull = false;
                    AddProfileAffiliationChecklistAllDataErrorMessage = content;
                    return AddProfileAffiliationChecklistAllDataIsSuccessfull;
                }
                else if (content.Contains("invalid_occupation_checklist_duplicate"))
                {
                    AddProfileAffiliationChecklistAllDataIsSuccessfull = true;
                    AddProfileAffiliationChecklistAllDataErrorMessage = content;
                    // MessageBox.Show("Duplicate entry!");
                    return AddProfileAffiliationChecklistAllDataIsSuccessfull;
                }

                // System.Data.DataTable tableX = StringManipulation.JsonStringToDatatable(content);
                SaveProfileFarmerProcessorIsSuccessfull = true;

                return AddProfileAffiliationChecklistAllDataIsSuccessfull;
            }
            catch (Exception ex)
            {
                AddProfileAffiliationChecklistAllDataIsSuccessfull = false;
                AddProfileAffiliationChecklistAllDataErrorMessage = ex.Message + "\nFunction : Add";
                // MessageBox.Show("Error Getting data in Database!");
                return AddProfileOccupationChecklistAllDataIsSuccessfull;
            }
        }
    }
}
