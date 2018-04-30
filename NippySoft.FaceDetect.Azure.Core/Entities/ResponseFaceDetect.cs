using System;
using System.Collections.Generic;
using System.Text;

namespace NippySoft.FaceDetect.Azure.Core.Entities
{
    public class ResponseFaceDetect
    {
        public List<Face> Faces { get; set; } = new List<Face>();
        public Exception Error { get; set; } = null;
        public bool IsSuccess { get; set; } = true;
        public string JsonFromApiAzure { get; set; } = string.Empty;
    }
}
