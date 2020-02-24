using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace DataLayer.Business
{
    public class FileManager
    {

        /// <summary>
        /// Gets un arreglo de bytes que representa una imagen o archivo
        /// </summary>
        /// <param name="imagePath"> la direccion del archivo </param>
        /// <returns></returns>
        public byte[] GetStream(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                byte[] imageByteArray = File.ReadAllBytes(imagePath);
                return imageByteArray;
            }
            else
                return null;
        }
        public byte[] GetStream(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        /// <summary>
        /// Gets el BitMap (osea el archivo) del stream
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public Bitmap GetFile(byte[] stream)
        {
            using (MemoryStream ms = new MemoryStream(stream))
            {
                Bitmap fileAsBitmap = new Bitmap(ms);
                return fileAsBitmap;
            }

        }
    }
}
