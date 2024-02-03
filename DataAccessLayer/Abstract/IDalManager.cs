using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDalManager
    {
        IAboutDal About { get; }
        IAbout2Dal About2Dal { get; }
        IContactDal Contact { get; }
        IDestinationDal Destination { get; }
        IFeature1Dal Feature1 { get; }
        IFeatureDal Feature { get; }
        IGuideDal Guide { get; }
        INewsletterDal Newsletter { get; }
        ISubAboutDal SubAbout { get; }
        ITestimonialDal Testimonial { get; }
        ICommentDal Comment { get; }
        IReservationDal Reservation { get; }
    }
}
