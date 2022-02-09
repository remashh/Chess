using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class PieceViewBlack : MonoBehaviour
{
    [SerializeField] private Transform rootPoint;
    [SerializeField] private Piece piece;
    private GameObject _piece;
    private void Start()
    {
        SetupData();
    }

    public void SetupData()
    {
        if (_piece != null)
        {
            Destroy(_piece);
        }

        _piece = Instantiate(piece.PrefabBlack, rootPoint);
    }
}
