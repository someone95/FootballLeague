using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhonebookNET.ViewModels.Footballers
{
    public class FootballersIndexVM
    {
        public List<Footballer> Footballers { get; set; }
        public List<Team> Teams { get; set; }
    }
}