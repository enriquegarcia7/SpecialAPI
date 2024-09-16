using System;
using SpeacialAPI.Models;

namespace SpeacialAPI.Services;

public class MandrilDataStore
{
    public List<Mandril> Mandriles {get; set;}

    public static MandrilDataStore Current { get; } = new MandrilDataStore();

    public MandrilDataStore()
    {
        Mandriles = new List<Mandril>(){
            new Mandril(){
                Id = 1,
                Nombre = "Mandrilo",
                Apellido = "Mandrilez",
                Habilidades = new List<Habilidad>(){
                    new Habilidad(){
                        Id = 1,
                        Nombre = "Habilidad 1",
                        Potencia = Habilidad.EPotencia.Suave
                    },
                    new Habilidad(){
                        Id = 2,
                        Nombre = "Habilidad 2",
                        Potencia = Habilidad.EPotencia.Moderado
                    }
                }
            },
            new Mandril(){
                Id = 2,
                Nombre = "Mandrila",
                Apellido = "Mandrilez",
                Habilidades = new List<Habilidad>(){
                    new Habilidad(){
                        Id = 3,
                        Nombre = "Habilidad 3",
                        Potencia = Habilidad.EPotencia.Intenso
                    },
                    new Habilidad(){
                        Id = 4,
                        Nombre = "Habilidad 4",
                        Potencia = Habilidad.EPotencia.RePotente
                    }
                }
            },
        };
    }
}
