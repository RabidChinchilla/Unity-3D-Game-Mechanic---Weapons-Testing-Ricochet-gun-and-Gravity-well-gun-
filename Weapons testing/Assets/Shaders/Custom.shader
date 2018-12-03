Shader "ISS/Custom" {
	Properties {
		_Color("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_BumpMap("Normal Map", 2D) = "bump" {}

		_SpecColor("SpecularColor", Color) = (1,1,1,1)
		_Shininess("SpecPower", Range(-1, 2)) = 0.5
		_Glossiness("SpecPower", Range(0, 1)) = 0.5
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf ISS //surface shader called surf and custom Lighting model called ISS
		//#pragma surface surf Lambert //(diffuse)
		//#pragma surface surf Lambert vertex:vert // - Lambert lighting and a vertex shader called vert (diffuse with vertex shader)
		//#pragma surface surf BlinnPhong //(specular shader)

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

		sampler2D _MainTex;
		sampler2D _BumpMap;
		fixed4 _Color;
		fixed _Shininess;
		fixed _Glossiness;

		struct Input 
		{
			float2 uv_MainTex;
			float2 uv_BumpMap;
		};

		half4 LightingISS(SurfaceOutput s, half3 lightDir, half3 viewDir, half atten)
		{
			//diffuse
			half LdotN = max(-1, dot(lightDir, s.Normal)); //dot product - light direction & normal
			//fixed diff = LdotN * 0.5 + 0.5; //wrap the lighting to fake ambient
			fixed diff = pow((LdotN * 0.5 + 0.5), 2.0); //next level wrap so we can better control the lighting

			//specular
			fixed3 halfVector = normalize((lightDir + viewDir)); //calculate the half vector
			fixed NdotH = max(0, dot(s.Normal, halfVector));     //dot product - normal and half vector
			fixed spec = pow(NdotH, s.Specular * 128) * s.Gloss; //specular calculation

			half4 c;
			//c.rgb = s.Albedo * diff * _LightColor0.rgb;// diffuse;
			//c.rgb = s.Albedo * diff * _LightColor0.rgb +s.Albedo *_Color.rgb; //diffuse and ambient
			c.rgb = (s.Albedo * diff * _LightColor0.rgb + _SpecColor.rgb * spec) * (atten * 1.0); //specular
			c.a = s.Alpha;
			return c;
		}

		void surf (Input IN, inout SurfaceOutput o)
		{
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
			float3 bump = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap));
			o.Albedo = c.rgb;
			o.Alpha = c.a;
			o.Normal = bump.rgb;

			o.Specular = _Shininess;
			o.Gloss = _Glossiness;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
