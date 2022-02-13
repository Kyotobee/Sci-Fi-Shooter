using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public GameObject Bullet;

    public GameObject Player;
    private PlayerMovement PlayerScript;

    public float increment;

    private bool _canShoot = true;

    public Vector2 BulletTarget;

    public float speed;

    void Start()
    {
        PlayerScript = Player.GetComponent<PlayerMovement>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, BulletTarget, speed * Time.deltaTime);

        if(Input.GetKey(KeyCode.Space) && _canShoot)
        {
            StartCoroutine(ShootGun());
            BulletTarget = new Vector2(transform.position.x + increment, transform.position.y);
        }
    }

    IEnumerator ShootGun()
    {
        _canShoot = false;
        Instantiate(Bullet, PlayerScript.targetPos, Quaternion.identity);
        yield return new WaitForSeconds(2f);
        _canShoot = true;
    }
}
