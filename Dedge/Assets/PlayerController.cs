using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;

    public float speed = 3f;

    public GameObject my;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float lnput = Input.GetAxis("Horizontal");
        // 키보드 : 'A', <- : 음의방향 : -1.0f
        // 키보드 : 'D', -> : 양의방향 : +1.0f
        float zlnput = lnput.GutAxis("Vertical");
        // 키보드 : 'W',^ : 양의방향 : +1.0f
        // 키보드 : 'S',  : 음의방향 : -1.0f
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            playerRigidbody
                .AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigidbody
                .AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigidbody
                .AddForce(-speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigidbody
                .AddForce(speed,0f, 0f);
        }
    }
    void Die()
    {
        my.SetActive(false);
    }
}
