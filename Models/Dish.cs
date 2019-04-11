using System.ComponentModel.DataAnnotations;
using System;

namespace delicious.Models
{
    public class Dish
    {
       [Key]
       public int DishId { get; set; }
            // MySQL VARCHAR and TEXT types can be represeted by a string
       public string Name { get; set; }
       public string Chef { get; set; }
       public int Tastiness { get; set; }
       public int Calories { get; set; }
       public string Description { get; set; }
            // The MySQL DATETIME type can be represented by a DateTime
       public DateTime CreatedAt {get;set;}
       public DateTime UpdatedAt {get;set;}
    }
}