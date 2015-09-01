using AcmeCursos.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace AcmeCursos.WCF
{
    [ServiceContract]
    public interface IProfessorService
    {
        [OperationContract]
        List<Professor> GetAll();

        [OperationContract]
        Professor GetById(int id);

        [OperationContract]
        Professor GetByIdWithCursos(int id);

        [OperationContract]
        void Create(Professor professor);

        [OperationContract]
        void Edit(Professor professor);

        [OperationContract]
        void Delete(int id);
    }
}
