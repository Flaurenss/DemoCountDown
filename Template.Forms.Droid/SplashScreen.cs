﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Views;
using Template.Core;
using Template.Forms.UI;

namespace Template.Forms.Droid
{
    [Activity(
        Label = "CountDown",
        Theme = "@style/SplashScreen",
        MainLauncher = true, 
        NoHistory = true,
        Icon = "@drawable/icon_chrono")]
    public class SplashScreen : MvxFormsSplashScreenActivity<Setup, App, FormsApp>
    {
        protected override Task RunAppStartAsync(Bundle bundle)
        {
            StartActivity(typeof(MainActivity));
            return Task.CompletedTask;
        }
    }
}