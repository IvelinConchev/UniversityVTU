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

public class NapEditActivity extends AppCompatActivity {
    EditText edTextNapId, edTextNap, edTextNapDescription;
    Button btnEditNap, btnEditNapDelete, btnEditNapCancel;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_nap_edit);

        edTextNapId = findViewById(R.id.napid);
        edTextNap = findViewById(R.id.nap);
        edTextNapDescription = findViewById(R.id.napdescription);
        btnEditNap = findViewById(R.id.btnEdit);
        btnEditNapDelete = findViewById(R.id.btnDelete);
        btnEditNapCancel = findViewById(R.id.btnCancel);

        Intent intent = getIntent();

        String id = intent.getStringExtra("id").toString();
        String nap = intent.getStringExtra("nap").toString();

        String des = intent.getStringExtra("napDes").toString();

        edTextNapId.setText(id);
        edTextNap.setText(nap);
        edTextNapDescription.setText(des);

        btnEditNapCancel.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(intent);
            }
        });


        btnEditNapDelete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Delete();
            }
        });



        btnEditNap.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Edit();
            }
        });
    }

    public void Edit()
    {
        try {
            String napid = edTextNapId.getText().toString();
            String napname = edTextNap.getText().toString();
            String napdescription = edTextNapDescription.getText().toString();

            SQLiteDatabase db = openOrCreateDatabase("superpos", Context.MODE_PRIVATE, null);

            String sql = "update nap set nap = ?, napDes=? where id = ?";
            SQLiteStatement statement = db.compileStatement(sql);
            statement.bindString(1, napname);
            statement.bindString(2, napdescription);
            statement.bindString(3, napid);
            statement.execute();
            Toast.makeText(this, "Category Update", Toast.LENGTH_LONG).show();
            Intent intent = new Intent(getApplicationContext(), MainActivity.class);
            startActivity(intent);

        }
        catch (Exception e){
            Toast.makeText(this, "Category Failed", Toast.LENGTH_LONG).show();
        }
    }

    public void Delete(){
        try {
            String napid = edTextNapId.getText().toString();

            SQLiteDatabase db = openOrCreateDatabase("superpos", Context.MODE_PRIVATE, null);

            //String sql = "update nap set nap = ?, napDes=? where id = ?";
            String sql = "delete from nap where id = ?";
            SQLiteStatement statement = db.compileStatement(sql);

            statement.bindString(1, napid);
            statement.execute();
            Toast.makeText(this, "Category Daleteted", Toast.LENGTH_LONG).show();
            Intent intent = new Intent(getApplicationContext(), MainActivity.class);
            startActivity(intent);

        }
        catch (Exception e){
            Toast.makeText(this, "Category Failed", Toast.LENGTH_LONG).show();
        }
    }
}
