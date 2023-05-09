using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{

    [Keyless]
    public class UserData
    {

        public string Name { get; set; }
      public  int id { get; set; }
        public  string vtype { get; set; }
        public  string time { get; set; }
        public  string loc { get; set; }


    }
}
