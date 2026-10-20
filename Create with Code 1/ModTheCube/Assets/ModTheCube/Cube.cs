using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    async Task Start()
    {
        transform.position = new Vector3(0, 3, 0);
        transform.localScale = Vector3.one * 1.5f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.1f, 0.0f, 0.8f, 0.7f);

    }
    
    void Update()
    {
        transform.Rotate(30.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
