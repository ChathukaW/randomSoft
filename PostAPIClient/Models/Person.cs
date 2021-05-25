using System;
using System.Collections.Generic;
using System.Text;

namespace PostAPIClient.Models
{
    class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IList<Post> Posts { get; set; } = new List<Post>();
    }
}
