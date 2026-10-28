Shader "Custom/Teste"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _X ("Valor em X", Range(-10, 10)) = 0
        _Y ("Valor em Y", Range(-10, 10)) = 0
        _Z ("Valor em Z", Range(-20, 20)) = 0
    }

    SubShader
    {
        Tags
        {
            "Queue" = "Transparent"
            "RenderType" = "Transparent"
        }

        Pass
        {
            Blend SrcAlpha OneMinusSrcAlpha

            CGPROGRAM

            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float4 vertex : SV_POSITION;
                float2 uv : TEXCOORD0;
                float3 worldPos : TEXCOORD1;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            float4 _Color;
            float _X, _Y, _Z;

            v2f vert(appdata v)
            {
                v2f o;

                o.vertex = UnityObjectToClipPos(v.vertex);

                o.uv = TRANSFORM_TEX(v.uv, _MainTex);

                o.worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;

                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                fixed4 color = tex2D(_MainTex, i.uv) * _Color;

                float3 c = _WorldSpaceCameraPos.xyz;

                if (dot(i.worldPos, c) > 0.5)
                {
                    return fixed4(1, 0, 1, 1);
                }
                else
                {
                    return fixed4(0, 0, 0, 0);
                }
            }

            ENDCG
        }
    }

    FallBack "Diffuse"
}