// Decompiled with JetBrains decompiler
// Type: ProjectM.RotateAroundAxisSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class RotateAroundAxisSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rotation_Public_Static_quaternion_LocalToWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetScale_Public_Static_float3_float4x4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScaleBy_Public_Static_float4x4_float4x4_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invert_Public_Static_float3_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066275, XrefRangeEnd = 1066285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RotateAroundAxisSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066285, XrefRangeEnd = 1066297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RotateAroundAxisSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1066315, RefRangeEnd = 1066316, XrefRangeStart = 1066297, XrefRangeEnd = 1066315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe quaternion Rotation(LocalToWorld localToWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localToWorld;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxisSystem.NativeMethodInfoPtr_Rotation_Public_Static_quaternion_LocalToWorld_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(quaternion*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066316, XrefRangeEnd = 1066319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 GetScale(float4x4 matrix)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &matrix;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxisSystem.NativeMethodInfoPtr_GetScale_Public_Static_float3_float4x4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066319, XrefRangeEnd = 1066327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float4x4 ScaleBy(float4x4 matrix, float3 scale)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &matrix;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxisSystem.NativeMethodInfoPtr_ScaleBy_Public_Static_float4x4_float4x4_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float4x4*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066327, XrefRangeEnd = 1066335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 Invert(float3 f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &f;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxisSystem.NativeMethodInfoPtr_Invert_Public_Static_float3_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RotateAroundAxisSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotateAroundAxisSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RotateAroundAxisSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RotateAroundAxisSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RotateAroundAxisSystem()
    {
      Il2CppClassPointerStore<RotateAroundAxisSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RotateAroundAxisSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateAroundAxisSystem>.NativeClassPtr);
      RotateAroundAxisSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxisSystem>.NativeClassPtr, nameof (_Query));
      RotateAroundAxisSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxisSystem>.NativeClassPtr, 100683834);
      RotateAroundAxisSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxisSystem>.NativeClassPtr, 100683835);
      RotateAroundAxisSystem.NativeMethodInfoPtr_Rotation_Public_Static_quaternion_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxisSystem>.NativeClassPtr, 100683836);
      RotateAroundAxisSystem.NativeMethodInfoPtr_GetScale_Public_Static_float3_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxisSystem>.NativeClassPtr, 100683837);
      RotateAroundAxisSystem.NativeMethodInfoPtr_ScaleBy_Public_Static_float4x4_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxisSystem>.NativeClassPtr, 100683838);
      RotateAroundAxisSystem.NativeMethodInfoPtr_Invert_Public_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxisSystem>.NativeClassPtr, 100683839);
      RotateAroundAxisSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxisSystem>.NativeClassPtr, 100683840);
      RotateAroundAxisSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxisSystem>.NativeClassPtr, 100683841);
    }

    public RotateAroundAxisSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateAroundAxisSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateAroundAxisSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RotateJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_RotateType;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalToWorldType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ElapsedTime;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<RotateAroundAxis> RotateType;
      [FieldOffset(32)]
      public ComponentTypeHandle<LocalToWorld> LocalToWorldType;
      [FieldOffset(64)]
      public double ElapsedTime;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066240, XrefRangeEnd = 1066275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RotateAroundAxisSystem.RotateJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RotateJob()
      {
        Il2CppClassPointerStore<RotateAroundAxisSystem.RotateJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RotateAroundAxisSystem>.NativeClassPtr, nameof (RotateJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateAroundAxisSystem.RotateJob>.NativeClassPtr);
        RotateAroundAxisSystem.RotateJob.NativeFieldInfoPtr_RotateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxisSystem.RotateJob>.NativeClassPtr, nameof (RotateType));
        RotateAroundAxisSystem.RotateJob.NativeFieldInfoPtr_LocalToWorldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxisSystem.RotateJob>.NativeClassPtr, nameof (LocalToWorldType));
        RotateAroundAxisSystem.RotateJob.NativeFieldInfoPtr_ElapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxisSystem.RotateJob>.NativeClassPtr, nameof (ElapsedTime));
        RotateAroundAxisSystem.RotateJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxisSystem.RotateJob>.NativeClassPtr, 100683842);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RotateAroundAxisSystem.RotateJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
