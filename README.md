# NippySoft.FaceDetect.Azure

Proper use for the Azure facial recognition SDK

## Getting Started

Download the code compile and go. (Visual Studio 2017).

### Prerequisites

Net Standard, Net Core, Net Framework 4.5

```
Give examples
```

### Use The Code

**using (FaceDetect faceDetect = new FaceDetect(LocationServerApiAzure.EastUS))
{
      faceDetect.SuscriptionKey = "Api Key Azure Cognitive Services";
      ResponseFaceDetect responseFaceDetect = faceDetect.GetFacesFromImageInDisk("Path The Image").Result;
              
 }
**
## Authors

* **Javier Enrique Joya Aroca (NippySoft)**

See also the list of [contributors](https://github.com/nippysoft/NippySoft.FaceDetect.Azure/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

