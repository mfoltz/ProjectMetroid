// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.LightningStormLightSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

#nullable disable
namespace ProjectM.LightningStorm
{
  public class LightningStormLightSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Lightning;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalLightData;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerSpotlight;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultPlayerSpotlightShadows;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_LightningFrom;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentLightning;
    private static readonly System.IntPtr NativeFieldInfoPtr_ViewportPoints;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateLight_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LightningUntil_Private_get_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasLightning_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetLightning_Public_Void_LightningLight_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLight_Private_Boolean_HybridCameraData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    public unsafe double LightningUntil
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.NativeMethodInfoPtr_get_LightningUntil_Private_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(double*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool HasLightning
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115051, XrefRangeEnd = 1115053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.NativeMethodInfoPtr_get_HasLightning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115053, XrefRangeEnd = 1115062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetLightning(LightningLight lightning, float3 euler)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &lightning;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &euler;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.NativeMethodInfoPtr_SetLightning_Public_Void_LightningLight_float3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115062, XrefRangeEnd = 1115086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LightningStormLightSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115086, XrefRangeEnd = 1115096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LightningStormLightSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1115130, RefRangeEnd = 1115131, XrefRangeStart = 1115096, XrefRangeEnd = 1115130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool UpdateLight(HybridCameraData cameraData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &cameraData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.NativeMethodInfoPtr_UpdateLight_Private_Boolean_HybridCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LightningStormLightSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115131, XrefRangeEnd = 1115148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LightningStormLightSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1115152, RefRangeEnd = 1115153, XrefRangeStart = 1115148, XrefRangeEnd = 1115152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LightningStormLightSystem()
    {
      Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (LightningStormLightSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr);
      LightningStormLightSystem.NativeFieldInfoPtr_Lightning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, nameof (Lightning));
      LightningStormLightSystem.NativeFieldInfoPtr_AdditionalLightData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, nameof (AdditionalLightData));
      LightningStormLightSystem.NativeFieldInfoPtr_PlayerSpotlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, nameof (PlayerSpotlight));
      LightningStormLightSystem.NativeFieldInfoPtr_DefaultPlayerSpotlightShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, nameof (DefaultPlayerSpotlightShadows));
      LightningStormLightSystem.NativeFieldInfoPtr_CurveCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, nameof (CurveCollectionSystem));
      LightningStormLightSystem.NativeFieldInfoPtr_LightningFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, nameof (LightningFrom));
      LightningStormLightSystem.NativeFieldInfoPtr_CurrentLightning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, nameof (CurrentLightning));
      LightningStormLightSystem.NativeFieldInfoPtr_ViewportPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, nameof (ViewportPoints));
      LightningStormLightSystem.NativeFieldInfoPtr___UpdateLight_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, "<>UpdateLight_LambdaJob0_profilerMarker");
      LightningStormLightSystem.NativeMethodInfoPtr_get_LightningUntil_Private_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, 100688286);
      LightningStormLightSystem.NativeMethodInfoPtr_get_HasLightning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, 100688287);
      LightningStormLightSystem.NativeMethodInfoPtr_SetLightning_Public_Void_LightningLight_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, 100688288);
      LightningStormLightSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, 100688289);
      LightningStormLightSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, 100688290);
      LightningStormLightSystem.NativeMethodInfoPtr_UpdateLight_Private_Boolean_HybridCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, 100688291);
      LightningStormLightSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, 100688292);
      LightningStormLightSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, 100688294);
      LightningStormLightSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, 100688295);
    }

    public LightningStormLightSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Light Lightning
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr_Lightning));
        return pointer == System.IntPtr.Zero ? (Light) null : new Light(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr_Lightning), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HDAdditionalLightData AdditionalLightData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr_AdditionalLightData));
        return pointer == System.IntPtr.Zero ? (HDAdditionalLightData) null : new HDAdditionalLightData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr_AdditionalLightData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Light PlayerSpotlight
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr_PlayerSpotlight));
        return pointer == System.IntPtr.Zero ? (Light) null : new Light(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr_PlayerSpotlight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LightShadows DefaultPlayerSpotlightShadows
    {
      get
      {
        return *(LightShadows*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr_DefaultPlayerSpotlightShadows));
      }
      [param: In] set
      {
        *(LightShadows*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr_DefaultPlayerSpotlightShadows)) = value;
      }
    }

    public unsafe CurveCollectionSystem CurveCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr_CurveCollectionSystem));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr_CurveCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe double LightningFrom
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr_LightningFrom));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr_LightningFrom)) = value;
      }
    }

    public unsafe LightningLight CurrentLightning
    {
      get
      {
        return *(LightningLight*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr_CurrentLightning));
      }
      [param: In] set
      {
        *(LightningLight*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr_CurrentLightning)) = value;
      }
    }

    public static unsafe Il2CppStructArray<float3> ViewportPoints
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(LightningStormLightSystem.NativeFieldInfoPtr_ViewportPoints, (void*) &num);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float3>) null : new Il2CppStructArray<float3>(nativeObject);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LightningStormLightSystem.NativeFieldInfoPtr_ViewportPoints, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProfilerMarker __UpdateLight_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr___UpdateLight_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormLightSystem.NativeFieldInfoPtr___UpdateLight_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.LightningStorm.LightningStormLightSystem/<>c__DisplayClass15_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass15_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_rotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_frustumViewport;
      private static readonly System.IntPtr NativeFieldInfoPtr_cameraData;
      private static readonly System.IntPtr NativeFieldInfoPtr_depthOffset;
      private static readonly System.IntPtr NativeFieldInfoPtr_lightPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_lightBoxSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_lightFrustumSizing;
      private static readonly System.IntPtr NativeFieldInfoPtr_lightMinRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_time;
      private static readonly System.IntPtr NativeFieldInfoPtr_fromTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_intensity;
      private static readonly System.IntPtr NativeFieldInfoPtr_lightning;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveCollection;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateLight_b__0_Internal_Void_0;
      [FieldOffset(0)]
      public quaternion rotation;
      [FieldOffset(16)]
      public float3 frustumViewport;
      [FieldOffset(28)]
      public HybridCameraData cameraData;
      [FieldOffset(212)]
      public float depthOffset;
      [FieldOffset(216)]
      public float3 lightPosition;
      [FieldOffset(228)]
      public float3 lightBoxSize;
      [FieldOffset(240)]
      public LightningLightBoxFrustumSizing lightFrustumSizing;
      [FieldOffset(244)]
      public float lightMinRange;
      [FieldOffset(248)]
      public double time;
      [FieldOffset(256)]
      public double fromTime;
      [FieldOffset(264)]
      public float intensity;
      [FieldOffset(268)]
      public LightningLight lightning;
      [FieldOffset(296)]
      public CurveCollection curveCollection;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass15_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateLight_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__UpdateLight_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass15_0()
      {
        Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, "<>c__DisplayClass15_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr);
        LightningStormLightSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (rotation));
        LightningStormLightSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_frustumViewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (frustumViewport));
        LightningStormLightSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (cameraData));
        LightningStormLightSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_depthOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (depthOffset));
        LightningStormLightSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_lightPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (lightPosition));
        LightningStormLightSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_lightBoxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (lightBoxSize));
        LightningStormLightSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_lightFrustumSizing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (lightFrustumSizing));
        LightningStormLightSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_lightMinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (lightMinRange));
        LightningStormLightSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (time));
        LightningStormLightSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_fromTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (fromTime));
        LightningStormLightSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (intensity));
        LightningStormLightSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_lightning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (lightning));
        LightningStormLightSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_curveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (curveCollection));
        LightningStormLightSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, 100688296);
        LightningStormLightSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__UpdateLight_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, 100688297);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass15_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.LightningStorm.LightningStormLightSystem/ProjectM.LightningStorm.<>c__DisplayClass_UpdateLight_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateLight_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_rotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_frustumViewport;
      private static readonly System.IntPtr NativeFieldInfoPtr_cameraData;
      private static readonly System.IntPtr NativeFieldInfoPtr_depthOffset;
      private static readonly System.IntPtr NativeFieldInfoPtr_lightPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_lightBoxSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_lightFrustumSizing;
      private static readonly System.IntPtr NativeFieldInfoPtr_lightMinRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_time;
      private static readonly System.IntPtr NativeFieldInfoPtr_fromTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_lightning;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_intensity;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormLightSystem_byref___c__DisplayClass15_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public quaternion rotation;
      [FieldOffset(16)]
      public float3 frustumViewport;
      [FieldOffset(28)]
      public HybridCameraData cameraData;
      [FieldOffset(212)]
      public float depthOffset;
      [FieldOffset(216)]
      public float3 lightPosition;
      [FieldOffset(228)]
      public float3 lightBoxSize;
      [FieldOffset(240)]
      public LightningLightBoxFrustumSizing lightFrustumSizing;
      [FieldOffset(244)]
      public float lightMinRange;
      [FieldOffset(248)]
      public double time;
      [FieldOffset(256)]
      public double fromTime;
      [FieldOffset(264)]
      public LightningLight lightning;
      [FieldOffset(288)]
      public CurveCollection curveCollection;
      [FieldOffset(304)]
      public float intensity;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115017, XrefRangeEnd = 1115033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115033, RefRangeEnd = 1115034, XrefRangeStart = 1115033, XrefRangeEnd = 1115033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref LightningStormLightSystem.__c__DisplayClass15_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115034, RefRangeEnd = 1115035, XrefRangeStart = 1115034, XrefRangeEnd = 1115034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref LightningStormLightSystem.__c__DisplayClass15_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115036, RefRangeEnd = 1115037, XrefRangeStart = 1115035, XrefRangeEnd = 1115036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115038, RefRangeEnd = 1115039, XrefRangeStart = 1115037, XrefRangeEnd = 1115038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        LightningStormLightSystem componentSystem,
        ref LightningStormLightSystem.__c__DisplayClass15_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormLightSystem_byref___c__DisplayClass15_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115039, XrefRangeEnd = 1115043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115050, RefRangeEnd = 1115051, XrefRangeStart = 1115043, XrefRangeEnd = 1115050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateLight_LambdaJob0()
      {
        Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormLightSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateLight_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr);
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (rotation));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_frustumViewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (frustumViewport));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (cameraData));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_depthOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (depthOffset));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_lightPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (lightPosition));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_lightBoxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (lightBoxSize));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_lightFrustumSizing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (lightFrustumSizing));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_lightMinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (lightMinRange));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (time));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_fromTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (fromTime));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_lightning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (lightning));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_curveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (curveCollection));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (intensity));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, 100688298);
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, 100688299);
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, 100688300);
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, 100688301);
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormLightSystem_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, 100688302);
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, 100688303);
        LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, 100688304);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormLightSystem/ProjectM.LightningStorm.<>c__DisplayClass_UpdateLight_LambdaJob0/ProjectM.LightningStorm.RunWithoutJobSystem_0000579A$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 506273, RefRangeEnd = 506274, XrefRangeStart = 506273, XrefRangeEnd = 506274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          void* jobData,
          Il2CppSystem.AsyncCallback _param2,
          Il2CppSystem.Object _param3)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000579A$PostfixBurstDelegate");
          LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100688305);
          LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100688306);
          LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100688307);
          LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100688308);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormLightSystem/ProjectM.LightningStorm.<>c__DisplayClass_UpdateLight_LambdaJob0/ProjectM.LightningStorm.RunWithoutJobSystem_0000579A$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114942, XrefRangeEnd = 1114956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114956, XrefRangeEnd = 1114974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114974, XrefRangeEnd = 1114989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115016, RefRangeEnd = 1115017, XrefRangeStart = 1114989, XrefRangeEnd = 1115016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000579A$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688309);
          LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688310);
          LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688311);
          LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688312);
          LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688314);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormLightSystem.__c__DisplayClass_UpdateLight_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
