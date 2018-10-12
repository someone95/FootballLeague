using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhonebookNET.ViewModels.Footballers
{
    public class FootballersEditVM
    {
        public int Id { get; set; }
        public List<Team> Teams { get; set; }
        public int TeamId { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsReferee { get; set; }
    }
}