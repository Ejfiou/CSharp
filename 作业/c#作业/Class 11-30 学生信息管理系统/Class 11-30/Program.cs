﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  
///            学生管理系统：
///   *******************************
///   * 增加学生信息
///   * 修改学生信息
///   * 删除学生信息
///   * 查询所有学生信息
///   * 按学号查询对应的学生信息
///   * 按姓名查询对应的学生信息
/// </summary>
namespace Class_11_30
{
    class Program
    {
       
        static void Main(string[] args)
        {    
            MyController con = new MyController();
            con.Start();
        }
    }
}
