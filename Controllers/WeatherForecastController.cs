using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MQTestApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<MQData> Get()
        {
            var t= new List<MQData>(){
                 new MQData("2021-06-15T12:35:38.427-05:00",  7),
                 new MQData("2021-06-16T12:35:38.427-05:00",4),
                 new MQData("2021-06-17T12:35:38.427-05:00",1),
                 new MQData("2021-06-18T12:35:38.427-05:00",3),
                 new MQData("2021-06-19T12:35:38.427-05:00",8),
                 new MQData("2021-06-20T12:35:38.427-05:00", 5),
                 new MQData("2021-06-21T12:35:38.427-05:00",7),
                 new MQData("2021-06-22T12:35:38.427-05:00",8),
                 new MQData("2021-06-23T12:35:38.427-05:00",10),
                 new MQData("2021-06-24T12:35:38.427-05:00",7)};

            return t;
        }
    }



    public class MQData {

        public string Date {get;set;}
        public int Value {get;set;}

        public MQData(string date, int value) {
            Date = date;
            Value = value;

        }

    }

}
