package com.unitytoast;

import android.support.annotation.Nullable;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import com.mylibrary.CustomToastUnity;


public class ToastActivity extends AppCompatActivity implements View.OnClickListener {
    Button buShowToast;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_toast);
        buShowToast = (Button) findViewById(R.id.toast);
        buShowToast.setOnClickListener(this);

    }

    @Override
    public void onClick(View v) {
        CustomToastUnity customeToast = new CustomToastUnity(this);
        customeToast.customeToast();
    }
}
