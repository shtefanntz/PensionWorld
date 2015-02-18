using System;
using System.Web.Mvc;

namespace PensionWorld.Web.Controllers
{
    using System.Collections.Generic;

    using AutoMapper;

    using NUnit.Framework;

    using PensionWorld.Domain.MasterData;
    using PensionWorld.Services;
    using PensionWorld.Web.Models;

    public class RoomsController : Controller
    {
        private readonly IRoomsService roomsService;

        public RoomsController(IRoomsService roomsService)
        {
            this.roomsService = roomsService;
        }

        public ActionResult Index()
        {
            var rooms = this.roomsService.GetAllRooms();
            var model = Mapper.Map<List<RoomViewModel>>(rooms);
            return View(model);
        }

        public ActionResult Details(Guid id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RoomViewModel model)
        {
            try
            {
                var room = Mapper.Map<Room>(model);
                this.roomsService.CreateRoom(room);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                this.ModelState.AddModelError("",ex.Message);
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rooms/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rooms/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
