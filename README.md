# Proyecto Restaurante

## Cátedra Lenguaje II

Proyecto desarrollado como parte de la materia **Lenguaje II** del:

**ITEC3**

---

## Docente

**Luis Papazoglu**

---

## Descripción del proyecto

Este proyecto consiste en el desarrollo de un sistema para la **administración de un restaurante**.

El sistema permitirá gestionar las principales operaciones relacionadas con el funcionamiento del restaurante, aplicando los conceptos de programación orientada a objetos, acceso a datos y arquitectura en capas trabajados durante la materia.

El proyecto será desarrollado progresivamente durante la cursada y se utilizará como **proyecto de ejemplo y material de apoyo**.

> **Importante para los alumnos:**  
> El código publicado en este repositorio tiene como finalidad servir como ejemplo y guía de aprendizaje.  
> Cada alumno deberá analizar el código, comprender su funcionamiento y **adaptarlo a las necesidades de su propio proyecto**.

---

## Arquitectura

El proyecto utiliza una **arquitectura en capas**, separando las responsabilidades de cada parte del sistema.

La solución está organizada en **5 capas**:

```text
┌──────────────────────────────┐
│            View              │
│     Interfaz de usuario      │
└──────────────┬───────────────┘
               │
┌──────────────▼───────────────┐
│          Controller          │
│     Control de acciones      │
└──────────────┬───────────────┘
               │
┌──────────────▼───────────────┐
│           Service            │
│      Lógica de negocio       │
└──────────────┬───────────────┘
               │
┌──────────────▼───────────────┐
│          Repository           │
│       Acceso a datos          │
└──────────────┬───────────────┘
               │
┌──────────────▼───────────────┐
│            Model              │
│      Entidades del sistema    │
└───────────────────────────────┘
