// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileFlagEnumerator`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  public struct TileFlagEnumerator<TMaskGetter> where TMaskGetter : unmanaged
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Current_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr__HeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaskGetter;
    private static readonly System.IntPtr NativeFieldInfoPtr__CellEnumerator;
    private static readonly System.IntPtr NativeFieldInfoPtr__CellTileEnumerator;
    private static readonly System.IntPtr NativeFieldInfoPtr__CellMask;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_get_WorldTileFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Current_Private_set_Void_WorldTileFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_TileWorld_byref_TMaskGetter_BoundsMinMax_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshCurrent_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_TileFlagEnumerator_1_TMaskGetter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_ProjectM_Tiles_WorldTileFlag__get_Current_Private_Virtual_Final_New_get_WorldTileFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_Tiles_WorldTileFlag__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_WorldTileFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
    public WorldTileFlag _Current_k__BackingField;
    public readonly TileWorld _TileWorld;
    public readonly byte _HeightLevel;
    public TMaskGetter _MaskGetter;
    public IntersectingTileCellEnumerator _CellEnumerator;
    public BoundsMinMax.TileEnumerator _CellTileEnumerator;
    public BitMask2D_16x16 _CellMask;

    public unsafe WorldTileFlag Current
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 538765, RefRangeEnd = 538766, XrefRangeStart = 538765, XrefRangeEnd = 538766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_get_Current_Public_get_WorldTileFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(WorldTileFlag*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(13), CachedScanResults(RefRangeStart = 203152, RefRangeEnd = 203165, XrefRangeStart = 203152, XrefRangeEnd = 203165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_set_Current_Private_set_Void_WorldTileFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 793093, RefRangeEnd = 793096, XrefRangeStart = 793091, XrefRangeEnd = 793093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileFlagEnumerator(
      [In] ref TileWorld tileWorld,
      [In] ref TMaskGetter maskGetter,
      BoundsMinMax bounds,
      byte heightLevel)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) ref tileWorld;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) maskGetter);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr__ctor_Public_Void_byref_TileWorld_byref_TMaskGetter_BoundsMinMax_Byte_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TMaskGetter local = ref maskGetter;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TMaskGetter>(objectPointer, false, false);
      local = (TMaskGetter) valueGeneric;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793110, RefRangeEnd = 793111, XrefRangeStart = 793096, XrefRangeEnd = 793110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793111, XrefRangeEnd = 793115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshCurrent(bool hasData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &hasData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_RefreshCurrent_Private_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793115, XrefRangeEnd = 793116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Reset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 793116, RefRangeEnd = 793122, XrefRangeStart = 793116, XrefRangeEnd = 793116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileFlagEnumerator<TMaskGetter> GetEnumerator()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_GetEnumerator_Public_TileFlagEnumerator_1_TMaskGetter_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileFlagEnumerator<TMaskGetter>*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe WorldTileFlag System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CProjectM\u002ETiles\u002EWorldTileFlag\u003E\u002ECurrent
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793122, XrefRangeEnd = 793123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_ProjectM_Tiles_WorldTileFlag__get_Current_Private_Virtual_Final_New_get_WorldTileFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(WorldTileFlag*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793123, XrefRangeEnd = 793127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793127, XrefRangeEnd = 793131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator<WorldTileFlag> System_Collections_Generic_IEnumerable_ProjectM_Tiles_WorldTileFlag__GetEnumerator()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_Tiles_WorldTileFlag__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_WorldTileFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator<WorldTileFlag>) null : new IEnumerator<WorldTileFlag>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static TileFlagEnumerator()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", "TileFlagEnumerator`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMaskGetter>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr);
      TileFlagEnumerator<TMaskGetter>.NativeFieldInfoPtr__Current_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, "<Current>k__BackingField");
      TileFlagEnumerator<TMaskGetter>.NativeFieldInfoPtr__TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, nameof (_TileWorld));
      TileFlagEnumerator<TMaskGetter>.NativeFieldInfoPtr__HeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, nameof (_HeightLevel));
      TileFlagEnumerator<TMaskGetter>.NativeFieldInfoPtr__MaskGetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, nameof (_MaskGetter));
      TileFlagEnumerator<TMaskGetter>.NativeFieldInfoPtr__CellEnumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, nameof (_CellEnumerator));
      TileFlagEnumerator<TMaskGetter>.NativeFieldInfoPtr__CellTileEnumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, nameof (_CellTileEnumerator));
      TileFlagEnumerator<TMaskGetter>.NativeFieldInfoPtr__CellMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, nameof (_CellMask));
      TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_get_Current_Public_get_WorldTileFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, 100669841);
      TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_set_Current_Private_set_Void_WorldTileFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, 100669842);
      TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr__ctor_Public_Void_byref_TileWorld_byref_TMaskGetter_BoundsMinMax_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, 100669843);
      TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, 100669844);
      TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_RefreshCurrent_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, 100669845);
      TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, 100669846);
      TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_GetEnumerator_Public_TileFlagEnumerator_1_TMaskGetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, 100669847);
      TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_ProjectM_Tiles_WorldTileFlag__get_Current_Private_Virtual_Final_New_get_WorldTileFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, 100669848);
      TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, 100669849);
      TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, 100669850);
      TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_Tiles_WorldTileFlag__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_WorldTileFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, 100669851);
      TileFlagEnumerator<TMaskGetter>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, 100669852);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileFlagEnumerator<TMaskGetter>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
