//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Input/CustomInput.inputactions
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

public partial class @CustomInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CustomInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CustomInput"",
    ""maps"": [
        {
            ""name"": ""Ingame"",
            ""id"": ""129d4ca0-430e-47fd-abf9-da75c1ebcd35"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""ed7fc72f-46ff-486f-8841-9521b1e24823"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Value"",
                    ""id"": ""818e50ea-d978-4400-877a-3cc66028433d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""37608a23-f666-452c-81dd-d176d07524cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Canvas"",
                    ""type"": ""Button"",
                    ""id"": ""83fe3715-9e39-4c08-a15c-c21fe4f11cfb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AWSD"",
                    ""id"": ""dac9cbf4-fcb2-4a32-881f-219e14187423"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""01d32c21-baf6-49f6-90bd-b29fa3c7adca"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""5e5d4045-86cc-4afe-a853-5ecb92cbcf6a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""d74982ee-8a95-406f-955f-0bb0b818bba0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""57a2c7e9-267b-4ceb-a3c5-b7b29104e6f6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""46be150b-84de-442f-b836-c1769e26c23f"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b50b0018-2511-4e19-8fac-906fe3d4bd6b"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5fb58924-d16c-4ba8-995c-9e7d3521efd1"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Canvas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Ingame
        m_Ingame = asset.FindActionMap("Ingame", throwIfNotFound: true);
        m_Ingame_Movement = m_Ingame.FindAction("Movement", throwIfNotFound: true);
        m_Ingame_Dash = m_Ingame.FindAction("Dash", throwIfNotFound: true);
        m_Ingame_Fire = m_Ingame.FindAction("Fire", throwIfNotFound: true);
        m_Ingame_Canvas = m_Ingame.FindAction("Canvas", throwIfNotFound: true);
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

    // Ingame
    private readonly InputActionMap m_Ingame;
    private List<IIngameActions> m_IngameActionsCallbackInterfaces = new List<IIngameActions>();
    private readonly InputAction m_Ingame_Movement;
    private readonly InputAction m_Ingame_Dash;
    private readonly InputAction m_Ingame_Fire;
    private readonly InputAction m_Ingame_Canvas;
    public struct IngameActions
    {
        private @CustomInput m_Wrapper;
        public IngameActions(@CustomInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Ingame_Movement;
        public InputAction @Dash => m_Wrapper.m_Ingame_Dash;
        public InputAction @Fire => m_Wrapper.m_Ingame_Fire;
        public InputAction @Canvas => m_Wrapper.m_Ingame_Canvas;
        public InputActionMap Get() { return m_Wrapper.m_Ingame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(IngameActions set) { return set.Get(); }
        public void AddCallbacks(IIngameActions instance)
        {
            if (instance == null || m_Wrapper.m_IngameActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_IngameActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Dash.started += instance.OnDash;
            @Dash.performed += instance.OnDash;
            @Dash.canceled += instance.OnDash;
            @Fire.started += instance.OnFire;
            @Fire.performed += instance.OnFire;
            @Fire.canceled += instance.OnFire;
            @Canvas.started += instance.OnCanvas;
            @Canvas.performed += instance.OnCanvas;
            @Canvas.canceled += instance.OnCanvas;
        }

        private void UnregisterCallbacks(IIngameActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Dash.started -= instance.OnDash;
            @Dash.performed -= instance.OnDash;
            @Dash.canceled -= instance.OnDash;
            @Fire.started -= instance.OnFire;
            @Fire.performed -= instance.OnFire;
            @Fire.canceled -= instance.OnFire;
            @Canvas.started -= instance.OnCanvas;
            @Canvas.performed -= instance.OnCanvas;
            @Canvas.canceled -= instance.OnCanvas;
        }

        public void RemoveCallbacks(IIngameActions instance)
        {
            if (m_Wrapper.m_IngameActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IIngameActions instance)
        {
            foreach (var item in m_Wrapper.m_IngameActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_IngameActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public IngameActions @Ingame => new IngameActions(this);
    public interface IIngameActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnCanvas(InputAction.CallbackContext context);
    }
}
