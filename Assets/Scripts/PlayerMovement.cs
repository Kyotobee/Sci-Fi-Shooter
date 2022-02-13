using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 targetPos;

    public float increment;

    public float speed;

    public float maxX;
    public float minX;

    public GameObject Camera;

    private CameraAnimatorScript CamScript;

    void Start()
    {
        CamScript = Camera.GetComponent<CameraAnimatorScript>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxX)
        {
            targetPos = new Vector2(transform.position.x + increment, transform.position.y);
            CamScript.anim.SetTrigger("CamShake");
        } else if(Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minX)
        {
            targetPos = new Vector2(transform.position.x - increment, transform.position.y);
            CamScript.anim.SetTrigger("CamShake");
        }
    }
}
