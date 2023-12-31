// Decompiled with JetBrains decompiler
// Type: ProjectM.DebugHelper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public static class DebugHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_LogIfNaN_Public_Static_Void_float3_Int32_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogIfNaN_Public_Static_Void_quaternion_Int32_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogIfNaN_Public_Static_Void_Single_Int32_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogIfNaN_Public_Static_Void_float3_Int32_Boolean_ComponentDataFromEntity_1_PrefabGUID_Entity_0;

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 764347, RefRangeEnd = 764375, XrefRangeStart = 764318, XrefRangeEnd = 764347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void LogIfNaN(float3 value, int id, bool isServer, PrefabGUID reference = default (PrefabGUID))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isServer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &reference;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugHelper.NativeMethodInfoPtr_LogIfNaN_Public_Static_Void_float3_Int32_Boolean_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 764405, RefRangeEnd = 764406, XrefRangeStart = 764375, XrefRangeEnd = 764405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void LogIfNaN(
      quaternion value,
      int id,
      bool isServer,
      PrefabGUID reference = default (PrefabGUID))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isServer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &reference;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugHelper.NativeMethodInfoPtr_LogIfNaN_Public_Static_Void_quaternion_Int32_Boolean_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764406, XrefRangeEnd = 764433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void LogIfNaN(float value, int id, bool isServer, PrefabGUID reference = default (PrefabGUID))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isServer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &reference;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugHelper.NativeMethodInfoPtr_LogIfNaN_Public_Static_Void_Single_Int32_Boolean_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 764472, RefRangeEnd = 764474, XrefRangeStart = 764433, XrefRangeEnd = 764472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void LogIfNaN(
      float3 value,
      int id,
      bool isServer,
      ComponentDataFromEntity<PrefabGUID> getPrefabGUID,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isServer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getPrefabGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugHelper.NativeMethodInfoPtr_LogIfNaN_Public_Static_Void_float3_Int32_Boolean_ComponentDataFromEntity_1_PrefabGUID_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugHelper()
    {
      Il2CppClassPointerStore<DebugHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DebugHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugHelper>.NativeClassPtr);
      DebugHelper.NativeMethodInfoPtr_LogIfNaN_Public_Static_Void_float3_Int32_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHelper>.NativeClassPtr, 100667522);
      DebugHelper.NativeMethodInfoPtr_LogIfNaN_Public_Static_Void_quaternion_Int32_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHelper>.NativeClassPtr, 100667523);
      DebugHelper.NativeMethodInfoPtr_LogIfNaN_Public_Static_Void_Single_Int32_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHelper>.NativeClassPtr, 100667524);
      DebugHelper.NativeMethodInfoPtr_LogIfNaN_Public_Static_Void_float3_Int32_Boolean_ComponentDataFromEntity_1_PrefabGUID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHelper>.NativeClassPtr, 100667525);
    }

    public DebugHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
