using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Emperor
{
    public string Name { get; set; }
    public string Title { get; set; }
    public List<ModifierSkill> ModSkills { get; set; }
    public VerbianDate DOB { get; set; }
    public VerbianDate DOD { get; set; }
    public int LifeExpectancy { get; set; }
    public int AmassedGold { get; set; }
    public int AmassedMana { get; set; }
    public int RecruitedMages { get; set; }
    public int Portrait { get; set; }
    public List<string> ConqueredCities { get; set; }
}

