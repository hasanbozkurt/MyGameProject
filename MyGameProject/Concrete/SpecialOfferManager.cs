using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject.Concrete
{
    class SpecialOfferManager : ISpecialOfferService
    {
        public void AddSpecialOffer(SpecialOffer specialOffer)
        {
            specialOffer.SpecialOfferActive = true;
            Console.WriteLine("Yeni bir kampanya " + specialOffer.SpecialOfferType + " başarıyla eklendi.");
        }

        public void RemoveSpecialOffer(SpecialOffer specialOffer)
        {
            specialOffer.SpecialOfferActive = false;
            Console.WriteLine("Kampanya " + specialOffer.SpecialOfferType + " Kaldırıldı.");
        }

        public void UpdateSpecialOffer(SpecialOffer specialOffer)
        {
            Console.WriteLine("Mevcut kampanya " + specialOffer.SpecialOfferType + " güncellendi.");
        }
    }
}
