using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public Button sb; // Reference to the Button GameObject
    public Button wb;
    public Button nb;
    public Slider mySlider;
    private PlayerControls inputActions;

    private void Awake()
    {
        inputActions = new PlayerControls();
    }

    private void OnEnable()
    {
        inputActions.Enable();
        inputActions.Player.SouthButton.performed += OnSouthButtonPressed;
        inputActions.Player.WestButton.performed += OnWestButtonPressed;
        inputActions.Player.NorthButton.performed += OnNorthButtonPressed;
        inputActions.Player.SliderUp.performed += OnSliderUpPressed;
        inputActions.Player.SliderDown.performed += OnSliderDownPressed;
    }

    private void OnDisable()
    {
        inputActions.Player.SouthButton.performed -= OnSouthButtonPressed;
        inputActions.Player.WestButton.performed -= OnWestButtonPressed;
        inputActions.Player.NorthButton.performed -= OnNorthButtonPressed;
        inputActions.Player.SliderUp.performed -= OnSliderUpPressed;
        inputActions.Player.SliderDown.performed -= OnSliderDownPressed;
        inputActions.Disable();
    }

    private void OnSouthButtonPressed(InputAction.CallbackContext context)
    {
        sb.onClick.Invoke();
    }

    private void OnWestButtonPressed(InputAction.CallbackContext context)
    {
        Event.KeyboardEvent("c");
        wb.onClick.Invoke();
    }

    private void OnNorthButtonPressed(InputAction.CallbackContext context)
    {
        Event.KeyboardEvent("a");
        nb.onClick.Invoke();
    }

    private void OnSliderUpPressed(InputAction.CallbackContext context)
    {
        float sliderChange = Time.deltaTime; // Adjust sensitivity as needed
        mySlider.value = Mathf.Clamp(mySlider.value + sliderChange, mySlider.minValue, mySlider.maxValue);
    }

    private void OnSliderDownPressed(InputAction.CallbackContext context) 
    {
        float sliderChange = -Time.deltaTime; // Adjust sensitivity as needed
        mySlider.value = Mathf.Clamp(mySlider.value + sliderChange, mySlider.minValue, mySlider.maxValue);
    }
}