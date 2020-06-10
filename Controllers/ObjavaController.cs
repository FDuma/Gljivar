using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gljivar.Service;
using Microsoft.AspNetCore.Mvc;

namespace Gljivar.Controllers
{
    public class ObjavaController : Controller
    {
        private readonly IObjavaService _objavaService;
        private readonly IKomentarService _komentarService;
        public ObjavaController(IObjavaService objavaService, IKomentarService komentarService)
        {
            _objavaService = objavaService;
            _komentarService = komentarService;
        }

        public async Task<IActionResult> Index()
        {
            var objave = await _objavaService.getObjavas();
            return View(objave);
        }
        [HttpGet]
        public async Task<IActionResult> NekaObjava(int id)
        {
            var comments = await _komentarService.getAllCommentsForObjava(id);
            comments.Reverse();
            ViewBag.komentari = comments;

            var objava = await _objavaService.getObjava(id);

            //daj sve kupce koji su komentirali ovu poslovnicu
            ViewBag.komentatori = await _objavaService.getCommenters(objava.IdObjava);

            return View(objava);
        }
        
        [HttpPost]
        public async Task<IActionResult> nekaObjava(string id, string komentar, string userId)
        {
            int idInt = int.Parse(id);
            int userIdInt = int.Parse(userId);
            //unesi novi komentar

            await _objavaService.addComment(idInt, komentar, userIdInt);

            var comm = await _komentarService.getAllCommentsForObjava(idInt);
            comm.Reverse();
            ViewBag.komentari = comm;

            var objava = await _objavaService.getObjava(idInt);

            //daj sve komentare ove objave
            ViewBag.komentatori = await _objavaService.getCommenters(objava.IdObjava);

            return View(objava);
        }
    }
}