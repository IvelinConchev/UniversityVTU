package com.example.registerfirebasewithdatabase.adapters;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.example.registerfirebasewithdatabase.R;
import com.example.registerfirebasewithdatabase.model.Facility;

import java.util.List;

public class FacilityAdapter extends ArrayAdapter<Facility> {

    Context context;
    List<Facility> arrayListFacility;

    public FacilityAdapter(@NonNull Context context, List<Facility> arrayListFacility) {
        super(context, R.layout.custom_list_item, arrayListFacility);

        this.context = context;
        this.arrayListFacility = arrayListFacility;
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {

        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.custom_list_item, null, true);

        TextView tvID = view.findViewById(R.id.txt_id);
        TextView tvName = view.findViewById(R.id.txt_name);

        tvID.setText(arrayListFacility.get(position).getId());
        tvName.setText(arrayListFacility.get(position).getName());

        return view;
    }
}

