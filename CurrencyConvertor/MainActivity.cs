using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;

namespace CurrencyConvertor
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private TextView txt_inCur1, txt_inCur2, txt_inCur3, txt_inCur4, txt_inCur5;
        private Button btn_NZDAUD, btn_NZDUSD, btn_AUDUSD, btn_AUDNZD, btn_USDNZD;
        double result, cur;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btn_NZDAUD = FindViewById<Button>(Resource.Id.btnNZDAUD);
            btn_NZDUSD = FindViewById<Button>(Resource.Id.btnNZDUSD);
            btn_AUDUSD = FindViewById<Button>(Resource.Id.btnAUDUSD);
            btn_AUDNZD = FindViewById<Button>(Resource.Id.btnAUDNZD);
            btn_USDNZD = FindViewById<Button>(Resource.Id.btnUSDNZD);
            txt_inCur1 = FindViewById<TextView>(Resource.Id.txtinCur1);
            txt_inCur2 = FindViewById<TextView>(Resource.Id.txtinCur2);
            txt_inCur3 = FindViewById<TextView>(Resource.Id.txtinCur3);
            txt_inCur4 = FindViewById<TextView>(Resource.Id.txtinCur4);
            txt_inCur5 = FindViewById<TextView>(Resource.Id.txtinCur5);

            btn_NZDAUD.Click += btnNZDAUD_Click;
            btn_NZDUSD.Click += btnNZDUSD_Click;
            btn_AUDUSD.Click += btnAUDUSD_Click;
            btn_AUDNZD.Click += btnAUDNZD_Click;
            btn_USDNZD.Click += btnUSDNZD_Click;


        }

        private void btnNZDAUD_Click(object sender, EventArgs e)
        {
            cur = Convert.ToDouble(txt_inCur1.Text);
            result = 1.4715538 * cur;
            Toast.MakeText(context: this, text: "Result = " + result + " AUD", duration: ToastLength.Long).Show();
        }

        private void btnNZDUSD_Click(object sender, EventArgs e)
        {
            cur = Convert.ToDouble(txt_inCur2.Text);
            result = 0.64111627 * cur;
            Toast.MakeText(context: this, text: "Result = " + result + " USD", duration: ToastLength.Long).Show();
        }

        private void btnAUDUSD_Click(object sender, EventArgs e)
        {
            cur = Convert.ToDouble(txt_inCur3.Text);
            result = 0.67955381 * cur;
            Toast.MakeText(context: this, text: "Result = " + result + " USD", duration: ToastLength.Long).Show();
        }

        private void btnAUDNZD_Click(object sender, EventArgs e)
        {
            cur = Convert.ToDouble(txt_inCur4.Text);
            result = 1.0599541 * cur;
            Toast.MakeText(context: this, text: "Result = " + result + " NZD", duration: ToastLength.Long).Show();
        }

        private void btnUSDNZD_Click(object sender, EventArgs e)
        {
            cur = Convert.ToDouble(txt_inCur5.Text);
            result = 1.5599861 * cur;
            Toast.MakeText(context: this, text: "Result = " + result + " NZD", duration: ToastLength.Long).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}