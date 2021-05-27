using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    /// <summary>
    /// 算法基类
    /// </summary>
    public class Operation 
    {
        private float numberA = 0;
        private float numberB = 0;
        private float result = 0;

        public float NumberA { get => numberA; set => numberA = value; }
        public float NumberB { get => numberB; set => numberB = value; }

        /// <summary>
        /// 计算结果
        /// </summary>
        /// <returns></returns>
        public virtual float GetResult() 
        {

            return result;

        }
    }

    /// <summary>
    /// 加法运算
    /// </summary>
    public class AddOperats : Operation
    {

        public override float GetResult()
        {

            return NumberA + NumberB;

        }

    }

    /// <summary>
    /// 减法运算
    /// </summary>
    public class ReduceOperats : Operation
    {

        public override float GetResult()
        {

            return NumberA - NumberB;

        }

    }

    /// <summary>
    /// 乘法运算
    /// </summary>
    public class MultiplyOperats : Operation
    {

        public override float GetResult()
        {

            return NumberA * NumberB;

        }

    }

    /// <summary>
    /// 除法运算
    /// </summary>
    public class DivideOperats : Operation
    {

        public override float GetResult()
        {

            if (NumberB == 0) {

                Debug.LogError(" Divisor cannot be 0 ");
                return float.NaN;

            }

            return NumberA / NumberB;

        }

    }

    /// <summary>
    /// 幂运算
    /// </summary>
    public class PowOperats : Operation
    {

        public override float GetResult()
        {

            return Mathf.Pow(NumberA, NumberB);

        }

    }

}
