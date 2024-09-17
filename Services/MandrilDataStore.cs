using System;
using SpeacialAPI.Models;

namespace SpeacialAPI.Services;

public class MandrilDataStore
{
    public List<Mandril> Mandriles { get; set; }

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
                        Nombre = "Saltar",
                        Potencia = Habilidad.EPotencia.Suave
                    },
                    new Habilidad(){
                        Id = 2,
                        Nombre = "Golpear",
                        Potencia = Habilidad.EPotencia.Moderado
                    }
                }
            },
            new Mandril(){
                Id = 2,
                Nombre = "Makita",
                Apellido = "Mandrilez",
                Habilidades = new List<Habilidad>(){
                    new Habilidad(){
                        Id = 3,
                        Nombre = "Correr",
                        Potencia = Habilidad.EPotencia.Intenso
                    },
                    new Habilidad(){
                        Id = 4,
                        Nombre = "Balancear",
                        Potencia = Habilidad.EPotencia.RePotente
                    }
                }
            },
            new Mandril(){
                Id = 3,
                Nombre = "Mandrinuevo",
                Apellido = "Mandrilezciano",
                Habilidades = new List<Habilidad>(){
                    new Habilidad(){
                        Id = 1,
                        Nombre = "Saltar",
                        Potencia = Habilidad.EPotencia.Suave
                    },
                    new Habilidad(){
                        Id = 2,
                        Nombre = "Golpear",
                        Potencia = Habilidad.EPotencia.Moderado
                    }
                }
            },
            new Mandril(){
                Id = 4,
                Nombre = "Mandriliziano",
                Apellido = "Mandri",
                Habilidades = new List<Habilidad>(){
                    new Habilidad(){
                        Id = 1,
                        Nombre = "Saltar",
                        Potencia = Habilidad.EPotencia.RePotente
                    },
                    new Habilidad(){
                        Id = 2,
                        Nombre = "Golpear",
                        Potencia = Habilidad.EPotencia.Extremo
                    }
                }
            },
        };
    }
}
