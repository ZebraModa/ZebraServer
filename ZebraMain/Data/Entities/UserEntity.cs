﻿using CommonLibraries.CommonTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZebraData.Entities
{
  [Table("User")]
  public class UserEntity
  {
    [Key]
    public int UserId { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public SexType SexType { get; set; }
    public int CityId { get; set; }
    public string Description { get; set; }
  }
}