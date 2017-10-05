using System.Collections;
using System.Collections.Generic;
using CAFU.Domain;
using CAFU.Presentation.View;
using UnityEngine;

namespace CAFU.Presentation {

    public interface IPresenter {

        void SetViewController(IViewController<IPresenter, IRouter> viewController);

    }

    public class PresenterBase : IPresenter {

        public IViewController<IPresenter, IRouter> ViewController { get; private set; }

        public void SetViewController(IViewController<IPresenter, IRouter> viewController) {
            this.ViewController = viewController;
        }

    }

}