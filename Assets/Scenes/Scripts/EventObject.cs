using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventObject : MonoBehaviour
{
    [SerializeField]
    Sprite secondSprite = null;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ChangeSprite() {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = secondSprite;
    }
}
