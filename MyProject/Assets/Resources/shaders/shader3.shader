/*
 第一个Properties   
*/

Shader "Unlit/shader3"
{
    Properties
    {
        // 声明一个Color类型的变量
        _Color( "Color Tint",Color ) = ( 1.0,1.0,1.0,1.0 )  
    }
    SubShader
    {

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            // CG代码中，我们需要定义一个与属性名称和类型完全匹配的变量
            fixed4 _Color;

            struct a2v
            {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
 
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                fixed3 color : COLOR;
            };

            v2f vert (a2v v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.color = v.normal * 0.5 + fixed3( 0.5,0.5,0.5 );

                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                fixed3 col = i.color;

                col *= _Color.rgb;

                return fixed4( col, 1.0 );
            }
            ENDCG
        }
    }
}
