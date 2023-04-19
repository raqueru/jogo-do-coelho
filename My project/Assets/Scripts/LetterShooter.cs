using System.Collections.Generic;
using UnityEngine;

public class LetterShooter : MonoBehaviour
{
    public GameObject letter;
    PlayerMovement player;
    List<GameObject> bullets;
    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();
        player = FindObjectOfType<PlayerMovement>();

    }

    // Update is called once per frame
    void Update()
    {

        player = FindObjectOfType<PlayerMovement>();
        if (Input.GetKeyDown("z"))
        {
            Shoot(player.transform);
        }


        for (int i = 0; i < bullets.Count; i++)
        {
            if (bullets[i].transform.position.x > player.transform.position.x + 40)
            {
                Destroy(bullets[i].gameObject);
                bullets.Remove(bullets[i]);


            }
        }
    }

    public void Shoot(Transform transform)
    {
        Vector3 playerPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        GameObject bullet = Instantiate(letter, playerPos, player.transform.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(30, 0), ForceMode2D.Impulse);
        bullets.Add(bullet);


    }
}
