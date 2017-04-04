package com.mylibrary;

import android.content.Context;
import android.util.Log;
import android.widget.Toast;

/**
 * Created by sandy on 04/04/2017.
 */

public class CustomToastUnity {

    Context context;
    public CustomToastUnity(Context context)
    {
        this.context=context;
    }



    public void customeToast()
    {
        Toast.makeText(context,"heloo from android",Toast.LENGTH_LONG).show();
        Log.d("unity:","Custome Toast Run Succesfuly");
    }
}
