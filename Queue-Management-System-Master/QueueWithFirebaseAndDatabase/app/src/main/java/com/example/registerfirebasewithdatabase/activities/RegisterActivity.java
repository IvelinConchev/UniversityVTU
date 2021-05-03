package com.example.registerfirebasewithdatabase.activities;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.example.registerfirebasewithdatabase.R;
import com.example.registerfirebasewithdatabase.model.UserDetail;
import com.example.registerfirebasewithdatabase.util.CustomToast;
import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.OnSuccessListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.database.FirebaseDatabase;

public class RegisterActivity extends AppCompatActivity {
    EditText emailId, firstName, lastName, address, password;
    Button btnSignUp;
    //да се провери
    TextView tvSignIn;

    FirebaseAuth mFirebaseAuth;
    FirebaseDatabase firebaseDatabase;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);

        firstName = findViewById(R.id.editTextFirstName);
        lastName = findViewById(R.id.editTextLastName);
        emailId = findViewById(R.id.editTextEmail);
        address = findViewById(R.id.editTextAdress);
        password = findViewById(R.id.editTextPassword);
        btnSignUp = findViewById(R.id.signUpButton);
        tvSignIn = findViewById(R.id.textViewSignIn);


        mFirebaseAuth = FirebaseAuth.getInstance();
        firebaseDatabase = FirebaseDatabase.getInstance();

        btnSignUp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                final String email = emailId.getText().toString();
                final String fName = firstName.getText().toString();
                final String lName = lastName.getText().toString();
                final String add = address.getText().toString();
                final String pwd = password.getText().toString();

                if (lName.isEmpty()) {
                    firstName.setError("Моля въведете Име");
                    firstName.requestFocus();
                } else if (fName.isEmpty()) {
                    lastName.setError("Моля въведете Фамилия");
                    lastName.requestFocus();
                } else if (email.isEmpty()) {
                    emailId.setError("Моля въведете Email");
                    emailId.requestFocus();
                } else if (add.isEmpty()) {
                    address.setError("Моля въведете адрес");
                    address.requestFocus();
                } else if (pwd.isEmpty()) {
                    password.setError("Моля въведете парола");
                    password.requestFocus();
                } else if (!(email.isEmpty() && pwd.isEmpty())) {
                    mFirebaseAuth.createUserWithEmailAndPassword(email, pwd)
                            .addOnCompleteListener(RegisterActivity.this, new OnCompleteListener<AuthResult>() {
                                @Override
                                public void onComplete(@NonNull Task<AuthResult> task) {

                                    if (!task.isSuccessful()) {
                                        CustomToast.createToast(RegisterActivity.this,
                                                "Регистрацияте е Неуспешна, Опитайте отново! Email е непълен!" + " "
                                                        + task.getException().getMessage(), true);
                                    } else {
                                        UserDetail userDetail = new UserDetail(fName, lName, add);
                                        String uid = task.getResult().getUser().getUid();
                                        firebaseDatabase.getReference(uid).setValue(userDetail)
                                                .addOnSuccessListener(new OnSuccessListener<Void>() {
                                                    @Override
                                                    public void onSuccess(Void aVoid) {
                                                        Intent intent = new Intent(RegisterActivity.this,
                                                                LoginActivity.class);
                                                        intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK |
                                                                Intent.FLAG_ACTIVITY_CLEAR_TASK);
                                                        intent.putExtra("name", fName + " " + lName);
                                                        startActivity(intent);
                                                    }
                                                });
                                    }

                                }
                            });
                } else {
                    CustomToast.createToast(RegisterActivity.this, "Error Occurred !", true);
                }
            }
        });

        tvSignIn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i = new Intent(RegisterActivity.this, LoginActivity.class);
                i.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
                startActivity(i);
            }
        });
    }
}