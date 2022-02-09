using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class Piece : ScriptableObject
    {
        [SerializeField] private string name;
        [SerializeField] private GameObject prefab;

        public string Name => name;

        public GameObject Prefab => prefab;
    }
}

