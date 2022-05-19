using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public float cooldowntimer = .05f;
    float timerlength;
    public GameObject bullet;
    public Transform gun;

    private AudioSource laser;

    // Start is called before the first frame update
    void Start()
    {
        timerlength = cooldowntimer;
        cooldowntimer = 0;
        laser = GetComponent<AudioSource>(); //grabs audio source component
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && cooldowntimer <= 0)
        {
            GameObject.Instantiate(bullet, gun.position, Quaternion.identity); // this code allows bullet spray when player moves
            laser.Play();
            cooldowntimer = timerlength;     //once player shoots it sets cooldown timer off
        }
        if (cooldowntimer >= 0)
        {
            cooldowntimer -= Time.deltaTime;
        }
    }
}
