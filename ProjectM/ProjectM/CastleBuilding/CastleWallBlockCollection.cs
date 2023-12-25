// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleWallBlockCollection
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleWallBlockCollection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Walls;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_NativeHashMap_2_CastleWallBlock_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetWall_Public_Boolean_CastleWallBlock_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetWall_Public_Boolean_CastleBlock_CartesianAxis_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetWall_Public_Boolean_CastleBlock_CardinalDirection_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCartesianAxis_Private_Static_CartesianAxis_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidWallDirection_Private_Static_Boolean_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JustifyWallBlock_Private_Static_Void_byref_int3_CardinalDirection_0;
    [FieldOffset(0)]
    public readonly NativeHashMap<CastleWallBlock, Entity> _Walls;

    [CallerCount(103)]
    [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleWallBlockCollection(NativeHashMap<CastleWallBlock, Entity> walls)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &walls;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleWallBlockCollection.NativeMethodInfoPtr__ctor_Internal_Void_NativeHashMap_2_CastleWallBlock_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1126781, RefRangeEnd = 1126787, XrefRangeStart = 1126778, XrefRangeEnd = 1126781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetWall(CastleWallBlock wallBlock, out Entity wallEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &wallBlock;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref wallEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlockCollection.NativeMethodInfoPtr_TryGetWall_Public_Boolean_CastleWallBlock_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126787, XrefRangeEnd = 1126790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetWall(CastleBlock block, CartesianAxis axis, out Entity wallEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &block;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axis;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref wallEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlockCollection.NativeMethodInfoPtr_TryGetWall_Public_Boolean_CastleBlock_CartesianAxis_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool TryGetWall(
      CastleBlock block,
      CardinalDirection wallDirection,
      out Entity wallEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &block;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &wallDirection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref wallEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlockCollection.NativeMethodInfoPtr_TryGetWall_Public_Boolean_CastleBlock_CardinalDirection_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe CartesianAxis GetCartesianAxis(CardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlockCollection.NativeMethodInfoPtr_GetCartesianAxis_Private_Static_CartesianAxis_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CartesianAxis*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool IsValidWallDirection(CardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlockCollection.NativeMethodInfoPtr_IsValidWallDirection_Private_Static_Boolean_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe void JustifyWallBlock(ref int3 block, CardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref block;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleWallBlockCollection.NativeMethodInfoPtr_JustifyWallBlock_Private_Static_Void_byref_int3_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleWallBlockCollection()
    {
      Il2CppClassPointerStore<CastleWallBlockCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleWallBlockCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleWallBlockCollection>.NativeClassPtr);
      CastleWallBlockCollection.NativeFieldInfoPtr__Walls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleWallBlockCollection>.NativeClassPtr, nameof (_Walls));
      CastleWallBlockCollection.NativeMethodInfoPtr__ctor_Internal_Void_NativeHashMap_2_CastleWallBlock_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlockCollection>.NativeClassPtr, 100689489);
      CastleWallBlockCollection.NativeMethodInfoPtr_TryGetWall_Public_Boolean_CastleWallBlock_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlockCollection>.NativeClassPtr, 100689490);
      CastleWallBlockCollection.NativeMethodInfoPtr_TryGetWall_Public_Boolean_CastleBlock_CartesianAxis_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlockCollection>.NativeClassPtr, 100689491);
      CastleWallBlockCollection.NativeMethodInfoPtr_TryGetWall_Public_Boolean_CastleBlock_CardinalDirection_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlockCollection>.NativeClassPtr, 100689492);
      CastleWallBlockCollection.NativeMethodInfoPtr_GetCartesianAxis_Private_Static_CartesianAxis_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlockCollection>.NativeClassPtr, 100689493);
      CastleWallBlockCollection.NativeMethodInfoPtr_IsValidWallDirection_Private_Static_Boolean_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlockCollection>.NativeClassPtr, 100689494);
      CastleWallBlockCollection.NativeMethodInfoPtr_JustifyWallBlock_Private_Static_Void_byref_int3_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlockCollection>.NativeClassPtr, 100689495);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleWallBlockCollection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
