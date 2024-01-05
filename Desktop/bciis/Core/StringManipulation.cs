using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace bciis.Core
{
    public static class StringManipulation
    {
        /// <summary>
        /// This method will convert your string/phrase into Title Case
        /// Sample input: red fox jump
        /// Output: Red Fox Jump
        /// </summary>
        /// <param name="stringInput"></param>
        /// <returns></returns>
        public static string ToTitleCase(this string stringInput) 
        {
            try
            {
                string stringOutput;
                stringOutput = stringInput.ToLower();
                stringOutput = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(stringInput);
                return stringOutput;
            }
            catch { return stringInput; }
        }

        /// <summary>
        /// This method will capitalize the first letter of the string input
        /// Sample input: hello world
        /// Output: Hello world
        /// </summary>
        /// <param name="stringInput"></param>
        /// <returns></returns>
        public static string ToSentenceCase(this string stringInput) 
        {
            try
            {
                char[] stringInputInChar = stringInput.ToCharArray();
                if (stringInput.Length > 0)
                {
                    stringInputInChar[0] = char.ToUpper(stringInputInChar[0]);
                    return new string(stringInputInChar);
                }
                return stringInput;
            }
            catch { return stringInput; }
        }

        /// <summary>
        /// This method will return the proper money/currency case.
        /// Sample input: 10000292010
        /// Output: 10,000,292,010.00
        /// 
        /// Note: Data Type to send is in string format.
        /// </summary>
        /// <param name="numberInString"></param>
        /// <returns></returns>

        public static string ToCurrencyCase(this string numberInString) 
        {
            try { return Convert.ToDouble(numberInString).ToString("N2");}
            catch { return numberInString; }
        }


        /// <summary>
        /// This method will return the proper money/currency case.
        /// Sample input: 10000292010
        /// Output: 10,000,292,010
        /// 
        /// Note: Data Type to send is in string format.
        /// </summary>
        /// <param name="numberInString"></param>
        /// <returns></returns>

        public static string ToNumberWithComma(this string numberInString)
        {
            try { return Convert.ToDouble(numberInString).ToString("N0"); }
            catch { return numberInString; }
        }

        /// <summary>
        /// This method will return wordCount number of word in the sentence input
        /// Sample input: Hello World, Welcome to programming
        /// Output: 5
        /// </summary>
        /// <param name="stringInput"></param>
        /// <returns></returns>
        public static int WordCount(this string stringInput) 
        {
            try 
            {
                if(stringInput.Length > 0)
                {
                    int wordCounter = 0;
                    var matchesByListedChars = Regex.Matches(stringInput,
                    @"[^\s.?,]+", RegexOptions.CultureInvariant | RegexOptions.Multiline
                    | RegexOptions.IgnoreCase);
                    wordCounter = matchesByListedChars.Count;
                    return wordCounter;
                }
                return 0;
            }
            catch { return 0; }
        }

        /// <summary>
        /// This method will return numbers= in words form the integer input
        /// Sample input: 100
        /// Output: One Hundred
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string NumberToWords(this int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        public static DataTable JsonStringToDatatable(string json)
        {
            var result = new DataTable();
            var jArray = JArray.Parse(json);
            //Initialize the columns, If you know the row type, replace this   
            foreach (var row in jArray)
            {
                foreach (var jToken in row)
                {
                    var jproperty = jToken as JProperty;
                    if (jproperty == null) continue;
                    if (result.Columns[jproperty.Name] == null)
                        result.Columns.Add(jproperty.Name, typeof(string));
                }
            }
            foreach (var row in jArray)
            {
                var datarow = result.NewRow();
                foreach (var jToken in row)
                {
                    var jProperty = jToken as JProperty;
                    if (jProperty == null) continue;
                    datarow[jProperty.Name] = jProperty.Value.ToString();
                }
                result.Rows.Add(datarow);
            }

            return result;
        }

        public static DataTable JsonStringArrayToDatatable(string json)
        {
            var jsonLinq = JObject.Parse(json);

            // Find the first array using Linq
            var srcArray = jsonLinq.Descendants().Where(d => d is JArray).First();
            var trgArray = new JArray();
            foreach (JObject row in srcArray.Children<JObject>())
            {
                var cleanRow = new JObject();
                foreach (JProperty column in row.Properties())
                {
                    // Only include JValue types
                    if (column.Value is JValue)
                    {
                        cleanRow.Add(column.Name, column.Value);
                    }
                }

                trgArray.Add(cleanRow);
            }

            return JsonConvert.DeserializeObject<DataTable>(trgArray.ToString());
        }

        public static DataSet JsonStringToDataSet(string json)
        {
            return JsonConvert.DeserializeObject<DataSet>(json);
        }

        public static string ToMySQLDateFormat(this DateTime date)
        {
            string yearStr = date.Year.ToString();
            string monthStr = date.Month.ToString("00");
            string dayStr = date.Day.ToString("00");
            string hourStr = date.Hour.ToString("00");
            string minuteStr = date.Minute.ToString("00");
            string secondStr = date.Second.ToString("00");

            string ret = string.Concat(yearStr, "-", monthStr, "-", dayStr + " " + hourStr + "-" + minuteStr + "-" + secondStr);
            return ret;
        }

        public static string MunCodeToMunName(string MunCode) 
        {
            if (MunCode.Equals("ALB")) { return "ALBURQUERQUE"; }
            else if (MunCode.Equals("ALI")) { return "ALICIA"; }
            else if (MunCode.Equals("ALB")) { return "ALBURQUERQUE"; }
            else if (MunCode.Equals("ALI")) { return "ALICIA"; }
            else if (MunCode.Equals("AND")) { return "ANDA"; }
            else if (MunCode.Equals("ANT")) { return "ANTEQUERA"; }
            else if (MunCode.Equals("BAC")) { return "BACLAYON"; }
            else if (MunCode.Equals("BAL")) { return "BALILIHAN"; }
            else if (MunCode.Equals("BAT")) { return "BATUAN"; }
            else if (MunCode.Equals("BIE")) { return "BIEN UNIDO"; }
            else if (MunCode.Equals("BIL")) { return "BILAR"; }
            else if (MunCode.Equals("BUE")) { return "BUENAVISTA"; }
            else if (MunCode.Equals("CAL")) { return "CALAPE"; }
            else if (MunCode.Equals("CAN")) { return "CANDIJAY"; }
            else if (MunCode.Equals("CAR")) { return "CARMEN"; }
            else if (MunCode.Equals("CAT")) { return "CATIGBIAN"; }
            else if (MunCode.Equals("CLA")) { return "CLARIN"; }
            else if (MunCode.Equals("COR")) { return "CORELLA"; }
            else if (MunCode.Equals("CORT")) { return "CORTES"; }
            else if (MunCode.Equals("DAG")) { return "DAGOHOY"; }
            else if (MunCode.Equals("DAN")) { return "DANAO"; }
            else if (MunCode.Equals("DAU")) { return "DAUIS"; }
            else if (MunCode.Equals("DIM")) { return "DIMIAO"; }
            else if (MunCode.Equals("DUE")) { return "DUERO"; }
            else if (MunCode.Equals("GAR")) { return "GARCIA HERNANDEZ"; }
            else if (MunCode.Equals("GET")) { return "GETAFE"; }
            else if (MunCode.Equals("GUI")) { return "GUINDULMAN"; }
            else if (MunCode.Equals("INA")) { return "INABANGA"; }
            else if (MunCode.Equals("JAG")) { return "JAGNA"; }
            else if (MunCode.Equals("LIL")) { return "LILA"; }
            else if (MunCode.Equals("LOA")) { return "LOAY"; }
            else if (MunCode.Equals("LOB")) { return "LOBOC"; }
            else if (MunCode.Equals("LOO")) { return "LOON"; }
            else if (MunCode.Equals("MAB")) { return "MABINI"; }
            else if (MunCode.Equals("MAR")) { return "MARIBOJOC"; }
            else if (MunCode.Equals("PANG")) { return "PANGLAO"; }
            else if (MunCode.Equals("PIL")) { return "PILAR"; }
            else if (MunCode.Equals("CPG")) { return "PRES. CARLOS P. GARCIA"; }
            else if (MunCode.Equals("SAG")) { return "SAGBAYAN"; }
            else if (MunCode.Equals("SANI")) { return "SAN ISIDRO"; }
            else if (MunCode.Equals("SANM")) { return "SAN MIGUEL"; }
            else if (MunCode.Equals("SEV")) { return "SEVILLA"; }
            else if (MunCode.Equals("SIE")) { return "SIERRA BULLONES"; }
            else if (MunCode.Equals("SIK")) { return "SIKATUNA"; }
            else if (MunCode.Equals("TAG")) { return "TAGBILARAN CITY"; }
            else if (MunCode.Equals("TAL")) { return "TALIBON"; }
            else if (MunCode.Equals("TRI")) { return "TRINIDAD"; }
            else if (MunCode.Equals("TUB")) { return "TUBIGON"; }
            else if (MunCode.Equals("UBA")) { return "UBAY"; }
            else if (MunCode.Equals("VAL")) { return "VALENCIA"; }
            else { return null; }
        }
    }
}
