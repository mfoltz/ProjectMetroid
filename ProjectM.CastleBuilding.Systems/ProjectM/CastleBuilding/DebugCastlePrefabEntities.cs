// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.DebugCastlePrefabEntities
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DebugCastlePrefabEntities
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeart;
    private static readonly System.IntPtr NativeFieldInfoPtr_Floor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Wall;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pillar;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_DebugCastlePrefabs_byref_PrefabLookupMap_0;
    [FieldOffset(0)]
    public readonly Entity CastleHeart;
    [FieldOffset(8)]
    public readonly Entity Floor;
    [FieldOffset(16)]
    public readonly Entity Wall;
    [FieldOffset(24)]
    public readonly Entity Pillar;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194608, XrefRangeEnd = 1194612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugCastlePrefabEntities(
      [In] ref DebugCastlePrefabs prefabGuids,
      [In] ref PrefabLookupMap lookupMap)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref prefabGuids;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lookupMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugCastlePrefabEntities.NativeMethodInfoPtr__ctor_Public_Void_byref_DebugCastlePrefabs_byref_PrefabLookupMap_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugCastlePrefabEntities()
    {
      Il2CppClassPointerStore<DebugCastlePrefabEntities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding", nameof (DebugCastlePrefabEntities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugCastlePrefabEntities>.NativeClassPtr);
      DebugCastlePrefabEntities.NativeFieldInfoPtr_CastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCastlePrefabEntities>.NativeClassPtr, nameof (CastleHeart));
      DebugCastlePrefabEntities.NativeFieldInfoPtr_Floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCastlePrefabEntities>.NativeClassPtr, nameof (Floor));
      DebugCastlePrefabEntities.NativeFieldInfoPtr_Wall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCastlePrefabEntities>.NativeClassPtr, nameof (Wall));
      DebugCastlePrefabEntities.NativeFieldInfoPtr_Pillar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCastlePrefabEntities>.NativeClassPtr, nameof (Pillar));
      DebugCastlePrefabEntities.NativeMethodInfoPtr__ctor_Public_Void_byref_DebugCastlePrefabs_byref_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCastlePrefabEntities>.NativeClassPtr, 100663775);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugCastlePrefabEntities>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
