using UnityEngine;

/// <summary>
/// This script represents the basic functionsality of any state
/// </summary>
public abstract class BaseState<T>
{
    protected T _controller;

    public BaseState(T controller)
    { _controller = controller; }
    protected virtual void OnEnter() { }    // Handles everything related when entering any state
    protected abstract void Update();   // Handles everything a state is affected by or affecting in Update()
    protected abstract void FixedUpdate();   // Handles everything a state is affected by or afecting in Fixed Update(), use this in Physics related problems
    protected virtual void OnExit() { }    // Handles everything related when leaving any state
}