package com.example.registerfirebasewithdatabase.activities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import com.example.registerfirebasewithdatabase.R;

public class NapAreaActivity extends AppCompatActivity {
    Button btnSave, btnInfo;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_nap_area);

        btnSave = findViewById(R.id.btnSaveNapТ);
        btnInfo = findViewById(R.id.btnInfo);

        btnSave.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(NapAreaActivity.this, NapActivity.class);
                startActivity(intent);
            }
        });

        btnInfo.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(NapAreaActivity.this, NapViewActivity.class);
                startActivity(intent);
            }
        });
    }
}