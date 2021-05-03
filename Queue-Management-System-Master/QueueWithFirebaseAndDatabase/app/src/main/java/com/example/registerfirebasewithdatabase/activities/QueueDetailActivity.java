package com.example.registerfirebasewithdatabase.activities;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.util.Log;
import android.view.MenuItem;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;
import android.app.AlertDialog.Builder;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.Volley;
import com.example.registerfirebasewithdatabase.R;
import com.example.registerfirebasewithdatabase.model.Facility;
import com.example.registerfirebasewithdatabase.model.Queue;
//import com.example.registerfirebasewithdatabase.util.App

import org.json.JSONException;
import org.json.JSONObject;

import java.util.Map;

public class QueueDetailActivity extends AppCompatActivity {

    TextView facilityNameTextView, queueNameTextView, queueCurrentNumberTextView, queueCurrentText;
    Button reservationButton;
    RelativeLayout ticketTextContainer;
    ImageView ticketImageView;
    Animation animation;
    Queue queue;
    Facility facility;
    RequestQueue volleyQueue;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_queue_detail);


        volleyQueue = Volley.newRequestQueue(this);

        facilityNameTextView = (TextView) findViewById(R.id.facilityNameTextView);
        queueNameTextView = (TextView) findViewById(R.id.queueNameTextView);
        queueCurrentText = (TextView) findViewById(R.id.queueCurrentText);
        queueCurrentNumberTextView = (TextView) findViewById(R.id.queueCurrentNumberTextView);
        reservationButton = (Button) findViewById(R.id.reserveButton);
        ticketTextContainer = (RelativeLayout) findViewById(R.id.ticketTextContainer);
        ticketImageView = findViewById(R.id.ticketImageView);

        animation = AnimationUtils.loadAnimation(this, R.anim.zoomin);

        facility = new Facility();
        facility.setName(getIntent().getStringExtra("facilityName"));
        facility.setId(getIntent().getStringExtra("facilityId"));

        queue = new Queue();
        queue.setFacility(facility);
        queue.setId(getIntent().getStringExtra("queueId"));
        queue.setName(getIntent().getStringExtra("queueName"));
        queue.setCurrent(getIntent().getIntExtra("queueNext", 0));
        queue.setNext(getIntent().getIntExtra("queueNext", 0));

        setTitle(facility.getName() + " - " + queue.getName());

        facilityNameTextView.setText(facility.getName());
        queueNameTextView.setText(queue.getName());

        //updateText();

        reservationButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                attemptEnterQueue();
                ticketTextContainer.startAnimation(animation);
                Intent intent = new Intent(QueueDetailActivity.this, TimerNapActivity.class);
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

       // updateData();
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

    private void updateData() {
        //String url = AppController.API_URL + "/queues/" +queue.getId();
        String url = "http://192.168.56.1/crud/retrieve.php";
        JsonObjectRequest request = new JsonObjectRequest(Request.Method.GET, url, null, new Response.Listener<JSONObject>() {
            @Override
            public void onResponse(JSONObject response) {
                try {
                    queue.setCurrent(response.getInt("current"));
                    queue.setNext(response.getInt("next"));
                    //updateText();
                } catch (JSONException e) {
                    e.printStackTrace();
                }
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Log.d("QueueUpdate", "onErrorResponse: " + error.getMessage());
            }
        });

        volleyQueue.add(request);
    }

    private void attemptEnterQueue() {
        //String url = AppController.API_URL + "/reservations/" + queue.getId();
        String url = "http://192.168.56.1/crud/retrieve.php";

        JsonObjectRequest request = new JsonObjectRequest(Request.Method.POST, url, null, new Response.Listener<JSONObject>() {
            @Override
            public void onResponse(JSONObject response) {
                Log.d("AttemptEnterQueue", "onResponse: " +response);
                //tukkk
                //FirebaseMessaging.getInstance().subscribeToTopic(queue.getId());
//                AppController.getInstance().updateReservations();

                Handler handler = new Handler();
                handler.postDelayed(new Runnable() {
                    @Override
                    public void run() {

                       // Intent intent = new Intent(QueueDetailActivity.this, ReservationsActivity.class);
                        //startActivity(intent);
                        finish();
                    }
                }, 1000);

            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Log.d("AttemptEnterFail", "onErrorResponse: " + error);
                if(error.networkResponse.statusCode == 409) {

                    AlertDialog.Builder builder = new AlertDialog.Builder(QueueDetailActivity.this);
                    builder.setMessage("На ред сте")
                            .setNegativeButton("На ред", new DialogInterface.OnClickListener() {
                                @Override
                                public void onClick(DialogInterface dialogInterface, int i) {
                                    Intent intent = new Intent(QueueDetailActivity.this, ReservationsActivity.class);
                                    startActivity(intent);
                                    finish();
                                }
                            })
                            .create().show();
                }
                if(error.networkResponse.statusCode == 401) {

                    AlertDialog.Builder builder = new AlertDialog.Builder(QueueDetailActivity.this);
                    builder.setMessage("Изчакайте за ред")
                            .setNegativeButton("На ред", new DialogInterface.OnClickListener() {
                                @Override
                                public void onClick(DialogInterface dialogInterface, int i) {
                                    Intent intent = new Intent(QueueDetailActivity.this, LoginActivity.class);
                                    intent.putExtra("attemptedQueue", queue.getId());
                                    startActivity(intent);
                                    finish();
                                }
                            })
                            .create().show();
                }
            }
//        }) {
//            @Override
//            public Map<String, String> getHeaders() throws AuthFailureError {
//                return AppController.getInstance().getAuthorizationHeader();
//            }
        });

        volleyQueue.add(request);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        if(item.getItemId() == android.R.id.home) {
            finish();
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}