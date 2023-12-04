﻿using System;
using System.Collections.Generic;

namespace SchoolManagementApp.MVC.Data;

public partial class Lecturer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();
}
