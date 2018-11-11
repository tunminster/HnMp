using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HnMp.Model
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
