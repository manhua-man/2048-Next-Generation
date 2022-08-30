using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[CreateAssetMenu(menuName ="Player Input")]
public class PlayerInputs : ScriptableObject,InputActions.IGameplayActions
{
    public event UnityAction<Vector2> onMove;

    //¿ÕÎ¯ÍÐ
    public event UnityAction onStopMove=delegate { };
    InputActions inputActions;

    private void OnDisable()
    {
        DisablePlayInput();
    }
    void OnEnable()
    {
        inputActions = new InputActions();
        inputActions.Gameplay.SetCallbacks(this);
    }
    public void EnablePlayInput()
    {
        inputActions.Gameplay.Enable();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void DisablePlayInput()
    {
        inputActions.Gameplay.Disable();
    }
    public void OnDodge(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnLaunchMissile(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.phase==InputActionPhase.Performed)
        {
            onMove?.Invoke(context.ReadValue<Vector2>());
        }
        if (context.phase==InputActionPhase.Canceled)
        {
            onStopMove.Invoke();
        }
    }

    public void OnOverdrive(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

   
}
