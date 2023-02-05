using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    private GameObject[] Obstacle;
    private GameObject[] Movable;
    private GameObject[] MovableWithKey;
    private GameObject[] Hurtfull;
    public AudioSource audioSource;

    void Start()
    {
        Obstacle = GameObject.FindGameObjectsWithTag("Obstacle");
        Movable = GameObject.FindGameObjectsWithTag("Movable");
        MovableWithKey = GameObject.FindGameObjectsWithTag("MovableWithKey");
        Hurtfull = GameObject.FindGameObjectsWithTag("Hurtfull");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Move(Vector2 direction)
    {
        if(ObjtoBlocked(transform.position,direction))
        {
            audioSource.Play();
            return false;
        }
        else
        {
            audioSource.Play();
            transform.Translate(direction);
            return true;
        }
    }

    public bool ObjtoBlocked(Vector3 position, Vector2 direction)
    {
        Vector2 newpos = new Vector2(position.x, position.y) + direction;

        foreach (var obj in Obstacle)
        {
            if (obj.transform.position.x == newpos.x && obj.transform.position.y == newpos.y)
            {
                audioSource.Play();
                return true;
            }
        }

        foreach (var Movable in Movable)
        {
            if (Movable.transform.position.x == newpos.x && Movable.transform.position.y == newpos.y)
            {
                audioSource.Play();
                return true;
            }
        }
        return false;
    }
}
