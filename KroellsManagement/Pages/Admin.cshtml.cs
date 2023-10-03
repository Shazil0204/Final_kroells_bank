using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KroellsManagement.Pages
{
    public class AdminModel : PageModel
    {
        public void OnPost(string table)
        {
            Console.WriteLine(table);
        }
    }
}
