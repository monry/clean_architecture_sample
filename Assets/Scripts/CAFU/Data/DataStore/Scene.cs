using CAFU.Data;
using UniRx;

namespace CAFU.Data.DataStore {

    public interface ISceneDataStore : IDataStore {

        IObservable<UnityEngine.SceneManagement.Scene> LoadSceneAsObservable(string sceneName, UnityEngine.SceneManagement.LoadSceneMode loadSceneMode);

    }

    public static class SceneDataStoreFactory {

        public static ISceneDataStore CreateInstance() {
            return new Scene();
        }

    }

    public class Scene : ISceneDataStore {

        // Stack 使って読み込んだデータを保持しておくとかしたい気持ち

        public IObservable<UnityEngine.SceneManagement.Scene> LoadSceneAsObservable(string sceneName, UnityEngine.SceneManagement.LoadSceneMode loadSceneMode) {
            return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName, loadSceneMode)
                .AsObservable()
                .Select(_ => UnityEngine.SceneManagement.SceneManager.GetSceneByName(sceneName));
        }

    }

}