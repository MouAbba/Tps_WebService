using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEnseignement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceEnseignment" in both code and config file together.
    public class ServiceEnseignment : IServiceEnseignment
    {
        DataClassesEnseignmentDataContext l = new DataClassesEnseignmentDataContext();
        public List<Eleve> getByCNE(string s)
        {
            return (from p in l.Eleves where p.CNE == s select p).ToList();
        }
        public void DoWork()
        {
        }
    }
}
