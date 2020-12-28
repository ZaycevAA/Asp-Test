using Calendar.core.interfaces;
using Calendar.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Calendar.controllers
{
    public class PhotoController:Controller
    {
        private readonly IPhoto _photos;
        private readonly IPhotoType _phototypes;
        private readonly ITypes _types;

        public PhotoController(IPhoto photos, IPhotoType phototypes, ITypes types)
        {
            _photos = photos;
            _phototypes = phototypes;
            _types = types;
        }
        public ViewResult List()
        {
            ViewBag.Title="А вот!";
            return View(new PhotoList() { Potos=_photos.Photos, Titel="Фото" });
        }
    }
}
