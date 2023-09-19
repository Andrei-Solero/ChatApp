using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ChatApp_Model;

namespace ChatApp_Controller
{
    public class ImageProcessor
    {
        private readonly string mainUserImagePath = $@"{ Directory.GetCurrentDirectory() }\_AppImages";
        private readonly string mainMessageImagePath = $@"{Directory.GetCurrentDirectory()}\_PictureMessage";


        public string GetProfileImage(int userID)
        {
            return (userID == 0) ? $@"{mainUserImagePath}\default.jpg" : $@"{mainUserImagePath}\{ userID }.jpg";
        }

        public void SaveImage(string imagePath, int userID)
        {
            if (imagePath != "")
            {
                File.Copy(imagePath, $@"{mainUserImagePath}\{userID}.jpg");
            }
        }

        public void SaveChatImage(string imagePath, string imageCode)
        {
            if (imagePath != "")
            {   
                File.Copy(imagePath, $@"{mainMessageImagePath}\{imageCode}.jpg");
            }
        }

        public string GetChatImage(string imageCode)
        {
            return $@"{mainMessageImagePath}\{imageCode}.jpg";
        }

    }
}
