package ru.mina987.lab.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.server.ResponseStatusException;
import ru.mina987.lab.pojo.Schoolboy;
import ru.mina987.lab.repository.SchoolboyRepository;

import java.util.Optional;

@Controller
public class SchoolboyController {
    @Autowired
    private SchoolboyRepository schoolboyRepository;

    @GetMapping("/")
    public String index(Model model){
        return "redirect:/list";
    }
    @GetMapping("/list")
    public String list(Model model){
        model.addAttribute("list", schoolboyRepository.findAll());
        return "list";
    }
    @GetMapping("/add")
    public String add(Model model){
        model.addAttribute("schoolboy", new Schoolboy());
        model.addAttribute("title", "Добавить");
        model.addAttribute("url", "/add");
        return "edit";
    }
    @PostMapping("/add")
    public String add(Model model,
                      Schoolboy schoolboy){
        if(schoolboy.getId() != null){
            schoolboy.setId(null);
        }
        return "redirect:/item/" + schoolboyRepository.save(schoolboy).getId();
    }
    @PostMapping("/remove")
    public String remove(Model model,
                         @RequestParam int id){
        schoolboyRepository.deleteById((long) id);
        return "redirect:/list";
    }
    @GetMapping("/update/{id:\\d+}")
    public String update(Model model,
                         @PathVariable int id){
        Optional<Schoolboy> schoolboy = schoolboyRepository.findById((long) id);
        if(schoolboy.isEmpty()){
            throw  new ResponseStatusException(HttpStatus.NOT_FOUND, "Школьник не найден");
        }
        model.addAttribute("schoolboy", schoolboy.get());
        model.addAttribute("title", "Обновить");
        model.addAttribute("url", "/update");
        return "edit";
    }
    @PostMapping("/update")
    public String update(Model model,
                         Schoolboy schoolboy){
        if(schoolboy.getId() != null && schoolboyRepository.existsById(schoolboy.getId())){
            schoolboyRepository.save(schoolboy);
            return "redirect:/item/" + schoolboy.getId();
        }
        throw  new ResponseStatusException(HttpStatus.BAD_REQUEST, "Данного школьника не существует");
    }
    @GetMapping("/item/{id:\\d+}")
    public String item(Model model,
                       @PathVariable int id){
        Optional<Schoolboy> schoolboy = schoolboyRepository.findById((long) id);
        if(schoolboy.isEmpty()){
            throw  new ResponseStatusException(HttpStatus.NOT_FOUND, "Школьник не найден");
        }
        model.addAttribute("schoolboy", schoolboy.get());
        return "item";
    }



}
