using  System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RDB_Website.Controllers
{    //We R Writng This Cdoe For Uploading Image in Server Side  
    public class SharedController : Controller
    { 
        public JsonResult UploadImage()
        {
            /* result is the name of Json Object*/
            JsonResult result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;

            try
            {
                var file = Request.Files[0];
                /*Guid Hmri image k Name ko Unique String ma Convert Krta Hai Ta K koi User Guess 
                 Work na kr Sky, 
                 Get Extension k Through Hm Upload Image ki Type Ko Detect Krty Hai */
                var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/images/"), fileName);
                /*Success is just the name of Anonymous Object*/
                result.Data = new { Success = true, ImageURLPath =string.Format("/Content/images/{0}", fileName) };
                file.SaveAs(path);
                /*var newImage = new Image() { Name = fileName };
                if (ImageService.Instance.SaveNewImage(newImage))
                {
                    result.Data = new { Success = true,Image = fileName,File = newImage.ID,ImageURL=string.Format}
                }*/
            }
            catch (Exception ex)
            {
                result.Data = new { Success = false, Message = ex.Message };
            }
            return result;
        }
      
    }
}