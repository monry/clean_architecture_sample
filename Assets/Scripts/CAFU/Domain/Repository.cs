
namespace CAFU.Domain {

    public interface IRepository {}

    public abstract partial class RepositoryBase<T> : IRepository where T : RepositoryBase<T>, new() {

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

}
