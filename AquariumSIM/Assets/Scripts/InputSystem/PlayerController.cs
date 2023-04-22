//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/InputSystem/PlayerController.inputactions
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

public partial class @PlayerController : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""d580d9f3-a4bd-42b0-87a4-6630ad6ca19c"",
            ""actions"": [
                {
                    ""name"": ""XAxis"",
                    ""type"": ""Value"",
                    ""id"": ""3a1fdc4c-ae98-4f0f-91ee-b10cd28cb01f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""YAxis"",
                    ""type"": ""Value"",
                    ""id"": ""c401e467-5868-48c9-bb4f-731f20de7b36"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ZAxis"",
                    ""type"": ""Value"",
                    ""id"": ""4f702953-9eab-4fb4-a43c-6949db7bdc12"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""68719a34-d35c-46e2-a405-d9c12be965b4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XAxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""739cd2ac-9ff3-42b1-ac3d-9d7e4438d446"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""261884a0-7bc2-4073-a5bd-8c87199854e6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""90150b76-39e2-4bd0-82e7-f87ea9f50e01"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZAxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f9cb3f31-d5c9-478f-a714-b65fa4d9a080"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6f362484-2d93-487b-ae92-fd92b030558d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""ce5d8124-8656-43d7-ab86-ab01e1239f3e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8a82ab03-2060-4025-9911-40910b263c50"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f2ed9f31-8920-4c27-ad39-8e3947eb7e1c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_XAxis = m_Movement.FindAction("XAxis", throwIfNotFound: true);
        m_Movement_YAxis = m_Movement.FindAction("YAxis", throwIfNotFound: true);
        m_Movement_ZAxis = m_Movement.FindAction("ZAxis", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_XAxis;
    private readonly InputAction m_Movement_YAxis;
    private readonly InputAction m_Movement_ZAxis;
    public struct MovementActions
    {
        private @PlayerController m_Wrapper;
        public MovementActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @XAxis => m_Wrapper.m_Movement_XAxis;
        public InputAction @YAxis => m_Wrapper.m_Movement_YAxis;
        public InputAction @ZAxis => m_Wrapper.m_Movement_ZAxis;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @XAxis.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnXAxis;
                @XAxis.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnXAxis;
                @XAxis.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnXAxis;
                @YAxis.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnYAxis;
                @YAxis.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnYAxis;
                @YAxis.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnYAxis;
                @ZAxis.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnZAxis;
                @ZAxis.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnZAxis;
                @ZAxis.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnZAxis;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @XAxis.started += instance.OnXAxis;
                @XAxis.performed += instance.OnXAxis;
                @XAxis.canceled += instance.OnXAxis;
                @YAxis.started += instance.OnYAxis;
                @YAxis.performed += instance.OnYAxis;
                @YAxis.canceled += instance.OnYAxis;
                @ZAxis.started += instance.OnZAxis;
                @ZAxis.performed += instance.OnZAxis;
                @ZAxis.canceled += instance.OnZAxis;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnXAxis(InputAction.CallbackContext context);
        void OnYAxis(InputAction.CallbackContext context);
        void OnZAxis(InputAction.CallbackContext context);
    }
}