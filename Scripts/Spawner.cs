using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Target target; //������ �� ��� ������ � ����� ��� ����, ����� ����� �������, ��� ������ ���������

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 5f, 1f); //������ ��������� ����� 5 ������ ������ �������
    }

    // Update is called once per frame
    private void Spawn()
    {
        Instantiate(target); //������� ������
    }
}
