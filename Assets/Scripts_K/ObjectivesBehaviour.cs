using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Obj
{
    Selfie, Sign, Shoot
}
public class ObjectivesBehaviour : MonoBehaviour
{
    [SerializeField] GameObject gameHnadler;
    // later
    public Obj objective; 
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //do the objective
            gameHnadler.GetComponent<GameHandlerScript>()
                .focusCamera(
                transform.GetChild(0).transform.position,
                transform.GetChild(0).transform.rotation);
        }    
    }
}
