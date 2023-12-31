// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileCellCoordinate
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileCellCoordinate
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromWorldPosition_Public_Static_TileCellCoordinate_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromWorldPosition_Public_Static_TileCellCoordinate_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromWorldTile_Public_Static_TileCellCoordinate_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellWorldTileOffset_Public_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellWorldBounds_Public_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TileCellCoordinate_TileCellCoordinate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TileCellCoordinate_TileCellCoordinate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileCellCoordinate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public readonly int2 Id;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 791805, RefRangeEnd = 791806, XrefRangeStart = 791804, XrefRangeEnd = 791805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileCellCoordinate FromWorldPosition(float3 worldPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellCoordinate.NativeMethodInfoPtr_FromWorldPosition_Public_Static_TileCellCoordinate_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCellCoordinate*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791806, XrefRangeEnd = 791807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileCellCoordinate FromWorldPosition(float2 worldPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellCoordinate.NativeMethodInfoPtr_FromWorldPosition_Public_Static_TileCellCoordinate_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCellCoordinate*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 791807, RefRangeEnd = 791809, XrefRangeStart = 791807, XrefRangeEnd = 791807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileCellCoordinate FromWorldTile(int2 worldTile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldTile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellCoordinate.NativeMethodInfoPtr_FromWorldTile_Public_Static_TileCellCoordinate_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCellCoordinate*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileCellCoordinate(int2 id)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &id;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileCellCoordinate.NativeMethodInfoPtr__ctor_Public_Void_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 56553, RefRangeEnd = 56610, XrefRangeStart = 56553, XrefRangeEnd = 56610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileCellCoordinate(int x, int y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileCellCoordinate.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(31)]
    [CachedScanResults(RefRangeStart = 791809, RefRangeEnd = 791840, XrefRangeStart = 791809, XrefRangeEnd = 791809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetCellWorldTileOffset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellCoordinate.NativeMethodInfoPtr_GetCellWorldTileOffset_Public_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 791840, RefRangeEnd = 791842, XrefRangeStart = 791840, XrefRangeEnd = 791840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BoundsMinMax GetCellWorldBounds()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellCoordinate.NativeMethodInfoPtr_GetCellWorldBounds_Public_BoundsMinMax_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(658)]
    [CachedScanResults(RefRangeStart = 410500, RefRangeEnd = 411158, XrefRangeStart = 410500, XrefRangeEnd = 411158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(TileCellCoordinate a, TileCellCoordinate b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellCoordinate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TileCellCoordinate_TileCellCoordinate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(543)]
    [CachedScanResults(RefRangeStart = 411158, RefRangeEnd = 411701, XrefRangeStart = 411158, XrefRangeEnd = 411701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(TileCellCoordinate a, TileCellCoordinate b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellCoordinate.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TileCellCoordinate_TileCellCoordinate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 767218, RefRangeEnd = 767231, XrefRangeStart = 767218, XrefRangeEnd = 767231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(TileCellCoordinate other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellCoordinate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileCellCoordinate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791842, XrefRangeEnd = 791845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellCoordinate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 261553, RefRangeEnd = 261560, XrefRangeStart = 261553, XrefRangeEnd = 261560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellCoordinate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791845, XrefRangeEnd = 791853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TileCellCoordinate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static TileCellCoordinate()
    {
      Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileCellCoordinate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr);
      TileCellCoordinate.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, nameof (Id));
      TileCellCoordinate.NativeMethodInfoPtr_FromWorldPosition_Public_Static_TileCellCoordinate_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, 100669658);
      TileCellCoordinate.NativeMethodInfoPtr_FromWorldPosition_Public_Static_TileCellCoordinate_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, 100669659);
      TileCellCoordinate.NativeMethodInfoPtr_FromWorldTile_Public_Static_TileCellCoordinate_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, 100669660);
      TileCellCoordinate.NativeMethodInfoPtr__ctor_Public_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, 100669661);
      TileCellCoordinate.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, 100669662);
      TileCellCoordinate.NativeMethodInfoPtr_GetCellWorldTileOffset_Public_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, 100669663);
      TileCellCoordinate.NativeMethodInfoPtr_GetCellWorldBounds_Public_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, 100669664);
      TileCellCoordinate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TileCellCoordinate_TileCellCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, 100669665);
      TileCellCoordinate.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TileCellCoordinate_TileCellCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, 100669666);
      TileCellCoordinate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileCellCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, 100669667);
      TileCellCoordinate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, 100669668);
      TileCellCoordinate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, 100669669);
      TileCellCoordinate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, 100669670);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileCellCoordinate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
