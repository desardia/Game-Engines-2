using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {

        if(GameManager.instance != null)
        {
        return;
        }



        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);

    }
        //Resources 
       // public List <Sprite> playerSprites;
      //  public List <Spirte> weaponSprites;
        public List <int> weaponPrices;
        public List <int> xpTable;

        //References
        public Player player;
        public FloatingTextManager floatingTextManager;
        //Public weapon weapob...

        //Logic
        public int drachmas;
        public int experience;

        public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
        {
            floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
        }


        /*
        INT preferedSkin
        Int drachmas
        INT experience
        Int WeaponLevel
        */
        public void SaveState()
        {
           string s ="";
            s += "0" + "|";
            s += drachmas.ToString()+ "|";
            s += experience.ToString() + "|";
            s += "0" ;



           PlayerPrefs.SetString("SaveState",s);
        }
        public void LoadState(Scene s,LoadSceneMode mode)
        { 

            if(!PlayerPrefs.HasKey("SaveState"))
            {
                return;
            }
           string[] data = PlayerPrefs.GetString("SaveState").Split('|');

           drachmas = int.Parse(data[1]);
           experience =int.Parse(data[2]);


           Debug.Log("LoadState");
        }

}
