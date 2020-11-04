using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

// Handling the orientation Exif tag in images using C#
// http://cyotek.com/blog/handling-the-orientation-exif-tag-in-images-using-csharp
// Copyright © 2019 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the Creative Commons Attribution 4.0 International License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

// Found this example useful? 
// https://www.paypal.me/cyotek

namespace RackKeyV07
{
  internal static class ImageExtensions
  {
    #region Constants

    public const int ExifOrientationTagId = 0x112;

    #endregion

    #region Static Methods

    public static void NormalizeOrientation(this Image image)
    {
      // https://stackoverflow.com/a/23400751/148962
      if(image!= null)
      if (Array.IndexOf(image.PropertyIdList, ExifOrientationTagId) > -1)
      {
        int orientation;

        orientation = image.GetPropertyItem(ExifOrientationTagId).Value[0];

        if (orientation >= 1 && orientation <= 8)
        {
          switch (orientation)
          {
            case 2:
              image.RotateFlip(RotateFlipType.RotateNoneFlipX);
              break;
            case 3:
              image.RotateFlip(RotateFlipType.Rotate180FlipNone);
              break;
            case 4:
              image.RotateFlip(RotateFlipType.Rotate180FlipX);
              break;
            case 5:
              image.RotateFlip(RotateFlipType.Rotate90FlipX);
              break;
            case 6:
              image.RotateFlip(RotateFlipType.Rotate90FlipNone);
              break;
            case 7:
              image.RotateFlip(RotateFlipType.Rotate270FlipX);
              break;
            case 8:
              image.RotateFlip(RotateFlipType.Rotate270FlipNone);
              break;
          }

          image.RemovePropertyItem(ExifOrientationTagId);
        }
      }
    }

    public static void SaveAsJpeg(this Image image, string fileName, int compressionLevel)
    {
      using (Stream stream = File.Create(fileName))
      {
        image.SaveAsJpeg(stream, compressionLevel);
      }
    }

    public static void SaveAsJpeg(this Image image, Stream stream, int compressionLevel)
    {
      ImageCodecInfo jpegEncoder;
      Encoder qualityEncoder;
      EncoderParameters encoderParameters;

      qualityEncoder = Encoder.Quality;
      jpegEncoder = GetEncoder(ImageFormat.Jpeg);
      encoderParameters = new EncoderParameters(1);
      encoderParameters.Param[0] = new EncoderParameter(qualityEncoder, compressionLevel);

      image.Save(stream, jpegEncoder, encoderParameters);
    }

    private static ImageCodecInfo GetEncoder(ImageFormat format)
    {
      ImageCodecInfo[] codecs;
      ImageCodecInfo result;

      codecs = ImageCodecInfo.GetImageEncoders();
      result = null;

      for (int i = 0; i < codecs.Length; i++)
      {
        ImageCodecInfo codec;

        codec = codecs[i];

        if (codec.FormatID == format.Guid)
        {
          result = codec;
          break;
        }
      }

      return result;
    }

    #endregion
  }
}
