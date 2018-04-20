using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ElectronNET.API;
using ElectronNET.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PlayerElectronBasic.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var musicPath = await Electron.App.GetPathAsync(PathName.music);
            var mp3Files = Directory.GetFiles(musicPath, "*.mp3", SearchOption.TopDirectoryOnly);
            var mp4Files = Directory.GetFiles(musicPath, "*.mp4", SearchOption.TopDirectoryOnly);

            var musicFiles = new List<string>();
            musicFiles.AddRange(mp3Files);
            musicFiles.AddRange(mp4Files);

            return View(musicFiles);
        }
    }
}