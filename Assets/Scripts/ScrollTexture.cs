using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTexture : MonoBehaviour
{
    public Material scrollableMaterial;
    public Vector2 direction = new Vector2(0,1);
    public float speed = 1.0f;

    private Vector2 currentOffset;
    
    // Start is called before the first frame update
    void Start()
    {
        currentOffset = scrollableMaterial.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        currentOffset += direction * speed * Time.deltaTime;
        scrollableMaterial.SetTextureOffset("_MainTex", currentOffset);
    }
}
