using NippySoft.FaceDetect.Azure.Core.Entities;
using NippySoft.FaceDetect.Azure.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static NippySoft.FaceDetect.Azure.Core.Entities.ServerApiAzure;

namespace NippySoft.FaceDetect.Azure
{
    public class FaceDetect : IFaceDetect, IDisposable
    {
        public FaceDetect(LocationServerApiAzure locationServer)
        {
            UriApiAzure = ServerApiAzure.GetServerApiFromLocationServerApiAzure(locationServer);
        }

        #region Properties
        private string UriApiAzure { get; set; }
        public string SuscriptionKey { get; set; }
        public bool ReturnFaceId { get; set; } = true;
        public bool ReturnFaceLandmarks { get; set; } = false;
        public bool ShowInFaceAttributes_Age { get; set; } = true;
        public bool ShowInFaceAttributes_Gender { get; set; } = true;
        public bool ShowInFaceAttributes_HeadPose { get; set; } = true;
        public bool ShowInFaceAttributes_Smile { get; set; } = true;
        public bool ShowInFaceAttributes_FacialHair { get; set; } = true;
        public bool ShowInFaceAttributes_Glasses { get; set; } = true;
        public bool ShowInFaceAttributes_Emotion { get; set; } = true;
        public bool ShowInFaceAttributes_Hair { get; set; } = true;
        public bool ShowInFaceAttributes_Makeup { get; set; } = true;
        public bool ShowInFaceAttributes_Occlusion { get; set; } = true;
        public bool ShowInFaceAttributes_Accessories { get; set; } = true;
        public bool ShowInFaceAttributes_Blur { get; set; } = true;
        public bool ShowInFaceAttributes_Exposure { get; set; } = true;
        public bool ShowInFaceAttributes_Noise { get; set; } = true;
        #endregion

        #region Private Methods
        private string GetParamsForApi()
        {
            StringBuilder builderParams = new StringBuilder();

            //Example:
            //"returnFaceId=true&returnFaceLandmarks=false&returnFaceAttributes=age,gender,headPose,smile,facialHair
            //,glasses,emotion,hair,makeup,occlusion,accessories,blur,exposure,noise"

            builderParams.AppendFormat("?returnFaceId={0}", ReturnFaceId.ToString().ToLower());
            builderParams.AppendFormat("&returnFaceLandmarks={0}", ReturnFaceLandmarks.ToString().ToLower());
            builderParams.Append("&returnFaceAttributes=");

            List<string> listaFaceAttributes = new List<string>();

            #region Validations Show Face Attributes
            if (ShowInFaceAttributes_Age)
                listaFaceAttributes.Add("age");

            if (ShowInFaceAttributes_Gender)
                listaFaceAttributes.Add("gender");

            if (ShowInFaceAttributes_HeadPose)
                listaFaceAttributes.Add("headPose");

            if (ShowInFaceAttributes_Smile)
                listaFaceAttributes.Add("smile");

            if (ShowInFaceAttributes_FacialHair)
                listaFaceAttributes.Add("facialHair");

            if (ShowInFaceAttributes_Glasses)
                listaFaceAttributes.Add("glasses");

            if (ShowInFaceAttributes_Emotion)
                listaFaceAttributes.Add("emotion");

            if (ShowInFaceAttributes_Hair)
                listaFaceAttributes.Add("hair");

            if (ShowInFaceAttributes_Makeup)
                listaFaceAttributes.Add("makeup");

            if (ShowInFaceAttributes_Occlusion)
                listaFaceAttributes.Add("occlusion");

            if (ShowInFaceAttributes_Accessories)
                listaFaceAttributes.Add("accessories");

            if (ShowInFaceAttributes_Blur)
                listaFaceAttributes.Add("blur");

            if (ShowInFaceAttributes_Exposure)
                listaFaceAttributes.Add("exposure");

            if (ShowInFaceAttributes_Noise)
                listaFaceAttributes.Add("noise");

            #endregion


            builderParams.Append(string.Join(",", listaFaceAttributes));

            return builderParams.ToString();

        }
        private void ValidateSuscriptionKeyAndUriApi()
        {
            if (string.IsNullOrEmpty(SuscriptionKey))
                throw new Exception("Set the SuscriptionKey");

            if (string.IsNullOrEmpty(UriApiAzure))
                throw new Exception("Set the UriApiAzure");
        }
        private byte[] GetImageAsByteArray(string imageFilePath)
        {
            using (FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }
        }

        private async Task<ResponseFaceDetect> AnalysisRequest(string imageFilePath)
        {
            return await MakeAnalysisRequest(GetImageAsByteArray(imageFilePath));
        }
        private async Task<ResponseFaceDetect> AnalysisRequest(byte[] imageBytes)
        {
            return await MakeAnalysisRequest(imageBytes);
        }
        private async Task<ResponseFaceDetect> MakeAnalysisRequest(byte[] imageBytes)
        {
            ResponseFaceDetect response = new ResponseFaceDetect();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", SuscriptionKey);
                    string requestParameters = GetParamsForApi();

                    string uri = $"{UriApiAzure}{requestParameters}";

                    HttpResponseMessage responseApi;

                    using (ByteArrayContent content = new ByteArrayContent(imageBytes))
                    {
                        content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                        responseApi = await client.PostAsync(uri, content);
                        string contentString = await responseApi.Content.ReadAsStringAsync();

                        response.JsonFromApiAzure = contentString;
                        response.Faces = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Face>>(contentString); ;
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Error = ex;
            }

            return response;
        }

        #endregion

        #region Public Methods
        public async Task<ResponseFaceDetect> GetFacesFromBytesImage(byte[] imageBytes)
        {
            ValidateSuscriptionKeyAndUriApi();
            return await AnalysisRequest(imageBytes);
        }


        public async Task<ResponseFaceDetect> GetFacesFromImageInDisk(string imageFilePath)
        {
            ValidateSuscriptionKeyAndUriApi();
            return await AnalysisRequest(imageFilePath);
        }

        public void Dispose()
        {
            UriApiAzure = string.Empty;
            SuscriptionKey = string.Empty;
        }
        #endregion
    }
}
