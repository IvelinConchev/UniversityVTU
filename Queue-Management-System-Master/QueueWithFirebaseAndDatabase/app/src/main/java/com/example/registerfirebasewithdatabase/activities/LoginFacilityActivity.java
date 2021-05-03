package com.example.registerfirebasewithdatabase.activities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.registerfirebasewithdatabase.R;

public class LoginFacilityActivity extends AppCompatActivity {
    EditText edTextUser, edTextCode;
    Button btnLogin, btnCancel;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login_facility);

        edTextUser = findViewById(R.id.user);
        edTextCode = findViewById(R.id.code);
        btnLogin = findViewById(R.id.btnLogin);
        btnCancel = findViewById(R.id.btnCancel);

        btnCancel.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Login();
            }
        });
    }

    public void Login(){
        String username = edTextUser.getText().toString();
        String code = edTextCode.getText().toString();

        if (username.equals("") || code.equals("")){
            Toast.makeText(this, "Полетата на Името или Кода са празни !", Toast.LENGTH_LONG).show();
        }
        else if (username.equals("Институции") && code.equals("12345"))
        {
            Intent intent = new Intent(LoginFacilityActivity.this, MainActivity.class);
            Toast.makeText(this, "Влязохте успешно", Toast.LENGTH_LONG).show();
            startActivity(intent);
        }
        else {
            Toast.makeText(this, "Името и Кодът не съвпадат!", Toast.LENGTH_LONG).show();
        }
    }
}