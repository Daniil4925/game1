using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool _isDown;
    public bool IsClick { get; private set; }






    public void OnPointerDown(PointerEventData eveneData)
    {
        if (_isDown == false) 
            IsClick = true;
        _isDown = true;
    }
    public void OnPointerUp(PointerEventData eveneData)
    {
        _isDown = false;
        IsClick = false;
    }
    void LateUpdate()
    {
        IsClick = false;
    }


}


