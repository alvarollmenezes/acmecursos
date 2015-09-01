using AcmeCursos.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace AcmeCursos.WCF
{
    [ServiceContract]
    public interface ICursoService
    {
        [OperationContract]
        List<Curso> GetAll();

        [OperationContract]
        Curso GetById(int id);

        [OperationContract]
        Curso GetByIdWithProfessores(int id);

        [OperationContract]
        void Create(Curso curso, int[] professores);

        [OperationContract]
        void Edit(Curso curso, int[] professores);

        [OperationContract]
        void Delete(int id);
    }
}
