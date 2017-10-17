using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdMobUnits : MonoBehaviour {

	private void Start()
	{
		ReqeustBanner ();
	}

	private void ReqeustBanner() 
	{
		#if UNITY_EDITOR
		string adUnitId = "ca-app-pub-3718238989302361/9753694939";
		#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-3718238989302361/9753694939";
		#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-3718238989302361/9753694939";
		#else
		string adUnitId = "ca-app-pub-3718238989302361/9753694939";
		#endif

		// Create a 320x50 banner at the top of the screen.
		BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the banner with the request.
		bannerView.LoadAd(request);
	}
}
