using System;
using IdScanMobileDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdScanMobileDemo.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index(Guid? sessionId)
        {
            if (!IsValidSessionId(sessionId))
            {
                return HandleInvalidSessionId();
            }

            return View(new SessionModel(sessionId.Value));
        }

        public IActionResult Camera(Guid? sessionId)
        {
            if (!IsValidSessionId(sessionId))
            {
                return HandleInvalidSessionId();
            }

            return View(new SessionModel(sessionId.Value));
        }

        private bool IsValidSessionId(Guid? sessionId)
        {
            return sessionId != null && sessionId.Value != Guid.Empty;
        }

        private IActionResult HandleInvalidSessionId()
        {
            return RedirectToAction(nameof(Index), new { sessionId = Guid.NewGuid() });
        }
    }
}
