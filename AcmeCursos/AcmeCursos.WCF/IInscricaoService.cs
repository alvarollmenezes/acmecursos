using AcmeCursos.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace AcmeCursos.WCF
{
    [ServiceContract]
    public interface IInscricaoService
    {
        [OperationContract]
        void CadastrarEstudante(Inscricao inscricao);

        [OperationContract]
        List<Inscricao> GetByEstudanteId(int estudanteId);
    }
}
