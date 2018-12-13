using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobs.Models;

namespace TechJobs.ViewModels
{

    public class BaseViewModel
    {
        public List<JobFieldType> Columns { get; set; } //display all columns

        public string Title { get; set; } = ""; //title view

        public BaseViewModel()
        {
            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType))) //all columns list
            {
                Columns.Add(enumVal);
            }

        }
    }
}
