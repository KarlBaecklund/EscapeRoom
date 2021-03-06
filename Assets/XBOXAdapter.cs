//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/XBOXAdapter.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @XBOXAdapter : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @XBOXAdapter()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""XBOXAdapter"",
    ""maps"": [
        {
            ""name"": ""Signal"",
            ""id"": ""1459791f-5402-400c-ac14-8fdc8ed99dc2"",
            ""actions"": [
                {
                    ""name"": ""A Button"",
                    ""type"": ""Button"",
                    ""id"": ""fec3521d-1485-4dfa-b3bf-a40ecb4c24d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""B Button"",
                    ""type"": ""Button"",
                    ""id"": ""c54ed5a1-5d06-4c30-bfd2-417466db073e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""X Button"",
                    ""type"": ""Button"",
                    ""id"": ""a45df644-c550-42e3-81c5-060b87bfe189"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Y Button"",
                    ""type"": ""Button"",
                    ""id"": ""481adb3d-93bf-49e2-a720-889f1f4250bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Up Button"",
                    ""type"": ""Button"",
                    ""id"": ""0ddd9a45-67d8-4e29-9c75-7192c9ed0297"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Down Button"",
                    ""type"": ""Button"",
                    ""id"": ""33e8ce8e-14af-4c9b-838d-fefa6c8b9db8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""84d69c89-fcf1-4fec-a115-b103c8287f44"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3def6d15-3a23-4b7c-9beb-ac0dbba7e792"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bd843a3-0260-4ae2-b127-63a5d34fd19b"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""740f0bd2-6270-4704-8111-36ddde07b80f"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98cd3268-8f2f-409a-82ca-c158c3ac2ccf"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""372790f2-0e58-41bc-aa0d-f4aca60f171d"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Signal
        m_Signal = asset.FindActionMap("Signal", throwIfNotFound: true);
        m_Signal_AButton = m_Signal.FindAction("A Button", throwIfNotFound: true);
        m_Signal_BButton = m_Signal.FindAction("B Button", throwIfNotFound: true);
        m_Signal_XButton = m_Signal.FindAction("X Button", throwIfNotFound: true);
        m_Signal_YButton = m_Signal.FindAction("Y Button", throwIfNotFound: true);
        m_Signal_UpButton = m_Signal.FindAction("Up Button", throwIfNotFound: true);
        m_Signal_DownButton = m_Signal.FindAction("Down Button", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Signal
    private readonly InputActionMap m_Signal;
    private ISignalActions m_SignalActionsCallbackInterface;
    private readonly InputAction m_Signal_AButton;
    private readonly InputAction m_Signal_BButton;
    private readonly InputAction m_Signal_XButton;
    private readonly InputAction m_Signal_YButton;
    private readonly InputAction m_Signal_UpButton;
    private readonly InputAction m_Signal_DownButton;
    public struct SignalActions
    {
        private @XBOXAdapter m_Wrapper;
        public SignalActions(@XBOXAdapter wrapper) { m_Wrapper = wrapper; }
        public InputAction @AButton => m_Wrapper.m_Signal_AButton;
        public InputAction @BButton => m_Wrapper.m_Signal_BButton;
        public InputAction @XButton => m_Wrapper.m_Signal_XButton;
        public InputAction @YButton => m_Wrapper.m_Signal_YButton;
        public InputAction @UpButton => m_Wrapper.m_Signal_UpButton;
        public InputAction @DownButton => m_Wrapper.m_Signal_DownButton;
        public InputActionMap Get() { return m_Wrapper.m_Signal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SignalActions set) { return set.Get(); }
        public void SetCallbacks(ISignalActions instance)
        {
            if (m_Wrapper.m_SignalActionsCallbackInterface != null)
            {
                @AButton.started -= m_Wrapper.m_SignalActionsCallbackInterface.OnAButton;
                @AButton.performed -= m_Wrapper.m_SignalActionsCallbackInterface.OnAButton;
                @AButton.canceled -= m_Wrapper.m_SignalActionsCallbackInterface.OnAButton;
                @BButton.started -= m_Wrapper.m_SignalActionsCallbackInterface.OnBButton;
                @BButton.performed -= m_Wrapper.m_SignalActionsCallbackInterface.OnBButton;
                @BButton.canceled -= m_Wrapper.m_SignalActionsCallbackInterface.OnBButton;
                @XButton.started -= m_Wrapper.m_SignalActionsCallbackInterface.OnXButton;
                @XButton.performed -= m_Wrapper.m_SignalActionsCallbackInterface.OnXButton;
                @XButton.canceled -= m_Wrapper.m_SignalActionsCallbackInterface.OnXButton;
                @YButton.started -= m_Wrapper.m_SignalActionsCallbackInterface.OnYButton;
                @YButton.performed -= m_Wrapper.m_SignalActionsCallbackInterface.OnYButton;
                @YButton.canceled -= m_Wrapper.m_SignalActionsCallbackInterface.OnYButton;
                @UpButton.started -= m_Wrapper.m_SignalActionsCallbackInterface.OnUpButton;
                @UpButton.performed -= m_Wrapper.m_SignalActionsCallbackInterface.OnUpButton;
                @UpButton.canceled -= m_Wrapper.m_SignalActionsCallbackInterface.OnUpButton;
                @DownButton.started -= m_Wrapper.m_SignalActionsCallbackInterface.OnDownButton;
                @DownButton.performed -= m_Wrapper.m_SignalActionsCallbackInterface.OnDownButton;
                @DownButton.canceled -= m_Wrapper.m_SignalActionsCallbackInterface.OnDownButton;
            }
            m_Wrapper.m_SignalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AButton.started += instance.OnAButton;
                @AButton.performed += instance.OnAButton;
                @AButton.canceled += instance.OnAButton;
                @BButton.started += instance.OnBButton;
                @BButton.performed += instance.OnBButton;
                @BButton.canceled += instance.OnBButton;
                @XButton.started += instance.OnXButton;
                @XButton.performed += instance.OnXButton;
                @XButton.canceled += instance.OnXButton;
                @YButton.started += instance.OnYButton;
                @YButton.performed += instance.OnYButton;
                @YButton.canceled += instance.OnYButton;
                @UpButton.started += instance.OnUpButton;
                @UpButton.performed += instance.OnUpButton;
                @UpButton.canceled += instance.OnUpButton;
                @DownButton.started += instance.OnDownButton;
                @DownButton.performed += instance.OnDownButton;
                @DownButton.canceled += instance.OnDownButton;
            }
        }
    }
    public SignalActions @Signal => new SignalActions(this);
    public interface ISignalActions
    {
        void OnAButton(InputAction.CallbackContext context);
        void OnBButton(InputAction.CallbackContext context);
        void OnXButton(InputAction.CallbackContext context);
        void OnYButton(InputAction.CallbackContext context);
        void OnUpButton(InputAction.CallbackContext context);
        void OnDownButton(InputAction.CallbackContext context);
    }
}
