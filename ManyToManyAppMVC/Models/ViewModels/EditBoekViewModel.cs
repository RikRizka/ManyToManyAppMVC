using ManyToManyApp.Enums;

namespace ManyToManyApp.Models.ViewModels
{
    public class EditBoekViewModel
    {
        public int BookId { get; set; }
        public string Titel { get; set; }
        public List<int> SelectedGenres { get; set; }
        public bool IsAvalible { get; set; }
        public bool IsNewRelease { get; set; }
        public bool IsBestSeller { get; set; }
        public BindingType? BindingType { get; set; }
        public List<Auteur> Auteurs { get; set; }
        public List <Genre> Genres { get; set; }
        public IFormFile? Afbeelding { get; set; }
        public string AfbeeldingPad { get; set; } ="/imgaes/default.jpg";
    }
}
