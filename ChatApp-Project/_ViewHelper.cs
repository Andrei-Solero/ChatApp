using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Media;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatApp_Controller;
using Guna.UI2.WinForms;
using static Guna.UI2.Native.WinApi;

namespace ChatApp_Project
{
    public class _ViewHelper
    {
        public static string MessageStatus { get; set; }

        public static void ImageProcessor(Guna2CirclePictureBox pictureBox, int ID)
        {
            ImageProcessor processor = new ImageProcessor();

            try
            {
                pictureBox.Image = Image.FromFile(processor.GetProfileImage(ID));
            }
            catch (Exception)
            {
                pictureBox.Image = Image.FromFile(processor.GetProfileImage(0));
            }
        }

        public static void ImageProcessor_Save(string imagePath, int ID)
        {
            ImageProcessor processor = new ImageProcessor();
            processor.SaveImage(imagePath, ID);
        }

        public static void ChatImageProcessor(PictureBox image, string message)
        {
            ImageProcessor processor = new ImageProcessor();
            string imagePath = ImageConverter(message);
            image.Image = Image.FromFile(processor.GetChatImage(imagePath));
        }

        public static void ChatImageProcessor_Save(string imagePath, string imageCode)
        {
            ImageProcessor processor = new ImageProcessor();
            string code = ImageConverter(imageCode);

            processor.SaveChatImage(imagePath, code);
        }

        private static string ImageConverter(string imagePath)
        {
            char[] chars = imagePath.ToCharArray();
            List<char> code = new List<char>();

            foreach (var c in chars)
            {
                if (c != '/' && c != ':') code.Add(c);
            }

            return new string(code.ToArray());
        }

        private static void AudioProcessor(string process)
        {
            SoundPlayer player;
            switch (process)
            {
                case "Send":
                    player = new SoundPlayer(ChatApp_Project.Properties.Resources.send_message);
                    player.Play();
                    break;
                case "Received":
                    player = new SoundPlayer(ChatApp_Project.Properties.Resources.sent);
                    player.Play();
                    break;
                case "NewFriend":
                    player = new SoundPlayer(ChatApp_Project.Properties.Resources.newFriend);
                    player.Play();
                    break;
            }
        }

        public static void AudioSend()
        {
            AudioProcessor("Send");
        }

        public static void AudioNewFriend()
        {
            AudioProcessor("NewFriend");
        }

        public static void AudioReceived()
        {
            AudioProcessor("Received");
        }
    }
}
