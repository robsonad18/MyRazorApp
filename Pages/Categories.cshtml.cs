using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class CategoriesModel : PageModel
    {
        public List<CategoryItem> CategoryList { get; set; } = new();

        public void OnGet(
            int skip = 0,
            int take = 25)
        {
            for (int i = 0; i < 10; i++)
            {
                CategoryList.Add(new CategoryItem(
                    i + 1,
                    $"Categoria {i + 1}",
                    (i + 1) * 5.5M
                ));
            }

            CategoryList = CategoryList.Skip(skip).Take(take).ToList();
        }
    }

    public record CategoryItem(int Id, string Title, decimal Price);
}
