using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public Animator animator;

    public GameObject livingRoom;
    public GameObject cantina;
    public GameObject cube;
    public GameObject mezzanine;

    /*[Header ("UI")]*/

    #region UI

    public GameObject livingRoomHotSpot;
    public GameObject cantinaHotSpot;
    public GameObject cubeHotSpot;
    public GameObject mezzanineHotSpot;

    public GameObject fadeSystem;

    #endregion
    

    #region LivingRoom

    public void LivingRoomToCantina()
    {

        StartCoroutine(FadeIn());
        livingRoom.SetActive(false);
        livingRoomHotSpot.SetActive(false);
        cantina.SetActive(true);
        cantinaHotSpot.SetActive(true);

    }

    public void LivingRoomToCube()
    {
        StartCoroutine(FadeIn());
        livingRoom.SetActive(false);
        livingRoomHotSpot.SetActive(false);
        cube.SetActive(true);
        cubeHotSpot.SetActive(true);
    }

    #endregion

    #region Cantina

    public void CantinaToLivingRoom()
    {
        StartCoroutine(FadeIn());
        cantina.SetActive(false);
        cantinaHotSpot.SetActive(false);
        livingRoom.SetActive(true);
        livingRoomHotSpot.SetActive(true);
    }

    public void CantinaToCube()
    {
        StartCoroutine(FadeIn());
        cantina.SetActive(false);
        cantinaHotSpot.SetActive(false);
        cube.SetActive(true);
        cubeHotSpot.SetActive(true);
    }

    #endregion

    #region Cube

    public void CubeToLivingRoom()
    {
        StartCoroutine(FadeIn());
        cube.SetActive(false);
        cubeHotSpot.SetActive(false);
        livingRoom.SetActive(true);
        livingRoomHotSpot.SetActive(true);
    }
    public void CubeToCantina()
    {
        StartCoroutine(FadeIn());
        cube.SetActive(false);
        cubeHotSpot.SetActive(false);
        cantina.SetActive(true);
        cantinaHotSpot.SetActive(true);
    }

    public void CubeToMezzanine()
    {
        StartCoroutine(FadeIn());
        cube.SetActive(false);
        cubeHotSpot.SetActive(false);
        mezzanine.SetActive(true);
        mezzanineHotSpot.SetActive(true);
    }

    #endregion

    #region Mezzanine

    public void MezzanineToCube()
    {
        StartCoroutine(FadeIn());
        mezzanine.SetActive(false);
        mezzanineHotSpot.SetActive(false);
        cube.SetActive(true);
        cubeHotSpot.SetActive(true);
    }

    #endregion

    public IEnumerator FadeIn()
    {
        fadeSystem.SetActive(true);
        animator.SetTrigger("f");
        yield return new WaitForSeconds(2);
        fadeSystem.SetActive(false);

    }
}
