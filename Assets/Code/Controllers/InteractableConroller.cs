using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableController : MonoBehaviour
{
    public float _interactRadius;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color=Color.white;
        Gizmos.DrawWireSphere(transform.position, _interactRadius);
    }
}
