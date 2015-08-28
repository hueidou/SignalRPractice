using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalRPractice.ServerMonitor
{
    public class ServerMonitorInfo
    {

        /// <summary>
        /// SeqID
        /// </summary>
        [Display(Name = "SeqID")]
        public int? SeqID { get; set; }

        /// <summary>
        /// 服务器IP
        /// </summary>
        [Display(Name = "服务器IP")]
        [Required(ErrorMessage = "服务器IP不能为空。")]
        [StringLength(30, ErrorMessage = "服务器IP必须至少包含1个字符。", MinimumLength = 1)] //此默认生成的，请根据业务逻辑修改
        public string IP { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [Required(ErrorMessage = "创建时间不能为空。")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// CPU使用率
        /// </summary>
        [Required]
        [Display(Name = "CPU使用率")]
        [StringLength(500, ErrorMessage = "CPU使用率必须至少包含1个字符。", MinimumLength = 1)] //此默认生成的，请根据业务逻辑修改
        public string CPU { get; set; }

        /// <summary>
        /// 内存使用率
        /// </summary>
        [Required]
        [Display(Name = "内存使用率")]
        public int? Memory { get; set; }

        /// <summary>
        /// 磁盘IO
        /// </summary>
        [Required]
        [Display(Name = "磁盘IO")]
        public int? HardDisk { get; set; }

        /// <summary>
        /// 网络使用
        /// </summary>
        [Required]
        [Display(Name = "网络使用")]
        public int? NetWork { get; set; }

        /// <summary>
        /// 进程数
        /// </summary>
        [Required]
        [Display(Name = "进程数")]
        public int? Process { get; set; }

        /// <summary>
        /// 线程数
        /// </summary>
        [Required]
        [Display(Name = "线程数")]
        public int? Thread { get; set; }


    }
}