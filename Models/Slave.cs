using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__MateoMontoyaOspina.Models;
public class Slave
{
    public string Name {get; set;}
    public string ProcedenceCountry {get; set;}
    public int age {get; set;}
    public double WeightInKG {get; set;}
    public double HeightInM{get; set;}


    public Slave(string Name,string ProcedenceCountry,int age,double WeightInKG,double HeightInM)
    {
        this.Name = Name;
        this.ProcedenceCountry = ProcedenceCountry;
        this.age = age;
        this.WeightInKG = WeightInKG;
        this.HeightInM = HeightInM;
    }
}
