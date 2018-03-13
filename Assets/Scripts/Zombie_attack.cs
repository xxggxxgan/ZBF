using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_attack : MonoBehaviour
{
    int Zombie_hunt = 10;
    float atrack_time = 0;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (atrack_time <= 0 && other.gameObject.tag == "hunted")
        {
            other.gameObject.SendMessage("TakeDamage", Zombie_hunt);
            atrack_time = 3;
        }
        else
        {
            atrack_time -= Time.deltaTime;
        }

    }
}
