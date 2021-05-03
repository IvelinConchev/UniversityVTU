package com.example.registerfirebasewithdatabase.activities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import com.example.registerfirebasewithdatabase.R;

public class NoiAreaActivity extends AppCompatActivity {
    Button btnSaveNoi, btnInfoNoi;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_noi_area);

        btnSaveNoi = findViewById(R.id.btnSaveNoi);
        btnInfoNoi = findViewById(R.id.btnInfoNoi);

        btnSaveNoi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(NoiAreaActivity.this, NoiActivity.class);
                startActivity(intent);
            }
        });

        btnInfoNoi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(NoiAreaActivity.this, NoiViewActivity.class);
                startActivity(intent);
            }
        });
    }
}
