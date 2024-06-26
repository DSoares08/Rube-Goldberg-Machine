using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public Button sb; // Reference to the Button GameObject
    public Button wb;
    public Button nb;
    public Slider mySlider;
    public Slider mySlider2;
    private PlayerControls inputActions;
    private bool L2 = false;
    private bool R2 = false;
    public GameObject a;
    public int gravity;
    public Button ab;
    public Rigidbody2D b1;
    public Rigidbody2D b2;
    public Rigidbody2D b3;
    public static bool ni = false;
    public static bool su = false;
    public static bool sd = false;
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
        inputActions.Player.NorthButton.canceled += OnNorthButtonReleased;
        inputActions.Player.SliderUp.performed += OnSliderUpPressed;
        inputActions.Player.SliderDown.performed += OnSliderDownPressed;
        inputActions.Player.SliderUp.canceled += OnSliderUpReleased;
        inputActions.Player.SliderDown.canceled += OnSliderDownReleased;
        inputActions.Player.R2.performed += OnR2Pressed;
        inputActions.Player.L2.performed += OnL2Pressed;
        inputActions.Player.R2.canceled += OnR2Released;
        inputActions.Player.L2.canceled += OnL2Released;
    }

    private void OnDisable()
    {
        inputActions.Player.SouthButton.performed -= OnSouthButtonPressed;
        inputActions.Player.WestButton.performed -= OnWestButtonPressed;
        inputActions.Player.NorthButton.performed -= OnNorthButtonPressed;
        inputActions.Player.NorthButton.canceled -= OnNorthButtonReleased;
        inputActions.Player.SliderUp.performed -= OnSliderUpPressed;
        inputActions.Player.SliderDown.performed-= OnSliderDownPressed;
        inputActions.Player.SliderUp.canceled -= OnSliderUpReleased;
        inputActions.Player.SliderDown.canceled -= OnSliderDownReleased;
        inputActions.Player.R2.performed -= OnR2Pressed;
        inputActions.Player.L2.performed -= OnL2Pressed;
        inputActions.Player.R2.canceled -= OnR2Released;
        inputActions.Player.L2.canceled -= OnL2Released;
        inputActions.Disable();
    }

    private void OnSouthButtonPressed(InputAction.CallbackContext context)
    {
        if (sb != null)
        {
            sb.onClick.Invoke();
        }
        
    }

    private void OnWestButtonPressed(InputAction.CallbackContext context)
    {
        wb.onClick.Invoke();
    }

    private void OnNorthButtonPressed(InputAction.CallbackContext context)
    {
            ni = true;
            nb.onClick.Invoke();
        
    }

    private void OnSliderUpPressed(InputAction.CallbackContext context)
    {
        su = true;

    }

    private void OnSliderDownPressed(InputAction.CallbackContext context)
    {
        sd = true;
    }

    private void OnSliderDownReleased(InputAction.CallbackContext context)
    {
        sd = false;
    }

    private void OnSliderUpReleased(InputAction.CallbackContext context)
    {
        su = false;
    }

    private void OnR2Pressed(InputAction.CallbackContext context)
    {
        R2 = true;
    }

    private void OnL2Pressed(InputAction.CallbackContext context)
    {
        L2 = true;
    }
    
    private void OnR2Released(InputAction.CallbackContext context)
    {
        R2 = false;
    }

    private void OnL2Released(InputAction.CallbackContext context)
    {
        L2 = false;
    }

    private void OnNorthButtonReleased(InputAction.CallbackContext context)
    {
        ni = false;
    }

    void Update()
    {
        if (L2 && R2)
        {
            if (a.activeSelf)
            {
                b1.gravityScale = gravity;
                b2.gravityScale = gravity;
                b3.gravityScale = gravity;
                ab.onClick.Invoke();
            }
        }
        if (sd && mySlider != null)
        {
            float deltaTime = Time.deltaTime > 0 ? Time.deltaTime : 0.002f;
            float sliderChange = -2 * deltaTime;
            mySlider.value = Mathf.Clamp(mySlider.value + sliderChange, mySlider.minValue, mySlider.maxValue);
        }
        if (su && mySlider != null)
        {
            float deltaTime = Time.deltaTime > 0 ? Time.deltaTime : 0.002f;
            float sliderChange = 2 * deltaTime;
            mySlider.value = Mathf.Clamp(mySlider.value + sliderChange, mySlider.minValue, mySlider.maxValue);
        }
    }
}