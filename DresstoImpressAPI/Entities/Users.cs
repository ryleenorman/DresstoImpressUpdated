using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DresstoImpressAPI.Entities
{
    public class Users
    {
            public int UserID { get; set; }
            public DateTime UserDoB { get; set; }
            public string UserOccupation { get; set; }
        }
    }
}
