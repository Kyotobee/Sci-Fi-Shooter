using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector2Follow : MonoBehaviour
{
    public GameObject Player;

    private PlayerMovement PlayerScript;

    private Vector2 ExamplePos;

    void Start()
    {
        PlayerScript = Player.GetComponent<PlayerMovement>();
    }

    void Update()
    {
        ExamplePos = new Vector2(PlayerScript.targetPos.x, 0);

        transform.position = ExamplePos;
    }
}
