﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary1;

namespace WareHouse
{
    public class WareHouse:IMyObject
    {
        public WareHouse()
        { }

        public WareHouse(string foodsName, double foodsNum, string unit)
        {
            this.foodsName = foodsName;
            this.foodsNum = foodsNum;
            this.unit = unit;
        }

        public WareHouse(string foodsName, double foodsNum)
        {
            this.foodsName = foodsName;
            this.foodsNum = foodsNum;
        }

        private string unit;

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }


        public string PrimaryKey
        {
            get { return foodsName; }
            set { foodsName = value; }
        }
        
        private string foodsName;

        /// <summary>
        /// 货物名称
        /// </summary>          
        public string FoodsName
        {
            get { return foodsName; }
            set { foodsName = value; }
        }

        private double foodsNum;

        /// <summary>
        /// 库存数量
        /// </summary>
        public double FoodsNum
        {
            get { return foodsNum; }
            set { foodsNum = value; }
        }

        public string ShowMe()
        {
            throw new NotImplementedException();
        }
    }
}
