package com.example.registerfirebasewithdatabase.activities;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;
import androidx.swiperefreshlayout.widget.SwipeRefreshLayout;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.RequestQueue;
import com.android.volley.toolbox.Volley;
import com.example.registerfirebasewithdatabase.R;
import com.example.registerfirebasewithdatabase.model.Reservation;

import java.text.DateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.List;
import java.util.Locale;

public class ReservationsActivity extends AppCompatActivity implements AdapterView.OnItemSelectedListener {

    TextView month,day,year;
    Button queue;
//    RequestQueue volleyQueue;
//    TextView emptyView;
//    RecyclerView recyclerView;
//    RecyclerView.Adapter adapter;
//    List<Reservation> reservations;
//    SwipeRefreshLayout swipeContainer;
    public static ArrayList<Reservation> reservationArrayList = new ArrayList<>();
    String url = "http://192.168.56.1/crud/users.php";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_reservations);
        setTitle("Моите Резервации");

        month = findViewById(R.id.month);
        day = findViewById(R.id.day);
        year = findViewById(R.id.year);
        queue = findViewById(R.id.textViewQueue);

//        Calendar calendar = Calendar.getInstance();
//        String currentDate = DateFormat.getDateInstance(DateFormat.FULL).format(calendar.getTime());
//
//        TextView textViewDate = findViewById(R.id.text_view_date);
//        textViewDate.setText(currentDate);

        Date currentTime = Calendar.getInstance().getTime();
        String formattedDate = DateFormat.getDateInstance(DateFormat.FULL).format(currentTime);

        String[] splitDate = formattedDate.split(",");

        month.setText(splitDate[1]);
        day.setText(splitDate[0]);
        year.setText(splitDate[2]);
        Log.d("myLOG", currentTime.toString());
        Log.d("myLOG", formattedDate);
        Log.d("myLOG", splitDate[0].trim());
        Log.d("myLOG", splitDate[1].trim());
        Log.d("myLOG", splitDate[2].trim());

        queue.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intSignUp = new Intent(ReservationsActivity.this, LoginFacilityActivity.class);
                intSignUp.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
                startActivity(intSignUp);

            }
        });
//        Spinner spinner = findViewById(R.id.spinner);
//        ArrayAdapter<CharSequence> adapter = ArrayAdapter.createFromResource(this,R.array.facility, android.R.layout.simple_spinner_item);
//        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
//        spinner.setAdapter(adapter);
//        spinner.setOnItemSelectedListener(this);

//        volleyQueue = Volley.newRequestQueue(this);
//       // emptyView = findViewById(R.id.empty_view);
//
//        //reservations = AppController.getInstance().getReservations();
//        //recyclerView = (RecyclerView) findViewById(R.id.reservationRecyclerView);
//        //swipeContainer = (SwipeRefreshLayout) findViewById(R.id.swiperefresh);
//
//        recyclerView.setHasFixedSize(true);
//        recyclerView.setLayoutManager(new LinearLayoutManager(ReservationsActivity.this));
//
//        swipeContainer.setSize(SwipeRefreshLayout.LARGE);
//        swipeContainer.setColorSchemeResources(R.color.colorPrimary);
//        swipeContainer.setOnRefreshListener(new SwipeRefreshLayout.OnRefreshListener() {
//            @Override
//            public void onRefresh() {
//                //populateReservations();

//        }
//
//    });

}


    @Override
    public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
        String text  = parent.getItemAtPosition(position).toString();
        Toast.makeText(parent.getContext(), text, Toast.LENGTH_SHORT).show();
    }

    @Override
    public void onNothingSelected(AdapterView<?> parent) {

    }
}