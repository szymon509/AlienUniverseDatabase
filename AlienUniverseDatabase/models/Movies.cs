using System.Collections.Generic;

namespace AlienUniverseDatabase.models
{
    public class Movies
    {
        public string? TytułOryginalny { get; set; }
        public string? TytułPolski { get; set; }
        public int RokPremiery { get; set; }
        public string? Reżyser { get; set; }
        public string? Scenariusz { get; set; }
        public string? Gatunek { get; set; }
        public int CzasTrwania { get; set; }
        public int Ocena { get; set; }
        public string? GłównePostacie { get; set; }
        public string? Statek { get; set; }
        public string? Opis { get; set; }
        public string? Ciekawostka { get; set; }

        public List<Characters> Postacie { get; set; } = new();

    }
    
}