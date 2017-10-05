using System.Linq;
using CAFU.Domain.Model;
using CAFU.Presentation;
using CAFU.Presentation.View;

namespace CAFU.Domain.Translator {

    public class Routing : ITranslator<Data.Entity.Scene, Scene> {

        public Scene Translate(Data.Entity.Scene entity) {
            return new Scene() {
                ViewController = entity.UnityScene
                    .GetRootGameObjects()
                    .ToList()
                    .Find(x => x.GetComponent<IViewController<IPresenter, IRouter>>() != default(IViewController<IPresenter, IRouter>))
                    .GetComponent<IViewController<IPresenter, IRouter>>(),
            };
        }

    }

}
