using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DeepHistClient
{
    class ImageUploadProcesses
    {
        public List<ImageInfoHolderForJson> _imageinfoholderforjson = new List<ImageInfoHolderForJson>();
        public string CacheImgPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName, "cache");
        Boolean isCacheEmpty = true;
        List<ImageUploadToAmazonS3> imageinfosforupload = new List<ImageUploadToAmazonS3>();
        List<files> files = new List<files>();



        public async Task uploadImagesToAmazons3()
        {
            try
            {

                var Files = File.ReadAllBytes("F:\\deephistPath\\image.jpg");
                string json = new JavaScriptSerializer().Serialize(new
                {
                    ImageName = "abc.jpeg",
                    ProjectId = 1,
                    StainId = 1,
                    MagnificationImageId = 1,
                    MicroscopeId = 1,
                    CustomerId = 1,
                });

                MultipartFormDataContent content = new MultipartFormDataContent();
                ByteArrayContent imageContent = new ByteArrayContent(Files);
                //string strImageDtoJsson1 = JsonConvert.SerializeObject(contentstrImageDto);
                StringContent strImageDto = new StringContent(json);

                content.Add(imageContent, "file", "abc.jpeg");
                content.Add(strImageDto, "strImageDto");
                var httpClient = new HttpClient();
                //var response = await httpClient.PostAsync("https://localhost:44398/api/image/UploadImageToAmazon", content);
               

                var response = await httpClient.PostAsync("https://deephistapps.com/api/image/UploadImageToAmazon", content);



                //using (HttpClient httpClient = new HttpClient())
                //{
                //    using (var multipartfromcontent = new MultipartFormDataContent())
                //    {
                //        var filestreamcontent = new StreamContent(File.OpenRead("F:\\deephistPath\\image.jpg"));
                //        multipartfromcontent.Add(filestreamcontent, name: "file");
                //        var contentStrings = "{\"imageName\": \"abc.jpeg\",\"projectId\": 1,\"stainId\": 1,\"magnificationImageId\": 2,\"microscopeId\": 1,\"customerId\": 1,}";
                //        //var strImageDto1 = JsonConvert.SerializeObject(contentStrings);
                //        var strImageDto = new StringContent(contentStrings, Encoding.UTF8, "application/json");
                //        multipartfromcontent.Add(strImageDto, name: "strImageDto");
                //        System.Net.ServicePointManager.ServerCertificateValidationCallback +=
                //                delegate (object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                //                    System.Security.Cryptography.X509Certificates.X509Chain chain,
                //                    System.Net.Security.SslPolicyErrors sslPolicyErrors)
                //                        {
                //                            return true; // ** Always accept
                //                        };
                //        var response = await httpClient.PostAsync("http://deephistapps.com/api/image/UploadImageToAmazon", multipartfromcontent);
                //        response.EnsureSuccessStatusCode();
                //    }
                //}




                //                var response = await 

                //                var client = new RestClient(url);             
                //                var request = new RestRequest();
                //                request.AddFile("file", "F:\\deephistPath\\image.jpg");
                //                //request.AddParameter("StrImageDto", strImageDto.ToString());
                //                request.AddParameter("strImageDto", "{\"imageName\": \"abc.jpeg\",\"projectId\": 1,\"stainId\": 1,\"magnificationImageId\": 2,\"microscopeId\": 1,\"customerId\": 1,}");              
                //                request.AlwaysMultipartFormData = true;
                //                System.Net.ServicePointManager.ServerCertificateValidationCallback +=
                //delegate (object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                //                        System.Security.Cryptography.X509Certificates.X509Chain chain,
                //                        System.Net.Security.SslPolicyErrors sslPolicyErrors)
                //{
                //    return true; // ** Always accept
                //};
                //                var response = await client.PostAsync(request);
                //if (response.StatusCode == System.Net.HttpStatusCode.OK)
                //{

                //    //DOSYAYI SİLECEĞİMİZ KISIM BURADA
                //    //JSON DOSYASIYLA BERABER RESMİ SİLİP BİTİRECEĞİZ.

                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

      
        public async Task readJson()
        {
            DirectoryInfo d = new DirectoryInfo(CacheImgPath+"\\");
            imageinfosforupload.Clear();
            foreach (var file in d.GetFiles())
            {              
                    if (file.Extension == ".json")
                    {
                        using (StreamReader r = new StreamReader(file.FullName))
                        {
                            string json = r.ReadToEnd();
                            imageinfosforupload = JsonConvert.DeserializeObject<List<ImageUploadToAmazonS3>>(json);
                            await uploadImagesToAmazons3();
                        }
                    }               
            }
        }

        //public async Task uploadDriverMetotAsync()
        //{
        //    string s = "a";
        //    await readJson();
        //    await uploadImagesToAmazons3();
        //}

        public string createImageName()
        {
            string fileName = ProjeSecimEkrani.customerId.ToString()+"_" + ProjeEkrani.choosenProjectId+"_" + DateTime.Now.ToString("dd_MM_dd_yyy_HH_mm_ss_ffff") + ".jpeg";
            return fileName;
        }

        /// <summary>
        /// 
        /// 
        /// 
        /// İNTERNET YOKKEN PLANLANAN METOTLAR AŞAĞIDA YER ALMAKTADIR.
        /// 
        /// 
        /// 
        /// </summary>

        public string ImagetoBase64(string imagepath)
        {
            string imagepathWithimagename = imagepath + ".jpeg";
            byte[] imageBytes = System.IO.File.ReadAllBytes(imagepathWithimagename);
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }

        //json string oluşturan metot
        public void CreateJsonString(string imagepath, string imagename)
        {
            _imageinfoholderforjson.Clear();
            _imageinfoholderforjson.Add(new ImageInfoHolderForJson()
            {
                imageName = imagename,
                projectId = int.Parse(ProjeEkrani.choosenProjectId),
                stainId = 1,
                magnificationImageId = 1,
                microscopeId = 1,
                customerId = int.Parse(ProjeSecimEkrani.customerId)
            });
            string json = JsonConvert.SerializeObject(_imageinfoholderforjson.ToArray(), Formatting.Indented);
            File.WriteAllText(CacheImgPath + "\\" + imagename + ".json", json);
        }

        //bütün cache içerisinde gezinen metot      
        public void fillJsonFile()
        {
            DirectoryInfo d = new DirectoryInfo(CacheImgPath);
            if (IsCacheEmpty())
            {
                foreach (var file in d.GetFiles())
                {
                    if (!file.Extension.Equals(".json"))
                    {
                        if (!File.Exists(CacheImgPath + "\\" + Path.GetFileNameWithoutExtension(file.Name).ToString() + ".json"))
                        {
                            CreateJsonString(CacheImgPath, Path.GetFileNameWithoutExtension(file.Name));
                        }
                    }
                }
            }
        }

        public bool IsCacheEmpty()
        {
            if (Directory.GetFiles(CacheImgPath) != null)
            {
                isCacheEmpty = true;
            }
            else
            {
                isCacheEmpty = false;
            }
            return isCacheEmpty;
        }

       
    }
}
