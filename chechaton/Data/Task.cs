using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using System.Globalization;

namespace Data
{
    public class Task
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("end_date")]
        public string EndDate { get; set; }
        [JsonProperty("end_time")]
        public string EndTime { get; set; }
        [JsonProperty("periodicity")]
        public int Periodicity { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonIgnore]
        public bool IsFailed { get; set; }
        [JsonIgnore]
        public DateTime EndDateTime { get; set; }

        public Task()
        {
            Id = -1;
            Name = "Task";
            EndDate = "";
            EndTime = "";
            Periodicity = 0;
            Description = "";
            IsFailed = false;
            EndDateTime = new DateTime();
        }

        public Task(int Id)
        {
            this.Id = Id;
            Name = "";
            EndDate = "";
            EndTime = "";
            Periodicity = 0;
            Description = "";
            IsFailed = false;
            EndDateTime = new DateTime();
        }

        public Task(int Id, string Name, string EndDate, string EndTime, int Periodicity, string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.EndDate = EndDate;
            this.EndTime = EndTime;
            this.Periodicity = Periodicity;
            this.Description = Description;
            this.IsFailed = false;
            var cultureInfo = new CultureInfo("ru-RU");
            this.EndDateTime = DateTime.Parse(EndDate + " " + EndTime, cultureInfo);
            DateTime today = DateTime.Today;
            if (this.EndDateTime < today)
                this.IsFailed = true;
        }

        public void UpdateDateTime()
        {
            var cultureInfo = new CultureInfo("en-us");
            this.EndDateTime = DateTime.Parse(this.EndDate + " " + this.EndTime, cultureInfo);
        }

    }
}
