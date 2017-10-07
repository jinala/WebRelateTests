using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using System.Diagnostics;

namespace UrlTests
{

    [TestFixture]
    public class UrlLearningTest
    {
        #region Address

        [Test, Timeout(120000)]
        public void Address_weather_accuweather_url()
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
                "Redmond weather",
                "Renton weather",
                "Seattle weather",
                "Puyallup weather",
                "Redmond weather",
                "Kent weather",
                "Cambridge weather"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> output = new List<string>() {
                "http://www.accuweather.com/en/us/redmond-wa/98052/weather-forecast/341347",
                "http://www.accuweather.com/en/us/renton-wa/98057/weather-forecast/341348",
                "http://www.accuweather.com/en/us/seattle-wa/98104/weather-forecast/351409",
                "http://www.accuweather.com/en/us/puyallup-wa/98372/weather-forecast/341343",
                "http://www.accuweather.com/en/us/redmond-wa/98052/weather-forecast/341347",
                "http://www.accuweather.com/en/us/kent-wa/98032/weather-forecast/341295",
                "http://www.accuweather.com/en/us/cambridge-ma/02139/weather-forecast/329319"
            };


            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("21Address_weather_accuweather_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Address_weather_timeanddate_url()
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

            List<string> output = new List<string>() {
                "http://www.timeanddate.com/weather/usa/redmond",
                "http://www.timeanddate.com/weather/usa/san-francisco",
                "http://www.timeanddate.com/weather/usa/seattle",
                "http://www.timeanddate.com/weather/usa/chicago",
                "http://www.timeanddate.com/weather/usa/redmond",
                "http://www.timeanddate.com/weather/usa/boston",
                "http://www.timeanddate.com/weather/usa/cambridge"
            };


            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("12Address_weather_timeanddate_url", inputData, output));

        }
        [Test, Timeout(120000)]
        public void Address_weather_wunderground_url()
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
                "Redmond weather",
                "Renton weather",
                "Seattle weather",
                "Puyallup weather",
                "Redmond weather",
                "Kent weather",
                "Cambridge weather"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> output = new List<string>() {
                "https://www.wunderground.com/us/wa/redmond",
                "https://www.wunderground.com/us/wa/renton",
                "https://www.wunderground.com/us/wa/seattle",
                "https://www.wunderground.com/us/wa/puyallup",
                "https://www.wunderground.com/us/wa/redmond",
                "https://www.wunderground.com/us/wa/kent",
                "https://www.wunderground.com/us/ma/cambridge"
            };


            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11Address_weather_wunderground_url", inputData, output));
        }

        [Test, Timeout(120000)]
        public void Address_weather_weather_url()
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
                "Redmond weather",
                "Renton weather",
                "Seattle weather",
                "Puyallup weather",
                "Redmond weather",
                "Kent weather",
                "Cambridge weather"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> output = new List<string>() {
                "https://weather.com/weather/today/l/Redmond+WA+98053:4:US#!",
                "https://weather.com/weather/today/l/Renton+WA+98058:4:US#!",
                "https://weather.com/weather/today/l/Seattle+WA+98125:4:US#!",
                "https://weather.com/weather/today/l/Puyallup+WA+98371:4:US#!",
                "https://weather.com/weather/today/l/Redmond+WA+98053:4:US#!",
                "https://weather.com/weather/today/l/Kent+WA+98031:4:US#!",
                "https://weather.com/weather/today/l/Cambridge+MA+02139:4:US#!"
            };


            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("21Address_weather_weather_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Address_population_citydata_url()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Ana Trujillo                 357 21th Place SE,Redmond,Washington,(757) 555-1634,140-37-6064,27171" },
            new List<string> () { "Charlie Gunaja        732 Memorial Drive, Cambridge, Massachusetts, (617) 325-2342, 732-322-4321,32654" },
            new List<string> () { "Antonio Moreno                 515 93th Lane ,Renton,Washington,(411) 555-2786,562-87-3127,28581" },
            new List<string> () { "Thomas Hardy                 742 17th Street NE,Seattle,Washington,(412) 555-5719,921-29-4931,24607" },
            new List<string> () { "Hanna Moos                 785 45th Street NE,Puyallup,Washington,(376) 555-2462,515-68-1285,29284" },
            new List<string> () { "Frederique Citeaux                 308 66th Place ,Redmond,Washington,(689) 555-2770,552-23-2508,21415" },
            new List<string> () { "Martin Sommer                 887 86th Place ,Kent,Washington,(715) 555-5450,870-91-9824,21536" },

            };


            List<string> searchQuery = new List<string>() {
                "Redmond population",
                "Cambridge population",
                "Renton population",
                "Seattle population",
                "Puyallup population",
                "Redmond population",
                "Kent population",

            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> output = new List<string>() {
                "http://www.city-data.com/city/Redmond-Washington.html",
                "http://www.city-data.com/city/Cambridge-Massachusetts.html",
                "http://www.city-data.com/city/Renton-Washington.html",
                "http://www.city-data.com/city/Seattle-Washington.html",
                "http://www.city-data.com/city/Puyallup-Washington.html",
                "http://www.city-data.com/city/Redmond-Washington.html",
                "http://www.city-data.com/city/Kent-Washington.html",

            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11Address_population_citydata_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Address_zipcode_zipcode_url()
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

            List<string> output = new List<string>() {
                "http://zipcode.org/city/WA/REDMOND",
                "http://zipcode.org/city/WA/RENTON",
                "http://zipcode.org/city/WA/SEATTLE",
                "http://zipcode.org/city/WA/PUYALLUP",
                "http://zipcode.org/city/WA/REDMOND",
                "http://zipcode.org/city/WA/KENT",
                "http://zipcode.org/city/MA/CAMBRIDGE"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11Address_zipcode_zipcode_url", inputData, output));

        }

        #endregion

        #region country names

        [Test, Timeout(120000)]
        public void Country_population_worldometers_url_1()
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

            List<string> output = new List<string>() {
                "http://www.worldometers.info/world-population/india-population/",
                "http://www.worldometers.info/world-population/us-population/",
                "http://www.worldometers.info/world-population/south-africa-population/",
                "http://www.worldometers.info/world-population/china-population/",
                "http://www.worldometers.info/world-population/russia-population/",
                "http://www.worldometers.info/world-population/new-zealand-population/"
            };


            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("12Country_population_worldometers_url_1", inputData, output));

        }

        [Test, Timeout(120000)]
        public void City_population_worldpopulationreview_url()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Mumbai, India" },
            new List<string> () { "Los Angeles, United States of America" },
            new List<string> () { "Seattle, United States" },
            new List<string> () { "New York, United States of America" },
            new List<string> () { "Wellington, New Zealand" },
            new List<string> () { "Delhi, India" }
            };


            List<string> searchQuery = new List<string>() {
                "Mumbai population",
                "Los Angeles population",
                "Seattle population",
                "New York population",
                "Wellington population",
                "Delhi population"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> output = new List<string>() {
                "http://worldpopulationreview.com/world-cities/mumbai-population/",
                "http://worldpopulationreview.com/us-cities/los-angeles-population/",
                "http://worldpopulationreview.com/us-cities/seattle-population/",
                "http://worldpopulationreview.com/states/new-york-population/",
                "http://worldpopulationreview.com/world-cities/wellington-population/",
                "http://worldpopulationreview.com/world-cities/delhi-population/"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("24City_population_worldpopulationreview_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Country_population_wiki()
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


            List<string> output = new List<string>() {
                "https://en.wikipedia.org/wiki/Demographics_of_India",
                "https://en.wikipedia.org/wiki/Demographics_of_the_United_States",
                "https://en.wikipedia.org/wiki/Demographics_of_South_Africa",
                "https://en.wikipedia.org/wiki/Demographics_of_China",
                "https://en.wikipedia.org/wiki/Demographics_of_Russia",
                "https://en.wikipedia.org/wiki/Demographics_of_New_Zealand",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("24Country_population_wiki", inputData, output));

        }

        #endregion

        #region stocks

        [Test, Timeout(120000)]
        public void Stock_value_cnn_url()
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

            List<string> output = new List<string>() {
                "http://money.cnn.com/quote/quote.html?symb=MSFT",
                "http://money.cnn.com/quote/quote.html?symb=AMZN",
                "http://money.cnn.com/quote/quote.html?symb=AAPL",
                "http://money.cnn.com/quote/quote.html?symb=TWTR",
                "http://money.cnn.com/quote/quote.html?symb=T",
                "http://money.cnn.com/quote/quote.html?symb=S"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11Stock_value_cnn_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Stock_value_yahoo_url()
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

            List<string> output = new List<string>() {
                "http://finance.yahoo.com/q?s=MSFT",
                "http://finance.yahoo.com/q?s=AMZN",
                "http://finance.yahoo.com/q?s=AAPL",
                "http://finance.yahoo.com/q?s=TWTR",
                "http://finance.yahoo.com/q?s=T",
                "http://finance.yahoo.com/q?s=S"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11Stock_value_yahoo_url", inputData, output));

        }


        [Test, Timeout(120000)]
        public void Stock_value_nasdaq_url()
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

            List<string> output = new List<string>() {
                "http://www.nasdaq.com/symbol/msft",
                "http://www.nasdaq.com/symbol/amzn",
                "http://www.nasdaq.com/symbol/aapl",
                "http://www.nasdaq.com/symbol/twtr",
                "http://www.nasdaq.com/symbol/t",
                "http://www.nasdaq.com/symbol/s"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11Stock_value_nasdaq_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Stock_value_marketwatch_url()
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

            List<string> output = new List<string>() {
                "http://www.marketwatch.com/investing/stock/msft",
                "http://www.marketwatch.com/investing/stock/amzn",
                "http://www.marketwatch.com/investing/stock/aapl",
                "http://www.marketwatch.com/investing/stock/twtr",
                "http://www.marketwatch.com/investing/stock/T",
                "http://www.marketwatch.com/investing/stock/s"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11Stock_value_marketwatch_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Stock_value_wsj_url()
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

            List<string> output = new List<string>() {
                "http://quotes.wsj.com/MSFT",
                "http://quotes.wsj.com/AMZN",
                "http://quotes.wsj.com/AAPL",
                "http://quotes.wsj.com/TWTR",
                "http://quotes.wsj.com/T",
                "http://quotes.wsj.com/S"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11Stock_value_wsj_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Stock_value_google_url()
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

            List<string> output = new List<string>() {
                "http://www.google.com/finance?cid=358464",
                "http://www.google.com/finance?cid=660463",
                "https://www.google.com/finance?cid=22144",
                "https://www.google.com/finance?cid=32086821185414",
                "https://www.google.com/finance?cid=33312",
                "http://www.google.com/finance?cid=694653"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("3Stock_value_google_url", inputData, output));

        }



        [Test, Timeout(120000)]
        public void Stock_value_google_history_url_1()
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

            List<string> output = new List<string>() {
                "http://www.google.com/finance/historical?q=NASDAQ:MSFT",
                "http://www.google.com/finance/historical?q=NASDAQ:AMZN",
                "http://www.google.com/finance/historical?q=NASDAQ:AAPL",
                "http://www.google.com/finance/historical?q=NASDAQ:GOOG",
                "http://www.google.com/finance/historical?q=NYSE:T",
                "http://www.google.com/finance/historical?q=NASDAQ:FB"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("21Stock_value_google_history_url_1", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Stock_value_marketwatch_history_url()
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

            List<string> output = new List<string>() {
                "http://www.marketwatch.com/investing/stock/MSFT/historical",
                "http://www.marketwatch.com/investing/stock/AMZN/historical",
                "http://www.marketwatch.com/investing/stock/AAPL/historical",
                "http://www.marketwatch.com/investing/stock/twtr/historical",
                "http://www.marketwatch.com/investing/stock/T/historical",
                "http://www.marketwatch.com/investing/stock/s/historical"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11Stock_value_marketwatch_history_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void stocks_same_page()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"VNET" },
                new List<string>() {"AGTK" },
                new List<string>() {"AKAM" },
                new List<string>() {"BIDU" },
                new List<string>() {"BCOR" },
                new List<string>() {"WIFI" },
            };
            List<string> output = new List<string>() {
                "http://www.marketwatch.com/tools/industry/stocklist.asp?bcind_ind=9535&bcind_period=3mo",
                "http://www.marketwatch.com/tools/industry/stocklist.asp?bcind_ind=9535&bcind_period=3mo",
                "http://www.marketwatch.com/tools/industry/stocklist.asp?bcind_ind=9535&bcind_period=3mo",
                "http://www.marketwatch.com/tools/industry/stocklist.asp?bcind_ind=9535&bcind_period=3mo",
                "http://www.marketwatch.com/tools/industry/stocklist.asp?bcind_ind=9535&bcind_period=3mo",
                "http://www.marketwatch.com/tools/industry/stocklist.asp?bcind_ind=9535&bcind_period=3mo",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestDirectUrl("11stocks_same_page", inputData, output));

        }
        #endregion

        #region currency exchange

        [Test, Timeout(120000)]
        public void Curreny_exchange_yahoo_echarts_url()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "10 USD", "INR", "6/16/2015" },
            new List<string> () { "12 EUR", "GBP", "2/21/2015" },
            new List<string> () { "44 GBP", "USD" , "4/5/2014" },
            new List<string> () { "5 USD", "CHF", "4/21/2015" },
            new List<string> () { "200 AUD", "USD", "6/21/2014" },
            new List<string> () { "31 USD", "CHF", "8/21/2015" }
            };


            List<string> searchQuery = new List<string>() {
                "USD to INR",
                "EUR to GBP",
                "GBP to USD",
                "USD to CHF",
                "AUD to USD",
                "USD to CHF"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> output = new List<string>() {
                "http://finance.yahoo.com/echarts?s=USDINR=X",
                "http://finance.yahoo.com/echarts?s=EURGBP=X",
                "http://finance.yahoo.com/echarts?s=GBPUSD=X",
                "http://finance.yahoo.com/echarts?s=USDCHF=X",
                "http://finance.yahoo.com/echarts?s=AUDUSD=X",
                "http://finance.yahoo.com/echarts?s=USDCHF=X"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("13Curreny_exchange_yahoo_echarts_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Curreny_exchange_yahoo_url()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "10 USD", "INR", "6/16/2015" },
            new List<string> () { "12 EUR", "GBP", "2/21/2015" },
            new List<string> () { "44 GBP", "USD" , "4/5/2014" },
            new List<string> () { "5 USD", "CHF", "4/21/2015" },
            new List<string> () { "24 CHF", "INR" , "5/11/2015" },
            new List<string> () { "100 USD", "JPY", "4/18/2014" },
            new List<string> () { "200 AUD", "CAD", "6/21/2014" },
            new List<string> () { "31 CAD", "CHF", "8/21/2015" }
            };


            List<string> searchQuery = new List<string>() {
                "USD to INR",
                "EUR to GBP",
                "GBP to USD",
                "USD to CHF",
                "CHF to INR",
                "USD to JPY",
                "AUD to CAD",
                "CAD to CHF"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> output = new List<string>() {
                "http://finance.yahoo.com/q?s=USDINR=X",
                "http://finance.yahoo.com/q?s=EURGBP=X",
                "http://finance.yahoo.com/q?s=GBPUSD=X",
                "http://finance.yahoo.com/q?s=USDCHF=X",
                "http://finance.yahoo.com/q?s=CHFINR=X",
                "http://finance.yahoo.com/q?s=USDJPY=X",
                "http://finance.yahoo.com/q?s=AUDCAD=X",
                "http://finance.yahoo.com/q?s=CADCHF=X"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("13Currency_exchange_yahoo_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Curreny_exchange_investing_url()
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

            List<string> output = new List<string>() {
                "http://www.investing.com/currencies/usd-inr",
                "http://www.investing.com/currencies/eur-gbp",
                "http://www.investing.com/currencies/gbp-usd",
                "http://www.investing.com/currencies/usd-chf",
                "http://www.investing.com/currencies/chf-inr",
                "http://www.investing.com/currencies/jpy-usd",
                "http://www.investing.com/currencies/aud-cad",
                "http://www.investing.com/currencies/cad-chf"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11Currency_exchange_investing_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Curreny_exchange_xe_url()
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

            List<string> output = new List<string>() {
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=USD&To=INR",
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=EUR&To=GBP",
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=GBP&To=USD",
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=USD&To=CHF",
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=CHF&To=INR",
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=JPY&To=USD",
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=AUD&To=CAD",
                "http://www.xe.com/currencyconverter/convert/?Amount=1&From=CAD&To=CHF"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11Currency_exchange_xe_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Curreny_exchange_bloomberg_url()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "10 USD", "INR", "6/16/2015" },
            new List<string> () { "12 EUR", "GBP", "2/21/2015" },
            new List<string> () { "44 GBP", "USD" , "4/5/2014" },
            new List<string> () { "5 USD", "CHF", "4/21/2015" },
            new List<string> () { "24 CHF", "INR" , "5/11/2015" },
            new List<string> () { "100 USD", "JPY", "4/18/2014" },
            new List<string> () { "200 AUD", "CAD", "6/21/2014" },
            new List<string> () { "31 CAD", "CHF", "8/21/2015" }
            };


            List<string> searchQuery = new List<string>() {
                "USD to INR",
                "EUR to GBP",
                "GBP to USD",
                "USD to CHF",
                "CHF to INR",
                "USD to JPY",
                "AUD to CAD",
                "CAD to CHF"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> output = new List<string>() {
                "http://www.bloomberg.com/quote/USDINR:CUR",
                "http://www.bloomberg.com/quote/EURGBP:CUR",
                "http://www.bloomberg.com/quote/GBPUSD:CUR",
                "http://www.bloomberg.com/quote/USDCHF:CUR",
                "http://www.bloomberg.com/quote/CHFINR:CUR",
                "http://www.bloomberg.com/quote/USDJPY:CUR",
                "http://www.bloomberg.com/quote/AUDCAD:CUR",
                "http://www.bloomberg.com/quote/CADCHF:CUR"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("13Currency_exchange_bloomberg_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Curreny_exchange_moneyconverter_url()
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

            List<string> output = new List<string>() {
                "http://themoneyconverter.com/USD/INR.aspx",
                "http://themoneyconverter.com/EUR/GBP.aspx",
                "http://themoneyconverter.com/GBP/USD.aspx",
                "http://themoneyconverter.com/USD/CHF.aspx",
                "http://themoneyconverter.com/CHF/INR.aspx",
                "http://themoneyconverter.com/JPY/USD.aspx",
                "http://themoneyconverter.com/AUD/CAD.aspx",
                "http://themoneyconverter.com/CAD/CHF.aspx"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11Currency_exchange_moneyconverter_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Curreny_exchange_google_url()
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

            List<string> output = new List<string>() {
                "http://www.google.com/finance?q=USDINR",
                "http://www.google.com/finance?q=EURGBP",
                "http://www.google.com/finance?q=GBPUSD",
                "http://www.google.com/finance?q=USDCHF",
                "http://www.google.com/finance?q=CHFINR",
                "http://www.google.com/finance?q=JPYUSD",
                "http://www.google.com/finance?q=AUDCAD",
                "http://www.google.com/finance?q=CADCHF"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("13Currency_exchange_google_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Curreny_exchange_investing_historical_url()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "10 USD", "INR", "USD to INR historical" },
            new List<string> () { "12 EUR", "GBP", "EUR to GBP historical" },
            new List<string> () { "44 GBP", "USD", "GBP to USD historical"},
            new List<string> () { "5 USD", "CHF", "USD to CHF historical" },
            new List<string> () { "24 CHF", "INR", "CHF to INR historical" },
            new List<string> () { "100 JPY", "USD", "JPY to USD historical" },
            new List<string> () { "200 AUD", "CAD", "AUD to CAD historical" },
            new List<string> () { "31 CAD", "CHF" , "CAD to CHF historical" }
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

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11Currency_exchange_investing_historical_url", inputData, url));
        }

        [Test, Timeout(120000)]
        public void Curreny_exchange_xe_historical_url_direct()
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

            List<string> output = new List<string>() {
                "http://www.xe.com/currencytables/?from=USD&date=2015-06-16",
                "http://www.xe.com/currencytables/?from=EUR&date=2015-02-21",
                "http://www.xe.com/currencytables/?from=GBP&date=2014-04-05",
                "http://www.xe.com/currencytables/?from=USD&date=2015-04-21",
                "http://www.xe.com/currencytables/?from=CHF&date=2015-05-11",
                "http://www.xe.com/currencytables/?from=JPY&date=2014-04-18",
                "http://www.xe.com/currencytables/?from=AUD&date=2014-06-21",
                "http://www.xe.com/currencytables/?from=CAD&date=2015-08-21"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestDirectUrl("11Currency_exchange_xe_historical_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void Curreny_exchange_rates_url_direct()
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

            List<string> output = new List<string>() {
                "http://www.exchange-rates.org/Rate/USD/INR/6-16-2015",
                "http://www.exchange-rates.org/Rate/EUR/GBP/2-21-2015",
                "http://www.exchange-rates.org/Rate/GBP/USD/4-5-2014",
                "http://www.exchange-rates.org/Rate/USD/CHF/4-21-2015",
                "http://www.exchange-rates.org/Rate/CHF/INR/5-11-2015",
                "http://www.exchange-rates.org/Rate/JPY/USD/4-18-2014",
                "http://www.exchange-rates.org/Rate/AUD/CAD/6-21-2014",
                "http://www.exchange-rates.org/Rate/CAD/CHF/8-21-2015"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestDirectUrl("11Currency_exchange_rates_url", inputData, output));

        }

        #endregion

        #region NFL teams

        [Test, Timeout(120000)]
        public void NFL_teamranking_url()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Buffalo Bills", "Orchard Park, NY", "Ralph WIlson Stadium" },
            new List<string> () { "Miami Dolphins", "Miami Gardens, FL", "Sun Life Stadium" },
            new List<string> () { "New England Patriots", "Foxborough, MA" , "Gillette Stadium" },
            new List<string> () { "New York Jets", "East Rutherford, NJ", "MetLife Stadium[B]" },
            new List<string> () { "Baltimore Ravens", "Baltimore, MD" , "M&T Bank Stadium" }
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

            List<string> output = new List<string>() {
                "https://www.teamrankings.com/nfl/team/buffalo-bills",
                "https://www.teamrankings.com/nfl/team/miami-dolphins",
                "https://www.teamrankings.com/nfl/team/new-england-patriots",
                "https://www.teamrankings.com/nfl/team/new-york-jets",
                "https://www.teamrankings.com/nfl/team/baltimore-ravens"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("12NFL_teamranking_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void NFL_teamranking_espn_url()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Buffalo Bills", "Orchard Park, NY", "Ralph WIlson Stadium" },
            new List<string> () { "Miami Dolphins", "Miami Gardens, FL", "Sun Life Stadium" },
            new List<string> () { "New England Patriots", "Foxborough, MA" , "Gillette Stadium" },
            new List<string> () { "New York Jets", "East Rutherford, NJ", "MetLife Stadium[B]" },
            new List<string> () { "Baltimore Ravens", "Baltimore, MD" , "M&T Bank Stadium" }
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

            List<string> output = new List<string>() {
                "http://www.espn.com/nfl/team/_/name/buf/buffalo-bills",
                "http://www.espn.com/nfl/team/_/name/mia/miami-dolphins",
                "http://www.espn.com/nfl/team/_/name/ne/new-england-patriots",
                "http://www.espn.com/nfl/team/_/name/nyj/new-york-jets",
                "http://www.espn.com/nfl/team/_/name/bal/baltimore-ravens"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("22NFL_teamranking_espn_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void NFL_stadium_espn_url()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Buffalo Bills", "Orchard Park, NY" },
            new List<string> () { "Miami Dolphins", "Miami Gardens, FL"},
            new List<string> () { "New England Patriots", "Foxborough, MA" },
            new List<string> () { "New York Jets", "East Rutherford, NJ" },
            new List<string> () { "Baltimore Ravens", "Baltimore, MD" }
            };


            List<string> searchQuery = new List<string>() {
                "buffalo bills stadium",
                "miami dolphins stadium",
                "new england patriots stadium",
                "new york jets stadium",
                "baltimore ravens stadium"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> output = new List<string>() {
                "http://www.espn.com/nfl/team/stadium/_/name/buf/buffalo-bills",
                "http://www.espn.com/nfl/team/stadium/_/name/mia/miami-dolphins",
                "http://www.espn.com/nfl/team/stadium/_/name/ne/new-england-patriots",
                "http://www.espn.com/nfl/team/stadium/_/name/nyj/new-york-jets",
                "http://www.espn.com/nfl/team/stadium/_/name/bal/baltimore-ravens"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("22NFL_stadium_espn_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void NFL_stadium_espn_url_big()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Buffalo Bills", "Orchard Park, NY", },
                new List<string>() {"New England Patriots", "Foxborough, MA", },
                new List<string>() {"Miami Dolphins", "Miami Gardens, FL", },
                new List<string>() {"New York Jets", "East Rutherford, NJ", },
                new List<string>() {"Baltimore Ravens", "Baltimore, MD", },
                new List<string>() {"Cincinnati Bengals", "Cincinnati, OH", },
                new List<string>() {"Cleveland Browns", "Cleveland, OH", },
                new List<string>() {"Pittsburgh Steelers", "Pittsburgh, PA", },
                new List<string>() {"Houston Texans", "Houston, TX", },
                new List<string>() {"Indianapolis Colts", "Indianapolis, IN", },
                new List<string>() {"Jacksonville Jaguars", "Jacksonville, FL", },
                new List<string>() {"Tennessee Titans", "Nashville, TN", },
                new List<string>() {"Denver Broncos", "Denver, CO", },
                new List<string>() {"Kansas City Chiefs", "Kansas City, MO", },
                new List<string>() {"Oakland Raiders", "Oakland, CA", },
                new List<string>() {"San Diego Chargers", "San Diego, CA", },
                new List<string>() {"Dallas Cowboys", "Arlington, TX", },
                new List<string>() {"New York Giants", "East Rutherford, NJ", },
                new List<string>() {"Philadelphia Eagles", "Philadelphia, PA", },
                new List<string>() {"Washington Redskins", "Landover, MD", },
                new List<string>() {"Chicago Bears", "Chicago, IL", },
                new List<string>() {"Detroit Lions", "Detroit, MI", },
                new List<string>() {"Green Bay Packers", "Green Bay, WI", },
                new List<string>() {"Minnesota Vikings", "Minneapolis, MN", },
                new List<string>() {"Atlanta Falcons", "Atlanta, GA", },
                new List<string>() {"Carolina Panthers", "Charlotte, NC", },
                new List<string>() {"New Orleans Saints", "New Orleans, LA", },
                new List<string>() {"Tampa Bay Buccaneers", "Tampa, FL", },
                new List<string>() {"Arizona Cardinals", "Glendale, AZ", },
                new List<string>() {"Los Angeles Rams", "Los Angeles, CA", },
                new List<string>() {"San Francisco 49ers", "Santa Clara, CA", },
                new List<string>() {"Seattle Seahawks", "Seattle, WA", },
            };


            List<string> searchQuery = new List<string>() {
                "buffalo bills stadium",
                "new england patriots stadium",
                "miami dolphins stadium",
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

            List<string> output = new List<string>() {
                "http://www.espn.com/nfl/team/stadium/_/name/buf/buffalo-bills",
                "http://www.espn.com/nfl/team/stadium/_/name/ne/new-england-patriots",
                "http://www.espn.com/nfl/team/stadium/_/name/mia/miami-dolphins",
                "http://www.espn.com/nfl/team/stadium/_/name/nyj/new-york-jets",
                "http://www.espn.com/nfl/team/stadium/_/name/bal/baltimore-ravens",
                "http://www.espn.com/nfl/team/stadium/_/name/cin/cincinnati-bengals",
                "http://www.espn.com/nfl/team/stadium/_/name/cle/cleveland-browns",
                "http://www.espn.com/nfl/team/stadium/_/name/pit/pittsburgh-steelers",
                "http://www.espn.com/nfl/team/stadium/_/name/hou/houston-texans",
                "http://www.espn.com/nfl/team/stadium/_/name/ind/indianapolis-colts",
                "http://www.espn.com/nfl/team/stadium/_/name/jax/jacksonville-jaguars",
                "http://www.espn.com/nfl/team/stadium/_/name/ten/tennessee-titans",
                "http://www.espn.com/nfl/team/stadium/_/name/den/denver-broncos",
                "http://www.espn.com/nfl/team/stadium/_/name/kc/kansas-city-chiefs",
                "http://www.espn.com/nfl/team/stadium/_/name/oak/oakland-raiders",
                "http://www.espn.com/nfl/team/stadium/_/name/sd/san-diego-chargers",
                "http://www.espn.com/nfl/team/stadium/_/name/dal/dallas-cowboys",
                "http://www.espn.com/nfl/team/stadium/_/name/nyg/new-york-giants",
                "http://www.espn.com/nfl/team/stadium/_/name/phi/philadelphia-eagles",
                "http://www.espn.com/nfl/team/stadium/_/name/wsh/washington-redskins",
                "http://www.espn.com/nfl/team/stadium/_/name/chi/chicago-bears",
                "http://www.espn.com/nfl/team/stadium/_/name/det/detroit-lions",
                "http://www.espn.com/nfl/team/stadium/_/name/gb/green-bay-packers",
                "http://www.espn.com/nfl/team/stadium/_/name/min/minnesota-vikings",
                "http://www.espn.com/nfl/team/stadium/_/name/atl/atlanta-falcons",
                "http://www.espn.com/nfl/team/stadium/_/name/car/carolina-panthers",
                "http://www.espn.com/nfl/team/stadium/_/name/no/new-orleans-saints",
                "http://www.espn.com/nfl/team/stadium/_/name/tb/tampa-bay-buccaneers",
                "http://www.espn.com/nfl/team/stadium/_/name/ari/arizona-cardinals",
                "http://www.espn.com/nfl/team/stadium/_/name/la/los-angeles-rams",
                "http://www.espn.com/nfl/team/stadium/_/name/sf/san-francisco-49ers",
                "http://www.espn.com/nfl/team/stadium/_/name/sea/seattle-seahawks",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("22NFL_stadium_espn_url_big", inputData, output));

        }

        [Test, Timeout(120000)]
        public void NFL_teamranking_cbss_url()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Buffalo Bills", "Orchard Park, NY", "Ralph WIlson Stadium" },
            new List<string> () { "Miami Dolphins", "Miami Gardens, FL", "Sun Life Stadium" },
            new List<string> () { "New England Patriots", "Foxborough, MA" , "Gillette Stadium" },
            new List<string> () { "New York Jets", "East Rutherford, NJ", "MetLife Stadium[B]" },
            new List<string> () { "Baltimore Ravens", "Baltimore, MD" , "M&T Bank Stadium" }
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

            List<string> output = new List<string>() {
                "http://www.cbssports.com/nfl/teams/page/BUF/buffalo-bills",
                "http://www.cbssports.com/nfl/teams/page/MIA/miami-dolphins",
                "http://www.cbssports.com/nfl/teams/page/NE/new-england-patriots",
                "http://www.cbssports.com/nfl/teams/page/NYJ/new-york-jets",
                "http://www.cbssports.com/nfl/teams/page/BAL/baltimore-ravens"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("22NFL_teamranking_cbss_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void NFL_teamranking_nfl_url()
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

            List<string> output = new List<string>() {
                "http://www.nfl.com/teams/buffalobills/profile?team=BUF",
                "http://www.nfl.com/teams/miamidolphins/profile?team=MIA",
                "http://www.nfl.com/teams/newenglandpatriots/profile?team=NE",
                "http://www.nfl.com/teams/newyorkjets/profile?team=NYJ",
                "http://www.nfl.com/teams/baltimoreravens/profile?team=BAL"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("21NFL_teamranking_nfl_url", inputData, output));

        }

        #endregion

        #region atp ranking

        [Test, Timeout(120000)]
        public void atp_ranking_atpworldtour_url()
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

            List<string> output = new List<string>() {
                "http://www.atpworldtour.com/en/players/novak-djokovic/d643/overview",
                "http://www.atpworldtour.com/en/players/roger-federer/f324/overview",
                "http://www.atpworldtour.com/en/players/andy-murray/mc10/overview",
                "http://www.atpworldtour.com/en/players/stan-wawrinka/w367/overview",
                "http://www.atpworldtour.com/en/players/tomas-berdych/ba47/overview"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("21atp_ranking_atpworldtour_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void atp_ranking_wiki_url_1()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Novak Djokovic" },
            new List<string> () { "Roger Federer" },
            new List<string> () { "Andy Murray" },
            new List<string> () { "Stanislas Wawrinka" },
            new List<string> () { "Tom%C3%A1%C5%A1 Berdych" }
            };


            List<string> searchQuery = new List<string>() {
                "Novak Djokovic wiki",
                "Roger Federer wiki",
                "Andy Murray wiki",
                "Stanislas Wawrinka wiki",
                "Tom%C3%A1%C5%A1 Berdych wiki"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> output = new List<string>() {
                "https://en.wikipedia.org/wiki/Novak_Djokovic",
                "https://en.wikipedia.org/wiki/Roger_Federer",
                "https://en.wikipedia.org/wiki/Andy_Murray",
                "https://en.wikipedia.org/wiki/Stanislas_Wawrinka",
                "https://en.wikipedia.org/wiki/Tom%C3%A1%C5%A1_Berdych",
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11atp_ranking_wiki_url_1", inputData, output));

        }

        [Test, Timeout(120000)]
        public void tennis_wiki_full_1()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Novak Djokovic", "2016", "Novak Djokovic wiki", },
                new List<string>() {"Roger Federer", "2009", "Roger Federer wiki", },
                new List<string>() {"Andy Murray", "2012", "Andy Murray wiki", },
                new List<string>() {"Stanislas Wawrinka", "2016", "Stanislas Wawrinka wiki", },
                new List<string>() { "Tom%C3%A1%C5%A1 Berdych", "2011", "Tomas Berdych wiki", },
                new List<string>() {"Kei Nishikori", "2016", "Kei Nishikori wiki", },
                new List<string>() {"Rafael Nadal", "2015", "Rafael Nadal wiki", },
                new List<string>() {"David Ferrer", "2013", "David Ferrer wiki", },
                new List<string>() {"Milos Raonic", "2016", "Milos Raonic wiki", },
                new List<string>() {"Gilles Simon", "2013", "Gilles Simon wiki", },
                new List<string>() {"Richard Gasquet", "2016", "Richard Gasquet wiki", },
                new List<string>() {"John Isner", "2014", "John Isner wiki", },
                new List<string>() { "Marin %C4%8Cili%C4%87", "2015", "Marin Cilic wiki", },
                new List<string>() {"David Goffin", "2016", "David Goffin wiki", },
                new List<string>() { "Feliciano L%C3%B3pez", "2011", "Feliciano Lopez wiki", },
                new List<string>() {"Jo-Wilfried Tsonga", "2014", "Wilfried Tsonga wiki", },
                new List<string>() { "Ivo Karlovi%C4%87", "2015", "Ivo Karlovic wiki", },
                new List<string>() {"Grigor Dimitrov", "2016", "Grigor Dimitrov wiki", },
                new List<string>() {"Bernard Tomic", "2011", "Bernard Tomic wiki", },
            };
            List<string> output = new List<string>() {
                "https://en.wikipedia.org/wiki/Novak_Djokovic",
                "https://en.wikipedia.org/wiki/Roger_Federer",
                "https://en.wikipedia.org/wiki/Andy_Murray",
                "https://en.wikipedia.org/wiki/Stanislas_Wawrinka",
                "https://en.wikipedia.org/wiki/Tom%C3%A1%C5%A1_Berdych",
                "https://en.wikipedia.org/wiki/Kei_Nishikori",
                "https://en.wikipedia.org/wiki/Rafael_Nadal",
                "https://en.wikipedia.org/wiki/David_Ferrer",
                "https://en.wikipedia.org/wiki/Milos_Raonic",
                "https://en.wikipedia.org/wiki/Gilles_Simon",
                "https://en.wikipedia.org/wiki/Richard_Gasquet",
                "https://en.wikipedia.org/wiki/John_Isner",
                "https://en.wikipedia.org/wiki/Marin_%C4%8Cili%C4%87",
                "https://en.wikipedia.org/wiki/David_Goffin",
                "https://en.wikipedia.org/wiki/Feliciano_L%C3%B3pez",
                "https://en.wikipedia.org/wiki/Jo-Wilfried_Tsonga",
                "https://en.wikipedia.org/wiki/Ivo_Karlovi%C4%87",
                "https://en.wikipedia.org/wiki/Grigor_Dimitrov",
                "https://en.wikipedia.org/wiki/Bernard_tomic",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("12tennis_wiki_full_1", inputData, output));
        }

        [Test, Timeout(120000)]
        public void atp_ranking_tennis_url()
        {
            List<List<string>> inputData = new List<List<string>>() {
            new List<string> () { "Novak Djokovic" },
            new List<string> () { "Roger Federer" },
            new List<string> () { "Andy Murray" },
            new List<string> () { "Stanislas Wawrinka" },
            new List<string> () { "Tomas Berdych" }
            };


            List<string> searchQuery = new List<string>() {
                "Novak Djokovic ranking",
                "Roger Federer ranking",
                "Andy Murray ranking",
                "Stanislas Wawrinka ranking",
                "Tomas Berdych ranking"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> output = new List<string>() {
                "http://www.tennis.com/player/532/novak-djokovic/",
                "http://www.tennis.com/player/376/roger-federer/",
                "http://www.tennis.com/player/569/andy-murray/",
                "http://www.tennis.com/player/506/stanislas-wawrinka/",
                "http://www.tennis.com/player/511/tomas-berdych/"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("21atp_ranking_tennis_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void atp_ranking_espn_url()
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

            List<string> output = new List<string>() {
                "http://www.espn.com/tennis/player/_/id/296/novak-djokovic",
                "http://www.espn.com/tennis/player/_/id/425/roger-federer",
                "http://www.espn.com/tennis/player/_/id/235/andy-murray",
                "http://www.espn.com/tennis/player/_/id/264/stan-wawrinka",
                "http://www.espn.com/tennis/player/_/id/363/tomas-berdych"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("21atp_ranking_espn_url", inputData, output));

        }

        [Test, Timeout(120000)]
        public void atp_ranking_espn_full()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Novak Djokovic", "2016", "Novak Djokovic"},
                new List<string>() {"Jo-Wilfried Tsonga", "2014", "Jo-Wilfried Tsonga"},
                new List<string>() {"Roger Federer", "2009", "Roger Federer"},
                new List<string>() {"Andy Murray", "2012", "Andy Murray"},
                new List<string>() {"Stan Wawrinka", "2016", "Stan Wawrinka"},
                new List<string>() {"Tomas Berdych", "2011", "Tomas Berdych"},
                new List<string>() {"Kei Nishikori", "2016", "Kei Nishikori"},
                new List<string>() {"Rafael Nadal", "2015", "Rafael Nadal"},
                new List<string>() {"David Ferrer", "2013", "David Ferrer"},
                new List<string>() {"Milos Raonic", "2016", "Milos Raonic"},
                new List<string>() {"Gilles Simon", "2013", "Gilles Simon"},
                new List<string>() {"Richard Gasquet", "2016", "Richard Gasquet"},
                new List<string>() {"Kevin Anderson", "2015", "Kevin Anderson"},
                new List<string>() {"John Isner", "2014", "John Isner"},
                new List<string>() {"Marin Cilic", "2015", "Marin Cilic"},
                new List<string>() {"David Goffin", "2016", "David Goffin"},
                new List<string>() {"Feliciano Lopez", "2011", "Feliciano Lopez"},
                new List<string>() {"Ivo Karlovic", "2015", "Ivo Karlovic"},
                new List<string>() {"Grigor Dimitrov", "2016", "Grigor Dimitrov"},
                new List<string>() {"Bernard Tomic", "2011", "Bernard Tomic"},
            };
            List<string> output = new List<string>() {
                "http://www.espn.com/tennis/player/_/id/296/novak-djokovic",
                "http://www.espn.com/tennis/player/_/id/435/jo-wilfried-tsonga",
                "http://www.espn.com/tennis/player/_/id/425/roger-federer",
                "http://www.espn.com/tennis/player/_/id/235/andy-murray",
                "http://www.espn.com/tennis/player/_/id/264/stan-wawrinka",
                "http://www.espn.com/tennis/player/_/id/363/tomas-berdych",
                "http://www.espn.com/tennis/player/_/id/1035/kei-nishikori",
                "http://www.espn.com/tennis/player/_/id/261/rafael-nadal",
                "http://www.espn.com/tennis/player/_/id/346/david-ferrer",
                "http://www.espn.com/tennis/player/_/id/1333/milos-raonic",
                "http://www.espn.com/tennis/player/_/id/302/gilles-simon",
                "http://www.espn.com/tennis/player/_/id/310/richard-gasquet",
                "http://www.espn.com/tennis/player/_/id/1068/kevin-anderson",
                "http://www.espn.com/tennis/player/_/id/1023/john-isner",
                "http://www.espn.com/tennis/player/_/id/464/marin-cilic",
                "http://www.espn.com/tennis/player/_/id/1360/david-goffin",
                "http://www.espn.com/tennis/player/_/id/426/feliciano-lopez",
                "http://www.espn.com/tennis/player/_/id/233/ivo-karlovic",
                "http://www.espn.com/tennis/player/_/id/1287/grigor-dimitrov",
                "http://www.espn.com/tennis/player/_/id/1317/bernard-tomic",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("22atp_ranking_espn_full", inputData, output));
        }

        [Test, Timeout(120000)]
        public void atp_twitter_with_id()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Novak Djokovic", "djokernole", "Novak Djokovic twitter", },
                new List<string>() {"Andy Murray", "andy_murray", "Andy Murray twitter", },
                new List<string>() {"Roger Federer", "RogerFederer", "Roger Federer twitter", },
                new List<string>() {"Stan Wawrinka", "stanwawrinka", "Stan Wawrinka twitter", },
                new List<string>() {"Tomas Berdych", "TomasBerdych", "Tomas Berdych twitter", },
                new List<string>() {"Kei Nishikori", "KeiNishikori", "Kei Nishikori twitter", },
                new List<string>() {"Rafael Nadal", "rafaelnadal", "Rafael Nadal twitter", },
                new List<string>() {"David Ferrer", "DavidFerrer87", "David Ferrer twitter", },
                new List<string>() {"Milos Raonic", "MilosRaonic", "Milos Raonic twitter", },
                new List<string>() {"Gilles Simon", "GillesSimon84", "Gilles Simon twitter", },
                new List<string>() {"Richard Gasquet", "richardgasquet1", "Richard Gasquet twitter", },
                new List<string>() {"Kevin Anderson", "kevinanderson18", "Kevin Anderson twitter", },
                new List<string>() {"John Isner", "johnisner", "John Isner twitter", },
                new List<string>() {"Marin Cilic", "cilic_marin", "Marin Cilic twitter", },
                new List<string>() {"David Goffin", "David__Goffin", "David Goffin twitter", },
                new List<string>() {"Feliciano Lopez", "feliciano_lopez", "Feliciano Lopez twitter", },
                new List<string>() {"Jo-Wilfried Tsonga", "tsonga7", "Wilfried Tsonga twitter", },
                new List<string>() {"Ivo Karlovic", "ivokarlovic", "Ivo Karlovic twitter", },
                new List<string>() {"Grigor Dimitrov", "grigordimitrov", "Grigor Dimitrov twitter", },
            };
            List<string> output = new List<string>() {
                "https://twitter.com/djokernole",
                "https://twitter.com/andy_murray",
                "https://twitter.com/RogerFederer",
                "https://twitter.com/stanwawrinka",
                "https://twitter.com/TomasBerdych",
                "https://twitter.com/KeiNishikori",
                "https://twitter.com/rafaelnadal",
                "https://twitter.com/DavidFerrer87",
                "https://twitter.com/MilosRaonic",
                "https://twitter.com/GillesSimon84",
                "https://twitter.com/richardgasquet1",
                "https://twitter.com/kevinanderson18",
                "https://twitter.com/johnisner",
                "https://twitter.com/cilic_marin",
                "https://twitter.com/David__Goffin",
                "https://twitter.com/feliciano_lopez",
                "https://twitter.com/tsonga7",
                "https://twitter.com/ivokarlovic",
                "https://twitter.com/grigordimitrov",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("12atp_twitter_with_id", inputData, output));
        }

        [Test, Timeout(120000)]
        public void atp_twitter()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Novak Djokovic", "Novak Djokovic twitter", },
                new List<string>() {"Roger Federer", "Roger Federer twitter", },
                new List<string>() {"Andy Murray", "Andy Murray twitter", },
                new List<string>() {"Stan Wawrinka", "Stan Wawrinka twitter", },
                new List<string>() {"Tomas Berdych", "Tomas Berdych twitter", },
                new List<string>() {"Kei Nishikori", "Kei Nishikori twitter", },
                new List<string>() {"Rafael Nadal", "Rafael Nadal twitter", },
                new List<string>() {"David Ferrer", "David Ferrer twitter", },
                new List<string>() {"Milos Raonic", "Milos Raonic twitter", },
                new List<string>() {"Gilles Simon", "Gilles Simon twitter", },
                new List<string>() {"Richard Gasquet", "Richard Gasquet twitter", },
                new List<string>() {"Kevin Anderson", "Kevin Anderson twitter", },
                new List<string>() {"John Isner", "John Isner twitter", },
                new List<string>() {"Marin Cilic", "Marin Cilic twitter", },
                new List<string>() {"David Goffin", "David Goffin twitter", },
                new List<string>() {"Feliciano Lopez", "Feliciano Lopez twitter", },
                new List<string>() {"Jo-Wilfried Tsonga", "Wilfried Tsonga twitter", },
                new List<string>() {"Ivo Karlovic", "Ivo Karlovic twitter", },
                new List<string>() {"Grigor Dimitrov", "Grigor Dimitrov twitter", },
            };
            List<string> output = new List<string>() {
                "https://twitter.com/djokernole",
                "https://twitter.com/RogerFederer",
                "https://twitter.com/andy_murray",
                "https://twitter.com/stanwawrinka",
                "https://twitter.com/TomasBerdych",
                "https://twitter.com/KeiNishikori",
                "https://twitter.com/rafaelnadal",
                "https://twitter.com/DavidFerrer87",
                "https://twitter.com/MilosRaonic",
                "https://twitter.com/GillesSimon84",
                "https://twitter.com/richardgasquet1",
                "https://twitter.com/kevinanderson18",
                "https://twitter.com/johnisner",
                "https://twitter.com/cilic_marin",
                "https://twitter.com/David__Goffin",
                "https://twitter.com/feliciano_lopez",
                "https://twitter.com/tsonga7",
                "https://twitter.com/ivokarlovic",
                "https://twitter.com/grigordimitrov",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("34atp_twitter", inputData, output));
        }

        #endregion

        #region video

        [Test, Timeout(120000)]
        public void video_views()
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
                "See you Again video",
                "Uptown Funk video",
                "Blank Space video",
                "Sorry video"
            };

            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i].Add(searchQuery[i]);
            }

            List<string> output = new List<string>() {
                "http://www.youtube.com/watch?v=9bZkp7q19f0",
                "http://www.youtube.com/watch?v=RgKAFK5djSk",
                "http://www.youtube.com/watch?v=OPf0YbXqDm0",
                "http://www.youtube.com/watch?v=e-ORhEE9VVg",
                "http://www.youtube.com/watch?v=fRh_vgS2dFE"
            };

            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("3video_views", inputData, output));

        }

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
            List<string> output = new List<string>() {
                "https://en.wikipedia.org/wiki/The_Joshua_Tree",
                "https://en.wikipedia.org/wiki/Hybrid_Theory",
                "https://en.wikipedia.org/wiki/Come_Away_with_Me",
                "https://en.wikipedia.org/wiki/Slippery_When_Wet",
                "https://en.wikipedia.org/wiki/Nevermind",

            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("12albums_wiki", inputData, output));
        }

        #endregion

        #region flights

        [Test, Timeout(120000)]
        public void flights_travel_time()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"boston", "seattle", "boston to seattle flight", },
                new List<string>() {"seattle", "san francisco", "seattle to san francisco flight", },
                new List<string>() {"new york", "seattle", "new york to seattle flight", },
                new List<string>() {"los angeles", "san francisco", "los angeles to san francisco flight", },
                new List<string>() {"san francisco", "boston", "san francisco to boston flight", },
            };
            List<string> output = new List<string>() {
                "http://www.travelmath.com/flying-time/from/Boston,+MA/to/Seattle,+WA",
                "http://www.travelmath.com/flying-time/from/Seattle,+WA/to/San+Francisco,+CA",
                "http://www.travelmath.com/flying-time/from/New+York,+NY/to/Seattle,+WA",
                "http://www.travelmath.com/flying-time/from/Los+Angeles,+CA/to/San+Francisco,+CA",
                "http://www.travelmath.com/flying-time/from/San+Francisco,+CA/to/Boston,+MA",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("22flights_travel_time", inputData, output));
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
            List<string> output = new List<string>() {
                "http://www.farecompare.com/flights/Boston-BOS/Seattle-SEA/market.html",
                "http://www.farecompare.com/flights/Seattle-SEA/San_Francisco-SFO/market.html",
                "http://www.farecompare.com/flights/New_York-NYC/Seattle-SEA/market.html",
                "http://www.farecompare.com/flights/Los_Angeles-LAX/San_Francisco-SFO/market.html",
                "http://www.farecompare.com/flights/San_Francisco-SFO/Boston-BOS/market.html",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("22flights_fare_compare", inputData, output));
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
            List<string> output = new List<string>() {
                "http://www.cheapflights.com/flights-to-seattle/boston/",
                "http://www.cheapflights.com/flights-to-san-francisco/seattle/",
                "http://www.cheapflights.com/flights-to-seattle/new-york/",
                "http://www.cheapflights.com/flights-to-san-francisco/los-angeles/",
                "http://www.cheapflights.com/flights-to-boston/san-francisco/",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("12flights_cheap_flights", inputData, output));
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
            List<string> output = new List<string>() {
                "https://www.cheapoair.com/flights/cheap-flights-from-boston-to-seattle-bos-sea",
                "https://www.cheapoair.com/flights/cheap-flights-from-seattle-to-san-francisco-sea-sfo",
                "https://www.cheapoair.com/flights/cheap-flights-from-new-york-city-to-seattle-nyc-sea",
                "https://www.cheapoair.com/flights/cheap-flights-from-los-angeles-to-san-francisco-lax-sfo",
                "https://www.cheapoair.com/flights/cheap-flights-from-san-francisco-to-boston-sfo-bos",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("22flights_cheapoair", inputData, output));
        }

        #endregion

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
            List<string> output = new List<string>() {
                "http://www.zillow.com/homedetails/5002-159th-Ct-NE-Redmond-WA-98052/48731190_zpid/",
                "http://www.zillow.com/homedetails/11749-158th-Pl-NE-Redmond-WA-98052/65222240_zpid/",
                "http://www.zillow.com/homedetails/512-213th-St-SW-Bothell-WA-98021/38563217_zpid/",
                "http://www.zillow.com/homedetails/12806-64th-Ave-S-Seattle-WA-98178/49065655_zpid/",
                "http://www.zillow.com/homedetails/12824-4th-Ave-S-Burien-WA-98168/48734200_zpid/",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("22realestate_zillow", inputData, output));
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
            List<string> output = new List<string>() {
                "https://www.goodreads.com/book/show/1953.A_Tale_of_Two_Cities",
                "http://www.goodreads.com/book/show/33.The_Lord_of_the_Rings",
                "http://www.goodreads.com/book/show/5907.The_Hobbit",
                "https://www.goodreads.com/book/show/535739.The_Dream_of_the_Red_Chamber",
                "http://www.goodreads.com/book/show/16299.And_Then_There_Were_None",
                "https://www.goodreads.com/book/show/968.The_Da_Vinci_Code",
                "https://www.goodreads.com/book/show/865.The_Alchemist",
                "https://www.goodreads.com/book/show/136251.Harry_Potter_and_the_Deathly_Hallows",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("22novels_goodreads", inputData, output));
        }

        [Test, Timeout(120000)]
        public void novels()
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
            List<string> output = new List<string>() {
                "https://en.wikipedia.org/wiki/A_Tale_of_Two_Cities",
                "https://en.wikipedia.org/wiki/The_Lord_of_the_Rings",
                "https://en.wikipedia.org/wiki/The_Hobbit",
                "https://en.wikipedia.org/wiki/Dream_of_the_Red_Chamber",
                "https://en.wikipedia.org/wiki/And_Then_There_Were_None",
                "https://en.wikipedia.org/wiki/The_Da_Vinci_Code",
                "https://en.wikipedia.org/wiki/Harry_Potter_and_the_Deathly_Hallows",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("12novels", inputData, output));
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
                new List<string>() {"Nikhil Swamy", "Nikhil Swamy microsoft zoominfo" }
            };
            List<string> output = new List<string>() {
                "http://www.zoominfo.com/p/Patrice-Godefroid/1130704893",
                "http://www.zoominfo.com/p/Ben-Zorn/14114516",
                "http://www.zoominfo.com/p/Tom-Ball/14114519",
                "http://www.zoominfo.com/p/Nikolaj-Bj%C3%B8rner/1176627381",
                "http://www.zoominfo.com/p/Nikhil-Swamy/1302489119"
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("21microsoft_people_zoominfo", inputData, output));
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
            List<string> output = new List<string>() {
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=BOS",
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=OAK",
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=SFO",
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=SJC",
                "http://www.flightstats.com/go/Airport/airportDetails.do;airportCode=JFK",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11airport_code_flightstats", inputData, output));
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
            List<string> output = new List<string>() {
                "https://www.aa.com/i18n/travelInformation/destinationInformation/bos-airport.jsp",
                "https://www.aa.com/i18n/travelInformation/destinationInformation/oak-airport.jsp",
                "https://www.aa.com/i18n/travelInformation/destinationInformation/sfo-airport.jsp",
                "https://www.aa.com/i18n/travelInformation/destinationInformation/sjc-airport.jsp",
                "https://www.aa.com/i18n/travelInformation/destinationInformation/jfk-airport.jsp",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11airport_code_aa", inputData, output));
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
            List<string> output = new List<string>() {
                "https://www.virginamerica.com/cms/fly-with-us/airport-info/boston-bos/",
                "https://www.virginamerica.com/cms/fly-with-us/airport-info/austin-aus/",
                "https://www.virginamerica.com/cms/fly-with-us/airport-info/san-francisco-sfo/",
                "https://www.virginamerica.com/cms/fly-with-us/airport-info/los-angeles-lax/",
                "https://www.virginamerica.com/cms/fly-with-us/airport-info/portland-pdx/",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("22airport_code_virginamerica", inputData, output));
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
            List<string> output = new List<string>() {
                "http://www.nobelprize.org/nobel_prizes/lists/year/?year=2010",
                "http://www.nobelprize.org/nobel_prizes/lists/year/?year=2007",
                "http://www.nobelprize.org/nobel_prizes/lists/year/?year=2002",
                "http://www.nobelprize.org/nobel_prizes/lists/year/?year=2011",
                "http://www.nobelprize.org/nobel_prizes/lists/year/?year=2006",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11nobel_prize", inputData, output));
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
            List<string> output = new List<string>() {
                "http://www.nobelprize.org/nobel_prizes/chemistry/laureates/2010/",
                "http://www.nobelprize.org/nobel_prizes/physics/laureates/2007/",
                "http://www.nobelprize.org/nobel_prizes/literature/laureates/2002/",
                "http://www.nobelprize.org/nobel_prizes/physics/laureates/2011/",
                "http://www.nobelprize.org/nobel_prizes/chemistry/laureates/2006/",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11nobel_prize_subject", inputData, output));
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
            List<string> output = new List<string>() {
                "https://en.wikipedia.org/wiki/List_of_Nobel_laureates_in_Chemistry",
                "https://en.wikipedia.org/wiki/List_of_Nobel_laureates_in_Physics",
                "https://en.wikipedia.org/wiki/List_of_Nobel_laureates_in_Literature",
                "https://en.wikipedia.org/wiki/List_of_Nobel_laureates_in_Physics",
                "https://en.wikipedia.org/wiki/List_of_Nobel_laureates_in_Chemistry",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("11nobel_prize_subject_wiki", inputData, output));
        }
        #endregion

        #region google scholar

        [Test, Timeout(120000)]
        public void google_scholar_url_direct()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Rishabh Singh"},
                new List<string>() {"Armando Solar-Lezama"},
                new List<string>() {"Emery Berger"},
                new List<string>() {"Sumit Gulwani"},
                new List<string>() { "Swarat chaudhuri" }
            };
            List<string> output = new List<string>() {
                "https://scholar.google.com/scholar?q=rishabh+singh",
                "https://scholar.google.com/scholar?q=armando+solar-lezama",
                "https://scholar.google.com/scholar?q=emery+berger",
                "https://scholar.google.com/scholar?q=sumit+gulwani",
                "https://scholar.google.com/scholar?q=swarat+chaudhuri"
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestDirectUrl("12google_scholar_url", inputData, output));
        }


        #endregion

        [Test, Timeout(120000)]
        public void weather_historical()
        {
            List<List<string>> inputData = new List<List<string>>() {
                new List<string>() {"Ana Trujillo                 357 21th Place SE,Redmond,WA,(757) 555-1634,140-37-6064,27171", "November 4 (11/4)", "Redmond WA weather november 4", },
                new List<string>() {"Antonio Moreno                 515 93th Lane ,Renton,WA,(411) 555-2786,562-87-3127,28581", "October 30 (10/4)", "Renton WA weather october 30", },
                new List<string>() {"Thomas Hardy                 742 17th Street NE,Seattle,WA,(412) 555-5719,921-29-4931,24607", "September 1 (9/1)", "Seattle WA weather september 1", },
                new List<string>() {"Hanna Moos                 785 45th Street NE,Puyallup,WA,(376) 555-2462,515-68-1285,29284", "November 1 (11/1)", "Puyallup WA weather november 1", },
                new List<string>() {"Martin Sommer                 887 86th Place ,Kent,WA,(715) 555-5450,870-91-9824,21536", "October 25 (10/25)", "Kent WA weather october 25", },
                new List<string>() {"Charlie Gunaja        732 Memorial Drive, Cambridge,MA, (617) 325-2342, 732-322-4321,32654", "November 2 (11/2)", "Cambridge MA weather november 2", },
            };
            List<string> output = new List<string>() {
                "http://www.accuweather.com/en/us/redmond-wa/98052/november-weather/341347",
                "http://www.accuweather.com/en/us/renton-wa/98057/october-weather/341348",
                "http://www.accuweather.com/en/us/seattle-wa/98104/september-weather/351409",
                "http://www.accuweather.com/en/us/puyallup-wa/98372/november-weather/341343",
                "http://www.accuweather.com/en/us/kent-wa/98032/october-weather/341295",
                "http://www.accuweather.com/en/us/cambridge-ma/02139/november-weather/329319",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("21weather_historical", inputData, output));
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
            List<string> output = new List<string>() {
                "http://www.accuweather.com/en/us/redmond-wa/98052/november-weather/341347",
                "http://www.accuweather.com/en/us/renton-wa/98057/december-weather/341348",
                "http://www.accuweather.com/en/us/seattle-wa/98104/december-weather/351409",
                "http://www.accuweather.com/en/us/puyallup-wa/98372/december-weather/341343",
                "http://www.accuweather.com/en/us/kent-wa/98032/november-weather/341295",
                "http://www.accuweather.com/en/us/cambridge-ma/02139/november-weather/329319",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("21weather_future", inputData, output));
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
            List<string> output = new List<string>() {
                "http://dblp.uni-trier.de/pers/s/Solar=Lezama:Armando",
                "http://dblp.uni-trier.de/pers/g/Gulwani:Sumit",
                "http://dblp.uni-trier.de/pers/hd/y/Yahav:Eran",
                "http://dblp.uni-trier.de/pers/t/Torlak:Emina",
                "http://dblp.uni-trier.de/pers/c/Chaudhuri:Swarat",
            };
            Assert.IsTrue(WebExtractionPBE.WebRelateTestUtil.TestUrl("24dblp", inputData, output));
        }
    }

}
