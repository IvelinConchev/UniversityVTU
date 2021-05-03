package com.example.registerfirebasewithdatabase.activities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import com.example.registerfirebasewithdatabase.R;

public class DetailActivity extends AppCompatActivity {

    Button reservation;
    TextView tvid,tvname,tvtown,tvaddress,tvphone;
    int position;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_detail);

        tvid = findViewById(R.id.txtid);
        tvname = findViewById(R.id.txtname);
        tvtown = findViewById(R.id.txttown);
        tvaddress = findViewById(R.id.txtaddress);
        tvphone = findViewById(R.id.txtphone);
        reservation = findViewById(R.id.textViewReservation);

        Intent intent = getIntent();
        position = intent.getExtras().getInt("position");

        tvid.setText("№: " + FacilityListActivity.facilityArrayList.get(position).getId());
        tvname.setText("Институция: " + FacilityListActivity.facilityArrayList.get(position).getName());
        tvtown.setText("Град: " + FacilityListActivity.facilityArrayList.get(position).getTown());
        tvaddress.setText("Адрес: " + FacilityListActivity.facilityArrayList.get(position).getAddress());
        tvphone.setText("Телефон: " + FacilityListActivity.facilityArrayList.get(position).getPhone());


        //бутон за резервация
        reservation.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intSignUp = new Intent(DetailActivity.this, LoginFacilityActivity.class);
                intSignUp.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
                startActivity(intSignUp);

            }
        });


    }


}