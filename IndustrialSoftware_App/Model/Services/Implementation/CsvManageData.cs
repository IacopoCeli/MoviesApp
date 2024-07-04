using CsvHelper;
using CsvHelper.Configuration;
using IndustrialSoftware_App.Model.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSoftware_App.Model.Services.Implementation
{
    public class CsvManageData : iManageData
    {

        public string connectionString {  get; set; }

        public List<HollywoodMovies> Download()
        {

            try
            {

                List<HollywoodMovies> moviesList = new List<HollywoodMovies>();

                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    MissingFieldFound = null
                };

                using (var reader = new StreamReader(connectionString))
                {
                    using (var csv = new CsvReader(reader, config))
                    {
                        csv.Context.RegisterClassMap<HollywoodMoviesClassMap>();
                        moviesList = csv.GetRecords<HollywoodMovies>().ToList();
                    }
                }

                return moviesList;

            }
            catch (Exception ex)
            {
                return null;
            }


        }

        public bool SaveData(List<HollywoodMovies> movies)
        {

            try
            {

                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    MissingFieldFound = null
                };

                using (TextWriter writer = new StreamWriter(connectionString, false, System.Text.Encoding.UTF8))
                {
                    using (var csv = new CsvWriter(writer, config))
                    {
                        csv.WriteHeader<HollywoodMovies>();
                        csv.NextRecord();
                        foreach(HollywoodMovies movie in movies)
                        {
                            csv.WriteRecord(movie);
                            csv.NextRecord();
                        }
                    }
                    writer.Close();
                }

                return true;

            }
            catch { return false; }
            

        }




        private class HollywoodMoviesClassMap : ClassMap<HollywoodMovies>
        {

            public HollywoodMoviesClassMap()
            {
                Map(m => m.Movie).Name("Movie");
                Map(m => m.LeadStudio).Name("LeadStudio");
                Map(m => m.RottenTomatoes).Name("RottenTomatoes");
                Map(m => m.AudienceScore).Name("AudienceScore");
                Map(m => m.Story).Name("Story");
                Map(m => m.Genre).Name("Genre");
                Map(m => m.TheatersOpenWeek).Name("TheatersOpenWeek");
                Map(m => m.OpeningWeekend).Name("OpeningWeekend");
                Map(m => m.BOAvgOpenWeekend).Name("BOAvgOpenWeekend");
                Map(m => m.DomesticGross).Name("DomesticGross");
                Map(m => m.ForeignGross).Name("ForeignGross");
                Map(m => m.WorldGross).Name("WorldGross");
                Map(m => m.Budget).Name("Budget");
                Map(m => m.Profitability).Name("Profitability");
                Map(m => m.OpenProfit).Name("OpenProfit");
                Map(m => m.Year).Name("Year");
                Map(m => m.Director).Name("Director");
            }

        }


    }
}
