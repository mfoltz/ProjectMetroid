// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.GetPlacementForEntityWork
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  public static class GetPlacementForEntityWork : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMergedPlacement_Public_Static_Result_EntityManager_ComponentSystemBase_Entity_BoundsMinMax_Boolean_int2_TileRotation_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1085572, RefRangeEnd = 1085573, XrefRangeStart = 1085525, XrefRangeEnd = 1085572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GetPlacementForEntityWork.Result GetMergedPlacement(
      EntityManager entityManager,
      ComponentSystemBase componentSystemBase,
      Entity entity,
      BoundsMinMax worldBounds,
      bool isPrefabEntity,
      int2 prefabTileOffset = default (int2),
      TileRotation prefabTileRotation = TileRotation.None)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystemBase);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &worldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isPrefabEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabTileOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabTileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementForEntityWork.NativeMethodInfoPtr_GetMergedPlacement_Public_Static_Result_EntityManager_ComponentSystemBase_Entity_BoundsMinMax_Boolean_int2_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GetPlacementForEntityWork.Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GetPlacementForEntityWork()
    {
      Il2CppClassPointerStore<GetPlacementForEntityWork>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (GetPlacementForEntityWork));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementForEntityWork>.NativeClassPtr);
      GetPlacementForEntityWork.NativeMethodInfoPtr_GetMergedPlacement_Public_Static_Result_EntityManager_ComponentSystemBase_Entity_BoundsMinMax_Boolean_int2_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementForEntityWork>.NativeClassPtr, 100685503);
    }

    public GetPlacementForEntityWork(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Result
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementArray;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public BoundsMinMax WorldBounds;
      [FieldOffset(16)]
      public NativeMultiHashMap<int3, PlacementData> PlacementArray;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1085524, RefRangeEnd = 1085525, XrefRangeStart = 1085518, XrefRangeEnd = 1085524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementForEntityWork.Result.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Result()
      {
        Il2CppClassPointerStore<GetPlacementForEntityWork.Result>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementForEntityWork>.NativeClassPtr, nameof (Result));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementForEntityWork.Result>.NativeClassPtr);
        GetPlacementForEntityWork.Result.NativeFieldInfoPtr_WorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementForEntityWork.Result>.NativeClassPtr, nameof (WorldBounds));
        GetPlacementForEntityWork.Result.NativeFieldInfoPtr_PlacementArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementForEntityWork.Result>.NativeClassPtr, nameof (PlacementArray));
        GetPlacementForEntityWork.Result.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementForEntityWork.Result>.NativeClassPtr, 100685504);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementForEntityWork.Result>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
