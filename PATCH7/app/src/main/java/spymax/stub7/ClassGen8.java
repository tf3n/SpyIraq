package spymax.stub7;

import java.io.UnsupportedEncodingException;

public class ClassGen8 {
    public String str = null;
    public byte [] byt = null;
    ClassGen8(byte [] s, byte [] b){
        try {
            str = new String(s, "UTF-8");
            byt = b;
        } catch (UnsupportedEncodingException e) {}
    }

}
