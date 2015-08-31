using AcmeCursos.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcmeCursos.WCFClient
{
    public class AutoMapper
    {

        public static void Configurar()
        {
            Mapper.CreateMap<Curso, CursoService.Curso>().ReverseMap();
            Mapper.CreateMap<Curso, EstudanteService.Curso>().ReverseMap();
            Mapper.CreateMap<Curso, ProfessorService.Curso>().ReverseMap();
            
            Mapper.CreateMap<Estudante, EstudanteService.Estudante>().ReverseMap();
            
            Mapper.CreateMap<Inscricao, InscricaoService.Inscricao>().ReverseMap();
            Mapper.CreateMap<Inscricao, EstudanteService.Inscricao>().ReverseMap();
            
            Mapper.CreateMap<Professor, ProfessorService.Professor>().ReverseMap();
            Mapper.CreateMap<Professor, CursoService.Professor>().ReverseMap();
        }

    }
}