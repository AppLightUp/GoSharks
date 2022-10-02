using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour
{
   public void StartBtn(){
     SceneManager.LoadScene("start");
   }
   public void welBtn(){
     SceneManager.LoadScene("welcome");
   }
   public void ufoBtn(){
     SceneManager.LoadScene("ufo");
   }
   public void mazeBtn(){
     SceneManager.LoadScene("maze");
   }
   public void menubtn(){
     SceneManager.LoadScene("main menu");
   }
   public void imgbtn(){
     SceneManager.LoadScene("imagecanvas");
   }
}
