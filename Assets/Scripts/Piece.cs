using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class Piece : ScriptableObject
    {
        [SerializeField] private string name;
        [SerializeField] private GameObject prefabWhite;
        [SerializeField] private GameObject prefabBlack;

        public string Name => name;

        public GameObject PrefabWhite => prefabWhite;

        public GameObject PrefabBlack => prefabBlack;
    }
}

