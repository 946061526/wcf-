using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using WCF.Model;

namespace WCF.Web.Contracts.Interfaces
{
    [ServiceContract]
    public interface IWcfServices<T> where T : class
    {
        #region restful
        [WebGet(UriTemplate = "")]
        IEnumerable<T> GetCollection();

        [WebGet(UriTemplate = "{id}")]
        string GetCollectionWhere(string id);

        [WebInvoke(UriTemplate = "", Method = "POST")]
        ReturnJson<T> Create(T instance);

        [WebInvoke(UriTemplate = "", Method = "PUT")]
        string Update(string id, T instance);

        [WebInvoke(UriTemplate = "", Method = "DELETE")]
        string Delete(string id, T instance);
        #endregion
    }
}
