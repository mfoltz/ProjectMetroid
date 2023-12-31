// Decompiled with JetBrains decompiler
// Type: ProjectM.TileWorldLineTraversal
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileWorldLineTraversal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CellWorldBounds_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentCellCoordinate;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentCell;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileLayer;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentHeightLevel;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CellWorldBounds_Public_get_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CellWorldBounds_Private_set_Void_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TileWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryStep_Public_Boolean_int2_Byte_byref_TileCell_byref_TileLayer_byref_int2_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUpdateCellLayer_Private_Boolean_int2_Byte_byref_Boolean_0;
    [FieldOffset(0)]
    public BoundsMinMax _CellWorldBounds_k__BackingField;
    [FieldOffset(16)]
    public readonly TileWorld _TileWorld;
    [FieldOffset(40)]
    public TileCellCoordinate _CurrentCellCoordinate;
    [FieldOffset(48)]
    public TileCell _CurrentCell;
    [FieldOffset(56)]
    public TileLayer _TileLayer;
    [FieldOffset(64)]
    public int _CurrentHeightLevel;

    public unsafe BoundsMinMax CellWorldBounds
    {
      [CallerCount(46), CachedScanResults(RefRangeStart = 257985, RefRangeEnd = 258031, XrefRangeStart = 257985, XrefRangeEnd = 258031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldLineTraversal.NativeMethodInfoPtr_get_CellWorldBounds_Public_get_BoundsMinMax_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(103), CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileWorldLineTraversal.NativeMethodInfoPtr_set_CellWorldBounds_Private_set_Void_BoundsMinMax_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 764960, RefRangeEnd = 764961, XrefRangeStart = 764960, XrefRangeEnd = 764960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileWorldLineTraversal(TileWorld tileWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileWorld;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileWorldLineTraversal.NativeMethodInfoPtr__ctor_Public_Void_TileWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 764962, RefRangeEnd = 764963, XrefRangeStart = 764961, XrefRangeEnd = 764962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryStep(
      int2 worldTile,
      byte heightLevel,
      out TileCell currentCell,
      out TileLayer currentLayer,
      out int2 cellTile,
      out bool newCellLayer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &worldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentLayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref newCellLayer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldLineTraversal.NativeMethodInfoPtr_TryStep_Public_Boolean_int2_Byte_byref_TileCell_byref_TileLayer_byref_int2_byref_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 764968, RefRangeEnd = 764969, XrefRangeStart = 764963, XrefRangeEnd = 764968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryUpdateCellLayer(int2 worldTile, byte heightLevel, out bool newCellLayer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &worldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref newCellLayer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldLineTraversal.NativeMethodInfoPtr_TryUpdateCellLayer_Private_Boolean_int2_Byte_byref_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileWorldLineTraversal()
    {
      Il2CppClassPointerStore<TileWorldLineTraversal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TileWorldLineTraversal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileWorldLineTraversal>.NativeClassPtr);
      TileWorldLineTraversal.NativeFieldInfoPtr__CellWorldBounds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldLineTraversal>.NativeClassPtr, "<CellWorldBounds>k__BackingField");
      TileWorldLineTraversal.NativeFieldInfoPtr__TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldLineTraversal>.NativeClassPtr, nameof (_TileWorld));
      TileWorldLineTraversal.NativeFieldInfoPtr__CurrentCellCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldLineTraversal>.NativeClassPtr, nameof (_CurrentCellCoordinate));
      TileWorldLineTraversal.NativeFieldInfoPtr__CurrentCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldLineTraversal>.NativeClassPtr, nameof (_CurrentCell));
      TileWorldLineTraversal.NativeFieldInfoPtr__TileLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldLineTraversal>.NativeClassPtr, nameof (_TileLayer));
      TileWorldLineTraversal.NativeFieldInfoPtr__CurrentHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldLineTraversal>.NativeClassPtr, nameof (_CurrentHeightLevel));
      TileWorldLineTraversal.NativeMethodInfoPtr_get_CellWorldBounds_Public_get_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldLineTraversal>.NativeClassPtr, 100667562);
      TileWorldLineTraversal.NativeMethodInfoPtr_set_CellWorldBounds_Private_set_Void_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldLineTraversal>.NativeClassPtr, 100667563);
      TileWorldLineTraversal.NativeMethodInfoPtr__ctor_Public_Void_TileWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldLineTraversal>.NativeClassPtr, 100667564);
      TileWorldLineTraversal.NativeMethodInfoPtr_TryStep_Public_Boolean_int2_Byte_byref_TileCell_byref_TileLayer_byref_int2_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldLineTraversal>.NativeClassPtr, 100667565);
      TileWorldLineTraversal.NativeMethodInfoPtr_TryUpdateCellLayer_Private_Boolean_int2_Byte_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldLineTraversal>.NativeClassPtr, 100667566);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileWorldLineTraversal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
