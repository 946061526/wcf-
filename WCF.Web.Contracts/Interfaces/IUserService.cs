using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using WCF.Model;

namespace WCF.Web.Contracts.Interfaces
{
    [ServiceContract]
    public interface IUserService : IWcfServices<User>
    {
        #region api
        [WebGet(UriTemplate = "{id}/orders")]
        string GetUserOrder(string id);
        #endregion
    }
}
