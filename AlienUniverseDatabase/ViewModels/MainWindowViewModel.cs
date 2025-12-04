using System.Collections.ObjectModel;
using AlienUniverseDatabase.models;

namespace AlienUniverseDatabase.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Movies> Movies { get; } = new()
    {
        new Movies()
        {
            TytułOryginalny = "Alien", TytułPolski =  "Alien", RokPremiery = 1979, Reżyser = "Ridley Scott", Scenariusz = "Dan O'Bannon", Gatunek = "Sci-Fi / Horror", CzasTrwania = 117, Ocena = 8, GłównePostacie = "Ellen Ripley, Dallas, Ash, Lambert, Kane"},
    };
}