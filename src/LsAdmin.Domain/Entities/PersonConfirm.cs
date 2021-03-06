using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LsAdmin.Domain.Entities
{
    public class PersonConfirm:BaseEntity
    {
        //账户名
        public string UserName { get; set; }
        //姓名
        [Required]
        public string Name { get; set; }

        //身份证号码
        [Required]
        public string IdNumber { get; set; }

        //身份证类型
        public string IdType { get; set; }

        //个人信息所在面
        public byte[] UploadIdFront { get; set; }

        //国徽图案所在面
        public byte[] UploadIdBack { get;set; }

        //身份证到期时间
        [Required]
        public string IdDuration { get; set; }

        //常用地址
        [Required]
        public string Location { get; set; }
    }
}
