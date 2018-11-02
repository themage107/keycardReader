using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycardReader : MonoBehaviour {

    public BoxCollider2D readerCollider;
    public GameObject readerGO;
    public Texture redLight;
    public Texture greenLight;
    public bool doorUnlocked;

    public GameObject keycard;
    keycard keycardVars;

    void Start()
    {
        readerGO.GetComponent<Renderer>().material.SetTexture("_EmissionMap", redLight);
        keycardVars = keycard.GetComponent<keycard>();
        doorUnlocked = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "JohnnyHitBox")
        {
            if (keycardVars.keyCardInPoss)
            {
                readerGO.GetComponent<Renderer>().material.SetTexture("_EmissionMap", greenLight);
                this.gameObject.GetComponent<AudioSource>().Play();
                readerCollider.enabled = false;
                doorUnlocked = true;
            }
        }
    }
 

}
