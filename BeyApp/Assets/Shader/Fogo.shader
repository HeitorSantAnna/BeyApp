Shader "Custom/Fogo"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _ColorTwo ("Segunda Cor", Color) = (0, 0, 0, 1)

        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _MapColor ("Mapa de coordenadas de movimentação", 2D) = "white" {}

        _Slider ("Slider", Range(-100, 100)) = 0
        _X ("Slider X", Range(-10, 10)) = 0
        _Y ("Slider Y", Range(-10, 10)) = 0
        _Z ("Slider Z", Range(-10, 10)) = 0
    }
    SubShader
    {
        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows vertex:vert

        sampler2D _MainTex;
        sampler2D _MapColor;

        struct Input
        {
            float2 uv_MainTex;
            float2 uv_MapColor;
        };

        fixed4 _Color;
        fixed4 _ColorTwo;
        float _Slider, _X, _Y, _Z;

        inline float unity_noise_randomValue (float2 uv)
        {
            return frac(sin(dot(uv, float2(12.9898, 78.233)))*43758.5453);
        }

        inline float unity_noise_interpolate (float a, float b, float t)
        {
            return (1.0-t)*a + (t*b);
        }

        inline float unity_valueNoise (float2 uv)
        {
            float2 i = floor(uv);
            float2 f = frac(uv);
            f = f * f * (3.0 - 2.0 * f);

            uv = abs(frac(uv) - 0.5);
            float2 c0 = i + float2(0.0, 0.0);
            float2 c1 = i + float2(1.0, 0.0);
            float2 c2 = i + float2(0.0, 1.0);
            float2 c3 = i + float2(1.0, 1.0);
            float r0 = unity_noise_randomValue(c0);
            float r1 = unity_noise_randomValue(c1);
            float r2 = unity_noise_randomValue(c2);
            float r3 = unity_noise_randomValue(c3);

            float bottomOfGrid = unity_noise_interpolate(r0, r1, f.x);
            float topOfGrid = unity_noise_interpolate(r2, r3, f.x);
            float t = unity_noise_interpolate(bottomOfGrid, topOfGrid, f.y);
            return t;
        }

        void Unity_SimpleNoise_float(float2 UV, float Scale, out float Out)
        {
            float t = 0.0;

            float freq = pow(2.0, float(0));
            float amp = pow(0.5, float(3-0));
            t += unity_valueNoise(float2(UV.x*Scale/freq, UV.y*Scale/freq))*amp;

            freq = pow(2.0, float(1));
            amp = pow(0.5, float(3-1));
            t += unity_valueNoise(float2(UV.x*Scale/freq, UV.y*Scale/freq))*amp;

            freq = pow(2.0, float(2));
            amp = pow(0.5, float(3-2));
            t += unity_valueNoise(float2(UV.x*Scale/freq, UV.y*Scale/freq))*amp;

            Out = t;
        }

        void vert (inout appdata_full v)
        {
            float noise;
            Unity_SimpleNoise_float(v.vertex.xy, 5, noise);

            if(noise > 0.5)
            {
                v.vertex.z += v.normal * 0.1 * _Slider;
            } 
            //else

            /*if(v.texcoord.x > 0.8 || v.texcoord.x < 0.2 || v.texcoord.y > 0.8 || v.texcoord.y < 0.2)
            {
                v.vertex.xyz += noise * 0.1 * sin(100 + (_Time.y * _Slider));
            }*/

            //v.vertex.xyz += noise * 0.1 * sin(10 + (_Time.y * _Slider));
        }

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
            if(IN.uv_MainTex.x > 0.8 || IN.uv_MainTex.x < 0.2 || IN.uv_MainTex.y > 0.8 || IN.uv_MainTex.y < 0.2)
            {
                o.Albedo = _ColorTwo;
            } 
            else
            {
                o.Albedo = _Color;
            }
            //o.Albedo = _Color;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
