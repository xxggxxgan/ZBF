using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {


    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

	}

    public static void surprise()
    {
        float random_number;
        random_number = Random.value;

        //Debug.Log(random_number);
        if (0.2 >= random_number)
        {
            Debug.Log("Heavy_weapon_bullet");
            PlayerShooting.bullets += 3;
        }
        if (0.4 >= random_number && random_number > 0.2)
        {
            Debug.Log("First_aid");
        }
        if (0.6 >= random_number && random_number > 0.4)
        {
            Debug.Log("Empty");
        }
        if (0.8 >= random_number && random_number > 0.6)
        {
            Debug.Log("Regular zombies");
        }
        if (1.0 >= random_number && random_number > 0.8)
        {
            Debug.Log("NiuBi Jiangshi(not telling) and a bit bullets");
            PlayerShooting.bullets += 2;
        }
    }
}
