using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupScript : MonoBehaviour
{
    public void Popup_explane()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨       이지모드 튜토리얼 처음
        "튜토리얼",
        "안녕하세요 로딩암 시뮬레이션에 오신걸 환영합니다\r\n\r\n" +
        "로딩암은 기름, 케미칼, LNG 및 LPG 화물의 선적이나 하역을 위해 사용되는 장비로서 원유 운반선 화학제품 운반선, " +
        "LNG운반선 및 LPG 운반선 등에 설치된 메니 폴드 부두와 부두에 설치된 로딩암을 통해 하역 작업이 이루어지게 합니다. \r\n 로딩암은 통상 마린로딩암 또는 칙산으로 지칭 되고 있으며," +
        " 주로대량의 액체나 기체의 화울을 이송하기위해 이용됩니다.\r\n\r\n" +
        "( F 를 눌러 팝업을 닫습니다.)");
        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("ffffffffffffffff");
            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();

            //  gotutorial();
        }
    }

    public void Popup_good()
    {
        PopupSystem.instance.OpenPopUp(// 확인버튼
        "튜토리얼", "훌륭한 조작입니다! 다음 단계로 넘어가겠습니다.\r\n\r\n" +
        "( F 를 눌러 팝업을 닫습니다.)");

    }
    public void Popup_good2()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
        "튜토리얼", "훌륭한 조작입니다! \r\n" + "자유조종시에는 E키를 눌러 동시에 조종할 수 있습니다." +
        "다음 단계로 넘어가겠습니다.\r\n\r\n" +
        "( F 를 눌러 팝업을 닫습니다.)");

    }
    public void Popup_end()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
        "튜토리얼", "축하합니다! 이제 모든조작을 배웠습니다. \r\n다음은 지금까지 배운 지식을 활용하여 배와의 연결을 시도해 보십시오.\r\n\r\n" +
        "( F 를 눌러 팝업을 닫습니다.)");

    }

    public void Popup_1()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
        "튜토리얼", " 로딩암 시뮬레이션을 시작합니다. \r\n조작법에 대해 배워봅시다.\r\n\r\n" + "( F 를 눌러 팝업을 닫습니다.)")
         ;

    }

    public void Popup_2()
    {       
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨       p1파트
       "튜토리얼", "먼저 조작을 배워봅니다.로딩암의 조종은 크게 3파트로 나뉩니다. \r\n 로딩암을 기울이는 것 두개. 중심축을 회전시키는 것 하나입니다. " +
       "[Q] 를 누르면 활성화가 가능합니다\r\n" +
       "[좌] [우] 화살표를 눌러 파트1번을 조종 해보세요.\r\n\r\n" +
       " (F 를 눌러 팝업을 닫습니다.)");

    }

    public void Popup_3()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨           p2파트 
       "튜토리얼", "이번에는 주입구 파트를 조종하겠습니다.\r\n 이 부분을 조종하여 선박의 연결부와 가까워지면 자연스럽게 연결이 시작됩니다. \r\n" +
       "[W] 를 누르면 활성화가 가능합니다\r\n" +
       "[좌] [우] 화살표를 눌러 파트2번을 조종 해보세요.\r\n\r\n" + "( F 를 눌러 팝업을 닫습니다.)");

    }
    public void Popup_4()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨       중심축 파트
       "튜토리얼", "이번에는 로딩암 중심축을 조종하겠습니다. \r\n 이 부분을 조종하여 로딩암의 좌우를 회전시켜 더욱 자세한 조종이 가능해 집니다. \r\n " +
       "[U] [I] 키를 눌러 기둥을 조종 해보세요. \r\n\r\n " + "( F 를 눌러 팝업을 닫습니다.)");

    }
    public void Popup_5()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨       카메라 조종파트
       "튜토리얼", "이번에는 카메라를 전환해 보겠습니다.\r\n왼쪽 쉬프트(Shift)키를 누르면 카메라 전환을 통해 좀더 섬세한 조종이 가능합니다.\r\n 3가지 시점을 활용하여 선박과의 연결을 성공시킬 수 있습니다. "
       + " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)");

    }
    public void Popup_Ani_In()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨       //로딩암 난이도 하 연결애니메이션
     "튜토리얼", "로딩암은 여러 액체물질을 이송할 수 있습니다. \r\n 또한 로딩암의 호스에 따라서 이송가능한 액체물질이 달라집니다\r\n\r\n" +
     "주로 [원유,중질 유 및 동식물 유, 석유화학 제품, LPG ] 이 이송됩니다. "

     + " \r\n \r\n( F 를 눌러 연결을 시작하세요.)");
    }
  
    public void Popup_Ani_out()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨       //로딩암 난이도 하 연결 해제애니메이션
     "튜토리얼", "\r\n로딩암의 주유가 끝이나면 밸브를 해제합니다. 주유가 끝난 후에 로딩암은 원상태로 복귀하고 점검을 실시하게 됩니다.\r\n" +
     "\r\n 이 해제작업또한 안전사고가 많기때문에 주의를 해야합니다. "

     + " \r\n \r\n( F 를 눌러 해제을 시작하세요.)");
    }
    
   


    public void Popup_endSimul()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨       // 튜토리얼 종료
     "튜토리얼", "\r\n 축하합니다! 모든 튜토리얼 성공적으로 마쳤습니다. \r\n\r\n조금더 실제같고 어려운 조작을 원한다면 난이도 [상] 모드를 플레이해 보십시오. "

     );
    }
    public void Popup_1_hard()          //하드모드 시작팝업
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "튜토리얼", "HardMode에 오신 여러분을 환영합니다. \r\n\r\n 이 모드는 EasyMode를 완료한,로딩암 조종견습생 및 전문가를 위한 모드입니다.\r\n " +
     "\r\n 로딩암에 대한 절차적인 정보가 제공되며, " +
     "실제 로딩암 조종을 위한 좋은 연습방법이 될것입니다. " + " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)"

     );
    }
    public void Popup_2_hard()
        {
            PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨       //하드모드 처음 시작설명팝업 1
         "튜토리얼", "저희가 다룰 로딩암은  RCMA (Rotary Counterweighted Marine Arm 입니다.\r\n \r\n" + "이 모델은 중형 탱커나 대형 탱커의 하역에주로 사용됩니다.\r\n\r\n" +
         "RCMA는 단일 평형추를 이용하여 인 보드 암과 아웃 보드 암의 균형을 동시에 균형을 이루며, \r\n RCMA는 구형의 커다란 로딩 암 구조(DCMA)와 비교해서 훨씬 가벼운 구조로 이루어져 있습니다. " +
         " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)"
         );
        }
    public void Popup_3_hard()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨     //하드모드 처음 시작설명팝업 2
     "튜토리얼", "로링암 운전시 유의점으로 \r\n\r\n  로딩암의 암(Arm)의 운동 각도범위는 10°이상 70°이하인 것으로 하며.\r\n \r\n " +
     " 로딩암은 차량과 로딩암의 위치가 직각에서 ±20°에서도 이입·충전 작업이 가능한 것으로 합니다." +
     
     " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)"
     );
    }
    public void Popup_connection_hard()         //하드모드  로딩암조종해서 연결부 맞았을때 뜨는 팝업
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "튜토리얼", "로딩암과 선박의 연결부위가 매치되었습니다.\r\n\r\n 로딩암과 선박의 결합시에는 실제로는 사람이 옆에서 연결을 합니다." +
     "  \r\n \r\n 이외 추가 연결설명 필요! " + "연결 애니메이션이 시작됩니다.\r\n \r\n " +

     " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)"
     );
    }
    public void Popup_Ani_In_hard()     //하드모드 로딩암 주입설명1
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "튜토리얼", "로딩암 주입 설명1 "

     + " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)");
    }
    public void Popup_Ani_In_hard2()        //하드모드 로딩암 주입설명2
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "튜토리얼", "로딩암 주입 설명2 "

     + " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)");
    }
  
    public void Popup_Ani_out_hard()        //하드모드 로딩암 해제설명1
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "튜토리얼", "로딩암 헤제 설명1 "

     + " \r\n \r\n( F 를 눌러 해제을 시작하세요.)");
    }
    public void Popup_Ani_out_hard2()       //로딩암 해제후 배나가고 뜨는 팝업
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "튜토리얼", "로딩암 해제가 성공적으로 완료되었습니다. 이제 선박은 항만을 떠나갑니다." +
     " \r\n \r\n 곧 2번째 배가 들어오니 지금까지 한 내용을 떠올리며 조종해보십시오.  \r\n \r\n " 
      );
    }


    public void Popup_Ani_In_hard3()        //하드모드 두번째 배 주입팝업
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨   
     "튜토리얼", "로딩암 주입(하역) 설명 씬 6번째 "

     + " \r\n \r\n( F 를 눌러 팝업을 닫습니다.)");
    }
    public void Popup_Ani_out_hard3()       //하드모드 두번째 배 연결해제 팝업
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "튜토리얼", "하적 연결해제설명  \r\n \r\n ( F 를 눌러 해제을 시작하세요.)"
      );
    }
    public void Popup_mockup()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "목업", "목업 연결 성공 \r\n\r\n( F 를 눌러 해제을 시작하세요.)"
      );
    }
    public void Popup_shipside()
    {
        PopupSystem.instance.OpenPopUp(//타이틀, 내용 적으면됨
     "목업", "배옆면과 충돌햇습니다. 실제로는 사고로 이어질 수 있으므로 주의해야합니다, \r\n\r\n 로딩암은 다시 원상태로 초기화 됩니다.\r\n \r\n 재조종 하십시오\r\n( F 를 눌러 해제을 시작하세요.)"
      );
    }
}
