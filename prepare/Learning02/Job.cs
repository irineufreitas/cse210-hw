using System;
using System.ComponentModel.DataAnnotations;
public class Job //class

{
  public string _jobTitle;
  public string _company;
  public int _startYear;
  public int _endYear;

  public void DisplayTo()
  {
    Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
  }
}
