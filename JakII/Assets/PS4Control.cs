// GENERATED AUTOMATICALLY FROM 'Assets/PS4Control.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PS4Control : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PS4Control()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PS4Control"",
    ""maps"": [
        {
            ""name"": ""Movimientos"",
            ""id"": ""849edb55-1e9a-4c87-81e9-8ca8c7a5be9f"",
            ""actions"": [
                {
                    ""name"": ""agachar"",
                    ""type"": ""Button"",
                    ""id"": ""5e14d3d9-dfa3-436f-b01a-90ff139d4e63"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""saltar"",
                    ""type"": ""Button"",
                    ""id"": ""b098b3c5-8a89-43d9-85a5-501d1ee4af6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Spin"",
                    ""type"": ""Button"",
                    ""id"": ""74aa49d3-0a45-46e5-9578-314ca9c723e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""subirNave"",
                    ""type"": ""Button"",
                    ""id"": ""e1b3c2c6-75d2-48e2-b867-9e5ae8361fea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Caminar"",
                    ""type"": ""Value"",
                    ""id"": ""124a6f38-588b-4f63-93cc-7138a2fc1fe0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""puñetazo"",
                    ""type"": ""Button"",
                    ""id"": ""40c3b987-0e52-4d6b-98e5-8f16685107be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""salirApp"",
                    ""type"": ""Button"",
                    ""id"": ""bd693deb-815d-4501-aff2-15b6db39a59c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""reiniciarApp"",
                    ""type"": ""Button"",
                    ""id"": ""b1eea33b-9cfe-40a8-beb4-cc0baa3d9ff9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d53500b5-dfa5-4e53-86fa-0ff8a70e03bb"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""agachar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2efb8560-89f8-4d16-a07c-3fa5d8be507c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Ps4Control"",
                    ""action"": ""saltar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53ed3621-30ee-4804-b9ac-402f59c1f418"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d56bff73-2129-4979-99ef-2ed397ba2cd6"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Ps4Control"",
                    ""action"": ""subirNave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aba9d8ea-167e-4543-a0b3-5443fcff292d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Ps4Control"",
                    ""action"": ""Caminar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""076b9f48-705a-4bb3-af04-d1b9954e3842"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Ps4Control"",
                    ""action"": ""puñetazo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01b566ad-24b0-41fe-a6c1-9497ba7c221e"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Ps4Control"",
                    ""action"": ""salirApp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5dd3c402-c4a9-471e-aae9-fa896363c1d1"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Ps4Control"",
                    ""action"": ""reiniciarApp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""camara"",
            ""id"": ""a11d4cb4-4e01-4add-8bbe-77f0737a99c9"",
            ""actions"": [
                {
                    ""name"": ""Giro"",
                    ""type"": ""Value"",
                    ""id"": ""8a44802a-c123-469e-991f-952d69102a41"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eb355230-385d-40b1-bfc3-5cb94a062a32"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Ps4Control"",
                    ""action"": ""Giro"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Ps4Control"",
            ""bindingGroup"": ""Ps4Control"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Movimientos
        m_Movimientos = asset.FindActionMap("Movimientos", throwIfNotFound: true);
        m_Movimientos_agachar = m_Movimientos.FindAction("agachar", throwIfNotFound: true);
        m_Movimientos_saltar = m_Movimientos.FindAction("saltar", throwIfNotFound: true);
        m_Movimientos_Spin = m_Movimientos.FindAction("Spin", throwIfNotFound: true);
        m_Movimientos_subirNave = m_Movimientos.FindAction("subirNave", throwIfNotFound: true);
        m_Movimientos_Caminar = m_Movimientos.FindAction("Caminar", throwIfNotFound: true);
        m_Movimientos_puñetazo = m_Movimientos.FindAction("puñetazo", throwIfNotFound: true);
        m_Movimientos_salirApp = m_Movimientos.FindAction("salirApp", throwIfNotFound: true);
        m_Movimientos_reiniciarApp = m_Movimientos.FindAction("reiniciarApp", throwIfNotFound: true);
        // camara
        m_camara = asset.FindActionMap("camara", throwIfNotFound: true);
        m_camara_Giro = m_camara.FindAction("Giro", throwIfNotFound: true);
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

    // Movimientos
    private readonly InputActionMap m_Movimientos;
    private IMovimientosActions m_MovimientosActionsCallbackInterface;
    private readonly InputAction m_Movimientos_agachar;
    private readonly InputAction m_Movimientos_saltar;
    private readonly InputAction m_Movimientos_Spin;
    private readonly InputAction m_Movimientos_subirNave;
    private readonly InputAction m_Movimientos_Caminar;
    private readonly InputAction m_Movimientos_puñetazo;
    private readonly InputAction m_Movimientos_salirApp;
    private readonly InputAction m_Movimientos_reiniciarApp;
    public struct MovimientosActions
    {
        private @PS4Control m_Wrapper;
        public MovimientosActions(@PS4Control wrapper) { m_Wrapper = wrapper; }
        public InputAction @agachar => m_Wrapper.m_Movimientos_agachar;
        public InputAction @saltar => m_Wrapper.m_Movimientos_saltar;
        public InputAction @Spin => m_Wrapper.m_Movimientos_Spin;
        public InputAction @subirNave => m_Wrapper.m_Movimientos_subirNave;
        public InputAction @Caminar => m_Wrapper.m_Movimientos_Caminar;
        public InputAction @puñetazo => m_Wrapper.m_Movimientos_puñetazo;
        public InputAction @salirApp => m_Wrapper.m_Movimientos_salirApp;
        public InputAction @reiniciarApp => m_Wrapper.m_Movimientos_reiniciarApp;
        public InputActionMap Get() { return m_Wrapper.m_Movimientos; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovimientosActions set) { return set.Get(); }
        public void SetCallbacks(IMovimientosActions instance)
        {
            if (m_Wrapper.m_MovimientosActionsCallbackInterface != null)
            {
                @agachar.started -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnAgachar;
                @agachar.performed -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnAgachar;
                @agachar.canceled -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnAgachar;
                @saltar.started -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnSaltar;
                @saltar.performed -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnSaltar;
                @saltar.canceled -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnSaltar;
                @Spin.started -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnSpin;
                @Spin.performed -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnSpin;
                @Spin.canceled -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnSpin;
                @subirNave.started -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnSubirNave;
                @subirNave.performed -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnSubirNave;
                @subirNave.canceled -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnSubirNave;
                @Caminar.started -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnCaminar;
                @Caminar.performed -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnCaminar;
                @Caminar.canceled -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnCaminar;
                @puñetazo.started -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnPuñetazo;
                @puñetazo.performed -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnPuñetazo;
                @puñetazo.canceled -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnPuñetazo;
                @salirApp.started -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnSalirApp;
                @salirApp.performed -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnSalirApp;
                @salirApp.canceled -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnSalirApp;
                @reiniciarApp.started -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnReiniciarApp;
                @reiniciarApp.performed -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnReiniciarApp;
                @reiniciarApp.canceled -= m_Wrapper.m_MovimientosActionsCallbackInterface.OnReiniciarApp;
            }
            m_Wrapper.m_MovimientosActionsCallbackInterface = instance;
            if (instance != null)
            {
                @agachar.started += instance.OnAgachar;
                @agachar.performed += instance.OnAgachar;
                @agachar.canceled += instance.OnAgachar;
                @saltar.started += instance.OnSaltar;
                @saltar.performed += instance.OnSaltar;
                @saltar.canceled += instance.OnSaltar;
                @Spin.started += instance.OnSpin;
                @Spin.performed += instance.OnSpin;
                @Spin.canceled += instance.OnSpin;
                @subirNave.started += instance.OnSubirNave;
                @subirNave.performed += instance.OnSubirNave;
                @subirNave.canceled += instance.OnSubirNave;
                @Caminar.started += instance.OnCaminar;
                @Caminar.performed += instance.OnCaminar;
                @Caminar.canceled += instance.OnCaminar;
                @puñetazo.started += instance.OnPuñetazo;
                @puñetazo.performed += instance.OnPuñetazo;
                @puñetazo.canceled += instance.OnPuñetazo;
                @salirApp.started += instance.OnSalirApp;
                @salirApp.performed += instance.OnSalirApp;
                @salirApp.canceled += instance.OnSalirApp;
                @reiniciarApp.started += instance.OnReiniciarApp;
                @reiniciarApp.performed += instance.OnReiniciarApp;
                @reiniciarApp.canceled += instance.OnReiniciarApp;
            }
        }
    }
    public MovimientosActions @Movimientos => new MovimientosActions(this);

    // camara
    private readonly InputActionMap m_camara;
    private ICamaraActions m_CamaraActionsCallbackInterface;
    private readonly InputAction m_camara_Giro;
    public struct CamaraActions
    {
        private @PS4Control m_Wrapper;
        public CamaraActions(@PS4Control wrapper) { m_Wrapper = wrapper; }
        public InputAction @Giro => m_Wrapper.m_camara_Giro;
        public InputActionMap Get() { return m_Wrapper.m_camara; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CamaraActions set) { return set.Get(); }
        public void SetCallbacks(ICamaraActions instance)
        {
            if (m_Wrapper.m_CamaraActionsCallbackInterface != null)
            {
                @Giro.started -= m_Wrapper.m_CamaraActionsCallbackInterface.OnGiro;
                @Giro.performed -= m_Wrapper.m_CamaraActionsCallbackInterface.OnGiro;
                @Giro.canceled -= m_Wrapper.m_CamaraActionsCallbackInterface.OnGiro;
            }
            m_Wrapper.m_CamaraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Giro.started += instance.OnGiro;
                @Giro.performed += instance.OnGiro;
                @Giro.canceled += instance.OnGiro;
            }
        }
    }
    public CamaraActions @camara => new CamaraActions(this);
    private int m_Ps4ControlSchemeIndex = -1;
    public InputControlScheme Ps4ControlScheme
    {
        get
        {
            if (m_Ps4ControlSchemeIndex == -1) m_Ps4ControlSchemeIndex = asset.FindControlSchemeIndex("Ps4Control");
            return asset.controlSchemes[m_Ps4ControlSchemeIndex];
        }
    }
    public interface IMovimientosActions
    {
        void OnAgachar(InputAction.CallbackContext context);
        void OnSaltar(InputAction.CallbackContext context);
        void OnSpin(InputAction.CallbackContext context);
        void OnSubirNave(InputAction.CallbackContext context);
        void OnCaminar(InputAction.CallbackContext context);
        void OnPuñetazo(InputAction.CallbackContext context);
        void OnSalirApp(InputAction.CallbackContext context);
        void OnReiniciarApp(InputAction.CallbackContext context);
    }
    public interface ICamaraActions
    {
        void OnGiro(InputAction.CallbackContext context);
    }
}
