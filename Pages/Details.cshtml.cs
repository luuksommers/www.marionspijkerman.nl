using MarionSpijkerman.Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MarionSpijkerman.Website.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public Painting? Painting { get; private set; }
        public Painting? Prev { get; private set; }
        public Painting? Next { get; private set; }
        public DetailsModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int id)
        {
            Painting = PaintingsList.Get().Single(x => x.Id == id);
            Prev = PaintingsList.Get().SingleOrDefault(x => x.Id == id - 1);
            Next = PaintingsList.Get().SingleOrDefault(x => x.Id == id + 1);
        }
    }
}