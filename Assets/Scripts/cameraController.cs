using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class cameraController : MonoBehaviour

{



    public GameObject player;



    private Vector3 offset;





    void Start()

    {

        offset = transform.position - player.transform.position;

    }



    // Update is called once per frame

    void LateUpdate()

    {
        if (player.transform.position.x > -15.7 && player.transform.position.x < 55 && player.transform.position.z > -66 && player.transform.position.z < 28.6)
        {
            transform.position = player.transform.position + offset;
        }
        else if (player.transform.position.x <= -15.7 || player.transform.position.x >= 55)
        {
            if (player.transform.position.z > -66 && player.transform.position.z < 28.6)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, offset.z + player.transform.position.z);
            }
            else
            {
                transform.position = transform.position;
            }
        }
        else
        {
            transform.position = new Vector3(offset.x + player.transform.position.x, transform.position.y, transform.position.z);
        }


    }

}