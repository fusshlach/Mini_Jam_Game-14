using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public int Energy;
    [SerializeField]
    FinishScript Vic;
    private GameObject[] Obstacle;
    private GameObject[] Movable;
    public GameObject[] MovableWithKey;
    private GameObject[] Hurtfull;

    private bool ReadyToMove;
    void Start()
    {
        Obstacle = GameObject.FindGameObjectsWithTag("Obstacle");
        Movable = GameObject.FindGameObjectsWithTag("Movable");
        MovableWithKey = GameObject.FindGameObjectsWithTag("MovableWithKey");
        Hurtfull = GameObject.FindGameObjectsWithTag("Hurtfull");
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 moveinput = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        moveinput.Normalize();

        if(moveinput.sqrMagnitude > 0.5)
        {
            if(ReadyToMove==true &&Vic.Victory ==false)
            {
                ReadyToMove = false;
                Move(moveinput);
            }
        }
        else
        {
            ReadyToMove = true;
        }

        if(Energy == 0)
        {
            ReadyToMove = false;
        }
    }

    public bool Move(Vector2 direction)
    {
        if (Mathf.Abs(direction.x) < 0.5)

        {
            direction.x = 0;
            Energy--;
        }
        else

        {
            direction.y = 0;
            Energy--;
        }
        direction.Normalize();

        if (Blocked(transform.position, direction))
        {
            return false;
        }
        else
        {
            transform.Translate(direction);
            return true;
        }
    }

    public bool Blocked(Vector3 position, Vector2 direction)
    {
        Vector2 newpos = new Vector2(position.x, position.y) + direction;

        foreach (var obj in Obstacle)
        {
            if (obj.transform.position.x == newpos.x && obj.transform.position.y == newpos.y)
            {
                return true;
            }
        }
        if (MovableWithKey[0] != null)
        {
            foreach (var obj in MovableWithKey)
            {
                if (obj.transform.position.x == newpos.x && obj.transform.position.y == newpos.y)
                {
                    return true;
                }
            }
        }
        



        foreach (var Movable in Movable)
        {
            if (Movable.transform.position.x == newpos.x && Movable.transform.position.y == newpos.y)
            {
                Push objpush = Movable.GetComponent<Push>();
                if (objpush && objpush.Move(direction))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        return false;
    }

}
