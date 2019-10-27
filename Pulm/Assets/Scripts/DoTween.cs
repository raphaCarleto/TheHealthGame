using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DoTween : MonoBehaviour {
    public RectTransform imgRect = null;

    void Start () { }

    void Update () {
        AnimacaoScala ();
    }

    void AnimacaoScala () {

        if (imgRect.localScale.x == 25) {
            imgRect.DOScale (new Vector3 (29, 29, 29), 1);
        } else if (imgRect.localScale.x == 29) {
            imgRect.DOScale (new Vector3 (25, 25, 25), 1);
        }

    }
}