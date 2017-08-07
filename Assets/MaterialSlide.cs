using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class MaterialSlide : MonoBehaviour
{
    [SerializeField]
    private Vector2 velocity;

    private void Update()
    {
        GetComponent<MeshRenderer>().material.mainTextureOffset += velocity * Time.deltaTime;
    }
}
