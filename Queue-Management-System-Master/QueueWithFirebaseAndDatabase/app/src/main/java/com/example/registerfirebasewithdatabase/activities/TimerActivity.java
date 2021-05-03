package com.example.registerfirebasewithdatabase.activities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.os.CountDownTimer;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

import com.example.registerfirebasewithdatabase.R;

import java.util.Locale;
import java.util.concurrent.TimeUnit;

public class TimerActivity extends AppCompatActivity {
    TextView textView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_timer);

        textView = findViewById(R.id.text_view);

        //long duration = TimeUnit.MINUTES.toMillis(1);
        long duration = TimeUnit.SECONDS.toMillis(10);

        new CountDownTimer(duration, 1000) {
            @Override
            public void onTick(long l) {
                String sDuration = String.format(Locale.ENGLISH, "%02d : %02d"
                        , TimeUnit.MILLISECONDS.toMinutes(l)
                        ,TimeUnit.MILLISECONDS.toSeconds(l) -
                                TimeUnit.MINUTES.toSeconds(TimeUnit.MILLISECONDS.toMinutes(l)));

                textView.setText(sDuration);
            }

            @Override
            public void onFinish() {
                textView.setVisibility(View.GONE);

                Toast.makeText(getApplicationContext()
                        ,"Времето за изчакване свърши", Toast.LENGTH_LONG).show();
                Intent inte = new Intent();
                Intent intent = new Intent(TimerActivity.this, BankAreaActivity.class);
                startActivity(intent);
            }

        }.start();
    }
}