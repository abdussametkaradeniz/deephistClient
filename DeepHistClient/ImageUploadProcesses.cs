using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepHistClient
{
    class ImageUploadProcesses
    {
        public List<ImageInfoHolderForJson> ImageInfoHolderForJson = new List<ImageInfoHolderForJson>();




        public void driverMetot()
        {

        }

        public async Task uploadImagesToAmazons3(string waitingForUploadImagePath)
        {
            try
            {
                string url = "http://deephistapps.com/api/image/UploadImageToAmazon";
                var client = new RestClient(url);
                var request = new RestRequest();
                var strImageDto1 = new
                {
                    //base64string = ImagetoBase64(imagepath),
                    ImageName = "abc.jpeg",
                    ProjectId = int.Parse(ProjeSecimEkrani.choosenProject),
                    StainId = 1,
                    MagnificationImageId = 1,
                    MicroscopeId = 1,
                    CustomerId = int.Parse(ProjeSecimEkrani.customerId)
                };
                string strImageDto = JsonConvert.SerializeObject(strImageDto1);
                //request.AddHeader("Content-Type", "multipart/form-data");
                request.AddFile(Path.GetFileNameWithoutExtension("Image10"), waitingForUploadImagePath);
                request.AddParameter("StrImageDto", strImageDto);
                request.AlwaysMultipartFormData = true;
                var response = await client.PostAsync(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void base64toImage()
        {

        }

        public string ImagetoBase64(string imagepath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(imagepath);
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }

        public string createImageName()
        {
            string fileName = "1_1_" + DateTime.Now.ToString("dd_MM_dd_yyy_HH_mm_ss_ffff") + ".jpeg";
            return fileName;
        }

        public void writeTxt()
        {

        }

        public void readTxt()
        {

        }

        //internet varsa upload ettiricem yoksa eğer json dosyasına çevirip cache içerisine kaydedicem







    }
}
