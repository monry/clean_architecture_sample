using CAFU.Data;
using UniRx;

namespace CASample.Data.DataStore {

    public interface ISceneDataStore : IDataStore {

        IObservable<Entity.Scene> LoadSceneAsObservable(string sceneName, UnityEngine.SceneManagement.LoadSceneMode loadSceneMode);

    }

    public static class SceneDataStoreFactory {

        public static ISceneDataStore CreateInstance() {
            return new Scene();
        }

    }

    public class Scene : ISceneDataStore {

        // Stack 使って読み込んだデータを保持しておくとかしたい気持ち

        public IObservable<Entity.Scene> LoadSceneAsObservable(string sceneName, UnityEngine.SceneManagement.LoadSceneMode loadSceneMode) {
            return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName, loadSceneMode)
                .AsObservable()
                .Select(
                    (_) => {
                        UnityEngine.SceneManagement.Scene scene = UnityEngine.SceneManagement.SceneManager.GetSceneByName(sceneName);
                        return new Entity.Scene() {
                            RootGameObjects = scene.GetRootGameObjects(),
                            IsValid = scene.IsValid(),
                        };
                    }
                );
        }

    }

}