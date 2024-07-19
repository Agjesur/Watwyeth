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
        yazi.text = "selam"; //Ýstediðini yazabilirsin bu kýsma ve baþlangýçta gözüküyor bu kýsým.Eðer baþlangýçta birþey gözüksün istemiyorsan bu kod sil.
    }
    
    void OnTriggerEnter (Collider collider)
    {
        if (this.gameObject.tag == "Trigger1") ;//Aþaðýyý oku
        {
            yazi.text = "deneme"; //Ýstediðini yazabilirsin bu kýsma.
            
        }
       
    }

}

//Þunu unutma içine girince yazýnýn gözükmesini saðlayacaðýmýz küpün "Inspector" kýsmýný açýp Tag kýsmýna "Trigger 1 iismli Tag'ý seç "11
//Eðer bu kod birden fazla kez çalýþacaksa ordaki "Cube" kýsmýna birden fazla kez kopyala. "2"
//Bu kodu içine girince çalýþacak bir nesneye at ve nesnenin Box Collider'ýndaki "Ýs trigger" ayarýný aç. "3"
//Nesnenin gözükmesini istemiyorsan Nesnenin "MeshRenderer" Kýsmýnýn tikini kapat. "4"
//Kodu temasa geçince atacaðýmýz kodun içine attýktan sonra text'ide at buraya. "5"
//Eðer yazý gözükmezse yazýnýnýn boyutunu ayarla "6"
//Anlamazsan resme bak. "7"