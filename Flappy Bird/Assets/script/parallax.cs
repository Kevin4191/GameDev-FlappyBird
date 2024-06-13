using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float snelhijt = 1f;
    void Update()
    {
       float offsetX = Time.time * snelhijt;
       GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetX, 0);
    }
}