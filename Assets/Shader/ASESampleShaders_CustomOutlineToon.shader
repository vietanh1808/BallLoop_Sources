Shader "ASESampleShaders/CustomOutlineToon" {
	Properties {
		[NoScaleOffset] _BaseColorRGBOutlineWidthA ("Base Color (RGB) Outline Width (A)", 2D) = "gray" {}
		_BaseTint ("Base Tint", Vector) = (1,1,1,0)
		_BaseCellSharpness ("Base Cell Sharpness", Range(0.01, 1)) = 0.01
		_BaseCellOffset ("Base Cell Offset", Range(-1, 1)) = 0
		_IndirectDiffuseContribution ("Indirect Diffuse Contribution", Range(0, 1)) = 1
		_ShadowContribution ("Shadow Contribution", Range(0, 1)) = 0.5
		[HDR] _HighlightTint ("Highlight Tint", Vector) = (1024,1024,1024,1)
		_HighlightCellOffset ("Highlight Cell Offset", Range(-1, -0.5)) = -0.6457434
		_HighlightCellSharpness ("Highlight Cell Sharpness", Range(0.001, 1)) = 0.01
		_IndirectSpecularContribution ("Indirect Specular Contribution", Range(0, 1)) = 1
		[HDR] _RimColor ("Rim Color", Vector) = (1,1,1,0)
		_RimPower ("Rim Power", Range(0.01, 1)) = 0.4
		_RimOffset ("Rim Offset", Range(0, 1)) = 0.6
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Diffuse"
	//CustomEditor "ASEMaterialInspector"
}