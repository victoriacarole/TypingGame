using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Typing.Pages
{
    public class GameModel : PageModel
    {
        public string thisPlayer => (string)TempData[nameof(thisPlayer)];

        public void OnGet()
        {
            TempData["thisPlayer"] = UserStatus.currentUser;

        }
    }
}
