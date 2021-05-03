package com.example.registerfirebasewithdatabase.activities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import com.example.registerfirebasewithdatabase.R;

import java.util.ArrayList;

public class BankViewActivity extends AppCompatActivity {
    ListView banklst;
    ArrayList<String> titles = new ArrayList<String>();
    ArrayAdapter arrayAdapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bank_view);

        banklst = findViewById(R.id.banklst);
        SQLiteDatabase db = openOrCreateDatabase("superpos", Context.MODE_PRIVATE, null);

        final Cursor cursor = db.rawQuery("select * from bank", null);
        int id = cursor.getColumnIndex("id");
        int bank = cursor.getColumnIndex("bank");
        int bankDes = cursor.getColumnIndex("bankDes");

        titles.clear();


        arrayAdapter = new ArrayAdapter(this, R.layout.support_simple_spinner_dropdown_item, titles);
        banklst.setAdapter(arrayAdapter);

        final ArrayList<Bank> bapp = new ArrayList<Bank>();
        if (cursor.moveToFirst()) {
            do {
                Bank bk = new Bank();
                bk.id = cursor.getString(id);
                bk.bank = cursor.getString(bank);
                bk.bankD = cursor.getString(bankDes);
                bapp.add(bk);

                titles.add(cursor.getString(id) + "\t" + cursor.getString(bank) + "\t" + cursor.getString(bankDes));

            } while (cursor.moveToNext());
            arrayAdapter.notifyDataSetChanged();
            banklst.invalidateViews();

        }

        banklst.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int position, long id) {

                String baps = titles.get(position).toString();
                Bank np = bapp.get((position));
                Intent intent = new Intent(getApplicationContext(), BankEditActivity.class);
                intent.putExtra("id", np.id);
                intent.putExtra("bank", np.bank);
                intent.putExtra("bankDes", np.bankD);
                startActivity(intent);

            }
        });
    }
}
