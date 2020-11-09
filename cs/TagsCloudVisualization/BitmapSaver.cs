﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace TagsCloudVisualization
{
    class BitmapSaver
    {
        public void Save(Bitmap bitmap, string directoryPath = ".")
        {
            if (!Directory.Exists(directoryPath))
                throw new ArgumentException("This directory does not exist.");
            var filePath = Path.GetFullPath(CreateFilePath(directoryPath));
            bitmap.Save(filePath, ImageFormat.Png);
            Console.WriteLine(@$"Tag cloud visualization saved to file <{filePath}>");
        }

        private string CreateFilePath(string directoryPath)
        {
            var fileName = DateTime.Now.ToString("yyyyMMddhhmmss");;
            return $@"{directoryPath}\{fileName}.png";
        }
    }
}
