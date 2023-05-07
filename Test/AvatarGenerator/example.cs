using System;
using System.IO;
using Bridgestars.Util;
using Bridgestars.Util.WebUtil;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.AvatarGenerator
{
    [TestClass]
    public class example
    {
        [TestInitialize]
        public void förevarjetest()
        {
            
        }

        [TestCleanup]
        public void eftervarjetest()
        {
            
        }
        
        [TestMethod]
        public void TestFileUpload()
        {
            
            //massor utkommenterat här eftersom att dependencies är borttagna
            //Bilder: ImageUtil
            //Http request and builder: WebUtil/WebRequest
            //tolka json, behöver du nog inte, JsonUtil
            //Debugger.Print för att printa
            //File.WriteAllBytes för att skriva till fil för att se vad du har laddat ner
            //new WebRequest().setEndpoint("url").....GET().Then(response => response.RawBytes) //nu är det IPromise<byte[]> istället för IPromise<Response>
            
           //Admin.SignIn();
           //Debugger.Print(Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory).ToJson());
           //var user = Database.GetCurrentUser();
           
           var image = new byte[] { 0, 1, 2 }; //....
           //or
           var img = ImageUtil.LoadFromFile("/Users/theo/Documents/bridgestars/lib/bridgestars-lib/Test/IMG_2280.jpg");
            
           //clamp size to be max 256px in any direction
           img = ImageUtil.ClampSize(img, 256);
           //pure image upscale to 1000x1000
           img = ImageUtil.ResizeImage(img, 1000, 1000);
           //crop image
           img = ImageUtil.Crop(img, 200, 200, 100, 100);
           //create db rep.
           //DbFile file = new DbFile("name.jpeg", img);
          
           //listen for progress %
           //file.UploadProgress.ProgressChanged += (sender, level) =>
           //{
           //    Debugger.Print("progress: " + level.Amount);
           //};
           
           //upload
           //file.SaveAsync().Await();
           
           //file is now saved and url is accessible to download image
           //Assert.IsTrue(file.IsSaved);
           //Debugger.Print(file.Url);
          
           //set user avatar reference to image
           //user.Avatar = file;
           //user.SaveAsync().Await();

           //user.Avatar.DownloadAsync().Then(x =>
           //{
               //File.WriteAllBytes("/Users/theo/Documents/bridgestars/lib/bridgestars-lib/Test/IMG_2280_DOWNLOADED.jpeg",x);
           //}).Await();
        }

        [TestMethod]
        public void test() {
          new WebRequest()
          .SetEndpoint("https://api.dicebear.com/6.x/avataaars/png")
          .GET()
          .Then(response => {
            var resp = response.RawBytes;
            File.WriteAllBytes("test.png",resp);
            Debugger.Print(Directory.GetCurrentDirectory());
          });

           new WebRequest()
          .SetEndpoint("https://api.dicebear.com/6.x/avataaars/png")
          .AddParam("seed" , "John")
          .AddParam("hair", "")
          .GET()
          .Then(response => {
            var resp = response.RawBytes;
            //File.WriteAllBytes("test.png",resp);
            return ImageUtil.LoadFromData(resp);
          });
        }
    }


}