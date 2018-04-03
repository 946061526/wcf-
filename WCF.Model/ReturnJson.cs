using System.Runtime.Serialization;

namespace WCF.Model
{
    [DataContract]
    public class ReturnJson<T> where T : class
    {
        [DataMember]
        public int code { get; set; }
        [DataMember]
        public string msg { get; set; }
        [DataMember]
        public T data { get; set; }
    }
}
