Shader "Hidden/RenderExp"
{
	Properties
	{
		_MainTex("Texture", 2D) = "white" {}
		_DisplaceTex("Texture", 2D) = "white" {}
		_Magnitude("Magnitude", Range(0, 0.1)) = 0
	}
		SubShader
		{
			Cull off ZWrite Off ZTest Always

			Pass
			{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"

			struct appdata						// defines what information we're getting from each vertex on the mesh
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f							// defines what information we're passing into the fragment function
			{
				float4 vertex : SV_POSITION;
				float2 uv : TEXCOORD0;			// TEXCOORD0 is a value you can get from mesh
			};

			v2f vert(appdata v)					// takes appdata struct as a parameter and returns a v2f
			{
				v2f o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);	// matric multiplication: takes it from a point relative to object and transforms to point on screen
				o.uv = v.uv;					// pass on uv as is to frag function
				return o;
			}

			sampler2D _MainTex;
			sampler2D _DisplaceTex;
			float _Magnitude;

			float4 frag(v2f i) : SV_Target		// takes v2f and returns a colour in the form of a float4 variable
			{
				float2 distuv = float2(i.uv.x + _Time.x * 2, i.uv.y + _Time.x * 2);

				float2 disp = tex2D(_DisplaceTex, distuv).xy;
				disp = ((disp * 2) - 1) * (_Magnitude);

				float4 col = tex2D(_MainTex, i.uv + disp);
				//col *= float4(i.uv.x + 0.5, i.uv.y + 0.5, 0, 1);

				//col -= 0.5;

				return col;
			}
			ENDCG
		}
		}
}