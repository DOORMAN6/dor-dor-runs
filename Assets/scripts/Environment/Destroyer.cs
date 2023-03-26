using System.Collections;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public string parentName;

    void Start()
    {
        parentName = transform.name;
        StartCoroutine(DestoryClone());
    }
    IEnumerator DestoryClone()
    {
        
        if (parentName == "Section(Clone)")
        {
            Debug.Log("Started Coroutine at timestamp : " + Time.time);
            yield return new WaitForSeconds(40);
            Destroy(gameObject);
            Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        }
    }
}
