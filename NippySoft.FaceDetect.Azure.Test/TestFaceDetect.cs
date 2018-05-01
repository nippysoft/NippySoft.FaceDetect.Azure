using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NippySoft.FaceDetect.Azure.Core.Entities;
using static NippySoft.FaceDetect.Azure.Core.Entities.ServerApiAzure;

namespace NippySoft.FaceDetect.Azure.Test.NetStandard
{
    [TestClass]
    public class TestFaceDetect
    {
        private byte[] GetImageAsByteArray(string imageFilePath)
        {
            using (FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }
        }

        [TestMethod]
        public void TestFaceDetectFromBytesImage()
        {
            byte[] arrBytes = GetImageAsByteArray("imageTest/img1.jpg");

            using (FaceDetect faceDetect = new FaceDetect(LocationServerApiAzure.EastUS))
            {
                faceDetect.SuscriptionKey = "Api Key Azure Cognitive Services";
                ResponseFaceDetect responseFaceDetect = faceDetect.GetFacesFromImageInDisk("Path The Image").Result;
            }

        }
    }
}
