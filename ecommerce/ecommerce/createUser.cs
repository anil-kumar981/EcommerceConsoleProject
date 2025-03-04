using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    internal class createUser
    {
        static int count = 0;
        List<Dictionary<string, dynamic>> user = new List<Dictionary<string, dynamic>>();
        public void listUser(Dictionary<string, dynamic> user)
        {
            this.user.Add(user);
        }
        public void createuser(string username)
        {
            count++;
            Dictionary<string, dynamic> user = new Dictionary<string, dynamic>
            {
            { "id", count },
            { "name", username }
        };
            listUser(user);
        }
        public void display()
        {
            foreach (var item in user)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2.ToString());
                }
            }
        }
    }
}
