using AndroidX.AppCompat.Widget;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notely_App.Platforms.Android.CustomRenderers
{
    public class CustomEntryRenderer : EntryHandler
    {
        protected override void ConnectHandler(AppCompatEditText platformView)
        {
            base.ConnectHandler(platformView);
            platformView.Background = null;
            platformView.BackgroundTintList = global::Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
        }
    }
}
