using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horceSpawn : MonoBehaviour
{

   public Animation anim;
    public Animation anim1;
    public Animation anim2;
    public GameObject horce;            //��������n�̃I�u�W�F�N�g
    public GameObject spawnPoint;       //���������n�̍ŏ��̈ʒu
    public Vector3[] gotoPositions;     //���������n�̖ړI�n
    GameObject[] CreatedHorces;         //���������n�ꗗ
    private int createNum = 0;          //���ݐ��������n�̐�

    private AudioSource horceRoar;      //���������Ƃ��ɗ���SE
    public AudioClip horceStep;
    void Start() {
        //anim = this.gameObject.GetComponent<Animation>();
        CreatedHorces = new GameObject[gotoPositions.Length];
        horceRoar = GetComponent<AudioSource>();
    }
    void Update()
    {
    
    }
    public void OnClick()
    {
        
        
            if (createNum < CreatedHorces.Length)
            {         
                Vector3 spawnVec = spawnPoint.transform.position;
                GameObject prefab = Instantiate(horce, spawnVec, Quaternion.identity);
                horceRoar.PlayOneShot(horceRoar.clip);
                moveHorce mh = prefab.GetComponent<moveHorce>();
                mh.endPosition = gotoPositions[createNum];
                CreatedHorces[createNum] = prefab;
                createNum++;
                this.anim.Play();
            this.anim1.Play();
            this.anim2.Play();
            this.GetComponent<AudioSource>().PlayOneShot(horceStep);
        }
            else
            {
                foreach (GameObject h in CreatedHorces)
                {
                    moveHorce mh = h.GetComponent<moveHorce>();
                    Vector3 vec = h.transform.position;
                    vec.x = -1400;
                    mh.GoodByeHource(vec);
                this.GetComponent<AudioSource>().PlayOneShot(horceStep);
            }
                createNum = 0;
            }
        
    }

}