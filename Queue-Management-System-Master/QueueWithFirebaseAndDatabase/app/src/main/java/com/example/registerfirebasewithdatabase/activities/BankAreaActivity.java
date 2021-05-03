package com.example.registerfirebasewithdatabase.activities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import com.example.registerfirebasewithdatabase.R;

public class BankAreaActivity extends AppCompatActivity {
    Button btnSaveBank, btnInfoBank;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bank_area);

        btnSaveBank = findViewById(R.id.btnSaveBankТ);
        btnInfoBank = findViewById(R.id.btnInfoBankT);

        btnSaveBank.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(BankAreaActivity.this, BankActivity.class);
                startActivity(intent);
            }
        });

        btnInfoBank.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(BankAreaActivity.this, BankViewActivity.class);
                startActivity(intent);
            }
        });
    }
}