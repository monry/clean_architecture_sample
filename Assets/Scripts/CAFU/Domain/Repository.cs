
namespace CAFU.Domain {

    public interface IRepository {}

    public abstract class Repository<T> : IRepository where T : Repository<T>, new() {

        private static T instance;

        public static T Instance {
            get {
                if (instance == default(T)) {
                    instance = new T();
                }
                return instance;
            }
            private set {
                instance = value;
            }
        }

    }

    // TODO: ルーティング専用の Repository を作る

}