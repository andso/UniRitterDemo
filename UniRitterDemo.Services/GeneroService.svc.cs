namespace UniRitterDemo.Services
{
    using System;

    using Moo;

    using UniRitter.Demo.BusinessLogic;

    using UniRitterDemo.Services.DataContracts;
    using UniRitter.Demo.DomainModel;

    public class GeneroService : BaseService<GeneroDataContract, Genero>, IGeneroService
    {
        public GeneroService(IBusinessObject<Genero> bo, IMapper<GeneroDataContract, Genero> dataContractMapper, IMapper<Genero, GeneroDataContract> entityMapper)
            : base(bo, dataContractMapper, entityMapper)
        {
        }
    }
}

