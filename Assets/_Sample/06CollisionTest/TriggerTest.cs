using UnityEngine;
namespace MySample
{
    /// <summary>
    /// 충돌체의 Trigger 충돌 체크
    /// </summary>
    public class TriggerTest : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log($"OnTriggerEnter : {other.name}");
            MoveObject moveObject = other.GetComponent<MoveObject>();
            if (moveObject)
            {
                moveObject.MoveRight();
                moveObject.ChangeMoveColor();
            }
                
        }
        private void OnTriggerStay(Collider other)
        {
            Debug.Log($"OnTriggerStay : {other.name}");

        }
        private void OnTriggerExit(Collider other)
        {
            Debug.Log($"OnTriggerExit : {other.name}");
            MoveObject moveObject = other.GetComponent<MoveObject>();
            if (moveObject)
            {
                moveObject.MoveLeft();
                moveObject.ResetMoveColor();
            }
        }
    }
}