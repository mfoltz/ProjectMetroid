// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleWallBlock
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleWallBlock
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Axis;
    private static readonly System.IntPtr NativeFieldInfoPtr_Block;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CastleBlock_CartesianAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FloorBlockBack_Public_get_CastleBlock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FloorBlockFront_Public_get_CastleBlock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCenterPosition_Public_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCenterTile_Public_int2_TilePivotType_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightLevel_Public_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBounds_Public_BoundsMinMax_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CastleWallBlock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_CastleWallBlock_byref_CastleWallBlock_byref_int3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_CastleWallBlock_byref_CastleWallBlock_byref_int3_0;
    [FieldOffset(0)]
    public CartesianAxis Axis;
    [FieldOffset(4)]
    public CastleBlock Block;

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1126689, RefRangeEnd = 1126699, XrefRangeStart = 1126689, XrefRangeEnd = 1126689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleWallBlock(CastleBlock block, CartesianAxis axis)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &block;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axis;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleWallBlock.NativeMethodInfoPtr__ctor_Public_Void_CastleBlock_CartesianAxis_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe CastleBlock FloorBlockBack
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 1126701, RefRangeEnd = 1126708, XrefRangeStart = 1126699, XrefRangeEnd = 1126701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlock.NativeMethodInfoPtr_get_FloorBlockBack_Public_get_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe CastleBlock FloorBlockFront
    {
      [CallerCount(48), CachedScanResults(RefRangeStart = 538207, RefRangeEnd = 538255, XrefRangeStart = 538207, XrefRangeEnd = 538255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlock.NativeMethodInfoPtr_get_FloorBlockFront_Public_get_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1126710, RefRangeEnd = 1126713, XrefRangeStart = 1126708, XrefRangeEnd = 1126710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 GetCenterPosition()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlock.NativeMethodInfoPtr_GetCenterPosition_Public_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126713, XrefRangeEnd = 1126716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetCenterTile(TilePivotType tilePivot = TilePivotType.None, TileRotation tileRotation = TileRotation.None)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tilePivot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlock.NativeMethodInfoPtr_GetCenterTile_Public_int2_TilePivotType_TileRotation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1126717, RefRangeEnd = 1126718, XrefRangeStart = 1126716, XrefRangeEnd = 1126717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe byte GetHeightLevel()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlock.NativeMethodInfoPtr_GetHeightLevel_Public_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1126721, RefRangeEnd = 1126722, XrefRangeStart = 1126718, XrefRangeEnd = 1126721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BoundsMinMax GetBounds(int thickness = 2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &thickness;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlock.NativeMethodInfoPtr_GetBounds_Public_BoundsMinMax_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool Equals(CastleWallBlock other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CastleWallBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126722, XrefRangeEnd = 1126726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126726, XrefRangeEnd = 1126727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlock.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126727, XrefRangeEnd = 1126736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CastleWallBlock.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1126737, RefRangeEnd = 1126741, XrefRangeStart = 1126736, XrefRangeEnd = 1126737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleWallBlock operator +([In] ref CastleWallBlock wallBlock, [In] ref int3 offset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref wallBlock;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref offset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlock.NativeMethodInfoPtr_op_Addition_Public_Static_CastleWallBlock_byref_CastleWallBlock_byref_int3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleWallBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126741, XrefRangeEnd = 1126742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleWallBlock operator -([In] ref CastleWallBlock wallBlock, [In] ref int3 offset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref wallBlock;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref offset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWallBlock.NativeMethodInfoPtr_op_Subtraction_Public_Static_CastleWallBlock_byref_CastleWallBlock_byref_int3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleWallBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CastleWallBlock()
    {
      Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleWallBlock));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr);
      CastleWallBlock.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, nameof (Axis));
      CastleWallBlock.NativeFieldInfoPtr_Block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, nameof (Block));
      CastleWallBlock.NativeMethodInfoPtr__ctor_Public_Void_CastleBlock_CartesianAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, 100689471);
      CastleWallBlock.NativeMethodInfoPtr_get_FloorBlockBack_Public_get_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, 100689472);
      CastleWallBlock.NativeMethodInfoPtr_get_FloorBlockFront_Public_get_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, 100689473);
      CastleWallBlock.NativeMethodInfoPtr_GetCenterPosition_Public_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, 100689474);
      CastleWallBlock.NativeMethodInfoPtr_GetCenterTile_Public_int2_TilePivotType_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, 100689475);
      CastleWallBlock.NativeMethodInfoPtr_GetHeightLevel_Public_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, 100689476);
      CastleWallBlock.NativeMethodInfoPtr_GetBounds_Public_BoundsMinMax_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, 100689477);
      CastleWallBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CastleWallBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, 100689478);
      CastleWallBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, 100689479);
      CastleWallBlock.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, 100689480);
      CastleWallBlock.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, 100689481);
      CastleWallBlock.NativeMethodInfoPtr_op_Addition_Public_Static_CastleWallBlock_byref_CastleWallBlock_byref_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, 100689482);
      CastleWallBlock.NativeMethodInfoPtr_op_Subtraction_Public_Static_CastleWallBlock_byref_CastleWallBlock_byref_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, 100689483);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleWallBlock>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
