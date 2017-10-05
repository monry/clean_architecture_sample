
namespace CASample.Presentation.View.Game {

    public class ViewController : CAFU.Presentation.View.ViewControllerBase<ViewController, Presenter.Game, Router.Game> {

        protected override void OnInitialized() {
            this.Inject(new Presenter.Game(), new Router.Game());
            // あと、キーボードイベントもココで受ける感じかな？
        }

    }

}