using UnityEngine;

public class LetterShooter : MonoBehaviour
{
    public Bullet letter;
    PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
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
        Bullet[] bullets = FindObjectsOfType<Bullet>();
        foreach (Bullet bullet in bullets)
        {
            if (bullet.transform.position.x > player.transform.position.x + 40)
            {
                Destroy(bullet.gameObject);
            }
        }
    }

    public void Shoot(Transform transform)
    {
        Vector3 playerPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Rigidbody2D bullet = Instantiate(letter.body, playerPos, player.transform.rotation);
        bullet.AddForce(new Vector2(30, 0), ForceMode2D.Impulse);


    }
}
