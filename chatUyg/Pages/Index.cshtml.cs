using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chatUyg.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace chatUyg.Pages
{
    public class IndexModel : PageModel
    { 
        readonly DatabaseContext _dbContext;
        public IndexModel (DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }
       public List<Message> Messages { get; set; }
        public void OnGet()
        {
            Messages = _dbContext.Messages.ToList();
        }
   
       
    }
}
