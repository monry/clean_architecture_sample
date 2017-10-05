
using UniRx;
using CAFU.Data.DataStore;

namespace CAFU.Domain.Repository {

    public class Routing : RepositoryBase<Routing> {

        public IObservable<UnityEngine.SceneManagement.Scene> Load(string sceneName, UnityEngine.SceneManagement.LoadSceneMode loadSceneMode) {
            return SceneDataStoreFactory.CreateInstance().LoadSceneAsObservable(sceneName, loadSceneMode);
        }

    }

}