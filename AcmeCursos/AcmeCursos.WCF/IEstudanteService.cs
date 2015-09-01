
using AcmeCursos.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace AcmeCursos.WCF
{
    [ServiceContract]
    public interface IEstudanteService
    {
        [OperationContract]
        List<Estudante> GetAll();

        [OperationContract]
        Estudante GetById(int id);

        [OperationContract]
        Estudante GetByIdWithInscricoes(int id);

        [OperationContract]
        void Create(Estudante estudante);

        [OperationContract]
        void Edit(Estudante estudante);

        [OperationContract]
        void Delete(int id);
    }
}
