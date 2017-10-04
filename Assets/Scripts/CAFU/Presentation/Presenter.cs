using System.Collections;
using System.Collections.Generic;
using CAFU.Presentation.View;
using UnityEngine;

namespace CAFU.Presentation {

    public interface IPresenter {

        void SetViewController(IViewController viewController);

    }

    public class Presenter : IPresenter {

        public IViewController ViewController { get; private set; }

        public void SetViewController(IViewController viewController) {
            this.ViewController = viewController;
        }

    }

}