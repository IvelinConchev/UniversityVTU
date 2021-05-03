package com.example.registerfirebasewithdatabase.activities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import com.example.registerfirebasewithdatabase.R;

public class MainActivity extends AppCompatActivity {

    Button btnNap, btnNoi, btnBank, btnPolyclinic, btnHospital, btnTaxes, btnMunicipality, btnPension, btnKatPolice, btnHear;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnNap = findViewById(R.id.btnNap);
        btnNoi = findViewById(R.id.btnNoi);
        btnBank = findViewById(R.id.btnBank);


        btnBank.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(MainActivity.this, BankAreaActivity.class);
                startActivity(intent);
            }
        });


        btnNoi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(MainActivity.this, NoiAreaActivity.class);
                startActivity(intent);
            }
        });

        btnNap.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(MainActivity.this, NapAreaActivity.class);
                startActivity(intent);
            }
        });
    }
}