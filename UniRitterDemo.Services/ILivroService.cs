using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UniRitterDemo.Services
{
    using UniRitterDemo.Services.DataContracts;

    [ServiceContract]
    public interface ILivroService
    {
        [OperationContract]
        LivroDataContract BuscarPorNome(string nome);

        [OperationContract]
        LivroDataContract[] BuscarTodos();
    }
}
