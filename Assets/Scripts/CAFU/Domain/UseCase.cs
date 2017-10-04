
namespace CAFU.Domain {

    public interface IUseCase {}

    public interface IRouter : IUseCase {}

    public class UseCase : IUseCase {

    }

    // TODO: ルーティング専用の Repository を作ったらそっちに逃がす
    public abstract class Router<TRepository> : IRouter where TRepository : IRepository {

        public TRepository RepositoryRouting { get; set; }

    }

}

