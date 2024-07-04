using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using IndustrialSoftware_App.Model.Services.Interfaces;
using IndustrialSoftware_App.Model.Services.Implementation;
using IndustrialSoftware_App.Model;

namespace IndustrialSoftware_App.Controller
{
    public class DataController
    {

        private static DataController controller = null;

        private DataController() { }

        public static DataController GetInstance()
        {

            if (controller == null)
                controller = new DataController();

            return controller;

        }





        public iManageData dbContext = new CsvManageData() 
        { 
            connectionString = "" 
        };

        public List<HollywoodMovies> moviesList { get; private set; } = new List<HollywoodMovies>();

        public void Inizialize(string connectionString)
        {
            dbContext.connectionString = connectionString;
        }

        public void DownloadData()
        {

            this.moviesList = dbContext.Download();

            if (this.moviesList == null)
                throw new Exception("Qualcosa è andato storto nel download dei dati");

        }

        public void SaveData()
        {

            if(!dbContext.SaveData(this.moviesList))
                throw new Exception("Qualcosa è andato storto nel salvataggio dei dati");

        }

        public void ModElement(string key, string propertyName, string newValue)
        {

            switch (propertyName)
            {
                case "Movie":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.Movie = newValue;
                    });
                    break;

                case "LeadStudio":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.LeadStudio = newValue;
                    });
                    break;

                case "RottenTomatoes":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.RottenTomatoes = newValue;
                    });
                    break;

                case "AudienceScore":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.AudienceScore = newValue;
                    });
                    break;

                case "Story":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.Story = newValue;
                    });
                    break;

                case "Genre":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.Genre = newValue;
                    });
                    break;

                case "TheatersOpenWeek":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.TheatersOpenWeek = newValue;
                    });
                    break;

                case "OpeningWeekend":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.OpeningWeekend = newValue;
                    });
                    break;

                case "BOAvgOpenWeekend":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.BOAvgOpenWeekend = newValue;
                    });
                    break;

                case "DomesticGross":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.DomesticGross = newValue;
                    });
                    break;

                case "ForeignGross":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.ForeignGross = newValue;
                    });
                    break;

                case "WorldGross":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.WorldGross = newValue;
                    });
                    break;

                case "Budget":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.Budget = newValue;
                    });
                    break;

                case "Profitability":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.Profitability = newValue;
                    });
                    break;

                case "OpenProfit":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.OpenProfit = newValue;
                    });
                    break;

                case "Year":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.Year = newValue;
                    });
                    break;

                case "Director":
                    this.moviesList.ForEach(movie =>
                    {
                        if (movie.Movie == key)
                            movie.Director = newValue;
                    });
                    break;

                default:
                    break;
            }

        }

        public void DeleteElement(string key)
        {
            this.moviesList = this.moviesList.Where(movie => movie.Movie != key).ToList();
        }

    }
}
