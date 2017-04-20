using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlamingWeaponScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public float damageValue = 20;

    void OnParticleCollision(GameObject other)
    {
        if (other.transform.tag.Equals("breakable"))
        {
            other.SendMessage("Hit", damageValue);
        }
    }

}
