using AutoMapper;
using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Presentation;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using TraversalCore.Areas.Admin.Models;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Announcement/")]
    public class AnnouncementController : Controller
    {
        private readonly IServiceManager _serviceManager;
        private readonly IMapper _mapper;

        public AnnouncementController(IServiceManager serviceManager, IMapper mapper)
        {
            _serviceManager = serviceManager;
            _mapper = mapper;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDto>>(_serviceManager.AnnouncementService.TGetList());
            return View(values);
        }
        [HttpGet]
        [Route("AddAnnouncement")]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        [Route("AddAnnouncement")]
        public IActionResult AddAnnouncement(AnnouncementAddDto announcementAddDto)
        {
            if (ModelState.IsValid)
            {
                _serviceManager.AnnouncementService.TInsert(new Announcement()
                {
                    Content = announcementAddDto.Content,
                    Title = announcementAddDto.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });

                return RedirectToAction("Index");
            }
            return View(announcementAddDto);
        }
        [Route("DeleteAnnouncement/{id}")]
        public IActionResult DeleteAnnouncement(int id)
        {
            var value = _serviceManager.AnnouncementService.TGetById(id);
            _serviceManager.AnnouncementService.TDelete(value);

            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("UpdateAnnouncement/{id}")]
        public IActionResult UpdateAnnouncement(int id)
        {
            var value = _mapper.Map<AnnouncementUpdateDto>(_serviceManager.AnnouncementService.TGetById(id));

            return View(value);
        }
        [HttpPost]
        [Route("UpdateAnnouncement/{id}")]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDto announcementUpdateDto)
        {
            if (ModelState.IsValid)
            {
                _serviceManager.AnnouncementService.TUpdate(new Announcement()
                {
                    AnnouncementId = announcementUpdateDto.AnnouncementId,
                    Content = announcementUpdateDto.Content,
                    Title = announcementUpdateDto.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }

            return View(announcementUpdateDto);
        }
    }
}
