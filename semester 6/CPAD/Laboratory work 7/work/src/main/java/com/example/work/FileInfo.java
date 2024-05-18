package com.example.work;

import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.time.LocalDateTime;
import java.time.ZoneOffset;
public class FileInfo {
    public enum FileType {
        FILE("F"), DIRECTORY("D");
        private String name;
        FileType(String name) {
            this.name = name;
        }
        public String getName() {
            return name;
        }
    }
    private FileType type;
    public FileInfo(Path path) {
        try {
            this.fileName = path.getFileName().toString();
            this.size = Files.size(path);
            this.type = Files.isDirectory(path) ? FileType.DIRECTORY : FileType.FILE;
            if(type==FileType.DIRECTORY){
                size=-1L;
            }
            this.lastModified = LocalDateTime.ofInstant(Files.getLastModifiedTime(path).toInstant(),
                    ZoneOffset.ofHours(3));
        } catch (IOException e) {
            throw new RuntimeException("Unable to get file info");
        }
    }
    private String fileName;
    private long size;
    private LocalDateTime lastModified;
    public FileType getType() {
        return type;
    }
    public void setType(FileType type) {
        this.type = type;
    }
    public String getFileName() {
        return fileName;
    }
    public void setFileName(String fileName) {
        this.fileName = fileName;
    }
    public long getSize() {
        return size;
    }
    public void setSize(long size) {
        this.size = size;
    }
    public LocalDateTime getLastModified() {
        return lastModified;
    }
    public void setLastModified(LocalDateTime lastModified) {
        this.lastModified = lastModified;
    }
}