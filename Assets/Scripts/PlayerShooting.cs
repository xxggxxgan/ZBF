using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public int GunDamageAmount = 5;
    public int NiuBiDamageAmount = 200;
    public float used_distancee;
    public float GunAllowedRange = 15.0f;
    public float NiuBiAllowedRange = 30.0f;
    public GameObject Gun, NiuBi;
    public static int bullets = 0;


    void Start()
    {
		
        NiuBi.SetActive(false);
        Gun.SetActive(true);
    }
    void FixedUpdate()
	{
        if (Input.GetKeyDown(KeyCode.F))
		{ 
            //Debug.Log("hello");
            if (Gun.activeSelf)
            {
                Gun.SetActive(false);
                NiuBi.SetActive(true);
            }
            else
            {
                Gun.SetActive(true);
                NiuBi.SetActive(false);
            }
            //Gun.SetActive(true);
            //NiuBi.SetActive(false);
        }

        if (Input.GetKeyDown("space"))
		{   
			
            if (Gun.activeSelf)
            {
                RaycastHit Shot;
                if (Physics.Raycast(Gun.transform.position, transform.TransformDirection(Vector3.forward), out Shot, GunAllowedRange))
                {
                    Shot.transform.SendMessage("DeductPoints", GunDamageAmount, SendMessageOptions.DontRequireReceiver);
                }
            }

            if (NiuBi.activeSelf)
            {
                if (bullets > 0)
                {
                    bullets -= 1;
                    RaycastHit[] Shot = Physics.RaycastAll(NiuBi.transform.position, transform.TransformDirection(Vector3.forward), NiuBiAllowedRange); 
                    if (Shot.Length != 0)
                    {
                        for (int i = 0; i < Shot.Length; i++)
                        {
                            Shot[i].collider.SendMessage("DeductPoints", NiuBiDamageAmount, SendMessageOptions.DontRequireReceiver);
                        }
                    }
                }
            }
        }
    }
}
