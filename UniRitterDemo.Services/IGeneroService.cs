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
    public interface IGeneroService
    {
        [OperationContract]
        GeneroDataContract BuscarPorNome(string nome);

        [OperationContract]
        GeneroDataContract[] BuscarTodos();
    }
}
