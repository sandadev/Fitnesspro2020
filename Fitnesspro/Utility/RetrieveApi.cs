using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fitnesspro.Models.ViewModels.Web;
using Fitnesspro.Dtos;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web.Services.Description;

namespace Fitnesspro.Utility
{
    public static class RetrieveApi
    {
        //public static async Task<string> RetrieveDataListFromApiAsync(string baseUrl,string actionMethod)
        //{
        //   Task<string> serviceTypeResponse='';
        //    using (var client = new HttpClient())
        //    {
        //        //Passing service base url  
        //        client.BaseAddress = new Uri(baseUrl);

        //        client.DefaultRequestHeaders.Clear();
        //        //Define request data format  
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
        //        HttpResponseMessage Res = await client.GetAsync(actionMethod);

        //        //Checking the response is successful or not which is sent using HttpClient  
        //        if (Res.IsSuccessStatusCode)
        //        {
        //            //Storing the response details recieved from web api   
        //            serviceTypeResponse = Res.Content.ReadAsStringAsync().Result;
        //            return serviceTypeResponse;
        //            //Deserializing the response recieved from web api and storing into the Employee list  
        //            //serviceTypeDetails.serviceTypes = JsonConvert.DeserializeObject<List<ServiceTypeDto>>(serviceTypeResponse);

        //        }
        //        return serviceTypeResponse;
        //    }

        //    }
    }
}