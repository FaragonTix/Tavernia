﻿using UnityEngine;
using System.Collections;
public class chr : MonoBehaviour
{
    public GameObject player;
    public int speedRotation = 3;
    public int speed = 5;
    public AnimationClip anima;
    public int jumpSpeed = 50;
    public Animator animation;

    void Start()
    {
        player = (GameObject)this.gameObject;
      //  animation.AddClip(anima, "animCube");
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            player.transform.position += player.transform.forward * speed * Time.deltaTime;
            animation.Play("Walking");
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.position -= player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.Rotate(Vector3.down * speedRotation);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Rotate(Vector3.up * speedRotation);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.transform.position += player.transform.up * jumpSpeed * Time.deltaTime;
        }
    }
}