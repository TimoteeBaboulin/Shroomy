using System;
using UnityEngine;

public abstract class Shroom : MonoBehaviour{
    public static event Action<Shroom> OnPickUp;

    protected abstract void PickUp(IEntity player);

    public abstract void Use(IEntity player);

    public void OnTriggerEnter(Collider other){
        if (!other.CompareTag("Player")) return;
        
        OnPickUp?.Invoke(this);
        PickUp(other.GetComponent<IEntity>());
    }
}