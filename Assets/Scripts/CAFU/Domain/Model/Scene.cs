using CAFU.Presentation;
using CAFU.Presentation.View;

namespace CAFU.Domain.Model {

    public class Scene : IModel {

        public IViewController<IPresenter, IRouter> ViewController;

    }

}