using DataAccess.Data;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly IUserData _data;
        public IEnumerable<UserModel> _usr  {get;  set; }
        public string _TrekName { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IUserData data)
        {
            _logger = logger;
            _data = data;
        }

        public async Task OnGetAsync()
        {
            _usr = await _data.GetUsers();
            _TrekName = "test";
        }
    }
}
