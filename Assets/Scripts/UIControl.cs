using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour {

    public GameObject plane, openingScreen, journeyScreen, debugObjects, pageList, aContent, bContent, cContent, dContent, eContent, backButton, MLLab, GraphicsLab, CSL, MAPSLab, PDSLab, TheoryLab, DECENTLab, BDLab, LearningSouthLab, StudentLounge, destiny=null, mainCamera, wayArrow, turnAround;
    public string destinyName;

    // Use this for initialization
    void Start () {
        plane = GameObject.Find("Plane");
        openingScreen = GameObject.Find("OpeningScreen");
        journeyScreen = GameObject.Find("JourneyScreen");
        debugObjects = GameObject.Find("DebugObjects");
        pageList = GameObject.Find("Pages");
        aContent = GameObject.Find("aContent");
        bContent = GameObject.Find("bContent");
        cContent = GameObject.Find("cContent");
        dContent = GameObject.Find("dContent");
        eContent = GameObject.Find("eContent");
        backButton = GameObject.Find("Back");
        MLLab = GameObject.Find("AnchorMLLab");
        GraphicsLab = GameObject.Find("AnchorGraphicsLab");
        CSL = GameObject.Find("AnchorCSL");
        MAPSLab = GameObject.Find("AnchorMAPSLab");
        PDSLab = GameObject.Find("AnchorPDSLab");
        TheoryLab = GameObject.Find("AnchorTheoryLab");
        DECENTLab = GameObject.Find("AnchorDECENTLab");
        BDLab = GameObject.Find("AnchorBDLab");
        LearningSouthLab = GameObject.Find("AnchorLearningLabSouth");
        StudentLounge = GameObject.Find("AnchorStudentLounge");
        wayArrow = GameObject.Find("Waypoint Arrow");
        turnAround = GameObject.Find("TurnAround");
        mainCamera = GameObject.Find("MixedRealityCamera");
        plane.gameObject.active = true;
        openingScreen.gameObject.active = true;
        pageList.gameObject.active = false;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        journeyScreen.gameObject.active = false;
        debugObjects.gameObject.active = false;
        MLLab.gameObject.active = false;
        GraphicsLab.gameObject.active = false;
        CSL.gameObject.active = false;
        MAPSLab.gameObject.active = false;
        PDSLab.gameObject.active = false;
        wayArrow.gameObject.active = false;
        turnAround.gameObject.active = false;
        TheoryLab.gameObject.active = false;
        DECENTLab.gameObject.active = false;
        BDLab.gameObject.active = false;
        LearningSouthLab.gameObject.active = false;
        StudentLounge.gameObject.active = false;
        //Two();
    }

    public void setDestination()
    {
        openingScreen.gameObject.active = false;
        pageList.gameObject.active = true;
        aContent.gameObject.active = true;

    }
    public void debugMode()
    {
        openingScreen.gameObject.active = false;
        debugObjects.gameObject.active = true;
        backButton.gameObject.active = true;
    }
    public void backUp()
    {
        openingScreen.active = true;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        pageList.gameObject.active = false;
        journeyScreen.gameObject.active = false;
        debugObjects.gameObject.active = false;
    }
    public void aCon()
    {
        aContent.gameObject.active = true;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;

    }
    public void bCon()
    {
        bContent.gameObject.active = true;
        aContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;

    }
    public void cCon()
    {
        cContent.gameObject.active = true;
        bContent.gameObject.active = false;
        aContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;

    }
    public void dCon()
    {
        dContent.gameObject.active = true;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        aContent.gameObject.active = false;
        eContent.gameObject.active = false;

    }
    public void eCon()
    {
        eContent.gameObject.active = true;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        aContent.gameObject.active = false;

    }
    public void One()
    {
        plane.gameObject.active = false;
        openingScreen.gameObject.active = false;
        pageList.gameObject.active = false;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        debugObjects.gameObject.active = false;
        GraphicsLab.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = GraphicsLab;
        destinyName = "Graphics Lab";
        //Add a text variable here and calculate distance!
    }
    public void Two()
    {
        plane.gameObject.active = false;
        pageList.gameObject.active = false;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        debugObjects.gameObject.active = false;
        MLLab.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = MLLab;
        destinyName = "ML Lab";
        //Add a text variable here and calculate distance!
    }
    public void Three()
    {
        plane.gameObject.active = false;
        pageList.gameObject.active = false;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        debugObjects.gameObject.active = false;
        CSL.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = CSL;
        destinyName = "CyberSecurity Lab";
        //Add a text variable here and calculate distance!
    }
    public void Four()
    {
        plane.gameObject.active = false;
        pageList.gameObject.active = false;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        debugObjects.gameObject.active = false;
        MAPSLab.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = MAPSLab;
        destinyName = "MAPS Lab";
        //Add a text variable here and calculate distance!
    }
    public void Five()
    {
        plane.gameObject.active = false;
        pageList.gameObject.active = false;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        debugObjects.gameObject.active = false;
        PDSLab.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = PDSLab;
        destinyName = "PDS Lab";
        //Add a text variable here and calculate distance!
    }
    public void Six()
    {
        plane.gameObject.active = false;
        pageList.gameObject.active = false;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        debugObjects.gameObject.active = false;
        TheoryLab.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = TheoryLab;
        destinyName = "Theory Lab";
        //Add a text variable here and calculate distance!
    }
    public void Seven()
    {
        plane.gameObject.active = false;
        pageList.gameObject.active = false;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        debugObjects.gameObject.active = false;
        DECENTLab.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = DECENTLab;
        destinyName = "DECENT Lab";
        //Add a text variable here and calculate distance!
    }
    public void Eight()
    {
        plane.gameObject.active = false;
        pageList.gameObject.active = false;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        debugObjects.gameObject.active = false;
        BDLab.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = BDLab;
        destinyName = "BD Lab";
        //Add a text variable here and calculate distance!
    }
    public void Nine()
    {
        plane.gameObject.active = false;
        pageList.gameObject.active = false;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        debugObjects.gameObject.active = false;
        LearningSouthLab.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = LearningSouthLab;
        destinyName = "South Learning Lab";
        //Add a text variable here and calculate distance!
    }
    public void Ten()
    {
        plane.gameObject.active = false;
        pageList.gameObject.active = false;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        debugObjects.gameObject.active = false;
        StudentLounge.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = StudentLounge;
        destinyName = "Student Lounge";
        //Add a text variable here and calculate distance!
    }
    public void exitNavigation()
    {
        plane.gameObject.active = true;
        openingScreen.gameObject.active = true;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        pageList.gameObject.active = false;
        journeyScreen.gameObject.active = false;
        debugObjects.gameObject.active = false;
        CSL.gameObject.active = false;
        MLLab.gameObject.active = false;
        GraphicsLab.gameObject.active = false;
        wayArrow.gameObject.active = false;
        destiny = mainCamera;
    }
}
