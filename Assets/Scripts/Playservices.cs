﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.UI;
using GooglePlayGames.BasicApi;


public class Playservices : MonoBehaviour
{
    public Text signInButtonText, authStatus;

    void OnEnable()
    {
        /*if (PlayGamesPlatform.Instance.localUser.authenticated)
        {
            // Note: make sure to add 'using GooglePlayGames'
            PlayGamesPlatform.Instance.ReportScore(PlayerPrefs.GetInt("Levels"),
                GPGSIds.leaderboard_stage_ranking,
                (bool success) =>
                {
                    Debug.Log("(Lollygagger) Leaderboard update success: " + success);
                });
        }

        if (PlayerPrefs.GetInt ("Coins") >= 12000) {

            if (Social.localUser.authenticated) {
                PlayGamesPlatform.Instance.ReportProgress (
                    GPGSIds.achievement_get_1200_coins,
                    100.0f, (bool success) => {
                        Debug.Log ("(Lollygagger) 120000 Coins Achievement: " +
                            success);
                    });

            }
        }
        if (PlayerPrefs.GetInt ("Coins") >= 6000) {

            if (Social.localUser.authenticated) {
                PlayGamesPlatform.Instance.ReportProgress (
                    GPGSIds.achievement_get_600_coins,
                    100.0f, (bool success) => {
                        Debug.Log ("(Lollygagger) 60000 Coins Achievement: " +
                            success);
                    });
            }
        }

        if (PlayerPrefs.GetInt ("Coins") >= 9000) {

            if (Social.localUser.authenticated) {
                PlayGamesPlatform.Instance.ReportProgress (
                    GPGSIds.achievement_get_900_coins,
                    100.0f, (bool success) => {
                        Debug.Log ("(Lollygagger) 90000 Coins Achievements: " +
                            success);
                    });
            }
        }*/
    }

    ////////////  ADD THIS CODE In Start////////////////////
    void Start()
    {
        /*// ...
        // Try silent sign-in (second parameter is isSilent)
        // This should always be the last line of Start()
        PlayGamesPlatform.Instance.Authenticate(SignInCallback, true);
            // Create client configuration
            PlayGamesClientConfiguration config = new
            PlayGamesClientConfiguration.Builder ().Build ();

            // Enable debugging output (recommended)
            PlayGamesPlatform.DebugLogEnabled = true;

            // Initialize and activate the platform
            PlayGamesPlatform.InitializeInstance (config);
            PlayGamesPlatform.Activate ();
    //
    */
    }
    ////////// END THE CODE TO PASTE INTO START//////////////////////

    ///////////////Sign in Code/////////////////////////////////
    public void SignIn()
    {
        /*if (!PlayGamesPlatform.Instance.localUser.authenticated)
        {
            // Sign in with Play Game Services, showing the consent dialog
            // by setting the second parameter to isSilent=false.
            PlayGamesPlatform.Instance.Authenticate(SignInCallback, false);
        }
        else
        {
            // Sign out of play games
            PlayGamesPlatform.Instance.SignOut();

            // Reset UI
            signInButtonText.text = "Sign In";
            authStatus.text = "";
        }*/
    }
    ////////////////////////////////////////////////////////

    ///////////////////IncermentalAchivenment/////////////////// 


    /////////////////////////////////////////////////////////

    ////////////////////////UnlockAchivenmnet//////////////////
    /// 
    /// 
    public void OnAchiementUnlock()
    {
        /*if (Social.localUser.authenticated) {
            PlayGamesPlatform.Instance.ReportProgress (
                GPGSIds.achievement_1_vs_1_500_win,
                100.0f, (bool success) => {
                Debug.Log ("(Lollygagger) Welcome Unlock: " +
                success);
            });
        }*/
    }


    public void SignInCallback(bool success)
    {
        if (success)
        {
            Debug.Log("(Lollygagger) Signed in!");

            // Change sign-in button text
            signInButtonText.text = "Sign out";

            // Show the user's name
            authStatus.text = "Signed in as: " + Social.localUser.userName;
        }
        else
        {
            Debug.Log("(Lollygagger) Sign-in failed...");

            // Show failure message
            signInButtonText.text = "Sign in";
            authStatus.text = "Sign-in failed";
        }
    }


    public void ShowAchievements()
    {
        /*if (PlayGamesPlatform.Instance.localUser.authenticated)
        {
            PlayGamesPlatform.Instance.ShowAchievementsUI();
        }
        else
        {
            Debug.Log("Cannot show Achievements, not logged in");
        }*/
    }

    public void ShowLeaderboards()
    {
        /*if (PlayGamesPlatform.Instance.localUser.authenticated) {
            PlayGamesPlatform.Instance.ShowLeaderboardUI();
        }
        else {
            Debug.Log("Cannot show leaderboard: not authenticated");
        }*/
    }
}