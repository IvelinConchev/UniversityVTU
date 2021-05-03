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

public class NapViewActivity extends AppCompatActivity {
    ListView naplst;
    ArrayList<String> titles = new ArrayList<String>();
    ArrayAdapter arrayAdapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_nap_view);

        naplst = findViewById(R.id.naplst);
        SQLiteDatabase db = openOrCreateDatabase("superpos", Context.MODE_PRIVATE, null);

        final Cursor cursor = db.rawQuery("select * from nap", null);
        int id = cursor.getColumnIndex("id");
        int nap = cursor.getColumnIndex("nap");
        int napDes = cursor.getColumnIndex("napDes");

        titles.clear();


        arrayAdapter = new ArrayAdapter(this, R.layout.support_simple_spinner_dropdown_item, titles);
        naplst.setAdapter(arrayAdapter);

        final ArrayList<Nap> napp = new ArrayList<Nap>();
        if (cursor.moveToFirst()) {
            do {
                Nap np = new Nap();
                np.id = cursor.getString(id);
                np.nap = cursor.getString(nap);
                np.napD = cursor.getString(napDes);
                napp.add(np);

                titles.add(cursor.getString(id) + "\t" + cursor.getString(nap) + "\t" + cursor.getString(napDes));

            } while (cursor.moveToNext());
            arrayAdapter.notifyDataSetChanged();
            naplst.invalidateViews();

        }

        naplst.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int position, long id) {

                String naps = titles.get(position).toString();
                Nap np = napp.get((position));
                Intent intent = new Intent(getApplicationContext(), NapEditActivity.class);
                intent.putExtra("id", np.id);
                intent.putExtra("nap", np.nap);
                intent.putExtra("napDes", np.napD);
                startActivity(intent);

            }
        });
    }
}
