using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector2Follow : MonoBehaviour
{
    public GameObject Player;

    private PlayerMovement PlayerScript;

    void Start()
    {
        PlayerScript = Player.GetComponent<PlayerMovement>();
    }

    void Update()
    {
        transform.position = PlayerScript.targetPos;
    }
}
