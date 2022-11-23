using System;
using System.IO;
using SkiaSharp;

namespace CondenseTech.JBig2Decoder
{
  public static class ResizeHelpers
  {
        public static byte[] ScaleImage(byte[] file, int maxWidth, int maxHeight)
        {
            using (SKImage originalImage = SKImage.FromEncodedData(file))
            {
                var ratioX = (double)maxWidth / originalImage.Width;
                var ratioY = (double)maxHeight / originalImage.Height;
                var ratio = Math.Min(ratioX, ratioY);
                var scaledWidth = (int)(originalImage.Width * ratio);
                var scaledHeight = (int)(originalImage.Height * ratio);
                SKImageInfo scaledImageInfo = new SKImageInfo(scaledWidth, scaledHeight);
                using (SKSurface scaledSurface = SKSurface.Create(scaledImageInfo))
                {
                    using (SKCanvas scaledCanvas = scaledSurface.Canvas)
                    {
                        scaledCanvas.DrawImage(originalImage, scaledCanvas.LocalClipBounds);
                        using (SKImage scaledImage = scaledSurface.Snapshot())
                        {
                            using (SKData scaledImageData = scaledImage.Encode(SKEncodedImageFormat.Bmp, 100))
                            {
                                using (Stream scaledImageStream = scaledImageData.AsStream())
                                {
                                    byte[] buffer = new byte[scaledImageStream.Length];
                                    scaledImageStream.Read(buffer, 0, buffer.Length);
                                    return buffer;
                                }
                            }
                        }
                    }
                }
            }
        }
        public static SKImage ScaleImage(SKImage originalImage, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / originalImage.Width;
            var ratioY = (double)maxHeight / originalImage.Height;
            var ratio = Math.Min(ratioX, ratioY);
            var scaledWidth = (int)(originalImage.Width * ratio);
            var scaledHeight = (int)(originalImage.Height * ratio);
            SKImageInfo scaledImageInfo = new SKImageInfo(scaledWidth, scaledHeight);
            using (SKSurface scaledSurface = SKSurface.Create(scaledImageInfo))
            {
                using (SKCanvas scaledCanvas = scaledSurface.Canvas)
                {
                    scaledCanvas.DrawImage(originalImage, scaledCanvas.LocalClipBounds);
                    return scaledSurface.Snapshot();
                }
            }
        }

    }
}
