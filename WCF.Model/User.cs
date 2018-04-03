using System.Runtime.Serialization;

namespace WCF.Model
{
    [DataContract]
    public class User
    {
        public int Id { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public int Age { get; set; }
    }
}
