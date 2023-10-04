﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DevFreela.Application.InputModels
{
    public class UpdateProjectInputModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal TotalCost { get; set; }
    }
}
