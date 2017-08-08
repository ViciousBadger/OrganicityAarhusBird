using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup), typeof(RectTransform))]
public class CanvasGroupDistanceFade : MonoBehaviour
{
    [SerializeField]
    private float visibleDistance;
    [SerializeField]
    private float invisibleDistance;

    private CanvasGroup cg;
    private RectTransform rt;

    private void Start()
    {
        cg = GetComponent<CanvasGroup>();
        rt = GetComponent<RectTransform>();
    }

    private void Update()
    {
        float visibility = Mathf.InverseLerp(invisibleDistance, visibleDistance, rt.anchoredPosition.x);
        cg.alpha = visibility;
    }
}
