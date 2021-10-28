using ClassLibraryLoterica.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibraryService
{
    public interface ILotofacil
    {
        IEnumerable<Lotofacil> GetAllConcursos();
        Lotofacil GetConcurso(int? id);
        Lotofacil GetPontos15(int? Dezena_01, int? Dezena_02, int? Dezena_03, int? Dezena_04, int? Dezena_05, 
                              int? Dezena_06, int? Dezena_07, int? Dezena_08, int? Dezena_09, int? Dezena_10, 
                              int? Dezena_11, int? Dezena_12, int? Dezena_13, int? Dezena_14, int? Dezena_15);
        IEnumerable<Lotofacil> GetPontos(int? Dezena_01, int? Dezena_02, int? Dezena_03, int? Dezena_04, int? Dezena_05,
                                         int? Dezena_06, int? Dezena_07, int? Dezena_08, int? Dezena_09, int? Dezena_10,
                                         int? Dezena_11, int? Dezena_12, int? Dezena_13, int? Dezena_14, int? Dezena_15);
    }
}
