using UnityEngine;
using System.Collections;

public class LaserPlayerDetection : MonoBehaviour
{
    private GameObject player;                          // Reference to the player.
    private LastPlayerSighting lastPlayerSighting;      // Reference to the global last sighting of the player.
	private Detonator exp;

    void Awake ()
    {
        // Setting up references.
        player = GameObject.FindGameObjectWithTag(Tags.player);
        lastPlayerSighting = (LastPlayerSighting)GameObject.Find("secondaryMusic").GetComponent(typeof(LastPlayerSighting));
    	exp = (Detonator)GetComponentInChildren(typeof(Detonator));
	}


    void OnTriggerStay(Collider other)
    {
        // If the beam is on...
        if(renderer.enabled){
            // ... and if the colliding gameobject is the player...
            if(other.gameObject == player){
                // ... set the last global sighting of the player to the colliding object's position.
                lastPlayerSighting.position = other.transform.position;
				exp.Explode();
				exp.sonido();
				GameObject p = GameObject.Find("char_ethan");
				p.SendMessage("TakeDamage",100f);
			}
		}
    }
}