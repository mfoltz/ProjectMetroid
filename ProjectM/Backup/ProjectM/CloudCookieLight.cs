// Decompiled with JetBrains decompiler
// Type: ProjectM.CloudCookieLight
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class CloudCookieLight : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MAX_CLOUDS;
    private static readonly IntPtr NativeFieldInfoPtr_TIME_OF_BREAK;
    private static readonly IntPtr NativeFieldInfoPtr_CLOUD_QUAD_SIZE;
    private static readonly IntPtr NativeFieldInfoPtr_CookieResolution;
    private static readonly IntPtr NativeFieldInfoPtr_CookieSize;
    private static readonly IntPtr NativeFieldInfoPtr_Shader;
    private static readonly IntPtr NativeFieldInfoPtr_DrawGizmos;
    private static readonly IntPtr NativeFieldInfoPtr_DrawGameplayPointGizmos;
    private static readonly IntPtr NativeFieldInfoPtr__RenderTexture;
    private static readonly IntPtr NativeFieldInfoPtr__CloudsComputeBuffer;
    private static readonly IntPtr NativeFieldInfoPtr__Camera;
    private static readonly IntPtr NativeFieldInfoPtr__CloudManager;
    private static readonly IntPtr NativeFieldInfoPtr__Clouds;
    private static readonly IntPtr NativeFieldInfoPtr_WrapPoint;
    private static readonly IntPtr NativeFieldInfoPtr_DotsSystemControlUpdate;
    private static readonly IntPtr NativeFieldInfoPtr_UseOldClouds;
    private static readonly IntPtr NativeFieldInfoPtr_forward;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasAllResources_Private_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetDataAndDispatch_Public_Void_NativeList_1_CloudInProjectionSpace_Int32_Int32_Boolean_Vector3_Double_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetOldWindVector_Public_double2_Double_0;
    private static readonly IntPtr NativeMethodInfoPtr_InitWind_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetWindVector_Public_float2_Double_0;
    private static readonly IntPtr NativeMethodInfoPtr_CalculateWrapPoint_Private_Double_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_CalculateUVFrac_Private_Double_Double_Double_0;
    private static readonly IntPtr NativeMethodInfoPtr_Dispatch_Private_Void_Int32_Int32_Boolean_Double_Single_float2_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_CalculateCloud_Private_Static_CloudInProjectionSpace_CloudCookieAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsCloudInFrustrum_Private_Static_Boolean_byref_CloudInProjectionSpace_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987218, XrefRangeEnd = 987267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 987293, RefRangeEnd = 987294, XrefRangeStart = 987267, XrefRangeEnd = 987293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasAllResources()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr_HasAllResources_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987294, XrefRangeEnd = 987357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LateUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 987372, RefRangeEnd = 987373, XrefRangeStart = 987357, XrefRangeEnd = 987372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetDataAndDispatch(
      NativeList<CloudInProjectionSpace> clouds,
      int cloudShadowCount,
      int cloudLightCount,
      bool dynamicCloudsEnabled,
      Vector3 lightForward,
      double time,
      float cloudiness)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[7];
      numPtr[0] = (IntPtr) &clouds;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &cloudShadowCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &cloudLightCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &dynamicCloudsEnabled;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &lightForward;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &time;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &cloudiness;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr_SetDataAndDispatch_Public_Void_NativeList_1_CloudInProjectionSpace_Int32_Int32_Boolean_Vector3_Double_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe double2 GetOldWindVector(double time)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &time;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr_GetOldWindVector_Public_double2_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987373, XrefRangeEnd = 987375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitWind()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr_InitWind_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 987379, RefRangeEnd = 987380, XrefRangeStart = 987375, XrefRangeEnd = 987379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float2 GetWindVector(double time)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &time;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr_GetWindVector_Public_float2_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 987384, RefRangeEnd = 987388, XrefRangeStart = 987380, XrefRangeEnd = 987384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe double CalculateWrapPoint(float speed, float timeOfBreak)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &speed;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &timeOfBreak;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr_CalculateWrapPoint_Private_Double_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987388, XrefRangeEnd = 987389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe double CalculateUVFrac(double time, double wrapPoint)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &time;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &wrapPoint;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr_CalculateUVFrac_Private_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 987460, RefRangeEnd = 987462, XrefRangeStart = 987389, XrefRangeEnd = 987460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Dispatch(
      int cloudShadowCount,
      int cloudLightCount,
      bool dynamicCloudsEnabled,
      double time,
      float cloudiness,
      float2 cloudCookieOffset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[6];
      numPtr[0] = (IntPtr) &cloudShadowCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &cloudLightCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &dynamicCloudsEnabled;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &time;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &cloudiness;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &cloudCookieOffset;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr_Dispatch_Private_Void_Int32_Int32_Boolean_Double_Single_float2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987462, XrefRangeEnd = 987463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 987485, RefRangeEnd = 987486, XrefRangeStart = 987463, XrefRangeEnd = 987485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 987498, RefRangeEnd = 987500, XrefRangeStart = 987486, XrefRangeEnd = 987498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CloudInProjectionSpace CalculateCloud(CloudCookieAuthoring cloud)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cloud);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr_CalculateCloud_Private_Static_CloudInProjectionSpace_CloudCookieAuthoring_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CloudInProjectionSpace*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 987506, RefRangeEnd = 987508, XrefRangeStart = 987500, XrefRangeEnd = 987506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsCloudInFrustrum([In] ref CloudInProjectionSpace cloud)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref cloud;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr_IsCloudInFrustrum_Private_Static_Boolean_byref_CloudInProjectionSpace_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987508, XrefRangeEnd = 987509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CloudCookieLight()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloudCookieLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CloudCookieLight()
    {
      Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CloudCookieLight));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr);
      CloudCookieLight.NativeFieldInfoPtr_MAX_CLOUDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (MAX_CLOUDS));
      CloudCookieLight.NativeFieldInfoPtr_TIME_OF_BREAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (TIME_OF_BREAK));
      CloudCookieLight.NativeFieldInfoPtr_CLOUD_QUAD_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (CLOUD_QUAD_SIZE));
      CloudCookieLight.NativeFieldInfoPtr_CookieResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (CookieResolution));
      CloudCookieLight.NativeFieldInfoPtr_CookieSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (CookieSize));
      CloudCookieLight.NativeFieldInfoPtr_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (Shader));
      CloudCookieLight.NativeFieldInfoPtr_DrawGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (DrawGizmos));
      CloudCookieLight.NativeFieldInfoPtr_DrawGameplayPointGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (DrawGameplayPointGizmos));
      CloudCookieLight.NativeFieldInfoPtr__RenderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (_RenderTexture));
      CloudCookieLight.NativeFieldInfoPtr__CloudsComputeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (_CloudsComputeBuffer));
      CloudCookieLight.NativeFieldInfoPtr__Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (_Camera));
      CloudCookieLight.NativeFieldInfoPtr__CloudManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (_CloudManager));
      CloudCookieLight.NativeFieldInfoPtr__Clouds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (_Clouds));
      CloudCookieLight.NativeFieldInfoPtr_WrapPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (WrapPoint));
      CloudCookieLight.NativeFieldInfoPtr_DotsSystemControlUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (DotsSystemControlUpdate));
      CloudCookieLight.NativeFieldInfoPtr_UseOldClouds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (UseOldClouds));
      CloudCookieLight.NativeFieldInfoPtr_forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, nameof (forward));
      CloudCookieLight.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676150);
      CloudCookieLight.NativeMethodInfoPtr_HasAllResources_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676151);
      CloudCookieLight.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676152);
      CloudCookieLight.NativeMethodInfoPtr_SetDataAndDispatch_Public_Void_NativeList_1_CloudInProjectionSpace_Int32_Int32_Boolean_Vector3_Double_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676153);
      CloudCookieLight.NativeMethodInfoPtr_GetOldWindVector_Public_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676154);
      CloudCookieLight.NativeMethodInfoPtr_InitWind_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676155);
      CloudCookieLight.NativeMethodInfoPtr_GetWindVector_Public_float2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676156);
      CloudCookieLight.NativeMethodInfoPtr_CalculateWrapPoint_Private_Double_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676157);
      CloudCookieLight.NativeMethodInfoPtr_CalculateUVFrac_Private_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676158);
      CloudCookieLight.NativeMethodInfoPtr_Dispatch_Private_Void_Int32_Int32_Boolean_Double_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676159);
      CloudCookieLight.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676160);
      CloudCookieLight.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676161);
      CloudCookieLight.NativeMethodInfoPtr_CalculateCloud_Private_Static_CloudInProjectionSpace_CloudCookieAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676162);
      CloudCookieLight.NativeMethodInfoPtr_IsCloudInFrustrum_Private_Static_Boolean_byref_CloudInProjectionSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676163);
      CloudCookieLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieLight>.NativeClassPtr, 100676164);
    }

    public CloudCookieLight(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int MAX_CLOUDS
    {
      get
      {
        int maxClouds;
        IL2CPP.il2cpp_field_static_get_value(CloudCookieLight.NativeFieldInfoPtr_MAX_CLOUDS, (void*) &maxClouds);
        return maxClouds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CloudCookieLight.NativeFieldInfoPtr_MAX_CLOUDS, (void*) &value);
      }
    }

    public static unsafe float TIME_OF_BREAK
    {
      get
      {
        float timeOfBreak;
        IL2CPP.il2cpp_field_static_get_value(CloudCookieLight.NativeFieldInfoPtr_TIME_OF_BREAK, (void*) &timeOfBreak);
        return timeOfBreak;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CloudCookieLight.NativeFieldInfoPtr_TIME_OF_BREAK, (void*) &value);
      }
    }

    public static unsafe int CLOUD_QUAD_SIZE
    {
      get
      {
        int cloudQuadSize;
        IL2CPP.il2cpp_field_static_get_value(CloudCookieLight.NativeFieldInfoPtr_CLOUD_QUAD_SIZE, (void*) &cloudQuadSize);
        return cloudQuadSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CloudCookieLight.NativeFieldInfoPtr_CLOUD_QUAD_SIZE, (void*) &value);
      }
    }

    public unsafe int CookieResolution
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_CookieResolution));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_CookieResolution)) = value;
      }
    }

    public unsafe int CookieSize
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_CookieSize));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_CookieSize)) = value;
      }
    }

    public unsafe ComputeShader Shader
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_Shader));
        return pointer == IntPtr.Zero ? (ComputeShader) null : new ComputeShader(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_Shader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool DrawGizmos
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_DrawGizmos));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_DrawGizmos)) = value;
      }
    }

    public unsafe bool DrawGameplayPointGizmos
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_DrawGameplayPointGizmos));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_DrawGameplayPointGizmos)) = value;
      }
    }

    public unsafe RenderTexture _RenderTexture
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr__RenderTexture));
        return pointer == IntPtr.Zero ? (RenderTexture) null : new RenderTexture(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr__RenderTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ComputeBuffer _CloudsComputeBuffer
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr__CloudsComputeBuffer));
        return pointer == IntPtr.Zero ? (ComputeBuffer) null : new ComputeBuffer(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr__CloudsComputeBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Camera _Camera
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr__Camera));
        return pointer == IntPtr.Zero ? (Camera) null : new Camera(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr__Camera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CloudManager _CloudManager
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr__CloudManager));
        return pointer == IntPtr.Zero ? (CloudManager) null : new CloudManager(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr__CloudManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<CloudInProjectionSpace> _Clouds
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr__Clouds));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<CloudInProjectionSpace>) null : new Il2CppStructArray<CloudInProjectionSpace>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr__Clouds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe double2 WrapPoint
    {
      get
      {
        return *(double2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_WrapPoint));
      }
      [param: In] set
      {
        *(double2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_WrapPoint)) = value;
      }
    }

    public unsafe bool DotsSystemControlUpdate
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_DotsSystemControlUpdate));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_DotsSystemControlUpdate)) = value;
      }
    }

    public static unsafe bool UseOldClouds
    {
      get
      {
        bool useOldClouds;
        IL2CPP.il2cpp_field_static_get_value(CloudCookieLight.NativeFieldInfoPtr_UseOldClouds, (void*) &useOldClouds);
        return useOldClouds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CloudCookieLight.NativeFieldInfoPtr_UseOldClouds, (void*) &value);
      }
    }

    public unsafe float3 forward
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_forward));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieLight.NativeFieldInfoPtr_forward)) = value;
      }
    }
  }
}
