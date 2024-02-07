using BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceManager
    {
        private readonly IAbout2Service _about2Service;
        private readonly IAboutService _aboutService;
        private readonly IContactService _contactService;
        private readonly IDestinationService _destinationService;
        private readonly IFeature1Service _feature1Service;
        private readonly IFeatureService _featureService;
        private readonly IGuideService _guideService;
        private readonly INewsletterService _newsletterService;
        private readonly ISubAboutService _subAboutService;
        private readonly ITestimonialService _testimonialService;
        private readonly ICommentService _commentService;
        private readonly IReservationService _reservationService;
        private readonly IAppUserService _appUserService;

        public ServiceManager(IAbout2Service about2Service, IAboutService aboutService, IContactService contactService, IDestinationService destinationService, IFeature1Service feature1Service, IFeatureService featureService, IGuideService guideService, INewsletterService newsletterService, ISubAboutService subAboutService, ITestimonialService testimonialService, ICommentService commentService, IReservationService reservationService, IAppUserService appUserService)
        {
            _about2Service = about2Service;
            _aboutService = aboutService;
            _contactService = contactService;
            _destinationService = destinationService;
            _feature1Service = feature1Service;
            _featureService = featureService;
            _guideService = guideService;
            _newsletterService = newsletterService;
            _subAboutService = subAboutService;
            _testimonialService = testimonialService;
            _commentService = commentService;
            _reservationService = reservationService;
            _appUserService = appUserService;
        }

        public IAbout2Service About2Service => _about2Service;
        public IAboutService AboutService => _aboutService;

        public IContactService ContactService => _contactService;

        public IDestinationService DestinationService => _destinationService;

        public IFeature1Service Feature1Service => _feature1Service;
        public IFeatureService FeatureService => _featureService;
        public IGuideService GuideService => _guideService;

        public INewsletterService NewsletterService => _newsletterService;

        public ISubAboutService SubAboutService => _subAboutService;

        public ITestimonialService TestimonialService => _testimonialService;

        public ICommentService CommentService => _commentService;

        public IReservationService ReservationService => _reservationService;

        public IAppUserService AppUserService => _appUserService;
    }
}
