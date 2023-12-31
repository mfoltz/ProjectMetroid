// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.BusStopId
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct BusStopId
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Chunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_BusStopGuid;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TerrainChunk_AssetGuid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BusStopId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public TerrainChunk Chunk;
    [FieldOffset(8)]
    public AssetGuid BusStopGuid;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 630817, RefRangeEnd = 630818, XrefRangeStart = 630817, XrefRangeEnd = 630818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BusStopId(TerrainChunk chunk, AssetGuid busStopGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &busStopGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BusStopId.NativeMethodInfoPtr__ctor_Public_Void_TerrainChunk_AssetGuid_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768228, XrefRangeEnd = 768229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(BusStopId other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BusStopId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BusStopId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768229, XrefRangeEnd = 768232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BusStopId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768232, XrefRangeEnd = 768234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BusStopId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BusStopId()
    {
      Il2CppClassPointerStore<BusStopId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (BusStopId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BusStopId>.NativeClassPtr);
      BusStopId.NativeFieldInfoPtr_Chunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BusStopId>.NativeClassPtr, nameof (Chunk));
      BusStopId.NativeFieldInfoPtr_BusStopGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BusStopId>.NativeClassPtr, nameof (BusStopGuid));
      BusStopId.NativeMethodInfoPtr__ctor_Public_Void_TerrainChunk_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusStopId>.NativeClassPtr, 100667966);
      BusStopId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BusStopId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusStopId>.NativeClassPtr, 100667967);
      BusStopId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusStopId>.NativeClassPtr, 100667968);
      BusStopId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusStopId>.NativeClassPtr, 100667969);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BusStopId>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
