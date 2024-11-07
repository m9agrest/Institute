package ru.m9studio.lab2;

import jakarta.servlet.http.HttpServletRequest;
import jakarta.websocket.server.PathParam;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

@Controller
public class PageController {
    @Autowired
    private StudentService studentService;

    @GetMapping("/")
    public String index(){
        return "redirect:/students";
    }
    @GetMapping("/students")
    public String allStudents(Model model){
        model.addAttribute("students", studentService.getAllStudents());
        return "list";
    }

    @GetMapping("/student{id:\\d+}")
    public String student(Model model,
                          @PathVariable int id){
        Student student = studentService.getStudentById(id);
        if(student == null)
            throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Студент не найден");
        model.addAttribute("student", student);
        return "item";
    }

    @GetMapping("/delete")
    public String delete(Model model,
                         @RequestParam(required = true) int id){
        if(!studentService.removeStudentById(id)){
            throw new ResponseStatusException(HttpStatus.UNPROCESSABLE_ENTITY, "Студента по данному id нет");
        }
        return "redirect:/students";
    }

    @GetMapping("/create")
    public String create(Model model) {
        model.addAttribute("student", new Student());
        return "create";
    }
    @PostMapping("/create")
    public String create(@ModelAttribute Student student, Model model){
        return "redirect:/student" + studentService.addStudent(student);
    }
}
