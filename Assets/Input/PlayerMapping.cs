//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/PlayerMapping.inputactions
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

public partial class @PlayerMapping: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMapping()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMapping"",
    ""maps"": [
        {
            ""name"": ""PlayerMap"",
            ""id"": ""d35c2e0e-5649-4678-9238-65fbe3e219cb"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""f6be0976-e837-4415-8753-58baa3e3231b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""YAxis"",
                    ""type"": ""Button"",
                    ""id"": ""e897cc19-1e58-4876-8c73-ad2929f13560"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""XAxis"",
                    ""type"": ""Button"",
                    ""id"": ""719cdcd5-7dda-4422-8c07-ceb7389e3b23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""adb8849e-19cc-4310-9607-60a474e2b897"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Collect"",
                    ""type"": ""Button"",
                    ""id"": ""754be670-f4ce-4fdf-a7b0-d67d234b2866"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Respawn"",
                    ""type"": ""Button"",
                    ""id"": ""3e0b5380-e9cb-4140-8144-32ed3283a4ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""384d3407-a9fb-4f9c-823c-47cd6792244e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""deb58705-24d0-4fc9-842f-17c134c2b186"",
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
                    ""id"": ""3ee8cfd3-3f58-42d7-9549-f4b755450dce"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""948d9c22-57c8-483e-9e5d-baf4a710177d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d3caa4ea-e2b9-4b74-8747-e0418d23a883"",
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
                    ""id"": ""645de7b7-430b-44e0-9915-9ad78cc8cc97"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e0ca4933-ae7e-4d8a-b292-5334afccc2b0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""151e7619-2255-4b84-b638-5f8cb7c29ba9"",
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
                    ""id"": ""a0651d5f-a3f8-4a94-9d29-a9e91b3cc6e2"",
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
                    ""id"": ""11e8f848-f35b-4870-b218-fe60e4de7535"",
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
                    ""id"": ""81f72d38-d173-456b-82ab-bf76c19ba466"",
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
                    ""id"": ""e58d87b8-3dbd-40be-8729-7898fef22042"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bd27183a-d4b9-410e-83a2-24034ddaaeb5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6573be4c-bb6c-45d1-acec-dc95c1a73246"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4dca08b5-e8a1-4186-b328-94d3b8e943b9"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42e75142-cde3-4b2d-ae1b-4955ffe0a6e0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Collect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c41a5c7a-3201-42ae-b638-7e6d81a71037"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Collect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b220814b-d67a-4445-a23f-c4711f8e4e8c"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Respawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMap
        m_PlayerMap = asset.FindActionMap("PlayerMap", throwIfNotFound: true);
        m_PlayerMap_Jump = m_PlayerMap.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMap_YAxis = m_PlayerMap.FindAction("YAxis", throwIfNotFound: true);
        m_PlayerMap_XAxis = m_PlayerMap.FindAction("XAxis", throwIfNotFound: true);
        m_PlayerMap_Drop = m_PlayerMap.FindAction("Drop", throwIfNotFound: true);
        m_PlayerMap_Collect = m_PlayerMap.FindAction("Collect", throwIfNotFound: true);
        m_PlayerMap_Respawn = m_PlayerMap.FindAction("Respawn", throwIfNotFound: true);
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

    // PlayerMap
    private readonly InputActionMap m_PlayerMap;
    private List<IPlayerMapActions> m_PlayerMapActionsCallbackInterfaces = new List<IPlayerMapActions>();
    private readonly InputAction m_PlayerMap_Jump;
    private readonly InputAction m_PlayerMap_YAxis;
    private readonly InputAction m_PlayerMap_XAxis;
    private readonly InputAction m_PlayerMap_Drop;
    private readonly InputAction m_PlayerMap_Collect;
    private readonly InputAction m_PlayerMap_Respawn;
    public struct PlayerMapActions
    {
        private @PlayerMapping m_Wrapper;
        public PlayerMapActions(@PlayerMapping wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PlayerMap_Jump;
        public InputAction @YAxis => m_Wrapper.m_PlayerMap_YAxis;
        public InputAction @XAxis => m_Wrapper.m_PlayerMap_XAxis;
        public InputAction @Drop => m_Wrapper.m_PlayerMap_Drop;
        public InputAction @Collect => m_Wrapper.m_PlayerMap_Collect;
        public InputAction @Respawn => m_Wrapper.m_PlayerMap_Respawn;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMapActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerMapActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerMapActionsCallbackInterfaces.Add(instance);
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @YAxis.started += instance.OnYAxis;
            @YAxis.performed += instance.OnYAxis;
            @YAxis.canceled += instance.OnYAxis;
            @XAxis.started += instance.OnXAxis;
            @XAxis.performed += instance.OnXAxis;
            @XAxis.canceled += instance.OnXAxis;
            @Drop.started += instance.OnDrop;
            @Drop.performed += instance.OnDrop;
            @Drop.canceled += instance.OnDrop;
            @Collect.started += instance.OnCollect;
            @Collect.performed += instance.OnCollect;
            @Collect.canceled += instance.OnCollect;
            @Respawn.started += instance.OnRespawn;
            @Respawn.performed += instance.OnRespawn;
            @Respawn.canceled += instance.OnRespawn;
        }

        private void UnregisterCallbacks(IPlayerMapActions instance)
        {
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @YAxis.started -= instance.OnYAxis;
            @YAxis.performed -= instance.OnYAxis;
            @YAxis.canceled -= instance.OnYAxis;
            @XAxis.started -= instance.OnXAxis;
            @XAxis.performed -= instance.OnXAxis;
            @XAxis.canceled -= instance.OnXAxis;
            @Drop.started -= instance.OnDrop;
            @Drop.performed -= instance.OnDrop;
            @Drop.canceled -= instance.OnDrop;
            @Collect.started -= instance.OnCollect;
            @Collect.performed -= instance.OnCollect;
            @Collect.canceled -= instance.OnCollect;
            @Respawn.started -= instance.OnRespawn;
            @Respawn.performed -= instance.OnRespawn;
            @Respawn.canceled -= instance.OnRespawn;
        }

        public void RemoveCallbacks(IPlayerMapActions instance)
        {
            if (m_Wrapper.m_PlayerMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerMapActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerMapActions @PlayerMap => new PlayerMapActions(this);
    public interface IPlayerMapActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnYAxis(InputAction.CallbackContext context);
        void OnXAxis(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
        void OnCollect(InputAction.CallbackContext context);
        void OnRespawn(InputAction.CallbackContext context);
    }
}
