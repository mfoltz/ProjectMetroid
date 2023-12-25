// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Extensions.RayTracerSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics.Systems;

#nullable disable
namespace Unity.Physics.Extensions
{
  public class RayTracerSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_BuildPhysicsWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Requests;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Results;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddRequest_Public_RayResult_RayRequest_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926604, XrefRangeEnd = 926611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RayTracerSystem.RayResult AddRequest(RayTracerSystem.RayRequest req)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &req;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RayTracerSystem.NativeMethodInfoPtr_AddRequest_Public_RayResult_RayRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RayTracerSystem.RayResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    public unsafe bool IsEnabled
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 113040, RefRangeEnd = 113048, XrefRangeStart = 113040, XrefRangeEnd = 113048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RayTracerSystem.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926611, XrefRangeEnd = 926631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RayTracerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926631, XrefRangeEnd = 926658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RayTracerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RayTracerSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RayTracerSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RayTracerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RayTracerSystem()
    {
      Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Extensions", nameof (RayTracerSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr);
      RayTracerSystem.NativeFieldInfoPtr_m_BuildPhysicsWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr, nameof (m_BuildPhysicsWorldSystem));
      RayTracerSystem.NativeFieldInfoPtr_m_Requests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr, nameof (m_Requests));
      RayTracerSystem.NativeFieldInfoPtr_m_Results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr, nameof (m_Results));
      RayTracerSystem.NativeMethodInfoPtr_AddRequest_Public_RayResult_RayRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr, 100664014);
      RayTracerSystem.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr, 100664015);
      RayTracerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr, 100664016);
      RayTracerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr, 100664017);
      RayTracerSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr, 100664018);
      RayTracerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr, 100664019);
    }

    public RayTracerSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BuildPhysicsWorld m_BuildPhysicsWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracerSystem.NativeFieldInfoPtr_m_BuildPhysicsWorldSystem));
        return pointer == System.IntPtr.Zero ? (BuildPhysicsWorld) null : new BuildPhysicsWorld(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RayTracerSystem.NativeFieldInfoPtr_m_BuildPhysicsWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<RayTracerSystem.RayRequest> m_Requests
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracerSystem.NativeFieldInfoPtr_m_Requests));
        return pointer == System.IntPtr.Zero ? (List<RayTracerSystem.RayRequest>) null : new List<RayTracerSystem.RayRequest>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RayTracerSystem.NativeFieldInfoPtr_m_Requests), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<RayTracerSystem.RayResult> m_Results
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracerSystem.NativeFieldInfoPtr_m_Results));
        return pointer == System.IntPtr.Zero ? (List<RayTracerSystem.RayResult>) null : new List<RayTracerSystem.RayResult>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RayTracerSystem.NativeFieldInfoPtr_m_Results), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RayRequest
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PinHole;
      private static readonly System.IntPtr NativeFieldInfoPtr_ImageCenter;
      private static readonly System.IntPtr NativeFieldInfoPtr_Up;
      private static readonly System.IntPtr NativeFieldInfoPtr_Right;
      private static readonly System.IntPtr NativeFieldInfoPtr_LightDir;
      private static readonly System.IntPtr NativeFieldInfoPtr_RayLength;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlaneHalfExtents;
      private static readonly System.IntPtr NativeFieldInfoPtr_AmbientLight;
      private static readonly System.IntPtr NativeFieldInfoPtr_ImageResolution;
      private static readonly System.IntPtr NativeFieldInfoPtr_AlternateKeys;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastSphere;
      private static readonly System.IntPtr NativeFieldInfoPtr_Shadows;
      private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFilter;
      [FieldOffset(0)]
      public float3 PinHole;
      [FieldOffset(12)]
      public float3 ImageCenter;
      [FieldOffset(24)]
      public float3 Up;
      [FieldOffset(36)]
      public float3 Right;
      [FieldOffset(48)]
      public float3 LightDir;
      [FieldOffset(60)]
      public float RayLength;
      [FieldOffset(64)]
      public float PlaneHalfExtents;
      [FieldOffset(68)]
      public float AmbientLight;
      [FieldOffset(72)]
      public int ImageResolution;
      [FieldOffset(76)]
      public bool AlternateKeys;
      [FieldOffset(77)]
      public bool CastSphere;
      [FieldOffset(78)]
      public bool Shadows;
      [FieldOffset(80)]
      public CollisionFilter CollisionFilter;

      static RayRequest()
      {
        Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr, nameof (RayRequest));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr);
        RayTracerSystem.RayRequest.NativeFieldInfoPtr_PinHole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr, nameof (PinHole));
        RayTracerSystem.RayRequest.NativeFieldInfoPtr_ImageCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr, nameof (ImageCenter));
        RayTracerSystem.RayRequest.NativeFieldInfoPtr_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr, nameof (Up));
        RayTracerSystem.RayRequest.NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr, nameof (Right));
        RayTracerSystem.RayRequest.NativeFieldInfoPtr_LightDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr, nameof (LightDir));
        RayTracerSystem.RayRequest.NativeFieldInfoPtr_RayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr, nameof (RayLength));
        RayTracerSystem.RayRequest.NativeFieldInfoPtr_PlaneHalfExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr, nameof (PlaneHalfExtents));
        RayTracerSystem.RayRequest.NativeFieldInfoPtr_AmbientLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr, nameof (AmbientLight));
        RayTracerSystem.RayRequest.NativeFieldInfoPtr_ImageResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr, nameof (ImageResolution));
        RayTracerSystem.RayRequest.NativeFieldInfoPtr_AlternateKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr, nameof (AlternateKeys));
        RayTracerSystem.RayRequest.NativeFieldInfoPtr_CastSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr, nameof (CastSphere));
        RayTracerSystem.RayRequest.NativeFieldInfoPtr_Shadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr, nameof (Shadows));
        RayTracerSystem.RayRequest.NativeFieldInfoPtr_CollisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr, nameof (CollisionFilter));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RayTracerSystem.RayRequest>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RayResult
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PixelData;
      [FieldOffset(0)]
      public NativeStream PixelData;

      static RayResult()
      {
        Il2CppClassPointerStore<RayTracerSystem.RayResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr, nameof (RayResult));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayTracerSystem.RayResult>.NativeClassPtr);
        RayTracerSystem.RayResult.NativeFieldInfoPtr_PixelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RayResult>.NativeClassPtr, nameof (PixelData));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RayTracerSystem.RayResult>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RaycastJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Results;
      private static readonly System.IntPtr NativeFieldInfoPtr_Request;
      private static readonly System.IntPtr NativeFieldInfoPtr_World;
      private static readonly System.IntPtr NativeFieldInfoPtr_NumDynamicBodies;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;
      [FieldOffset(0)]
      public NativeStream.Writer Results;
      [FieldOffset(64)]
      public RayTracerSystem.RayRequest Request;
      [FieldOffset(160)]
      public CollisionWorld World;
      [FieldOffset(504)]
      public int NumDynamicBodies;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926537, XrefRangeEnd = 926604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(int index)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RayTracerSystem.RaycastJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RaycastJob()
      {
        Il2CppClassPointerStore<RayTracerSystem.RaycastJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RayTracerSystem>.NativeClassPtr, nameof (RaycastJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayTracerSystem.RaycastJob>.NativeClassPtr);
        RayTracerSystem.RaycastJob.NativeFieldInfoPtr_Results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RaycastJob>.NativeClassPtr, nameof (Results));
        RayTracerSystem.RaycastJob.NativeFieldInfoPtr_Request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RaycastJob>.NativeClassPtr, nameof (Request));
        RayTracerSystem.RaycastJob.NativeFieldInfoPtr_World = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RaycastJob>.NativeClassPtr, nameof (World));
        RayTracerSystem.RaycastJob.NativeFieldInfoPtr_NumDynamicBodies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracerSystem.RaycastJob>.NativeClassPtr, nameof (NumDynamicBodies));
        RayTracerSystem.RaycastJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracerSystem.RaycastJob>.NativeClassPtr, 100664020);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RayTracerSystem.RaycastJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
