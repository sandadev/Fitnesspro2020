using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fitnesspro.Models.ViewModels.Web;
using Fitnesspro.Dtos;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web.Services.Description;

namespace Fitnesspro.Controllers.Web.Admin
{
    public class EntityController : Controller
    {
        string baseUrl = "https://localhost:44396/";
      
        // GET: Entity
        public ActionResult EntityList()
        {
            return View();
        }

        public async Task<ActionResult> CreateEntity()
        {
            var serviceTypeDetails = new EntityViewModel();
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/EntityAdmin/ServiceTypeList");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var serviceTypeResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    serviceTypeDetails.lstserviceTypes = JsonConvert.DeserializeObject<List<ServiceTypeDto>>(serviceTypeResponse);

                }
                return View(serviceTypeDetails);
            }
        }

        public async Task<ActionResult> EditEntity(int id)
        
        {
            var serviceTypeDetails = new EntityViewModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage entityRes = await client.GetAsync("api/EntityAdmin/" + id);
                HttpResponseMessage ServiceRes = await client.GetAsync("api/EntityAdmin/ServiceTypeList");
                if (entityRes.IsSuccessStatusCode && ServiceRes.IsSuccessStatusCode)
                {
                    var entityTypeResponse = entityRes.Content.ReadAsStringAsync().Result;
                    var serviceTypeResponse= ServiceRes.Content.ReadAsStringAsync().Result;
                    serviceTypeDetails.lstserviceTypes = JsonConvert.DeserializeObject<List<ServiceTypeDto>>(serviceTypeResponse);
                    serviceTypeDetails.Entity = JsonConvert.DeserializeObject<EntityDto>(entityTypeResponse);
                }
                //return View(serviceTypeDetails);
                return View("CreateEntity", serviceTypeDetails);
            }
        }
        }
}