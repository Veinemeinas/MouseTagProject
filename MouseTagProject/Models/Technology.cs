﻿namespace MouseTagProject.Models
{
    public class Technology
    {
        public int Id { get; set; }
        public string TechnologyName { get; set; }

        public IEnumerable<CandidateTechnology> Candidates { get; set; }
    }
}
