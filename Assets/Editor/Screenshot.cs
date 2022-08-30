using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace DKrOSS.Unity.Editor
{
    public class Screenshot
    {
        [MenuItem("DKrOSS/Take Screenshot")]
        public static void Grab()
        {
            var timestamp = DateTime.Now.ToString("yyyyMMdd-HHmmss");
            var basePath = Path.Combine(".", "Assets", "Screenshots");
            var fileName = $"Screenshot_{timestamp}_{Screen.width}x{Screen.height}.png";
            var path = Path.Combine(basePath, fileName);

            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }

            ScreenCapture.CaptureScreenshot(path);
        }
    }
}
