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

public class NoiViewActivity extends AppCompatActivity {
    ListView noilst;
    ArrayList<String> titles = new ArrayList<String>();
    ArrayAdapter arrayAdapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_noi_view);

        noilst = findViewById(R.id.noilst);
        SQLiteDatabase db = openOrCreateDatabase("superpos", Context.MODE_PRIVATE, null);

        final Cursor cursor = db.rawQuery("select * from noi", null);
        int id = cursor.getColumnIndex("id");
        int noi = cursor.getColumnIndex("noi");
        int noiDes = cursor.getColumnIndex("noiDes");

//        final Cursor cursor = db.rawQuery("select * from nap", null);
//        int id = cursor.getColumnIndex("id");
//        int nap = cursor.getColumnIndex("nap");
//        int napDes = cursor.getColumnIndex("napDes");

        titles.clear();


        arrayAdapter = new ArrayAdapter(this, R.layout.support_simple_spinner_dropdown_item, titles);
        noilst.setAdapter(arrayAdapter);

        final ArrayList<Noi> nopp = new ArrayList<Noi>();
        if (cursor.moveToFirst()) {
            do {
                Noi np = new Noi();
                np.id = cursor.getString(id);
                np.noi = cursor.getString(noi);
                np.noiD = cursor.getString(noiDes);
                nopp.add(np);

                titles.add(cursor.getString(id) + "\t" + cursor.getString(noi) + "\t" + cursor.getString(noiDes));

            } while (cursor.moveToNext());
            arrayAdapter.notifyDataSetChanged();
            noilst.invalidateViews();

        }

        noilst.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int position, long id) {

                String nops = titles.get(position).toString();
                Noi np = nopp.get((position));
                Intent intent = new Intent(getApplicationContext(), NoiEditActivity.class);
                intent.putExtra("id", np.id);
                intent.putExtra("noi", np.noi);
                intent.putExtra("noiDes", np.noiD);
                startActivity(intent);

            }
        });
    }
}
