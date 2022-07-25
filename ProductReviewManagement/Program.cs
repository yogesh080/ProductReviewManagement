using System;
using System.Collections.Generic;
using System.Linq;
namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ ProductID =1,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ ProductID =2,UserID=1,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ ProductID =3,UserID=2,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ ProductID =4,UserID=2,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ ProductID =5,UserID=3,Rating=1,Review="bad",isLike=true},
                new ProductReview(){ ProductID =6,UserID=4,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ ProductID =7,UserID=4,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ ProductID =8,UserID=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ ProductID =9,UserID=10,Rating=2,Review="bad",isLike=true},
                new ProductReview(){ ProductID =10,UserID=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ ProductID =11,UserID=10,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ ProductID =12,UserID=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ ProductID =13,UserID=10,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ ProductID =14,UserID=10,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ ProductID =15,UserID=10,Rating=1,Review="bad",isLike=true}


            };
        }
    }
}