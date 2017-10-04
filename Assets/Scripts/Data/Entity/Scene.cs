using System.Collections;
using System.Collections.Generic;
using CAFU.Data;
using UnityEngine;

namespace CASample.Data.Entity {

    public class Scene : IEntity {

        public GameObject[] RootGameObjects { get; set; }

        public bool IsValid { get; set; }

    }


}

