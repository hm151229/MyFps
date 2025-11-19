using UnityEngine;
namespace MySample
{
    /// <summary>
    /// 충돌체의 Collision 충돌 체크
    /// </summary>
    public class CollisionTest : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log($"OnCollisionEnter : {collision.gameObject.name}");

            MoveObject moveObject = collision.gameObject.GetComponent<MoveObject>();
            if (moveObject)
            {
                moveObject.MoveLeft();
            }
        }
        private void OnCollisionStay(Collision collision)
        {
            Debug.Log($"OnCollisionStay : {collision.gameObject.name}");
        }
        void OnCollisionExit(Collision collision) 
        {
            Debug.Log($"OnCollisionExit : {collision.gameObject.name}");
            MoveObject moveObject = collision.gameObject.GetComponent<MoveObject>();
            if (moveObject)
            {
                moveObject.MoveRight();
            }
        }
    }
}
