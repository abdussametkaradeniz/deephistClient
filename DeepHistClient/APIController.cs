using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepHistClient
{
    class APIController
    {
        public int projectId { get; set; }
        public string projectNumber { get; set; }
        public string projectName { get; set; }
        public int adminId { get; set; }
        public int tissueId { get; set; }
        public bool isUseableInOnlineLearning { get; set; }
        public override string ToString()
        {
            return string.Format("Proje Bilgileri: \n\t proje Idsi:{0},\n\tproje numarası{1},\n\tproje adı: {2},\n\t" +
                "admin Id: {3},\n\t tissueId: {4}", projectId,projectNumber,projectName,adminId,tissueId);
        }

    }
    class LoginPost
    {
        public string userName { get; set; }
        public string password { get; set; }
    }
    
    class userInfo
    {
        public int customerId { get; set; }
        public string passwordSalt { get; set; }
        public string passwordHash { get; set; }
        public string customerName { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public double customerDiscount { get; set; }
        public bool isDeleted { get; set; }
        public int cityId { get; set; }
        public int customerTypeId { get; set; }
        public string city { get; set; }
        public string customerType { get; set; }
        public DateTime insertDateTime { get; set; }
        public DateTime updateDateTime { get; set; }
    }

    public class projectInfos
    {
        public int projectId { get; set; }
        public string projectNumber { get; set; }
        public string projectName { get; set; }
        public int adminId { get; set; }
        public int tissueId { get; set; }
        public bool ısUseableInOnlineLearning { get; set; }
    }

    public class ReturnImageInfos
    {
        public int imageId { get; set; }
        public string imageName { get; set; }
        public int projectId { get; set; }
        public int stainId { get; set; }
        public int magnificationImageId { get; set; }       
        public int microscopeId { get; set; }
        public int customerId { get; set; }
        public string microscope { get; set; }
        public string stain { get; set; }
        public string project { get; set; }
        public string magnificationImage { get; set; }
        public string tissue { get; set; }
        public string predictedTissue { get; set; }
        public int predictedTissueId { get; set; }
    }

    public class ImageUploadToAmazonS3
    {        
        public string imageName { get; set; }
        public int projectId { get; set; }
        public int stainId { get; set; }
        public int magnificationImageId { get; set; }
        public int microscopeId { get; set; }
        public int customerId { get; set; }       
    }
    public class KeyStrImageDto
    {
        public List<ImageUploadToAmazonS3> strImageDto { get; set; }
    }

}
