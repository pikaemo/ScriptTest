using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int[] array = { 43, 22, 93, 60, 58 };

        for (int a = 0; a < array.Length; a++)
        {
            Debug.Log(array[a]);
        }

        for (int b = 4; b >= 0; b--)
        {
            Debug.Log(array[b]);
        }


        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);
        lastboss.Magic();
        
        for(int i = 0; i < 9; i++)
        {
            lastboss.Magic();
        }

        lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
   
    }
}

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");

        this.hp -= damage;
    }

    public void Magic()
    {
        if(mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
        }

        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}