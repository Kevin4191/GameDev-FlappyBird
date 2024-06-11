using UnityEngine;

public class Parallax : MonoBehaviour
{
    void Update()
    {
       float offsetX = Time.time * 2f;
       float offsetY = Time.time * 0;
       GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}