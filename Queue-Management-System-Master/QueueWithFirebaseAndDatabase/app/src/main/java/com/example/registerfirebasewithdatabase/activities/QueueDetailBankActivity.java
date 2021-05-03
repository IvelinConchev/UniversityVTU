package com.example.registerfirebasewithdatabase.activities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;

import com.example.registerfirebasewithdatabase.R;

import java.util.Queue;

public class QueueDetailBankActivity extends AppCompatActivity {
    TextView facilityNameTextView, queueNameTextView, queueCurrentNumberTextView, queueCurrentText;
    Button reservationButton;
    RelativeLayout ticketTextContainer;
    ImageView ticketImageView;
    Animation animation;
    Queue queue;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_queue_detail_bank);


        facilityNameTextView = (TextView) findViewById(R.id.facilityNameTextView);
        queueNameTextView = (TextView) findViewById(R.id.queueNameTextView);
        queueCurrentText = (TextView) findViewById(R.id.queueCurrentText);
        queueCurrentNumberTextView = (TextView) findViewById(R.id.queueCurrentNumberTextView);
        reservationButton = (Button) findViewById(R.id.reserveButton);
        ticketTextContainer = (RelativeLayout) findViewById(R.id.ticketTextContainer);
        ticketImageView = findViewById(R.id.ticketImageView);

        animation = AnimationUtils.loadAnimation(this, R.anim.zoomin);

//        facility = new Facility();
//        facility.setName(getIntent().getStringExtra("facilityName"));
//        facility.setId(getIntent().getStringExtra("facilityId"));
//
//        queue = new Queue();
//        queue.setFacility(facility);
//        queue.setId(getIntent().getStringExtra("queueId"));
//        queue.setName(getIntent().getStringExtra("queueName"));
//        queue.setCurrent(getIntent().getIntExtra("queueNext", 0));
//        queue.setNext(getIntent().getIntExtra("queueNext", 0));
//
//        setTitle(facility.getName() + " - " + queue.getName());
//
//        facilityNameTextView.setText(facility.getName());
//        queueNameTextView.setText(queue.getName());

        //updateText();

        reservationButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // attemptEnterQueue();
                ticketTextContainer.startAnimation(animation);
                Intent intent = new Intent(QueueDetailBankActivity.this, TimerActivity.class);
                startActivity(intent);
            }
        });

        animation.setAnimationListener(new Animation.AnimationListener() {
            @Override
            public void onAnimationStart(Animation animation) {

            }

            @Override
            public void onAnimationEnd(Animation animation) {
                ticketTextContainer.setVisibility(View.GONE);
            }

            @Override
            public void onAnimationRepeat(Animation animation) {

            }
        });

//        Intent intent = new Intent(QueueDetailActivity.this, TimerActivity.class);
//        startActivity(intent);
        //updateData();
    }

//    private void updateText() {
//        if (queue.getCurrent() != 0) {
//            queueCurrentText.setText("В момента се обслужва: ");
//            queueCurrentNumberTextView.setText(String.valueOf(queue.getCurrent()));
//        } else {
//            queueCurrentText.setText("В очакване на чиновника");
//            queueCurrentNumberTextView.setText("");
//            queueCurrentNumberTextView.setVisibility(View.GONE);
//        }
//
//        reservationButton.setText("Вземете\nброй:\n" + queue.getNext());
//    }
}
