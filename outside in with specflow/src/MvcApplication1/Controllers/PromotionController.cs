using System;
using System.Linq;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class PromotionController : Controller
    {
        private readonly IPromotionRepository promotionRepository;
        private readonly IPrizeWinningRecorder prizeWinningRecorder;

        public PromotionController(IPromotionRepository promotionRepository,
            IPrizeWinningRecorder prizeWinningRecorder)
        {
            this.promotionRepository = promotionRepository;
            this.prizeWinningRecorder = prizeWinningRecorder;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index(PromotionForm promotionForm)
        {
            var promotion = promotionRepository.GetPromotions()
                .FirstOrDefault(p => p.PromotionCode == promotionForm.PromotionCode);

            if (promotion == null)
                return RedirectToAction("Failure");

            prizeWinningRecorder.RecordWin(promotionForm.FirstName + " " + promotionForm.LastName,
                promotionForm.Email, promotionForm.PromotionCode);

            return RedirectToAction("Confirmation", new {PrizeName = promotion.Prize});
        }
    }
}