﻿using Hospital_Mangment_System_DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Mangment_System_DAL.Repositary.Abstraction
{
    public interface IPatientsRepo
    {
        public bool add(Patient patient);
        public bool delete(int id);

        public bool update(Patient patient);

        public Patient getbyId(int id);

        public List<Patient> getAll();

    }
}
