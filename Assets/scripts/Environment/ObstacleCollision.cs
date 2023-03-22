using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject Player;
    public GameObject charModel;
    public AudioSource crashThud;
    public GameObject levelcontrol;
    

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Player.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        crashThud.Play();
        levelcontrol.GetComponent<LevelDistance>().enabled = false;
        levelcontrol.GetComponent<EndRunSequence>().enabled = true;
    }

}