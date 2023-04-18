using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float Jumpforce = 1;
    public float scenarySpeed = 1;
    public GameObject child;
    public bool IsGrounded = true;

    public Sprite walking;
    public Sprite jumping;

    // Start is called before the first frame update
    void Start()
    {
        child.GetComponent<SpriteRenderer>().sprite = walking;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && IsGrounded == true)
        { jump(); }
        gameObject.transform.position += new Vector3(scenarySpeed, 0);



    }

    void jump()
    {

        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Jumpforce), ForceMode2D.Impulse);
        IsGrounded = false;
        child.GetComponent<SpriteRenderer>().sprite = jumping;


    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor")
        {
            IsGrounded = true;
            child.GetComponent<SpriteRenderer>().sprite = walking;


        }
    }

}

