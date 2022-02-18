﻿using LsAdmin.Domain.Entities;
using System;

namespace LsAdmin.Application.PlayPriceApp.Dtos
{
    public class PlayPriceDto
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 类型（area=区域、place=店铺、equipment=设备、combo=套餐）
        /// </summary>
        public string PlayType { get; set; }
        /// <summary>
        /// 版本
        /// </summary>
        public string version { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 时间段类型
        /// </summary>
        public string TimeRangeType { get; set; }
        /// <summary>
        /// 时间段
        /// </summary>
        public string TimeRange { get; set; }

        /// <summary>
        /// 时间段单价
        /// </summary>
        public Decimal Price { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        public string Street { get; set; }


        public Guid EquipmentID { get; set; }

        /// <summary>
        /// 套餐名称
        /// </summary>
        public string combo { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public Guid CreateUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
