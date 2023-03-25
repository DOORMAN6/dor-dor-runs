using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject Player;
    public GameObject charModel;
    public AudioSource crashThud;
    public GameObject Levelcontrol;
    

    void OnTriggerEnter(Collider other)
    {
        Levelcontrol.GetComponent<LevelDistance>().enabled = false;
        Levelcontrol.GetComponent<EndRunSequence>().enabled = true;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Player.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        crashThud.Play();
        //Levelcontrol.GetComponent<LevelDistance>().enabled = false;
       // Levelcontrol.GetComponent<EndRunSequence>().enabled = false;
      
    }

}