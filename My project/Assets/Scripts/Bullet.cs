using UnityEngine;

public class Bullet : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D body;

    private void Start()
    {
        body = this.GetComponent<Rigidbody2D>();
    }
}
