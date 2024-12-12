using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI; 

public class MenuController : MonoBehaviour
{
    public GameObject creditosPanel;  
    public Button iniciarJuegoButton; 
    public Button creditosButton;     
    public Button salirButton;        
    public Button retrocederButton;   

    void Start()
    {
       
        //iniciarJuegoButton.onClick.AddListener(IniciarJuego);
        //creditosButton.onClick.AddListener(MostrarCreditos);
       // salirButton.onClick.AddListener(SalirDelJuego);
        //retrocederButton.onClick.AddListener(OcultarCreditos);


       // creditosPanel.SetActive(false);
    }

   
   public void IniciarJuego()
    {
        
        SceneManager.LoadScene("Demo");
    }


    public void MostrarCreditos()
    {
        creditosPanel.SetActive(true);
    }


    public void OcultarCreditos()
    {
        creditosPanel.SetActive(false);
    }


    public void SalirDelJuego()
    {
       
        Application.Quit();

       
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif

    }
}
