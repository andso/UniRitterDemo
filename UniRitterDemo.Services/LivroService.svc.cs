namespace UniRitterDemo.Services
{
    using System;

    using Moo;

    using UniRitter.Demo.BusinessLogic;

    using UniRitterDemo.Services.DataContracts;
    using UniRitter.Demo.DomainModel;

    public class LivroService : BaseService<LivroDataContract, Livro>, ILivroService
    {
        public LivroService(IBusinessObject<Livro> bo, IMapper<LivroDataContract, Livro> dataContractMapper, IMapper<Livro, LivroDataContract> entityMapper)
            : base(bo, dataContractMapper, entityMapper)
        {
        }
    }
}
