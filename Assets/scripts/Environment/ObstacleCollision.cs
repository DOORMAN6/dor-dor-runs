using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject Player;
    public GameObject charModel;
    public AudioSource crashThud;
    public GameObject levelControl;
    

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Player.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        crashThud.Play();
        levelControl.GetComponent<LevelDistance>().enabled = false;
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    }

}