using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CAFU.Domain;
using CAFU.Presentation;
using CAFU.Presentation.View;
using UnityEngine;

namespace CASample.Domain.UseCase.Translator {

    public class Scene : ITranslator<Data.Entity.Scene, Model.Scene> {

        public Model.Scene Translate(Data.Entity.Scene entity) {
            Model.Scene modelScene = new Model.Scene() {
                ViewController = entity.RootGameObjects
                    .ToList()
                    .Find(x => x.GetComponent<IViewController<IPresenter, IRouter>>() != default(IViewController<IPresenter, IRouter>))
                    .GetComponent<IViewController<IPresenter, IRouter>>(),
            };
            return modelScene;
        }

    }

}