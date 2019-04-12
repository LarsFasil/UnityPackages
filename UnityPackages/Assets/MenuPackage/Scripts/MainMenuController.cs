using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private int i_numberOfBacks = 5;
    //[SerializeField]
    private GameObject[] goA_allPanels;
    private Animator[] aA_allPanels;
    private int[] iA_backArray;

    public string s_openAnim, s_closeAnim;
    private bool b_open, b_close;

    void Start()
    {
        b_close = false;
        b_open = true;

        getPanels();

        iA_backArray = new int[i_numberOfBacks];
        aA_allPanels = new Animator[goA_allPanels.Length];
        for (int i = 0; i < goA_allPanels.Length; i++)
        {
            aA_allPanels[i] = goA_allPanels[i].GetComponent<Animator>();
        }

        //currentscreen = mainscreen
        iA_backArray[0] = 0;
    }

    void getPanels()
    {
        // the -3 is the ammount of non-panel children the mainMenuCanvas has
        goA_allPanels = new GameObject[transform.childCount - 3];

        for (int i = 0; i < goA_allPanels.Length; i++)
        {
            goA_allPanels[i] = transform.GetChild(i).gameObject;
        }
    }

    public void Panel(int PanelNum)
    {
        PanelManager(PanelNum);
    }

    void PanelManager(int panel)
    {
        OpenClose(b_close, iA_backArray[0]);
        OpenClose(b_open, panel);

        UpdateBackArray(true);
        iA_backArray[0] = panel;
    }

    public void Back()
    {
        OpenClose(b_close, iA_backArray[0]);
        OpenClose(b_open, iA_backArray[1]);

        UpdateBackArray(false);
    }

    void UpdateBackArray(bool forward)
    {
        if (forward)
        {
            for (int i = 0; i < iA_backArray.Length - 1; i++)
            {
                iA_backArray[iA_backArray.Length - 1 - i] = iA_backArray[iA_backArray.Length - 2 - i];
            }
        }
        else
        {
            for (int i = 0; i < iA_backArray.Length - 1; i++)
            {
                iA_backArray[i] = iA_backArray[i + 1];
            }
        }
    }

    void OpenClose(bool open, int ArrayPos)
    {
        if (open)
        {
            aA_allPanels[ArrayPos].Play(s_openAnim);
        }
        else
        {
            aA_allPanels[ArrayPos].Play(s_closeAnim);
        }
    }
}
