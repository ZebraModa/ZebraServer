﻿using System.Collections.Generic;

namespace SweaterServer.ViewModels
{
  public class ListResponseViewModel<T>
  {
    public int Count { get; set; }

    public List<T> List { get; set; }
  }
}