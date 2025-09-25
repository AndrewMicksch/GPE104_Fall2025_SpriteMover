using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public KeyCode keyToUse;
    public SpriteRenderer ShipRenderer; 

    // Start is called before the first frame update
    void Start()
    {
        ShipRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToUse))
        {
            //TODO: Changes Sprite color
            Color newColor - new Color(Random.Range (0.0f,1.0f), Random.Range(0.0f,1.0f), Random,Range(0.0f,1.0f), 1.0f);
            ShipRenderer.color = newColor;
        }   else
        {
            ShipRenderer.color = Color.blue;
        }
    }
}
