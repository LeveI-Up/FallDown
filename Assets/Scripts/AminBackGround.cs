using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AminBackGround : MonoBehaviour
{
    Material mat;
    Vector2 move;
    public Vector2 speed;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        mat.mainTextureOffset = move;
        move += speed * Time.deltaTime;
        
    }
}
