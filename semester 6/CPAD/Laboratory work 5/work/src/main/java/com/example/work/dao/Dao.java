package com.example.work.dao;
import java.util.Collection;
public interface Dao<T, ID> {
    T findById(ID id);

    Collection<T> findALl();

    T save(T entity);

    T update(T entity);

    void delete(T entity);

    void deleteById(ID id);
}
