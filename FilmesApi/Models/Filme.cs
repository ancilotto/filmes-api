﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;
//propriedades que um filme tem
public class Filme
{
    [Required(ErrorMessage = "O título do filme é obrigatório")] 
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do campo gênero não pode exceder 50 caracteres.")]
    public string Genero { get; set; }
    [Required]
    [Range(70,600, ErrorMessage = "A duração do filme não pode ser menor que 70 e maior que 600 minutos.")]
    public int Duracao { get; set; }
}
