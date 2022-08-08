﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MouseTagProject.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public  IEnumerable<UserDate> WhenWasContacted { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Linkedin { get; set; }
        public string Comment { get; set; }
        public bool Available { get; set; }
        public IEnumerable<CandidateTechnology> Technologies { get; set; }
        public DateTime WillBeContacted { get; set; }
    }
}
