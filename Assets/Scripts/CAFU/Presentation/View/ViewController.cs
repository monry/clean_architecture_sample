using CAFU.Domain;
using UnityEngine;

namespace CAFU.Presentation.View {

    public interface IViewController<in TPresenter, in TRouter> where TPresenter : IPresenter where TRouter : IRouter {

        void Inject(TPresenter presenter, TRouter router);

    }

    public abstract class ViewController<T, TPresenter, TRouter> : MonoBehaviour, IViewController<TPresenter, TRouter>
        where T : ViewController<T, TPresenter, TRouter>
        where TPresenter : IPresenter
        where TRouter : IRouter {

        private TPresenter presenter;
        public TPresenter Presenter {
            get {
                return this.presenter;
            }
            private set {
                this.presenter = value;
                this.presenter.SetViewController((IViewController<IPresenter, IRouter>)this);
            }
        }

        private TRouter router;
        public TRouter Router {
            get {
                return this.router;
            }
            private set {
                this.router = value;
            }
        }

        public void Inject(TPresenter presenter, TRouter router) {
            this.Presenter = presenter;
            this.Router = router;
        }

        private static T instance;

        public static T Instance {
            get {
                return instance;
            }
            private set {
                instance = value;
            }
        }

        protected abstract void OnInitialized();

        private void Awake() {
            Instance = (T)this;
        }

        private void OnDestroy() {
            Instance = null;
        }

    }

}