using System.Collections;
using TMPro;
using UnityEngine;

namespace MyFps
{
    /// <summary>
    /// 첫번째 트리거 시퀀스 실행
    /// </summary>
    public class BFirstTrigger : MonoBehaviour
    {
        #region Variabels
        //플레이어 오브젝트
        public GameObject thePlayer;

        //시퀀스UI
        public TextMeshProUGUI sequenceText;
        [SerializeField]
        private string sequence = "Looks like a weapon on that table.";

        //화살표 오브젝트
        public GameObject theMaker;
        #endregion

        #region Unity Event Method 
        private void OnTriggerEnter(Collider other)
        {
            //트리거 시퀀스 플레이
            StartCoroutine(SequencePlay());
        }
        #endregion

        #region Custom Method
        IEnumerator SequencePlay()
        {
            //플레이 캐릭터 비활성화(플레이 멈춤)
            thePlayer.SetActive(false);

            //대사 출력
            sequenceText.text = sequence;
            yield return new WaitForSeconds(2f);    //1초 딜레이

            //화살표 활성화
            theMaker.SetActive(true);
            yield return new WaitForSeconds(1f);    //1초 딜레이

            //초기화
            sequenceText.text = ""; //텍스트 초기화
            this.transform.GetComponent<BoxCollider>().enabled = false;     //충돌체 비활성화

            //플레이 캐릭터 활성화 (다시 플레이)
            thePlayer.SetActive(true);
        }
        #endregion
    }
}
