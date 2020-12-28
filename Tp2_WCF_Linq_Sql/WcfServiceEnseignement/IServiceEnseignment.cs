using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEnseignement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceEnseignment" in both code and config file together.
    [ServiceContract]
    public interface IServiceEnseignment
    {
        [OperationContract]
        List<Eleve> getByCNE(string s);
        void DoWork();
    }
}
