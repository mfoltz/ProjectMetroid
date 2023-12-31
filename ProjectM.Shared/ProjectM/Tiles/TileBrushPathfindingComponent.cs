// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileBrushPathfindingComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Pathfinding;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Tiles
{
  public class TileBrushPathfindingComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TerrainType;
    private static readonly IntPtr NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe TileBrushType BrushType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushPathfindingComponent.NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TileBrushType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793435, XrefRangeEnd = 793438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ITileData GetData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushPathfindingComponent.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ITileData) null : new ITileData(pointer);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileBrushPathfindingComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileBrushPathfindingComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileBrushPathfindingComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileBrushPathfindingComponent()
    {
      Il2CppClassPointerStore<TileBrushPathfindingComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileBrushPathfindingComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBrushPathfindingComponent>.NativeClassPtr);
      TileBrushPathfindingComponent.NativeFieldInfoPtr_TerrainType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushPathfindingComponent>.NativeClassPtr, nameof (TerrainType));
      TileBrushPathfindingComponent.NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushPathfindingComponent>.NativeClassPtr, 100669885);
      TileBrushPathfindingComponent.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushPathfindingComponent>.NativeClassPtr, 100669886);
      TileBrushPathfindingComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushPathfindingComponent>.NativeClassPtr, 100669887);
    }

    public TileBrushPathfindingComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TerrainType TerrainType
    {
      get
      {
        return *(TerrainType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushPathfindingComponent.NativeFieldInfoPtr_TerrainType));
      }
      [param: In] set
      {
        *(TerrainType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushPathfindingComponent.NativeFieldInfoPtr_TerrainType)) = value;
      }
    }
  }
}
