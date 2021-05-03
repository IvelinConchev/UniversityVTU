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

public class NoiEditActivity extends AppCompatActivity {
    EditText edTextNoiId, edTextNoi, edTextNoiDescription;
    Button btnEditNoi, btnEditNoiDelete, btnEditNoiCancel;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_noi_edit);

        edTextNoiId = findViewById(R.id.noiid);
        edTextNoi= findViewById(R.id.noi);
        edTextNoiDescription = findViewById(R.id.noidescription);
        btnEditNoi = findViewById(R.id.btnEditNoi);
        btnEditNoiDelete = findViewById(R.id.btnDeleteNoi);
        btnEditNoiCancel = findViewById(R.id.btnCancelNoi);

        Intent intent = getIntent();

        String id = intent.getStringExtra("id").toString();
        String noi = intent.getStringExtra("noi").toString();

        String des = intent.getStringExtra("noiDes").toString();

        edTextNoiId.setText(id);
        edTextNoi.setText(noi);
        edTextNoiDescription.setText(des);

        btnEditNoiCancel.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(intent);
            }
        });


        btnEditNoiDelete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Delete();
            }
        });



        btnEditNoi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Edit();
            }
        });
    }

    public void Edit()
    {
        try {
            String noiid = edTextNoiId.getText().toString();
            String noiname = edTextNoi.getText().toString();
            String noidescription = edTextNoiDescription.getText().toString();

            SQLiteDatabase db = openOrCreateDatabase("superpos", Context.MODE_PRIVATE, null);

            String sql = "update noi set noi = ?, noiDes=? where id = ?";
            SQLiteStatement statement = db.compileStatement(sql);
            statement.bindString(1, noiname);
            statement.bindString(2, noidescription);
            statement.bindString(3, noiid);
            statement.execute();
            Toast.makeText(this, "Noi Update", Toast.LENGTH_LONG).show();
            Intent intent = new Intent(getApplicationContext(), MainActivity.class);
            startActivity(intent);

        }
        catch (Exception e){
            Toast.makeText(this, "Noi Failed", Toast.LENGTH_LONG).show();
        }
    }

    public void Delete(){
        try {
            String noiid = edTextNoiId.getText().toString();

            SQLiteDatabase db = openOrCreateDatabase("superpos", Context.MODE_PRIVATE, null);


            String sql = "delete from noi where id = ?";
            SQLiteStatement statement = db.compileStatement(sql);

            statement.bindString(1, noiid);
            statement.execute();
            Toast.makeText(this, "Noi Daleteted", Toast.LENGTH_LONG).show();
            Intent intent = new Intent(getApplicationContext(), MainActivity.class);
            startActivity(intent);

        }
        catch (Exception e){
            Toast.makeText(this, "Noi Failed", Toast.LENGTH_LONG).show();
        }
    }
}