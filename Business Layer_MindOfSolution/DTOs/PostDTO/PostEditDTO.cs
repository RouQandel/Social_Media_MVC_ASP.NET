using Business_Layer_MindOfSolution.DTOs.ContentsDTO;
using Business_Layer_MindOfSolution.DTOs.PostCategoryDTO;
using Business_Layer_MindOfSolution.DTOs.PostTagDTO;
using DataAccess_Layer_Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_MindOfSolution.DTOs.PostDTO
{
    public class PostEditDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public DateTime CreatedAt { get; set; }
        public string thumbnail { get; set; }
        public bool IsPublished { get; set; } = false;
        public string UserId { get; set; }
        public UserDTO.EditUserDTO User { get; set; }

        public List<ContentListDTTO> contents { get; set; }
        public ICollection<PostCategoryListDTO> postCategories { get; set; }
        public ICollection<PostTagListDTO> postTags { get; set; }
        List<int> CategoryIds { get; set; }
        List<int> TagIds { get; set; }
        public User user { get; set; }
    }
}
