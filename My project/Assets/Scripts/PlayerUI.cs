using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Player player;

    public Image Player_Image;
    public Slider player_hp;
    public Text player_name;

    public GameObject player_UI;

    private void Start()
    {
        Player_Image.sprite = player.image;
        player_name.text = player.name;
        player_hp.maxValue = player.max_hp;//�����̴� �ִ� ������ �÷��̾� �ִ� ü��
        player_hp.value = player.hp; //�÷��̾� ü������ �����̴��� ���� ��
    }

    private void Update()
    {
        //GetKeyDown : ������ ��(1��)
        //GetKey : ������ ����
        //GetKeyUp : ���� �� ���� ��(1��)
        if (Input.GetKeyDown(KeyCode.I)) //Ű���� I ��ư�� ������ ��
        {
            if(player_UI.activeSelf) //�÷��̾�UI�� �����ִٸ�
                player_UI.SetActive(false); //���ּ���.
            else
                player_UI.SetActive(true); //���ּ���.
        }
    }


    //����Ƽ c#�� �޼ҵ� ��� ���
    //1. Ű���� �Է� ���� ���� �޼ҵ带 ȣ���մϴ�.

    //2. ����Ƽ�� ��ư ���� Ȱ���� ��ư ������ �� �޼ҵ带 ȣ���մϴ�.

    public void Action01()
    {
        player.Dance();
    }

    public void Action02()
    {
        player.Heal(); //�÷��̾��� ȸ�� ��� ���
        setValue(); //ü�� �ֽ�ȭ
    }

    public void setValue()
    {
        player_hp.value = player.hp;
    }
}
