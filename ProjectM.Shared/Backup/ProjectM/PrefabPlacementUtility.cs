// Decompiled with JetBrains decompiler
// Type: ProjectM.PrefabPlacementUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Physics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class PrefabPlacementUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSettingsFor_Public_Static_Boolean_GameObject_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightCollisionFlags_Public_Static_CollisionFilterFlags_GameObject_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 764982, RefRangeEnd = 764984, XrefRangeStart = 764969, XrefRangeEnd = 764982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetSettingsFor(
      GameObject gameObject,
      out TilePivotSettings pivotSettings,
      out TileSnapType snapType,
      out Nullable_Unboxed<HeightPlacementConfig> heightPlacementConfig)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref snapType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref heightPlacementConfig;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabPlacementUtility.NativeMethodInfoPtr_TryGetSettingsFor_Public_Static_Boolean_GameObject_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764984, XrefRangeEnd = 765001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CollisionFilterFlags GetHeightCollisionFlags(GameObject gameObject)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabPlacementUtility.NativeMethodInfoPtr_GetHeightCollisionFlags_Public_Static_CollisionFilterFlags_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CollisionFilterFlags*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PrefabPlacementUtility()
    {
      Il2CppClassPointerStore<PrefabPlacementUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PrefabPlacementUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabPlacementUtility>.NativeClassPtr);
      PrefabPlacementUtility.NativeMethodInfoPtr_TryGetSettingsFor_Public_Static_Boolean_GameObject_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPlacementUtility>.NativeClassPtr, 100667568);
      PrefabPlacementUtility.NativeMethodInfoPtr_GetHeightCollisionFlags_Public_Static_CollisionFilterFlags_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPlacementUtility>.NativeClassPtr, 100667569);
    }

    public PrefabPlacementUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
