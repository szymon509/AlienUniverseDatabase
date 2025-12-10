using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AlienUniverseDatabase.models;

namespace AlienUniverseDatabase
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Characters> Postacie { get; set; }

        private Characters? _wybranaPostac;
        public Characters? WybranaPostac
        {
            get => _wybranaPostac;
            set { _wybranaPostac = value; OnPropertyChanged(); }
        }

        // --- POLA DO DODAWANIA NOWEJ POSTACI ---
        // To są "pudełka", w które wpisujesz tekst w formularzu
        private string? _noweImie;
        public string? NoweImie { get => _noweImie; set { _noweImie = value; OnPropertyChanged(); } }

        private string? _nowaRola;
        public string? NowaRola { get => _nowaRola; set { _nowaRola = value; OnPropertyChanged(); } }
        
        private string? _nowaRasa;
        public string? NowaRasa { get => _nowaRasa; set { _nowaRasa = value; OnPropertyChanged(); } }

        // --- KONSTRUKTOR ---
        public MainWindowViewModel()
        {
            Postacie = new ObservableCollection<Characters>();
            ZaladujDaneStartowe();
        }

        // --- METODA DODAJĄCA POSTAĆ (To robi przycisk) ---
        public void DodajPostac()
        {
            // Sprawdzamy, czy wpisano chociaż imię, żeby nie dodawać pustych
            if (!string.IsNullOrWhiteSpace(NoweImie))
            {
                var nowa = new Characters
                {
                    ImieNazwisko = NoweImie,
                    Rola = NowaRola ?? "Nieznana",
                    Rasa = NowaRasa ?? "Nieznana",
                    // Resztę pól można uzupełnić później lub dodać więcej TextBoxów
                    Charakterystyka = "Postać dodana ręcznie.",
                    funkcja = "Brak danych",
                    Los = "Nieznany"
                };

                Postacie.Add(nowa);

                // Czyścimy pola po dodaniu, żeby były gotowe na kolejną postać
                NoweImie = "";
                NowaRola = "";
                NowaRasa = "";
            }
        }

        private void ZaladujDaneStartowe()
        {
            Postacie.Add(new Characters { ImieNazwisko = "Ellen Ripley", Rola = "Bohaterka", Rasa = "Człowiek", Charakterystyka = "Twarda" });
            Postacie.Add(new Characters { ImieNazwisko = "Xenomorph", Rola = "Potwór", Rasa = "Obcy", Charakterystyka = "Agresywny" });
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}