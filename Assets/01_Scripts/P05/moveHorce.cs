using UnityEngine;
using System.Collections;



public class moveHorce : MonoBehaviour
{

    public Vector3 endPosition;//�ړI�n
    private bool deleteFlg = false;
    Vector3 velocity = Vector3.zero;
    float smoothTime = 0.5f;//�ړ����x
    

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, endPosition,ref velocity,smoothTime);

        if (deleteFlg && this.transform.position.x < -1250)//�����n����ʊO(x���W��-1250�ȉ��ɂȂ���)���A�I�u�W�F�N�g������
        {
            Destroy(this.gameObject);
        }
    }
    //�n��endPosition�Ɉړ������폜�t���O�𗧂Ă�
    public void GoodByeHource(Vector3 endPosition) 
    {
        this.endPosition = endPosition;
        deleteFlg = true;
    }
}