using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puppy
{
    public class Dog
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string breed { get; set; }
        public string size { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public string healthStatus { get; set; }
    }
}
