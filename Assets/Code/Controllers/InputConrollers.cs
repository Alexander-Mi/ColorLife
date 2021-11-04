using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(MoveController))]
public class InputConrollers : MonoBehaviour
{
   private Camera mainCamera;
   private MoveController _move;
   [SerializeField] private InteractableController _focus;
   public Material _material;
 
   private void Start()
   {
      mainCamera = Camera.main;
      _move = GetComponent<MoveController>();
   }

   private void Update()
   {
      if (Input.GetMouseButton(0))
      {
         Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
         RaycastHit hit;
         if (Physics.Raycast(ray, out hit))
         {
            print($"{hit.collider.name}-{hit.point}");
            _move.MoveToPoint(hit.point);
            RemoveFocus();
            
            
            
         }
         
      }
      else if (Input.GetMouseButton(1))
      {
         Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
         RaycastHit hit;
         if (Physics.Raycast(ray, out hit))
         {
            var _interactable = hit.collider.GetComponent<InteractableController>();
            if (_interactable != null)
            {
               SetFocus(_interactable);
               Debug.Log("взаимодействие");
            }
         }
      }
   }

   private void SetFocus(InteractableController _newFocus)
   {
      _focus = _newFocus;
   }

   private void RemoveFocus()
   {
      _focus = null;
   }
}
