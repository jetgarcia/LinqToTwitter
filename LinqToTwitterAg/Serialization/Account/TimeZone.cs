﻿//using System.Collections.Generic;
//using System.Runtime.Serialization;

//#if !SILVERLIGHT && !CLIENT_PROFILE
//using System.Web.Script.Serialization;
//#endif

//namespace LinqToTwitter.Json
//{
//    [DataContract]
//    public class TimeZone
//    {
//        [DataMember]
//        public string name { get; set; }
//        [DataMember]
//        public string tzinfo_name { get; set; }
//        [DataMember]
//        public int utc_offset { get; set; }

//        public static TimeZone Deserialize(IDictionary<string, object> dictionary, JavaScriptSerializer serializer)
//        {
//            return new TimeZone
//            {
//                name = dictionary.GetValue<string>("name"),
//                tzinfo_name = dictionary.GetValue<string>("tzinfo_name"),
//                utc_offset = dictionary.GetValue("utc_offset", 0)
//            };
//        }
//    }
//}
