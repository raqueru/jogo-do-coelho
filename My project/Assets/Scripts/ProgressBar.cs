using UnityEngine;
using UnityEngine.UI;
public class ProgressBar : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject endPoint;

    private Slider slider;
    private float startPosition, EndPosition, CurrentPosition;
    private RectTransform rectTransform;
    // Start is called before the first frame update

    private void Start()
    {
        slider = this.GetComponent<Slider>();

    }
    void Update()
    {

        slider.minValue = Camera.main.WorldToViewportPoint(startPoint.transform.position).x;
        slider.maxValue = Camera.main.WorldToViewportPoint(endPoint.transform.position).x;
        Vector2 viewportPosition = Camera.main.WorldToViewportPoint(FindObjectOfType<PlayerMovement>().gameObject.transform.position);
        slider.value = viewportPosition.x;
    }
}