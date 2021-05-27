using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    /// <summary>
    /// 简单工厂测试类 
    /// </summary>
    public class SimpleFactoryMain : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // 创建简单工厂并指定产品的类型并生产
            OperationFactory factory = new OperationFactory();
            var operate = factory.CreateType(OperateType.Add);

            // 指定运算数据
            operate.NumberA = 5;
            operate.NumberB = 2;

            // 计算结果
            var result = operate.GetResult();

            Debug.Log(result);

        }

    }

}
