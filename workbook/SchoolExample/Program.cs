﻿using SchoolExample;

/// <summary>
/// An example class for students and classGroups.
/// Author: Angelo Encarnacion
/// Date Modified: Jul-30-2024
/// </summary>
/// 

const int MaxStudents = 25;

Student[] students = new Student[MaxStudents];

Student angelo = new Student("Angelo", "Encarnacion", 34);
angelo.SetFirstName("            Socks");

Console.WriteLine(angelo.GetFullName());
