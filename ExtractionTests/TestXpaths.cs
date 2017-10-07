using System.Collections.Generic;
using NUnit.Framework;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Configuration;

namespace ExtractionTests
{

    [TestFixture]
    public class XpathLearningTest
    {
        #region Address

        [Test, Timeout(120000)]
        public void Address_weather_accuweather_temp_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Ana Trujillo                 357 21th Place SE,Redmond,WA,(757) 555-1634,140-37-6064,27171" },
            new List<string> () { "Antonio Moreno                 515 93th Lane ,Renton,WA,(411) 555-2786,562-87-3127,28581" },
            new List<string> () { "Charlie Gunaja        732 Memorial Drive, Cambridge, MA, (617) 325-2342, 732-322-4321,32654" },
            new List<string> () { "Thomas Hardy                 742 17th Street NE,Seattle,WA,(412) 555-5719,921-29-4931,24607" },
            new List<string> () { "Hanna Moos                 785 45th Street NE,Puyallup,WA,(376) 555-2462,515-68-1285,29284" },
            new List<string> () { "Frederique Citeaux                 308 66th Place ,Redmond,WA,(689) 555-2770,552-23-2508,21415" },
            new List<string> () { "Martin Sommer                 887 86th Place ,Kent,WA,(715) 555-5450,870-91-9824,21536" },
            };


            List<string> searchQuery = new List<string>() {
                "Redmond weather",
                "Renton weather",
                "Cambridge weather",
                "Seattle weather",
                "Puyallup weather",
                "Redmond weather",
                "Kent weather",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.accuweather.com/en/us/redmond-wa/98052/weather-forecast/341347",
                "http://www.accuweather.com/en/us/renton-wa/98057/weather-forecast/341348",
                "http://www.accuweather.com/en/us/cambridge-ma/02139/weather-forecast/329319",
                "http://www.accuweather.com/en/us/seattle-wa/98104/weather-forecast/351409",
                "http://www.accuweather.com/en/us/puyallup-wa/98372/weather-forecast/341343",
                "http://www.accuweather.com/en/us/redmond-wa/98052/weather-forecast/341347",
                "http://www.accuweather.com/en/us/kent-wa/98032/weather-forecast/341295",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"feed-tabs\"][count(child::node()) > 3]/ul/li[1]/div[1]/div[2]/div/span[1]",
                "//*[@id=\"feed-tabs\"][count(child::node()) > 3]/ul/li[1]/div[1]/div[2]/div/span[1]",
                "//*[@id=\"feed-tabs\"][count(child::node()) > 3]/ul/li[1]/div[1]/div[2]/div/span[1]",
                "//*[@id=\"feed-tabs\"][count(child::node()) > 3]/ul/li[1]/div[1]/div[2]/div/span[1]",
                "//*[@id=\"feed-tabs\"][count(child::node()) > 3]/ul/li[1]/div[1]/div[2]/div/span[1]",
                "//*[@id=\"feed-tabs\"][count(child::node()) > 3]/ul/li[1]/div[1]/div[2]/div/span[1]",
                "//*[@id=\"feed-tabs\"][count(child::node()) > 3]/ul/li[1]/div[1]/div[2]/div/span[1]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Address_weather_accuweather_temp_xpath", inputData, xpath, "Addresses to weather"));
        }

        [Test, Timeout(120000)]
        public void Address_weather_accuweather_temp_xpath2()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Ana Trujillo                 357 21th Place SE,Redmond,WA,(757) 555-1634,140-37-6064,27171", "tomorrow" },
            new List<string> () { "Antonio Moreno                 515 93th Lane ,Renton,WA,(411) 555-2786,562-87-3127,28581", "tonight" },
            new List<string> () { "Charlie Gunaja        732 Memorial Drive,Cambridge,MA, (617) 325-2342, 732-322-4321,32654", "current weather"},
            new List<string> () { "Thomas Hardy                 742 17th Street NE,Seattle,WA,(412) 555-5719,921-29-4931,24607", "current weather" },
            new List<string> () { "Hanna Moos                 785 45th Street NE,Puyallup,WA,(376) 555-2462,515-68-1285,29284", "tomorrow" },
            new List<string> () { "Frederique Citeaux                 308 66th Place ,Redmond,WA,(689) 555-2770,552-23-2508,21415", "tonight" },
            new List<string> () { "Martin Sommer                 887 86th Place ,Kent,WA,(715) 555-5450,870-91-9824,21536", "tomorrow"},
            };


            List<string> searchQuery = new List<string>() {
                "Redmond weather",
                "Renton weather",
                "Cambridge weather",
                "Seattle weather",
                "Puyallup weather",
                "Redmond weather",
                "Kent weather",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.accuweather.com/en/us/redmond-wa/98052/weather-forecast/341347",
                "http://www.accuweather.com/en/us/renton-wa/98057/weather-forecast/341348",
                "http://www.accuweather.com/en/us/cambridge-ma/02139/weather-forecast/329319",
                "http://www.accuweather.com/en/us/seattle-wa/98104/weather-forecast/351409",
                "http://www.accuweather.com/en/us/puyallup-wa/98372/weather-forecast/341343",
                "http://www.accuweather.com/en/us/redmond-wa/98052/weather-forecast/341347",
                "http://www.accuweather.com/en/us/kent-wa/98032/weather-forecast/341295",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"feed-tabs\"][count(child::node()) > 3]/ul/li[4]/div/div[2]/div/span[1]",
                "//*[@id=\"feed-tabs\"][count(child::node()) > 3]/ul/li[3]/div/div[2]/div/span[1]",
                "//*[@id=\"feed-tabs\"][count(child::node()) > 3]/ul/li[1]/div[1]/div[2]/div/span[1]",
                "//*[@id=\"feed-tabs\"][count(child::node()) > 3]/ul/li[1]/div[1]/div[2]/div/span[1]",
                "//*[@id=\"feed-tabs\"][count(child::node()) > 3]/ul/li[4]/div/div[2]/div/span[1]",
                "//*[@id=\"feed-tabs\"][count(child::node()) > 3]/ul/li[3]/div/div[2]/div/span[1]",
                "//*[@id=\"feed-tabs\"][count(child::node()) > 3]/ul/li[4]/div/div[2]/div/span[1]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3Address_weather_accuweather_temp_xpath2", inputData, xpath, "Addresses to weather based on date"));
        }

        [Test, Timeout(120000)]
        public void Address_weather_weather_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Ana Trujillo                 357 21th Place SE,Redmond,WA,(757) 555-1634,140-37-6064,27171" },
            new List<string> () { "Charlie Gunaja        732 Memorial Drive,Cambridge,MA, (617) 325-2342, 732-322-4321,32654" },
            new List<string> () { "Antonio Moreno                 515 93th Lane ,Renton,WA,(411) 555-2786,562-87-3127,28581" },
            new List<string> () { "Thomas Hardy                 742 17th Street NE,Seattle,WA,(412) 555-5719,921-29-4931,24607" },
            new List<string> () { "Hanna Moos                 785 45th Street NE,Puyallup,WA,(376) 555-2462,515-68-1285,29284" },
            new List<string> () { "Frederique Citeaux                 308 66th Place ,Redmond,WA,(689) 555-2770,552-23-2508,21415" },
            new List<string> () { "Martin Sommer                 887 86th Place ,Kent,WA,(715) 555-5450,870-91-9824,21536" },

            };


            List<string> searchQuery = new List<string>() {
                "Redmond weather",
                "Cambridge weather",
                "Renton weather",
                "Seattle weather",
                "Puyallup weather",
                "Redmond weather",
                "Kent weather",

            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "https://weather.com/weather/today/l/Redmond+WA+98052:4:US#!",
                "https://weather.com/weather/today/l/Cambridge+MA+02138:4:US#!",
                "https://weather.com/weather/today/l/Renton+WA+98058:4:US#!",
                "https://weather.com/weather/today/l/Seattle+WA+98109:4:US#!",
                "https://weather.com/weather/today/l/Puyallup+WA+98372:4:US#!",
                "https://weather.com/weather/today/l/Redmond+WA+98052:4:US#!",
                "https://weather.com/weather/today/l/Kent+WA+98032:4:US#!",

            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"js-nowcard\"]/div[1]/div[1]/div[2]/span/span",
                "//*[@id=\"js-nowcard\"]/div[1]/div[1]/div[2]/span/span",
                "//*[@id=\"js-nowcard\"]/div[1]/div[1]/div[2]/span/span",
                "//*[@id=\"js-nowcard\"]/div[1]/div[1]/div[2]/span/span",
                "//*[@id=\"js-nowcard\"]/div[1]/div[1]/div[2]/span/span",
                "//*[@id=\"js-nowcard\"]/div[1]/div[1]/div[2]/span/span",
                "//*[@id=\"js-nowcard\"]/div[1]/div[1]/div[2]/span/span",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Address_weather_weather_temp_xpath", inputData, xpath, "Addresses to weather"));

        }

        [Test, Timeout(120000)]
        public void Address_population_citydata_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Ana Trujillo                 357 21th Place SE,Redmond,WA,(757) 555-1634,140-37-6064,27171" },
            new List<string> () { "Antonio Moreno                 515 93th Lane ,Renton,WA,(411) 555-2786,562-87-3127,28581" },
            new List<string> () { "Thomas Hardy                 742 17th Street NE,Seattle,WA,(412) 555-5719,921-29-4931,24607" },
            new List<string> () { "Hanna Moos                 785 45th Street NE,Puyallup,WA,(376) 555-2462,515-68-1285,29284" },
            new List<string> () { "Frederique Citeaux                 308 66th Place ,Redmond,WA,(689) 555-2770,552-23-2508,21415" },
            new List<string> () { "Martin Sommer                 887 86th Place ,Kent,WA,(715) 555-5450,870-91-9824,21536" },
            new List<string> () { "Charlie Gunaja        732 Memorial Drive, Cambridge, MA, (617) 325-2342, 732-322-4321,32654" }
            };


            List<string> searchQuery = new List<string>() {
                "Redmond population",
                "Renton population",
                "Seattle population",
                "Puyallup population",
                "Redmond population",
                "Kent population",
                "Cambridge population"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.city-data.com/city/Redmond-Washington.html",
                "http://www.city-data.com/city/Renton-Washington.html",
                "http://www.city-data.com/city/Seattle-Washington.html",
                "http://www.city-data.com/city/Puyallup-Washington.html",
                "http://www.city-data.com/city/Redmond-Washington.html",
                "http://www.city-data.com/city/Kent-Washington.html",
                "http://www.city-data.com/city/Cambridge-Massachusetts.html"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"city-population\"]/text()[1]",
                "//*[@id=\"city-population\"]/text()[1]",
                "//*[@id=\"city-population\"]/text()[1]",
                "//*[@id=\"city-population\"]/text()[1]",
                "//*[@id=\"city-population\"]/text()[1]",
                "//*[@id=\"city-population\"]/text()[1]",
                "//*[@id=\"city-population\"]/text()[1]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Address_population_citydata_xpath", inputData, xpath, "Addresses to population"));

        }

        [Test, Timeout(120000)]
        public void Address_zipcode_zipcode_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Ana Trujillo                 357 21th Place SE,Redmond,WA,(757) 555-1634,140-37-6064,27171" },
            new List<string> () { "Antonio Moreno                 515 93th Lane ,Renton,WA,(411) 555-2786,562-87-3127,28581" },
            new List<string> () { "Thomas Hardy                 742 17th Street NE,Seattle,WA,(412) 555-5719,921-29-4931,24607" },
            new List<string> () { "Hanna Moos                 785 45th Street NE,Puyallup,WA,(376) 555-2462,515-68-1285,29284" },
            new List<string> () { "Frederique Citeaux                 308 66th Place ,Redmond,WA,(689) 555-2770,552-23-2508,21415" },
            new List<string> () { "Martin Sommer                 887 86th Place ,Kent,WA,(715) 555-5450,870-91-9824,21536" },
            new List<string> () { "Charlie Gunaja        732 Memorial Drive, Cambridge,MA, (617) 325-2342, 732-322-4321,32654" }
            };


            List<string> searchQuery = new List<string>() {
                "Redmond zipcode",
                "Renton zipcode",
                "Seattle zipcode",
                "Puyallup zipcode",
                "Redmond zipcode",
                "Kent zipcode",
                "Cambridge zipcode"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://zipcode.org/city/WA/REDMOND",
                "http://zipcode.org/city/WA/RENTON",
                "http://zipcode.org/city/WA/SEATTLE",
                "http://zipcode.org/city/WA/PUYALLUP",
                "http://zipcode.org/city/WA/REDMOND",
                "http://zipcode.org/city/WA/KENT",
                "http://zipcode.org/city/MA/CAMBRIDGE"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "/html/body/div[43]/div[1]",
                "/html/body/div[43]/div[1]",
                "/html/body/div[43]/div[1]",
                "/html/body/div[43]/div[1]",
                "/html/body/div[43]/div[1]",
                "/html/body/div[43]/div[1]",
                "/html/body/div[43]/div[1]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Address_zipcode_zipcode_xpath", inputData, xpath, "Addresses to zipcode"));

        }

        [Test, Timeout(120000)]
        public void Address_zipcode_pop_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Ana Trujillo                 357 21th Place SE,Redmond,WA,(757) 555-1634,140-37-6064,27171" },
            new List<string> () { "Antonio Moreno                 515 93th Lane ,Renton,WA,(411) 555-2786,562-87-3127,28581" },
            new List<string> () { "Thomas Hardy                 742 17th Street NE,Seattle,WA,(412) 555-5719,921-29-4931,24607" },
            new List<string> () { "Hanna Moos                 785 45th Street NE,Puyallup,WA,(376) 555-2462,515-68-1285,29284" },
            new List<string> () { "Frederique Citeaux                 308 66th Place ,Redmond,WA,(689) 555-2770,552-23-2508,21415" },
            new List<string> () { "Martin Sommer                 887 86th Place ,Kent,WA,(715) 555-5450,870-91-9824,21536" },
            new List<string> () { "Charlie Gunaja        732 Memorial Drive, Cambridge,MA, (617) 325-2342, 732-322-4321,32654" }
            };


            List<string> searchQuery = new List<string>() {
                "Redmond population",
                "Renton population",
                "Seattle population",
                "Puyallup population",
                "Redmond population",
                "Kent population",
                "Cambridge population"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://zipcode.org/city/WA/REDMOND",
                "http://zipcode.org/city/WA/RENTON",
                "http://zipcode.org/city/WA/SEATTLE",
                "http://zipcode.org/city/WA/PUYALLUP",
                "http://zipcode.org/city/WA/REDMOND",
                "http://zipcode.org/city/WA/KENT",
                "http://zipcode.org/city/MA/CAMBRIDGE"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "/html/body/div[26]/div[1]/div[1]/div[2]",
                "/html/body/div[26]/div[1]/div[1]/div[2]",
                "/html/body/div[26]/div[1]/div[1]/div[2]",
                "/html/body/div[26]/div[1]/div[1]/div[2]",
                "/html/body/div[26]/div[1]/div[1]/div[2]",
                "/html/body/div[26]/div[1]/div[1]/div[2]",
                "/html/body/div[26]/div[1]/div[1]/div[2]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Address_zipcode_pop_xpath", inputData, xpath, "Addresses to population"));

        }

        [Test, Timeout(120000)]
        public void Address_weather_timeanddate_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Ana Trujillo                 357 21th Place SE,Redmond,WA,(757) 555-1634,140-37-6064,27171" },
            new List<string> () { "Antonio Moreno                 515 93th Lane ,San Francisco,CA,(411) 555-2786,562-87-3127,28581" },
            new List<string> () { "Thomas Hardy                 742 17th Street NE,Seattle,WA,(412) 555-5719,921-29-4931,24607" },
            new List<string> () { "Hanna Moos                 785 45th Street NE,Chicago,IL(376) 555-2462,515-68-1285,29284" },
            new List<string> () { "Frederique Citeaux                 308 66th Place ,Redmond,WA,(689) 555-2770,552-23-2508,21415" },
            new List<string> () { "Martin Sommer                 887 86th Place ,Boston,MA,(715) 555-5450,870-91-9824,21536" },
            new List<string> () { "Charlie Gunaja        732 Memorial Drive, Cambridge, MA, (617) 325-2342, 732-322-4321,32654" }
            };


            List<string> searchQuery = new List<string>() {
                "Redmond weather",
                "San Francisco weather",
                "Seattle weather",
                "Chicago weather",
                "Redmond weather",
                "Boston weather",
                "Cambridge weather"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> urls = new List<string>() {
                "http://www.timeanddate.com/weather/usa/redmond",
                "http://www.timeanddate.com/weather/usa/san-francisco",
                "http://www.timeanddate.com/weather/usa/seattle",
                "http://www.timeanddate.com/weather/usa/chicago",
                "http://www.timeanddate.com/weather/usa/redmond",
                "http://www.timeanddate.com/weather/usa/boston",
                "http://www.timeanddate.com/weather/usa/cambridge"
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"wt-5hr\"]/tbody/tr[3]/td[1]",
                "//*[@id=\"wt-5hr\"]/tbody/tr[3]/td[1]",
                "//*[@id=\"wt-5hr\"]/tbody/tr[3]/td[1]",
                "//*[@id=\"wt-5hr\"]/tbody/tr[3]/td[1]",
                "//*[@id=\"wt-5hr\"]/tbody/tr[3]/td[1]",
                "//*[@id=\"wt-5hr\"]/tbody/tr[3]/td[1]",
                "//*[@id=\"wt-5hr\"]/tbody/tr[3]/td[1]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Address_weather_timeanddate_xpath", inputData, output, "Addresses to weather"));

        }

        #endregion

        #region country names

        [Test, Timeout(120000)]
        public void Country_population_worldometers_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "India" },
            new List<string> () { "US" },
            new List<string> () { "South Africa" },
            new List<string> () { "China" },
            new List<string> () { "Russia" },
            new List<string> () { "New Zealand" }
            };


            List<string> searchQuery = new List<string>() {
                "India population",
                "US population",
                "South Africa population",
                "China population",
                "Russia population",
                "New Zealand population"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.worldometers.info/world-population/india-population/",
                "http://www.worldometers.info/world-population/us-population/",
                "http://www.worldometers.info/world-population/south-africa-population/",
                "http://www.worldometers.info/world-population/china-population/",
                "http://www.worldometers.info/world-population/russia-population/",
                "http://www.worldometers.info/world-population/new-zealand-population/"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "/html/body/div[2]/div[3]/div/div/div[5]/table/tbody/tr[1]/td[2]/strong",
                "/html/body/div[2]/div[3]/div/div/div[5]/table/tbody/tr[1]/td[2]/strong",
                "/html/body/div[2]/div[3]/div/div/div[5]/table/tbody/tr[1]/td[2]/strong",
                "/html/body/div[2]/div[3]/div/div/div[5]/table/tbody/tr[1]/td[2]/strong",
                "/html/body/div[2]/div[3]/div/div/div[5]/table/tbody/tr[1]/td[2]/strong",
                "/html/body/div[2]/div[3]/div/div/div[5]/table/tbody/tr[1]/td[2]/strong",

            };


            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Country_population_worldometers_xpath", inputData, xpath, "Country names to population"));

        }

        [Test, Timeout(120000)]
        public void Country_population_wiki_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "India" },
            new List<string> () { "United States" },
            new List<string> () { "South Africa" },
            new List<string> () { "China" },
            new List<string> () { "Russia" },
            new List<string> () { "New Zealand" }
            };


            List<string> searchQuery = new List<string>() {
                "India population",
                "United States population",
                "South Africa population",
                "China population",
                "Russia population",
                "New Zealand population"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }


            List<string> url = new List<string>() {
                "https://en.wikipedia.org/wiki/Demographics_of_India",
                "https://en.wikipedia.org/wiki/Demographics_of_the_United_States",
                "https://en.wikipedia.org/wiki/Demographics_of_South_Africa",
                "https://en.wikipedia.org/wiki/Demographics_of_China",
                "https://en.wikipedia.org/wiki/Demographics_of_Russia",
                "https://en.wikipedia.org/wiki/Demographics_of_New_Zealand",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"mw-content-text\"]/table[1]/tr[3]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[3]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tbody/tr[3]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[3]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tbody/tr[2]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[3]/td",

            };


            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2Country_population_wiki_xpath", inputData, xpath, "Country names to population"));

        }
        [Test, Timeout(120000)]
        public void City_population_worldpopulationreview_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Mumbai, India" },
            new List<string> () { "Los Angeles, United States of America" },
            new List<string> () { "Seattle, United States" },
            new List<string> () { "New York, United States of America" },
            new List<string> () { "Wellington, New Zealand" },
            new List<string> () { "New Delhi, India" }
            };


            List<string> searchQuery = new List<string>() {
                "Mumbai population",
                "Los Angeles population",
                "Seattle population",
                "New York population",
                "Wellington population",
                "New Delhi population"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://worldpopulationreview.com/world-cities/mumbai-population/",
                "http://worldpopulationreview.com/us-cities/los-angeles-population/",
                "http://worldpopulationreview.com/us-cities/seattle-population/",
                "http://worldpopulationreview.com/us-cities/new-york-city-population/",
                "http://worldpopulationreview.com/world-cities/wellington-population/",
                "http://worldpopulationreview.com/world-cities/delhi-population/"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"sidebar\"]/div[4]/div/span",
                "//*[@id=\"sidebar\"]/div[4]/div/span",
                "//*[@id=\"sidebar\"]/div[4]/div/span",
                "//*[@id=\"sidebar\"]/div[4]/div/span",
                "//*[@id=\"sidebar\"]/div[4]/div/span",
                "//*[@id=\"sidebar\"]/div[4]/div/span",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1City_population_worldpopulationreview_xpath", inputData, xpath, "Cities to population"));

        }

        #endregion

        #region stocks

        [Test, Timeout(120000)]
        public void Stock_value_cnn_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "MSFT" },
            new List<string> () { "AMZN" },
            new List<string> () { "AAPL" },
            new List<string> () { "TWTR" },
            new List<string> () { "T" },
            new List<string> () { "S" }
            };


            List<string> searchQuery = new List<string>() {
                "msft stock value",
                "amzn stock value",
                "aapl stock value",
                "twtr stock value",
                "t stock value",
                "s stock value"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://money.cnn.com/quote/quote.html?symb=MSFT",
                "http://money.cnn.com/quote/quote.html?symb=AMZN",
                "http://money.cnn.com/quote/quote.html?symb=AAPL",
                "http://money.cnn.com/quote/quote.html?symb=TWTR",
                "http://money.cnn.com/quote/quote.html?symb=T",
                "http://money.cnn.com/quote/quote.html?symb=S"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"cnnBody\"]/div[1]/div[1]/div[2]/table/tr/td[1]/span",
                "//*[@id=\"cnnBody\"]/div[1]/div[1]/div[2]/table/tr/td[1]/span",
                "//*[@id=\"cnnBody\"]/div[1]/div[1]/div[2]/table/tr/td[1]/span",
                "//*[@id=\"cnnBody\"]/div[1]/div[1]/div[2]/table/tr/td[1]/span",
                "//*[@id=\"cnnBody\"]/div[1]/div[1]/div[2]/table/tr/td[1]/span",
                "//*[@id=\"cnnBody\"]/div[1]/div[1]/div[2]/table/tr/td[1]/span"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Stock_value_cnn_xpath", inputData, xpath, "Company symbols to stock prices"));
        }

        [Test, Timeout(120000)]
        public void Stock_value_yahoo_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "MSFT" },
            new List<string> () { "AMZN" },
            new List<string> () { "AAPL" },
            new List<string> () { "TWTR" },
            new List<string> () { "T" },
            new List<string> () { "S" }
            };


            List<string> searchQuery = new List<string>() {
                "msft stock value",
                "amzn stock value",
                "aapl stock value",
                "twtr stock value",
                "t stock value",
                "s stock value"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://finance.yahoo.com/q?s=MSFT",
                "http://finance.yahoo.com/q?s=AMZN",
                "http://finance.yahoo.com/q?s=AAPL",
                "http://finance.yahoo.com/q?s=TWTR",
                "http://finance.yahoo.com/q?s=T",
                "http://finance.yahoo.com/q?s=S"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"quote-header-info\"]/div[2]/div[1]/section/span[1]",
                "//*[@id=\"quote-header-info\"]/div[2]/div[1]/section/span[1]",
                "//*[@id=\"quote-header-info\"]/div[2]/div[1]/section/span[1]",
                "//*[@id=\"quote-header-info\"]/div[2]/div[1]/section/span[1]",
                "//*[@id=\"quote-header-info\"]/div[2]/div[1]/section/span[1]",
                "//*[@id=\"quote-header-info\"]/div[2]/div[1]/section/span[1]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Stock_value_yahoo_xpath", inputData, xpath, "Company symbols to stock prices"));

        }


        [Test, Timeout(120000)]
        public void Stock_value_nasdaq_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "MSFT" },
            new List<string> () { "AMZN" },
            new List<string> () { "AAPL" },
            new List<string> () { "TWTR" },
            new List<string> () { "T" },
            new List<string> () { "S" }
            };


            List<string> searchQuery = new List<string>() {
                "msft stock value",
                "amzn stock value",
                "aapl stock value",
                "twtr stock value",
                "t stock value",
                "s stock value"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.nasdaq.com/symbol/msft",
                "http://www.nasdaq.com/symbol/amzn",
                "http://www.nasdaq.com/symbol/aapl",
                "http://www.nasdaq.com/symbol/twtr",
                "http://www.nasdaq.com/symbol/t",
                "http://www.nasdaq.com/symbol/s"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"qwidget_lastsale\"]",
                "//*[@id=\"qwidget_lastsale\"]",
                "//*[@id=\"qwidget_lastsale\"]",
                "//*[@id=\"qwidget_lastsale\"]",
                "//*[@id=\"qwidget_lastsale\"]",
                "//*[@id=\"qwidget_lastsale\"]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2Stock_value_nasdaq_xpath", inputData, xpath, "Company symbols to stock prices"));

        }

        [Test, Timeout(120000)]
        public void Stock_1yeartarget_nasdaq_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "MSFT" },
            new List<string> () { "AMZN" },
            new List<string> () { "AAPL" },
            new List<string> () { "TWTR" },
            new List<string> () { "T" },
            new List<string> () { "S" }
            };


            List<string> searchQuery = new List<string>() {
                "msft stock value",
                "amzn stock value",
                "aapl stock value",
                "twtr stock value",
                "t stock value",
                "s stock value"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.nasdaq.com/symbol/msft",
                "http://www.nasdaq.com/symbol/amzn",
                "http://www.nasdaq.com/symbol/aapl",
                "http://www.nasdaq.com/symbol/twtr",
                "http://www.nasdaq.com/symbol/t",
                "http://www.nasdaq.com/symbol/s"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"quotes_content_left_InfoQuotesResults\"]/tr/td/div[1]/table/tbody/tr[2]/td[2]",
                "//*[@id=\"quotes_content_left_InfoQuotesResults\"]/tr/td/div[1]/table/tbody/tr[2]/td[2]",
                "//*[@id=\"quotes_content_left_InfoQuotesResults\"]/tr/td/div[1]/table/tbody/tr[2]/td[2]",
                "//*[@id=\"quotes_content_left_InfoQuotesResults\"]/tr/td/div[1]/table/tbody/tr[1]/td[2]",
                "//*[@id=\"quotes_content_left_InfoQuotesResults\"]/tr/td/div[1]/table/tbody/tr[1]/td[2]",
                "//*[@id=\"quotes_content_left_InfoQuotesResults\"]/tr/td/div[1]/table/tbody/tr[1]/td[2]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2Stock_1yeartarget_nasdaq_xpath", inputData, xpath, "Company symbols to 1 year target prices"));

        }

        [Test, Timeout(120000)]
        public void Stock_value_marketwatch_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "MSFT" },
            new List<string> () { "AMZN" },
            new List<string> () { "AAPL" },
            new List<string> () { "TWTR" },
            new List<string> () { "T" },
            new List<string> () { "S" }
            };


            List<string> searchQuery = new List<string>() {
                "msft stock value",
                "amzn stock value",
                "aapl stock value",
                "twtr stock value",
                "t stock value",
                "s stock value"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.marketwatch.com/investing/stock/msft",
                "http://www.marketwatch.com/investing/stock/amzn",
                "http://www.marketwatch.com/investing/stock/aapl",
                "http://www.marketwatch.com/investing/stock/twtr",
                "http://www.marketwatch.com/investing/stock/T",
                "http://www.marketwatch.com/investing/stock/s"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"quoteDisplay_37009960\"]/div[2]/div[3]/div/p[2]",
                "//*[@id=\"quoteDisplay_1811140540\"]/div[2]/div[3]/div/p[2]",
                "//*[@id=\"quoteDisplay_2053059580\"]/div[2]/div[3]/div/p[2]",
                "//*[@id=\"quoteDisplay_1764458971\"]/div[2]/div[3]/div/p[2]",
                "//*[@id=\"quoteDisplay_372029418\"]/div[2]/div[3]/div/p[2]",
                "//*[@id=\"quoteDisplay_372029423\"]/div[2]/div[3]/div/p[2]",

            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Stock_value_marketwatch_xpath", inputData, xpath, "Company symbols to stock prices"));

        }

        [Test, Timeout(120000)]
        public void Stock_value_wsj_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "MSFT" },
            new List<string> () { "AMZN" },
            new List<string> () { "AAPL" },
            new List<string> () { "TWTR" },
            new List<string> () { "T" },
            new List<string> () { "S" }
            };


            List<string> searchQuery = new List<string>() {
                "msft stock value",
                "amzn stock value",
                "aapl stock value",
                "twtr stock value",
                "t stock value",
                "s stock value"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://quotes.wsj.com/MSFT",
                "http://quotes.wsj.com/AMZN",
                "http://quotes.wsj.com/AAPL",
                "http://quotes.wsj.com/TWTR",
                "http://quotes.wsj.com/T",
                "http://quotes.wsj.com/S"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"quote_val\"]",
                "//*[@id=\"quote_val\"]",
                "//*[@id=\"quote_val\"]",
                "//*[@id=\"quote_val\"]",
                "//*[@id=\"quote_val\"]",
                "//*[@id=\"quote_val\"]",
            };


            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Stock_value_wsj_xpath", inputData, xpath, "Company symbols to stock prices"));

        }

        [Test, Timeout(120000)]
        public void Stock_value_google_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "MSFT" },
            new List<string> () { "AMZN" },
            new List<string> () { "AAPL" },
            new List<string> () { "TWTR" },
            new List<string> () { "T" },
            new List<string> () { "GOOGL" }
            };


            List<string> searchQuery = new List<string>() {
                "msft stock value",
                "amzn stock value",
                "aapl stock value",
                "twtr stock value",
                "t stock value",
                "googl stock value"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.google.com/finance?cid=358464",
                "http://www.google.com/finance?cid=660463",
                "https://www.google.com/finance?cid=22144",
                "https://www.google.com/finance?cid=32086821185414",
                "https://www.google.com/finance?cid=33312",
                "http://www.google.com/finance?cid=694653"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"ref_358464_l\"]",
                "//*[@id=\"ref_660463_l\"]",
                "//*[@id=\"ref_22144_l\"]",
                "//*[@id=\"ref_32086821185414_l\"]",
                "//*[@id=\"ref_33312_l\"]",
                "//*[@id=\"ref_694653_l\"]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3Stock_value_google_xpath", inputData, xpath, "Company symbols to stock prices"));

        }

        [Test, Timeout(120000)]
        public void Stock_value_google_history_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "MSFT" },
            new List<string> () { "AMZN" },
            new List<string> () { "AAPL" },
            new List<string> () { "GOOG" },
            new List<string> () { "T" },
            new List<string> () { "FB" }
            };


            List<string> searchQuery = new List<string>() {
                "msft stock value historical",
                "amzn stock value historical",
                "aapl stock value historical",
                "goog stock value historical",
                "t stock value historical",
                "fb stock value historical"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.google.com/finance/historical?q=NASDAQ:MSFT",
                "http://www.google.com/finance/historical?q=NASDAQ:AMZN",
                "http://www.google.com/finance/historical?q=NASDAQ:AAPL",
                "http://www.google.com/finance/historical?q=NASDAQ:GOOG",
                "http://www.google.com/finance/historical?q=NYSE:T",
                "http://www.google.com/finance/historical?q=NASDAQ:FB"
            };

            List<string> dataxpath = new List<string>()
            {
                "//*[@id=\"prices\"]/table/tbody/tr[4]/td[1]",
                "//*[@id=\"prices\"]/table/tbody/tr[3]/td[1]",
                "//*[@id=\"prices\"]/table/tbody/tr[4]/td[1]",
                "//*[@id=\"prices\"]/table/tbody/tr[5]/td[1]",
                "//*[@id=\"prices\"]/table/tbody/tr[2]/td[1]",
                "//*[@id=\"prices\"]/table/tbody/tr[7]/td[1]",
            };

            HtmlWeb web = new HtmlWeb();
            WebClient client = new WebClient();
            for (int i = 0; i < inputData.Count; i++)
            {
                string fname = DataStudio.PublicAPI.HtmlsFolder + DataStudio.PublicAPI.urlToName(url[i]) + ".html";
                if (!File.Exists(fname))
                {
                    (new FileInfo(fname)).Directory.Create();
                    client.DownloadFile(url[i], fname);
                }
                HtmlDocument doc = web.Load(fname);
                HtmlNode node = doc.DocumentNode.SelectNodes(dataxpath[i])[0];
                inputData[i].Add(node.InnerText);
            }

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"prices\"]/table/tbody/tr[4]/td[2]",
                "//*[@id=\"prices\"]/table/tbody/tr[3]/td[2]",
                "//*[@id=\"prices\"]/table/tbody/tr[4]/td[2]",
                "//*[@id=\"prices\"]/table/tbody/tr[5]/td[2]",
                "//*[@id=\"prices\"]/table/tbody/tr[2]/td[2]",
                "//*[@id=\"prices\"]/table/tbody/tr[7]/td[2]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3Stock_value_google_history_xpath", inputData, xpath, "Company symbols to stock prices based on date"));

        }

        [Test, Timeout(120000)]
        public void Stock_value_google_history_xpath1()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "MSFT" },
            new List<string> () { "AMZN" },
            new List<string> () { "AAPL" },
            new List<string> () { "TWTR" },
            new List<string> () { "T" },
            new List<string> () { "S" }
            };


            List<string> searchQuery = new List<string>() {
                "msft stock value historical",
                "amzn stock value historical",
                "aapl stock value historical",
                "twtr stock value historical",
                "t stock value historical",
                "s stock value historical"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.google.com/finance/historical?q=NASDAQ:MSFT",
                "http://www.google.com/finance/historical?q=NASDAQ:AMZN",
                "http://www.google.com/finance/historical?q=NASDAQ:AAPL",
                "http://www.google.com/finance/historical?q=NASDAQ:TWTR",
                "http://www.google.com/finance/historical?q=NASDAQ:T",
                "http://www.google.com/finance/historical?q=NASDAQ:S"
            };

            List<string> dataxpath = new List<string>()
            {
                "//*[@id=\"prices\"]/table/tbody/tr[4]/td[1]",
                "//*[@id=\"prices\"]/table/tbody/tr[3]/td[1]",
                "//*[@id=\"prices\"]/table/tbody/tr[4]/td[1]",
                "//*[@id=\"prices\"]/table/tbody/tr[5]/td[1]",
                "//*[@id=\"prices\"]/table/tbody/tr[2]/td[1]",
                "//*[@id=\"prices\"]/table/tbody/tr[7]/td[1]",
            };

            HtmlWeb web = new HtmlWeb();
            WebClient client = new WebClient();
            for (int i = 0; i < inputData.Count; i++)
            {
                string fname = DataStudio.PublicAPI.HtmlsFolder + DataStudio.PublicAPI.urlToName(url[i]) + ".html";
                if (!File.Exists(fname))
                {
                    (new FileInfo(fname)).Directory.Create();
                    client.DownloadFile(url[i], fname);
                }
                HtmlDocument doc = web.Load(fname);
                HtmlNode node = doc.DocumentNode.SelectNodes(dataxpath[i])[0];
                inputData[i].Add(node.InnerText);
            }

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"prices\"]/table/tbody/tr[4]/td[2]",
                "//*[@id=\"prices\"]/table/tbody/tr[3]/td[2]",
                "//*[@id=\"prices\"]/table/tbody/tr[4]/td[2]",
                "//*[@id=\"prices\"]/table/tbody/tr[5]/td[2]",
                "//*[@id=\"prices\"]/table/tbody/tr[2]/td[2]",
                "//*[@id=\"prices\"]/table/tbody/tr[7]/td[2]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3Stock_value_google_history_xpath1", inputData, xpath, "Company symbols to stock prices based on date"));

        }

        [Test, Timeout(120000)]
        public void Stock_value_marketwatch_history_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "MSFT" },
            new List<string> () { "AMZN" },
            new List<string> () { "AAPL" },
            new List<string> () { "TWTR" },
            new List<string> () { "T" },
            new List<string> () { "S" }
            };


            List<string> searchQuery = new List<string>() {
                "msft stock value historical",
                "amzn stock value historical",
                "aapl stock value historical",
                "twtr stock value historical",
                "t stock value historical",
                "s stock value historical"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.marketwatch.com/investing/stock/MSFT/historical",
                "http://www.marketwatch.com/investing/stock/AMZN/historical",
                "http://www.marketwatch.com/investing/stock/AAPL/historical",
                "http://www.marketwatch.com/investing/stock/twtr/historical",
                "http://www.marketwatch.com/investing/stock/T/historical",
                "http://www.marketwatch.com/investing/stock/s/historical"
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> output = new List<string>()
            {
                "//*[@id=\"quoteDisplay_37009960\"]/div[2]/div[3]/div/p[2]",
                "//*[@id=\"quoteDisplay_1811140540\"]/div[2]/div[3]/div/p[2]",
                "//*[@id=\"quoteDisplay_2053059580\"]/div[2]/div[3]/div/p[2]",
                "//*[@id=\"quoteDisplay_1764458971\"]/div[2]/div[3]/div/p[2]",
                "//*[@id=\"quoteDisplay_372029418\"]/div[2]/div[3]/div/p[2]",
                "//*[@id=\"quoteDisplay_372029423\"]/div[2]/div[3]/div/p[2]",


            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Stock_value_marketwatch_history_xpath", inputData, output, "Company symbols to stock prices"));

        }

        [Test, Timeout(120000)]
        public void stocks_same_page()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() { },
                new List<string>() { },
                new List<string>() { },
                new List<string>() { },
                new List<string>() { },
                new List<string>() { },
            };
            List<string> url = new List<string>() {
                "http://www.marketwatch.com/tools/industry/stocklist.asp?bcind_ind=9535&bcind_period=3mo",
                "http://www.marketwatch.com/tools/industry/stocklist.asp?bcind_ind=9535&bcind_period=3mo",
                "http://www.marketwatch.com/tools/industry/stocklist.asp?bcind_ind=9535&bcind_period=3mo",
                "http://www.marketwatch.com/tools/industry/stocklist.asp?bcind_ind=9535&bcind_period=3mo",
                "http://www.marketwatch.com/tools/industry/stocklist.asp?bcind_ind=9535&bcind_period=3mo",
                "http://www.marketwatch.com/tools/industry/stocklist.asp?bcind_ind=9535&bcind_period=3mo",
            };
            List<string> dataxpath = new List<string>()
            {
                "//*[@id=\"tools_industry_stocklist\"]/div[1]/table[4]/tbody/tr[15]/td[2]/a",
                "//*[@id=\"tools_industry_stocklist\"]/div[1]/table[4]/tbody/tr[25]/td[2]/a",
                "//*[@id=\"tools_industry_stocklist\"]/div[1]/table[4]/tbody/tr[21]/td[2]/a",
                "//*[@id=\"tools_industry_stocklist\"]/div[1]/table[4]/tbody/tr[11]/td[2]/a",
                "//*[@id=\"tools_industry_stocklist\"]/div[1]/table[4]/tbody/tr[19]/td[2]/a",
                "//*[@id=\"tools_industry_stocklist\"]/div[1]/table[4]/tbody/tr[23]/td[2]/a",
            };

            HtmlWeb web = new HtmlWeb();
            WebClient client = new WebClient();
            for (int i = 0; i < inputData.Count; i++)
            {
                string fname = DataStudio.PublicAPI.HtmlsFolder + DataStudio.PublicAPI.urlToName(url[i]) + ".html";
                if (!File.Exists(fname))
                {
                    (new FileInfo(fname)).Directory.Create();
                    client.DownloadFile(url[i], fname);
                }
                HtmlDocument doc = web.Load(fname);
                HtmlNode node = doc.DocumentNode.SelectNodes(dataxpath[i])[0];
                inputData[i].Add(node.InnerText);
            }
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }
            List<string> xpath = new List<string>()
            {
                "//*[@id=\"tools_industry_stocklist\"]/div[1]/table[4]/tbody/tr[15]/td[4]",
                "//*[@id=\"tools_industry_stocklist\"]/div[1]/table[4]/tbody/tr[25]/td[4]",
                "//*[@id=\"tools_industry_stocklist\"]/div[1]/table[4]/tbody/tr[21]/td[4]",
                "//*[@id=\"tools_industry_stocklist\"]/div[1]/table[4]/tbody/tr[11]/td[4]",
                "//*[@id=\"tools_industry_stocklist\"]/div[1]/table[4]/tbody/tr[19]/td[4]",
                "//*[@id=\"tools_industry_stocklist\"]/div[1]/table[4]/tbody/tr[23]/td[4]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3stocks_same_page", inputData, xpath, "Stock prices based on company names from same webpage"));
        }
        #endregion

        #region currency exchange

        [Test, Timeout(120000)]
        public void Curreny_exchange_yahoo_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "10 USD", "INR", "6/16/2015" },
            new List<string> () { "12 EUR", "GBP", "2/21/2015" },
            new List<string> () { "44 GBP", "USD" , "4/5/2014" },
            new List<string> () { "5 USD", "CHF", "4/21/2015" },
            new List<string> () { "24 CHF", "INR" , "5/11/2015" },
            new List<string> () { "100 JPY", "USD", "4/18/2014" },
            new List<string> () { "200 AUD", "CAD", "6/21/2014" },
            new List<string> () { "31 CAD", "CHF", "8/21/2015" }
            };


            List<string> searchQuery = new List<string>() {
                "USD to INR",
                "EUR to GBP",
                "GBP to USD",
                "USD to CHF",
                "CHF to INR",
                "JPY to USD",
                "AUD to CAD",
                "CAD to CHF"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://finance.yahoo.com/echarts?s=USDINR=X",
                "http://finance.yahoo.com/echarts?s=EURGBP=X",
                "http://finance.yahoo.com/echarts?s=GBPUSD=X",
                "http://finance.yahoo.com/echarts?s=USDCHF=X",
                "http://finance.yahoo.com/echarts?s=CHFINR=X",
                "http://finance.yahoo.com/echarts?s=JPYUSD=X",
                "http://finance.yahoo.com/echarts?s=AUDCAD=X",
                "http://finance.yahoo.com/echarts?s=CADCHF=X"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"main-0-fullScreenChart-Proxy\"]/div/section/header/span[1]",
                "//*[@id=\"main-0-fullScreenChart-Proxy\"]/div/section/header/span[1]",
                "//*[@id=\"main-0-fullScreenChart-Proxy\"]/div/section/header/span[1]",
                "//*[@id=\"main-0-fullScreenChart-Proxy\"]/div/section/header/span[1]",
                "//*[@id=\"main-0-fullScreenChart-Proxy\"]/div/section/header/span[1]",
                "//*[@id=\"main-0-fullScreenChart-Proxy\"]/div/section/header/span[1]",
                "//*[@id=\"main-0-fullScreenChart-Proxy\"]/div/section/header/span[1]",
                "//*[@id=\"main-0-fullScreenChart-Proxy\"]/div/section/header/span[1]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Currency_exchange_yahoo_xpath", inputData, xpath, "Currency exchange values"));

        }

        [Test, Timeout(120000)]
        public void Curreny_exchange_investing_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "10 USD", "INR", "6/16/2015" },
            new List<string> () { "12 EUR", "GBP", "2/21/2015" },
            new List<string> () { "44 GBP", "USD" , "4/5/2014" },
            new List<string> () { "5 USD", "CHF", "4/21/2015" },
            new List<string> () { "24 CHF", "INR" , "5/11/2015" },
            new List<string> () { "100 JPY", "USD", "4/18/2014" },
            new List<string> () { "200 AUD", "CAD", "6/21/2014" },
            new List<string> () { "31 CAD", "CHF", "8/21/2015" }
            };


            List<string> searchQuery = new List<string>() {
                "USD to INR",
                "EUR to GBP",
                "GBP to USD",
                "USD to CHF",
                "CHF to INR",
                "JPY to USD",
                "AUD to CAD",
                "CAD to CHF"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.investing.com/currencies/usd-inr",
                "http://www.investing.com/currencies/eur-gbp",
                "http://www.investing.com/currencies/gbp-usd",
                "http://www.investing.com/currencies/usd-chf",
                "http://www.investing.com/currencies/chf-inr",
                "http://www.investing.com/currencies/jpy-usd",
                "http://www.investing.com/currencies/aud-cad",
                "http://www.investing.com/currencies/cad-chf"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"last_last\"]",
                "//*[@id=\"last_last\"]",
                "//*[@id=\"last_last\"]",
                "//*[@id=\"last_last\"]",
                "//*[@id=\"last_last\"]",
                "//*[@id=\"last_last\"]",
                "//*[@id=\"last_last\"]",
                "//*[@id=\"last_last\"]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Currency_exchange_investing_xpath", inputData, xpath, "Currency exchange values"));

        }

        [Test, Timeout(120000)]
        public void currency_exchange_investing_history_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "10 USD", "INR" },
            new List<string> () { "12 EUR", "GBP" },
            new List<string> () { "44 GBP", "USD" },
            new List<string> () { "5 USD", "CHF" },
            new List<string> () { "24 CHF", "INR" },
            new List<string> () { "100 JPY", "USD" },
            new List<string> () { "200 AUD", "CAD" },
            new List<string> () { "31 CAD", "CHF" }
            };

            List<string> url = new List<string>() {
                "http://www.investing.com/currencies/usd-inr-historical-data",
                "http://www.investing.com/currencies/eur-gbp-historical-data",
                "http://www.investing.com/currencies/gbp-usd-historical-data",
                "http://www.investing.com/currencies/usd-chf-historical-data",
                "http://www.investing.com/currencies/chf-inr-historical-data",
                "http://www.investing.com/currencies/jpy-usd-historical-data",
                "http://www.investing.com/currencies/aud-cad-historical-data",
                "http://www.investing.com/currencies/cad-chf-historical-data"
            };

            List<string> dataxpath = new List<string>()
            {
                "//*[@id=\"curr_table\"]/tbody/tr[1]/td[1]",
                "//*[@id=\"curr_table\"]/tbody/tr[4]/td[1]",
                "//*[@id=\"curr_table\"]/tbody/tr[3]/td[1]",
                "//*[@id=\"curr_table\"]/tbody/tr[7]/td[1]",
                "//*[@id=\"curr_table\"]/tbody/tr[2]/td[1]",
                "//*[@id=\"curr_table\"]/tbody/tr[1]/td[1]",
                "//*[@id=\"curr_table\"]/tbody/tr[2]/td[1]",
                "//*[@id=\"curr_table\"]/tbody/tr[1]/td[1]",
            };

            HtmlWeb web = new HtmlWeb();
            WebClient client = new WebClient();
            for (int i = 0; i < inputData.Count; i++)
            {
                string fname = DataStudio.PublicAPI.HtmlsFolder + DataStudio.PublicAPI.urlToName(url[i]) + ".html";
                if (!File.Exists(fname))
                {
                    (new FileInfo(fname)).Directory.Create();
                    client.DownloadFile(url[i], fname);
                }
                HtmlDocument doc = web.Load(fname);
                HtmlNode node = doc.DocumentNode.SelectNodes(dataxpath[i])[0];
                inputData[i].Add(node.InnerText);
            }


            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"curr_table\"]/tbody/tr[1]/td[2]",
                "//*[@id=\"curr_table\"]/tbody/tr[4]/td[2]",
                "//*[@id=\"curr_table\"]/tbody/tr[3]/td[2]",
                "//*[@id=\"curr_table\"]/tbody/tr[7]/td[2]",
                "//*[@id=\"curr_table\"]/tbody/tr[2]/td[2]",
                "//*[@id=\"curr_table\"]/tbody/tr[1]/td[2]",
                "//*[@id=\"curr_table\"]/tbody/tr[2]/td[2]",
                "//*[@id=\"curr_table\"]/tbody/tr[1]/td[2]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3currency_exchange_investing_history_xpath", inputData, xpath, "Currency exchange values based on date"));

        }
        [Test, Timeout(120000)]
        public void Curreny_exchange_rates_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "10 USD", "INR", "6/16/2015" },
            new List<string> () { "12 EUR", "GBP", "2/21/2015" },
            new List<string> () { "44 GBP", "USD" , "4/5/2014" },
            new List<string> () { "5 USD", "CHF", "4/21/2015" },
            new List<string> () { "24 CHF", "INR" , "5/11/2015" },
            new List<string> () { "100 JPY", "USD", "4/18/2014" },
            new List<string> () { "200 AUD", "CAD", "6/21/2014" },
            new List<string> () { "31 CAD", "CHF", "8/21/2015" }
            };

            List<string> url = new List<string>() {
                "http://www.exchange-rates.org/Rate/USD/INR/6-16-2015",
                "http://www.exchange-rates.org/Rate/EUR/GBP/2-21-2015",
                "http://www.exchange-rates.org/Rate/GBP/USD/4-5-2014",
                "http://www.exchange-rates.org/Rate/USD/CHF/4-21-2015",
                "http://www.exchange-rates.org/Rate/CHF/INR/5-11-2015",
                "http://www.exchange-rates.org/Rate/JPY/USD/4-18-2014",
                "http://www.exchange-rates.org/Rate/AUD/CAD/6-21-2014",
                "http://www.exchange-rates.org/Rate/CAD/CHF/8-21-2015"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"ratesTable\"]/tbody/tr[1]/td[3]",
                "//*[@id=\"ratesTable\"]/tbody/tr[1]/td[3]",
                "//*[@id=\"ratesTable\"]/tbody/tr[1]/td[3]",
                "//*[@id=\"ratesTable\"]/tbody/tr[1]/td[3]",
                "//*[@id=\"ratesTable\"]/tbody/tr[1]/td[3]",
                "//*[@id=\"ratesTable\"]/tbody/tr[1]/td[3]",
                "//*[@id=\"ratesTable\"]/tbody/tr[1]/td[3]",
                "//*[@id=\"ratesTable\"]/tbody/tr[1]/td[3]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Currency_exchange_rates_xpath", inputData, xpath, "Currency exchange values based on date"));
        }
        [Test, Timeout(120000)]
        public void Curreny_exchange_xe_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "10 USD", "INR", "6/16/2015" },
            new List<string> () { "12 EUR", "GBP", "2/21/2015" },
            new List<string> () { "44 GBP", "USD" , "4/5/2014" },
            new List<string> () { "5 USD", "CHF", "4/21/2015" },
            new List<string> () { "24 CHF", "INR" , "5/11/2015" },
            new List<string> () { "100 JPY", "USD", "4/18/2014" },
            new List<string> () { "200 AUD", "CAD", "6/21/2014" },
            new List<string> () { "31 CAD", "CHF", "8/21/2015" }
            };


            List<string> searchQuery = new List<string>() {
                "USD to INR",
                "EUR to GBP",
                "GBP to USD",
                "USD to CHF",
                "CHF to INR",
                "JPY to USD",
                "AUD to CAD",
                "CAD to CHF"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=USD&To=INR",
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=EUR&To=GBP",
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=GBP&To=USD",
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=USD&To=CHF",
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=CHF&To=INR",
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=JPY&To=USD",
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=AUD&To=CAD",
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=CAD&To=CHF"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"ucc-container\"]/span[2]/span[2]",
                "//*[@id=\"ucc-container\"]/span[2]/span[2]",
                "//*[@id=\"ucc-container\"]/span[2]/span[2]",
                "//*[@id=\"ucc-container\"]/span[2]/span[2]",
                "//*[@id=\"ucc-container\"]/span[2]/span[2]",
                "//*[@id=\"ucc-container\"]/span[2]/span[2]",
                "//*[@id=\"ucc-container\"]/span[2]/span[2]",
                "//*[@id=\"ucc-container\"]/span[2]/span[2]",

            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Currency_exchange_xe_xpath", inputData, xpath, "Currency exchange values"));

        }

        [Test, Timeout(120000)]
        public void Curreny_exchange_xe_historical_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "10 USD", "INR", "06/16/2015" },
            new List<string> () { "12 EUR", "GBP", "02/21/2015" },
            new List<string> () { "44 GBP", "USD" , "04/05/2014" },
            new List<string> () { "5 USD", "CHF", "04/21/2015" },
            new List<string> () { "24 CHF", "INR" , "05/11/2015" },
            new List<string> () { "100 JPY", "USD", "04/18/2014" },
            new List<string> () { "200 AUD", "CAD", "06/21/2014" },
            new List<string> () { "31 CAD", "CHF", "08/21/2015" }
            };

            List<string> url = new List<string>() {
                "http://www.xe.com/currencytables/?from=USD&date=2015-06-16",
                "http://www.xe.com/currencytables/?from=EUR&date=2015-02-21",
                "http://www.xe.com/currencytables/?from=GBP&date=2014-04-05",
                "http://www.xe.com/currencytables/?from=USD&date=2015-04-21",
                "http://www.xe.com/currencytables/?from=CHF&date=2015-05-11",
                "http://www.xe.com/currencytables/?from=JPY&date=2014-04-18",
                "http://www.xe.com/currencytables/?from=AUD&date=2014-06-21",
                "http://www.xe.com/currencytables/?from=CAD&date=2015-08-21"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//self::table[@id = \"historicalRateTbl\"]/child::tbody/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::a[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]/child::text()[normalize-space(self::text()) = \"INR\"]]",
                "//self::table[@id = \"historicalRateTbl\"]/child::tbody/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::a[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]/child::text()[normalize-space(self::text()) = \"GBP\"]]",
                "//self::table[@id = \"historicalRateTbl\"]/child::tbody/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::a[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]/child::text()[normalize-space(self::text()) = \"USD\"]]",
                "//self::table[@id = \"historicalRateTbl\"]/child::tbody/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::a[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]/child::text()[normalize-space(self::text()) = \"CHF\"]]",
                "//self::table[@id = \"historicalRateTbl\"]/child::tbody/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::a[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]/child::text()[normalize-space(self::text()) = \"INR\"]]",
                "//self::table[@id = \"historicalRateTbl\"]/child::tbody/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::a[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]/child::text()[normalize-space(self::text()) = \"USD\"]]",
                "//self::table[@id = \"historicalRateTbl\"]/child::tbody/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::a[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]/child::text()[normalize-space(self::text()) = \"CAD\"]]",
                "//self::table[@id = \"historicalRateTbl\"]/child::tbody/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::a[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]/child::text()[normalize-space(self::text()) = \"CHF\"]]",

            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3Currency_exchange_xe_historical_xpath", inputData, xpath, "Currency exchange values based on date"));

        }

        [Test, Timeout(120000)]
        public void Curreny_exchange_bloomberg_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "10 USD", "INR", "6/16/2015" },
            new List<string> () { "12 EUR", "GBP", "2/21/2015" },
            new List<string> () { "44 GBP", "USD" , "4/5/2014" },
            new List<string> () { "5 USD", "CHF", "4/21/2015" },
            new List<string> () { "24 CHF", "INR" , "5/11/2015" },
            new List<string> () { "100 JPY", "USD", "4/18/2014" },
            new List<string> () { "200 AUD", "CAD", "6/21/2014" },
            new List<string> () { "31 CAD", "CHF", "8/21/2015" }
            };


            List<string> searchQuery = new List<string>() {
                "USD to INR",
                "EUR to GBP",
                "GBP to USD",
                "USD to CHF",
                "CHF to INR",
                "JPY to USD",
                "AUD to CAD",
                "CAD to CHF"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.bloomberg.com/quote/USDINR:CUR",
                "http://www.bloomberg.com/quote/EURGBP:CUR",
                "http://www.bloomberg.com/quote/GBPUSD:CUR",
                "http://www.bloomberg.com/quote/USDCHF:CUR",
                "http://www.bloomberg.com/quote/CHFINR:CUR",
                "http://www.bloomberg.com/quote/JPYUSD:CUR",
                "http://www.bloomberg.com/quote/AUDCAD:CUR",
                "http://www.bloomberg.com/quote/CADCHF:CUR"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"content\"]/div/div/div[1]/div/div[4]/div[2]",
                "//*[@id=\"content\"]/div/div/div[1]/div/div[4]/div[2]",
                "//*[@id=\"content\"]/div/div/div[1]/div/div[4]/div[2]",
                "//*[@id=\"content\"]/div/div/div[1]/div/div[4]/div[2]",
                "//*[@id=\"content\"]/div/div/div[1]/div/div[4]/div[2]",
                "//*[@id=\"content\"]/div/div/div[1]/div/div[4]/div[2]",
                "//*[@id=\"content\"]/div/div/div[1]/div/div[4]/div[2]",
                "//*[@id=\"content\"]/div/div/div[1]/div/div[4]/div[2]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Currency_exchange_bloomberg_xpath", inputData, xpath, "Currency exchange values"));

        }

        [Test, Timeout(120000)]
        public void Curreny_exchange_moneyconverter_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "10 USD", "INR", "6/16/2015" },
            new List<string> () { "12 EUR", "GBP", "2/21/2015" },
            new List<string> () { "44 GBP", "USD" , "4/5/2014" },
            new List<string> () { "5 USD", "CHF", "4/21/2015" },
            new List<string> () { "24 CHF", "INR" , "5/11/2015" },
            new List<string> () { "100 JPY", "USD", "4/18/2014" },
            new List<string> () { "200 AUD", "CAD", "6/21/2014" },
            new List<string> () { "31 CAD", "CHF", "8/21/2015" }
            };


            List<string> searchQuery = new List<string>() {
                "USD to INR",
                "EUR to GBP",
                "GBP to USD",
                "USD to CHF",
                "CHF to INR",
                "JPY to USD",
                "AUD to CAD",
                "CAD to CHF"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://themoneyconverter.com/USD/INR.aspx",
                "http://themoneyconverter.com/EUR/GBP.aspx",
                "http://themoneyconverter.com/GBP/USD.aspx",
                "http://themoneyconverter.com/USD/CHF.aspx",
                "http://themoneyconverter.com/CHF/INR.aspx",
                "http://themoneyconverter.com/JPY/USD.aspx",
                "http://themoneyconverter.com/AUD/CAD.aspx",
                "http://themoneyconverter.com/CAD/CHF.aspx"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"cc-ratebox\"]",
                "//*[@id=\"cc-ratebox\"]",
                "//*[@id=\"cc-ratebox\"]",
                "//*[@id=\"cc-ratebox\"]",
                "//*[@id=\"cc-ratebox\"]",
                "//*[@id=\"cc-ratebox\"]",
                "//*[@id=\"cc-ratebox\"]",
                "//*[@id=\"cc-ratebox\"]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Currency_exchange_moneyconverter_xpath", inputData, xpath, "Currency exchange values"));

        }

        [Test, Timeout(120000)]
        public void Curreny_exchange_google_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "10 USD", "INR", "6/16/2015" },
            new List<string> () { "12 EUR", "GBP", "2/21/2015" },
            new List<string> () { "44 GBP", "USD" , "4/5/2014" },
            new List<string> () { "5 USD", "CHF", "4/21/2015" },
            new List<string> () { "24 CHF", "INR" , "5/11/2015" },
            new List<string> () { "100 JPY", "USD", "4/18/2014" },
            new List<string> () { "200 AUD", "CAD", "6/21/2014" },
            new List<string> () { "31 CAD", "CHF", "8/21/2015" }
            };


            List<string> searchQuery = new List<string>() {
                "USD to INR",
                "EUR to GBP",
                "GBP to USD",
                "USD to CHF",
                "CHF to INR",
                "JPY to USD",
                "AUD to CAD",
                "CAD to CHF"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.google.com/finance?q=USDINR",
                "http://www.google.com/finance?q=EURGBP",
                "http://www.google.com/finance?q=GBPUSD",
                "http://www.google.com/finance?q=USDCHF",
                "http://www.google.com/finance?q=CHFINR",
                "http://www.google.com/finance?q=JPYUSD",
                "http://www.google.com/finance?q=AUDCAD",
                "http://www.google.com/finance?q=CADCHF"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"currency_value\"]/div[1]/span[1]/span",
                "//*[@id=\"currency_value\"]/div[1]/span[1]/span",
                "//*[@id=\"currency_value\"]/div[1]/span[1]/span",
                "//*[@id=\"currency_value\"]/div[1]/span[1]/span",
                "//*[@id=\"currency_value\"]/div[1]/span[1]/span",
                "//*[@id=\"currency_value\"]/div[1]/span[1]/span",
                "//*[@id=\"currency_value\"]/div[1]/span[1]/span",
                "//*[@id=\"currency_value\"]/div[1]/span[1]/span",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1Currency_exchange_google_xpath", inputData, xpath, "Currency exchange values"));

        }

        #endregion

        #region NFL teams

        [Test, Timeout(120000)]
        public void NFL_teamranking_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Buffalo Bills (BUF)", "Orchard Park, NY", "Ralph WIlson Stadium" },
            new List<string> () { "Miami Dolphins (MIA)", "Miami Gardens, FL", "Sun Life Stadium" },
            new List<string> () { "New England Patriots (NE)", "Foxborough, MA" , "Gillette Stadium" },
            new List<string> () { "New York Jets (NYJ)", "East Rutherford, NJ", "MetLife Stadium[B]" },
            new List<string> () { "Baltimore Ravens (BAL)", "Baltimore, MD" , "M&T Bank Stadium" }
            };


            List<string> searchQuery = new List<string>() {
                "buffalo bills ranking",
                "miami dolphins ranking",
                "new england patriots ranking",
                "new york jets ranking",
                "baltimore ravens ranking"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "https://www.teamrankings.com/nfl/team/buffalo-bills",
                "https://www.teamrankings.com/nfl/team/miami-dolphins",
                "https://www.teamrankings.com/nfl/team/new-england-patriots",
                "https://www.teamrankings.com/nfl/team/new-york-jets",
                "https://www.teamrankings.com/nfl/team/baltimore-ravens"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"html\"]/body/div[3]/div[1]/div[3]/main/table/tr[2]/td[2]/div/p/span",
                "//*[@id=\"html\"]/body/div[3]/div[1]/div[3]/main/table/tr[2]/td[2]/div/p/span",
                "//*[@id=\"html\"]/body/div[3]/div[1]/div[3]/main/table/tr[2]/td[2]/div/p/span",
                "//*[@id=\"html\"]/body/div[3]/div[1]/div[3]/main/table/tr[2]/td[2]/div/p/span",
                "//*[@id=\"html\"]/body/div[3]/div[1]/div[3]/main/table/tr[2]/td[2]/div/p/span",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1NFL_teamranking_xpath", inputData, xpath, "NFL teams to rankings"));

        }

        [Test, Timeout(120000)]
        public void NFL_teamranking_espn_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Buffalo Bills (BUF)", "Orchard Park, NY", "Ralph WIlson Stadium" },
            new List<string> () { "Miami Dolphins (MIA)", "Miami Gardens, FL", "Sun Life Stadium" },
            new List<string> () { "New England Patriots (NE)", "Foxborough, MA" , "Gillette Stadium" },
            new List<string> () { "New York Jets (NYJ)", "East Rutherford, NJ", "MetLife Stadium[B]" },
            new List<string> () { "Baltimore Ravens (BAL)", "Baltimore, MD" , "M&T Bank Stadium" }
            };


            List<string> searchQuery = new List<string>() {
                "buffalo bills ranking",
                "miami dolphins ranking",
                "new england patriots ranking",
                "new york jets ranking",
                "baltimore ravens ranking"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://espn.go.com/nfl/team/_/name/buf/buffalo-bills",
                "http://espn.go.com/nfl/team/_/name/mia/miami-dolphins",
                "http://espn.go.com/nfl/team/_/name/ne/new-england-patriots",
                "http://espn.go.com/nfl/team/_/name/nyj/new-york-jets",
                "http://espn.go.com/nfl/team/_/name/bal/baltimore-ravens"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"main-container\"]/div/section[2]/section/header/div[2]",
                "//*[@id=\"main-container\"]/div/section[2]/section/header/div[2]",
                "//*[@id=\"main-container\"]/div/section[2]/section/header/div[2]",
                "//*[@id=\"main-container\"]/div/section[2]/section/header/div[2]",
                "//*[@id=\"main-container\"]/div/section[2]/section/header/div[2]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1NFL_teamranking_espn_xpath", inputData, xpath, "NFL teams to rankings"));

        }

        [Test, Timeout(120000)]
        public void NFL_stadium_espn_xpath_big()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Buffalo Bills (BUF)", "Orchard Park, NY", },
                new List<string>() {"Miami Dolphins (MIA)", "Miami Gardens, FL", },
                new List<string>() {"New England Patriots (NE)", "Foxborough, MA", },
                new List<string>() {"New York Jets (NYJ)", "East Rutherford, NJ", },
                new List<string>() {"Baltimore Ravens (BAL)", "Baltimore, MD", },
                new List<string>() {"Cincinnati Bengals (CIN)", "Cincinnati, OH", },
                new List<string>() {"Cleveland Browns (CLE)", "Cleveland, OH", },
                new List<string>() {"Pittsburgh Steelers (PIT)", "Pittsburgh, PA", },
                new List<string>() {"Houston Texans (HOU)", "Houston, TX", },
                new List<string>() {"Indianapolis Colts (IND)", "Indianapolis, IN", },
                new List<string>() {"Jacksonville Jaguars (JAX)", "Jacksonville, FL", },
                new List<string>() {"Tennessee Titans (TEN)", "Nashville, TN", },
                new List<string>() {"Denver Broncos (DEN)", "Denver, CO", },
                new List<string>() {"Kansas City Chiefs (KC)", "Kansas City, MO", },
                new List<string>() {"Oakland Raiders (OAK)", "Oakland, CA", },
                new List<string>() {"San Diego Chargers (SD)", "San Diego, CA", },
                new List<string>() {"Dallas Cowboys (DAL)", "Arlington, TX", },
                new List<string>() {"New York Giants (NYG)", "East Rutherford, NJ", },
                new List<string>() {"Philadelphia Eagles (PHI)", "Philadelphia, PA", },
                new List<string>() {"Washington Redskins (WSH)", "Landover, MD", },
                new List<string>() {"Chicago Bears (CHI)", "Chicago, IL", },
                new List<string>() {"Detroit Lions (DET)", "Detroit, MI", },
                new List<string>() {"Green Bay Packers (GB)", "Green Bay, WI", },
                new List<string>() {"Minnesota Vikings (MIN)", "Minneapolis, MN", },
                new List<string>() {"Atlanta Falcons (ATL)", "Atlanta, GA", },
                new List<string>() {"Carolina Panthers (CAR)", "Charlotte, NC", },
                new List<string>() {"New Orleans Saints (NO)", "New Orleans, LA", },
                new List<string>() {"Tampa Bay Buccaneers (TB)", "Tampa, FL", },
                new List<string>() {"Arizona Cardinals (ARI)", "Glendale, AZ", },
                new List<string>() {"Los Angeles Rams (LA)", "Los Angeles, CA", },
                new List<string>() {"San Francisco 49ers (SF)", "Santa Clara, CA", },
                new List<string>() {"Seattle Seahawks (SEA)", "Seattle, WA", },
            };


            List<string> searchQuery = new List<string>() {
                "buffalo bills stadium",
                "miami dolphins stadium",
                "new england patriots stadium",
                "new york jets stadium",
                "baltimore ravens stadium",
                "cincinnati bengals stadium",
                "cleveland browns stadium",
                "pittsburgh steelers stadium",
                "houston texans stadium",
                "indianapolis colts stadium",
                "jacksonville jaguars stadium",
                "tennessee titans stadium",
                "denver broncos stadium",
                "kansas city chiefs stadium",
                "oakland raiders stadium",
                "san diego chargers stadium",
                "dallas cowboys stadium",
                "new york giants stadium",
                "philadelphia eagles stadium",
                "washington redskins stadium",
                "chicago bears stadium",
                "detroit lions stadium",
                "green bay packers stadium",
                "minnesota vikings stadium",
                "atlanta falcons stadium",
                "carolina panthers stadium",
                "new orleans saints stadium",
                "tampa bay buccaneers stadium",
                "arizona cardinals stadium",
                "los angeles rams stadium",
                "ers stadium",
                "seattle seahawks stadium",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://espn.go.com/nfl/team/stadium/_/name/buf/buffalo-bills",
                "http://espn.go.com/nfl/team/stadium/_/name/mia/miami-dolphins",
                "http://espn.go.com/nfl/team/stadium/_/name/ne/new-england-patriots",
                "http://espn.go.com/nfl/team/stadium/_/name/nyj/new-york-jets",
                "http://espn.go.com/nfl/team/stadium/_/name/bal/baltimore-ravens",
                "http://espn.go.com/nfl/team/stadium/_/name/cin/cincinnati-bengals",
                "http://espn.go.com/nfl/team/stadium/_/name/cle/cleveland-browns",
                "http://espn.go.com/nfl/team/stadium/_/name/pit/pittsburgh-steelers",
                "http://espn.go.com/nfl/team/stadium/_/name/hou/houston-texans",
                "http://espn.go.com/nfl/team/stadium/_/name/ind/indianapolis-colts",
                "http://espn.go.com/nfl/team/stadium/_/name/jax/jacksonville-jaguars",
                "http://espn.go.com/nfl/team/stadium/_/name/ten/tennessee-titans",
                "http://espn.go.com/nfl/team/stadium/_/name/den/denver-broncos",
                "http://espn.go.com/nfl/team/stadium/_/name/kc/kansas-city-chiefs",
                "http://espn.go.com/nfl/team/stadium/_/name/oak/oakland-raiders",
                "http://espn.go.com/nfl/team/stadium/_/name/sd/san-diego-chargers",
                "http://espn.go.com/nfl/team/stadium/_/name/dal/dallas-cowboys",
                "http://espn.go.com/nfl/team/stadium/_/name/nyg/new-york-giants",
                "http://espn.go.com/nfl/team/stadium/_/name/phi/philadelphia-eagles",
                "http://espn.go.com/nfl/team/stadium/_/name/wsh/washington-redskins",
                "http://espn.go.com/nfl/team/stadium/_/name/chi/chicago-bears",
                "http://espn.go.com/nfl/team/stadium/_/name/det/detroit-lions",
                "http://espn.go.com/nfl/team/stadium/_/name/gb/green-bay-packers",
                "http://espn.go.com/nfl/team/stadium/_/name/min/minnesota-vikings",
                "http://espn.go.com/nfl/team/stadium/_/name/atl/atlanta-falcons",
                "http://espn.go.com/nfl/team/stadium/_/name/car/carolina-panthers",
                "http://espn.go.com/nfl/team/stadium/_/name/no/new-orleans-saints",
                "http://espn.go.com/nfl/team/stadium/_/name/tb/tampa-bay-buccaneers",
                "http://espn.go.com/nfl/team/stadium/_/name/ari/arizona-cardinals",
                "http://espn.go.com/nfl/team/stadium/_/name/la/los-angeles-rams",
                "http://espn.go.com/nfl/team/stadium/_/name/sf/san-francisco-49ers",
                "http://espn.go.com/nfl/team/stadium/_/name/sea/seattle-seahawks",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>() {
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
                "//*[@id=\"content\"]/div[4]/div[1]/div[2]/div[1]/h2",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1NFL_stadium_espn_xpath_big", inputData, xpath, "NFL teams to stadium names"));

        }

        [Test, Timeout(120000)]
        public void NFL_teamranking_cbss_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Buffalo Bills (BUF)", "Orchard Park, NY", "Ralph WIlson Stadium" },
            new List<string> () { "Miami Dolphins (MIA)", "Miami Gardens, FL", "Sun Life Stadium" },
            new List<string> () { "New England Patriots (NE)", "Foxborough, MA" , "Gillette Stadium" },
            new List<string> () { "New York Jets (NYJ)", "East Rutherford, NJ", "MetLife Stadium[B]" },
            new List<string> () { "Baltimore Ravens (BAL)", "Baltimore, MD" , "M&T Bank Stadium" }
            };


            List<string> searchQuery = new List<string>() {
                "buffalo bills ranking",
                "miami dolphins ranking",
                "new england patriots ranking",
                "new york jets ranking",
                "baltimore ravens ranking"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.cbssports.com/nfl/teams/page/BUF/buffalo-bills",
                "http://www.cbssports.com/nfl/teams/page/MIA/miami-dolphins",
                "http://www.cbssports.com/nfl/teams/page/NE/new-england-patriots",
                "http://www.cbssports.com/nfl/teams/page/NYJ/new-york-jets",
                "http://www.cbssports.com/nfl/teams/page/BAL/baltimore-ravens"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"gridContainer\"]/div/div[1]/div[1]/div/div[3]/table/tbody/tr[2]/td[2]",
                "//*[@id=\"gridContainer\"]/div/div[1]/div[1]/div/div[3]/table/tbody/tr[2]/td[2]",
                "//*[@id=\"gridContainer\"]/div/div[1]/div[1]/div/div[3]/table/tbody/tr[2]/td[2]",
                "//*[@id=\"gridContainer\"]/div/div[1]/div[1]/div/div[3]/table/tbody/tr[2]/td[2]",
                "//*[@id=\"gridContainer\"]/div/div[1]/div[1]/div/div[3]/table/tbody/tr[2]/td[2]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1NFL_teamranking_cbss_xpath", inputData, xpath, "NFL teams to rankings"));

        }

        [Test, Timeout(120000)]
        public void NFL_teamranking_nfl_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Buffalo Bills (BUF)", "Orchard Park, NY", "Ralph WIlson Stadium" },
            new List<string> () { "Miami Dolphins (MIA)", "Miami Gardens, FL", "Sun Life Stadium" },
            new List<string> () { "New England Patriots (NE)", "Foxborough, MA" , "Gillette Stadium" },
            new List<string> () { "New York Jets (NYJ)", "East Rutherford, NJ", "MetLife Stadium[B]" },
            new List<string> () { "Baltimore Ravens (BAL)", "Baltimore, MD" , "M&T Bank Stadium" }
            };


            List<string> searchQuery = new List<string>() {
                "buffalo bills",
                "miami dolphins",
                "new england patriots",
                "new york jets",
                "baltimore ravens"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.nfl.com/teams/buffalobills/profile?team=BUF",
                "http://www.nfl.com/teams/miamidolphins/profile?team=MIA",
                "http://www.nfl.com/teams/newenglandpatriots/profile?team=NE",
                "http://www.nfl.com/teams/newyorkjets/profile?team=NYJ",
                "http://www.nfl.com/teams/baltimoreravens/profile?team=BAL"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"team-quick-stats-1\"]/div/div[1]/div[2]/text()",
                "//*[@id=\"team-quick-stats-1\"]/div/div[1]/div[2]/text()",
                "//*[@id=\"team-quick-stats-1\"]/div/div[1]/div[2]/text()",
                "//*[@id=\"team-quick-stats-1\"]/div/div[1]/div[2]/text()",
                "//*[@id=\"team-quick-stats-1\"]/div/div[1]/div[2]/text()",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1NFL_teamranking_nfl_xpath", inputData, xpath, "NFL teams to rankings"));
        }

        #endregion

        #region atp ranking

        [Test, Timeout(120000)]
        public void atp_ranking_atpworldtour_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Novak Djokovic" },
            new List<string> () { "Roger Federer" },
            new List<string> () { "Andy Murray" },
            new List<string> () { "Stan Wawrinka" },
            new List<string> () { "Tomas Berdych" }
            };


            List<string> searchQuery = new List<string>() {
                "Novak Djokovic ranking",
                "Roger Federer ranking",
                "Andy Murray ranking",
                "Stan Wawrinka ranking",
                "Tomas Berdych ranking"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.atpworldtour.com/en/players/novak-djokovic/d643/overview",
                "http://www.atpworldtour.com/en/players/roger-federer/f324/overview",
                "http://www.atpworldtour.com/en/players/andy-murray/mc10/overview",
                "http://www.atpworldtour.com/en/players/stan-wawrinka/w367/overview",
                "http://www.atpworldtour.com/en/players/tomas-berdych/ba47/overview"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"playerProfileHero\"]/div[2]/div[1]/div/div[3]/div[1]/div[2]",
                "//*[@id=\"playerProfileHero\"]/div[2]/div[1]/div/div[3]/div[1]/div[2]",
                "//*[@id=\"playerProfileHero\"]/div[2]/div[1]/div/div[3]/div[1]/div[2]",
                "//*[@id=\"playerProfileHero\"]/div[2]/div[1]/div/div[3]/div[1]/div[2]",
                "//*[@id=\"playerProfileHero\"]/div[2]/div[1]/div/div[3]/div[1]/div[2]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1atp_ranking_atpworldtour_xpath", inputData, xpath, "ATP players to rankings"));

        }

        [Test, Timeout(120000)]
        public void atp_data_dependent()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Novak Djokovic", "2016", "http://www.espn.com/tennis/player/_/id/296/novak-djokovic", },
                new List<string>() {"Roger Federer", "2009", "http://www.espn.com/tennis/player/_/id/425/roger-federer", },
                new List<string>() {"Andy Murray", "2012", "http://www.espn.com/tennis/player/_/id/235/andy-murray", },
                new List<string>() {"Stan Wawrinka", "2016", "http://www.espn.com/tennis/player/_/id/264/stan-wawrinka", },
                new List<string>() {"Tomas Berdych", "2011", "http://www.espn.com/tennis/player/_/id/363/tomas-berdych", },
                new List<string>() {"Kei Nishikori", "2016", "http://www.espn.com/tennis/player/_/id/1035/kei-nishikori", },
                new List<string>() {"Rafael Nadal", "2015", "http://www.espn.com/tennis/player/_/id/261/rafael-nadal", },
                new List<string>() {"David Ferrer", "2013", "http://www.espn.com/tennis/player/_/id/346/david-ferrer", },
                new List<string>() {"Milos Raonic", "2016", "http://www.espn.com/tennis/player/_/id/1333/milos-raonic", },
                new List<string>() {"Gilles Simon", "2013", "http://www.espn.com/tennis/player/_/id/302/gilles-simon", },
                new List<string>() {"Richard Gasquet", "2016", "http://www.espn.com/tennis/player/_/id/310/richard-gasquet", },
                new List<string>() {"Kevin Anderson", "2015", "http://www.espn.com/tennis/player/_/id/1068/kevin-anderson", },
                new List<string>() {"John Isner", "2014", "http://www.espn.com/tennis/player/_/id/1023/john-isner", },
                new List<string>() {"Marin Cilic", "2015", "http://www.espn.com/tennis/player/_/id/464/marin-cilic", },
                new List<string>() {"David Goffin", "2016", "http://www.espn.com/tennis/player/_/id/1360/david-goffin", },
                new List<string>() {"Feliciano Lopez", "2011", "http://www.espn.com/tennis/player/_/id/426/feliciano-lopez", },
                new List<string>() {"Jo-Wilfried Tsonga", "2014", "http://www.espn.com/tennis/player/_/id/435/jo-wilfried-tsonga", },
                new List<string>() {"Ivo Karlovic", "2015", "http://www.espn.com/tennis/player/_/id/233/ivo-karlovic", },
                new List<string>() {"Grigor Dimitrov", "2016", "http://www.espn.com/tennis/player/_/id/1287/grigor-dimitrov", },
                new List<string>() {"Bernard Tomic", "2011", "http://www.espn.com/tennis/player/_/id/1317/bernard-tomic", },
            };
            List<string> output = new List<string>() {
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2016\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2009\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2012\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2016\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2011\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2016\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2015\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2013\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2016\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2013\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2016\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2015\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2014\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2015\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2016\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2011\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2014\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2015\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2016\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
                "//self::div[count(preceding-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::div[count(following-sibling::node() ) = 0]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::td[count(preceding-sibling::node() ) = 0]]/child::text()[normalize-space(self::text()) = \"2011\"]][preceding-sibling::node()[1][self::td]/child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3atp_data_dependent", inputData, output, "ATP players to rankings based on year"));
        }

        [Test, Timeout(120000)]
        public void atp_ranking_wiki_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Novak Djokovic" },
            new List<string> () { "Roger Federer" },
            new List<string> () { "Andy Murray" },
            new List<string> () { "Stan Wawrinka" },
            new List<string> () { "Tomas Berdych" }
            };


            List<string> searchQuery = new List<string>() {
                "Novak Djokovic ranking",
                "Roger Federer ranking",
                "Andy Murray ranking",
                "Stan Wawrinka ranking",
                "Tomas Berdych ranking"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "https://en.wikipedia.org/wiki/Novak_Djokovic",
                "https://en.wikipedia.org/wiki/Roger_Federer",
                "https://en.wikipedia.org/wiki/Andy_Murray",
                "https://en.wikipedia.org/wiki/Stan_Wawrinka",
                "https://en.wikipedia.org/wiki/Tomas_Berdych"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"mw-content-text\"]/table[1]/tr[14]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[12]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[14]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[13]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[12]/td",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2atp_ranking_wiki_xpath", inputData, xpath, "ATP players to rankings"));

        }

        [Test, Timeout(120000)]
        public void atp_ranking_wiki_age_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Novak Djokovic" },
            new List<string> () { "Roger Federer" },
            new List<string> () { "Andy Murray" },
            new List<string> () { "Stan Wawrinka" },
            new List<string> () { "Tomas Berdych" }
            };


            List<string> searchQuery = new List<string>() {
                "Novak Djokovic ranking",
                "Roger Federer ranking",
                "Andy Murray ranking",
                "Stan Wawrinka ranking",
                "Tomas Berdych ranking"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "https://en.wikipedia.org/wiki/Novak_Djokovic",
                "https://en.wikipedia.org/wiki/Roger_Federer",
                "https://en.wikipedia.org/wiki/Andy_Murray",
                "https://en.wikipedia.org/wiki/Stan_Wawrinka",
                "https://en.wikipedia.org/wiki/Tomas_Berdych"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"mw-content-text\"]/table[1]/tr[5]/td/span[2]",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[4]/td/span[2]",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[5]/td/span[2]",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[5]/td/span[2]",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[4]/td/span[2]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2atp_ranking_wiki_age_xpath", inputData, xpath, "ATP players to ages"));

        }
        [Test, Timeout(120000)]
        public void atp_ranking_wiki_country_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Novak Djokovic" },
            new List<string> () { "Roger Federer" },
            new List<string> () { "Andy Murray" },
            new List<string> () { "Stan Wawrinka" },
            new List<string> () { "Tomas Berdych" }
            };


            List<string> searchQuery = new List<string>() {
                "Novak Djokovic ranking",
                "Roger Federer ranking",
                "Andy Murray ranking",
                "Stan Wawrinka ranking",
                "Tomas Berdych ranking"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "https://en.wikipedia.org/wiki/Novak_Djokovic",
                "https://en.wikipedia.org/wiki/Roger_Federer",
                "https://en.wikipedia.org/wiki/Andy_Murray",
                "https://en.wikipedia.org/wiki/Stan_Wawrinka",
                "https://en.wikipedia.org/wiki/Tomas_Berdych"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"mw-content-text\"]/table[1]/tr[3]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[2]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[3]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[3]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[2]/td",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2atp_ranking_wiki_country_xpath", inputData, xpath, "ATP players to countries"));

        }

        [Test, Timeout(120000)]
        public void atp_ranking_tennis_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Novak Djokovic" },
            new List<string> () { "Roger Federer" },
            new List<string> () { "Andy Murray" },
            new List<string> () { "Stan Wawrinka" },
            new List<string> () { "Tomas Berdych" }
            };


            List<string> searchQuery = new List<string>() {
                "Novak Djokovic ranking",
                "Roger Federer ranking",
                "Andy Murray ranking",
                "Stan Wawrinka ranking",
                "Tomas Berdych ranking"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.tennis.com/player/532/novak-djokovic/",
                "http://www.tennis.com/player/376/roger-federer/",
                "http://www.tennis.com/player/569/andy-murray/",
                "http://www.tennis.com/player/506/stanislas-wawrinka/",
                "http://www.tennis.com/player/511/tomas-berdych/"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "/html/body/section/div[1]/div[1]/div[1]/div[3]/h6/span",
                "/html/body/section/div[1]/div[1]/div[1]/div[3]/h6/span",
                "/html/body/section/div[1]/div[1]/div[1]/div[3]/h6/span",
                "/html/body/section/div[1]/div[1]/div[1]/div[3]/h6/span",
                "/html/body/section/div[1]/div[1]/div[1]/div[3]/h6/span",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1atp_ranking_tennis_xpath", inputData, xpath, "ATP players to rankings"));

        }

        [Test, Timeout(120000)]
        public void atp_ranking_espn_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Novak Djokovic" },
            new List<string> () { "Roger Federer" },
            new List<string> () { "Andy Murray" },
            new List<string> () { "Stan Wawrinka" },
            new List<string> () { "Tomas Berdych" }
            };


            List<string> searchQuery = new List<string>() {
                "Novak Djokovic ranking",
                "Roger Federer ranking",
                "Andy Murray ranking",
                "Stan Wawrinka ranking",
                "Tomas Berdych ranking"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://espn.go.com/tennis/player/_/id/296/novak-djokovic",
                "http://espn.go.com/tennis/player/_/id/425/roger-federer",
                "http://espn.go.com/tennis/player/_/id/235/andy-murray",
                "http://espn.go.com/tennis/player/_/id/264/stan-wawrinka",
                "http://espn.go.com/tennis/player/_/id/363/tomas-berdych"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[12]/td[5]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[12]/td[5]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[12]/td[5]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[12]/td[5]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[12]/td[5]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1atp_ranking_espn_xpath", inputData, xpath, "ATP players to rankings"));

        }

        [Test, Timeout(120000)]
        public void atp_ranking_16_espn_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Novak Djokovic", "16145", "novak djokovic", },
                new List<string>() {"Roger Federer", "9420", "roger federer", },
                new List<string>() {"Andy Murray", "8800", "andy murray", },
                new List<string>() {"Stan Wawrinka", "6005", "stan wawrinka", },
                new List<string>() {"Tomas Berdych", "5050", "tomas berdych", },
                new List<string>() {"Kei Nishikori", "5015", "kei nishikori", },
                new List<string>() {"Rafael Nadal", "3770", "rafael nadal", },
                new List<string>() {"David Ferrer", "3695", "david ferrer", },
                new List<string>() {"Milos Raonic", "2790", "milos raonic", },
                new List<string>() {"Gilles Simon", "2560", "gilles simon", },
                new List<string>() {"Richard Gasquet", "2490", "richard gasquet", },
                new List<string>() {"Kevin Anderson", "2430", "kevin anderson", },
                new List<string>() {"John Isner", "2325", "john isner", },
                new List<string>() {"Marin Cilic", "2270", "marin cilic", },
                new List<string>() {"David Goffin", "2050", "david goffin", },
                new List<string>() {"Feliciano Lopez", "1935", "feliciano lopez", },
                new List<string>() {"Jo-Wilfried Tsonga", "1740", "wilfried tsonga", },
                new List<string>() {"Ivo Karlovic", "1620", "ivo karlovic", },
                new List<string>() {"Grigor Dimitrov", "1600", "grigor dimitrov", },
                new List<string>() {"Bernard Tomic", "1575", "bernard tomic", },
            };
            List<string> url = new List<string>() {
                "http://espn.go.com/tennis/player/_/id/296/novak-djokovic",
                "http://espn.go.com/tennis/player/_/id/425/roger-federer",
                "http://espn.go.com/tennis/player/_/id/235/andy-murray",
                "http://espn.go.com/tennis/player/_/id/264/stan-wawrinka",
                "http://espn.go.com/tennis/player/_/id/363/tomas-berdych",
                "http://espn.go.com/tennis/player/_/id/1035/kei-nishikori",
                "http://espn.go.com/tennis/player/_/id/261/rafael-nadal",
                "http://espn.go.com/tennis/player/_/id/346/david-ferrer",
                "http://espn.go.com/tennis/player/_/id/1333/milos-raonic",
                "http://espn.go.com/tennis/player/_/id/302/gilles-simon",
                "http://espn.go.com/tennis/player/_/id/310/richard-gasquet",
                "http://espn.go.com/tennis/player/_/id/1068/kevin-anderson",
                "http://espn.go.com/tennis/player/_/id/1023/john-isner",
                "http://espn.go.com/tennis/player/_/id/464/marin-cilic",
                "http://espn.go.com/tennis/player/_/id/1360/david-goffin",
                "http://espn.go.com/tennis/player/_/id/426/feliciano-lopez",
                "http://espn.go.com/tennis/player/_/id/435/jo-wilfried-tsonga",
                "http://espn.go.com/tennis/player/_/id/233/ivo-karlovic",
                "http://espn.go.com/tennis/player/_/id/1287/grigor-dimitrov",
                "http://espn.go.com/tennis/player/_/id/1317/bernard-tomic",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
                "//*[@id=\"my-players-table\"]/div[1]/div/div[2]/table/tr[2]/td[3]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1atp_ranking_16_espn_xpath", inputData, xpath, "ATP players to rankings"));

        }

        [Test, Timeout(120000)]
        public void atp_ranking_espn_xpath_full()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Novak Djokovic", "16145", "novak djokovic", },
                new List<string>() {"Roger Federer", "9420", "roger federer", },
                new List<string>() {"Jo-Wilfried Tsonga", "1740", "jo-wilfried tsonga", }, 
                new List<string>() {"Andy Murray", "8800", "andy murray", },
                new List<string>() {"Stan Wawrinka", "6005", "stan wawrinka", },
                new List<string>() {"Tomas Berdych", "5050", "tomas berdych", },
                new List<string>() {"Kei Nishikori", "5015", "kei nishikori", },
                new List<string>() {"Rafael Nadal", "3770", "rafael nadal", },
                new List<string>() {"David Ferrer", "3695", "david ferrer", },
                new List<string>() {"Milos Raonic", "2790", "milos raonic", },
                new List<string>() {"Gilles Simon", "2560", "gilles simon", },
                new List<string>() {"Richard Gasquet", "2490", "richard gasquet", },
                new List<string>() {"Kevin Anderson", "2430", "kevin anderson", },
                new List<string>() {"John Isner", "2325", "john isner", },
                new List<string>() {"Marin Cilic", "2270", "marin cilic", },
                new List<string>() {"David Goffin", "2050", "david goffin", },
                new List<string>() {"Feliciano Lopez", "1935", "feliciano lopez", },
                new List<string>() {"Ivo Karlovic", "1620", "ivo karlovic", },
                new List<string>() {"Grigor Dimitrov", "1600", "grigor dimitrov", },
                new List<string>() {"Bernard Tomic", "1575", "bernard tomic", },
            };
            List<string> url = new List<string>() {
                "http://espn.go.com/tennis/player/_/id/296/novak-djokovic",
                "http://espn.go.com/tennis/player/_/id/425/roger-federer",
                "http://espn.go.com/tennis/player/_/id/435/jo-wilfried-tsonga",
                "http://espn.go.com/tennis/player/_/id/235/andy-murray",
                "http://espn.go.com/tennis/player/_/id/264/stan-wawrinka",
                "http://espn.go.com/tennis/player/_/id/363/tomas-berdych",
                "http://espn.go.com/tennis/player/_/id/1035/kei-nishikori",
                "http://espn.go.com/tennis/player/_/id/261/rafael-nadal",
                "http://espn.go.com/tennis/player/_/id/346/david-ferrer",
                "http://espn.go.com/tennis/player/_/id/1333/milos-raonic",
                "http://espn.go.com/tennis/player/_/id/302/gilles-simon",
                "http://espn.go.com/tennis/player/_/id/310/richard-gasquet",
                "http://espn.go.com/tennis/player/_/id/1068/kevin-anderson",
                "http://espn.go.com/tennis/player/_/id/1023/john-isner",
                "http://espn.go.com/tennis/player/_/id/464/marin-cilic",
                "http://espn.go.com/tennis/player/_/id/1360/david-goffin",
                "http://espn.go.com/tennis/player/_/id/426/feliciano-lopez",
                "http://espn.go.com/tennis/player/_/id/233/ivo-karlovic",
                "http://espn.go.com/tennis/player/_/id/1287/grigor-dimitrov",
                "http://espn.go.com/tennis/player/_/id/1317/bernard-tomic",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>()
            {
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",
                "//*[@id=\"content\"]/div[3]/div[2]/div[3]/ul[2]/li[1]",

            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1atp_ranking_espn_xpath_full", inputData, xpath, "ATP players to rankings"));

        }

        [Test, Timeout(120000)]
        public void atp_twitter_tweets()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Novak Djokovic", "djokernole", "Novak Djokovic twitter", "https://twitter.com/djokernole", },
                new List<string>() {"Roger Federer", "RogerFederer", "Roger Federer twitter", "https://twitter.com/RogerFederer", },
                new List<string>() {"Andy Murray", "andy_murray", "Andy Murray twitter", "https://twitter.com/andy_murray", },
                new List<string>() {"Stan Wawrinka", "stanwawrinka", "Stan Wawrinka twitter", "https://twitter.com/stanwawrinka", },
                new List<string>() {"Tomas Berdych", "TomasBerdych", "Tomas Berdych twitter", "https://twitter.com/TomasBerdych", },
                new List<string>() {"Kei Nishikori", "KeiNishikori", "Kei Nishikori twitter", "https://twitter.com/KeiNishikori", },
                new List<string>() {"Rafael Nadal", "rafaelnadal", "Rafael Nadal twitter", "https://twitter.com/rafaelnadal", },
                new List<string>() {"David Ferrer", "DavidFerrer87", "David Ferrer twitter", "https://twitter.com/DavidFerrer87", },
                new List<string>() {"Milos Raonic", "MilosRaonic", "Milos Raonic twitter", "https://twitter.com/MilosRaonic", },
                new List<string>() {"Gilles Simon", "GillesSimon84", "Gilles Simon twitter", "https://twitter.com/GillesSimon84", },
                new List<string>() {"Richard Gasquet", "richardgasquet1", "Richard Gasquet twitter", "https://twitter.com/richardgasquet1", },
                new List<string>() {"Kevin Anderson", "kevinanderson18", "Kevin Anderson twitter", "https://twitter.com/kevinanderson18", },
                new List<string>() {"John Isner", "johnisner", "John Isner twitter", "https://twitter.com/johnisner", },
                new List<string>() {"Marin Cilic", "cilic_marin", "Marin Cilic twitter", "https://twitter.com/cilic_marin", },
                new List<string>() {"David Goffin", "David__Goffin", "David Goffin twitter", "https://twitter.com/David__Goffin", },
                new List<string>() {"Feliciano Lopez", "feliciano_lopez", "Feliciano Lopez twitter", "https://twitter.com/feliciano_lopez", },
                new List<string>() {"Jo-Wilfried Tsonga", "tsonga7", "Wilfried Tsonga twitter", "https://twitter.com/tsonga7", },
                new List<string>() {"Ivo Karlovic", "ivokarlovic", "Ivo Karlovic twitter", "https://twitter.com/ivokarlovic", },
                new List<string>() {"Grigor Dimitrov", "grigordimitrov", "Grigor Dimitrov twitter", "https://twitter.com/grigordimitrov", },
                new List<string>() {"Bernard Tomic", "BernardTomicFC", "Bernard Tomic twitter", "https://twitter.com/BernardTomicFC", },
            };
            List<string> output = new List<string>() {
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
                "//self::div/child::div/child::ul/child::li/child::a/child::span[child::text()[count(preceding-sibling::node() ) = 0][count(following-sibling::node() ) = 0]][preceding-sibling::node()[1][self::text()]][preceding-sibling::node()[2][self::span]/child::text()[normalize-space(self::text()) = \"Tweets\"]]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2atp_twitter_tweets", inputData, output, "ATP players to number of tweets"));
        }

        [Test, Timeout(120000)]
        public void atp_twitter_latest_tweet()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Novak Djokovic", "djokernole", "Novak Djokovic twitter", "https://twitter.com/djokernole", },
                new List<string>() {"Roger Federer", "RogerFederer", "Roger Federer twitter", "https://twitter.com/RogerFederer", },
                new List<string>() {"Andy Murray", "andy_murray", "Andy Murray twitter", "https://twitter.com/andy_murray", },
                new List<string>() {"Stan Wawrinka", "stanwawrinka", "Stan Wawrinka twitter", "https://twitter.com/stanwawrinka", },
                new List<string>() {"Tomas Berdych", "TomasBerdych", "Tomas Berdych twitter", "https://twitter.com/TomasBerdych", },
            };
            List<string> output = new List<string>() {
                "//*[@id=\"stream-items-id\"]/li[1]/div",///div[2]/div[2]/p",
                "//*[@id=\"stream-items-id\"]/li[1]/div",///div[2]/div[2]/p",
                "//*[@id=\"stream-items-id\"]/li[1]/div",///div[2]/div[2]/p",
                "//*[@id=\"stream-items-id\"]/li[1]/div",///div[2]/div[2]/p",
                "//*[@id=\"stream-items-id\"]/li[1]/div",///div[2]/div[2]/p",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1atp_twitter_latest_tweet", inputData, output, "ATP players to latest tweet"));
        }
        #endregion

        #region video

        [Test, Timeout(120000)]
        public void video_views_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Gangnam Style" },
            new List<string> () { "See You Again" },
            new List<string> () { "Uptown Funk" },
            new List<string> () { "Blank Space" },
            new List<string> () { "Sorry" }
            };


            List<string> searchQuery = new List<string>() {
                "Gangnam Style video",
                "See you again video",
                "Uptown Funk video",
                "Blank Space video",
                "Sorry video"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.youtube.com/watch?v=9bZkp7q19f0",
                "http://www.youtube.com/watch?v=RgKAFK5djSk",
                "http://www.youtube.com/watch?v=OPf0YbXqDm0",
                "http://www.youtube.com/watch?v=e-ORhEE9VVg",
                "http://www.youtube.com/watch?v=fRh_vgS2dFE"
            };


            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>() {
                "//*[@id=\"watch7-views-info\"]/div[1]",
                "//*[@id=\"watch7-views-info\"]/div[1]",
                "//*[@id=\"watch7-views-info\"]/div[1]",
                "//*[@id=\"watch7-views-info\"]/div[1]",
                "//*[@id=\"watch7-views-info\"]/div[1]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1video_views_xpath", inputData, xpath, "videos to number of youtube views"));

        }

        [Test, Timeout(120000)]
        public void video_likes_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Gangnam Style" },
            new List<string> () { "See You Again" },
            new List<string> () { "Uptown Funk" },
            new List<string> () { "Blank Space" },
            new List<string> () { "Sorry" }
            };


            List<string> searchQuery = new List<string>() {
                "Gangnam Style video",
                "See you again video",
                "Uptown Funk video",
                "Blank Space video",
                "Sorry video"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.youtube.com/watch?v=9bZkp7q19f0",
                "http://www.youtube.com/watch?v=RgKAFK5djSk",
                "http://www.youtube.com/watch?v=OPf0YbXqDm0",
                "http://www.youtube.com/watch?v=e-ORhEE9VVg",
                "http://www.youtube.com/watch?v=fRh_vgS2dFE"
            };


            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>() {
                "//*[@id=\"watch8-sentiment-actions\"]/span/span[1]/button/span",
                "//*[@id=\"watch8-sentiment-actions\"]/span/span[1]/button/span",
                "//*[@id=\"watch8-sentiment-actions\"]/span/span[1]/button/span",
                "//*[@id=\"watch8-sentiment-actions\"]/span/span[1]/button/span",
                "//*[@id=\"watch8-sentiment-actions\"]/span/span[1]/button/span",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1video_likes_xpath", inputData, xpath, "videos to number of likes"));

        }

        [Test, Timeout(120000)]
        public void video_publish_date_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Gangnam Style" },
            new List<string> () { "See You Again" },
            new List<string> () { "Uptown Funk" },
            new List<string> () { "Blank Space" },
            new List<string> () { "Sorry" }
            };


            List<string> searchQuery = new List<string>() {
                "Gangnam Style video",
                "See you again video",
                "Uptown Funk video",
                "Blank Space video",
                "Sorry video"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> url = new List<string>() {
                "http://www.youtube.com/watch?v=9bZkp7q19f0",
                "http://www.youtube.com/watch?v=RgKAFK5djSk",
                "http://www.youtube.com/watch?v=OPf0YbXqDm0",
                "http://www.youtube.com/watch?v=e-ORhEE9VVg",
                "http://www.youtube.com/watch?v=fRh_vgS2dFE"
            };


            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }

            List<string> xpath = new List<string>() {
                "//*[@id=\"watch-uploader-info\"]/strong",
                "//*[@id=\"watch-uploader-info\"]/strong",
                "//*[@id=\"watch-uploader-info\"]/strong",
                "//*[@id=\"watch-uploader-info\"]/strong",
                "//*[@id=\"watch-uploader-info\"]/strong",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1video_publish_date_xpath", inputData, xpath, "videos to publish date"));

        }

        #endregion

        #region flights

        [Test, Timeout(120000)]
        public void flights_travel_time_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"boston", "seattle", "boston to seattle flight", },
                new List<string>() {"seattle", "san francisco", "seattle to san francisco flight", },
                new List<string>() {"new york", "seattle", "new york to seattle flight", },
                new List<string>() {"los angeles", "san francisco", "los angeles to san francisco flight", },
                new List<string>() {"san francisco", "boston", "san francisco to boston flight", },
            };
            List<string> url = new List<string>() {
                "http://www.travelmath.com/flying-time/from/Boston,+MA/to/Seattle,+WA",
                "http://www.travelmath.com/flying-time/from/Seattle,+WA/to/San+Francisco,+CA",
                "http://www.travelmath.com/flying-time/from/New+York,+NY/to/Seattle,+WA",
                "http://www.travelmath.com/flying-time/from/Los+Angeles,+CA/to/San+Francisco,+CA",
                "http://www.travelmath.com/flying-time/from/San+Francisco,+CA/to/Boston,+MA",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(url[i]);
            }
            List<string> output = new List<string>() {
                "//*[@id=\"flyingtime\"]",
                "//*[@id=\"flyingtime\"]",
                "//*[@id=\"flyingtime\"]",
                "//*[@id=\"flyingtime\"]",
                "//*[@id=\"flyingtime\"]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1flights_travel_time", inputData, output, "Travel time between two cities"));
        }

        [Test, Timeout(120000)]
        public void flights_cheap_flights()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"boston", "seattle", "boston to seattle flights", },
                new List<string>() {"seattle", "san francisco", "seattle to san francisco flights", },
                new List<string>() {"new york", "seattle", "new york to seattle flights", },
                new List<string>() {"los angeles", "san francisco", "los angeles to san francisco flights", },
                new List<string>() {"san francisco", "boston", "san francisco to boston flights", },
            };
            List<string> urls = new List<string>() {
                "http://www.cheapflights.com/flights-to-seattle/boston/",
                "http://www.cheapflights.com/flights-to-san-francisco/seattle/",
                "http://www.cheapflights.com/flights-to-seattle/new-york/",
                "http://www.cheapflights.com/flights-to-san-francisco/los-angeles/",
                "http://www.cheapflights.com/flights-to-boston/san-francisco/",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> xpath = new List<string>() {
                "//*[@id=\"flight-deals-grids\"]/div/div[1]/div[4]",///div[1]/div[6]/a/span[1]",
                "//*[@id=\"flight-deals-grids\"]/div/div[1]/div[4]",///div[1]/div[6]/a/span[1]",
                "//*[@id=\"flight-deals-grids\"]/div/div[1]/div[4]",///div[1]/div[6]/a/span[1]",
                "//*[@id=\"flight-deals-grids\"]/div/div[1]/div[4]",///div[1]/div[6]/a/span[1]",
                "//*[@id=\"flight-deals-grids\"]/div/div[1]/div[4]",///div[1]/div[6]/a/span[1]",

            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1flights_cheap_flights", inputData, xpath, "Flight fares between two cities"));
        }

        [Test, Timeout(120000)]
        public void flights_fare_compare()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"boston", "seattle", "boston to seattle flights", },
                new List<string>() {"seattle", "san francisco", "seattle to san francisco flights", },
                new List<string>() {"new york", "seattle", "new york to seattle flights", },
                new List<string>() {"los angeles", "san francisco", "los angeles to san francisco flights", },
                new List<string>() {"san francisco", "boston", "san francisco to boston flights", },
            };
            List<string> urls = new List<string>() {
                "http://www.farecompare.com/flights/Boston-BOS/Seattle-SEA/market.html",
                "http://www.farecompare.com/flights/Seattle-SEA/San_Francisco-SFO/market.html",
                "http://www.farecompare.com/flights/New_York-NYC/Seattle-SEA/market.html",
                "http://www.farecompare.com/flights/Los_Angeles-LAX/San_Francisco-SFO/market.html",
                "http://www.farecompare.com/flights/San_Francisco-SFO/Boston-BOS/market.html",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"contentBody\"]/div[2]/div[1]/div/div[2]/div[2]/div[1]/div[2]/div[1]/span",
                "//*[@id=\"contentBody\"]/div[2]/div[2]/div/div[2]/div[2]/div[1]/div[2]/div[1]/span",
                "//*[@id=\"contentBody\"]/div[2]/div[1]/div/div[2]/div[2]/div[1]/div[2]/div[1]/span",
                "//*[@id=\"contentBody\"]/div[2]/div[1]/div/div[2]/div[2]/div[1]/div[2]/div[1]/span",
                "//*[@id=\"contentBody\"]/div[2]/div[1]/div/div[2]/div[2]/div[1]/div[2]/div[1]/span",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1flights_fare_compare", inputData, output, "Flight fares between two cities"));
        }

        [Test, Timeout(120000)]
        public void flights_fare_compare1()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"boston", "seattle", "boston to seattle flights", },
                new List<string>() {"seattle", "san francisco", "seattle to san francisco flights", },
                new List<string>() {"new york", "seattle", "new york to seattle flights", },
                new List<string>() {"los angeles", "san francisco", "los angeles to san francisco flights", },
                new List<string>() {"san francisco", "boston", "san francisco to boston flights", },
            };
            List<string> urls = new List<string>() {
                "http://www.farecompare.com/flights/Boston-BOS/Seattle-SEA/market.html",
                "http://www.farecompare.com/flights/Seattle-SEA/San_Francisco-SFO/market.html",
                "http://www.farecompare.com/flights/New_York-NYC/Seattle-SEA/market.html",
                "http://www.farecompare.com/flights/Los_Angeles-LAX/San_Francisco-SFO/market.html",
                "http://www.farecompare.com/flights/San_Francisco-SFO/Boston-BOS/market.html",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"contentBody\"]/div[2]/div[5]/div/div[2]/table/thead/tr/th[3]",
                "//*[@id=\"contentBody\"]/div[2]/div[6]/div/div[2]/table/thead/tr/th[3]",
                "//*[@id=\"contentBody\"]/div[2]/div[5]/div/div[2]/table/thead/tr/th[1]",
                "//*[@id=\"contentBody\"]/div[2]/div[5]/div/div[2]/table/thead/tr/th[3]",
                "//*[@id=\"contentBody\"]/div[2]/div[5]/div/div[2]/table/thead/tr/th[2]",

            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2flights_fare_compare1", inputData, output, "Flight fares between two cities"));
        }


        [Test, Timeout(120000)]
        public void flights_fare_compare2()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"boston", "seattle", "boston to seattle flights", "Alaska airlines" },
                new List<string>() {"seattle", "san francisco", "seattle to san francisco flights", "JetBlue airlines" },
                new List<string>() {"new york", "seattle", "new york to seattle flights", "American airlines" },
                new List<string>() {"los angeles", "san francisco", "los angeles to san francisco flights", "United airlines" },
                new List<string>() {"san francisco", "boston", "san francisco to boston flights", "Virgin America airlines"},
            };
            List<string> urls = new List<string>() {
                "http://www.farecompare.com/flights/Boston-BOS/Seattle-SEA/market.html",
                "http://www.farecompare.com/flights/Seattle-SEA/San_Francisco-SFO/market.html",
                "http://www.farecompare.com/flights/New_York-NYC/Seattle-SEA/market.html",
                "http://www.farecompare.com/flights/Los_Angeles-LAX/San_Francisco-SFO/market.html",
                "http://www.farecompare.com/flights/San_Francisco-SFO/Boston-BOS/market.html",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"contentBody\"]/div[2]/div[1]/div/div[2]/div[1]/form/ul/li[1]/div/span[1]",
                "//*[@id=\"contentBody\"]/div[2]/div[2]/div/div[2]/div[1]/form/ul/li[4]/div/span[1]",
                "//*[@id=\"contentBody\"]/div[2]/div[1]/div/div[2]/div[1]/form/ul/li[2]/div/span[1]",
                "//*[@id=\"contentBody\"]/div[2]/div[1]/div/div[2]/div[1]/form/ul/li[2]/div/span[1]",
                "//*[@id=\"contentBody\"]/div[2]/div[1]/div/div[2]/div[1]/form/ul/li[6]/div/span[1]",

            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2flights_fare_compare2", inputData, output, "Flight fares between two cities based on airlines"));
        }

        [Test, Timeout(120000)]
        public void flights_cheap_flights2()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"boston", "seattle", "boston to seattle flights", },
                new List<string>() {"seattle", "san francisco", "seattle to san francisco flights", },
                new List<string>() {"new york", "seattle", "new york to seattle flights", },
                new List<string>() {"los angeles", "san francisco", "los angeles to san francisco flights", },
                new List<string>() {"san francisco", "boston", "san francisco to boston flights", },
            };
            List<string> urls = new List<string>() {
                "http://www.cheapflights.com/flights-to-seattle/boston/",
                "http://www.cheapflights.com/flights-to-san-francisco/seattle/",
                "http://www.cheapflights.com/flights-to-seattle/new-york/",
                "http://www.cheapflights.com/flights-to-san-francisco/los-angeles/",
                "http://www.cheapflights.com/flights-to-boston/san-francisco/",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"snippets\"]/div[3]/div[2]/span[3]",
                "//*[@id=\"snippets\"]/div[3]/div[2]/span[3]",
                "//*[@id=\"snippets\"]/div[3]/div[2]/span[3]",
                "//*[@id=\"snippets\"]/div[3]/div[2]/span[3]",
                "//*[@id=\"snippets\"]/div[3]/div[2]/span[3]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1flights_cheap_flights2", inputData, output, "Flight fares between two cities"));
        }

        [Test, Timeout(120000)]
        public void flights_cheapoair()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"boston", "seattle", "boston to seattle flights", },
                new List<string>() {"seattle", "san francisco", "seattle to san francisco flights", },
                new List<string>() {"new york city", "seattle", "new york city to seattle flights", },
                new List<string>() {"los angeles", "san francisco", "los angeles to san francisco flights", },
                new List<string>() {"san francisco", "boston", "san francisco to boston flights", },
            };
            List<string> urls = new List<string>() {
                "https://www.cheapoair.com/flights/cheap-flights-from-boston-to-seattle-bos-sea",
                "https://www.cheapoair.com/flights/cheap-flights-from-seattle-to-san-francisco-sea-sfo",
                "https://www.cheapoair.com/flights/cheap-flights-from-new-york-city-to-seattle-nyc-sea",
                "https://www.cheapoair.com/flights/cheap-flights-from-los-angeles-to-san-francisco-lax-sfo",
                "https://www.cheapoair.com/flights/cheap-flights-from-san-francisco-to-boston-sfo-bos",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"tabTd\"]/aside/section[2]/ul/li[2]/strong",
                "//*[@id=\"tabTd\"]/aside/section[2]/ul/li[2]/strong",
                "//*[@id=\"tabTd\"]/aside/section[2]/ul/li[2]/strong",
                "//*[@id=\"tabTd\"]/aside/section[2]/ul/li[2]/strong",
                "//*[@id=\"tabTd\"]/aside/section[2]/ul/li[2]/strong",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1flights_cheapoair", inputData, output, "Flight fares between two cities"));
        }

        [Test, Timeout(120000)]
        public void flights_cheapoair2()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"boston", "seattle", "boston to seattle flights", },
                new List<string>() {"seattle", "san francisco", "seattle to san francisco flights", },
                new List<string>() {"new york city", "seattle", "new york city to seattle flights", },
                new List<string>() {"los angeles", "san francisco", "los angeles to san francisco flights", },
                new List<string>() {"san francisco", "boston", "san francisco to boston flights", },
            };
            List<string> urls = new List<string>() {
                "https://www.cheapoair.com/flights/cheap-flights-from-boston-to-seattle-bos-sea",
                "https://www.cheapoair.com/flights/cheap-flights-from-seattle-to-san-francisco-sea-sfo",
                "https://www.cheapoair.com/flights/cheap-flights-from-new-york-city-to-seattle-nyc-sea",
                "https://www.cheapoair.com/flights/cheap-flights-from-los-angeles-to-san-francisco-lax-sfo",
                "https://www.cheapoair.com/flights/cheap-flights-from-san-francisco-to-boston-sfo-bos",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"citypairfacts\"]/li[2]/span",
                "//*[@id=\"citypairfacts\"]/li[2]/span",
                "//*[@id=\"citypairfacts\"]/li[2]/span",
                "//*[@id=\"citypairfacts\"]/li[2]/span",
                "//*[@id=\"citypairfacts\"]/li[2]/span",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1flights_cheapoair2", inputData, output, "Flight fares between two cities"));
        }

        #endregion

        #region google scholar

        [Test, Timeout(120000)]
        public void google_scholar_first_paper()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Rishabh Singh"},
                new List<string>() {"Armando Solar-Lezama"},
                new List<string>() {"Emery Berger"},
                new List<string>() {"Sumit Gulwani"},
                new List<string>() {"Swarat Chaudhuri" },
            };
            List<string> urls = new List<string>() {
                "https://scholar.google.com/scholar?q=rishabh+singh",
                "https://scholar.google.com/scholar?q=armando+solar-lezama",
                "https://scholar.google.com/scholar?q=emery+berger",
                "https://scholar.google.com/scholar?q=sumit+gulwani",
                "https://scholar.google.com/scholar?q=swarat+chaudhuri"
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> xpath = new List<string>() {
                "//*[@id=\"gs_ccl_results\"]/div[2]/div[2]/h3/a",
                "//*[@id=\"gs_ccl_results\"]/div[2]/div[2]/h3/a",
                "//*[@id=\"gs_ccl_results\"]/div[2]/div[2]/h3/a",
                "//*[@id=\"gs_ccl_results\"]/div[2]/div[2]/h3/a",
                "//*[@id=\"gs_ccl_results\"]/div[2]/div[2]/h3/a"
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1google_scholar_first_paper", inputData, xpath, "Authors to most cited papers"));
        }

        [Test, Timeout(120000)]
        public void google_scholar_citations()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Rishabh Singh"},
                new List<string>() {"Armando Solar-Lezama"},
                new List<string>() {"Emery Berger"},
                new List<string>() {"Sumit Gulwani"},
                new List<string>() {"Swarat Chaudhuri" },
            };
            List<string> urls = new List<string>() {
                "https://scholar.google.com/scholar?q=rishabh+singh",
                "https://scholar.google.com/scholar?q=armando+solar-lezama",
                "https://scholar.google.com/scholar?q=emery+berger",
                "https://scholar.google.com/scholar?q=sumit+gulwani",
                "https://scholar.google.com/scholar?q=swarat+chaudhuri"
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> xpath = new List<string>() {
                "//*[@id=\"gs_ccl_results\"]/div[2]/div[2]/div[3]/a[1]",
                "//*[@id=\"gs_ccl_results\"]/div[2]/div[2]/div[3]/a[1]",
                "//*[@id=\"gs_ccl_results\"]/div[2]/div[2]/div[3]/a[1]",
                "//*[@id=\"gs_ccl_results\"]/div[2]/div[2]/div[3]/a[1]",
                "//*[@id=\"gs_ccl_results\"]/div[2]/div[2]/div[3]/a[1]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1google_scholar_citations", inputData, xpath, "Authors to highest citations"));
        }

        [Test, Timeout(120000)]
        public void google_scholar_paper()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Rishabh Singh", "Learning semantic string transformations from examples"},
                new List<string>() {"Armando Solar-Lezama", "Sketching concurrent data structures"},
                new List<string>() {"Emery Berger", "Dthreads: efficient deterministic multithreading"},
                new List<string>() {"Sumit Gulwani", "Synthesis of loop-free programs"},
                new List<string>() {"Swarat Chaudhuri", "Proving programs robust", }
            };
            List<string> urls = new List<string>() {
                "https://scholar.google.com/scholar?q=rishabh+singh",
                "https://scholar.google.com/scholar?q=armando+solar-lezama",
                "https://scholar.google.com/scholar?q=emery+berger",
                "https://scholar.google.com/scholar?q=sumit+gulwani",
                "https://scholar.google.com/scholar?q=swarat+chaudhuri"
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> xpath = new List<string>() {
                "//*[@id=\"gs_ccl_results\"]/div[5]/div[2]/div[3]/a[1]",
                "//*[@id=\"gs_ccl_results\"]/div[6]/div[2]/div[3]/a[1]",
                "//*[@id=\"gs_ccl_results\"]/div[6]/div[2]/div[3]/a[1]",
                "//*[@id=\"gs_ccl_results\"]/div[5]/div[2]/div[3]/a[1]",
                "//*[@id=\"gs_ccl_results\"]/div[3]/div[2]/div[3]/a[1]"
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3google_scholar_paper", inputData, xpath, "Authors to citations based on paper title"));
        }

        #endregion

        #region cricket

        [Test, Timeout(120000)]
        public void cricket_same_webpage_total_matches()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Australia"},
                new List<string>() {"England"},
                new List<string>() {"Bangladesh"},
                new List<string>() {"Sri Lanka"},
                new List<string>() {"West Indies"},
            };

            List<string> urls = new List<string>() {
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> xpath = new List<string>() {
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[1]/td[3]",
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[3]/td[3]",
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[2]/td[3]",
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[7]/td[3]",
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[8]/td[3]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3cricket_same_webpage_total_matches", inputData, xpath, "Cricket stats (total matches) for two different teams"));
        }

        [Test, Timeout(120000)]
        public void cricket_same_webpage_won()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Australia"},
                new List<string>() {"England"},
                new List<string>() {"Bangladesh"},
                new List<string>() {"Sri Lanka"},
                new List<string>() {"West Indies"},
            };

            List<string> urls = new List<string>() {
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> xpath = new List<string>() {
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[1]/td[4]",
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[3]/td[4]",
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[2]/td[4]",
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[7]/td[4]",
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[8]/td[4]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3cricket_same_webpage_won", inputData, xpath, "Cricket stats (won) for two different teams"));
        }
        [Test, Timeout(120000)]
        public void cricket_same_webpage_ave()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Australia"},
                new List<string>() {"England"},
                new List<string>() {"Bangladesh"},
                new List<string>() {"Sri Lanka"},
                new List<string>() {"West Indies"},
            };

            List<string> urls = new List<string>() {
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
                "http://stats.espncricinfo.com/ci/engine/team/6.html?class=1;template=results;type=team",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> xpath = new List<string>() {
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[1]/td[9]",
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[3]/td[9]",
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[2]/td[9]",
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[7]/td[9]",
                "//*[@id=\"ciHomeContentlhs\"]/div[3]/table[4]/tbody[1]/tr[8]/td[9]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3cricket_same_webpage_ave", inputData, xpath, "Cricket stats(average) for two different teams"));
        }

        [Test, Timeout(120000)]
        public void cricket_different_dates_results()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Australia", "08-21-2016"},
                new List<string>() {"Pakistan", "08-18-2016"},
                new List<string>() {"South Africa", "08-23-2016"},
                new List<string>() {"Australia", "08-24-2016"},
                new List<string>() {"England", "08-24-2016"},
            };

            List<string> urls = new List<string>() {
                "http://www.espncricinfo.com/ci/engine/match/index.html?date=2016-08-21",
                "http://www.espncricinfo.com/ci/engine/match/index.html?date=2016-08-18",
                "http://www.espncricinfo.com/ci/engine/match/index.html?date=2016-08-23",
                "http://www.espncricinfo.com/ci/engine/match/index.html?date=2016-08-24",
                "http://www.espncricinfo.com/ci/engine/match/index.html?date=2016-08-24",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> xpath = new List<string>() {
                "//*[@id=\"viewport\"]/div[6]/div[2]/main/section/section[5]/section/div[4]/span",
                "//*[@id=\"viewport\"]/div[6]/div[2]/main/section/section[5]/section/div[4]/span",
                "//*[@id=\"viewport\"]/div[6]/div[2]/main/section/section[5]/section/div[4]/span",
                "//*[@id=\"viewport\"]/div[6]/div[2]/main/section/section[5]/section[1]/div[4]/span",
                "//*[@id=\"viewport\"]/div[6]/div[2]/main/section/section[5]/section[2]/div[4]/span",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3cricket_different_dates_results", inputData, xpath, "Cricket results for teams on different dates"));
        }
        #endregion


        #region novels
        [Test, Timeout(120000)]
        public void novels_author_xpath()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"A Tale of Two Cities", "https://en.wikipedia.org/wiki/A_Tale_of_Two_Cities", },
                new List<string>() {"The Lord of the Rings", "https://en.wikipedia.org/wiki/The_Lord_of_the_Rings", },
                new List<string>() {"The Hobbit", "https://en.wikipedia.org/wiki/The_Hobbit", },
                new List<string>() {"Dream of the Red Chamber", "https://en.wikipedia.org/wiki/Dream_of_the_Red_Chamber", },
                new List<string>() {"And Then There Were None", "https://en.wikipedia.org/wiki/And_Then_There_Were_None", },
                new List<string>() {"The Da Vinci Code", "https://en.wikipedia.org/wiki/The_Da_Vinci_Code", },
                new List<string>() {"Harry Potter and the Deathly Hallows", "https://en.wikipedia.org/wiki/Harry_Potter_and_the_Deathly_Hallows", },
            };
            List<string> output = new List<string>() {
                "//self::div[@id = \"mw-content-text\"]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::th]/child::text()[normalize-space(self::text()) = \"Author\"]]/child::a",
                "//self::div[@id = \"mw-content-text\"]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::th]/child::text()[normalize-space(self::text()) = \"Author\"]]/child::a",
                "//self::div[@id = \"mw-content-text\"]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::th]/child::text()[normalize-space(self::text()) = \"Author\"]]/child::a",
                "//self::div[@id = \"mw-content-text\"]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::th]/child::text()[normalize-space(self::text()) = \"Author\"]]/child::a",
                "//self::div[@id = \"mw-content-text\"]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::th]/child::text()[normalize-space(self::text()) = \"Author\"]]/child::a",
                "//self::div[@id = \"mw-content-text\"]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::th]/child::text()[normalize-space(self::text()) = \"Author\"]]/child::a",
                "//self::div[@id = \"mw-content-text\"]/child::table/child::tr/child::td[preceding-sibling::node()[2][self::th]/child::text()[normalize-space(self::text()) = \"Author\"]]/child::a",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2novels_author_url", inputData, output, "Novels to authors"));
        }
        #endregion

        [Test, Timeout(120000)]
        public void weather_historical()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Ana Trujillo                 357 21th Place SE,Redmond,WA,(757) 555-1634,140-37-6064,27171", "November 4 (11/4)", "Redmond weather november 4", },
                new List<string>() {"Antonio Moreno                 515 93th Lane ,Renton,WA,(411) 555-2786,562-87-3127,28581", "October 30 (10/30)", "Renton weather october 30", },
                new List<string>() {"Thomas Hardy                 742 17th Street NE,Seattle,WA,(412) 555-5719,921-29-4931,24607", "September 1 (9/1)", "Seattle weather september 1", },
                new List<string>() {"Hanna Moos                 785 45th Street NE,Puyallup,WA,(376) 555-2462,515-68-1285,29284", "November 1 (11/1)", "Puyallup weather november 1", },
                new List<string>() {"Martin Sommer                 887 86th Place ,Kent,WA,(715) 555-5450,870-91-9824,21536", "October 25 (10/25)", "Kent weather october 29", },
                new List<string>() {"Charlie Gunaja        732 Memorial Drive, Cambridge,MA, (617) 325-2342, 732-322-4321,32654", "November 2 (11/2)", "Cambridge weather november 2", },
            };
            List<string> urls = new List<string>() {
                "http://www.accuweather.com/en/us/redmond-wa/98052/november-weather/341347",
                "http://www.accuweather.com/en/us/renton-wa/98057/october-weather/341348",
                "http://www.accuweather.com/en/us/seattle-wa/98104/september-weather/351409",
                "http://www.accuweather.com/en/us/puyallup-wa/98372/november-weather/341343",
                "http://www.accuweather.com/en/us/kent-wa/98032/october-weather/341295",
                "http://www.accuweather.com/en/us/cambridge-ma/02139/november-weather/329319",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> output = new List<string>()
            {
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[1]/td[6]/div/div/div[2]/div/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[6]/td[1]/div/div/div[2]/div/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[1]/td[5]/div/div/div[2]/div/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[1]/td[3]/div/div/div[2]/div/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[5]/td[3]/div/div/div[2]/div/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[1]/td[4]/div/div/div[2]/div/span[1]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3weather_historical", inputData, output, "Addresses to weather based on the date"));
        }

        [Test, Timeout(120000)]
        public void weather_historical2()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Ana Trujillo                 357 21th Place SE,Redmond,WA,(757) 555-1634,140-37-6064,27171", "November 4 (11/4)", "Redmond weather november 4", },
                new List<string>() {"Antonio Moreno                 515 93th Lane ,Renton,WA,(411) 555-2786,562-87-3127,28581", "October 30 (10/30)", "Renton weather october 30", },
                new List<string>() {"Thomas Hardy                 742 17th Street NE,Seattle,WA,(412) 555-5719,921-29-4931,24607", "September 1 (9/1)", "Seattle weather september 1", },
                new List<string>() {"Hanna Moos                 785 45th Street NE,Puyallup,WA,(376) 555-2462,515-68-1285,29284", "November 1 (11/1)", "Puyallup weather november 1", },
                new List<string>() {"Martin Sommer                 887 86th Place ,Kent,WA,(715) 555-5450,870-91-9824,21536", "October 25 (10/25)", "Kent weather october 29", },
                new List<string>() {"Charlie Gunaja        732 Memorial Drive, Cambridge,MA, (617) 325-2342, 732-322-4321,32654", "November 2 (11/2)", "Cambridge weather november 2", },
            };
            List<string> urls = new List<string>() {
                "http://www.accuweather.com/en/us/redmond-wa/98052/november-weather/341347",
                "http://www.accuweather.com/en/us/renton-wa/98057/october-weather/341348",
                "http://www.accuweather.com/en/us/seattle-wa/98104/september-weather/351409",
                "http://www.accuweather.com/en/us/puyallup-wa/98372/november-weather/341343",
                "http://www.accuweather.com/en/us/kent-wa/98032/october-weather/341295",
                "http://www.accuweather.com/en/us/cambridge-ma/02139/november-weather/329319",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> output = new List<string>()
            {
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[1]/td[6]/div/h3",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[6]/td[1]/div/h3",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[1]/td[5]/div/h3",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[1]/td[3]/div/h3",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[5]/td[3]/div/h3",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[1]/td[4]/div/h3",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3weather_historical2", inputData, output, "Address to weather based on date"));
        }

        [Test, Timeout(120000)]
        public void weather_historical3()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Ana Trujillo                 357 21th Place SE,Redmond,WA,(757) 555-1634,140-37-6064,27171", "November 4 (11/4)",  "Redmond weather november 4", },
                new List<string>() {"Antonio Moreno                 515 93th Lane ,Renton,WA,(411) 555-2786,562-87-3127,28581", "October 30 (10/30)", "Renton weather october 30", },
                new List<string>() {"Thomas Hardy                 742 17th Street NE,Seattle,WA,(412) 555-5719,921-29-4931,24607", "September 1 (9/1)",  "Seattle weather september 1", },
                new List<string>() {"Hanna Moos                 785 45th Street NE,Puyallup,WA,(376) 555-2462,515-68-1285,29284", "November 1 (11/1)",  "Puyallup weather november 1", },
                new List<string>() {"Martin Sommer                 887 86th Place ,Kent,WA,(715) 555-5450,870-91-9824,21536", "October 25 (10/25)",  "Kent weather october 29", },
                new List<string>() {"Charlie Gunaja        732 Memorial Drive, Cambridge,MA, (617) 325-2342, 732-322-4321,32654", "November 2 (11/2)",  "Cambridge weather november 2", },
            };
            List<string> urls = new List<string>() {
                "http://www.accuweather.com/en/us/redmond-wa/98052/november-weather/341347",
                "http://www.accuweather.com/en/us/renton-wa/98057/october-weather/341348",
                "http://www.accuweather.com/en/us/seattle-wa/98104/september-weather/351409",
                "http://www.accuweather.com/en/us/puyallup-wa/98372/november-weather/341343",
                "http://www.accuweather.com/en/us/kent-wa/98032/october-weather/341295",
                "http://www.accuweather.com/en/us/cambridge-ma/02139/november-weather/329319",
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> output = new List<string>()
            {
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[1]/td[6]/div/div/div[3]/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[6]/td[1]/div/div/div[3]/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[1]/td[5]/div/div/div[3]/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[1]/td[3]/div/div/div[3]/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[5]/td[3]/div/div/div[3]/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[1]/td[4]/div/div/div[3]/span[1]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3weather_historical3", inputData, output, "Addresses to weather based on date"));
        }

        [Test, Timeout(120000)]
        public void weather_future()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Ana Trujillo                 357 21th Place SE,Redmond,WA,(757) 555-1634,140-37-6064,27171", "November 12 (11/12)", "Redmond WA weather november 12", },
                new List<string>() {"Antonio Moreno                 515 93th Lane ,Renton,WA,(411) 555-2786,562-87-3127,28581", "December 2 (12/2)", "Renton WA weather december 2", },
                new List<string>() {"Thomas Hardy                 742 17th Street NE,Seattle,WA,(412) 555-5719,921-29-4931,24607", "December 25 (12/25)", "Seattle WA weather december 25", },
                new List<string>() {"Hanna Moos                 785 45th Street NE,Puyallup,WA,(376) 555-2462,515-68-1285,29284", "December 7 (12/7)", "Puyallup WA weather december 7", },
                new List<string>() {"Martin Sommer                 887 86th Place ,Kent,WA,(715) 555-5450,870-91-9824,21536", "November 15 (11/15)", "Kent WA weather november 15", },
                new List<string>() {"Charlie Gunaja        732 Memorial Drive, Cambridge,MA, (617) 325-2342, 732-322-4321,32654", "November 9 (11/9)", "Cambridge MA weather november 9", },
            };
            List<string> urls = new List<string>() {
                "http://www.accuweather.com/en/us/redmond-wa/98052/november-weather/341347",
                "http://www.accuweather.com/en/us/renton-wa/98057/december-weather/341348",
                "http://www.accuweather.com/en/us/seattle-wa/98104/december-weather/351409",
                "http://www.accuweather.com/en/us/puyallup-wa/98372/december-weather/341343",
                "http://www.accuweather.com/en/us/kent-wa/98032/november-weather/341295",
                "http://www.accuweather.com/en/us/cambridge-ma/02139/november-weather/329319",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> output = new List<string>()
            {
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[2]/td[7]/div/div[2]/div[1]/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[1]/td[6]/div/div[2]/div[1]/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[5]/td[1]/div/div[2]/div[1]/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[2]/td[4]/div/div[2]/div[1]/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[3]/td[3]/div/div[2]/div[1]/span[1]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[2]/td[4]/div/div[2]/div[1]/span[1]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3weather_future", inputData, output, "Addresses to weather based on date"));
        }
        [Test, Timeout(120000)]
        public void weather_future1()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Ana Trujillo                 357 21th Place SE,Redmond,WA,(757) 555-1634,140-37-6064,27171", "November 12 (11/12)", "Redmond WA weather november 12", },
                new List<string>() {"Antonio Moreno                 515 93th Lane ,Renton,WA,(411) 555-2786,562-87-3127,28581", "December 2 (12/2)", "Renton WA weather december 2", },
                new List<string>() {"Thomas Hardy                 742 17th Street NE,Seattle,WA,(412) 555-5719,921-29-4931,24607", "December 25 (12/25)", "Seattle WA weather december 25", },
                new List<string>() {"Hanna Moos                 785 45th Street NE,Puyallup,WA,(376) 555-2462,515-68-1285,29284", "December 7 (12/7)", "Puyallup WA weather december 7", },
                new List<string>() {"Martin Sommer                 887 86th Place ,Kent,WA,(715) 555-5450,870-91-9824,21536", "November 15 (11/15)", "Kent WA weather november 15", },
                new List<string>() {"Charlie Gunaja        732 Memorial Drive, Cambridge,MA, (617) 325-2342, 732-322-4321,32654", "November 9 (11/9)", "Cambridge MA weather november 9", },
            };
            List<string> urls = new List<string>() {
                "http://www.accuweather.com/en/us/redmond-wa/98052/november-weather/341347",
                "http://www.accuweather.com/en/us/renton-wa/98057/december-weather/341348",
                "http://www.accuweather.com/en/us/seattle-wa/98104/december-weather/351409",
                "http://www.accuweather.com/en/us/puyallup-wa/98372/december-weather/341343",
                "http://www.accuweather.com/en/us/kent-wa/98032/november-weather/341295",
                "http://www.accuweather.com/en/us/cambridge-ma/02139/november-weather/329319",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> output = new List<string>()
            {
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[2]/td[7]/div/div[2]/div[2]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[1]/td[6]/div/div[2]/div[2]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[5]/td[1]/div/div[2]/div[2]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[2]/td[4]/div/div[2]/div[2]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[3]/td[3]/div/div[2]/div[2]",
                "//*[@id=\"panel-main\"]/div[2]/div/div/table/tbody/tr[2]/td[4]/div/div[2]/div[2]",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3weather_future1", inputData, output, "Addresses to weather based on date"));
        }

        [Test, Timeout(120000)]
        public void dblp()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Armando Solar-Lezama", "Armando Solar-Lezama dblp", },
                new List<string>() {"Sumit Gulwani", "Sumit Gulwani dblp", },
                new List<string>() {"Eran Yahav", "Eran Yahav dblp", },
                new List<string>() {"Emina Torlak", "Emina Torlak dblp", },
                new List<string>() {"Swarat Chaudhuri", "Swarat Chaudhuri dblp", },
            };
            List<string> urls = new List<string>() {
                "http://dblp.uni-trier.de/pers/s/Solar=Lezama:Armando",
                "http://dblp.uni-trier.de/pers/g/Gulwani:Sumit",
                "http://dblp.uni-trier.de/pers/hd/y/Yahav:Eran",
                "http://dblp.uni-trier.de/pers/hd/t/Torlak:Emina",
                "http://dblp.uni-trier.de/pers/c/Chaudhuri:Swarat",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> output = new List<string>()
            {
                "//*[@id=\"journals/cacm/WangZKS16\"]/div[3]/span[5]",
                "//*[@id=\"journals/cacm/Gulwani16\"]/div[3]/span[2]",
                "//*[@id=\"journals/acta/PelegSYY16\"]/div[3]/span[5]",
                "//*[@id=\"conf/asplos/BornholtKLKTW16\"]/div[3]/span[7]",
                "//*[@id=\"conf/aips/WangDCK16\"]/div[3]/span[5]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1dblp", inputData, output, "Authors to latest paper from DBLP"));
        }

        [Test, Timeout(120000)]
        public void dblp2()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Armando Solar-Lezama", "Armando Solar-Lezama dblp", },
                new List<string>() {"Sumit Gulwani", "Sumit Gulwani dblp", },
                new List<string>() {"Eran Yahav", "Eran Yahav dblp", },
                new List<string>() {"Emina Torlak", "Emina Torlak dblp", },
                new List<string>() {"Swarat Chaudhuri", "Swarat Chaudhuri dblp", },
            };
            List<string> urls = new List<string>() {
                "http://dblp.uni-trier.de/pers/s/Solar=Lezama:Armando",
                "http://dblp.uni-trier.de/pers/g/Gulwani:Sumit",
                "http://dblp.uni-trier.de/pers/hd/y/Yahav:Eran",
                "http://dblp.uni-trier.de/pers/hd/t/Torlak:Emina",
                "http://dblp.uni-trier.de/pers/c/Chaudhuri:Swarat",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> output = new List<string>()
            {
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[2]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[1]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[1]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[2]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[3]/button",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2dblp2", inputData, output, "Authors to number of PLDI papers"));
        }
        [Test, Timeout(120000)]
        public void dblp3()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Armando Solar-Lezama", "Armando Solar-Lezama dblp", "PLDI" },
                new List<string>() {"Sumit Gulwani", "Sumit Gulwani dblp", "PLDI"},
                new List<string>() {"Eran Yahav", "Eran Yahav dblp", "PLDI"},
                new List<string>() {"Emina Torlak", "Emina Torlak dblp", "PLDI"},
                new List<string>() {"Swarat Chaudhuri", "Swarat Chaudhuri dblp", "PLDI"},
                new List<string>() {"Armando Solar-Lezama", "Armando Solar-Lezama dblp", "POPL"},
                new List<string>() {"Sumit Gulwani", "Sumit Gulwani dblp", "POPL"},
                new List<string>() {"Eran Yahav", "Eran Yahav dblp", "POPL"},
                new List<string>() {"Emina Torlak", "Emina Torlak dblp", "POPL"},
                new List<string>() {"Swarat Chaudhuri", "Swarat Chaudhuri dblp", "POPL"},
            };
            List<string> urls = new List<string>() {
                "http://dblp.uni-trier.de/pers/s/Solar=Lezama:Armando",
                "http://dblp.uni-trier.de/pers/g/Gulwani:Sumit",
                "http://dblp.uni-trier.de/pers/hd/y/Yahav:Eran",
                "http://dblp.uni-trier.de/pers/hd/t/Torlak:Emina",
                "http://dblp.uni-trier.de/pers/c/Chaudhuri:Swarat",
                "http://dblp.uni-trier.de/pers/s/Solar=Lezama:Armando",
                "http://dblp.uni-trier.de/pers/g/Gulwani:Sumit",
                "http://dblp.uni-trier.de/pers/hd/y/Yahav:Eran",
                "http://dblp.uni-trier.de/pers/hd/t/Torlak:Emina",
                "http://dblp.uni-trier.de/pers/c/Chaudhuri:Swarat",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> output = new List<string>()
            {
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[2]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[1]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[1]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[2]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[3]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[5]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[2]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[6]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[10]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[5]/ul[1]/li[2]/button",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3dblp3", inputData, output, "Authors to number of papers based on conference"));
        }
        [Test, Timeout(120000)]
        public void dblp_coauthor()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Armando Solar-Lezama", "Swarat Chaudhuri", "Armando Solar-Lezama dblp", },
                new List<string>() {"Sumit Gulwani", "Rishabh Singh", "Sumit Gulwani dblp", },
                new List<string>() {"Sumit Gulwani", "Ashish Tiwari", "Sumit Gulwani dblp", },
                new List<string>() {"Eran Yahav", "Sharon Shoham", "Eran Yahav dblp", },
                new List<string>() {"Eran Yahav", "Greta Yorsh", "Eran Yahav dblp", },
                new List<string>() {"Emina Torlak", "Rastislav Bodík", "Emina Torlak dblp", },
                new List<string>() {"Emina Torlak", "Daniel Jackson", "Emina Torlak dblp", },
                new List<string>() {"Swarat Chaudhuri", "Rajeev Alur", "Swarat Chaudhuri dblp", },
                new List<string>() {"Swarat Chaudhuri", "Sumit Gulwani", "Swarat Chaudhuri dblp", },
            };
            List<string> urls = new List<string>() {
                "http://dblp.uni-trier.de/pers/s/Solar=Lezama:Armando",
                "http://dblp.uni-trier.de/pers/g/Gulwani:Sumit",
                "http://dblp.uni-trier.de/pers/g/Gulwani:Sumit",
                "http://dblp.uni-trier.de/pers/hd/y/Yahav:Eran",
                "http://dblp.uni-trier.de/pers/hd/y/Yahav:Eran",
                "http://dblp.uni-trier.de/pers/hd/t/Torlak:Emina",
                "http://dblp.uni-trier.de/pers/hd/t/Torlak:Emina",
                "http://dblp.uni-trier.de/pers/c/Chaudhuri:Swarat",
                "http://dblp.uni-trier.de/pers/c/Chaudhuri:Swarat",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> output = new List<string>()
            {
                "//*[@id=\"authorpage-refine\"]/div/div[4]/ul[1]/li[9]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[4]/ul[1]/li[2]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[4]/ul[1]/li[1]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[4]/ul[1]/li[7]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[4]/ul[1]/li[5]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[4]/ul[1]/li[1]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[4]/ul[1]/li[2]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[4]/ul[1]/li[1]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[4]/ul[1]/li[3]/button",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3dblp_coauthor", inputData, output, "Number of coauthored papers between two authors"));
        }
        [Test, Timeout(120000)]
        public void dblp_highest_coauthor()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Armando Solar-Lezama", "Armando Solar-Lezama dblp", },
                new List<string>() {"Sumit Gulwani", "Sumit Gulwani dblp", },
                new List<string>() {"Eran Yahav", "Eran Yahav dblp", },
                new List<string>() {"Emina Torlak", "Emina Torlak dblp", },
                new List<string>() {"Swarat Chaudhuri", "Swarat Chaudhuri dblp", },
            };
            List<string> urls = new List<string>() {
                "http://dblp.uni-trier.de/pers/s/Solar=Lezama:Armando",
                "http://dblp.uni-trier.de/pers/g/Gulwani:Sumit",
                "http://dblp.uni-trier.de/pers/hd/y/Yahav:Eran",
                "http://dblp.uni-trier.de/pers/hd/t/Torlak:Emina",
                "http://dblp.uni-trier.de/pers/c/Chaudhuri:Swarat",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> output = new List<string>()
            {
                "//*[@id=\"authorpage-refine\"]/div/div[4]/ul[1]/li[1]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[4]/ul[1]/li[1]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[4]/ul[1]/li[1]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[4]/ul[1]/li[1]/button",
                "//*[@id=\"authorpage-refine\"]/div/div[4]/ul[1]/li[1]/button",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1dblp_highest_coauthor", inputData, output, "Authors to most co-authored person"));
        }

        #region real estate



        [Test, Timeout(120000)]
        public void realestate_zillow()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"5002 159th Ct NE, Redmond, WA 98052", },
                new List<string>() {"11749 158th Pl NE, Redmond, WA 98052", },
                new List<string>() {"512 213th St SW, Bothell, WA 98021", },
                new List<string>() {"12806 64th Ave S, Seattle, WA 98178", },
                new List<string>() {"12824 4th Ave S, Burien, WA 98168", },
            };
            List<string> urls = new List<string>() {
                "http://www.zillow.com/homedetails/5002-159th-Ct-NE-Redmond-WA-98052/48731190_zpid/",
                "http://www.zillow.com/homedetails/11749-158th-Pl-NE-Redmond-WA-98052/65222240_zpid/",
                "http://www.zillow.com/homedetails/512-213th-St-SW-Bothell-WA-98021/38563217_zpid/",
                "http://www.zillow.com/homedetails/12806-64th-Ave-S-Seattle-WA-98178/49065655_zpid/",
                "http://www.zillow.com/homedetails/12824-4th-Ave-S-Burien-WA-98168/48734200_zpid/",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> output = new List<string>()
            {
                "//*[@id=\"loan-calculator-container\"]/div[1]/span/span[1]",
                "//*[@id=\"loan-calculator-container\"]/div[1]/span/span[1]",
                "//*[@id=\"loan-calculator-container\"]/div[1]/span/span[1]",
                "//*[@id=\"loan-calculator-container\"]/div[1]/span/span[1]",
                "//*[@id=\"loan-calculator-container\"]/div[1]/span/span[1]",

            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1realestate_zillow", inputData, output, "Real estate properties to sale prices"));
        }

        [Test, Timeout(120000)]
        public void realestate_zillow2()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"5002 159th Ct NE, Redmond, WA 98052", },
                new List<string>() {"11749 158th Pl NE, Redmond, WA 98052", },
                new List<string>() {"512 213th St SW, Bothell, WA 98021", },
                new List<string>() {"12806 64th Ave S, Seattle, WA 98178", },
                new List<string>() {"12824 4th Ave S, Burien, WA 98168", },
            };
            List<string> urls = new List<string>() {
                "http://www.zillow.com/homedetails/5002-159th-Ct-NE-Redmond-WA-98052/48731190_zpid/",
                "http://www.zillow.com/homedetails/11749-158th-Pl-NE-Redmond-WA-98052/65222240_zpid/",
                "http://www.zillow.com/homedetails/512-213th-St-SW-Bothell-WA-98021/38563217_zpid/",
                "http://www.zillow.com/homedetails/12806-64th-Ave-S-Seattle-WA-98178/49065655_zpid/",
                "http://www.zillow.com/homedetails/12824-4th-Ave-S-Burien-WA-98168/48734200_zpid/",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }

            List<string> output = new List<string>()
            {
                "//*[@id=\"hdp-content\"]/div[2]/div/div[1]/header/h3/span[6]",
                "//*[@id=\"hdp-content\"]/div[2]/div[1]/header/h3/span[6]",
                "//*[@id=\"hdp-content\"]/div[2]/div/div[1]/header/h3/span[6]",
                "//*[@id=\"hdp-content\"]/div[3]/div[1]/header/h3/span[6]",
                "//*[@id=\"hdp-content\"]/div[3]/div[1]/header/h3/span[6]",

            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2realestate_zillow2", inputData, output, "Real estate properties to stats"));
        }

        #endregion

        #region novels
        [Test, Timeout(120000)]
        public void novels_goodreads()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"A Tale of Two Cities", },
                new List<string>() {"The Lord of the Rings", },
                new List<string>() {"The Hobbit", },
                new List<string>() {"The Dream of the Red Chamber", },
                new List<string>() {"And Then There Were None", },
                new List<string>() {"The Da Vinci Code", },
                new List<string>() {"The Alchemist", },
                new List<string>() {"Harry Potter and the Deathly Hallows", },
            };
            List<string> urls = new List<string>() {
                "https://www.goodreads.com/book/show/1953.A_Tale_of_Two_Cities",
                "http://www.goodreads.com/book/show/33.The_Lord_of_the_Rings",
                "http://www.goodreads.com/book/show/5907.The_Hobbit",
                "https://www.goodreads.com/book/show/535739.The_Dream_of_the_Red_Chamber",
                "http://www.goodreads.com/book/show/16299.And_Then_There_Were_None",
                "https://www.goodreads.com/book/show/968.The_Da_Vinci_Code",
                "https://www.goodreads.com/book/show/865.The_Alchemist",
                "https://www.goodreads.com/book/show/136251.Harry_Potter_and_the_Deathly_Hallows",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"bookAuthors\"]/span[2]/a[1]/span",
                "//*[@id=\"bookAuthors\"]/span[2]/a/span",
                "//*[@id=\"bookAuthors\"]/span[2]/a/span",
                "//*[@id=\"bookAuthors\"]/span[2]/a[1]/span",
                "//*[@id=\"bookAuthors\"]/span[2]/a/span",
                "//*[@id=\"bookAuthors\"]/span[2]/a/span",
                "//*[@id=\"bookAuthors\"]/span[2]/a[1]/span",
                "//*[@id=\"bookAuthors\"]/span[2]/a[1]/span",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2novels_goodreads", inputData, output, "Novels to authors"));
        }

        [Test, Timeout(120000)]
        public void novels_wiki_2()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"A Tale of Two Cities", },
                new List<string>() {"The Lord of the Rings", },
                new List<string>() {"The Hobbit", },
                new List<string>() {"Dream of the Red Chamber", },
                new List<string>() {"And Then There Were None", },
                new List<string>() {"The Da Vinci Code", },
                new List<string>() {"Harry Potter and the Deathly Hallows", },
            };
            List<string> urls = new List<string>() {
                "https://en.wikipedia.org/wiki/A_Tale_of_Two_Cities",
                "https://en.wikipedia.org/wiki/The_Lord_of_the_Rings",
                "https://en.wikipedia.org/wiki/The_Hobbit",
                "https://en.wikipedia.org/wiki/Dream_of_the_Red_Chamber",
                "https://en.wikipedia.org/wiki/And_Then_There_Were_None",
                "https://en.wikipedia.org/wiki/The_Da_Vinci_Code",
                "https://en.wikipedia.org/wiki/Harry_Potter_and_the_Deathly_Hallows",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"mw-content-text\"]/table[1]/tr[7]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[6]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[7]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[5]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[6]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[5]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[6]/td",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2novels_wiki_2", inputData, output, "Novels to genre"));
        }
        #endregion

        #region people
        [Test, Timeout(120000)]
        public void microsoft_people_zoominfo()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Patrice Godefroid", "Patrice Godefroid microsoft zoominfo", },
                new List<string>() {"Ben Zorn", "Ben Zorn microsoft zoominfo", },
                new List<string>() {"Tom Ball", "Tom Ball microsoft zoominfo", },
                new List<string>() { "Nikolaj Bj%C3%B8rner", "Nikolaj Bjorner microsoft zoominfo", },
                new List<string>() {"Nikhil Swamy", "Nikhil Swamy microsoft zoominfo", },
            };
            List<string> urls = new List<string>() {
                "http://www.zoominfo.com/p/Patrice-Godefroid/1130704893",
                "http://www.zoominfo.com/p/Ben-Zorn/14114516",
                "http://www.zoominfo.com/p/Tom-Ball/14114519",
                "http://www.zoominfo.com/p/Nikolaj-Bj%C3%B8rner/1176627381",
                "http://www.zoominfo.com/p/Nikhil-Swamy/1302489119",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"profile_main_left\"]/div[1]/div[1]/p[1]/strong",
                "//*[@id=\"profile_main_left\"]/div[1]/div[1]/p[1]/strong",
                "//*[@id=\"profile_main_left\"]/div[1]/div[1]/p[1]/strong",
                "//*[@id=\"profile_main_left\"]/div[1]/div[1]/p[1]/strong",
                "//*[@id=\"profile_main_left\"]/div[1]/div[1]/p[1]/strong",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1microsoft_people_zoominfo", inputData, output, "People to profession"));
        }
        #endregion

        #region airport
        [Test, Timeout(120000)]
        public void airport_code_flightstats()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"BOS", "BOS airport", },
                new List<string>() {"OAK", "OAK airport", },
                new List<string>() {"SFO", "SFO airport", },
                new List<string>() {"SJC", "SJC airport", },
                new List<string>() {"JFK", "JFK airport", },
            };
            List<string> urls = new List<string>() {
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=BOS",
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=OAK",
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=SFO",
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=SJC",
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=JFK",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"mainAreaLeftColumn\"]/div/h2",
                "//*[@id=\"mainAreaLeftColumn\"]/div/h2",
                "//*[@id=\"mainAreaLeftColumn\"]/div/h2",
                "//*[@id=\"mainAreaLeftColumn\"]/div/h2",
                "//*[@id=\"mainAreaLeftColumn\"]/div/h2",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1airport_code_flightstats", inputData, output, "Airport codes to airport names"));
        }

        [Test, Timeout(120000)]
        public void airport_code_flightstats1()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"BOS", "BOS airport", },
                new List<string>() {"OAK", "OAK airport", },
                new List<string>() {"SFO", "SFO airport", },
                new List<string>() {"SJC", "SJC airport", },
                new List<string>() {"JFK", "JFK airport", },
            };
            List<string> urls = new List<string>() {
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=BOS",
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=OAK",
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=SFO",
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=SJC",
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=JFK",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"mainAreaLeftColumn\"]/table/tbody/tr/td[2]/div/div/table/tbody/tr[3]/td[1]/table/tbody/tr[1]/td[2]",
                "//*[@id=\"mainAreaLeftColumn\"]/table/tbody/tr/td[2]/div/div/table/tbody/tr[3]/td[1]/table/tbody/tr[1]/td[2]",
                "//*[@id=\"mainAreaLeftColumn\"]/table/tbody/tr/td[2]/div/div/table/tbody/tr[3]/td[1]/table/tbody/tr[1]/td[2]",
                "//*[@id=\"mainAreaLeftColumn\"]/table/tbody/tr/td[2]/div/div/table/tbody/tr[3]/td[1]/table/tbody/tr[1]/td[2]",
                "//*[@id=\"mainAreaLeftColumn\"]/table/tbody/tr/td[2]/div/div/table/tbody/tr[3]/td[1]/table/tbody/tr[1]/td[2]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1airport_code_flightstats1", inputData, output, "airport code to airport names"));
        }

        [Test, Timeout(120000)]
        public void airport_code_aa()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"BOS", "BOS airport", },
                new List<string>() {"OAK", "OAK airport", },
                new List<string>() {"SFO", "SFO airport", },
                new List<string>() {"SJC", "SJC airport", },
                new List<string>() {"JFK", "JFK airport", },
            };
            List<string> urls = new List<string>() {
                "https://www.aa.com/i18n/travelInformation/destinationInformation/bos-airport.jsp",
                "https://www.aa.com/i18n/travelInformation/destinationInformation/oak-airport.jsp",
                "https://www.aa.com/i18n/travelInformation/destinationInformation/sfo-airport.jsp",
                "https://www.aa.com/i18n/travelInformation/destinationInformation/sjc-airport.jsp",
                "https://www.aa.com/i18n/travelInformation/destinationInformation/jfk-airport.jsp",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"aa-content-frame\"]/section[2]/section[1]/div/div[1]/p[3]",
                "//*[@id=\"aa-content-frame\"]/section[2]/section[1]/div/div[1]/p[3]",
                "//*[@id=\"aa-content-frame\"]/section[2]/section[2]/div/div[1]/p[3]",
                "//*[@id=\"aa-content-frame\"]/section[2]/section[1]/div/div[1]/p[3]",
                "//*[@id=\"aa-content-frame\"]/section[2]/section[2]/div/div[1]/p[3]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2airport_code_aa", inputData, output, "airport code to terminal information"));
        }

        [Test, Timeout(120000)]
        public void airport_code_virginamerica()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"BOS", "BOS airport", },
                new List<string>() {"AUS", "AUS airport", },
                new List<string>() {"SFO", "SFO airport", },
                new List<string>() {"LAX", "LAX airport", },
                new List<string>() {"PDX", "PDX airport", },
            };
            List<string> urls = new List<string>() {
                "https://www.virginamerica.com/cms/fly-with-us/airport-info/boston-bos/",
                "https://www.virginamerica.com/cms/fly-with-us/airport-info/austin-aus/",
                "https://www.virginamerica.com/cms/fly-with-us/airport-info/san-francisco-sfo/",
                "https://www.virginamerica.com/cms/fly-with-us/airport-info/los-angeles-lax/",
                "https://www.virginamerica.com/cms/fly-with-us/airport-info/portland-pdx/",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "/html/body/div[1]/div[2]/div/h1",
                "/html/body/div[1]/div[2]/div/h1",
                "/html/body/div[1]/div[2]/div/h1",
                "/html/body/div[1]/div[2]/div/h1",
                "/html/body/div[1]/div[2]/div/h1",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1airport_code_virginamerica", inputData, output, "airport code to terminal information"));
        }
        #endregion

        #region
        [Test, Timeout(120000)]
        public void nobel_prize()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"2010", "Chemistry", "2010 nobel prize" },
                new List<string>() {"2007", "Physics", "2007 nobel prize"},
                new List<string>() {"2002", "Literature", "2002 nobel prize" },
                new List<string>() {"2011", "Physics", "2011 nobel prize" },
                new List<string>() {"2006", "Chemistry", "2006 nobel prize" },
            };
            List<string> urls = new List<string>() {
                "http://www.nobelprize.org/nobel_prizes/lists/year/?year=2010",
                "http://www.nobelprize.org/nobel_prizes/lists/year/?year=2007",
                "http://www.nobelprize.org/nobel_prizes/lists/year/?year=2002",
                "http://www.nobelprize.org/nobel_prizes/lists/year/?year=2011",
                "http://www.nobelprize.org/nobel_prizes/lists/year/?year=2006",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"nobel-middle-col\"]/div/div/div[4]/h6",
                "//*[@id=\"nobel-middle-col\"]/div/div/div[3]/h6",
                "//*[@id=\"nobel-middle-col\"]/div/div/div[6]/h6",
                "//*[@id=\"nobel-middle-col\"]/div/div/div[3]/h6",
                "//*[@id=\"nobel-middle-col\"]/div/div/div[4]/h6",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3nobel_prize", inputData, output, "Nobel prize for different years based on subject"));
        }

        [Test, Timeout(120000)]
        public void nobel_prize_subject()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"2010", "Chemistry", "2010 nobel prize chemistry" },
                new List<string>() {"2007", "Physics", "2007 nobel prize physics"},
                new List<string>() {"2002", "Literature", "2002 nobel prize literature" },
                new List<string>() {"2011", "Physics", "2011 nobel prize physics" },
                new List<string>() {"2006", "Chemistry", "2006 nobel prize chemistry" },
            };
            List<string> urls = new List<string>() {
                "http://www.nobelprize.org/nobel_prizes/chemistry/laureates/2010/",
                "http://www.nobelprize.org/nobel_prizes/physics/laureates/2007/",
                "http://www.nobelprize.org/nobel_prizes/literature/laureates/2002/",
                "http://www.nobelprize.org/nobel_prizes/physics/laureates/2011/",
                "http://www.nobelprize.org/nobel_prizes/chemistry/laureates/2006/",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"nobel-middle-col\"]/div/div/span/p",
                "//*[@id=\"nobel-middle-col\"]/div/div/span/p",
                "//*[@id=\"nobel-middle-col\"]/div/div/span/p",
                "//*[@id=\"nobel-middle-col\"]/div/div/span/p",
                "//*[@id=\"nobel-middle-col\"]/div/div/span/p",

            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("1nobel_prize_subject", inputData, output, "Nobel prize for different years based on subject"));
        }

        [Test, Timeout(120000)]
        public void nobel_prize_subject_wiki()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"2010", "Chemistry", "2010 nobel prize chemistry" },
                new List<string>() {"2007", "Physics", "2007 nobel prize physics"},
                new List<string>() {"2002", "Literature", "2002 nobel prize literature" },
                new List<string>() {"2011", "Physics", "2011 nobel prize physics" },
                new List<string>() {"2006", "Chemistry", "2006 nobel prize chemistry" },
            };
            List<string> urls = new List<string>() {
                "https://en.wikipedia.org/wiki/List_of_Nobel_laureates_in_Chemistry",
                "https://en.wikipedia.org/wiki/List_of_Nobel_laureates_in_Physics",
                "https://en.wikipedia.org/wiki/List_of_Nobel_laureates_in_Literature",
                "https://en.wikipedia.org/wiki/List_of_Nobel_laureates_in_Physics",
                "https://en.wikipedia.org/wiki/List_of_Nobel_laureates_in_Chemistry",
            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"mw-content-text\"]/table[1]/tr[167]/td[3]",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[187]/td[3]",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[107]/td[3]",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[197]/td[3]",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[159]/td[3]",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("3nobel_prize_subject_wiki", inputData, output, "Nobel prize for different subjects based on year"));
        }
        #endregion

        [Test, Timeout(120000)]
        public void albums_wiki()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"The Joshua Tree", },
                new List<string>() {"Hybrid Theory",  },
                new List<string>() { "Come Away with Me", },
                new List<string>() {"Slippery When Wet",  },
                new List<string>() {"Nevermind", },

            };
            List<string> urls = new List<string>() {
                "https://en.wikipedia.org/wiki/The_Joshua_Tree",
                "https://en.wikipedia.org/wiki/Hybrid_Theory",
                "https://en.wikipedia.org/wiki/Come_Away_with_Me",
                "https://en.wikipedia.org/wiki/Slippery_When_Wet",
                "https://en.wikipedia.org/wiki/Nevermind",

            };
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(urls[i]);
            }
            List<string> output = new List<string>()
            {
                "//*[@id=\"mw-content-text\"]/table[1]/tr[7]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[7]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[7]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[7]/td",
                "//*[@id=\"mw-content-text\"]/table[1]/tr[7]/td",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestXpath("2albums_wiki", inputData, output, "Albums to genre"));
        }

    }
}
