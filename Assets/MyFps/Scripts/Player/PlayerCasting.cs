using UnityEngine;
namespace MyFps
{
    /// <summary>
    /// 플레이어와 정면에 있는 오브젝트와의 거리 구하기
    /// </summary>
    public class PlayerCasting : MonoBehaviour
    {
        #region Variables
        public static float distanceFromTarget;    //플레이어와 정면에 있는 오브젝트와의 거리
        [SerializeField]
        public float toTarget;
        #endregion

        #region Unity Event Method
        private void Update()
        {
            //오브젝트와의 거리 구하기
            RaycastHit hit; //hit했을 때 hit 정보를 저장
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                //hit에 성공하면
                distanceFromTarget = hit.distance;
                toTarget = hit.distance;
            }
        }

        //레이케스트 기즈모로 그리기
        private void OnDrawGizmosSelected()
        {
            float maxDistance = 100f;

            RaycastHit hit;
            bool ishit = Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out hit);
            
            Gizmos.color = Color.red;
            if (ishit)
            {
                Gizmos.DrawRay(transform.position, transform.forward * hit.distance);
            }
            else
            {
                Gizmos.DrawRay(transform.position, transform.forward * maxDistance);
            }
        }
        #endregion

        #region
        #endregion
    }
}
