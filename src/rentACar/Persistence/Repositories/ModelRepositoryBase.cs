using Domain.Entities;

namespace Persistence.Repositories
{
    public class ModelRepositoryBase
    {

        public Model Settings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object DelegateSettings => throw new NotImplementedException();

        public string Type => throw new NotImplementedException();
    }
}