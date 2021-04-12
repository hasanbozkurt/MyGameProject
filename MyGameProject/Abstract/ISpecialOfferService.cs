using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject.Abstract
{
    public interface ISpecialOfferService
    {
        void AddSpecialOffer(SpecialOffer specialOffer);
        void UpdateSpecialOffer(SpecialOffer specialOffer);
        void RemoveSpecialOffer(SpecialOffer specialOffer);
    }
}
