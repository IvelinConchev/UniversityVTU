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

public class NapActivity extends AppCompatActivity implements View.OnClickListener{
    EditText edTextUser, edTextQueue;
    Button btnSaveNap, btnCancelNap;
    Button scanBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_nap);

        edTextUser = findViewById(R.id.napUser);
        edTextQueue = findViewById(R.id.napQueue);
        btnSaveNap = findViewById(R.id.btnSaveNap);
        btnCancelNap = findViewById(R.id.btnCancelNap);
        scanBtn = findViewById(R.id.scanBtn);
        scanBtn.setOnClickListener(this);

        btnCancelNap.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(NapActivity.this, MainActivity.class);
                startActivity(intent);
            }
        });

        btnSaveNap.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(NapActivity.this, MainActivity.class);
                insert();
            }
        });
    }

    public void insert(){
        try {
            String nap = edTextUser.getText().toString();
            String description = edTextQueue.getText().toString();
            SQLiteDatabase db = openOrCreateDatabase("superpos", Context.MODE_PRIVATE, null);
            db.execSQL("CREATE TABLE IF NOT EXISTS nap(id INTEGER PRIMARY KEY AUTOINCREMENT, nap VARCHAR, napDes VARCHAR)");
            //db.execSQL("DELETE FROM nap ");
            //db.execSQL("DELETE FROM SQLITE_SEQUENCE WHERE NAME = nap ");

            String sql = "insert into nap (nap, napDes)values(?,?)";
            SQLiteStatement statement = db.compileStatement(sql);
            statement.bindString(1, nap);
            statement.bindString(2, description);
            statement.execute();
            Toast.makeText(this, "Nap Created", Toast.LENGTH_LONG).show();
            edTextUser.setText("");
            edTextQueue.setText("");
            edTextUser.requestFocus();

        }catch (Exception e){
            Toast.makeText(this, "Nap Failed", Toast.LENGTH_LONG).show();
        }
        Intent intent = new Intent(NapActivity.this, QueueDetailActivity.class);
        startActivity(intent);
    }

    @Override
    public void onClick(View view) {
        scanCode();
    }

    private void scanCode(){

        IntentIntegrator integrator = new IntentIntegrator(this);
        integrator.setCaptureActivity(CaptureNapActivity.class);
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
