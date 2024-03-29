﻿using BusinessLayer.Abstract;
using BusinessLayer.Abstract.AbstractUOW;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.ConcreteUOW;
using BusinessLayer.ValidationRules.AnnouncementValidate;
using DataAccessLayer.Abstract;
using DataAccessLayer.Abstract.AbstractUOW;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class ServiceExtensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDalManager, EfDalManager>();
            services.AddScoped<IAbout2Dal, EfAbout2Dal>();
            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();
            services.AddScoped<IFeature1Dal, EfFeature1Dal>();
            services.AddScoped<IFeatureDal, EfFeatureDal>();
            services.AddScoped<IGuideDal, EfGuideDal>();
            services.AddScoped<INewsletterDal, EfNewsletterDal>();
            services.AddScoped<ISubAboutDal, EfSubAboutDal>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<IReservationDal, EfReservationDal>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IAbout2Service, About2Manager>();
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IFeature1Service, Feature1Manager>();
            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<INewsletterService, NewsletterManager>();
            services.AddScoped<ISubAboutService, SubAboutManager>();
            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();


            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();


            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();
            services.AddScoped<IUowDal, UowDal>();


        }
        public static void CustomValidator(this IServiceCollection services)
        {

            services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementAddValidator>();
            services.AddTransient<IValidator<AnnouncementUpdateDto>, AnnouncementUpdateValidator>();
        }
    }
}
