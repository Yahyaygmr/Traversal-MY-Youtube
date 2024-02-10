using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IServiceManager
    {
        IAbout2Service About2Service { get; }
        IAboutService AboutService { get; }
        IContactService ContactService { get; }
        IDestinationService DestinationService { get; }
        IFeature1Service Feature1Service { get; }
        IFeatureService FeatureService { get; }
        IGuideService GuideService { get; }
        INewsletterService NewsletterService { get; }
        ISubAboutService SubAboutService { get; }
        ITestimonialService TestimonialService { get; }
        ICommentService CommentService { get; }
        IReservationService ReservationService { get; }
        IAppUserService AppUserService { get; }
        IExcelService ExcelService { get; }
        IPdfService pdfService { get; }
    }
}
