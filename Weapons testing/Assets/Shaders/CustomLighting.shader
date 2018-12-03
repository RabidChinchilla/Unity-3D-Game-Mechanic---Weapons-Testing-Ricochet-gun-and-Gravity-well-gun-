Shader "ISS/CustomLighting"
{
	Properties{
		_MainTex("Albedo (RGB)", 2D) = "white" {}
	}
		SubShader{
		Tags{ "RenderType" = "Opaque" }
		LOD 200

		CGPROGRAM
		#pragma surface surf ISS
		#pragma target 3.0

		sampler2D _MainTex;

	struct Input
	{
		float2 uv_MainTex;
	};

	half4 LightingISS(SurfaceOutput s, half3 lightDir, half3 viewDir, half atten)
	{
		half4 c;
		c.rgb = s.Albedo;
		c.a = s.Alpha;
		return c;
	}

	void surf(Input IN, inout SurfaceOutput o)
	{
		fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
		o.Albedo = c.rgb;
		o.Alpha = c.a;
	}
	ENDCG
	}
		FallBack "Diffuse"
}
