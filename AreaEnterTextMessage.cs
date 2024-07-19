using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI; //kesinlikle ekle bunu.

public class AreaEnterTextMessage : MonoBehaviour
{
    public Text yazi; //ne isim vermek istersen "yazi" isimli kisma verebilirsin.

     void Start()
    {
        yazi.text = "selam"; //�stedi�ini yazabilirsin bu k�sma ve ba�lang��ta g�z�k�yor bu k�s�m.E�er ba�lang��ta bir�ey g�z�ks�n istemiyorsan bu kod sil.
    }
    
    void OnTriggerEnter (Collider collider)
    {
        if (this.gameObject.tag == "Trigger1") ;//A�a��y� oku
        {
            yazi.text = "deneme"; //�stedi�ini yazabilirsin bu k�sma.
            
        }
       
    }

}

//�unu unutma i�ine girince yaz�n�n g�z�kmesini sa�layaca��m�z k�p�n "Inspector" k�sm�n� a��p Tag k�sm�na "Trigger 1 iismli Tag'� se� "11
//E�er bu kod birden fazla kez �al��acaksa ordaki "Cube" k�sm�na birden fazla kez kopyala. "2"
//Bu kodu i�ine girince �al��acak bir nesneye at ve nesnenin Box Collider'�ndaki "�s trigger" ayar�n� a�. "3"
//Nesnenin g�z�kmesini istemiyorsan Nesnenin "MeshRenderer" K�sm�n�n tikini kapat. "4"
//Kodu temasa ge�ince ataca��m�z kodun i�ine att�ktan sonra text'ide at buraya. "5"
//E�er yaz� g�z�kmezse yaz�n�n�n boyutunu ayarla "6"
//Anlamazsan resme bak. "7"