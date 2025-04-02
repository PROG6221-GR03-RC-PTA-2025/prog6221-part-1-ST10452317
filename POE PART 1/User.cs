using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_1
{
    internal class User
    {
        public string name { get; set; }
        public string userId { get; set; }

        public DateTime lastInteration { get; set; }
        /*public User(string name, string useId) //Constructor i chose this one as it is asking the user to insset not the auto generator
        {
            this.name = name;
            this.useId = useId;
        }Y*/
    }
}
