using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExercise
{

    public enum Category
    {
           Dairy=1,
           Meat,
           Fruits,
           Sweets

    }
    public class Product
    {
        public Category Categoryf { get ; set ; }
        public int Price { get; set; }

        public string Name { get; set; }
        //public Product(int price, string name, Category Category)
        //{
        //    Name = name;
        //    Price = price;
        //    Category = Category;
        //}
    }
}
