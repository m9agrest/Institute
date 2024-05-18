package com.example.work.struct;

import com.example.work.Service;

import java.sql.ResultSet;
import java.sql.SQLException;

public class Message {
    private Message(Service service, int id, int interaction, int sender, String text) {
        this.id = id;
        this.interaction = interaction;
        this.sender = sender;
        this.text = text;
        this.service = service;
    }
    static public Message parse(Service service, ResultSet data) throws SQLException {
        return new Message(
                service,
                data.getInt("id"),
                data.getInt("interaction"),
                data.getInt("sender"),
                data.getString("text")
        );
    }
    Service service;
    private int id;
    public int getId(){return id;}
    private int interaction;
    public int getInteraction(){return interaction;}
    private int sender;
    public int getSender(){return sender;}
    private String text;
    public String getText(){return text;}

    public void update(int interaction, int sender, String text){
        this.interaction = interaction;
        this.sender = sender;
        this.text = text;
        service.update(this);
    }
}
