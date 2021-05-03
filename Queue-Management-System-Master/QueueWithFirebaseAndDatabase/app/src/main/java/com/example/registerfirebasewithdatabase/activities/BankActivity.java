package com.example.registerfirebasewithdatabase.activities;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteStatement;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.registerfirebasewithdatabase.R;
import com.google.zxing.integration.android.IntentIntegrator;
import com.google.zxing.integration.android.IntentResult;

public class BankActivity extends AppCompatActivity implements View.OnClickListener{
    EditText edTextUserBank, edTextQueueBank;
    Button btnSaveBank, btnCancelBank;
    Button scanBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bank);

        edTextUserBank = findViewById(R.id.bankUser);
        edTextQueueBank = findViewById(R.id.bankQueue);
        btnSaveBank = findViewById(R.id.btnSaveBank);
        btnCancelBank = findViewById(R.id.btnCancelBank);
        scanBtn = findViewById(R.id.scanBtn);
        scanBtn.setOnClickListener(this);

        btnCancelBank.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(BankActivity.this, MainActivity.class);
                startActivity(intent);
            }
        });

        btnSaveBank.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(BankActivity.this, MainActivity.class);
                insert();
            }
        });
    }

    public void insert() {
        try {
            String bank = edTextUserBank.getText().toString();
            String description = edTextQueueBank.getText().toString();
            SQLiteDatabase db = openOrCreateDatabase("superpos", Context.MODE_PRIVATE, null);
            db.execSQL("CREATE TABLE IF NOT EXISTS bank(id INTEGER PRIMARY KEY AUTOINCREMENT, bank VARCHAR, bankDes VARCHAR)");
            //db.execSQL("DELETE FROM bank ");

            String sql = "insert into bank (bank, bankDes)values(?,?)";
            SQLiteStatement statement = db.compileStatement(sql);
            statement.bindString(1, bank);
            statement.bindString(2, description);
            statement.execute();
            Toast.makeText(this, "Bank Created", Toast.LENGTH_LONG).show();
            edTextUserBank.setText("");
            edTextQueueBank.setText("");
            edTextUserBank.requestFocus();
//           Intent intent = new Intent(BankActivity.this, TimerActivity.class);
//                startActivity(intent);

        } catch (Exception e) {
            Toast.makeText(this, "Bank Failed", Toast.LENGTH_LONG).show();
        }
        Intent intent = new Intent(BankActivity.this, QueueDetailBankActivity.class);
        startActivity(intent);
    }

    @Override
    public void onClick(View v) {
        scanCode();
    }

    private void scanCode(){

        IntentIntegrator integrator = new IntentIntegrator(this);
        integrator.setCaptureActivity(CaptureBankActivity.class);
        integrator.setOrientationLocked(false);
        integrator.setDesiredBarcodeFormats(IntentIntegrator.ALL_CODE_TYPES);
        integrator.setPrompt("Сканиращ код");
        integrator.initiateScan();
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data){
        IntentResult result = IntentIntegrator.parseActivityResult(requestCode, resultCode, data);
        if (result != null){
            if (result.getContents() != null){
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
                builder.setMessage(result.getContents());
                builder.setTitle("Сканиран Резултат");
                builder.setPositiveButton("Сканирай Отново", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        scanCode();
                    }
                }).setNegativeButton("Край", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        finish();
                    }
                });
                AlertDialog dialog = builder.create();
                dialog.show();
            }
            else {
                Toast.makeText(this, "Няма резултат", Toast.LENGTH_LONG).show();
            }
        }else {
            super.onActivityResult(requestCode, resultCode, data);
        }
    }
}


