using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

    public GameObject bomb;
    public float power = 10.0f;
    public float radius = 5.0f;
    public int BombHealth = 10;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (BombHealth < 0)
        {
            Detonate();
            Destroy(bomb);
        }

	}

    void Detonate()
    {
        Vector3 ExplosionPosition = bomb.transform.position;
        Collider[] colliders = Physics.OverlapSphere(ExplosionPosition, radius);
        foreach (Collider hit in colliders)
        {
            hit.transform.SendMessage("DeductPoints", 200, SendMessageOptions.DontRequireReceiver);
        }
    }

    void DeductPoints(int DamageAmount)
    {
        Debug.Log(BombHealth);
        BombHealth -= DamageAmount;
    }
}
