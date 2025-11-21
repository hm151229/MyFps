using UnityEngine;
namespace MyFps
{
    /// <summary>
    /// 피스톨 아이템 획득하기
    /// </summary>
    public class PickupPistol : Interactive
    {
        #region Variables
        [Header ("Interactive Action")]
        //액션
        public GameObject fakePistol;
        public GameObject realPistol;
        public GameObject theMarker;
        #endregion

        #region Custom Method
        protected override void DoAction()
        {
            //UI
            HideActionUI();

            fakePistol.SetActive(false);

            realPistol.SetActive(true);

            theMarker.SetActive(false);
        }
        #endregion
    }
}