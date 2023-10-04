using System;
using System.Collections.Generic;
using System.Text;

namespace DevFreela.Application.InputModels
{
    public class CreateCommentInputModel
    {
        public string Content { get; set; } = string.Empty;
        public int IdProject { get; set; }
        public int IdUser { get; set; }
    }
}
