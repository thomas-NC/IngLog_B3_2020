using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBehavior : MonoBehaviour
{
    public Color hoverColor;
    private SpriteRenderer rend;
    private Color BaseColor;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
        BaseColor = rend.color;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseExit()
    {
        rend.color = BaseColor;
    }
    private void OnMouseEnter()
    {
        rend.color = hoverColor;
    }
}
