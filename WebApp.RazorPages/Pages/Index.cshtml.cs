using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.RazorPages.Pages.Components;

namespace WebApp.RazorPages.Pages
{
    public class IndexModel : PageModel
    {

        public List<FeaturesBoxViewModel> Features { get; set; } =
            [
                new FeaturesBoxViewModel {IdName = "box1", Icon = "images/icons/chat.svg", Title = "Comments on Tasks", Description = "Id mollis consecetur egestas egestas suspendisse blandit justo." },
                new FeaturesBoxViewModel {IdName = "box2", Icon = "images/icons/presentation.svg", Title = "Task Analytic", Description = "Non imperdiet facilisis nulla tellus Morbi scelerisque eget adipiscing vulputate." },
                new FeaturesBoxViewModel {IdName = "box3", Icon = "images/icons/add-group.svg", Title = "Mulitple Assignees", Description = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris." },
                new FeaturesBoxViewModel {IdName = "box4", Icon = "images/icons/bell.svg", Title = "Notifications", Description = "Diam suspendisse velit cras ac. Lobortis diam volutpat, eget pellentesque viverra." },
                new FeaturesBoxViewModel {IdName = "box5", Icon = "images/icons/tests.svg", Title = "Sections & Subtasks", Description = "Mi feugiat hac id in. Sit elit placerat lacus nibh lorem ridiculus lectus." },
                new FeaturesBoxViewModel {IdName = "box6", Icon = "images/icons/shield.svg", Title = "Data Security", Description = "Aliquam malesuada neque eget elit nulla vestibulum nunc cras." },
            ];

        public void OnGet()
        {
        }
    }
}
