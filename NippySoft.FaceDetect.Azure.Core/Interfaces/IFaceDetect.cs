using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NippySoft.FaceDetect.Azure.Core.Entities;

namespace NippySoft.FaceDetect.Azure.Core.Interfaces
{
    public interface IFaceDetect
    {
        Task<ResponseFaceDetect> GetFacesFromBytesImage(byte[] bytesImage);
        Task<ResponseFaceDetect> GetFacesFromImageInDisk(string pathImage);
    }
}
