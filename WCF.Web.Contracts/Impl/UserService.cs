using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using WCF.Model;
using WCF.Web.Contracts.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace WCF.Web.Contracts.Impl
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class UserService : IUserService
    {
        IEnumerable<User> list = new List<User>()
        {
            new User() { Id = 1, UserName = "张三", Age = 25 },
            new User() { Id = 2, UserName = "李四", Age = 23 },
            new User() { Id = 3, UserName = "王五", Age = 27 },
            new User() { Id = 4, UserName = "赵六", Age = 26 },
            new User() { Id = 5, UserName = "陈七", Age = 26 }
        };

        #region restful
        [WebInvoke(UriTemplate = "", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public ReturnJson<User> Create(User instance)
        {
            return new ReturnJson<User>() { code = 0, msg = "success", data = instance };
        }

        [WebInvoke(UriTemplate = "{id}", Method = "DELETE")]
        public string Delete(string id, User instance)
        {
            return JsonConvert.SerializeObject(new { code = 0, msg = "success" });
        }
        [WebGet(UriTemplate = "", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public IEnumerable<User> GetCollection()
        {
            return list;
        }
        [WebGet(UriTemplate = "{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public string GetCollectionWhere(string id)
        {
            int i = 0;
            int.TryParse(id, out i);
            return JsonConvert.SerializeObject(list.Where(x => x.Id == i));
        }

        [WebInvoke(UriTemplate = "{id}", Method = "PUT")]
        public string Update(string id, User instance)
        {
            return JsonConvert.SerializeObject(instance);
        }
        #endregion

        #region api
        [WebGet(UriTemplate = "{id}/orders", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public string GetUserOrder(string id)
        {
            return JsonConvert.SerializeObject(new { code = 1, msg = "no data" });
        }
        #endregion


    }
}
