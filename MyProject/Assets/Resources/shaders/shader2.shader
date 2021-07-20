/*
 第一次自定义输入输出结构   
*/

Shader "Unlit/shader2"
{
    SubShader
    {
       
       Pass{
       
           CGPROGRAM

           #pragma vertex vert
           #pragma fragment frag 
           
           struct a2v {
           
               // POSITION 语义告诉Unity, 用模型空间的顶点坐标填充vertex 
               float4 vertex : POSITION;

               // NORMAL 语义告诉Unity，用模型空间的法线向量填充normal
               float3 normal : NORMAL;

               // TEXCOORD0 语义告诉unity，用模型的第一套纹理坐标填充texcoord变量
               float4 texcoord : TEXCOORD0; 

           };

           struct v2f{  
           
               // SV_POSITION 语义告诉Unity，pos中包含了剪裁空间中的位置信息
               float4 pos : SV_POSITION;

               // COLOR语义可以用于存储颜色信息
               fixed3 col : COLOR0;
           

           }; 

           v2f vert( a2v v ) {
           
                v2f o;

                // 使用v.vertex来访问模型空间的顶点坐标
                o.pos = UnityObjectToClipPos( v.vertex );

                // v.normal 包含了顶点的法线信息，分量范围为[ -1.0, 1.0 ];
                // 下面的代码把分量范围映射到[ 0.0， 1.0 ]；
                // 存储到o.col中传递给片元着色器
                o.col = v.normal * 0.5 + fixed3( 0.5, 0.5, 0.5 );

                return o;

           }

           fixed4 frag( v2f i ) : SV_Target{
            
                
                //将插值后的i.col显示到屏幕上
                return fixed4( i.col, 1.0 );

           }

           ENDCG


       }
        
    }
}
