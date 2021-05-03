package com.example.registerfirebasewithdatabase.activities;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.app.ProgressDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.example.registerfirebasewithdatabase.R;
import com.example.registerfirebasewithdatabase.adapters.FacilityAdapter;
import com.example.registerfirebasewithdatabase.model.Facility;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;

public class FacilityListActivity extends AppCompatActivity {
    ListView listView;
    FacilityAdapter adapter;

    public static ArrayList<Facility> facilityArrayList = new ArrayList<>();
    String url = "http://192.168.56.1/crud/retrieve.php";
    Facility facility;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_facility_list);

        listView = findViewById(R.id.myListView);
        adapter = new FacilityAdapter(this, facilityArrayList);
        listView.setAdapter(adapter);

        listView .setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int position, long id) {

                AlertDialog.Builder builder = new AlertDialog.Builder(view.getContext());
                ProgressDialog progressDialog = new ProgressDialog(view.getContext());

                CharSequence[] dialogItem = {"Информация"};
                builder.setTitle(facilityArrayList.get(position).getName());
                builder.setItems(dialogItem, new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int i) {

                        switch (i){

                            case 0:

                                startActivity(new Intent(getApplicationContext(), DetailActivity.class)
                                        .putExtra("position", position));
                                break;

                            case 1:

                                break;

                            case 2:

                                break;
                        }

                    }
                });

                builder.create().show();

            }
        });

        retrieveData();
    }

    public void retrieveData() {

        StringRequest request = new StringRequest(Request.Method.POST, url,
                new com.android.volley.Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {

                        facilityArrayList.clear();
                        try {

                            JSONObject jsonObject = new JSONObject(response);
                            String sucess = jsonObject.getString("success");
                            JSONArray jsonArray = jsonObject.getJSONArray("data");

                            if (sucess.equals("1")) {

                                for (int i = 0; i < jsonArray.length(); i++) {

                                    JSONObject object = jsonArray.getJSONObject(i);

                                    String id = object.getString("id");
                                    String name = object.getString("name");
                                    String town = object.getString("town");
                                    String address = object.getString("address");
                                    String phone = object.getString("phone");

                                    facility = new Facility(id, name, town, address, phone);
                                    facilityArrayList.add(facility);
                                    adapter.notifyDataSetChanged();
                                    listView.setAdapter(adapter);

                                }
                            }

                        } catch (JSONException e) {
                            e.printStackTrace();
                        }
                    }
                }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {

            }
        });

        RequestQueue requestQueue = Volley.newRequestQueue(this);
        requestQueue.add(request);


    }

    public void btn_add_activity(View view) {
        startActivity(new Intent(getApplicationContext(), FacilityListActivity.class));
    }
}
