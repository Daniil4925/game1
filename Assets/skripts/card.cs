using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class card : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private float interval = 1;
    
    void Start()
    {
        StartCoroutine(ResetSlider());
    }

    void Update()
    {

    }
    private IEnumerator ResetSlider()
    {
        yield return new WaitForSeconds(interval);
        slider.value = 0;
    }
}
