package com.example.registerfirebasewithdatabase.fragments;

import androidx.fragment.app.Fragment;

import android.content.Intent;
import android.os.Build;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;

import com.example.registerfirebasewithdatabase.R;
import com.example.registerfirebasewithdatabase.activities.FacilityListActivity;
import com.example.registerfirebasewithdatabase.activities.ProfileActivity;
import com.example.registerfirebasewithdatabase.activities.ReservationsActivity;

public class NavigationFragment extends Fragment {
    Button navFacilities, navReservations, navProfile;

    public NavigationFragment() {

    }

    public static NavigationFragment newInstance() {
        NavigationFragment fragment = new NavigationFragment();
        return fragment;
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.activity_navigation_fragment, container, false);
        navFacilities = (Button) view.findViewById(R.id.navFacilities);
        navReservations = (Button) view.findViewById(R.id.navReservations);
        navProfile = (Button) view.findViewById(R.id.navProfile);

        // Цветът на текста на бутона в навигацията зависи от текущата активност
        int defaultColor = 0;
        int selectedColor = 0;
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
            defaultColor = getResources().getColor(R.color.colorNavigationDefault, null);
            selectedColor = getResources().getColor(R.color.colorNavigationSelected, null);
        } else {
            defaultColor = getResources().getColor(R.color.colorNavigationDefault);
            selectedColor = getResources().getColor(R.color.colorNavigationSelected);
        }


        final String currentActivityName = getActivity().getClass().getSimpleName();

        if (currentActivityName.equalsIgnoreCase(FacilityListActivity.class.getSimpleName())) {
            //избран списък на институциите
            navFacilities.setTextColor(selectedColor);

            navReservations.setTextColor(defaultColor);
            navProfile.setTextColor(defaultColor);
        } else if (currentActivityName.equalsIgnoreCase(ReservationsActivity.class.getSimpleName())) {
            // избран списък с резервации
            navReservations.setTextColor(selectedColor);

            navFacilities.setTextColor(defaultColor);
            navProfile.setTextColor(defaultColor);
        } else if (currentActivityName.equalsIgnoreCase(ProfileActivity.class.getSimpleName())) {
            // избрани настройки на профила
            navProfile.setTextColor(selectedColor);

            navFacilities.setTextColor(defaultColor);
            navReservations.setTextColor(defaultColor);
        } else {
            navFacilities.setTextColor(defaultColor);
            navReservations.setTextColor(defaultColor);
            navProfile.setTextColor(defaultColor);
        }

        //бутон за списък с институции
        navFacilities.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (!currentActivityName.equalsIgnoreCase(FacilityListActivity.class.getSimpleName())) {

                    Intent intent = new Intent(getActivity(), FacilityListActivity.class);
                    startActivity(intent);
                }
            }
        });

        //бутон за резервация
        navReservations.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (!currentActivityName.equalsIgnoreCase(FacilityListActivity.class.getSimpleName())) {

                    Intent intent = new Intent(getActivity(), ReservationsActivity.class);
                    startActivity(intent);
                }
            }
        });

        // бутон за резервация
//        navReservations.setOnClickListener(new View.OnClickListener() {
//            @Override
//            public void onClick(View v) {
//                if (!currentActivityName.equalsIgnoreCase(ReservationsActivity.class.getSimpleName())) {
//                    Intent intent;
//                    if (AppController.getInstance().isRemembered()) {
//                        // потребителят е влязъл
//                        intent = new Intent(getActivity(), ReservationsActivity.class);
//                    } else {
//                        // потребителят не е влязъл - отвежда се до екрана за вход
//                        if (currentActivityName.equalsIgnoreCase(LoginActivity.class.getSimpleName())) {
//                            //  ако не е на екрана за вход, да се покаже съобщението
//                            Snackbar.make(view, R.string.login_first, Snackbar.LENGTH_SHORT).show();
//                            return;
//                        }
//                        intent = new Intent(getActivity(), LoginActivity.class);
//                    }
//                    startActivity(intent);
//                }
//            }
//
//        });
        // бутон за настройки на профила
        navProfile.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (!currentActivityName.equalsIgnoreCase(ProfileActivity.class.getSimpleName())) {

                    Intent intent = new Intent(getActivity(), ProfileActivity.class);
                    startActivity(intent);
                }
            }
        });
        // бутон за настройки на профила
//        navProfile.setOnClickListener(new View.OnClickListener() {
//            @Override
//            public void onClick(View v) {
//                if (!currentActivityName.equalsIgnoreCase(ProfileActivity.class.getSimpleName())) {
//                    Intent intent;
//                    if (AppController.getInstance().isRemembered()) {
//                        // потребителят е влязъл
//                        intent = new Intent(getActivity(), ProfileActivity.class);
//                    } else {
//                        // ako потребителят не е влязъл - отвежда го до екрана за вход
//                        if (currentActivityName.equalsIgnoreCase(LoginActivity.class.getSimpleName())) {
//                            //ако вече не е на екрана за вход, показва съобщението
//                            Snackbar.make(v, R.string.login_first, Snackbar.LENGTH_SHORT).show();
//                            return;
//                        }
//                        intent = new Intent(getActivity(), LoginActivity.class);
//                    }
//                    startActivity(intent);
//                }
//            }
//        });
        return view;
    }
}
