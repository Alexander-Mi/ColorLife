using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

[RequireComponent(typeof(NavMeshAgent))]
public class MoveController : MonoBehaviour
{
   private NavMeshAgent _agent;
   

   private void Start()
   {
      _agent = GetComponent<NavMeshAgent>();
   }

   public void MoveToPoint(Vector3 point)
   {
      _agent.SetDestination(point);
   }
}
