package ru.m9studio.lab1;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;

@Controller
public class MainController{

    @GetMapping("/")
    public String form(Model model){
        model.addAttribute("student", new Student());
        return "form";
    }

    @PostMapping("/")
    public String result(@ModelAttribute Student student, Model model){
        model.addAttribute("student", student);
        return "result";
    }
}
