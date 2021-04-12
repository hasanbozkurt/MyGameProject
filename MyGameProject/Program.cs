using MyGameProject.Concrete;
using MyGameProject.Entities;
using System;

namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                CustomerID = 1,
                FirstName = "Hasan",
                LastName = "Bozkurt",
                IdentityNumber = "2728562645",
                DateOfBirth = new DateTime(1996, 9, 5)
            };

            SpecialOffer specialOffer = new SpecialOffer()
            {
                SpecialOfferID = 1,
                SpecialOfferType = "25% İndirimle",
                SpecialOfferActive = true
            };

            SpecialOfferManager specialOfferManager = new SpecialOfferManager();
            specialOfferManager.AddSpecialOffer(specialOffer);

            CustomerManager customerManager = new CustomerManager(new CustomerValidationManager());
            customerManager.SignUp(customer);

            GameStoreManager gameStoreManager = new GameStoreManager();
            gameStoreManager.BuyGames(specialOffer);

            specialOfferManager.RemoveSpecialOffer(specialOffer);

            gameStoreManager.BuyGames(specialOffer);
        }
    }
}
