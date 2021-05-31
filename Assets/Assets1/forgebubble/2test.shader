// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:True,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:34263,y:32721,varname:node_2865,prsc:2|diff-7784-OUT,spec-7784-OUT,gloss-7708-OUT,emission-9967-OUT,amspl-9967-OUT;n:type:ShaderForge.SFN_Time,id:7447,x:31866,y:33036,varname:node_7447,prsc:2;n:type:ShaderForge.SFN_Slider,id:988,x:31866,y:33193,ptovrint:False,ptlb:flow LR,ptin:_flowLR,varname:node_988,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0.04709401,max:1;n:type:ShaderForge.SFN_Multiply,id:3664,x:32211,y:33046,varname:node_3664,prsc:2|A-7447-T,B-988-OUT;n:type:ShaderForge.SFN_TexCoord,id:545,x:32012,y:32630,varname:node_545,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:433,x:32385,y:33027,varname:node_433,prsc:2,spu:0,spv:1|UVIN-9044-UVOUT,DIST-3664-OUT;n:type:ShaderForge.SFN_Panner,id:2204,x:32553,y:33026,varname:node_2204,prsc:2,spu:1,spv:0|UVIN-433-UVOUT,DIST-8215-OUT;n:type:ShaderForge.SFN_Multiply,id:8215,x:32211,y:33167,varname:node_8215,prsc:2|A-7447-T,B-844-OUT;n:type:ShaderForge.SFN_Slider,id:844,x:31866,y:33282,ptovrint:False,ptlb:flow TB,ptin:_flowTB,varname:node_844,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0.02564311,max:1;n:type:ShaderForge.SFN_Multiply,id:2048,x:33645,y:32879,varname:node_2048,prsc:2|A-6517-RGB,B-6717-OUT,C-3939-OUT;n:type:ShaderForge.SFN_Slider,id:9287,x:33044,y:33167,ptovrint:False,ptlb:rim,ptin:_rim,varname:node_9287,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3846154,max:5;n:type:ShaderForge.SFN_Fresnel,id:3034,x:33368,y:33150,varname:node_3034,prsc:2|EXP-9287-OUT;n:type:ShaderForge.SFN_Slider,id:4403,x:33211,y:33298,ptovrint:False,ptlb:opacity,ptin:_opacity,varname:node_4403,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.8757972,max:5;n:type:ShaderForge.SFN_SceneColor,id:4442,x:33641,y:32727,varname:node_4442,prsc:2;n:type:ShaderForge.SFN_Lerp,id:9967,x:33890,y:32873,varname:node_9967,prsc:2|A-4442-RGB,B-2048-OUT,T-2048-OUT;n:type:ShaderForge.SFN_Slider,id:1795,x:31855,y:32793,ptovrint:False,ptlb:Texture Partition width,ptin:_TexturePartitionwidth,varname:node_1795,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.4769256,max:5;n:type:ShaderForge.SFN_ValueProperty,id:9102,x:32012,y:32972,ptovrint:False,ptlb:null,ptin:_null,varname:node_9102,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_UVTile,id:9044,x:32211,y:32921,varname:node_9044,prsc:2|UVIN-545-UVOUT,WDT-1795-OUT,HGT-5515-OUT,TILE-9102-OUT;n:type:ShaderForge.SFN_Vector1,id:7784,x:33890,y:32714,varname:node_7784,prsc:2,v1:0;n:type:ShaderForge.SFN_Slider,id:7708,x:33890,y:32801,ptovrint:False,ptlb:right,ptin:_right,varname:node_7708,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.7350428,max:1;n:type:ShaderForge.SFN_Tex2d,id:5266,x:32725,y:33027,ptovrint:False,ptlb:normal map,ptin:_normalmap,varname:node_5266,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-2204-UVOUT;n:type:ShaderForge.SFN_Multiply,id:3616,x:32900,y:33027,varname:node_3616,prsc:2|A-5266-RGB,B-9307-OUT;n:type:ShaderForge.SFN_Slider,id:9307,x:32591,y:33208,ptovrint:False,ptlb:flow map,ptin:_flowmap,varname:_node_7708_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.163666,max:1;n:type:ShaderForge.SFN_TexCoord,id:3640,x:32725,y:32858,varname:node_3640,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:6650,x:33064,y:32879,varname:node_6650,prsc:2|A-3640-UVOUT,B-3616-OUT;n:type:ShaderForge.SFN_Subtract,id:5757,x:33261,y:32879,varname:node_5757,prsc:2|A-6650-OUT,B-9682-OUT;n:type:ShaderForge.SFN_Tex2d,id:6517,x:33449,y:32879,ptovrint:False,ptlb:texture 1,ptin:_texture1,varname:_texture2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:cd95d5416b5b13b45bbff91049282458,ntxv:0,isnm:False|UVIN-5757-OUT;n:type:ShaderForge.SFN_Slider,id:9682,x:33044,y:33054,ptovrint:False,ptlb:flow texture,ptin:_flowtexture,varname:_node_7708_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.08547009,max:1;n:type:ShaderForge.SFN_Slider,id:5515,x:31855,y:32884,ptovrint:False,ptlb:Texture Partition height,ptin:_TexturePartitionheight,varname:_size_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.4769256,max:5;n:type:ShaderForge.SFN_TexCoord,id:1546,x:32496,y:32125,varname:node_1546,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:9373,x:32719,y:32300,varname:node_9373,prsc:2|IN-1546-V,IMIN-3974-OUT,IMAX-1181-OUT,OMIN-8535-OUT,OMAX-8149-OUT;n:type:ShaderForge.SFN_Vector1,id:8535,x:32496,y:32468,varname:node_8535,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:8149,x:32496,y:32527,varname:node_8149,prsc:2,v1:0.1;n:type:ShaderForge.SFN_Vector1,id:1796,x:32272,y:32281,varname:node_1796,prsc:2,v1:0;n:type:ShaderForge.SFN_Clamp01,id:9982,x:32887,y:32300,varname:node_9982,prsc:2|IN-9373-OUT;n:type:ShaderForge.SFN_Step,id:1181,x:32496,y:32300,varname:node_1181,prsc:2|A-1796-OUT,B-3974-OUT;n:type:ShaderForge.SFN_Time,id:7822,x:32887,y:32445,varname:node_7822,prsc:2;n:type:ShaderForge.SFN_Multiply,id:9870,x:33096,y:32517,varname:node_9870,prsc:2|A-7822-T,B-5842-OUT;n:type:ShaderForge.SFN_Vector1,id:534,x:32887,y:32783,varname:node_534,prsc:2,v1:0;n:type:ShaderForge.SFN_TexCoord,id:9780,x:32887,y:32636,varname:node_9780,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Vector1,id:3974,x:32272,y:32333,varname:node_3974,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:360,x:33096,y:32636,varname:node_360,prsc:2|A-9780-V,B-534-OUT;n:type:ShaderForge.SFN_Add,id:2656,x:33293,y:32636,varname:node_2656,prsc:2|A-9870-OUT,B-360-OUT,C-9982-OUT;n:type:ShaderForge.SFN_Vector1,id:5842,x:32887,y:32575,varname:node_5842,prsc:2,v1:-0.097;n:type:ShaderForge.SFN_Cos,id:3939,x:33457,y:32636,varname:node_3939,prsc:2|IN-2656-OUT;n:type:ShaderForge.SFN_If,id:5699,x:29516,y:30077,varname:node_5699,prsc:2|A-7609-OUT,B-3773-OUT,GT-7609-OUT,EQ-9887-OUT,LT-9887-OUT;n:type:ShaderForge.SFN_Time,id:1427,x:28377,y:29876,varname:node_1427,prsc:2;n:type:ShaderForge.SFN_Multiply,id:3507,x:28586,y:29948,varname:node_3507,prsc:2|A-1427-T,B-4109-OUT;n:type:ShaderForge.SFN_Vector1,id:6927,x:28377,y:30214,varname:node_6927,prsc:2,v1:-2;n:type:ShaderForge.SFN_TexCoord,id:4014,x:28377,y:30067,varname:node_4014,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:5653,x:28586,y:30067,varname:node_5653,prsc:2|A-4014-V,B-6927-OUT;n:type:ShaderForge.SFN_Add,id:2028,x:28783,y:30067,varname:node_2028,prsc:2|A-3507-OUT,B-5653-OUT;n:type:ShaderForge.SFN_Vector1,id:4109,x:28377,y:29997,varname:node_4109,prsc:2,v1:-0.1;n:type:ShaderForge.SFN_Cos,id:7609,x:29003,y:30067,varname:node_7609,prsc:2|IN-2028-OUT;n:type:ShaderForge.SFN_Vector1,id:3773,x:29003,y:30194,varname:node_3773,prsc:2,v1:0.8;n:type:ShaderForge.SFN_Time,id:6806,x:28371,y:30288,varname:node_6806,prsc:2;n:type:ShaderForge.SFN_Multiply,id:8226,x:28580,y:30360,varname:node_8226,prsc:2|A-6806-T,B-9696-OUT;n:type:ShaderForge.SFN_Vector1,id:2105,x:28371,y:30626,varname:node_2105,prsc:2,v1:-2;n:type:ShaderForge.SFN_TexCoord,id:3740,x:28371,y:30479,varname:node_3740,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:9462,x:28580,y:30479,varname:node_9462,prsc:2|A-3740-V,B-2105-OUT;n:type:ShaderForge.SFN_Add,id:6466,x:28777,y:30479,varname:node_6466,prsc:2|A-8226-OUT,B-9462-OUT;n:type:ShaderForge.SFN_Vector1,id:9696,x:28371,y:30409,varname:node_9696,prsc:2,v1:-0.3;n:type:ShaderForge.SFN_Cos,id:4012,x:28997,y:30479,varname:node_4012,prsc:2|IN-6466-OUT;n:type:ShaderForge.SFN_Vector1,id:8569,x:28997,y:30607,varname:node_8569,prsc:2,v1:0.6;n:type:ShaderForge.SFN_If,id:9887,x:29520,y:30490,varname:node_9887,prsc:2|A-4012-OUT,B-8569-OUT,GT-4012-OUT,EQ-8154-OUT,LT-8154-OUT;n:type:ShaderForge.SFN_Time,id:3644,x:28379,y:30708,varname:node_3644,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1575,x:28588,y:30780,varname:node_1575,prsc:2|A-3644-T,B-5788-OUT;n:type:ShaderForge.SFN_Vector1,id:3207,x:28379,y:31046,varname:node_3207,prsc:2,v1:-2;n:type:ShaderForge.SFN_TexCoord,id:1822,x:28379,y:30899,varname:node_1822,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:4472,x:28588,y:30899,varname:node_4472,prsc:2|A-1822-V,B-3207-OUT;n:type:ShaderForge.SFN_Add,id:1260,x:28785,y:30899,varname:node_1260,prsc:2|A-1575-OUT,B-4472-OUT;n:type:ShaderForge.SFN_Vector1,id:5788,x:28379,y:30829,varname:node_5788,prsc:2,v1:-0.5;n:type:ShaderForge.SFN_Cos,id:5321,x:29005,y:30899,varname:node_5321,prsc:2|IN-1260-OUT;n:type:ShaderForge.SFN_Vector1,id:2904,x:29005,y:31027,varname:node_2904,prsc:2,v1:0.4;n:type:ShaderForge.SFN_If,id:8154,x:29520,y:30909,varname:node_8154,prsc:2|A-5321-OUT,B-2904-OUT,GT-5321-OUT,EQ-8109-OUT,LT-8109-OUT;n:type:ShaderForge.SFN_Time,id:6459,x:28381,y:31113,varname:node_6459,prsc:2;n:type:ShaderForge.SFN_Multiply,id:8648,x:28590,y:31185,varname:node_8648,prsc:2|A-6459-T,B-5053-OUT;n:type:ShaderForge.SFN_Vector1,id:2400,x:28381,y:31451,varname:node_2400,prsc:2,v1:-2;n:type:ShaderForge.SFN_TexCoord,id:2003,x:28381,y:31304,varname:node_2003,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:2271,x:28590,y:31304,varname:node_2271,prsc:2|A-2003-V,B-2400-OUT;n:type:ShaderForge.SFN_Add,id:7733,x:28787,y:31304,varname:node_7733,prsc:2|A-8648-OUT,B-2271-OUT;n:type:ShaderForge.SFN_Vector1,id:5053,x:28381,y:31234,varname:node_5053,prsc:2,v1:-0.7;n:type:ShaderForge.SFN_Cos,id:275,x:29007,y:31304,varname:node_275,prsc:2|IN-7733-OUT;n:type:ShaderForge.SFN_Vector1,id:1606,x:29007,y:31432,varname:node_1606,prsc:2,v1:0.2;n:type:ShaderForge.SFN_If,id:8109,x:29516,y:31314,varname:node_8109,prsc:2|A-275-OUT,B-1606-OUT,GT-275-OUT,EQ-5141-OUT,LT-5141-OUT;n:type:ShaderForge.SFN_Time,id:8268,x:28381,y:31527,varname:node_8268,prsc:2;n:type:ShaderForge.SFN_Multiply,id:6400,x:28590,y:31599,varname:node_6400,prsc:2|A-8268-T,B-9402-OUT;n:type:ShaderForge.SFN_Vector1,id:7899,x:28381,y:31865,varname:node_7899,prsc:2,v1:-2;n:type:ShaderForge.SFN_TexCoord,id:39,x:28381,y:31718,varname:node_39,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:3022,x:28590,y:31718,varname:node_3022,prsc:2|A-39-V,B-7899-OUT;n:type:ShaderForge.SFN_Add,id:5749,x:28787,y:31718,varname:node_5749,prsc:2|A-6400-OUT,B-3022-OUT;n:type:ShaderForge.SFN_Vector1,id:9402,x:28381,y:31648,varname:node_9402,prsc:2,v1:0;n:type:ShaderForge.SFN_Cos,id:45,x:29007,y:31718,varname:node_45,prsc:2|IN-5749-OUT;n:type:ShaderForge.SFN_Vector1,id:6686,x:29007,y:31846,varname:node_6686,prsc:2,v1:0;n:type:ShaderForge.SFN_If,id:5141,x:29512,y:31729,varname:node_5141,prsc:2|A-45-OUT,B-6686-OUT,GT-45-OUT,EQ-45-OUT,LT-45-OUT;n:type:ShaderForge.SFN_Time,id:6750,x:27219,y:31389,varname:node_6750,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2967,x:27428,y:31461,varname:node_2967,prsc:2|A-6750-T,B-884-OUT;n:type:ShaderForge.SFN_Vector1,id:884,x:27219,y:31510,varname:node_884,prsc:2,v1:0.2;n:type:ShaderForge.SFN_Vector1,id:5947,x:27478,y:31724,varname:node_5947,prsc:2,v1:1;n:type:ShaderForge.SFN_Fmod,id:9540,x:27667,y:31711,varname:node_9540,prsc:2|A-2967-OUT,B-5947-OUT;n:type:ShaderForge.SFN_Multiply,id:6698,x:28032,y:31829,varname:node_6698,prsc:2|A-9540-OUT,B-9606-OUT;n:type:ShaderForge.SFN_Time,id:1469,x:26856,y:31581,varname:node_1469,prsc:2;n:type:ShaderForge.SFN_Multiply,id:9336,x:27065,y:31653,varname:node_9336,prsc:2|A-1469-T,B-8926-OUT,C-9381-OUT;n:type:ShaderForge.SFN_TexCoord,id:5606,x:26856,y:31772,varname:node_5606,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:6202,x:27065,y:31772,varname:node_6202,prsc:2|A-5606-V,B-9317-OUT;n:type:ShaderForge.SFN_Add,id:4774,x:27262,y:31772,varname:node_4774,prsc:2|A-9336-OUT,B-6202-OUT;n:type:ShaderForge.SFN_Vector1,id:8926,x:26856,y:31702,varname:node_8926,prsc:2,v1:-0.1;n:type:ShaderForge.SFN_Vector1,id:9317,x:26856,y:31919,varname:node_9317,prsc:2,v1:-2;n:type:ShaderForge.SFN_Cos,id:9606,x:27442,y:31783,varname:node_9606,prsc:2|IN-4774-OUT;n:type:ShaderForge.SFN_Slider,id:9381,x:26567,y:31721,ptovrint:False,ptlb:oj4,ptin:_oj4,varname:_oj4,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:0.5;n:type:ShaderForge.SFN_Tex2d,id:1821,x:28298,y:32512,ptovrint:False,ptlb:normal map_copy,ptin:_normalmap_copy,varname:_normalmap_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:a013b03525f0dd74a986ada955bcbd95,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:9921,x:28298,y:32331,ptovrint:False,ptlb:normal map_copy_copy,ptin:_normalmap_copy_copy,varname:_normalmap_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9bc17ddcb0b7862499320cbe600ec9a2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:1430,x:28298,y:32150,ptovrint:False,ptlb:normal map_copy_copy_copy,ptin:_normalmap_copy_copy_copy,varname:_normalmap_copy_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:931188b3394d3054bb2cb70edc820f01,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:4735,x:28298,y:32683,varname:node_4735,prsc:2|A-1821-RGB,B-9921-RGB;n:type:ShaderForge.SFN_Multiply,id:6899,x:28298,y:32816,varname:node_6899,prsc:2|A-1821-RGB,B-1430-RGB;n:type:ShaderForge.SFN_Multiply,id:3274,x:28298,y:32954,varname:node_3274,prsc:2|A-1430-RGB,B-9921-RGB;n:type:ShaderForge.SFN_If,id:5234,x:28202,y:30904,varname:node_5234,prsc:2|A-7289-T,B-2840-OUT,GT-4897-OUT,EQ-4790-OUT,LT-4790-OUT;n:type:ShaderForge.SFN_Vector1,id:2840,x:27777,y:30807,varname:node_2840,prsc:2,v1:202;n:type:ShaderForge.SFN_Time,id:7289,x:27777,y:30683,varname:node_7289,prsc:2;n:type:ShaderForge.SFN_Time,id:9816,x:27212,y:30968,varname:node_9816,prsc:2;n:type:ShaderForge.SFN_Multiply,id:9279,x:27421,y:31040,varname:node_9279,prsc:2|A-9816-T,B-9968-OUT;n:type:ShaderForge.SFN_Vector1,id:4844,x:27212,y:31306,varname:node_4844,prsc:2,v1:-1;n:type:ShaderForge.SFN_TexCoord,id:2017,x:27212,y:31159,varname:node_2017,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:3623,x:27421,y:31159,varname:node_3623,prsc:2|A-2017-V,B-4844-OUT;n:type:ShaderForge.SFN_Add,id:4562,x:27618,y:31159,varname:node_4562,prsc:2|A-9279-OUT,B-3623-OUT;n:type:ShaderForge.SFN_Vector1,id:9968,x:27212,y:31098,varname:node_9968,prsc:2,v1:2;n:type:ShaderForge.SFN_Cos,id:4790,x:27804,y:31159,varname:node_4790,prsc:2|IN-4562-OUT;n:type:ShaderForge.SFN_Time,id:1891,x:26937,y:30616,varname:node_1891,prsc:2;n:type:ShaderForge.SFN_Multiply,id:627,x:27146,y:30688,varname:node_627,prsc:2|A-1891-T,B-4505-OUT;n:type:ShaderForge.SFN_Vector1,id:5487,x:26937,y:30954,varname:node_5487,prsc:2,v1:-1;n:type:ShaderForge.SFN_TexCoord,id:5758,x:26937,y:30807,varname:node_5758,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:4007,x:27146,y:30807,varname:node_4007,prsc:2|A-5758-V,B-5487-OUT;n:type:ShaderForge.SFN_Add,id:1021,x:27343,y:30807,varname:node_1021,prsc:2|A-627-OUT,B-4007-OUT;n:type:ShaderForge.SFN_Vector1,id:4505,x:26937,y:30746,varname:node_4505,prsc:2,v1:-2;n:type:ShaderForge.SFN_Cos,id:4897,x:27529,y:30807,varname:node_4897,prsc:2|IN-1021-OUT;n:type:ShaderForge.SFN_Vector1,id:3729,x:30072,y:30545,varname:node_3729,prsc:2,v1:1;n:type:ShaderForge.SFN_Fmod,id:2588,x:30264,y:30532,varname:node_2588,prsc:2|A-4116-OUT,B-3729-OUT;n:type:ShaderForge.SFN_Cos,id:8062,x:30432,y:30532,varname:node_8062,prsc:2|IN-2588-OUT;n:type:ShaderForge.SFN_Desaturate,id:4741,x:30785,y:30196,varname:node_4741,prsc:2|DES-3830-OUT;n:type:ShaderForge.SFN_Vector1,id:3830,x:30615,y:30257,varname:node_3830,prsc:2,v1:-2;n:type:ShaderForge.SFN_Multiply,id:481,x:30807,y:30431,varname:node_481,prsc:2|A-4741-OUT,B-8062-OUT;n:type:ShaderForge.SFN_Multiply,id:6717,x:33549,y:33150,varname:node_6717,prsc:2|A-3034-OUT,B-4403-OUT;n:type:ShaderForge.SFN_Time,id:9410,x:29862,y:29932,varname:node_9410,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7373,x:30071,y:30004,varname:node_7373,prsc:2|A-9410-T,B-2565-OUT;n:type:ShaderForge.SFN_Vector1,id:5320,x:29862,y:30270,varname:node_5320,prsc:2,v1:0;n:type:ShaderForge.SFN_TexCoord,id:9119,x:29862,y:30123,varname:node_9119,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:2773,x:30071,y:30123,varname:node_2773,prsc:2|A-9119-V,B-5320-OUT;n:type:ShaderForge.SFN_Add,id:4116,x:30268,y:30123,varname:node_4116,prsc:2|A-7373-OUT,B-2773-OUT;n:type:ShaderForge.SFN_Vector1,id:2565,x:29862,y:30062,varname:node_2565,prsc:2,v1:0.1;proporder:988-844-9287-4403-1795-9102-7708-5266-9307-6517-9682-5515-1430-9921-1821;pass:END;sub:END;*/

Shader "Shader Forge/2test" {
    Properties {
        _flowLR ("flow LR", Range(-1, 1)) = 0.04709401
        _flowTB ("flow TB", Range(-1, 1)) = 0.02564311
        _rim ("rim", Range(0, 5)) = 0.3846154
        _opacity ("opacity", Range(0, 5)) = 0.8757972
        _TexturePartitionwidth ("Texture Partition width", Range(0.1, 5)) = 0.4769256
        _null ("null", Float ) = 0
        _right ("right", Range(0, 1)) = 0.7350428
        _normalmap ("normal map", 2D) = "white" {}
        _flowmap ("flow map", Range(0, 1)) = 0.163666
        _texture1 ("texture 1", 2D) = "white" {}
        _flowtexture ("flow texture", Range(0, 1)) = 0.08547009
        _TexturePartitionheight ("Texture Partition height", Range(0.1, 5)) = 0.4769256
        _normalmap_copy_copy_copy ("normal map_copy_copy_copy", 2D) = "white" {}
        _normalmap_copy_copy ("normal map_copy_copy", 2D) = "white" {}
        _normalmap_copy ("normal map_copy", 2D) = "white" {}
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
                float4 node_7447 = _Time;
                float2 node_9044_tc_rcp = float2(1.0,1.0)/float2( _TexturePartitionwidth, _TexturePartitionheight );
                float node_9044_ty = floor(_null * node_9044_tc_rcp.x);
                float node_9044_tx = _null - _TexturePartitionwidth * node_9044_ty;
                float2 node_9044 = (i.uv0 + float2(node_9044_tx, node_9044_ty)) * node_9044_tc_rcp;
                float2 node_2204 = ((node_9044+(node_7447.g*_flowLR)*float2(0,1))+(node_7447.g*_flowTB)*float2(1,0));
                float4 _normalmap_var = tex2D(_normalmap,TRANSFORM_TEX(node_2204, _normalmap));
                float3 node_5757 = ((float3(i.uv0,0.0)+(_normalmap_var.rgb*_flowmap))-_flowtexture);
                float4 _texture1_var = tex2D(_texture1,TRANSFORM_TEX(node_5757, _texture1));
                float4 node_7822 = _Time;
                float node_3974 = 0.0;
                float node_8535 = 1.0;
                float3 node_2048 = (_texture1_var.rgb*(pow(1.0-max(0,dot(normalDirection, viewDirection)),_rim)*_opacity)*cos(((node_7822.g*(-0.097))+(i.uv0.g*0.0)+saturate((node_8535 + ( (i.uv0.g - node_3974) * (0.1 - node_8535) ) / (step(0.0,node_3974) - node_3974))))));
                float3 node_9967 = lerp(sceneColor.rgb,node_2048,node_2048);
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
                float3 indirectSpecular = (gi.indirect.specular + node_9967);
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
                float3 emissive = node_9967;
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
                float3 node_5757 = ((float3(i.uv0,0.0)+(_normalmap_var.rgb*_flowmap))-_flowtexture);
                float4 _texture1_var = tex2D(_texture1,TRANSFORM_TEX(node_5757, _texture1));
                float4 node_7822 = _Time;
                float node_3974 = 0.0;
                float node_8535 = 1.0;
                float3 node_2048 = (_texture1_var.rgb*(pow(1.0-max(0,dot(normalDirection, viewDirection)),_rim)*_opacity)*cos(((node_7822.g*(-0.097))+(i.uv0.g*0.0)+saturate((node_8535 + ( (i.uv0.g - node_3974) * (0.1 - node_8535) ) / (step(0.0,node_3974) - node_3974))))));
                float3 node_9967 = lerp(sceneColor.rgb,node_2048,node_2048);
                o.Emission = node_9967;
                
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
