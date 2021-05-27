using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{

    /// <summary>
    /// 算法工厂类（简单工厂模式）
    /// </summary>
    public class OperationFactory 
    {

        /// <summary>
        /// 创建的类型对象
        /// </summary>
        /// <param name="type"></param>
        public Operation CreateType(OperateType type) 
        {

            // 运算方式对象
            Operation operation = null;

            switch (type)
            {
                case OperateType.Add:

                    operation = new AddOperats();

                    break;
                case OperateType.Reduce:

                    operation = new ReduceOperats();

                    break;
                case OperateType.Multiply:

                    operation = new MultiplyOperats();

                    break;
                case OperateType.Divide:

                    operation = new DivideOperats();

                    break;
                case OperateType.Pow:

                    operation = new PowOperats();

                    break;

            }

            return operation;

        }

    }

    /// <summary>
    /// 运算类型
    /// </summary>
    public enum OperateType
    {

        /// <summary>
        ///  加法
        /// </summary>
        Add,

        /// <summary>
        /// 减法
        /// </summary>
        Reduce,

        /// <summary>
        /// 乘法
        /// </summary>
        Multiply,

        /// <summary>
        /// 除法
        /// </summary>
        Divide,

        /// <summary>
        /// 幂运算
        /// </summary>
        Pow,

    }

}