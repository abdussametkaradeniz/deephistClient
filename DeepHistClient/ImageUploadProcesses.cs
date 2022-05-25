using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepHistClient
{
    class ImageUploadProcesses
    {
        public List<ImageInfoHolderForJson> _imageinfoholderforjson = new List<ImageInfoHolderForJson>();
        public string CacheImgPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName, "cache");
        Boolean isCacheEmpty = true;
        List<ImageUploadToAmazonS3> imageinfosforupload = new List<ImageUploadToAmazonS3>();



        public async Task uploadImagesToAmazons3()
        {
            try
            {
                
                string url = "http://deephistapps.com/api/image/UploadImageToAmazon";
                var client = new RestClient(url);
                var request = new RestRequest();       
                string strImageDto = JsonConvert.SerializeObject(imageinfosforupload);
                request.AddHeader("Content-Type", "multipart/form-data");
                foreach (var q in imageinfosforupload)
                {
                    request.AddFile(q.imageName, CacheImgPath + "\\" + q.imageName + ".jpeg");
                }              
                request.AddParameter("StrImageDto", strImageDto);
                request.AlwaysMultipartFormData = true;
                var response = await client.PostAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    //DOSYAYI SİLECEĞİMİZ KISIM BURADA
                    //JSON DOSYASIYLA BERABER RESMİ SİLİP BİTİRECEĞİZ.
                    //BURADA JSON İÇERİSİNDE BASE64 TEKRAR İMAGE'E DÖNÜŞTÜRÜLÜP ARDINDAN 
                    //






                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public Image base64toImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        public async Task readJson()
        {
            DirectoryInfo d = new DirectoryInfo(CacheImgPath+"\\");
            imageinfosforupload.Clear();
            foreach (var file in d.GetFiles())
            {
                if (file.Extension!=".jpeg")
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
                //base64string = ImagetoBase64(imagepath + "\\" + imagename),
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
