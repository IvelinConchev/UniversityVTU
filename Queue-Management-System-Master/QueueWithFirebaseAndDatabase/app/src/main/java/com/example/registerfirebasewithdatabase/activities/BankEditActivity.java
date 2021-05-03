package com.example.registerfirebasewithdatabase.activities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteStatement;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.registerfirebasewithdatabase.R;

public class BankEditActivity extends AppCompatActivity {
    EditText edTextBankId, edTextBank, edTextBankDescription;
    Button btnEditBank, btnEditBankDelete, btnEditBankCancel;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bank_edit);

        edTextBankId = findViewById(R.id.bankid);
        edTextBank = findViewById(R.id.bank);
        edTextBankDescription = findViewById(R.id.bankdescription);
        btnEditBank = findViewById(R.id.btnEditBank);
        btnEditBankDelete = findViewById(R.id.btnDeleteBank);
        btnEditBankCancel = findViewById(R.id.btnCancelBank);

        Intent intent = getIntent();

        String id = intent.getStringExtra("id").toString();
        String bank = intent.getStringExtra("bank").toString();

        String des = intent.getStringExtra("bankDes").toString();

        edTextBankId.setText(id);
        edTextBank.setText(bank);
        edTextBankDescription.setText(des);

        btnEditBankCancel.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(intent);
            }
        });


        btnEditBankDelete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Delete();
            }
        });



        btnEditBank.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Edit();
            }
        });
    }

    public void Edit()
    {
        try {
            String bankid = edTextBankId.getText().toString();
            String bankname = edTextBank.getText().toString();
            String bankdescription = edTextBankDescription.getText().toString();

            SQLiteDatabase db = openOrCreateDatabase("superpos", Context.MODE_PRIVATE, null);

            String sql = "update bank set bank = ?, bankDes=? where id = ?";
            SQLiteStatement statement = db.compileStatement(sql);
            statement.bindString(1, bankname);
            statement.bindString(2, bankdescription);
            statement.bindString(3, bankid);
            statement.execute();
            Toast.makeText(this, "Bank Update", Toast.LENGTH_LONG).show();
            Intent intent = new Intent(getApplicationContext(), MainActivity.class);
            startActivity(intent);

        }
        catch (Exception e){
            Toast.makeText(this, "Bank Failed", Toast.LENGTH_LONG).show();
        }
    }

    public void Delete(){
        try {
            String bankid = edTextBankId.getText().toString();

            SQLiteDatabase db = openOrCreateDatabase("superpos", Context.MODE_PRIVATE, null);

            String sql = "delete from bank where id = ?";
            SQLiteStatement statement = db.compileStatement(sql);

            statement.bindString(1, bankid);
            statement.execute();
            Toast.makeText(this, "Bank Deleteted", Toast.LENGTH_LONG).show();
            Intent intent = new Intent(getApplicationContext(), MainActivity.class);
            startActivity(intent);

        }
        catch (Exception e){
            Toast.makeText(this, "Bank Failed", Toast.LENGTH_LONG).show();
        }
    }
}
