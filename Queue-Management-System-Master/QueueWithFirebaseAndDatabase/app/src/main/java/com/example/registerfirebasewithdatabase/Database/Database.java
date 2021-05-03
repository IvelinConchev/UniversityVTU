package com.example.registerfirebasewithdatabase.Database;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteQueryBuilder;

import com.example.registerfirebasewithdatabase.model.Friend;
import com.readystatesoftware.sqliteasset.SQLiteAssetHelper;

import java.util.ArrayList;
import java.util.List;


public class Database extends SQLiteAssetHelper {

    private static final String DB_NAME="friend.db";
    private static final int DB_VER=1;

    public Database(Context context) {
        super(context, DB_NAME, null, DB_VER);
    }

    //Function get all friends
    public List<Friend> getFriends()
    {
        SQLiteDatabase db = getReadableDatabase();
        SQLiteQueryBuilder qb = new SQLiteQueryBuilder();

        //Make sure all is column name in your Table
        String[] sqlSelect = {"Id", "Name", "Address", "Email", "Phone"};
        String tableName="Friends";// Make sure this is your table name

        qb.setTables(tableName);
        Cursor cursor = qb.query(db, sqlSelect, null, null, null, null, null);
        List<Friend> result = new ArrayList<>();
        if (cursor.moveToFirst())
        {
            do{
                Friend friend = new Friend();
                friend.setId(cursor.getInt(cursor.getColumnIndex("id")));
                friend.setName(cursor.getString(cursor.getColumnIndex("Name")));
                friend.setAddress(cursor.getString(cursor.getColumnIndex("Address")));
                friend.setEmail(cursor.getString(cursor.getColumnIndex("Email")));
                friend.setPhone(cursor.getString(cursor.getColumnIndex("Phone")));

                result.add(friend);
            }while (cursor.moveToNext());
        }
        return result;
    }

    //Function get all friend's name
    public List<String> getNames()
    {
        SQLiteDatabase db = getReadableDatabase();
        SQLiteQueryBuilder qb = new SQLiteQueryBuilder();

        //Make sure all is column name in your Table
        String[] sqlSelect = {"Name"};
        String tableName="Friends";// Make sure this is your table name

        qb.setTables(tableName);
        Cursor cursor = qb.query(db, sqlSelect, null, null, null, null, null);
        List<String> result = new ArrayList<>();
        if (cursor.moveToFirst())
        {
            do{
                result.add(cursor.getString(cursor.getColumnIndex("Name")));
            }while (cursor.moveToNext());
        }
        return result;
    }


    //Function get friend by name
    public List<Friend> getFriendByName(String name) {
        SQLiteDatabase db = getReadableDatabase();
        SQLiteQueryBuilder gb = new SQLiteQueryBuilder();

        //Make sure all is column name in your Table
        String[] sqlSelect = {"Id", "Name", "Address", "Email", "Phone"};
        String tableName = "Friends"; //Make sure this is your table name

        gb.setTables(tableName);
        //If you want to get extract name, just change
        // Cursor cursor = gb.query(db, sqlSelect, "Name = ?", new String[] {name}, null, null, null);

        //This will like query : Select * from Friends where Name LIKE %pattern%"

        Cursor cursor = gb.query(db, sqlSelect, "Name LIKE ?", new String[] {"%"+name+"%"}, null, null, null);
        List<Friend> result = new ArrayList<>();
        if (cursor.moveToFirst()) {
            do {
                Friend friend = new Friend();
                friend.setId(cursor.getInt(cursor.getColumnIndex("id")));
                friend.setName(cursor.getString(cursor.getColumnIndex("Name")));
                friend.setAddress(cursor.getString(cursor.getColumnIndex("Address")));
                friend.setEmail(cursor.getString(cursor.getColumnIndex("Email")));
                friend.setPhone(cursor.getString(cursor.getColumnIndex("Phone")));

                result.add(friend);
            } while (cursor.moveToNext());
        }
        return result;
    }
}

