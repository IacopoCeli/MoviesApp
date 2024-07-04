using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSoftware_App.Model.Services.Interfaces
{
    public interface iManageData
    {

        public string connectionString { get; set; }

        public abstract List<HollywoodMovies> Download();

        public abstract bool SaveData(List<HollywoodMovies> movies);

    }
}
