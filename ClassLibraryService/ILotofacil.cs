using ClassLibraryLoterica.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibraryService
{
    public interface ILotofacil
    {
        IEnumerable<Lotofacil> GetAllConcursos();
        Lotofacil GetConcurso(int? concurso);
    }
}
