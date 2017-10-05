using System.Collections;
using System.Collections.Generic;
using CAFU.Domain;
using CAFU.Presentation;
using CAFU.Presentation.View;
using UnityEngine;

namespace CASample.Domain.Model {

    public class Scene : IModel {

        public IViewController<IPresenter, IRouter> ViewController { get; set; }

    }

}