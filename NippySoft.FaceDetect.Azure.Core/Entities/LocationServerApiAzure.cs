using System;
using System.Collections.Generic;
using System.Text;

namespace NippySoft.FaceDetect.Azure.Core.Entities
{
    public class ServerApiAzure
    {
        public static string GetServerApiFromLocationServerApiAzure(LocationServerApiAzure location)
        {
            switch (location)
            {
                case LocationServerApiAzure.WestUS:
                    return "https://westus.api.cognitive.microsoft.com/face/v1.0/detect/";
                case LocationServerApiAzure.WestUS2:
                    return "https://westus2.api.cognitive.microsoft.com/face/v1.0/detect/";
                case LocationServerApiAzure.EastUS:
                    return "https://eastus.api.cognitive.microsoft.com/face/v1.0/detect/";
                case LocationServerApiAzure.EastUS2:
                    return "https://eastus2.api.cognitive.microsoft.com/face/v1.0/detect/";
                case LocationServerApiAzure.WestCentralUS:
                    return "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/detect/";
                case LocationServerApiAzure.SouthCentralUS:
                    return "https://southcentralus.api.cognitive.microsoft.com/face/v1.0/detect/";
                case LocationServerApiAzure.WestEurope:
                    return "https://westeurope.api.cognitive.microsoft.com/face/v1.0/detect/";
                case LocationServerApiAzure.NorthEurope:
                    return "https://northeurope.api.cognitive.microsoft.com/face/v1.0/detect/";
                case LocationServerApiAzure.SoutheastAsia:
                    return "https://southeastasia.api.cognitive.microsoft.com/face/v1.0/detect/";
                case LocationServerApiAzure.EastAsia:
                    return "https://eastasia.api.cognitive.microsoft.com/face/v1.0/detect/";
                case LocationServerApiAzure.AustraliaEast:
                    return "https://australiaeast.api.cognitive.microsoft.com/face/v1.0/detect/";
                case LocationServerApiAzure.BrazilSouth:
                    return "https://brazilsouth.api.cognitive.microsoft.com/face/v1.0/detect/";
                default: return "";
            }
        }
        public enum LocationServerApiAzure
        {
            WestUS,//westus.api.cognitive.microsoft.com
            WestUS2,//westus2.api.cognitive.microsoft.com
            EastUS,//eastus.api.cognitive.microsoft.com
            EastUS2,//eastus2.api.cognitive.microsoft.com
            WestCentralUS,//westcentralus.api.cognitive.microsoft.com
            SouthCentralUS,//southcentralus.api.cognitive.microsoft.com
            WestEurope,//westeurope.api.cognitive.microsoft.com
            NorthEurope,//northeurope.api.cognitive.microsoft.com
            SoutheastAsia,//southeastasia.api.cognitive.microsoft.com
            EastAsia,//eastasia.api.cognitive.microsoft.com
            AustraliaEast,//australiaeast.api.cognitive.microsoft.com
            BrazilSouth,//brazilsouth.api.cognitive.microsoft.com


        }
    }
}
