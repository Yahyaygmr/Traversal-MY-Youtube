﻿using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfDalManager : IDalManager
    {
        private readonly IAbout2Dal _about2Dal;
        private readonly IAboutDal _aboutDal;
        private readonly IContactDal _contactDal;
        private readonly IDestinationDal _destinationDal;
        private readonly IFeature1Dal _feature1Dal;
        private readonly IFeatureDal _featureDal;
        private readonly IGuideDal _guideDal;
        private readonly INewsletterDal _newsletterDal;
        private readonly ISubAboutDal _subAboutDal;
        private readonly ITestimonialDal _testimonialDal;
        private readonly ICommentDal _commentDal;
        private readonly IReservationDal _reservationDal;

        public EfDalManager(IAbout2Dal about2Dal, IAboutDal aboutDal, IContactDal contactDal, IDestinationDal destinationDal, IFeature1Dal feature1Dal, IFeatureDal featureDal, IGuideDal guideDal, INewsletterDal newsletterDal, ISubAboutDal subAboutDal, ITestimonialDal testimonialDal, ICommentDal commentDal, IReservationDal reservationDal)
        {
            _about2Dal = about2Dal;
            _aboutDal = aboutDal;
            _contactDal = contactDal;
            _destinationDal = destinationDal;
            _feature1Dal = feature1Dal;
            _featureDal = featureDal;
            _guideDal = guideDal;
            _newsletterDal = newsletterDal;
            _subAboutDal = subAboutDal;
            _testimonialDal = testimonialDal;
            _commentDal = commentDal;
            _reservationDal = reservationDal;
        }

        public IAboutDal About => _aboutDal;

        public IAbout2Dal About2Dal => _about2Dal;

        public IContactDal Contact => _contactDal;

        public IDestinationDal Destination => _destinationDal;

        public IFeature1Dal Feature1 => _feature1Dal;
        public IFeatureDal Feature => _featureDal;
        public IGuideDal Guide => _guideDal;
        public INewsletterDal Newsletter => _newsletterDal;

        public ISubAboutDal SubAbout => _subAboutDal;
        public ITestimonialDal Testimonial => _testimonialDal;

        public ICommentDal Comment => _commentDal;

        public IReservationDal Reservation => _reservationDal;
    }
}