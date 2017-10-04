using CAFU.Domain;
using CASample.Data.DataStore;
using UniRx;

namespace CASample.Domain.Repository {

    public class Routing : Repository<Routing> {

        public IObservable<Data.Entity.Scene> Load(string sceneName, UnityEngine.SceneManagement.LoadSceneMode loadSceneMode) {
            return SceneDataStoreFactory.CreateInstance().LoadSceneAsObservable(sceneName, loadSceneMode);
        }

    }

}