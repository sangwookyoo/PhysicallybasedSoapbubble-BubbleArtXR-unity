// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:True,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:34263,y:32721,varname:node_2865,prsc:2|diff-7784-OUT,spec-7784-OUT,gloss-7708-OUT,emission-9967-OUT;n:type:ShaderForge.SFN_Time,id:7447,x:31866,y:33036,varname:node_7447,prsc:2;n:type:ShaderForge.SFN_Slider,id:988,x:31866,y:33193,ptovrint:False,ptlb:flow LR,ptin:_flowLR,varname:node_988,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0.1,max:1;n:type:ShaderForge.SFN_Multiply,id:3664,x:32211,y:33046,varname:node_3664,prsc:2|A-7447-T,B-988-OUT;n:type:ShaderForge.SFN_TexCoord,id:545,x:32012,y:32630,varname:node_545,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:433,x:32385,y:33027,varname:node_433,prsc:2,spu:0,spv:1|UVIN-9044-UVOUT,DIST-3664-OUT;n:type:ShaderForge.SFN_Panner,id:2204,x:32553,y:33026,varname:node_2204,prsc:2,spu:1,spv:0|UVIN-433-UVOUT,DIST-8215-OUT;n:type:ShaderForge.SFN_Multiply,id:8215,x:32211,y:33167,varname:node_8215,prsc:2|A-7447-T,B-844-OUT;n:type:ShaderForge.SFN_Slider,id:844,x:31866,y:33282,ptovrint:False,ptlb:flow TB,ptin:_flowTB,varname:node_844,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0.1,max:1;n:type:ShaderForge.SFN_Multiply,id:2048,x:33645,y:32879,varname:node_2048,prsc:2|A-6517-RGB,B-3034-OUT,C-4403-OUT;n:type:ShaderForge.SFN_Slider,id:9287,x:33045,y:33152,ptovrint:False,ptlb:rim,ptin:_rim,varname:node_9287,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3846154,max:5;n:type:ShaderForge.SFN_Fresnel,id:3034,x:33369,y:33135,varname:node_3034,prsc:2|EXP-9287-OUT;n:type:ShaderForge.SFN_Slider,id:4403,x:33212,y:33285,ptovrint:False,ptlb:opacity,ptin:_opacity,varname:node_4403,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.324786,max:5;n:type:ShaderForge.SFN_SceneColor,id:4442,x:33641,y:32727,varname:node_4442,prsc:2;n:type:ShaderForge.SFN_Lerp,id:9967,x:33890,y:32873,varname:node_9967,prsc:2|A-4442-RGB,B-2048-OUT,T-2048-OUT;n:type:ShaderForge.SFN_Slider,id:1795,x:31855,y:32793,ptovrint:False,ptlb:Texture Partition width,ptin:_TexturePartitionwidth,varname:node_1795,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.5735504,max:5;n:type:ShaderForge.SFN_ValueProperty,id:9102,x:32012,y:32972,ptovrint:False,ptlb:null,ptin:_null,varname:node_9102,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_UVTile,id:9044,x:32206,y:32912,varname:node_9044,prsc:2|UVIN-545-UVOUT,WDT-1795-OUT,HGT-5515-OUT,TILE-9102-OUT;n:type:ShaderForge.SFN_Vector1,id:7784,x:33890,y:32714,varname:node_7784,prsc:2,v1:0;n:type:ShaderForge.SFN_Slider,id:7708,x:33890,y:32801,ptovrint:False,ptlb:right,ptin:_right,varname:node_7708,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.7350428,max:1;n:type:ShaderForge.SFN_Tex2d,id:5266,x:32725,y:33027,ptovrint:False,ptlb:normal map,ptin:_normalmap,varname:node_5266,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-2204-UVOUT;n:type:ShaderForge.SFN_Multiply,id:3616,x:32897,y:33027,varname:node_3616,prsc:2|A-5266-R,B-9307-OUT;n:type:ShaderForge.SFN_Slider,id:9307,x:32591,y:33208,ptovrint:False,ptlb:flow map,ptin:_flowmap,varname:_node_7708_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.163666,max:1;n:type:ShaderForge.SFN_TexCoord,id:3640,x:32894,y:32878,varname:node_3640,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:6650,x:33064,y:32879,varname:node_6650,prsc:2|A-3640-UVOUT,B-3616-OUT;n:type:ShaderForge.SFN_Subtract,id:5757,x:33261,y:32879,varname:node_5757,prsc:2|A-6650-OUT,B-9682-OUT;n:type:ShaderForge.SFN_Tex2d,id:6517,x:33449,y:32879,ptovrint:False,ptlb:texture 1,ptin:_texture1,varname:_texture2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:c1c48de38fb7cc84d91ddcd187e1349b,ntxv:0,isnm:False|UVIN-5757-OUT;n:type:ShaderForge.SFN_Slider,id:9682,x:33044,y:33054,ptovrint:False,ptlb:flow texture,ptin:_flowtexture,varname:_node_7708_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.08547009,max:1;n:type:ShaderForge.SFN_Slider,id:5515,x:31855,y:32884,ptovrint:False,ptlb:Texture Partition height,ptin:_TexturePartitionheight,varname:_size_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.5735504,max:5;proporder:988-844-9287-4403-1795-9102-7708-5266-9307-6517-9682-5515;pass:END;sub:END;*/

Shader "Shader Forge/2test" {
    Properties {
        _flowLR ("flow LR", Range(-1, 1)) = 0.1
        _flowTB ("flow TB", Range(-1, 1)) = 0.1
        _rim ("rim", Range(0, 5)) = 0.3846154
        _opacity ("opacity", Range(0, 5)) = 1.324786
        _TexturePartitionwidth ("Texture Partition width", Range(0.1, 5)) = 0.5735504
        _null ("null", Float ) = 0
        _right ("right", Range(0, 1)) = 0.7350428
        _normalmap ("normal map", 2D) = "white" {}
        _flowmap ("flow map", Range(0, 1)) = 0.163666
        _texture1 ("texture 1", 2D) = "white" {}
        _flowtexture ("flow texture", Range(0, 1)) = 0.08547009
        _TexturePartitionheight ("Texture Partition height", Range(0.1, 5)) = 0.5735504
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 2.0
            uniform sampler2D _GrabTexture;
            uniform float _flowLR;
            uniform float _flowTB;
            uniform float _rim;
            uniform float _opacity;
            uniform float _TexturePartitionwidth;
            uniform float _null;
            uniform float _right;
            uniform sampler2D _normalmap; uniform float4 _normalmap_ST;
            uniform float _flowmap;
            uniform sampler2D _texture1; uniform float4 _texture1_ST;
            uniform float _flowtexture;
            uniform float _TexturePartitionheight;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 projPos : TEXCOORD7;
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD8;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _right;
                float perceptualRoughness = 1.0 - _right;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                #endif
                #if UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                #endif
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float node_7784 = 0.0;
                float3 specularColor = node_7784;
                float specularMonochrome;
                float3 diffuseColor = float3(node_7784,node_7784,node_7784); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                half surfaceReduction;
                #ifdef UNITY_COLORSPACE_GAMMA
                    surfaceReduction = 1.0-0.28*roughness*perceptualRoughness;
                #else
                    surfaceReduction = 1.0/(roughness*roughness + 1.0);
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (gi.indirect.specular);
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                indirectSpecular *= surfaceReduction;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 node_7447 = _Time;
                float2 node_9044_tc_rcp = float2(1.0,1.0)/float2( _TexturePartitionwidth, _TexturePartitionheight );
                float node_9044_ty = floor(_null * node_9044_tc_rcp.x);
                float node_9044_tx = _null - _TexturePartitionwidth * node_9044_ty;
                float2 node_9044 = (i.uv0 + float2(node_9044_tx, node_9044_ty)) * node_9044_tc_rcp;
                float2 node_2204 = ((node_9044+(node_7447.g*_flowLR)*float2(0,1))+(node_7447.g*_flowTB)*float2(1,0));
                float4 _normalmap_var = tex2D(_normalmap,TRANSFORM_TEX(node_2204, _normalmap));
                float2 node_5757 = ((i.uv0+(_normalmap_var.r*_flowmap))-_flowtexture);
                float4 _texture1_var = tex2D(_texture1,TRANSFORM_TEX(node_5757, _texture1));
                float3 node_2048 = (_texture1_var.rgb*pow(1.0-max(0,dot(normalDirection, viewDirection)),_rim)*_opacity);
                float3 emissive = lerp(sceneColor.rgb,node_2048,node_2048);
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 2.0
            uniform sampler2D _GrabTexture;
            uniform float _flowLR;
            uniform float _flowTB;
            uniform float _rim;
            uniform float _opacity;
            uniform float _TexturePartitionwidth;
            uniform float _null;
            uniform float _right;
            uniform sampler2D _normalmap; uniform float4 _normalmap_ST;
            uniform float _flowmap;
            uniform sampler2D _texture1; uniform float4 _texture1_ST;
            uniform float _flowtexture;
            uniform float _TexturePartitionheight;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 projPos : TEXCOORD7;
                LIGHTING_COORDS(8,9)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _right;
                float perceptualRoughness = 1.0 - _right;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float node_7784 = 0.0;
                float3 specularColor = node_7784;
                float specularMonochrome;
                float3 diffuseColor = float3(node_7784,node_7784,node_7784); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 2.0
            uniform sampler2D _GrabTexture;
            uniform float _flowLR;
            uniform float _flowTB;
            uniform float _rim;
            uniform float _opacity;
            uniform float _TexturePartitionwidth;
            uniform float _null;
            uniform float _right;
            uniform sampler2D _normalmap; uniform float4 _normalmap_ST;
            uniform float _flowmap;
            uniform sampler2D _texture1; uniform float4 _texture1_ST;
            uniform float _flowtexture;
            uniform float _TexturePartitionheight;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float4 node_7447 = _Time;
                float2 node_9044_tc_rcp = float2(1.0,1.0)/float2( _TexturePartitionwidth, _TexturePartitionheight );
                float node_9044_ty = floor(_null * node_9044_tc_rcp.x);
                float node_9044_tx = _null - _TexturePartitionwidth * node_9044_ty;
                float2 node_9044 = (i.uv0 + float2(node_9044_tx, node_9044_ty)) * node_9044_tc_rcp;
                float2 node_2204 = ((node_9044+(node_7447.g*_flowLR)*float2(0,1))+(node_7447.g*_flowTB)*float2(1,0));
                float4 _normalmap_var = tex2D(_normalmap,TRANSFORM_TEX(node_2204, _normalmap));
                float2 node_5757 = ((i.uv0+(_normalmap_var.r*_flowmap))-_flowtexture);
                float4 _texture1_var = tex2D(_texture1,TRANSFORM_TEX(node_5757, _texture1));
                float3 node_2048 = (_texture1_var.rgb*pow(1.0-max(0,dot(normalDirection, viewDirection)),_rim)*_opacity);
                o.Emission = lerp(sceneColor.rgb,node_2048,node_2048);
                
                float node_7784 = 0.0;
                float3 diffColor = float3(node_7784,node_7784,node_7784);
                float specularMonochrome;
                float3 specColor;
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, node_7784, specColor, specularMonochrome );
                float roughness = 1.0 - _right;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
