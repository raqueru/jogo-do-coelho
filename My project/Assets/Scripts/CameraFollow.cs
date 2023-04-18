using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 _playerPosition;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _playerPosition = FindObjectOfType<PlayerMovement>().gameObject.transform.position;
        this.transform.position = _playerPosition + new Vector3(5, 1, -5);


    }
}
