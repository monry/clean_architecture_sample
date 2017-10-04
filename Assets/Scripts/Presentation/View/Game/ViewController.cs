
namespace CASample.Presentation.View.Game {

    public class ViewController : CAFU.Presentation.View.ViewController<ViewController, Presenter.Game, Domain.UseCase.GameRouter> {

        protected override void OnInitialized() {
            this.Inject(new Presenter.Game(), new Domain.UseCase.GameRouter());
            // あと、キーボードイベントもココで受ける感じかな？
        }

    }

}