package com.example.registerfirebasewithdatabase.model;

public class Facility {
    private String id, name, town, address, phone;

    public Facility() {
    }

    public Facility(String id, String name, String town, String address, String phone) {
        this.id = id;
        this.name = name;
        this.town = town;
        this.address = address;
        this.phone = phone;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getTown() {
        return town;
    }

    public void setTown(String town) {
        this.town = town;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }
}
