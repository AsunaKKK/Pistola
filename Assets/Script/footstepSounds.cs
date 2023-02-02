using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstepSounds : MonoBehaviour
{
    public AudioSource walking, Running;
    Animator playerAnim;

    public GunShooting gunShoot1;
    public GunShooting gunShoot2;


    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        playerAnim.SetBool("RunPlayer", false);
        playerAnim.SetBool("RunSpeed", false);  
        gunShoot1.enabled = true;
        gunShoot2.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            walking.enabled = true;
            playerAnim.SetBool("RunPlayer" ,true);
            playerAnim.SetBool("RunSpeed", false);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                playerAnim.SetBool("RunPlayer", false);
                playerAnim.SetBool("RunSpeed", true);           
                walking.enabled = false;
                Running.enabled = true;
                gunShoot1.enabled = false;
                gunShoot2.enabled = false;
            }
            else
            {
                Running.enabled = false;
                gunShoot1.enabled = true;
                gunShoot2.enabled = true;
            }
        }
        else
        {
            walking.enabled = false;
            Running.enabled = false;
            gunShoot1.enabled = true;
            gunShoot2.enabled = true;
            playerAnim.SetBool("RunPlayer", false);
            playerAnim.SetBool("RunSpeed", false);

        }
    }
}

