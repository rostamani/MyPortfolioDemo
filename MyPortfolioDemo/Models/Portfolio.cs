using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolioDemo.Models
{
    public class Portfolio
    {
        [Key]
        public int PortfolioId { get; set; }

        [Display(Name ="عنوان پروژه")]
        [Required(ErrorMessage ="{0} نمیتواند خالی باشد.")]
        [MaxLength(100,ErrorMessage ="{0} نمیتواند بیشتر از {1} کاراکتر باشد.")]
        public string Title { get; set; }

        [Display(Name = "توضیح پروژه")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        [MaxLength(250, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد.")]
        public string Description { get; set; }

        [Display(Name = "تصویر")]   
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد.")]
        public string ImageName { get; set; }

    }
}
